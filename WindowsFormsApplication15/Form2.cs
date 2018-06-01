using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication15
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Цей калькулятор допоможе вам з пiдрахунком матерiалiв при проладання мережi iнтернет! Все що вам потрібно зробити - це заповнити поля з вашими даними та натиснути на клавішу 'Підрахувти'.");

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                return;
            }
            if (e.KeyChar == '.')
            {
                e.KeyChar = ',';
            }
            if (e.KeyChar == ',')
            {
                if (textBox1.Text.IndexOf(',') != -1)
                {
                    e.Handled = true;
                }
                return;
            }
            if (Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Enter)
                    textBox2.Focus();
                return;
            }
            e.Handled = true;
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                return;
            }
            if (e.KeyChar == '.')
            {
                e.KeyChar = ',';
            }
            if (e.KeyChar == ',')
            {
                if (textBox2.Text.IndexOf(',') != -1)
                {
                    e.Handled = true;
                }
                return;
            }
            if (Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Enter)
                    button1.Focus();
                return;
            }
            e.Handled = true;
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                return;
            }
            if (Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Enter)
                    button1.Focus();
                return;
            }
            e.Handled = true;
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                return;
            }
            if (Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Enter)
                    button1.Focus();
                return;
            }
            e.Handled = true;
        }
        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                return;
            }
            if (Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Enter)
                    button1.Focus();
                return;
            }
            e.Handled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double width;
            double height;
            double area;
            double connect;
            double cable;
            double mediumlength;
            double n;
            double packaging;
            double cablelength;
            double connectors;
            double ports;
            double switches;
            double x = 0;
            try
            {
                width = Convert.ToDouble(textBox2.Text);
                height = Convert.ToDouble(textBox1.Text);
                connect = Convert.ToDouble(textBox3.Text);
                cable = Convert.ToDouble(textBox4.Text);
                ports = Convert.ToDouble(textBox5.Text);
                area = width * height;

                

                if (area <= 10d) x = 0.6;
                if ((area > 10d) && (area <= 20d)) x = 0.8;
                if (area > 20d) x = 1;


                mediumlength = (width + height) / 2 * 1.1 + x;
                n = cable / mediumlength;
                packaging = (connect*2)  / n;
                cablelength = packaging * cable;
                connectors = connect * 2 + 1;
                switches = connectors / ports;


                label1.Text = area.ToString();
                label2.Text = Math.Ceiling(packaging).ToString();
                label3.Text = Math.Ceiling(cablelength).ToString();
                label4.Text = connectors.ToString();
                label16.Text = Math.Ceiling(switches).ToString();
                 }
            catch
            {
                textBox1.Focus();
            }
            }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        

        }
    }




      

