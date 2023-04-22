using CARhw.Entites;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CARhw
{
    public partial class final : Form
    {
        List<car> Cars;
        List<company> companies;
        public final(List<car> Cars, List<company> companies)
        {
            InitializeComponent();

            this.Cars = Cars;
            this.companies = companies;
            var carsName = Cars.Select(w => w.ModelNumber).ToArray();
            var compName = companies.Select(w => w.Name).ToArray();

            this.comboBox1.Items.AddRange(carsName);
            this.comboBox2.Items.AddRange(compName);

        }

        private void show_btn_Click(object sender, EventArgs e)
        {
            var info = "";
            foreach (var item in Cars)
            {
                if (item.company == null)
                    continue;
                info += item.company.Name + " / " + item.ModelNumber + "\n";
            }
            res_lbl.Text = info;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void final_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var carselected = comboBox1.SelectedIndex;
            var companieselected = comboBox2.SelectedIndex;
            Cars.ElementAt(carselected).company = companies.ElementAt(companieselected);
           
        }
    }
}
