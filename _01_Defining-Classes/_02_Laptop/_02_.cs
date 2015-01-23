using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Laptop
{
    class Battery
    {
        protected string batt;
        protected int battLife;

        public Battery(string batt = null, int battLife = 0)
        {
            this.Batt = batt;
            this.BattLife = battLife;
        }

        public string Batt
        {
            get { return this.batt; }
            set
            {
                if (String.IsNullOrEmpty(value))
                    this.batt = null;
                this.batt = value;
            }
        }

        public int BattLife
        {
            get { return this.battLife; }
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("The value must be > 0");
                this.battLife = value;
            }
        }
    }

    class Laptop : Battery
    {
        private string model;
        private string manufact;
        private string processor;
        private int ram;
        private string video;
        private string hdd;
        private string screen;
        private double price;

        public Laptop(string model, double price, string manufact = null, string processor = null,
            int ram = 0, string video = null, string hdd = null, string screen = null, string batt = null, int battLife = 0)
        {
            this.Model = model;
            this.Price = price;
            this.Manufact = manufact;
            this.Processor = processor;
            this.Ram = ram;
            this.Video = video;
            this.Hdd = hdd;
            this.Screen = screen;
            this.Batt = batt;
            this.BattLife = battLife;
        }

        public Laptop(string model, double price)
        {
            this.Model = model;
            this.Price = price;
        }

        public Laptop(string model, double price, string manufact, int ram)
        {
            this.Model = model;
            this.Price = price;
            this.Manufact = manufact;
            this.Ram = ram;
        }

        public string Model
        {
            get { return this.model; }
            set
            {
                if (String.IsNullOrEmpty(value))
                    throw new ArgumentNullException("The model of the laptop is mandatory!");
                this.model = value;
            }
        }

        public string Manufact
        {
            get { return this.manufact; }
            set { this.manufact = value; }
        }

        public string Processor
        {
            get { return this.processor; }
            set { this.processor = value; }
        }

        public int Ram
        {
            get { return this.ram; }
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("Ram must be > 0");
                this.ram = value;
            }
        }

        public string Video
        {
            get { return this.video; }
            set { this.video = value; }
        }

        public string Hdd
        {
            get { return this.hdd; }
            set { this.hdd = value; }
        }

        public string Screen
        {
            get { return this.screen; }
            set { this.screen = value; }
        }

        public double Price
        {
            get { return this.price; }
            set
            {
                if (value <= 0)
                    throw new ArgumentOutOfRangeException("The price must be set and > 0");
                this.price = value;
            }
        }

        public override string ToString()
        {
            string output = "Model: " + this.model + "\n";
            if (!String.IsNullOrEmpty(this.manufact))
                output += "Manufacturer: " + this.manufact + "\n";
            if (!String.IsNullOrEmpty(this.processor))
                output += "Processor: " + this.processor + "\n";
            if (this.Ram != 0)
                output += "RAM: " + this.ram + " GB" + "\n";
            if (!String.IsNullOrEmpty(this.video))
                output += "Graphics card: " + this.video + "\n";
            if (!String.IsNullOrEmpty(this.hdd))
                output += "HDD: " + this.hdd + "\n";
            if (!String.IsNullOrEmpty(this.screen))
                output += "Screen: " + this.screen + "\n";
            if (!String.IsNullOrEmpty(this.batt))
                output += "Battery: " + this.batt + "\n";
            if (this.battLife > 0)
                output += "Battery Life: " + this.battLife + "\n";

            output += "Price: " + this.price + " lv.\n";
            return output;
        }
    }


    class _02_
    {
        static void Main(string[] args)
        {
            Laptop temp1 = new Laptop("Lenovo Whatever", 2999, "Lenovo", "Intel", 4, "Ati", "", "Full HD", "smotana", 1);

            Laptop temp2 = new Laptop("HP", 899.99);
            temp2.BattLife = 8;

            Laptop temp3 = new Laptop("HP 500", 1499.99, "Hewlett-Packard", 8);

            Console.WriteLine(temp1);
            Console.WriteLine(temp2);
            Console.WriteLine(temp3);
        }
    }
}

