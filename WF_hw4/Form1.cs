using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WF_hw4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bt_Add_Click(object sender, EventArgs e)
        {
            F_Product product = new F_Product();
            if (product.ShowDialog() == DialogResult.OK)
                listBox1.Items.Add(product.MyProduct);
        }
        private void bt_edit_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                F_Product product = new F_Product((listBox1.Items[listBox1.SelectedIndex] as Product).Name, (listBox1.Items[listBox1.SelectedIndex] as Product).Country, (listBox1.Items[listBox1.SelectedIndex] as Product).Cost);
                if(product.ShowDialog() == DialogResult.OK)
                    listBox1.Items[listBox1.SelectedIndex] = product.MyProduct;
            }
            else
                MessageBox.Show("Не выбрали товар для редактирования", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void bt_Del_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count != 0)
            {
                if (listBox1.SelectedIndex != -1)
                {
                    listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                }
                else
                    MessageBox.Show("Не выбрали товар для удаления", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Каталог пуст", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void bt_Clear_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count != 0)
                listBox1.Items.Clear();
            else
                MessageBox.Show("Каталог пуст", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}

