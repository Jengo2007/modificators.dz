using System;

namespace modificators.dz
{
    class Car
    {
        public string Model;
        protected int Data;
        protected double Motorengine;
        public string Color;

        public string GetModel
        {
            get{return Model;}
            set{Model = value;}
            
        }

        public int GetData
        {
            get{return Data;}
            set{Data = value;}
        }

        public double GetMotorengine
        {
            get{return Motorengine;}
            set{Motorengine = value;}
        }
    }

    class Bmw:Car
    {
        public Bmw()
        {
            Model = "BMW";
            Data = 2008;
            Motorengine = 3.5;
            Color = "Black";
        }

        Bmw(string model, int data, double motorengine, string color)
        {
            Model = model;
            Data = data;
            Motorengine = motorengine;
            Color = color;
        }
    }

    class Mercedec : Car
    {
        public Mercedec()
        {
            Model = "Mercedec";
            Data = 2021;
            Motorengine = 6.3;
            Color = "Red";
        }

        Mercedec(string model, int data, double motorengine, string color)
        {
            Model = model;
            Data = data;
            Motorengine= motorengine; 
            Color= color;
            
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Bmw bmw = new Bmw();
            Mercedec mercedec = new Mercedec();
            Console.WriteLine("Car name:"+bmw.Model);
            Console.WriteLine("Release date:"+bmw.GetData);
            Console.WriteLine("Motor engine:"+bmw.GetMotorengine);
            Console.WriteLine("Color:"+bmw.Color);
            Console.WriteLine("Car name:"+mercedec.Model);
            Console.WriteLine("Release date:"+mercedec.GetData);
            Console.WriteLine("Motor engine:" + mercedec.GetMotorengine);
            Console.WriteLine("Color:" + mercedec.Color);
        }
    }
}