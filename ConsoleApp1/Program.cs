using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            Vehicle Myveh = new Vehicle();

            Myveh.lunch();
            Myveh.info();

            Veh_b Myveh_b = new Veh_b();
            Myveh_b.info();
            //Console.WriteLine("Hello World!");

            /* static void add_function(int a,int b)
            {




                return ;
            } */
        }

    }
    class Vehicle
    {
        int cc = 150;
        string name = "no name";
        public void lunch()
        {
            Console.WriteLine("Lunching....");
        }
        public virtual void info()
        {
            Console.WriteLine("name:"+name);
            Console.WriteLine("CC:"+cc);
            Console.WriteLine(".........");
        }


    }
    class Veh_b : Vehicle
    {
        public override void info()
        {
            Console.WriteLine("veh_b.info");
        }
    }
}
