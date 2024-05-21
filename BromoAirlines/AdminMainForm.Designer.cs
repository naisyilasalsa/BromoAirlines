namespace BromoAirlines
{
    partial class AdminMainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminMainForm));
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printPreviewDialog2 = new System.Windows.Forms.PrintPreviewDialog();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tghToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.masterrToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.masterKodePromoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ubahStatusPenerbanganToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printPreviewDialog2
            // 
            this.printPreviewDialog2.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog2.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog2.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog2.Enabled = true;
            this.printPreviewDialog2.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog2.Icon")));
            this.printPreviewDialog2.Name = "printPreviewDialog2";
            this.printPreviewDialog2.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(30, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(817, 42);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Dashboard";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.menuStrip1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(30, 42);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(194, 506);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Firebrick;
            this.label1.Location = new System.Drawing.Point(47, 472);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 14);
            this.label1.TabIndex = 2;
            this.label1.Text = "Logout";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tghToolStripMenuItem,
            this.hhToolStripMenuItem,
            this.masterrToolStripMenuItem,
            this.masterKodePromoToolStripMenuItem,
            this.ubahStatusPenerbanganToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(185, 504);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BromoAirlines.Properties.Resources.WhatsApp_Image_2024_01_31_at_13_20_48;
            this.pictureBox1.Location = new System.Drawing.Point(15, 466);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(26, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // tghToolStripMenuItem
            // 
            this.tghToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tghToolStripMenuItem.Image = global::BromoAirlines.Properties.Resources.map_unselected_72__1_;
            this.tghToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tghToolStripMenuItem.Name = "tghToolStripMenuItem";
            this.tghToolStripMenuItem.Size = new System.Drawing.Size(178, 20);
            this.tghToolStripMenuItem.Text = "Master Bandara";
            this.tghToolStripMenuItem.Click += new System.EventHandler(this.tghToolStripMenuItem_Click);
            // 
            // hhToolStripMenuItem
            // 
            this.hhToolStripMenuItem.Image = global::BromoAirlines.Properties.Resources.plane_take_off_unselected_72__1_1;
            this.hhToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.hhToolStripMenuItem.Name = "hhToolStripMenuItem";
            this.hhToolStripMenuItem.Size = new System.Drawing.Size(178, 20);
            this.hhToolStripMenuItem.Text = "Master Maskapai";
            this.hhToolStripMenuItem.Click += new System.EventHandler(this.hhToolStripMenuItem_Click);
            // 
            // masterrToolStripMenuItem
            // 
            this.masterrToolStripMenuItem.Image = global::BromoAirlines.Properties.Resources.calendar_unselected_72__1_;
            this.masterrToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.masterrToolStripMenuItem.Name = "masterrToolStripMenuItem";
            this.masterrToolStripMenuItem.Size = new System.Drawing.Size(178, 20);
            this.masterrToolStripMenuItem.Text = "Master Jadwal Penerbangan";
            this.masterrToolStripMenuItem.Click += new System.EventHandler(this.masterrToolStripMenuItem_Click);
            // 
            // masterKodePromoToolStripMenuItem
            // 
            this.masterKodePromoToolStripMenuItem.Image = global::BromoAirlines.Properties.Resources.purchase_tag_alt_unselected_72__1_;
            this.masterKodePromoToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.masterKodePromoToolStripMenuItem.Name = "masterKodePromoToolStripMenuItem";
            this.masterKodePromoToolStripMenuItem.Size = new System.Drawing.Size(178, 20);
            this.masterKodePromoToolStripMenuItem.Text = "Master Kode Promo";
            this.masterKodePromoToolStripMenuItem.Click += new System.EventHandler(this.masterKodePromoToolStripMenuItem_Click);
            // 
            // ubahStatusPenerbanganToolStripMenuItem
            // 
            this.ubahStatusPenerbanganToolStripMenuItem.Image = global::BromoAirlines.Properties.Resources.notepad_unselected_72;
            this.ubahStatusPenerbanganToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ubahStatusPenerbanganToolStripMenuItem.Name = "ubahStatusPenerbanganToolStripMenuItem";
            this.ubahStatusPenerbanganToolStripMenuItem.Size = new System.Drawing.Size(178, 20);
            this.ubahStatusPenerbanganToolStripMenuItem.Text = "Ubah Status Penerbangan";
            this.ubahStatusPenerbanganToolStripMenuItem.Click += new System.EventHandler(this.ubahStatusPenerbanganToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Highlight;
            this.button1.BackgroundImage = global::BromoAirlines.Properties.Resources.menu_alt_72;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button1.Location = new System.Drawing.Point(5, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(36, 37);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AdminMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 548);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "AdminMainForm";
            this.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.Text = "Master Maskapai";
            this.Load += new System.EventHandler(this.AdminMainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tghToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hhToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem masterrToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem masterKodePromoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ubahStatusPenerbanganToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}