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
    public partial class Form3 : Form
    {
        public delegate void DelegatePaveNumeric(string touche);
        public event DelegatePaveNumeric paveNumeric;

        
        public Form3()
        {
            InitializeComponent();
            paveNumeric1.clickBtn += PaveNumeric1_clickBtn;
        }

        private void PaveNumeric1_clickBtn(string touche)
        {
            if (paveNumeric != null)
            {
                paveNumeric(touche);
            }

            textBox3.Text += touche;
        }

        private void paveNumeric1_Load(object sender, EventArgs e)
        {
           
        }
    }
}
