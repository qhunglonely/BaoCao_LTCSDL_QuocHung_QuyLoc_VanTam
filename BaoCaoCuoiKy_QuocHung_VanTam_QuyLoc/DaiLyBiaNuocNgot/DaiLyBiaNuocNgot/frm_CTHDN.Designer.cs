namespace DaiLyBiaNuocNgot
{
    partial class frm_CTHDN
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
            this.msds = new System.Windows.Forms.DataGridView();
            this.btsua = new System.Windows.Forms.Button();
            this.btluu = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbhd = new System.Windows.Forms.ComboBox();
            this.cbhang = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lbhang = new System.Windows.Forms.Label();
            this.txttt = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtdg = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btquaylai = new System.Windows.Forms.Button();
            this.btxoa = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btmoi = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtgg = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtsl = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.msds)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // msds
            // 
            this.msds.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(226)))), ((int)(((byte)(238)))));
            this.msds.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.msds.Dock = System.Windows.Forms.DockStyle.Fill;
            this.msds.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(226)))), ((int)(((byte)(238)))));
            this.msds.Location = new System.Drawing.Point(0, 315);
            this.msds.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.msds.Name = "msds";
            this.msds.Size = new System.Drawing.Size(1646, 244);
            this.msds.TabIndex = 24;
            this.msds.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.msds_CellClick);
            // 
            // btsua
            // 
            this.btsua.Dock = System.Windows.Forms.DockStyle.Left;
            this.btsua.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btsua.Image = global::DaiLyBiaNuocNgot.Properties.Resources.BTsua;
            this.btsua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btsua.Location = new System.Drawing.Point(440, 0);
            this.btsua.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btsua.Name = "btsua";
            this.btsua.Size = new System.Drawing.Size(174, 106);
            this.btsua.TabIndex = 2;
            this.btsua.Text = "Sửa";
            this.btsua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btsua.UseVisualStyleBackColor = true;
            this.btsua.Click += new System.EventHandler(this.btsua_Click_1);
            // 
            // btluu
            // 
            this.btluu.Dock = System.Windows.Forms.DockStyle.Left;
            this.btluu.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btluu.Image = global::DaiLyBiaNuocNgot.Properties.Resources.BTluu;
            this.btluu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btluu.Location = new System.Drawing.Point(258, 0);
            this.btluu.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btluu.Name = "btluu";
            this.btluu.Size = new System.Drawing.Size(182, 106);
            this.btluu.TabIndex = 1;
            this.btluu.Text = "Lưu";
            this.btluu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btluu.UseVisualStyleBackColor = true;
            this.btluu.Click += new System.EventHandler(this.btluu_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 23);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 39);
            this.label2.TabIndex = 11;
            this.label2.Text = "Số Hóa Đơn";
            // 
            // cbhd
            // 
            this.cbhd.Enabled = false;
            this.cbhd.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbhd.FormattingEnabled = true;
            this.cbhd.Location = new System.Drawing.Point(220, 17);
            this.cbhd.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cbhd.Name = "cbhd";
            this.cbhd.Size = new System.Drawing.Size(342, 47);
            this.cbhd.TabIndex = 14;
            // 
            // cbhang
            // 
            this.cbhang.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbhang.FormattingEnabled = true;
            this.cbhang.Location = new System.Drawing.Point(812, 12);
            this.cbhang.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cbhang.Name = "cbhang";
            this.cbhang.Size = new System.Drawing.Size(212, 47);
            this.cbhang.TabIndex = 14;
            this.cbhang.SelectedIndexChanged += new System.EventHandler(this.cbhang_SelectedIndexChanged_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(642, 17);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 39);
            this.label6.TabIndex = 11;
            this.label6.Text = "Mã SP";
            // 
            // lbhang
            // 
            this.lbhang.AutoSize = true;
            this.lbhang.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbhang.Location = new System.Drawing.Point(1040, 17);
            this.lbhang.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbhang.Name = "lbhang";
            this.lbhang.Size = new System.Drawing.Size(50, 39);
            this.lbhang.TabIndex = 10;
            this.lbhang.Text = "---";
            // 
            // txttt
            // 
            this.txttt.Enabled = false;
            this.txttt.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttt.Location = new System.Drawing.Point(812, 138);
            this.txttt.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txttt.Name = "txttt";
            this.txttt.Size = new System.Drawing.Size(480, 47);
            this.txttt.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(634, 144);
            this.label10.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(169, 39);
            this.label10.TabIndex = 4;
            this.label10.Text = "Thành Tiền";
            // 
            // txtdg
            // 
            this.txtdg.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdg.Location = new System.Drawing.Point(812, 75);
            this.txtdg.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtdg.Name = "txtdg";
            this.txtdg.Size = new System.Drawing.Size(480, 47);
            this.txtdg.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Left;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(1344, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(294, 106);
            this.button1.TabIndex = 6;
            this.button1.Text = "Xuất Hóa Đơn";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btquaylai
            // 
            this.btquaylai.Dock = System.Windows.Forms.DockStyle.Left;
            this.btquaylai.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btquaylai.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btquaylai.Location = new System.Drawing.Point(794, 0);
            this.btquaylai.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btquaylai.Name = "btquaylai";
            this.btquaylai.Size = new System.Drawing.Size(550, 106);
            this.btquaylai.TabIndex = 4;
            this.btquaylai.Text = "Quay Lại Giao Diện Hóa Đơn";
            this.btquaylai.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btquaylai.UseVisualStyleBackColor = true;
            // 
            // btxoa
            // 
            this.btxoa.Dock = System.Windows.Forms.DockStyle.Left;
            this.btxoa.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btxoa.Image = global::DaiLyBiaNuocNgot.Properties.Resources.XOa_n;
            this.btxoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btxoa.Location = new System.Drawing.Point(614, 0);
            this.btxoa.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btxoa.Name = "btxoa";
            this.btxoa.Size = new System.Drawing.Size(180, 106);
            this.btxoa.TabIndex = 3;
            this.btxoa.Text = "Xóa";
            this.btxoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btxoa.UseVisualStyleBackColor = true;
            this.btxoa.Click += new System.EventHandler(this.btxoa_Click_1);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(226)))), ((int)(((byte)(238)))));
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.btquaylai);
            this.panel2.Controls.Add(this.btxoa);
            this.panel2.Controls.Add(this.btsua);
            this.panel2.Controls.Add(this.btluu);
            this.panel2.Controls.Add(this.btmoi);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 559);
            this.panel2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1646, 106);
            this.panel2.TabIndex = 23;
            // 
            // btmoi
            // 
            this.btmoi.Dock = System.Windows.Forms.DockStyle.Left;
            this.btmoi.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmoi.Image = global::DaiLyBiaNuocNgot.Properties.Resources.BTmoi;
            this.btmoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btmoi.Location = new System.Drawing.Point(0, 0);
            this.btmoi.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btmoi.Name = "btmoi";
            this.btmoi.Size = new System.Drawing.Size(258, 106);
            this.btmoi.TabIndex = 0;
            this.btmoi.Text = "Thêm Mới";
            this.btmoi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btmoi.UseVisualStyleBackColor = true;
            this.btmoi.Click += new System.EventHandler(this.btmoi_Click_1);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(642, 81);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(133, 39);
            this.label8.TabIndex = 4;
            this.label8.Text = "Đơn Giá";
            // 
            // txtgg
            // 
            this.txtgg.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtgg.Location = new System.Drawing.Point(200, 148);
            this.txtgg.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtgg.Name = "txtgg";
            this.txtgg.Size = new System.Drawing.Size(362, 47);
            this.txtgg.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(24, 154);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(148, 39);
            this.label9.TabIndex = 4;
            this.label9.Text = "Giảm Giá";
            // 
            // txtsl
            // 
            this.txtsl.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsl.Location = new System.Drawing.Point(200, 81);
            this.txtsl.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtsl.Name = "txtsl";
            this.txtsl.Size = new System.Drawing.Size(362, 47);
            this.txtsl.TabIndex = 5;
            this.txtsl.TextChanged += new System.EventHandler(this.txtsl_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(380, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(877, 62);
            this.label1.TabIndex = 0;
            this.label1.Text = "CHI TIẾT HÓA ĐƠN NHẬP HÀNG";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(226)))), ((int)(((byte)(238)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 219);
            this.panel1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1646, 96);
            this.panel1.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(24, 87);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(152, 39);
            this.label7.TabIndex = 4;
            this.label7.Text = "Số Lượng";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(226)))), ((int)(((byte)(238)))));
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.cbhd);
            this.panel4.Controls.Add(this.cbhang);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.lbhang);
            this.panel4.Controls.Add(this.txttt);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.txtdg);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.txtgg);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.txtsl);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1646, 219);
            this.panel4.TabIndex = 22;
            // 
            // frm_CTHDN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1646, 665);
            this.Controls.Add(this.msds);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "frm_CTHDN";
            this.Text = "frm_CTHDN";
            this.Load += new System.EventHandler(this.frm_CTHDN_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.msds)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView msds;
        private System.Windows.Forms.Button btsua;
        private System.Windows.Forms.Button btluu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbhd;
        private System.Windows.Forms.ComboBox cbhang;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbhang;
        private System.Windows.Forms.TextBox txttt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtdg;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btquaylai;
        private System.Windows.Forms.Button btxoa;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btmoi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtgg;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtsl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel4;
    }
}