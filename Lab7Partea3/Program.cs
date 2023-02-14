using System;

namespace Lab7Partea3
{
    class Program
    {
        /*
             Clasa autoturism
             va detine o metoda prin care va fi calculat numarul total de autoturisme create
             Va detine o metoda care va returna cel mai puternic autovehicul creat.
        */
        static void Main(string[] args)
        {
            Motor motor1 = new Motor(3500, 120, "benzina");
            Motor motor2 = new Motor(2200, 110, "diesel");
            Motor motor3 = new Motor(1500, 80, "benzina");

            Usa usa1 = new Usa();
            Usa usa2 = new Usa();
            Usa usa3 = new Usa();

            Autoturism autoturism1 = new Autoturism(motor1, 5, "Seat", "Leon", 2012, usa1);
            Autoturism autoturism2 = new Autoturism(motor2, 3, "Volkswagen", "Passat", 2016, usa2);
            Autoturism autoturism3 = new Autoturism(motor3, 5, "Dacia", "Logan", 2010, usa3);

            Console.WriteLine(autoturism1.GetDescription());
            Console.WriteLine(autoturism2.GetDescription());
            Console.WriteLine(autoturism3.GetDescription());

            Console.WriteLine("Total numar de autoturisme create: " + Autoturism.GetNumarTotalAutoturismeCreate());
            
        }
    }
}
