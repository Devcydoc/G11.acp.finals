using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Thrifting_Treasures
{
    public partial class inventory : Form
    {
        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=");
        MySqlCommand command;
        MySqlDataReader mdr;

        public inventory()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1.ForeColor = System.Drawing.Color.BlueViolet;
            radioButton2.ForeColor = System.Drawing.Color.RosyBrown;
            radioButton3.ForeColor = System.Drawing.Color.BlueViolet;
            radioButton4.ForeColor = System.Drawing.Color.RosyBrown;
            radioButton5.ForeColor = System.Drawing.Color.BlueViolet;
            radioButton6.ForeColor = System.Drawing.Color.RosyBrown;
            comboBox1.Items.Clear();
            comboBox1.Items.AddRange(new string[] { "Shirt", "Jeans", "Jacket", "Shoes", "Underwear" });
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1.ForeColor = System.Drawing.Color.RosyBrown;
            radioButton2.ForeColor = System.Drawing.Color.BlueViolet;
            radioButton3.ForeColor = System.Drawing.Color.BlueViolet;
            radioButton4.ForeColor = System.Drawing.Color.RosyBrown;
            radioButton5.ForeColor = System.Drawing.Color.BlueViolet;
            radioButton6.ForeColor = System.Drawing.Color.RosyBrown;
            comboBox1.Items.Clear();
            comboBox1.Items.AddRange(new string[] { "Blouse", "Skirt", "Dress", "Shoes", "Scarf" });
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1.ForeColor = System.Drawing.Color.BlueViolet;
            radioButton2.ForeColor = System.Drawing.Color.RosyBrown;
            radioButton3.ForeColor = System.Drawing.Color.BlueViolet;
            radioButton4.ForeColor = System.Drawing.Color.RosyBrown;
            radioButton5.ForeColor = System.Drawing.Color.BlueViolet;
            radioButton6.ForeColor = System.Drawing.Color.RosyBrown;
            comboBox1.Items.Clear();
            comboBox1.Items.AddRange(new string[] { "T-Shirt", "Shorts", "Jacket", "Shoes", "Underwear" });
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1.ForeColor = System.Drawing.Color.RosyBrown;
            radioButton2.ForeColor = System.Drawing.Color.BlueViolet;
            radioButton3.ForeColor = System.Drawing.Color.BlueViolet;
            radioButton4.ForeColor = System.Drawing.Color.RosyBrown;
            radioButton5.ForeColor = System.Drawing.Color.BlueViolet;
            radioButton6.ForeColor = System.Drawing.Color.RosyBrown;
            comboBox1.Items.Clear();
            comboBox1.Items.AddRange(new string[] { "Blouse", "Skirt", "Dress", "Sandals", "Underwear" });
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1.ForeColor = System.Drawing.Color.BlueViolet;
            radioButton2.ForeColor = System.Drawing.Color.RosyBrown;
            radioButton3.ForeColor = System.Drawing.Color.BlueViolet;
            radioButton4.ForeColor = System.Drawing.Color.RosyBrown;
            radioButton5.ForeColor = System.Drawing.Color.BlueViolet;
            radioButton6.ForeColor = System.Drawing.Color.RosyBrown;
            comboBox1.Items.Clear();
            comboBox1.Items.AddRange(new string[] { "Onesie", "Pants", "Jumpsuit", "Shoes", "Accessories" });
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1.ForeColor = System.Drawing.Color.RosyBrown;
            radioButton2.ForeColor = System.Drawing.Color.BlueViolet;
            radioButton3.ForeColor = System.Drawing.Color.BlueViolet;
            radioButton4.ForeColor = System.Drawing.Color.RosyBrown;
            radioButton5.ForeColor = System.Drawing.Color.BlueViolet;
            radioButton6.ForeColor = System.Drawing.Color.RosyBrown;
            comboBox1.Items.Clear();
            comboBox1.Items.AddRange(new string[] { "HandBag", "Backpack", "MessengerBag", "HandBag", "ShoulderBag" });
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "Shirt")
            {
                textBox1.Text = "50";
            }
            else if (comboBox1.SelectedItem.ToString() == "Jeans")
            {
                textBox1.Text = "80";
            }
            else if (comboBox1.SelectedItem.ToString() == "Jacket")
            {
                textBox1.Text = "120";
            }
            else if (comboBox1.SelectedItem.ToString() == "Shoes")
            {
                textBox1.Text = "150";
            }
            else if (comboBox1.SelectedItem.ToString() == "Underwear")
            {
                textBox1.Text = "30";
            }
            else if (comboBox1.SelectedItem.ToString() == "Blouse")
            {
                textBox1.Text = "40";
            }
            else if (comboBox1.SelectedItem.ToString() == "Skirt")
            {
                textBox1.Text = "60";
            }
            else if (comboBox1.SelectedItem.ToString() == "Dress")
            {
                textBox1.Text = "100";
            }
            else if (comboBox1.SelectedItem.ToString() == "Sandals")
            {
                textBox1.Text = "120";
            }
            else if (comboBox1.SelectedItem.ToString() == "scarf")
            {
                textBox1.Text = "25";
            }
            else if (comboBox1.SelectedItem.ToString() == "T-Shirts")
            {
                textBox1.Text = "30";
            }
            else if (comboBox1.SelectedItem.ToString() == "Shorts")
            {
                textBox1.Text = "40";
            }
            else if (comboBox1.SelectedItem.ToString() == "Hoodie")
            {
                textBox1.Text = "80";
            }
            else if (comboBox1.SelectedItem.ToString() == "Shoes")
            {
                textBox1.Text = "100";
            }
            else if (comboBox1.SelectedItem.ToString() == "Underwear")
            {
                textBox1.Text = "20";
            }
            else if (comboBox1.SelectedItem.ToString() == "Blouse")
            {
                textBox1.Text = "35";
            }
            else if (comboBox1.SelectedItem.ToString() == "Skirt")
            {
                textBox1.Text = "50";
            }
            else if (comboBox1.SelectedItem.ToString() == "Dress")
            {
                textBox1.Text = "90";
            }
            else if (comboBox1.SelectedItem.ToString() == "Sandals")
            {
                textBox1.Text = "110";
            }
            else if (comboBox1.SelectedItem.ToString() == "Underwear")
            {
                textBox1.Text = "25";
            }
            else if (comboBox1.SelectedItem.ToString() == "Onesie")
            {
                textBox1.Text = "25";
            }
            else if (comboBox1.SelectedItem.ToString() == "Pants")
            {
                textBox1.Text = "30";
            }
            else if (comboBox1.SelectedItem.ToString() == "Jumpsuits")
            {
                textBox1.Text = "50";
            }
            else if (comboBox1.SelectedItem.ToString() == "Shoes")
            {
                textBox1.Text = "40";
            }
            else if (comboBox1.SelectedItem.ToString() == "Accessories")
            {
                textBox1.Text = "15";
            }
            else if (comboBox1.SelectedItem.ToString() == "HandBag")
            {
                textBox1.Text = "250";
            }
            else if (comboBox1.SelectedItem.ToString() == "Backpack")
            {
                textBox1.Text = "570";
            }
            else if (comboBox1.SelectedItem.ToString() == "MessengerBag")
            {
                textBox1.Text = "450";
            }
            else if (comboBox1.SelectedItem.ToString() == "HandBag")
            {
                textBox1.Text = "140";
            }
            else if (comboBox1.SelectedItem.ToString() == "ShoulderBag")
            {
                textBox1.Text = "320";
            }
            else
            {
                textBox1.Text = "0";
            }
            textBox3.Text = "";
            textBox2.Text = "";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text.Length > 0)
            {
                textBox3.Text = (Convert.ToInt64(textBox1.Text) * Convert.ToInt64(textBox2.Text)).ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(comboBox1.Text, textBox1.Text, textBox2.Text, textBox3.Text);
            textBox4.Text = (Convert.ToInt16(textBox4.Text) + Convert.ToInt16(textBox3.Text)).ToString();
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                for (int i = 0; i < dataGridView1.SelectedRows.Count; i++)
                {
                    if (dataGridView1.Rows[i].Selected)
                    {
                        textBox4.Text = (Convert.ToInt16(textBox4.Text) - Convert.ToInt16(dataGridView1.Rows[i].Cells[4].Value)).ToString();
                        dataGridView1.Rows.RemoveAt(i);
                    }
                }
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (textBox5.Text.Length > 0)
            {
                textBox6.Text = (Convert.ToInt16(textBox4.Text) - Convert.ToInt16(textBox5.Text)).ToString();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                decimal totalValue = 0; // Provide a default value or handle null appropriately

                if (dataGridView1.Rows[i].Cells[3].Value != null)
                {
                    totalValue = Convert.ToDecimal(dataGridView1.Rows[i].Cells[3].Value);
                }

                MySqlCommand cmd = new MySqlCommand("USE loginform; INSERT INTO item_tbl (Name, Price, Quantity, Total) VALUES (@Value1, @Value2, @Value3, @Value4)", connection);

                cmd.Parameters.AddWithValue("@Value1", dataGridView1.Rows[i].Cells[0].Value?.ToString());
                cmd.Parameters.AddWithValue("@Value2", dataGridView1.Rows[i].Cells[1].Value?.ToString());
                cmd.Parameters.AddWithValue("@Value3", dataGridView1.Rows[i].Cells[2].Value?.ToString());
                cmd.Parameters.AddWithValue("@Value4", totalValue.ToString()); // Use the non-null value

                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
            }

        }

        private void inventory_Load(object sender, EventArgs e)
        {
            // connection.Open();
            // if (connection.State == ConnectionState.Open)
            // {
            //      MessageBox.Show("Successfull DB Connection");
            //      connection.Close();
            //}
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Hide();
            loaddata ldform = new loaddata();
            ldform.ShowDialog();
            ldform = null;
            this.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
