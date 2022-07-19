using System;
namespace InterfaceExercise
{
    public class SUV : IVehicle, ICompany
    {
        
            public string CargoHoldSize { get; set; }
        public int CollapsableSeats { get; set; }

        public string VehicleType { get; set; }
        public string VehicleName { get; set; }
        public int Doors { get; set; }
        public int Wheels { get; set; }
        public string EngineSize { get; set; }
        public string CompanyName { get; set; }
        public string CompanyLogo { get; set; }
    
    }
}

