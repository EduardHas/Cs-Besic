using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proj1
{
     class Program
    {
        static void Main(string[] args)
        {   
            //מופע =אובייקט
            Bed b1 = new Bed();
            Bed b2 = new Bed();
            Bed b3 = new Bed();
          

            //יצירת שלש מופעים  שונים
            b1.model = "Sapapa";
            b1.price = 55f;

            b2.model = "Sababa";
            b2.price = 600f;

            b3.model = "Bamaba";
            b3.price = 23f;



            Console.ReadLine();

          
        }
    }
}
