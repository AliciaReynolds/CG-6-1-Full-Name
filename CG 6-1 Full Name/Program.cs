﻿using System;
using System.Text;


namespace CG_6_1_Full_Name
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please provide your first name.");
            string First = Console.ReadLine();

            Console.WriteLine("Please enter your last name.");
            string Last = Console.ReadLine();

            StringBuilder FullName = new StringBuilder();
            FullName.Append(First);
            FullName.Append(Last);

            Console.WriteLine(FullName);

            Console.ReadLine();


        }

        //private static string Name(string FirstName, string LastName);
        //{
        //return $"Hello {FristName}{LastName}";
        //}

    }
}
