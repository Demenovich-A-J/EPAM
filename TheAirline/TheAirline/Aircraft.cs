namespace TheAirline
{
    abstract class Aircraft
    {
        private string _name;
        private double _range;
        private double _fuelConsumption;

        protected Aircraft(string name, double range, double fuelConsumption)
        {
            Name = name;
            Range = range;
            FuelConsumption = fuelConsumption;
        }

        protected Aircraft() { }

        public double FuelConsumption
        {
            get { return _fuelConsumption; }
            set { _fuelConsumption = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public double Range
        {
            get { return _range; }
            set { _range = value; }
        }
    }
}