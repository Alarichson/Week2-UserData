using System;

namespace DrivingLisence
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutaja sünniaastat;
            //programm arvutab kasutaja vanust
            //kui kasutaja on noorem kui 18, siis programm kuvab konsoolis
            //"Oled liiga noor, et juhilube saada";
            //kui kasutaja on piisavalt vana, et juhilube saada";
            //kui kasutaja on 18, siis programm kuvab konsoolis
            //"Palju õnne! Nüüd saad juhilube taotleda"

            Console.WriteLine("Mis on su sünniaasta?");
            int YearOfBirth = Convert.ToInt32(Console.ReadLine());
            int UserAge = 2022 - YearOfBirth;

            if (UserAge > 18)
            {
                Console.WriteLine("Oled piisavalt vana, et juhilube taotleda");
            }
            else if (UserAge < 18)
            {
                Console.WriteLine("Oled liiga noor, et juhilube saada");
            }
            else
            {
                Console.WriteLine("Palju õnne! Nüüd saad juhilube taotleda.");
            }
            Console.WriteLine("Kena päeva!");


            Console.ReadLine();








        }
    }
}
