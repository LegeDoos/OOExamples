using DemoOO.BusinessModel;
using System;
using System.Collections.Generic;

namespace DemoOO
{
    class Program
    {
        static void Main()
        {
            // declare variable and set value
            string test = "Rob";
            List<string> namenLijst = new();

            // output and debugger
            Console.WriteLine($"Hello World! Inhoud van de string {test}");


            // create an instance and call the method (inheritance / globalisation / specification)
            Donkey donkey = new Donkey();
            donkey.MakeSound();
            Dog dog = new Dog();
            dog.MakeSound();

            // public, private, protected


            // polymorphism & encapsulation
            Animal animal = new Dog();
            animal.MakeSound();
            animal = donkey;
            animal.MakeSound();

            

            // association

        }

        public static void TestMethod(string _string)
        {
            _string = "Juul";
        }

        public static void TestNamenLijst(List<string> _lijst)
        {
            _lijst.Add("Juul");
        }
    }
}
