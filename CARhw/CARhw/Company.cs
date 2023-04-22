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
    public partial class Company : Form
    {
        List<car> Cars;
        List<company> companies;
        
        public Company(List<car> Cars ,List<company> companies)
        {
            this.Cars = Cars;
            this.companies = companies;
            InitializeComponent();
        }
        public Company()
        {
            InitializeComponent();
        }
        private void show_btn_Click(object sender, EventArgs e)
        {
            string info = "";

            company comp = new company();
            comp.Name = nm_txt.Text;
            comp.Mobile = mob_txt.Text;
            comp.Address = add_txt.Text;
            companies.Add(comp);

            foreach (var item in Cars)
            {
                info += item.getcarinfo();
                info += "\n===============================\n";
            }

            foreach (var item in companies)
            {
                info += item.getcompanyinfo();
                info += "\n===============================\n";
            }
            nm_txt.Clear();
            mob_txt.Clear();
            add_txt.Clear();

            res_lbl.Text = info;
        }

        private void next_btn_Click(object sender, EventArgs e)
        {
            final f1 = new final(Cars, companies);
            f1.Show();
            this.Hide();
        }

        private void Company_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
