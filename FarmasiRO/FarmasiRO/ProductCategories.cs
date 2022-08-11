using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;

namespace FarmasiRO
{
  
    internal class ProductCategories
    {
        private const string BaseURL = "https://farmasi.ro";

        public void GetCategories()
        {
            var web = new HtmlWeb();
            var document = web.Load(BaseURL);

            var tablerows = document.QuerySelectorAll("div.productMenuHeader"); //znalezienie przy pomocy selektorow css diva z linkiem do kategorii produktu

            foreach(var tablerow in tablerows)
            {
                var href = tablerow.QuerySelector("a").Attributes["href"].Value; //wybranie z selektora "a" wartosc tekstowa parametru href w ktorym znajduje sie odnosnik do kategorii
                Console.WriteLine(tablerow.InnerText); // wypisanie nazwy kategorii
                Console.WriteLine($"{BaseURL}{href}"); // wypisanie linku do kategorii
            }

        }
    }
}
