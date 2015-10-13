namespace TheAirline
{
    abstract class Aircraft
    {
        private readonly string _name;
        private readonly double _range;
        private readonly double _fuelConsumption;

        protected Aircraft(string name, double range, double fuelConsumption)
        {
            _name = name;
            _range = range;
            _fuelConsumption = fuelConsumption;
        }


        public string Name
        {
            get { return _name; }
        }

        public double Range
        {
            get { return _range; }
        }

        public double FuelConsumption
        {
            get { return _fuelConsumption; }
        }
    }
}