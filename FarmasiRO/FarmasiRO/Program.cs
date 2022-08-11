using System;

namespace FarmasiRO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var getcat = new ProductCategories(); // utworzenie nowego obiektu klasy "ProductCategories"
            getcat.GetCategories(); // wywolanie meteody 
        }
    }
}
/* Nie korzystalem z projektu udostepnionego na gicie poniewaz jego struktura byla dla mnie troszke zbyt skomplikowana, zrozumialem tresc zadania
 * jednak nie mialem po prostu czasu na odnalezienie sie w tym projekcie, aby wynik w tym projekcie byl taki jaki mial byc w poleceniu zadania
 * nalezaloby pobrac z linkow wypisanych przez metode GetCategories za pomoca np. selektorow css (jedyna znana mi metoda) linki do produktow z 
 * podanych kategorii nastepnie w kazdym z tych produktow (selektor document.querySelectorAll("#divProductList > div:nth-child(1)")), problemem 
 * byloby dla mnie na pewno to ze na stronie nie wyswietlaja sie od razu wszystkie produkty z podanej kategorii.
 * Nastepnie w tych produktach nalezaloby odnalezc jednostke miary i cene, nie udalo mi sie znalezc odpowiedzialnego za to selektora.
 * Fragmen ktory wykonalem zajal mi 1 godzine i  40 minut wraz z nauczeniem sie podstaw c#, poniewaz nigdy wczesniej z niego nie korzystalem.
 * Mam nadzieje ze moj komentarz pomorze w odpowiedniej ocenie. Pozdrawiam */ 