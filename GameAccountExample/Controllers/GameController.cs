using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using GameAccountExample.DAL;
using GameAccountExample.Models;
using GameAccountExample.ViewModels;

namespace GameAccountExample.Controllers
{
    public class GameController : Controller
    {
        private GameAccountDbContext db = new GameAccountDbContext();

        // GET: Game
        public async Task<ActionResult> Index()
        {
            return View(await db.Games.ToListAsync());
        }

        // GET: Game/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            // declareer een instantie van het viewmodel en koppel de juiste datasource
            var playersPerGameViewModel = new PlayersPerGameViewModel();
            playersPerGameViewModel.Game = db.Games.Where(g => g.GameID == id).Include(g => g.Users).FirstOrDefault();
            playersPerGameViewModel.Users = playersPerGameViewModel.Game.Users;

            // Docs over loading related entities
            // https://docs.microsoft.com/en-us/ef/ef6/querying/related-data


            if (playersPerGameViewModel.Game == null)
            {
                return HttpNotFound();
            }
            return View(playersPerGameViewModel);
        }

        // GET: Game/RemoveUserFromGame?gameid=1&userid=1
        public async Task<ActionResult> RemoveUserFromGame(int? gameid, int? userid)
        {
            if (gameid == null || userid == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            // declareer een instantie van het viewmodel en koppel de juiste datasource
            var playersPerGameViewModel = new PlayersPerGameViewModel();
            var theGame = db.Games.Where(g => g.GameID == gameid).Include(g => g.Users).FirstOrDefault();
            // remove the user from the game
            User userToRemove = theGame.Users.Single(u => u.UserID == userid);
            theGame.Users.Remove(userToRemove);
            db.SaveChanges();

            playersPerGameViewModel.Game = theGame;
            playersPerGameViewModel.Users = playersPerGameViewModel.Game.Users;

            if (playersPerGameViewModel.Game == null)
            {
                return HttpNotFound();
            }
            return View("Details", playersPerGameViewModel);
        }

        // GET: Game/RemoveUserFromGame?gameid=1&userid=1
        public async Task<ActionResult> AddAllUsersToGame(int? gameid)
        {
            if (gameid == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            // declareer een instantie van het viewmodel en koppel de juiste datasource
            var playersPerGameViewModel = new PlayersPerGameViewModel();
            var theGame = db.Games.Where(g => g.GameID == gameid).Include(g => g.Users).FirstOrDefault();
            // add all users
            var allUsers = db.Users.ToList<User>();
            theGame.Users = allUsers;
            db.SaveChanges();

            playersPerGameViewModel.Game = theGame;
            playersPerGameViewModel.Users = playersPerGameViewModel.Game.Users;

            if (playersPerGameViewModel.Game == null)
            {
                return HttpNotFound();
            }
            return View("Details", playersPerGameViewModel);
        }

        // GET: Game/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Game/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "GameID,GameIdentifier,Title,MinPlayers,MaxPlayers")] Game game)
        {
            if (ModelState.IsValid)
            {
                db.Games.Add(game);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(game);
        }

        // GET: Game/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Game game = await db.Games.FindAsync(id);
            if (game == null)
            {
                return HttpNotFound();
            }
            return View(game);
        }

        // POST: Game/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "GameID,GameIdentifier,Title,MinPlayers,MaxPlayers")] Game game)
        {
            if (ModelState.IsValid)
            {
                db.Entry(game).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(game);
        }

        // GET: Game/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Game game = await db.Games.FindAsync(id);
            if (game == null)
            {
                return HttpNotFound();
            }
            return View(game);
        }

        // POST: Game/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            Game game = await db.Games.FindAsync(id);
            db.Games.Remove(game);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
