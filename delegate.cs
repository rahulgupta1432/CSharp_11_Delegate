using System;

namespace ConsoleApp2
{
    class Program
    {
        public delegate void del();
     
        public static void display1()
        {
            Console.WriteLine("Dispaly 1 method is called");
        }
        public  static void display2()
        {
            Console.WriteLine("Dispaly 2 method is called");
            
            
        }

        // Main Method
        public static void Main(String[] args)
        {        
            del del_obj1 = new del(display1);
            del del_obj2 = new del(display2);
  
            del_obj1();
            del_obj2();
         
            Console.ReadLine();
        }
    }

}

