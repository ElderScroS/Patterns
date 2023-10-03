using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    internal class SiteProxy : ISite
    {
        private ISite Site;
        private Dictionary<int, string> cache;
        private int temp_counter = 0;
        public SiteProxy(ISite site)
        {
            this.Site = site;
            this.cache = new Dictionary<int, string>();
        }

        public string GetPage(int num)
        {
            string page;
            if (cache.ContainsKey(num))
            {
                if (temp_counter != 6)
                {
                    page = cache[num];
                    page = "Iz cache: " + page;
                    temp_counter++;
                }
                else
                {
                    page = cache[num];
                    page = "Iz DB " + page;
                    temp_counter = 0;
                }
            }
            else
            {
                page = Site.GetPage(num);
                cache.Add(num, page);
            }
            return page;
        }
    }
}
