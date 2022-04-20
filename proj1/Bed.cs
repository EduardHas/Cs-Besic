 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proj1
{
    public class Bed
    {
        //מאפיינים של פריט מיטה 
        public string model;
        public int height;
        public int width;
        public float price;
        public bool isInStock = true;//ברירת מחדל של משתנה 


        //הגדרת פעולויות /פונקציות ששיכות למחלקה מיטה 
        public void MakeOrder()
        {
            height = 0;
        }
        public int DrugDown()
        {
            return 0;
        }
             

    }
}
