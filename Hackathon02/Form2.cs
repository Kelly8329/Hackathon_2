using Hackathon02.Refuel2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hackathon02
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            numericUpDown1.DecimalPlaces = 2;
            numericUpDown1.ThousandsSeparator = true;
            numericUpDown2.DecimalPlaces = 2;
            numericUpDown2.ThousandsSeparator = true;
        }

        private void Form2_Load(object sender, EventArgs e)
        { 
        }

        private void button1_Click(object sender, EventArgs e)//回主畫面
        {
            Form1 form1 = new Form1();
            this.Visible = false;
            form1.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RefuelTable data = new RefuelTable()
            {
                RefuelingDate = dateTimePicker1.Value,
                Liter = (float)(numericUpDown1.Value),
                Kilometer = (float)(numericUpDown2.Value)
            };

            try
            {
                OilModel2 oiltext = new OilModel2();

                oiltext.RefuelTable.Add(data);
                oiltext.SaveChanges();
                MessageBox.Show("完成輸入");
            }
            catch
            {
                MessageBox.Show("輸入錯誤！");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
