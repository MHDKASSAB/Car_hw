using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CARhw.Entites
{
    public class car
    {

        public string ModelNumber { get; set; }
        public string Color { get; set; }
        public string WheelsNumber { get; set; }
        public company company { get; set; }

        public car()
        {

        }

        public car(string model, string color, string wheels)
        {
            this.ModelNumber = model;
            this.WheelsNumber = wheels;
            this.Color = color;
        }

        public string getcarinfo()
        {
            return $"Model Number : {this.ModelNumber}\nColor is : {this.Color}\nWheels Number : {this.WheelsNumber}";
        }

        public string getallinfo()
        {
            string info = "";
            info += this.getcarinfo();

            //foreach (var c in this.cars)
            //{
            //    info +=c.getlist();
            //}
            return info;
        }
    }
}

