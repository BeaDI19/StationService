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
    public partial class Form2 : Form
    {
        public delegate void DelegateChoixCarbu(string touche);
        public event DelegateChoixCarbu choixCarbu;

    
        public Form2()
        {
            InitializeComponent();
            carburants1.clickBtn += Carburants1_clickBtn;
        }

        private void Carburants1_clickBtn(string touche)
        {
            if (choixCarbu != null)
            {
                choixCarbu(touche);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
