using System;
using System.Collections.Generic;

namespace GameStore
{
    class Program
    {
        static void Main(string[] args)
        {
            PlayerManagement playerManagement = new PlayerManagement();
            GameManagement gameManagement = new GameManagement();
            GameStore gameStore = new GameStore();

            Player player1 = new Player() { DateOfBirth = new DateTime(1993, 12, 11), Name = "Eren", Surname = "Özdemir", NationalityId = "22657536556"};
            Player player2 = new Player() { DateOfBirth = new DateTime(1994, 11, 05), Name = "Gizem", Surname = "Özdemir", NationalityId = "2262586556"};
            
            Game RainbowSixSiege = new Game() { Id = 1, Name = "Rainbow 6: Siege", Genre = "FPS", Price = 100 };
            Game CivilizitaionVI = new Game() { Id = 2, Name = "Civilizitaion VI", Genre = "Strategy", Price = 200 };
            Game TheWitcher3 = new Game() { Id = 3, Name = "The Witcher 3: Wild Hunt", Genre = "Action-RPG", Price = 60 };
            Game CitiesSkylines = new Game() { Id = 4, Name = "Cities Skylines", Genre = "City Building", Price = 50 };

            player1.NickName = "ermisss";

            //Oyuncu bilgileri kaydedilecek
            



            gameManagement.Add(RainbowSixSiege);
            gameManagement.Add(CivilizitaionVI);
            gameManagement.Add(TheWitcher3);
            gameManagement.Add(CitiesSkylines);

            List<Game> games = gameManagement.Games;

            Console.WriteLine("\nBLACK FRIDAY KAMPANYASI!!!");
            Campaign blackFriday = new BlackFriday();
            blackFriday.ApplyDiscount(games);
            blackFriday.ShowCampaignInfo();

            foreach (var game in games)
            {
                Console.WriteLine("\nOyun Adı: {0} \nOyun Türü: {1} \nOyun Fiyatı: {2} \nİndirimli Fiyatı: {3}", 
                    game.Name, game.Genre, game.Price, game.DiscountedPrice );
            }


            Console.WriteLine("\nHALLOWEEN KAMPANYASI!!!");
            Campaign halloween = new Halloween();
            halloween.ApplyDiscount(games);
            halloween.ShowCampaignInfo();

            foreach (var game in games)
            {
                Console.WriteLine("\nOyun Adı: {0} \nOyun Türü: {1} \nOyun Fiyatı: {2} \nİndirimli Fiyatı: {3}", 
                    game.Name, game.Genre, game.Price, game.DiscountedPrice);
            }




            //GameStore gameStore = new GameStore();
            //gameStore.Buy(player1, RainbowSixSiege);
            //gameStore.Buy(player1, TheWitcher3);
            //gameStore.Buy(player2, CitiesSkylines);











        }
    }
}
