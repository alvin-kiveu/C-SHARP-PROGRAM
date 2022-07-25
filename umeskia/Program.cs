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

        String codersName = Calculator.Add();
        Console.WriteLine(codersName);
        }
       


    }

}