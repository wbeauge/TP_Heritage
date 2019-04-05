using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hypothese
{
    class Program
    {
        static void Main(string[] args)
        {

            Lion lii = new Lion("leo", "savan", "graaaa", false,Dangerosite.Mimi, 4);
            lii.Afficher();

            Chat chaaa = new Chat("ravi", "maison", "miaho", true, Dangerosite.DangerPourTaVie, 4);
            chaaa.Afficher();

            Baleine baaa = new Baleine("leoryo", "ocean", "tiiioouuu", false,Dangerosite.AManipulerAvecGrandSoin, 45, 2000);
            baaa.Afficher();

            int choix;

            do
            {

                do
                {
                    Console.WriteLine("Menu de dangerosité :\n\n");
                    Console.WriteLine("1 - Mimi");
                    Console.WriteLine("2 - Pas Trop Dangereux");
                    Console.WriteLine("3 - A Manipuler Avec Grand Soin");
                    Console.WriteLine("4 - Danger Pour Ta Vie");
                    Console.WriteLine("5 - Je veut plus choisir");
                    choix = Convert.ToInt32(Console.ReadLine());

                } while (choix < 0 || choix > 5);

                switch (choix)
                {
                    case 1:
                        Console.WriteLine("1 - Mimi");
                        lii.Afficher();
                        break;
                    case 2:
                        Console.WriteLine("2 - Pas Trop Dangereux");
                        break;
                    case 3:
                        Console.WriteLine("3 - A Manipuler Avec Grand Soin");
                        break;
                    case 4:
                        Console.WriteLine("4 - Danger Pour Ta Vie");
                        chaaa.Afficher();
                        break;
                    case 5:
                        Console.WriteLine("5 - Je veut plus choisir");
                        break;
                }

            } while (choix != 5);

            Console.ReadLine();
        }
    }
}
