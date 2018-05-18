using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hackathon04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int time = 0;
        int money1 = 0;
        int money2 = 0;
        int money3 = 0;

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            time = (int)numericUpDown1.Value;
            tele1();
            tele2();
            tele3();

            List<Class1> total = new List<Class1>()
            {
                new Class1(){ name = "中華電信", price=money1 },
                new Class1() { name = "遠傳", price = money2 },
                new Class1(){ name = "台灣大哥大", price = money3}
            };

            int min = total.Min((x) => x.price);
            label11.Text = "";
            foreach (var i in total)
            {
                if (i.price == min)
                {
                    label11.Text += i.name + "   ";
                }
            }
        }

        private void tele1()
        {
            money1 = 350 + time * 4;
            label5.Text = money1.ToString("C0");
        }

        private void tele2()
        {
            money2 = 400 + time * 3;
            label7.Text = money2.ToString("C0");
        }

        private void tele3()
        {
            money3 = 500 + time * 2;
            label9.Text = money3.ToString("C0");
        }
    }
}
