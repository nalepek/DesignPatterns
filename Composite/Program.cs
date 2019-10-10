using System;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            var colas = new Cola(200);
            colas.Drinks.Add(new ColaCherry(210));
            colas.Drinks.Add(new ColaLime(240));

            var pepsis = new Pepsi(180);
            pepsis.Drinks.Add(new PepsiMax(210));
            pepsis.Drinks.Add(new PepsiZero(190));

            var schweeppes = new Schweeppes(250);
            schweeppes.Drinks.Add(new SchweeppesOriginal(260));
            schweeppes.Drinks.Add(new SchweeppesRussian(280));

            var sodaDrink = new SodaDrink(100);
            sodaDrink.Drinks.Add(colas);
            sodaDrink.Drinks.Add(pepsis);
            sodaDrink.Drinks.Add(schweeppes);

            sodaDrink.DisplayPrice();

            Console.ReadKey();
        }
    }
}
