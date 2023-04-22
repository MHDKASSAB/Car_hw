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
    public partial class Form1 : Form
    {
        List<car> Cars;
        List<company> companies;

        public Form1()
        {
            companies = new List<company>();
            Cars = new List<car>();

            car carlinker = new car();
            InitializeComponent();
        }

        private void next_btn_Click(object sender, EventArgs e)
        {
           Company form2 = new Company(Cars , companies);
            form2.Show();
            this.Hide();
        }

        private void show_btn_Click(object sender, EventArgs e)
        {
            car temp = new car();
            temp.ModelNumber = (this.mod_txt.Text);
            temp.Color = (this.color_txt.Text);
            temp.WheelsNumber = (this.wheel_txt.Text);
            Cars.Add(temp);
            res_lbl.Text = "";
            
            
            foreach (var item in Cars)
            {
                res_lbl.Text += $"{item.getcarinfo()}\n";

            }
            this.mod_txt.Text = "";
            this.color_txt.Text = "";
            this.wheel_txt.Text = "";



        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
