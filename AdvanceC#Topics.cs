using System;
using System.Collections.Generic;
using System.Linq;

// ACCESS MODIFIERS,STRUCTS,ENUMS,

    struct Car
    {
        public string Model;
        public string Colour;
        public double Price;
        public string Name;

        public void carDetails()
        {
            Car car1;
            car1.Name = "AUDI";
            car1.Colour = "RED";
            car1.Model = "A6";
            car1.Price = 2.5;

            System.Console.WriteLine("Car Name: {0}",car1.Name);
            System.Console.WriteLine("Car Model:{0}",car1.Model);
            System.Console.WriteLine("Car Price:{0}",car1.Price);
            System.Console.WriteLine("Car Colour: {0}",car1.Colour);

        }

    }


