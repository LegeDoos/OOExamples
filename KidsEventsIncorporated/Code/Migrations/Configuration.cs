namespace KidsEventsIncorporated.Migrations
{
    using KidsEventsIncorporated.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<KidsEventsIncorporated.DAL.KEIDatabaseContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(KidsEventsIncorporated.DAL.KEIDatabaseContext context)
        {
            //  This method will be called after migrating to the latest version.
            List<User> userList = new List<User>();
            userList.Add(new Worker() { Username = "VaughnC", Pass = "fantastic", Lastname = "Cortez Vaughn", Email = "tattooman@verizon.net", AddressLine1 = "329 Bedford Rd.", AddressLine2 = "Clinton, MD 20735" });
            userList.Add(new Worker() { Username = "AcevedoC", Pass = "acceptable", Lastname = "Caden Acevedo", Email = "juliano@icloud.com", AddressLine1 = "9184 S. San Carlos Court", AddressLine2 = "Willingboro, NJ 08046" });
            userList.Add(new Worker() { Username = "GutierrezO", Pass = "upbeat", Lastname = "Oliver Gutierrez", Email = "dmiller@yahoo.ca", AddressLine1 = "912 NE. Sycamore Street", AddressLine2 = "Grand Island, NE 68801" });
            userList.Add(new Worker() { Username = "EdwardsS", Pass = "undesirable", Lastname = "Sloane Edwards", Email = "parsimony@hotmail.com", AddressLine1 = "34 Saxton Ave.", AddressLine2 = "Ladson, SC 29456" });
            userList.Add(new Worker() { Username = "VillaE", Pass = "industrious", Lastname = "Eddie Villa", Email = "gator@aol.com", AddressLine1 = "8704 Corona Street", AddressLine2 = "Graham, NC 27253" });
            userList.Add(new Worker() { Username = "CarpenterN", Pass = "melodic", Lastname = "Nathaly Carpenter", Email = "gregh@yahoo.ca", AddressLine1 = "7973 Pilgrim Street", AddressLine2 = "Groton, CT 06340" });
            userList.Add(new Worker() { Username = "DunlapT", Pass = "secretive", Lastname = "Tyrese Dunlap", Email = "jrkorson@icloud.com", AddressLine1 = "368 Fairway Drive", AddressLine2 = "Olney, MD 20832" });
            userList.Add(new Worker() { Username = "HamptonB", Pass = "plastic", Lastname = "Brooke Hampton", Email = "ilyaz@att.net", AddressLine1 = "7482 Primrose St.", AddressLine2 = "Asbury Park, NJ 07712" });
            userList.Add(new Worker() { Username = "BrooksL", Pass = "common", Lastname = "Luciano Brooks", Email = "kenja@me.com", AddressLine1 = "1 Manor St.", AddressLine2 = "Shrewsbury, MA 01545" });
            userList.Add(new Worker() { Username = "LloydJ", Pass = "perfect", Lastname = "Jamarion Lloyd", Email = "treit@verizon.net", AddressLine1 = "32 2nd Lane", AddressLine2 = "Elizabethtown, PA 17022" });
            userList.Add(new ProfessionalWorker() { Username = "LindseyC", Pass = "protective", Lastname = "Colten Lindsey", Email = "roamer@outlook.com", AddressLine1 = "7928 Rockcrest Street", AddressLine2 = "Dacula, GA 30019" });
            userList.Add(new ProfessionalWorker() { Username = "EsparzaZ", Pass = "elderly", Lastname = "Zane Esparza", Email = "kostas@yahoo.com", AddressLine1 = "373 W. Armstrong Drive", AddressLine2 = "Rockville, MD 20850" });
            userList.Add(new ProfessionalWorker() { Username = "RamirezE", Pass = "malicious", Lastname = "Ezekiel Ramirez", Email = "bmcmahon@icloud.com", AddressLine1 = "36 Branch Drive", AddressLine2 = "Mcminnville, TN 37110" });
            userList.Add(new ProfessionalWorker() { Username = "YatesS", Pass = "glorious", Lastname = "Sarai Yates", Email = "crimsane@mac.com", AddressLine1 = "9688 Valley Farms Dr.", AddressLine2 = "Antioch, TN 37013" });
            userList.Add(new Parent() { Username = "GlassM", Pass = "miniature", Lastname = "Mila Glass", Email = "meinkej@icloud.com", AddressLine1 = "7786 Wintergreen Drive", AddressLine2 = "Scotch Plains, NJ 07076" });

            userList.Add(new Parent() { Username = "ParksA", Pass = "axiomatic", Lastname = "Abram Parks", Email = "flaviog@msn.com", AddressLine1 = "29 Surrey Lane", AddressLine2 = "Rolla, MO 65401" });
            userList.Add(new Parent() { Username = "YoderA", Pass = "yummy", Lastname = "Amanda Yoder", Email = "errxn@msn.com", AddressLine1 = "338 Fairground Ave.", AddressLine2 = "Danvers, MA 01923" });
            userList.Add(new Parent() { Username = "GainesB", Pass = "efficient", Lastname = "Breanna Gaines", Email = "kohlis@yahoo.ca", AddressLine1 = "85 West Iroquois Ave.", AddressLine2 = "Cantonment, FL 32533" });
            userList.Add(new Parent() { Username = "BoydZ", Pass = "hypnotic", Lastname = "Zain Boyd", Email = "bmidd@comcast.net", AddressLine1 = "590 Dunbar Court", AddressLine2 = "Dorchester Center, MA 02124" });
            userList.Add(new Parent() { Username = "BradfordB", Pass = "accidental", Lastname = "Braden Bradford", Email = "kjohnson@comcast.net", AddressLine1 = "3 S. Harrison St.", AddressLine2 = "Neenah, WI 54956" });
            userList.Add(new Parent() { Username = "MurilloP", Pass = "cluttered", Lastname = "Pablo Murillo", Email = "nichoj@comcast.net", AddressLine1 = "7202 Bank Rd.", AddressLine2 = "Jersey City, NJ 07302" });
            userList.Add(new Parent() { Username = "ButlerK", Pass = "uninterested", Lastname = "Kailey Butler", Email = "smeier@comcast.net", AddressLine1 = "919 Branch Ave.", AddressLine2 = "Jamestown, NY 14701" });
            userList.Add(new Parent() { Username = "NorrisCa", Pass = "perpetual", Lastname = "Camron Norris", Email = "bastian@sbcglobal.net", AddressLine1 = "69 4th Dr.", AddressLine2 = "Johnston, RI 02919" });
            userList.Add(new Parent() { Username = "SuttonL", Pass = "reminiscent", Lastname = "Lia Sutton", Email = "gslondon@gmail.com", AddressLine1 = "2 East Adams St.", AddressLine2 = "Massapequa Park, NY 11762" });
            userList.Add(new Parent() { Username = "RussoM", Pass = "accessible", Lastname = "Miranda Russo", Email = "kwilliams@optonline.net", AddressLine1 = "19 Rockwell Dr.", AddressLine2 = "Saint Joseph, MI 49085" });
            userList.Add(new Parent() { Username = "HurleyN", Pass = "careful", Lastname = "Nicholas Hurley", Email = "scotfl@msn.com", AddressLine1 = "178 Locust St.", AddressLine2 = "Garland, TX 75043" });
            userList.Add(new Parent() { Username = "MasonM", Pass = "historical", Lastname = "Myles Mason", Email = "natepuri@mac.com", AddressLine1 = "32 Gregory St.", AddressLine2 = "Essex, MD 21221" });
            userList.Add(new Parent() { Username = "SteeleS", Pass = "romantic", Lastname = "Stephanie Steele", Email = "themer@live.com", AddressLine1 = "501 E. Court Street", AddressLine2 = "Lansdowne, PA 19050" });
            userList.Add(new Parent() { Username = "RamosR", Pass = "youthful", Lastname = "Ramon Ramos", Email = "wortmanj@yahoo.com", AddressLine1 = "937 Arch Rd.", AddressLine2 = "Duarte, CA 91010" });
            userList.Add(new Parent() { Username = "WhiteheadT", Pass = "flaky", Lastname = "Theodore Whitehead", Email = "british@live.com", AddressLine1 = "8288 Mill Court", AddressLine2 = "Addison, IL 60101" });
            userList.Add(new Parent() { Username = "ChangR", Pass = "meaty", Lastname = "Rogelio Chang", Email = "ismail@icloud.com", AddressLine1 = "781 Branch Dr.", AddressLine2 = "Enterprise, AL 36330" });
            userList.Add(new Parent() { Username = "FischerR", Pass = "uppity", Lastname = "Randy Fischer", Email = "marin@verizon.net", AddressLine1 = "26 Annadale Drive", AddressLine2 = "Shakopee, MN 55379" });
            userList.Add(new Parent() { Username = "BaxterA", Pass = "stereotyped", Lastname = "Alexa Baxter", Email = "munjal@me.com", AddressLine1 = "9269 E. Hickory St.", AddressLine2 = "Oak Creek, WI 53154" });
            userList.Add(new Parent() { Username = "PughK", Pass = "willing", Lastname = "Kennedi Pugh", Email = "konst@gmail.com", AddressLine1 = "22 Glen Eagles Lane", AddressLine2 = "Rockaway, NJ 07866" });
            userList.Add(new Parent() { Username = "DickersonJ", Pass = "resonant", Lastname = "Jovany Dickerson", Email = "lamprecht@icloud.com", AddressLine1 = "548 Chestnut Lane", AddressLine2 = "Buford, GA 30518" });
            userList.Add(new Parent() { Username = "MaloneJ", Pass = "maddening", Lastname = "Jorge Malone", Email = "tedrlord@yahoo.com", AddressLine1 = "7341 4th Rd.", AddressLine2 = "Herndon, VA 20170" });
            userList.Add(new Parent() { Username = "ElliottM", Pass = "adhesive", Lastname = "Markus Elliott", Email = "pierce@live.com", AddressLine1 = "684 Canal St.", AddressLine2 = "Southampton, PA 18966" });
            userList.Add(new Parent() { Username = "DillonM", Pass = "ahead", Lastname = "Melissa Dillon", Email = "oechslin@att.net", AddressLine1 = "29 Fieldstone Dr.", AddressLine2 = "Urbandale, IA 50322" });
            userList.Add(new Parent() { Username = "MatthewsD", Pass = "scared", Lastname = "Daniela Matthews", Email = "sblack@me.com", AddressLine1 = "9376 William Drive", AddressLine2 = "Hazleton, PA 18201" });
            userList.Add(new Parent() { Username = "LeblancL", Pass = "giddy", Lastname = "Leonidas Leblanc", Email = "jramio@yahoo.ca", AddressLine1 = "7919 Carson St.", AddressLine2 = "Marion, NC 28752" });
            userList.Add(new Parent() { Username = "BeanM", Pass = "unwieldy", Lastname = "Miranda Bean", Email = "sjava@aol.com", AddressLine1 = "8744 Vale Drive", AddressLine2 = "Greenville, NC 27834" });
            userList.Add(new Parent() { Username = "WatsonA", Pass = "permissible", Lastname = "Angelina Watson", Email = "joglo@verizon.net", AddressLine1 = "9165 Clark St.", AddressLine2 = "Southington, CT 06489" });
            userList.Add(new Parent() { Username = "DixonM", Pass = "doubtful", Lastname = "Melody Dixon", Email = "hyper@att.net", AddressLine1 = "9245 Linden St.", AddressLine2 = "Uniondale, NY 11553" });
            userList.Add(new Parent() { Username = "KingA", Pass = "thoughtless", Lastname = "Aleah King", Email = "pmint@yahoo.com", AddressLine1 = "8871 Plumb Branch Street", AddressLine2 = "Torrance, CA 90505" });
            userList.Add(new Parent() { Username = "CervantesR", Pass = "naughty", Lastname = "Ronan Cervantes", Email = "sassen@live.com", AddressLine1 = "24 Campfire Rd.", AddressLine2 = "Ithaca, NY 14850" });
            userList.Add(new Parent() { Username = "MosleyA", Pass = "disastrous", Lastname = "Amare Mosley", Email = "alhajj@msn.com", AddressLine1 = "598 Gainsway Street", AddressLine2 = "Zionsville, IN 46077" });
            userList.Add(new Parent() { Username = "DillonT", Pass = "numberless", Lastname = "Tyrone Dillon", Email = "muadip@gmail.com", AddressLine1 = "19 Lawrence Ave.", AddressLine2 = "Elkridge, MD 21075" });
            userList.Add(new Parent() { Username = "BlakeT", Pass = "natural", Lastname = "Trenton Blake", Email = "keutzer@verizon.net", AddressLine1 = "7404 Redwood St.", AddressLine2 = "Powell, TN 37849" });
            userList.Add(new Parent() { Username = "MorrisonK", Pass = "ratty", Lastname = "Kenneth Morrison", Email = "yxing@optonline.net", AddressLine1 = "978 Sherman Dr.", AddressLine2 = "Alexandria, VA 22304" });
            userList.Add(new Parent() { Username = "KramerN", Pass = "bloody", Lastname = "Nathaniel Kramer", Email = "sblack@sbcglobal.net", AddressLine1 = "1 Brookside Dr.", AddressLine2 = "Calumet City, IL 60409" });
            userList.Add(new Parent() { Username = "OwenJ", Pass = "unhealthy", Lastname = "John Owen", Email = "dburrows@optonline.net", AddressLine1 = "86 Orange St.", AddressLine2 = "Riverview, FL 33569" });
            userList.Add(new Parent() { Username = "TownsendR", Pass = "sharp", Lastname = "Reese Townsend", Email = "klaudon@gmail.com", AddressLine1 = "50 Bellevue Street", AddressLine2 = "Deerfield Beach, FL 33442" });
            userList.Add(new Parent() { Username = "VillanuevaR", Pass = "versed", Lastname = "Ricky Villanueva", Email = "dbindel@gmail.com", AddressLine1 = "2 10th St.", AddressLine2 = "Birmingham, AL 35209" });
            userList.Add(new Parent() { Username = "PetersonR", Pass = "gigantic", Lastname = "Rayne Peterson", Email = "paley@me.com", AddressLine1 = "459 Rockwell Street", AddressLine2 = "Corona, NY 11368" });
            userList.Add(new Parent() { Username = "McdowellG", Pass = "poor", Lastname = "Gracie Mcdowell", Email = "zavadsky@comcast.net", AddressLine1 = "935 Prospect Ave.", AddressLine2 = "Yorktown, VA 23693" });
            userList.Add(new Parent() { Username = "HenryJ", Pass = "deeply", Lastname = "Jordyn Henry", Email = "warrior@sbcglobal.net", AddressLine1 = "153 Clinton Lane", AddressLine2 = "Pembroke Pines, FL 33028" });
            userList.Add(new Parent() { Username = "NorrisC", Pass = "careless", Lastname = "Corbin Norris", Email = "yumpy@yahoo.ca", AddressLine1 = "547 SW. Purple Finch Rd.", AddressLine2 = "Fall River, MA 02720" });
            userList.Add(new Parent() { Username = "RosalesC", Pass = "vague", Lastname = "Charlie Rosales", Email = "jginspace@att.net", AddressLine1 = "3 Bradford Street", AddressLine2 = "San Lorenzo, CA 94580" });
            userList.Add(new Parent() { Username = "MoraA", Pass = "wandering", Lastname = "Angeline Mora", Email = "yxing@yahoo.com", AddressLine1 = "92 Heather Street", AddressLine2 = "East Elmhurst, NY 11369" });
            userList.Add(new Parent() { Username = "SellersA", Pass = "super", Lastname = "Armani Sellers", Email = "kuparine@comcast.net", AddressLine1 = "9368 Pilgrim Ave.", AddressLine2 = "Germantown, MD 20874" });
            userList.Add(new Parent() { Username = "FisherJ", Pass = "jittery", Lastname = "Janiyah Fisher", Email = "dburrows@outlook.com", AddressLine1 = "924 Cedar Swamp Ave.", AddressLine2 = "Garden City, NY 11530" });
            userList.Add(new Parent() { Username = "CharlesC", Pass = "direful", Lastname = "Cory Charles", Email = "themer@msn.com", AddressLine1 = "737 Pawnee Road", AddressLine2 = "Duluth, GA 30096" });
            userList.Add(new Parent() { Username = "HancockM", Pass = "smooth", Lastname = "Mikaela Hancock", Email = "tskirvin@msn.com", AddressLine1 = "7330 Marsh St.", AddressLine2 = "Pawtucket, RI 02860" });
            userList.Add(new Parent() { Username = "BanksL", Pass = "flowery", Lastname = "Lamont Banks", Email = "cisugrad@optonline.net", AddressLine1 = "9825 Circle St.", AddressLine2 = "Benton Harbor, MI 49022" });
            userList.Add(new Parent() { Username = "MillsE", Pass = "few", Lastname = "Erick Mills", Email = "jaffe@icloud.com", AddressLine1 = "10 St Louis Avenue", AddressLine2 = "Holly Springs, NC 27540" });
            userList.Add(new Parent() { Username = "OrtegaB", Pass = "ambitious", Lastname = "Brooklyn Ortega", Email = "thaljef@icloud.com", AddressLine1 = "218 Howard Dr.", AddressLine2 = "Lynn, MA 01902" });
            userList.Add(new Parent() { Username = "NguyenS", Pass = "flimsy", Lastname = "Sergio Nguyen", Email = "rafasgj@outlook.com", AddressLine1 = "9274 Rockville Street", AddressLine2 = "Longview, TX 75604" });
            userList.Add(new Parent() { Username = "HaleQ", Pass = "awake", Lastname = "Quentin Hale", Email = "yzheng@yahoo.com", AddressLine1 = "9595 S. Edgewood St.", AddressLine2 = "Henrico, VA 23228" });
            userList.Add(new Parent() { Username = "McknightL", Pass = "debonair", Lastname = "Lance Mcknight", Email = "webinc@optonline.net", AddressLine1 = "9145 Lancaster Ave.", AddressLine2 = "Simpsonville, SC 29680" });
            userList.Add(new Parent() { Username = "RichmondA", Pass = "chubby", Lastname = "Adan Richmond", Email = "ghaviv@me.com", AddressLine1 = "7997 NW. Fulton St.", AddressLine2 = "Virginia Beach, VA 23451" });
            userList.Add(new Parent() { Username = "OliverT", Pass = "steady", Lastname = "Taylor Oliver", Email = "andrewik@yahoo.ca", AddressLine1 = "651 West Pin Oak Court", AddressLine2 = "Apopka, FL 32703" });
            userList.Add(new Parent() { Username = "BoyleG", Pass = "impossible", Lastname = "German Boyle", Email = "ranasta@msn.com", AddressLine1 = "33 York Lane", AddressLine2 = "Roslindale, MA 02131" });
            userList.Add(new Parent() { Username = "GlassE", Pass = "entertaining", Lastname = "Ellen Glass", Email = "quantaman@yahoo.com", AddressLine1 = "9718 Westport St.", AddressLine2 = "Terre Haute, IN 47802" });
            userList.Add(new Parent() { Username = "GatesM", Pass = "trite", Lastname = "Mitchell Gates", Email = "sassen@icloud.com", AddressLine1 = "56 Sugar Court", AddressLine2 = "Savannah, GA 31404" });
            userList.Add(new Parent() { Username = "HurleyD", Pass = "aback", Lastname = "Diamond Hurley", Email = "raines@comcast.net", AddressLine1 = "8614 Brewery Lane", AddressLine2 = "Nottingham, MD 21236" });
            userList.Add(new Parent() { Username = "TerrellJ", Pass = "idiotic", Lastname = "Jaelynn Terrell", Email = "hakim@comcast.net", AddressLine1 = "565 South Henry Smith St.", AddressLine2 = "Norwich, CT 06360" });
            userList.Add(new Parent() { Username = "VelazquezM", Pass = "pricey", Lastname = "Moriah Velazquez", Email = "dobey@icloud.com", AddressLine1 = "1 Windsor Rd.", AddressLine2 = "Kearny, NJ 07032" });
            userList.Add(new Parent() { Username = "RowlandJ", Pass = "burly", Lastname = "Julissa Rowland", Email = "citizenl@gmail.com", AddressLine1 = "790 N. Gainsway St.", AddressLine2 = "Canyon Country, CA 91387" });
            userList.Add(new Parent() { Username = "KnappG", Pass = "tacky", Lastname = "Gary Knapp", Email = "jadavis@hotmail.com", AddressLine1 = "57 Windsor Street", AddressLine2 = "Taunton, MA 02780" });
            userList.Add(new Parent() { Username = "HayesC", Pass = "pink", Lastname = "Caitlin Hayes", Email = "skythe@mac.com", AddressLine1 = "7633 Roosevelt Street", AddressLine2 = "Mount Holly, NJ 08060" });
            userList.Add(new Parent() { Username = "McbrideA", Pass = "defeated", Lastname = "Ava Mcbride", Email = "isaacson@icloud.com", AddressLine1 = "259 Bayport Drive", AddressLine2 = "New York, NY 10002" });
            userList.Add(new Parent() { Username = "BarajasA", Pass = "huge", Lastname = "Antwan Barajas", Email = "flavell@hotmail.com", AddressLine1 = "60 Mechanic Street", AddressLine2 = "Los Angeles, CA 90008" });
            userList.Add(new Parent() { Username = "PotterJ", Pass = "guarded", Lastname = "Jakobe Potter", Email = "manuals@yahoo.ca", AddressLine1 = "8786 Race Rd.", AddressLine2 = "Sewell, NJ 08080" });
            userList.Add(new Parent() { Username = "TaylorJ", Pass = "old", Lastname = "Jay Taylor", Email = "reziac@yahoo.com", AddressLine1 = "7797 Vale Lane", AddressLine2 = "Milton, MA 02186" });
            userList.Add(new Parent() { Username = "AriasE", Pass = "anxious", Lastname = "Emilia Arias", Email = "iapetus@verizon.net", AddressLine1 = "779 Taylor St.", AddressLine2 = "Londonderry, NH 03053" });
            userList.Add(new Parent() { Username = "NicholsL", Pass = "secret", Lastname = "Londyn Nichols", Email = "sabren@live.com", AddressLine1 = "33 N. Hamilton Street", AddressLine2 = "New Baltimore, MI 48047" });
            userList.Add(new Parent() { Username = "HesterA", Pass = "crooked", Lastname = "Alison Hester", Email = "clkao@hotmail.com", AddressLine1 = "99 Valley Drive", AddressLine2 = "Wayne, NJ 07470" });
            userList.Add(new Parent() { Username = "KiddA", Pass = "dry", Lastname = "Alijah Kidd", Email = "mrsam@msn.com", AddressLine1 = "474 E. Campfire Street", AddressLine2 = "Mchenry, IL 60050" });
            userList.Add(new Parent() { Username = "GatesS", Pass = "tiny", Lastname = "Skylar Gates", Email = "dwendlan@verizon.net", AddressLine1 = "8038 Bald Hill Road", AddressLine2 = "Soddy Daisy, TN 37379" });
            userList.Add(new Parent() { Username = "SheaN", Pass = "curious", Lastname = "Nadia Shea", Email = "jwarren@live.com", AddressLine1 = "42 Church Ave.", AddressLine2 = "Onalaska, WI 54650" });
            userList.Add(new Parent() { Username = "SuarezE", Pass = "neighborly", Lastname = "Edwin Suarez", Email = "spadkins@comcast.net", AddressLine1 = "97 Augusta Lane", AddressLine2 = "Upland, CA 91784" });
            userList.Add(new Parent() { Username = "MaysJ", Pass = "large", Lastname = "Jaden Mays", Email = "delpino@outlook.com", AddressLine1 = "836 Foxrun Dr.", AddressLine2 = "Wadsworth, OH 44281" });
            userList.Add(new Parent() { Username = "ShawS", Pass = "green", Lastname = "Selena Shaw", Email = "bartak@yahoo.com", AddressLine1 = "9594 Sunset Drive", AddressLine2 = "Charlottesville, VA 22901" });
            userList.Add(new Parent() { Username = "EnglishL", Pass = "drunk", Lastname = "Laney English", Email = "cantu@live.com", AddressLine1 = "8777 Queen Street", AddressLine2 = "Baldwinsville, NY 13027" });
            userList.Add(new Parent() { Username = "HorneS", Pass = "right", Lastname = "Santos Horne", Email = "graham@icloud.com", AddressLine1 = "52 Bow Ridge Drive", AddressLine2 = "Cedar Falls, IA 50613" });
            userList.Add(new Parent() { Username = "MaxwellC", Pass = "godly", Lastname = "Craig Maxwell", Email = "damian@att.net", AddressLine1 = "8 South Rockland St.", AddressLine2 = "Venice, FL 34293" });
            userList.Add(new Parent() { Username = "WallD", Pass = "parallel", Lastname = "Delaney Wall", Email = "bigmauler@aol.com", AddressLine1 = "284 Golf Drive", AddressLine2 = "Fredericksburg, VA 22405" });
            userList.Add(new Parent() { Username = "WalterE", Pass = "closed", Lastname = "Eduardo Walter", Email = "lipeng@optonline.net", AddressLine1 = "11 Applegate St.", AddressLine2 = "West Orange, NJ 07052" });
            userList.Add(new Parent() { Username = "HermanD", Pass = "momentous", Lastname = "Darion Herman", Email = "carroll@sbcglobal.net", AddressLine1 = "9023 S. Hilltop St.", AddressLine2 = "Hopkinsville, KY 42240" });
            userList.Add(new Parent() { Username = "OrtegaE", Pass = "outgoing", Lastname = "Easton Ortega", Email = "biglou@att.net", AddressLine1 = "77 West Grant Street", AddressLine2 = "Brick, NJ 08723" });

            context.Users.AddOrUpdate(u => u.Username, userList.ToArray());

        }
    }
}
