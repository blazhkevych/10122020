using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10122020
{
    public partial class Form1 : Form
    {
        private Random random;
        public Form1()
        {
            InitializeComponent();
            random = new Random(DateTime.Now.Millisecond);
        }      

        private void button1_Click(object sender, EventArgs e)
        {           
            MessageBox.Show(
                "Продовжуй навчання",
                "Молодець", 
                MessageBoxButtons.OK,
                MessageBoxIcon.Information 
               // ,MessageBoxDefaultButton.Button3                
                );
        }

        private void buttonNO_MouseEnter(object sender, EventArgs e)
        {
            int xmax = this.ClientSize.Width - buttonNO.Width ;
            int ymax = this.ClientSize.Height - buttonNO.Height;

            buttonNO.Location = new Point(
                random.Next(0, xmax),
                random.Next(0, ymax)
                );
        }
    }
}
