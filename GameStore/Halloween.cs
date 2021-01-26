using System;
using System.Collections.Generic;
using System.Text;

namespace GameStore
{
    class Halloween : Campaign
    {
        float discount = 0.40F;
        public void ApplyDiscount(List<Game> games)
        {
            foreach (Game game in games)
            {
                if (game.Genre == "Action-RPG")
                {
                    game.DiscountedPrice = game.Price - game.Price * discount;
                }
            }

        }

        public void ShowCampaignInfo()
        {
            Console.WriteLine("Black Friday Kampanyası FPS türündeki tüm oyunlarda %" + 100*discount +" indirim sağlar");
        }
    }
}
