using System;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //   DONE   Create 2 Interfaces called IVehicle & ICompany



            //   DONE   Create 3 classes called Car , Truck , & SUV

            //   DONE   In your IVehicle

            /* Create 4 members that Car, Truck, & SUV all have in common.
             * Example: All vehicles have a number of wheels... for now..
             */


            //   DONE   In ICompany

            /*Create 2 members that are specific to each every company
             * regardless of vehicle type.
             *
             *
             * Example: public string Logo { get; set; }
             */

            //   DONE   In each of your car, truck, and suv classes

            /*Create 2 members that are specific to each class
             * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
             *
             * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
             * 
             */

            //Now, create objects of your 3 classes and give their members values;
            //Creatively display and organize their values

            Car car1 = new Car();
            Truck truck1 = new Truck();
            SUV suv1 = new SUV();

            suv1.VehicleType = "SUV";
            suv1.CompanyName = "Mercedes";
            suv1.CompanyLogo = "Three Pointed Star";
            suv1.VehicleName = "GL450";
            suv1.EngineSize = "V8";
            suv1.Doors = 4;
            suv1.Wheels = 4;

            suv1.CargoHoldSize = "huge";
            suv1.CollapsableSeats = 6;




            car1.VehicleType = "car";
            car1.CompanyName = "Jaguar";
            car1.CompanyLogo = "Pouncing Jaguar";
            car1.VehicleName = "I-Pace";
            car1.EngineSize = "90 kWh";
            car1.Doors = 2;
            car1.Wheels = 4;

            car1.Electric = false;
            car1.TrunkSize = "compact";

            


            truck1.VehicleType = "truck";
            truck1.CompanyName = "Ford";
            truck1.CompanyLogo = "Ford In Blue Circle";
            truck1.VehicleName = "F-150";
            truck1.EngineSize = "V6 Turbo";
            truck1.Doors = 2;
            truck1.Wheels = 4;

            truck1.BedSize = "huge";
            truck1.LockableBox = false;


            Console.WriteLine($"The {car1.VehicleType} in our showroom is a {car1.CompanyName}, {car1.VehicleName}.\n" +
                $"You will recognise it's logo, the famous {car1.CompanyLogo}.\n" +
                $"It boasts a {car1.EngineSize} Engine and has {car1.Doors} doors and {car1.Wheels} wheels.");
            Console.WriteLine("");
            Console.WriteLine($"This {car1.VehicleName} !is electric! and has a {car1.TrunkSize} trunk");
            // !! wanted to include: {car1.Electric? ("is electric") : ("is not electric")}
            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine($"The {suv1.VehicleType} in our showroom is a {suv1.CompanyName}, {suv1.VehicleName}.\n" +
                $"You will recognise it's logo, the famous {suv1.CompanyLogo}.\n" +
                $"It boasts a {suv1.EngineSize} Engine and has {suv1.Doors} doors and {suv1.Wheels} wheels.");
            Console.WriteLine("");
            Console.WriteLine($"This {suv1.VehicleName} has a {suv1.CargoHoldSize} cargo and {suv1.CollapsableSeats} collapsable seats.");
            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine($"The {truck1.VehicleType} in our showroom is a {truck1.CompanyName}, {truck1.VehicleName}.\n" +
                $"You will recognise it's logo, the famous {truck1.CompanyLogo}.\n" +
                $"It boasts a {truck1.EngineSize} Engine and has {truck1.Doors} doors and {truck1.Wheels} wheels.");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine($"This {truck1.VehicleName} has a {truck1.BedSize} bed and has !no lockable box! included.");
            // !! wanted to include: {truck1.LockableBox? ("a lockable box") : ("no lockable box")}
            Console.WriteLine("");

        }
    }
}
