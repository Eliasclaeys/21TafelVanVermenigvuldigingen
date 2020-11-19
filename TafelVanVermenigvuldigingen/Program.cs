using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TafelVanVermenigvuldigingen
{
    /*Opgave:
     * Maak een programma dat je een getal vraagt het minimum en maximum en dan de maaltafels.
     * 
     * ANALYSE:
     * VRAAG getal
     * VRAAG minimum
     * VRAAG maximum
     * BEREKEN alle cijfers van minimum tot maximum
     * TOON alle maaltafels van minimum tot maximum
     */

    class Program
    {
        static void Main(string[] args)
        {
            //Declarations
            int getal, minimum, maximum;

            //VRAAG getal
            Console.Write("Wat is het getal waarvan je de maaltafels wilt zien ");
            getal = int.Parse(Console.ReadLine());

            //VRAAG minimum
            Console.Write("Wat is de minimum waarde ");
            minimum = int.Parse(Console.ReadLine());

            //VRAAG maximum
            Console.Write("Wat is de maximum waarde ");
            maximum = int.Parse(Console.ReadLine());

            //BEREKEN alle cijfers van minimum tot maximum
            for (minimum = 1; minimum <= maximum; minimum++) 
            {
                //TOON alle maaltafels van minimum tot maximum
                Console.WriteLine($"{minimum} * {getal} =  {minimum * getal}");
            }

            //Wachten...
            Console.WriteLine();
            Console.Write("Druk op enter om af te sluiten ");
            Console.ReadLine();

        }
    }
}
