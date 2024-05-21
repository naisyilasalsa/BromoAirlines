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
    public partial class LIstPenerbangan : Form
    {
        public LIstPenerbangan()
        {
            InitializeComponent();
        }

        private void LIstPenerbangan_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add("IP-0209", "Pelita Air", "Juanda", "Soekarno-Hatta", "634000", "24-05-2023", "15:10 - 16:45", "Beli Tiket");
            dataGridView1.Rows.Add("IP-0203", "Pelita Air", "Juanda", "Soekarno-Hatta", "684000", "24-05-2023", "19:50 - 21:25", "Beli Tiket");
            dataGridView1.Rows.Add("IU-0333", "Super Air Jet", "Juanda", "Soekarno-Hatta", "725966", "24-05-2023", "06:00 - 07:25", "Beli Tiket");
            dataGridView1.Rows.Add("IU-0331", "Super Air Jet", "Juanda", "Soekarno-Hatta", "725966", "24-05-2023", "08:00 - 09:25", "Beli Tiket");
            dataGridView1.Rows.Add("IU-0341", "Super Air Jet", "Juanda", "Soekarno-Hatta", "725966",  "24-05-2023", "17:00 - 18:30", "Beli Tiket");
            dataGridView1.Rows.Add("JT-0591", "Lion Air", "Juanda", "Soekarno-Hatta", "726331", "24-05-2023", "06:15 - 07:40", "Beli Tiket");
            dataGridView1.Rows.Add("JT-0573", "Lion Air", "Juandaa", "Soekarno-Hatta", "726331", "24-05-2023", "07:40 - 09:05", "Beli Tiket");
            dataGridView1.Rows.Add("JT-0693", "Lion Air", "Juanda", "Soekarno-Hatta", "726331", "24-05-2023", "07:55 - 09:20", "Beli Tiket");
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomerMain form = new CustomerMain();
            form.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            BeliTiket form = new BeliTiket();
            form.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CustomerMain form = new CustomerMain();
            form.ShowDialog();
        }
    }
}
