using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BromoAirlines
{
    public partial class BeliTiket : Form
    {
        public BeliTiket()
        {
            InitializeComponent();
        }

        private void splitter1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            TiketSaya form = new TiketSaya();
            form.ShowDialog();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            CustomerMain form = new CustomerMain();
            form.ShowDialog();
        }
    }
}
