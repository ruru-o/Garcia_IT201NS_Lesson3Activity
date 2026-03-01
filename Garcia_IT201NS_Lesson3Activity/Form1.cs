using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Garcia_IT201NS_Lesson3Activity
{
    public partial class Form1 : Form
    {
      
        
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Items loaded in Form1_Load
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void textBox27_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void textBox67_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox68_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox70_TextChanged(object sender, EventArgs e)
        {

        }

        private void label35_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            textBox10.Clear();
            textBox11.Clear();
            textBox12.Clear();
            textBox13.Clear();
            textBox14.Clear();
            textBox15.Clear();
            textBox16.Clear();
            textBox17.Clear();
            textBox18.Clear();
            textBox19.Clear();
            textBox20.Clear();
            textBox21.Clear();
            textBox22.Clear();
            textBox23.Clear();
            textBox24.Clear();
            textBox25.Clear();
            textBox26.Clear();
            textBox27.Clear();
            textBox28.Clear();
            textBox29.Clear();
            textBox30.Clear();
            textBox31.Clear();
            textBox32.Clear();
            textBox33.Clear();
            textBox34.Clear();
            textBox35.Clear();
            textBox36.Clear();
            textBox37.Clear();
            textBox38.Clear();
            textBox39.Clear();
            textBox40.Clear();
            textBox41.Clear();
            textBox42.Clear();
            textBox43.Clear();
            textBox44.Clear();
            textBox45.Clear();
            textBox46.Clear();
            textBox47.Clear();
            textBox48.Clear();
            textBox49.Clear();
            textBox50.Clear();
            textBox51.Clear();
            textBox52.Clear();
            textBox53.Clear();
            textBox54.Clear();
            textBox55.Clear();
            textBox56.Clear();
            textBox57.Clear();
            textBox58.Clear();
            textBox59.Clear();
            textBox60.Clear();
            textBox61.Clear();
            textBox62.Clear();
            textBox63.Clear();
            textBox64.Clear();
            textBox65.Clear();
            
        }

        private void textBox66_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double LEC_FEE = 1500;
            double LAB_FEE = 2500;
            double CISCO_FEE = 4500;
            double EXAM_FEE = 450;
            double SAP_FEE = 2000;
            double DOWNPAYMENT = 8000;

            double unitLecture1 = Convert.ToDouble(textBox24.Text);
            double unitLecture2 = Convert.ToDouble(textBox25.Text);
            double unitLecture3 = Convert.ToDouble(textBox26.Text);
            double unitLecture4 = Convert.ToDouble(textBox27.Text);
            double unitLecture5 = Convert.ToDouble(textBox28.Text);
            double unitLecture6 = Convert.ToDouble(textBox29.Text);
            double unitLecture7 = Convert.ToDouble(textBox30.Text);

            double unitLab1 = Convert.ToDouble(textBox31.Text);
            double unitLab2 = Convert.ToDouble(textBox32.Text);
            double unitLab3 = Convert.ToDouble(textBox33.Text);
            double unitLab4 = Convert.ToDouble(textBox34.Text);
            double unitLab5 = Convert.ToDouble(textBox35.Text);
            double unitLab6 = Convert.ToDouble(textBox36.Text);
            double unitLab7 = Convert.ToDouble(textBox37.Text);

            double totalunits1 = unitLecture1 + unitLab1;
            double totalunits2 = unitLecture2 + unitLab2;
            double totalunits3 = unitLecture3 + unitLab3;
            double totalunits4 = unitLecture4 + unitLab4;
            double totalunits5 = unitLecture5 + unitLab5;
            double totalunits6 = unitLecture6 + unitLab6;
            double totalunits7 = unitLecture7 + unitLab7;

            textBox38.Text = totalunits1.ToString();
            textBox39.Text = totalunits2.ToString();
            textBox40.Text = totalunits3.ToString();
            textBox41.Text = totalunits4.ToString();
            textBox42.Text = totalunits5.ToString();
            textBox43.Text = totalunits6.ToString();
            textBox44.Text = totalunits7.ToString();

            double total = 0;

            total += Convert.ToDouble(textBox38.Text);
            total += Convert.ToDouble(textBox39.Text);
            total += Convert.ToDouble(textBox40.Text);
            total += Convert.ToDouble(textBox41.Text);
            total += Convert.ToDouble(textBox42.Text);
            total += Convert.ToDouble(textBox43.Text);
            total += Convert.ToDouble(textBox44.Text);

            textBox66.Text = total.ToString();

            double totalLecUnits = unitLecture1 + unitLecture2 + unitLecture3 + unitLecture4 + unitLecture5 + unitLecture6 + unitLecture7;
            double totalTuition = totalLecUnits * LEC_FEE;
            textBox67.Text = totalTuition.ToString();

            double totalLabUnits = unitLab1 + unitLab2 + unitLab3 + unitLab4 + unitLab5 + unitLab6 + unitLab7;
            double totalLabFee = totalLabUnits * LAB_FEE;

            textBox69.Text = totalLabFee.ToString();

            // Miscellaneous fee = CISCO + SAP + EXAM only (lab fee is separate)
            double totalmiscellaneousfee = CISCO_FEE + SAP_FEE + EXAM_FEE;

            textBox68.Text = totalLabFee.ToString();   // Lab fee display
            textBox73.Text = totalmiscellaneousfee.ToString();  // Misc fee display

            double totaltuitionandfee = totalTuition + totalLabFee + totalmiscellaneousfee;
            textBox74.Text = totaltuitionandfee.ToString();

            textBox70.Text = SAP_FEE.ToString();
            textBox71.Text = CISCO_FEE.ToString();
            textBox72.Text = EXAM_FEE.ToString();

            // Installment computation: balance after downpayment split into 3 equal payments
            double balance = totaltuitionandfee - DOWNPAYMENT;
            double installment = Math.Round(balance / 3, 2);

            textBox75.Text = "Installment";
            textBox76.Text = "No Charge";
            textBox77.Text = DOWNPAYMENT.ToString();
            textBox78.Text = installment.ToString();
            textBox79.Text = installment.ToString();
            textBox80.Text = installment.ToString();
            textBox82.Text = totaltuitionandfee.ToString();
            textBox81.Text = totaltuitionandfee.ToString();
            textBox84.Text = "0"; 
        }

        private void textBox24_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox25_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox26_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox28_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox29_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox30_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox31_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox37_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox38_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox44_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox69_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox71_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox72_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox73_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox74_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox75_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox76_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox77_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox80_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox83_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox65_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox23_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox51_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox58_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            comboBox3.SelectedIndex = -1;
        }

        private void textBox82_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox81_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox54_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox55_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // comboBox2 and comboBox3 items are added here since they are not pre-set in the Designer.
            // comboBox1 items are already set in InitializeComponent, so we skip those to avoid duplicates.
            if (comboBox2.Items.Count == 0)
            {
                comboBox2.Items.Add("1st Year");
                comboBox2.Items.Add("2nd Year");
                comboBox2.Items.Add("3rd Year");
                comboBox2.Items.Add("4th Year");
            }

            if (comboBox3.Items.Count == 0)
            {
                comboBox3.Items.Add("1st Semester");
                comboBox3.Items.Add("2nd Semester");
                comboBox3.Items.Add("Summer");
            }
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }
    }
}
