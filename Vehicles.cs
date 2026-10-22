using System;
using System.Collections.Generic;
using System.Text;

namespace Week2Assignment2._1
{
    internal class Vehicles
    {
        private string typeVehicle;

        public string TypeVehicle
        {
            get
            {
                return typeVehicle;
            }
            set
            {
                typeVehicle = value;
            }
        }
        public string NameVehicle { get; set; }
        public string EngineSize {  get; set; }
        public string DescriptionVehicle { get; set; }

        public Vehicles()
        {

        }

        public Vehicles(string name)
        {
            NameVehicle = name;
        }

        public Vehicles(string name, string description)
        {
            NameVehicle = name;
            DescriptionVehicle = description;
        }
    }

    class Car: Vehicles
    {
        private string classCar;

        public string ClassCar
        {
            get
            {
                return classCar;
            }
            set
            {
                classCar = value;
            }
        }

        public Car()
        {
            base.TypeVehicle = "Car";
        }

        public Car(string name)
        {
            base.TypeVehicle = "Car";
            NameVehicle = name;
        }

        public Car(string name, string description)
        {
            base.TypeVehicle = "Car";
            NameVehicle = name;
            DescriptionVehicle = description;
        }
    }

    class Motorcycle : Vehicles
    {
        public Motorcycle()
        {
            base.TypeVehicle = "Motorcycle";
        }

        public Motorcycle(string name)
        {
            base.TypeVehicle = "Motorcycle";
            NameVehicle = name;
        }

        public Motorcycle(string name, string description)
        {
            base.TypeVehicle = "Motorcycle";
            NameVehicle = name;
            DescriptionVehicle = description;
        }
    }

    class Sedan : Car
    {
        public Sedan()
        {
            base.TypeVehicle = "Car";
            base.ClassCar = "Sedan";
        }

        public Sedan(string name)
        {
            base.TypeVehicle = "Car";
            base.ClassCar = "Sedan";
            NameVehicle = name;
        }

        public Sedan(string name, string description)
        {
            base.TypeVehicle = "Car";
            base.ClassCar = "Sedan";
            NameVehicle = name;
            DescriptionVehicle = description;
        }
    }

    class Coupe : Car
    {
        public Coupe()
        {
            base.TypeVehicle = "Car";
            base.ClassCar = "Coupe";
        }

        public Coupe(string name)
        {
            base.TypeVehicle = "Car";
            base.ClassCar = "Coupe";
            NameVehicle = name;
        }

        public Coupe(string name, string description)
        {
            base.TypeVehicle = "Car";
            base.ClassCar = "Coupe";
            NameVehicle = name;
            DescriptionVehicle = description;
        }
    }
}
