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
    public partial class MasterMaskapai : Form
    {
        public MasterMaskapai()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void MasterMaskapai_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add("Adam Air", "PT Adam Air", "16", "Adam Air adalah");
            dataGridView1.Rows.Add("Aviastar", "PT Aviastar", "12", "Aviastar adalah");
            dataGridView1.Rows.Add("Batavia Air", "PT Batavia Air", "6", "Batavia Air adalah");
            dataGridView1.Rows.Add("Batik Air", "PT Batik Air", "17", "Batik Air adalah");
            dataGridView1.Rows.Add("Bouraq Indonesia", "PT Bouraq Indonesia", "19", "Bouraq Indonesia adalah");
        }

        private void masterBandaraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            MasterMaskapai form = new MasterMaskapai();
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.ShowDialog();
        }
    }
}
