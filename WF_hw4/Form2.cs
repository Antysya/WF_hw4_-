using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_hw4
{
    public partial class F_Product : Form
    {
        public F_Product()
        {
            InitializeComponent();
        }
        public F_Product(string name, string country, double cost)
        {
            InitializeComponent();
            tb_name.Text = name;
            tb_country.Text = country;
            tb_cost.Text = Convert.ToString(cost);
        }

        public Product MyProduct { 
            get { return new Product(tb_name.Text, tb_country.Text, Convert.ToDouble(tb_cost.Text)); }           
        }
        private void bt_ok_Click(object sender, EventArgs e)
        {
            if (tb_name.Text == "")
                MessageBox.Show("Не указали \"Название товара\"!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (tb_country.Text == "")
                MessageBox.Show("Не указали \"Страну производитель\"!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                //Product product = new Product(tb_name.Text, tb_country.Text, Convert.ToDouble(tb_cost.Text));
                this.DialogResult = DialogResult.OK;
            }
        }

        private void bt_cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            string reg_cost = @"^\d{1,}\,?\d{0,2}$";
            Regex r = new Regex(reg_cost);
            if (r.IsMatch(tb_cost.Text) == false)
            {
                MessageBox.Show("Ошибка ввода стоимоcти!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
