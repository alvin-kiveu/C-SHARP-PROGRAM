using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using umeskia.group;


namespace umeskia
{


    class app
    {
      
        /* 
         the main class should have main
         */
        static void Main()
        {
         //instatitaining a class
        Person data = new Person();
        //caling a method
        data.Statement();
        //calling a static method
        String codersName = Calculator.Add();
        Console.WriteLine(codersName);
        //convert string to int
        string nameName = "2";
        int number = Int32.Parse(nameName);
        Console.WriteLine(number);
            //Requesting user input
            Console.WriteLine("What is your age ?");
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
            string userAge = Console.ReadLine();
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
#pragma warning disable CS8604 // Possible null reference argument.
            int convertedAge = Int32.Parse(userAge);
#pragma warning restore CS8604 // Possible null reference argument.
            int newAge = convertedAge + number;
            Console.WriteLine("Your age in two years wil be : " + newAge);


        }
       


    }

}