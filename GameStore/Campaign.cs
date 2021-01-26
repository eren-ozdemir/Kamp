using System;
using System.Collections.Generic;
using System.Text;

namespace GameStore
{
    interface Campaign
    {
        void ShowCampaignInfo();
        void ApplyDiscount(List<Game> games);
    }
}
