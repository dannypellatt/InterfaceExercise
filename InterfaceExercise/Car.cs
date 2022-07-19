using System;
namespace InterfaceExercise
{
    public class Car : IVehicle, ICompany
    {
        
        public bool Electric { get; set; }
        public string TrunkSize { get; set; }

        public string VehicleType { get; set; }
        public string VehicleName { get; set; }
        public int Doors { get; set; }
        public int Wheels { get; set; }
        public string EngineSize { get; set; }
        public string CompanyName { get; set; }
        public string CompanyLogo { get; set; }
        
    }
}


