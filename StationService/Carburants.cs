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
    public partial class Carburants : UserControl
    {
        public delegate void DelegateClickBtn(string touche);
        public event DelegateClickBtn clickBtn;

        public EventHandler onClickBtn;
        public Carburants()
        {
            InitializeComponent();
        }

        private void buttonSP98_Click(object sender, EventArgs e)
        {
            if (clickBtn != null)
            {
                clickBtn(((Button)sender).Text);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (clickBtn != null)
            {
                clickBtn(((Button)sender).Text);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (clickBtn != null)
            {
                clickBtn(((Button)sender).Text);
            }

        }
    }
}
