using System;
using System.Collections.Generic;
using System.Text;

namespace GameStore
{
    class PlayerManagement
    {
        List<Player> players = new List<Player>();
        public void Add(Player player)
        {
            players.Add(player);
            Console.WriteLine("Sayın " + player.Name + " " + player.Surname + ", kaydınız yapılmıştır.");
        }

        public void Update(Player player)
        {
            players[players.IndexOf(player)] = player;
            Console.WriteLine("Sayın " + player.Name + " " + player.Surname + ", kaydınız güncellenmiştir.");
        }

        public void Delete(Player player)
        {
            players.Remove(player);
            Console.WriteLine("Sayın " + player.Name + " " + player.Surname + ", kaydınız silinmiştir.");
        }

        public void ListOfPlayers()
        {
            foreach (var player in players)
            {
                Console.WriteLine(player.NickName);
            }
        }

    }
}
