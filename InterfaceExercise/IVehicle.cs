using System;
namespace InterfaceExercise
{
    public interface IVehicle
    {
        public string VehicleType { get; set; }
        public string VehicleName { get; set; }
        public int Doors { get; set; }
        public int Wheels { get; set; }
        public string EngineSize { get; set; }
    }
}

