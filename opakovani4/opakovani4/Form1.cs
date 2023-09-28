using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace opakovani4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.CenterToScreen();
            this.ShowIcon = false;
            this.Text = "Ukol 4";
            button2.Visible = false;
            button3.Visible = false;        
            button5.Visible = false;
        }

        SportovecAmater sportovecA;
        SportovecProfesional sportovecP;
        private void button1_Click(object sender, EventArgs e)
        {
            sportovecA = new SportovecAmater(textBox1.Text, (double)numericUpDown1.Value, (double)numericUpDown2.Value);
            label5.Text = sportovecA.ToString();
            button2.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sportovecA.Trenuj((int)numericUpDown3.Value);
            label5.Text = sportovecA.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            sportovecP = new SportovecProfesional(textBox2.Text, (double)numericUpDown6.Value, (double)numericUpDown5.Value,dateTimePicker1.Value,(double)numericUpDown8.Value);
            label13.Text = sportovecP.ToString();
            button3.Visible = true;
            button5.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            sportovecP.StupenVykonosti = (int)numericUpDown7.Value;
            label13.Text = sportovecP.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sportovecP.Trenuj((int)numericUpDown4.Value);
            label13.Text = sportovecP.ToString();
        }
    }
}
