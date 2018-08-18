using System;
using System.Text;


namespace CG_6_1_Full_Name
{
    class Program
    {
        static void Main(string[] args)
        {
            //I did this (below) just to write the code so I knew I got it working.
            //I'm really struggling with how to make methods work so I thought this
            //might help baby step into it

            //Console.WriteLine("Please provide your first name.");
            //string First = Console.ReadLine();

            //Console.WriteLine("Please enter your last name.");
            //string Last = Console.ReadLine();

            //StringBuilder FullName = new StringBuilder();
            //FullName.Append(First);
            //FullName.Append(" ");
            //FullName.Append(Last);

            //Console.WriteLine(FullName);

            //This takes the user input for first name
            Console.WriteLine("Please provide your first name.");
            string First = Console.ReadLine();

            //This takes the user input for last name
            Console.WriteLine("Please enter your last name.");
            string Last = Console.ReadLine();


            //This is the method created to combine the user inputs for a full name output
            Name(First, Last);


            Console.ReadLine();


        }
        /// <summary>
        /// This utilizes the StringBuilder operation to create a full name greeting, using first/last name inputs
        /// </summary>
        /// <param name="first - inputted"></param>
        /// <param name="last - inputted"></param>
        
        private static void Name(string first, string last)
        {
            /*This was copied code from above when I was just writing the code to know I could do it
            Console.WriteLine("Please provide your first name.");
            string First = Console.ReadLine();

        Console.WriteLine("Please enter your last name.");
            string Last = Console.ReadLine();*/
        
         /*This is taking the inputted values that are provided by the user and entering them
         into this operation to spit out a full name greeting.*/
        StringBuilder FullName = new StringBuilder();
        FullName.Append(first);
            FullName.Append(" ");
            FullName.Append(last);

           Console.WriteLine("Hello" + FullName);

        }

}
}
