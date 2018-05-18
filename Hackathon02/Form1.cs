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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)//輸入加油紀錄
        {
            Form2 form2 = new Form2();
            this.Visible = false;
            form2.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)//查詢加油記錄畫面
        {
            Form3 form3 = new Form3();
            this.Visible = false;
            form3.Visible = true;
        }
    }
}
