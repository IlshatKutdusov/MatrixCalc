using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Visible = true;
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;
            textBox6.Visible = false;
            textBox7.Visible = false;
            textBox8.Visible = false;
            textBox9.Visible = false;

            textBox11.Visible = true;
            textBox12.Visible = false;
            textBox13.Visible = false;
            textBox14.Visible = false;
            textBox15.Visible = false;
            textBox16.Visible = false;
            textBox17.Visible = false;
            textBox18.Visible = false;
            textBox19.Visible = false;

            textBox111.Visible = true;
            textBox112.Visible = false;
            textBox113.Visible = false;
            textBox114.Visible = false;
            textBox115.Visible = false;
            textBox116.Visible = false;
            textBox117.Visible = false;
            textBox118.Visible = false;
            textBox119.Visible = false;

            textBox111.Text = "";
            textBox112.Text = "";
            textBox113.Text = "";
            textBox114.Text = "";
            textBox115.Text = "";
            textBox116.Text = "";
            textBox117.Text = "";
            textBox118.Text = "";
            textBox119.Text = "";

            Random random = new Random();

            textBox1.Text = Convert.ToString(random.Next(-5, 6));
            textBox2.Text = Convert.ToString(random.Next(-5, 6));
            textBox3.Text = Convert.ToString(random.Next(-5, 6));
            textBox4.Text = Convert.ToString(random.Next(-5, 6));
            textBox5.Text = Convert.ToString(random.Next(-5, 6));
            textBox6.Text = Convert.ToString(random.Next(-5, 6));
            textBox7.Text = Convert.ToString(random.Next(-5, 6));
            textBox8.Text = Convert.ToString(random.Next(-5, 6));
            textBox9.Text = Convert.ToString(random.Next(-5, 6));

            textBox11.Text = Convert.ToString(random.Next(-5, 6));
            textBox12.Text = Convert.ToString(random.Next(-5, 6));
            textBox13.Text = Convert.ToString(random.Next(-5, 6));
            textBox14.Text = Convert.ToString(random.Next(-5, 6));
            textBox15.Text = Convert.ToString(random.Next(-5, 6));
            textBox16.Text = Convert.ToString(random.Next(-5, 6));
            textBox17.Text = Convert.ToString(random.Next(-5, 6));
            textBox18.Text = Convert.ToString(random.Next(-5, 6));
            textBox19.Text = Convert.ToString(random.Next(-5, 6));

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = false;
            textBox4.Visible = true;
            textBox5.Visible = true;
            textBox6.Visible = false;
            textBox7.Visible = false;
            textBox8.Visible = false;
            textBox9.Visible = false;

            textBox11.Visible = true;
            textBox12.Visible = true;
            textBox13.Visible = false;
            textBox14.Visible = true;
            textBox15.Visible = true;
            textBox16.Visible = false;
            textBox17.Visible = false;
            textBox18.Visible = false;
            textBox19.Visible = false;

            textBox111.Visible = true;
            textBox112.Visible = true;
            textBox113.Visible = false;
            textBox114.Visible = true;
            textBox115.Visible = true;
            textBox116.Visible = false;
            textBox117.Visible = false;
            textBox118.Visible = false;
            textBox119.Visible = false;

            textBox111.Text = "";
            textBox112.Text = "";
            textBox113.Text = "";
            textBox114.Text = "";
            textBox115.Text = "";
            textBox116.Text = "";
            textBox117.Text = "";
            textBox118.Text = "";
            textBox119.Text = "";

            Random random = new Random();

            textBox1.Text = Convert.ToString(random.Next(-5, 6));
            textBox2.Text = Convert.ToString(random.Next(-5, 6));
            textBox3.Text = Convert.ToString(random.Next(-5, 6));
            textBox4.Text = Convert.ToString(random.Next(-5, 6));
            textBox5.Text = Convert.ToString(random.Next(-5, 6));
            textBox6.Text = Convert.ToString(random.Next(-5, 6));
            textBox7.Text = Convert.ToString(random.Next(-5, 6));
            textBox8.Text = Convert.ToString(random.Next(-5, 6));
            textBox9.Text = Convert.ToString(random.Next(-5, 6));

            textBox11.Text = Convert.ToString(random.Next(-5, 6));
            textBox12.Text = Convert.ToString(random.Next(-5, 6));
            textBox13.Text = Convert.ToString(random.Next(-5, 6));
            textBox14.Text = Convert.ToString(random.Next(-5, 6));
            textBox15.Text = Convert.ToString(random.Next(-5, 6));
            textBox16.Text = Convert.ToString(random.Next(-5, 6));
            textBox17.Text = Convert.ToString(random.Next(-5, 6));
            textBox18.Text = Convert.ToString(random.Next(-5, 6));
            textBox19.Text = Convert.ToString(random.Next(-5, 6));
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
            textBox5.Visible = true;
            textBox6.Visible = true;
            textBox7.Visible = true;
            textBox8.Visible = true;
            textBox9.Visible = true;

            textBox11.Visible = true;
            textBox12.Visible = true;
            textBox13.Visible = true;
            textBox14.Visible = true;
            textBox15.Visible = true;
            textBox16.Visible = true;
            textBox17.Visible = true;
            textBox18.Visible = true;
            textBox19.Visible = true;

            textBox111.Visible = true;
            textBox112.Visible = true;
            textBox113.Visible = true;
            textBox114.Visible = true;
            textBox115.Visible = true;
            textBox116.Visible = true;
            textBox117.Visible = true;
            textBox118.Visible = true;
            textBox119.Visible = true;

            textBox111.Text = "";
            textBox112.Text = "";
            textBox113.Text = "";
            textBox114.Text = "";
            textBox115.Text = "";
            textBox116.Text = "";
            textBox117.Text = "";
            textBox118.Text = "";
            textBox119.Text = "";

            Random random = new Random();

            textBox1.Text = Convert.ToString(random.Next(-5, 6));
            textBox2.Text = Convert.ToString(random.Next(-5, 6));
            textBox3.Text = Convert.ToString(random.Next(-5, 6));
            textBox4.Text = Convert.ToString(random.Next(-5, 6));
            textBox5.Text = Convert.ToString(random.Next(-5, 6));
            textBox6.Text = Convert.ToString(random.Next(-5, 6));
            textBox7.Text = Convert.ToString(random.Next(-5, 6));
            textBox8.Text = Convert.ToString(random.Next(-5, 6));
            textBox9.Text = Convert.ToString(random.Next(-5, 6));

            textBox11.Text = Convert.ToString(random.Next(-5, 6));
            textBox12.Text = Convert.ToString(random.Next(-5, 6));
            textBox13.Text = Convert.ToString(random.Next(-5, 6));
            textBox14.Text = Convert.ToString(random.Next(-5, 6));
            textBox15.Text = Convert.ToString(random.Next(-5, 6));
            textBox16.Text = Convert.ToString(random.Next(-5, 6));
            textBox17.Text = Convert.ToString(random.Next(-5, 6));
            textBox18.Text = Convert.ToString(random.Next(-5, 6));
            textBox19.Text = Convert.ToString(random.Next(-5, 6));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox111.Text = Convert.ToString(Convert.ToInt32(textBox1.Text) + Convert.ToInt32(textBox11.Text));
            textBox112.Text = Convert.ToString(Convert.ToInt32(textBox2.Text) + Convert.ToInt32(textBox12.Text));
            textBox113.Text = Convert.ToString(Convert.ToInt32(textBox3.Text) + Convert.ToInt32(textBox13.Text));
            textBox114.Text = Convert.ToString(Convert.ToInt32(textBox4.Text) + Convert.ToInt32(textBox14.Text));
            textBox115.Text = Convert.ToString(Convert.ToInt32(textBox5.Text) + Convert.ToInt32(textBox15.Text));
            textBox116.Text = Convert.ToString(Convert.ToInt32(textBox6.Text) + Convert.ToInt32(textBox16.Text));
            textBox117.Text = Convert.ToString(Convert.ToInt32(textBox7.Text) + Convert.ToInt32(textBox17.Text));
            textBox118.Text = Convert.ToString(Convert.ToInt32(textBox8.Text) + Convert.ToInt32(textBox18.Text));
            textBox119.Text = Convert.ToString(Convert.ToInt32(textBox9.Text) + Convert.ToInt32(textBox19.Text));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox111.Text = Convert.ToString(Convert.ToInt32(textBox1.Text) - Convert.ToInt32(textBox11.Text));
            textBox112.Text = Convert.ToString(Convert.ToInt32(textBox2.Text) - Convert.ToInt32(textBox12.Text));
            textBox113.Text = Convert.ToString(Convert.ToInt32(textBox3.Text) - Convert.ToInt32(textBox13.Text));
            textBox114.Text = Convert.ToString(Convert.ToInt32(textBox4.Text) - Convert.ToInt32(textBox14.Text));
            textBox115.Text = Convert.ToString(Convert.ToInt32(textBox5.Text) - Convert.ToInt32(textBox15.Text));
            textBox116.Text = Convert.ToString(Convert.ToInt32(textBox6.Text) - Convert.ToInt32(textBox16.Text));
            textBox117.Text = Convert.ToString(Convert.ToInt32(textBox7.Text) - Convert.ToInt32(textBox17.Text));
            textBox118.Text = Convert.ToString(Convert.ToInt32(textBox8.Text) - Convert.ToInt32(textBox18.Text));
            textBox119.Text = Convert.ToString(Convert.ToInt32(textBox9.Text) - Convert.ToInt32(textBox19.Text));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1000.Text != "")
            {
                textBox111.Text = Convert.ToString(Convert.ToInt32(textBox1.Text) * Convert.ToInt32(textBox1000.Text));
                textBox112.Text = Convert.ToString(Convert.ToInt32(textBox2.Text) * Convert.ToInt32(textBox1000.Text));
                textBox113.Text = Convert.ToString(Convert.ToInt32(textBox3.Text) * Convert.ToInt32(textBox1000.Text));
                textBox114.Text = Convert.ToString(Convert.ToInt32(textBox4.Text) * Convert.ToInt32(textBox1000.Text));
                textBox115.Text = Convert.ToString(Convert.ToInt32(textBox5.Text) * Convert.ToInt32(textBox1000.Text));
                textBox116.Text = Convert.ToString(Convert.ToInt32(textBox6.Text) * Convert.ToInt32(textBox1000.Text));
                textBox117.Text = Convert.ToString(Convert.ToInt32(textBox7.Text) * Convert.ToInt32(textBox1000.Text));
                textBox118.Text = Convert.ToString(Convert.ToInt32(textBox8.Text) * Convert.ToInt32(textBox1000.Text));
                textBox119.Text = Convert.ToString(Convert.ToInt32(textBox9.Text) * Convert.ToInt32(textBox1000.Text));
            }
            else
            {
                if (radioButton1.Checked == true)
                {
                    textBox111.Text = Convert.ToString(Convert.ToInt32(textBox1.Text) * Convert.ToInt32(textBox11.Text));
                }
                if (radioButton2.Checked == true)
                {
                    Int32 a1, a2, b1, b2, c1;
                    a1 = Convert.ToInt32(textBox1.Text);
                    a2 = Convert.ToInt32(textBox2.Text);
                    b1 = Convert.ToInt32(textBox11.Text);
                    b2 = Convert.ToInt32(textBox14.Text);
                    c1 = a1 * b1 + a2 * b2;
                    textBox111.Text = Convert.ToString(c1);

                    a1 = Convert.ToInt32(textBox1.Text);
                    a2 = Convert.ToInt32(textBox2.Text);
                    b1 = Convert.ToInt32(textBox12.Text);
                    b2 = Convert.ToInt32(textBox15.Text);
                    c1 = a1 * b1 + a2 * b2;
                    textBox112.Text = Convert.ToString(c1);

                    a1 = Convert.ToInt32(textBox4.Text);
                    a2 = Convert.ToInt32(textBox5.Text);
                    b1 = Convert.ToInt32(textBox11.Text);
                    b2 = Convert.ToInt32(textBox14.Text);
                    c1 = a1 * b1 + a2 * b2;
                    textBox114.Text = Convert.ToString(c1);

                    a1 = Convert.ToInt32(textBox4.Text);
                    a2 = Convert.ToInt32(textBox5.Text);
                    b1 = Convert.ToInt32(textBox12.Text);
                    b2 = Convert.ToInt32(textBox15.Text);
                    c1 = a1 * b1 + a2 * b2;
                    textBox115.Text = Convert.ToString(c1);
                }
                if (radioButton3.Checked == true)
                {
                    Int32 a1, a2, a3, b1, b2, b3, c1;
                    a1 = Convert.ToInt32(textBox1.Text);
                    a2 = Convert.ToInt32(textBox2.Text);
                    a3 = Convert.ToInt32(textBox3.Text);
                    b1 = Convert.ToInt32(textBox11.Text);
                    b2 = Convert.ToInt32(textBox14.Text);
                    b3 = Convert.ToInt32(textBox17.Text);
                    c1 = a1 * b1 + a2 * b2 + a3 * b3;
                    textBox111.Text = Convert.ToString(c1);

                    a1 = Convert.ToInt32(textBox1.Text);
                    a2 = Convert.ToInt32(textBox2.Text);
                    a3 = Convert.ToInt32(textBox3.Text);
                    b1 = Convert.ToInt32(textBox12.Text);
                    b2 = Convert.ToInt32(textBox15.Text);
                    b3 = Convert.ToInt32(textBox18.Text);
                    c1 = a1 * b1 + a2 * b2 + a3 * b3;
                    textBox112.Text = Convert.ToString(c1);

                    a1 = Convert.ToInt32(textBox1.Text);
                    a2 = Convert.ToInt32(textBox2.Text);
                    a3 = Convert.ToInt32(textBox3.Text);
                    b1 = Convert.ToInt32(textBox13.Text);
                    b2 = Convert.ToInt32(textBox16.Text);
                    b3 = Convert.ToInt32(textBox19.Text);
                    c1 = a1 * b1 + a2 * b2 + a3 * b3;
                    textBox113.Text = Convert.ToString(c1);

                    a1 = Convert.ToInt32(textBox4.Text);
                    a2 = Convert.ToInt32(textBox5.Text);
                    a3 = Convert.ToInt32(textBox6.Text);
                    b1 = Convert.ToInt32(textBox11.Text);
                    b2 = Convert.ToInt32(textBox14.Text);
                    b3 = Convert.ToInt32(textBox17.Text);
                    c1 = a1 * b1 + a2 * b2 + a3 * b3;
                    textBox114.Text = Convert.ToString(c1);

                    a1 = Convert.ToInt32(textBox4.Text);
                    a2 = Convert.ToInt32(textBox5.Text);
                    a3 = Convert.ToInt32(textBox6.Text);
                    b1 = Convert.ToInt32(textBox12.Text);
                    b2 = Convert.ToInt32(textBox15.Text);
                    b3 = Convert.ToInt32(textBox18.Text);
                    c1 = a1 * b1 + a2 * b2 + a3 * b3;
                    textBox115.Text = Convert.ToString(c1);

                    a1 = Convert.ToInt32(textBox4.Text);
                    a2 = Convert.ToInt32(textBox5.Text);
                    a3 = Convert.ToInt32(textBox6.Text);
                    b1 = Convert.ToInt32(textBox13.Text);
                    b2 = Convert.ToInt32(textBox16.Text);
                    b3 = Convert.ToInt32(textBox19.Text);
                    c1 = a1 * b1 + a2 * b2 + a3 * b3;
                    textBox116.Text = Convert.ToString(c1);

                    a1 = Convert.ToInt32(textBox7.Text);
                    a2 = Convert.ToInt32(textBox8.Text);
                    a3 = Convert.ToInt32(textBox9.Text);
                    b1 = Convert.ToInt32(textBox11.Text);
                    b2 = Convert.ToInt32(textBox14.Text);
                    b3 = Convert.ToInt32(textBox17.Text);
                    c1 = a1 * b1 + a2 * b2 + a3 * b3;
                    textBox117.Text = Convert.ToString(c1);

                    a1 = Convert.ToInt32(textBox7.Text);
                    a2 = Convert.ToInt32(textBox8.Text);
                    a3 = Convert.ToInt32(textBox9.Text);
                    b1 = Convert.ToInt32(textBox12.Text);
                    b2 = Convert.ToInt32(textBox15.Text);
                    b3 = Convert.ToInt32(textBox18.Text);
                    c1 = a1 * b1 + a2 * b2 + a3 * b3;
                    textBox118.Text = Convert.ToString(c1);

                    a1 = Convert.ToInt32(textBox7.Text);
                    a2 = Convert.ToInt32(textBox8.Text);
                    a3 = Convert.ToInt32(textBox9.Text);
                    b1 = Convert.ToInt32(textBox13.Text);
                    b2 = Convert.ToInt32(textBox16.Text);
                    b3 = Convert.ToInt32(textBox19.Text);
                    c1 = a1 * b1 + a2 * b2 + a3 * b3;
                    textBox119.Text = Convert.ToString(c1);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox111.Text = textBox1.Text;
            textBox112.Text = textBox4.Text;
            textBox113.Text = textBox7.Text;
            textBox114.Text = textBox2.Text;
            textBox115.Text = textBox5.Text;
            textBox116.Text = textBox8.Text;
            textBox117.Text = textBox3.Text;
            textBox118.Text = textBox6.Text;
            textBox119.Text = textBox9.Text;
        }

        private void textBox1000_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44 && number != 45) //цифры, клавиша BackSpace, запятая и минус в ASCII 
            {
                e.Handled = true;
            }
        }
    }
}
