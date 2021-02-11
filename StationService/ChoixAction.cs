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
    public partial class ChoixAction : UserControl
    {
        public delegate void DelegateClickBtn(string touche);
        public event DelegateClickBtn clickBtn;

        public EventHandler onClickBtn;
        public ChoixAction()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine(button1.Name);
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

        private void button4_Click(object sender, EventArgs e)
        {
            if (clickBtn != null)
            {
                clickBtn(((Button)sender).Text);
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            if (clickBtn != null)
            {
                clickBtn(((Button)sender).Text);
            }
        }

        private void ChoixAction_Load(object sender, EventArgs e)
        {

        }

       

        
    }
}
