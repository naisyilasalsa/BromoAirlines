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
    public partial class MasterKodePromo : Form
    {
        public MasterKodePromo()
        {
            InitializeComponent();
        }

        private void MasterKodePromo_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add("BROMOAJAYUK", "15", "100000", "09-09-2023", "Yuk pakai diskon");
            dataGridView1.Rows.Add("NAIBROMOAIRLANES", "10", "150000", "09-09-2023", "Bromo airlanes");
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MasterBandara form = new MasterBandara();
            form.ShowDialog();
        }

        private void masterMaskapaiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            MasterMaskapai form = new MasterMaskapai();
            form.ShowDialog();
        }

        private void masterJadwalPenerbanganToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this .Hide();
            MasterJadwalPenerbangan form = new MasterJadwalPenerbangan();
            form.ShowDialog();
        }

        private void ubahStatusPenerbanganToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide ();
            UbahStatusPenerbangan form = new UbahStatusPenerbangan();
            form.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.ShowDialog();
        }
    }
}
