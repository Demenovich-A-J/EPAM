using System;

namespace TheAirline.Interfaces
{
    interface IPlane : IComparable<IPlane>
    {
        string Name { get; }
        double Range { get; }
        double FuelConsumption { get; }

    }
}
