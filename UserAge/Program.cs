using System;

namespace UserAge
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutaja vanust;
            //programm arvutab kasutaja sünniaastat;
            //programm kuvab sünniaastat konsoolis;
            //"oled sündinud aastal {YearOfBirth}";

            Console.WriteLine("Mis on su sünniaasta?");
            int YearOfBirth = Convert.ToInt32(Console.ReadLine());

            int UserAge = 2022 - YearOfBirth;

            Console.WriteLine($"Sa oled {UserAge} aastat vana.");

            Console.ReadLine();
        }
    }
}
