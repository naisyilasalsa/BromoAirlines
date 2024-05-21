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
    public partial class MasterBandara : Form
    {
        public MasterBandara()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void MasterBandara_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add("Abdul Rakhman", "MLG", "Malang", "Indonesia", "2", "Malang");
            dataGridView1.Rows.Add("Abresso", "RSK", "Manokwari", "Indonesia", "2", "Manokwari");
            dataGridView1.Rows.Add("Achmad Yani", "SRG", "Semarang", "Indonesia", "2", "Semarang");
            dataGridView1.Rows.Add("Adi Sucipto", "JOG", "Yogyakarta", "Indonesia", "2", "Yogyakarta");
            dataGridView1.Rows.Add("Adisumarmo", "SOC", "Solo", "Indonesia", "2", "Solo");
        }

        private void masterBandaraToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.ShowDialog();
        }

        private void masterJadwalPenerbanganToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            MasterJadwalPenerbangan form = new MasterJadwalPenerbangan();
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
    }
}
