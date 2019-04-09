using System;

namespace myApp
{
    public class Building
    {
        private string _designer = "Connor Bailey";
        private DateTime _dateConstructed { get; set; }
        private string _address { get; set; }
        private string _owner { get; set; }

        public int Stories { get; set; }
        public int Width { get; set; }
        public int Depth { get; set; }
        public int Volume
        {
            get
            {
                return (3 * Stories) * Width * Depth;
            }
        }

        public Building(string address)
        {
            _address = address;
        }
        public void Construct()
        {
            _dateConstructed = DateTime.Now;
        }
        public void Purchase(string name)
        {
            _owner = name;
        }

        public void Print()
        {
            Console.WriteLine($@"
            Address: {_address}
            -----------------------------------
            Deisgned by {_designer}
            Constructed on {_dateConstructed}
            Owned By {_owner}
            {Volume} cubic meters of space
            ");
        }


    }
}

