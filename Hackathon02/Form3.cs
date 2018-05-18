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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)//回主畫面
        {
            Form1 form1 = new Form1();
            this.Visible = false;
            form1.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)//查詢
        {
            //選擇日期的公里相加/公升相加
            DateTime start = new DateTime(dateTimePicker1.Value.Year, dateTimePicker1.Value.Month, dateTimePicker1.Value.Day);
            DateTime end = new DateTime(dateTimePicker2.Value.Year, dateTimePicker2.Value.Month, dateTimePicker2.Value.Day);
            var day = end.AddDays(1);

            var total = new OilModel2();
            var distar = total.RefuelTable.Where((x) => x.RefuelingDate >= start).Where((y) => y.RefuelingDate <= day).ToList();
            dataGridView1.DataSource = distar;
            float k = 0, l1 = 0, l2 = 0, count = 0;
            l1 = (float)distar[0].Liter;
            l2 = (float)distar[distar.Count - 1].Liter;
            k = (float)distar[distar.Count - 1].Kilometer;
            count = k / (l1 - l2);
            label4.Text = count.ToString();
        }
    }
}
