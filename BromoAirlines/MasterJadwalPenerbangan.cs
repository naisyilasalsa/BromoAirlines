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
    public partial class MasterJadwalPenerbangan : Form
    {
        public MasterJadwalPenerbangan()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void MasterJadwalPenerbangan_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add("ID-7518", "Juanda", "Halim Perdana", "Batik Air", "30-05-", "19:55", "01 jam 10 menit", "829891");
            dataGridView1.Rows.Add("IP-0203", "Juanda", "Soekarno-Hatta", "Pelita Air", "30-05-", "19:50", "01 jam 20 menit", "684000");
            dataGridView1.Rows.Add("QG-0719", "Juanda", "Soekarno-Hatta", "Citilink", "30-05-", "19:30", "01 jam 30 menit", "1317538");
            dataGridView1.Rows.Add("QG-0173", "Juanda", "Halim Perdana", "Citilink", "30-05-", "19:00", "01 jam 40 menit", "772601");
            dataGridView1.Rows.Add("GA-0325", "Juanda", "Soekarno-Hatta", "Garuda", "30-05-", "18:40", "01 jam 50 menit", "1536880");
        }

        private void masterBandaraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            MasterBandara form = new MasterBandara();  
            form.ShowDialog();
        }

        private void jSIJHSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            MasterMaskapai form = new MasterMaskapai();
            form.ShowDialog();
        }

        private void masterKodePromoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            MasterKodePromo form = new MasterKodePromo();
            form.ShowDialog();
        }

        private void ubahStatusPenerbanganToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            UbahStatusPenerbangan form = new UbahStatusPenerbangan();
            form.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.ShowDialog();
        }

        private void masterJadwalPenerbanganToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
