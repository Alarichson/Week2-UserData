﻿using System;

namespace InstagramAgeCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutaja vanust;
            //programm kontrollib kas kasutaja on vanem kui 13 või 13 aastat vana;
            //kui kasutaja on 13 aastat vana või vanem, siis ta võib Instagrammi kasutada;
            //kui kasutaja on noorem kui 13, siis ta on liiga noor;

            Console.WriteLine("Palun sisesta oma vanus:");
            int UserAge = Convert.ToInt32(Console.ReadLine());

            if(UserAge > 13)
            {
                Console.WriteLine("Oled piisavalt vana, et Instagram'i kontot luua");
            }
            else if(UserAge < 13)
            {
                Console.WriteLine("Oled liiga noor, et Instagram'i kontot luua");
            }
            else
            { 
                Console.WriteLine("Oled piisavalt vana, et Instagram'i kontot luua"); 
            }
            Console.WriteLine("Kena päeva!");
            Console.WriteLine(" ");


            Console.ReadLine();




        }
    }
}
