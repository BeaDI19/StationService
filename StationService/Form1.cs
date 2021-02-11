using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StationService
{
    public partial class Form1 : Form
    {
        Form2 f2 = new Form2();
        Form3 f3 = new Form3();

        public Form1()
        {
            InitializeComponent();
            choixAction1.clickBtn += ChoixAction1_clickBtn;

            f2.choixCarbu += F2_choixCarbu;
            f3.paveNumeric += F3_paveNumeric;

        }

        private void F3_paveNumeric(string touche)
        {
            textBox1.Text = touche;
        }

        private void F2_choixCarbu(string touche)
        {
            textBox1.Text = touche;
            f3.Show();
        }


        private void ChoixAction1_clickBtn(string touche)
        {            
            f2.Show();
        }
    }
}
