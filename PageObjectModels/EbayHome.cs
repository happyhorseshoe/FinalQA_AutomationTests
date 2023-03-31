using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace AutomatedTesting.PageObjectModels
{
    internal class EbayHome
    {
        internal string EbayUrl = "https://www.ebay.com/";
        internal string EbayTitle = "Electronics, Cars, Fashion, Collectibles & More | eBay";

        string firstLinkTextCollectible = "Collectibles";
        internal By LinkTextCollectible => By.LinkText(firstLinkTextCollectible);

        string secondLinkTextArt = "Art Paintings";
        internal By LinkTextArt => By.LinkText(secondLinkTextArt);

    }


}
