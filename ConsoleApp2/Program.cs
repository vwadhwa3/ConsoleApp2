using ConsoleApp2.Inheritance_Interface;

namespace ConsoleApp2
{
    interface Car
    {
        void Drive();
    }
    public class Program : Car
    {
       void Car.Drive() { Console.Write("Explicit implimatation of interface member"); }

        static void Main(string[] args)
        {

            Program DemoProgram = new Program();    


            ((Car)DemoProgram).Drive(); 


          
            Console.WriteLine("Hello, World!");
        }
    }
}