using System;
using System.Collections.Generic;
using System.Text;

namespace GameStore
{
    class BlackFriday : Campaign
    {
        float discount = 0.25F;
        public void ApplyDiscount(List<Game> games)
        {
            foreach (Game game in games)
            {
                if (game.Genre == "FPS")
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
