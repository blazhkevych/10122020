using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlTEst
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonADD_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(textBoxA.Text, out double a))
            {
                MessageBox.Show("Введіть число в А", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!double.TryParse(textBoxB.Text, out double b))
            {
                MessageBox.Show("Введіть число в B", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            textBoxRes.Text = "" + (a + b);
        }
        private void textBoxAandB_TextChanged(object sender, EventArgs e)
        {
            textBoxRes.Text = "";
        }

        private void buttonEQ_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(textBoxA.Text, out double a))
            {
                MessageBox.Show("Введіть число в А", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!double.TryParse(textBoxB.Text, out double b))
            {
                MessageBox.Show("Введіть число в B", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            //if (radioButton1.Checked)            
            //    textBoxRes2.Text = "" + (a + b);
            //if (radioButton2.Checked)
            //    textBoxRes2.Text = "" + (a - b);
            //if (radioButton3.Checked)
            //    textBoxRes2.Text = "" + (a * b);
            //if (radioButton4.Checked)
            //    textBoxRes2.Text = "" + (a / b);

            //if (radioButton1.Checked)
            //    textBoxRes2.Text = "" + (a + b);
            //else
            //{
            //    if (radioButton2.Checked)
            //        textBoxRes2.Text = "" + (a - b);
            //    else
            //    {
            //        if (radioButton3.Checked)
            //            textBoxRes2.Text = "" + (a * b);
            //        else
            //            textBoxRes2.Text = "" + (a / b);
            //    }
            //}

            //Controls
            char? zn = ' ';
            //foreach (var item in Controls)
            //{
            //    if (item is RadioButton RB && RB.Checked) {
            //        zn = RB.Text[0];
            //        break;
            //    }
            //}   
            //zn = Controls
            //    .OfType<RadioButton>()
            //    .Where(r => r.Checked)
            //    .Select(r=>r.Text[0])
            //    .FirstOrDefault();
            zn = Controls
               .OfType<RadioButton>()
               .FirstOrDefault(r => r.Checked)
               ?.Text.FirstOrDefault();

            switch (zn)
            {
                case '+': textBoxRes2.Text = "" + (a + b); break;
                case '-': textBoxRes2.Text = "" + (a - b); break;
                case '*': textBoxRes2.Text = "" + (a * b); break;
                case '/': textBoxRes2.Text = "" + (a / b); break;
                default:  textBoxRes2.Text = ""; break;
            }



        }


    }
}
