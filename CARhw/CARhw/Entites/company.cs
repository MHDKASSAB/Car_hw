using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CARhw.Entites
{
    public class company
    {

        public string Name { get; set; }
        public string Address { get; set; }
        public string Mobile { get; set; }

        public company()
        {

        }
        public company(string nm, string add, string mob)
        {
            this.Address = add;
            this.Mobile = mob;
            this.Name = nm;
        }
        public string getcompanyinfo()
        {
            return $"Company Name : {this.Name}\nCompany Mobile : {this.Mobile}\n" +
                $"Company Address : {this.Address}\n";
        }
    }
}

