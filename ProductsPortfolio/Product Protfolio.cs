using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;


namespace ProductsPortfolio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            panel_create.Visible = false;
            panel_principal.Visible = true;
            panel_update.Visible = false;
        }
        DataAccess objdDA = new DataAccess();

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btn_create_Click(object sender, EventArgs e)
        {
            panel_create.Visible = true;
            panel_principal.Visible = false;
            panel_update.Visible = false;
            btn_update.Enabled = false;
            btn_delete.Enabled = false;
        }

        private void btn_update_Click(object sender, EventArgs e)
        {

            try
            {
                panel_create.Visible = false;
                panel_principal.Visible = false;
                panel_update.Visible = true;
                btn_delete.Enabled = false;

                string value_update_name = (string)dataGridView1.CurrentRow.Cells[0].Value;
                double value_update_price = (double)dataGridView1.CurrentRow.Cells[1].Value;
                int value_update_cat = (int)dataGridView1.CurrentRow.Cells[2].Value;

                textBox_name_update.Text = value_update_name;
                textBox_price_update.Text = "" + value_update_price;
                textBox_category_update.Text = "" + value_update_cat;
            }
            catch(Exception ex)
            {
                panel_create.Visible = false;
                panel_principal.Visible = true;
                panel_update.Visible = false;
                btn_delete.Enabled = true;
                MessageBox.Show("No selected product");
            }
            
        }

        private void button_back_update_Click(object sender, EventArgs e)
        {
            panel_create.Visible = false;
            panel_principal.Visible = true;
            panel_update.Visible = false;
            btn_create.Enabled = true;
            btn_delete.Enabled = true;
        }

        private void btn_back_create_Click(object sender, EventArgs e)
        {
            panel_create.Visible = false;
            panel_principal.Visible = true;
            panel_update.Visible = false;
            btn_update.Enabled = true;
            btn_delete.Enabled = true;
            this.dataGridView1.Refresh();
        }

        private void btn_reset_create_Click(object sender, EventArgs e)
        {
            textBox_name_create.Text = "";
            textBox_price_create.Text = "";
            textBox_category_create.ResetText();
        }

        private void button_reset_update_Click(object sender, EventArgs e)
        {
            textBox_name_update.Text = "";
            textBox_price_update.Text = "";
            textBox_category_update.ResetText();
        }

        private void btn_accept_create_Click(object sender, EventArgs e)
        {
            
            try
            {
                string sql = "insert into T01_PRODUCTS (NAMEPROD, PRICEPROD, CATEPROD) values ('" + textBox_name_create.Text + "','" + textBox_price_create.Text + "','" + textBox_category_create.Text + "')";
                if (objdDA.insert(sql))
                {
                    MessageBox.Show("Product successfully created");
                    this.dataGridView1.Refresh();
                    Application.Restart();
                }
            }
            catch (Exception ex)
            {
               MessageBox.Show("Error");
            }
            
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                string delete_value_name = (string)dataGridView1.CurrentRow.Cells[0].Value;
                /*double valor2 = (double)dataGridView1.CurrentRow.Cells[1].Value;
                int valor3 = (int)dataGridView1.CurrentRow.Cells[2].Value;
                MessageBox.Show(valor1 +" "+valor2+ " "+valor3);*/
                if (objdDA.delete("T01_PRODUCTS", "NAMEPROD='" + delete_value_name+"'"))
                {
                    MessageBox.Show("Product successfully removed");
                    this.dataGridView1.Refresh();
                }
                dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
            }
            catch(Exception ex)
            {
                MessageBox.Show("No selected product");
            }
            

        }

        private void button_accept_update_Click(object sender, EventArgs e)
        {
            try {
                string fields = "NAMEPROD'" + textBox_name_update.Text + "', PRICEPROD='" + textBox_price_update.Text + "', CATEPROD='" + textBox_category_update.Text + "'";
                if (objdDA.update("T01_PRODUCTS", fields, "NAMEPROD='" + textBox_name_update.Text + "'"))
                {
                    MessageBox.Show("Product Updated");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating product");
            }
            
      

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            objdDA.consult("select NAMEPROD, PRICEPROD, CATEPROD from T01_PRODUCTS", "T01_PRODUCTS");
            this.dataGridView1.DataSource = objdDA.ds.Tables["T01_PRODUCTS"];
            this.dataGridView1.Refresh();
        }

        private void textBox_price_update_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
                e.Handled = true;
            else if (char.IsSymbol(e.KeyChar))
                e.Handled = true;
            else if (char.IsPunctuation(e.KeyChar))
                e.Handled = true;
        }

        private void textBox_name_update_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsSymbol(e.KeyChar))
                e.Handled = true;
            else if (char.IsPunctuation(e.KeyChar))
                e.Handled = true;
        }

        private void textBox_category_update_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
                e.Handled = true;
            else if (char.IsSymbol(e.KeyChar))
                e.Handled = true;
            else if (char.IsPunctuation(e.KeyChar))
                e.Handled = true;
        }

        private void textBox_name_create_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsSymbol(e.KeyChar))
                e.Handled = true;
            else if (char.IsPunctuation(e.KeyChar))
                e.Handled = true;
        }


        private void textBox_category_create_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
                e.Handled = true;
            else if (char.IsSymbol(e.KeyChar))
                e.Handled = true;
            else if (char.IsPunctuation(e.KeyChar))
                e.Handled = true;
        }

        private void textBox_price_create_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
                e.Handled = true;
            else if (char.IsSymbol(e.KeyChar))
                e.Handled = true;
            else if (char.IsPunctuation(e.KeyChar))
                e.Handled = true;
        }

    }
}
