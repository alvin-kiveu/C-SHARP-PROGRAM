using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace umeskia.group
{

    public class Person
    {
        //this is an access modifier 

        //privent can only be accesed inside a calss
        public string FirstName = "Alvin";
        public string LastName = "Kiveu";
        public int Age = 22;

        /*
         * We have declered a method
         * Void means empty and it is used when the methosd does not return a value
         * You can replace void with the type of int that your returning
         */
        public void Statement()
        {
            Console.WriteLine("My Name is " + FirstName + " " + LastName + " and i am " + Age + " years of age");
        }
    }
}
