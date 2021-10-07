using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using GameAccountExample.Models;
using System.Collections.Generic;

namespace UnitTest
{
    [TestClass]
    public class GameModelTest
    {
        [TestMethod]
        public void TestHappyFlowAdd()
        {
            // arrange
            Game theGame = new Game();
            theGame.GameID = 1;
            theGame.GameIdentifier = "Testgame";
            theGame.MinPlayers = 2;
            theGame.MaxPlayers = 10;
            theGame.Users = new List<User>();

            List<User> usersToAdd = new List<User>();
            for (int i = 0; i < 5; i++)
            {
                usersToAdd.Add(new User());
            }

            // act
            var result = theGame.AddUsersToGame(usersToAdd);

            // assert
            // ik verwacht true
            Assert.IsTrue(result, "Toevoegen van 5 gebruikers niet gelukt terwijl dit wel zou moeten");
        }

        [TestMethod]
        public void AddToManyParticipants()
        {
            // arrange
            Game theGame = new Game();
            theGame.GameID = 1;
            theGame.GameIdentifier = "Testgame";
            theGame.MinPlayers = 2;
            theGame.MaxPlayers = 10;
            theGame.Users = new List<User>();

            List<User> usersToAdd = new List<User>();
            for (int i = 0; i < 100; i++)
            {
                usersToAdd.Add(new User());
            }

            // act
            var result = theGame.AddUsersToGame(usersToAdd);

            // assert
            // ik verwacht true
            Assert.IsFalse(result, "Toevoegen van 100 gebruikers mag niet aan een spel van minder spelers");
        }
    }
}
