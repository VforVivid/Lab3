using System.Diagnostics.Contracts;
using Microsoft.Data.Sqlite;

namespace QueryBuilderStarter
{
    internal class Program 
    {
        //static string root = FileRoot.Root;
        static string dbPath = "C:\\Users\\qstar\\Documents\\_School\\_JUNIOR\\Server-Side\\Lab 3\\Data\\data.db";
        static string connectionString = $"Data Source={dbPath}";

        SqliteConnection? connection;

        public Program(string dbPath)
        {
            connection = new SqliteConnection(connectionString);
            connection.Open();
        }


        public static void Main(string[] args)
        {
            var queerBuilder = new QueryBuilder(connectionString);

        //clears existing data
            queerBuilder.DeleteAll<BannedGame>();
            queerBuilder.DeleteAll<Pokemon>();

        //creates list of pokemaynes
            List<Pokemon> PokemonList = new List<Pokemon>()
            {

               new Pokemon {Name = "Queery", Form = "Weird", Type1 = "Diabetes", Type2 = "Diabetes", Total = 8008132, HP = 69, Attack = 6, Defense = 1, SpecialAttack = 700, SpecialDefense = 900, Speed = 0, Generation = 420},
               new Pokemon {Name = "Bitch", Form = "Queer", Type1 = "Diabetes", Type2 = "Diabetes", Total = 8008132, HP = 69, Attack = 6, Defense = 1, SpecialAttack = 700, SpecialDefense = 900, Speed = 0, Generation = 420},
               new Pokemon {Name = "Baby", Form = "Kinda gay", Type1 = "Diabetes", Type2 = "Diabetes", Total = 8008132, HP = 69, Attack = 6, Defense = 1, SpecialAttack = 700, SpecialDefense = 900, Speed = 0, Generation = 420},
               new Pokemon {Name = "Yo Momma", Form = "Oh....", Type1 = "Diabetes", Type2 = "Diabetes", Total = 8008132, HP = 69, Attack = 6, Defense = 1, SpecialAttack = 700, SpecialDefense = 900, Speed = 0, Generation = 420}
            };

        //creates single pokemaine
            var babyPokes = new Pokemon()
            {
                Id = 8008135,
                Name = "Karl Marks",
                HP = 69,
                Generation = 1
            };

        //adds list of pokimans
            foreach (Pokemon pokemon in PokemonList)
            {
                queerBuilder.Create(pokemon);
            }    

        //adds single pokieymaiynes
            queerBuilder.Create(babyPokes);

        


        //create list of banned games
            List<BannedGame> badGames = new List<BannedGame>()
            {
                new BannedGame { Title = "Tit-le", Series = "NekoPara", Country = "Japan", Details = "It made the president get a lil hard and that concerned him so ban."},
                new BannedGame { Title = "CoCo-MELONS", Series = "PBS", Country = "USA", Details = "Was a VERY adult show, sounded too similar to the childrens show, disqualified."},
                new BannedGame { Title = "Tony-COCK", Series = "Thrasher", Country = "USA", Details = "An adult take on the skateboarding classic. Totally fine, banned for licensing issues"}
            };

        //create single banned game
            var faveGames = new BannedGame()
            {
                Id = 6,
                Title = "Karl Marks Me",
                Country = "Russia",
                Details = "0-0 dont ask, dont tell"
            };

        //add list of banned games
            foreach (BannedGame Gayme in badGames)
            {
                queerBuilder.Create(Gayme);
            }

        //add single banned game
            queerBuilder.Create(faveGames);            
        }
    }
}