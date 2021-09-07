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
            string TestVariabele = "Test";
            List<string> lijstje = new List<string>();

            // output and debugger
            Console.WriteLine($"Hello World! Inhoud van de string {TestVariabele}");

           
            // create an instance and call the method (inheritance / globalisation / specification)
            Donkey donkey = new Donkey();
            donkey.MakeSound();

            // public, private, protected
            Dog dog = new Dog();
            dog.MakeSound();

            // polymorphism & encapsulation
            Animal animal = new Donkey();
            animal.MakeSound();
            animal = new Dog();
            animal.MakeSound();

            // association
            Farm farm = new Farm();
            farm.Animals = new List<Animal>();
            farm.Animals.Add(animal);
        }
    }
}
