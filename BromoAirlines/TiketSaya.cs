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
    public partial class TiketSaya : Form
    {
        public TiketSaya()
        {
            InitializeComponent();
        }

        private void TiketSaya_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add("IP-0203", "Pelita Air Service", "Juanda", "Soekarno-Hatta", "24-05-2023", "19:50 - 21:25", "Delay (selama 2 jam 30 menit)");
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomerMain form = new CustomerMain();
            form.ShowDialog();
        }
    }
}
