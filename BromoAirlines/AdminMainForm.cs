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
    public partial class AdminMainForm : Form
    {
        public AdminMainForm()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void masterBandaraToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void hhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            MasterMaskapai form = new MasterMaskapai();
            form.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (menuStrip1.Visible == false)
            {
                menuStrip1.Visible = true;
            }
            else
            {
                menuStrip1.Visible = false;
            }
        }

        private void AdminMainForm_Load(object sender, EventArgs e)
        {

        }

        private void tghToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            MasterBandara form = new MasterBandara();
            form.ShowDialog();
        }

        private void masterrToolStripMenuItem_Click(object sender, EventArgs e)
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
