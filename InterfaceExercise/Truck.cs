using System;
namespace InterfaceExercise
{
    public class Truck : IVehicle, ICompany
    {
        
            public string BedSize { get; set; }
            public bool LockableBox { get; set; }

        public string VehicleType { get; set; }
        public string VehicleName { get; set; }
        public int Doors { get; set; }
        public int Wheels { get; set; }
        public string EngineSize { get; set; }
        public string CompanyName { get; set; }
        public string CompanyLogo { get; set; }
    
    }
}

