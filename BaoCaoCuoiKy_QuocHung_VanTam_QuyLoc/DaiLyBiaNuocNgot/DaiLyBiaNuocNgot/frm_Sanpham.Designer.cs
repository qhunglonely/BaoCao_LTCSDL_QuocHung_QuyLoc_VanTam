namespace DaiLyBiaNuocNgot
{
    partial class frm_Sanpham
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
            this.components = new System.ComponentModel.Container();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btxoa = new System.Windows.Forms.Button();
            this.btsua = new System.Windows.Forms.Button();
            this.btluu = new System.Windows.Forms.Button();
            this.btmoi = new System.Windows.Forms.Button();
            this.txtngay = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.cbnoisx = new System.Windows.Forms.ComboBox();
            this.cbmahang = new System.Windows.Forms.ComboBox();
            this.txtgc = new System.Windows.Forms.TextBox();
            this.txtsl = new System.Windows.Forms.TextBox();
            this.txtdgb = new System.Windows.Forms.TextBox();
            this.txtdgn = new System.Windows.Forms.TextBox();
            this.txtten = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.msds = new System.Windows.Forms.DataGridView();
            this.tbSanphamBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qL_DaiLyBiaNuocNgotDataSet = new DaiLyBiaNuocNgot.QL_DaiLyBiaNuocNgotDataSet();
            this.label17 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lbnoisx = new System.Windows.Forms.Label();
            this.txtma = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lbhang = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_SanphamTableAdapter = new DaiLyBiaNuocNgot.QL_DaiLyBiaNuocNgotDataSetTableAdapters.tb_SanphamTableAdapter();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.msds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSanphamBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_DaiLyBiaNuocNgotDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(226)))), ((int)(((byte)(238)))));
            this.panel3.Controls.Add(this.btxoa);
            this.panel3.Controls.Add(this.btsua);
            this.panel3.Controls.Add(this.btluu);
            this.panel3.Controls.Add(this.btmoi);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(756, 96);
            this.panel3.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1142, 83);
            this.panel3.TabIndex = 18;
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
            this.btxoa.Size = new System.Drawing.Size(180, 83);
            this.btxoa.TabIndex = 3;
            this.btxoa.Text = "Xóa";
            this.btxoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btxoa.UseVisualStyleBackColor = true;
            this.btxoa.Click += new System.EventHandler(this.btxoa_Click);
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
            this.btsua.Size = new System.Drawing.Size(174, 83);
            this.btsua.TabIndex = 2;
            this.btsua.Text = "Sửa";
            this.btsua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btsua.UseVisualStyleBackColor = true;
            this.btsua.Click += new System.EventHandler(this.btsua_Click);
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
            this.btluu.Size = new System.Drawing.Size(182, 83);
            this.btluu.TabIndex = 1;
            this.btluu.Text = "Lưu";
            this.btluu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btluu.UseVisualStyleBackColor = true;
            this.btluu.Click += new System.EventHandler(this.btluu_Click_1);
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
            this.btmoi.Size = new System.Drawing.Size(258, 83);
            this.btmoi.TabIndex = 0;
            this.btmoi.Text = "Thêm Mới";
            this.btmoi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btmoi.UseVisualStyleBackColor = true;
            this.btmoi.Click += new System.EventHandler(this.btmoi_Click_1);
            // 
            // txtngay
            // 
            this.txtngay.CustomFormat = "MM/dd/yyyy";
            this.txtngay.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtngay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtngay.Location = new System.Drawing.Point(238, 490);
            this.txtngay.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtngay.Name = "txtngay";
            this.txtngay.Size = new System.Drawing.Size(468, 47);
            this.txtngay.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 502);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(189, 39);
            this.label4.TabIndex = 8;
            this.label4.Text = "Hạn sử dụng";
            // 
            // cbnoisx
            // 
            this.cbnoisx.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbnoisx.FormattingEnabled = true;
            this.cbnoisx.Location = new System.Drawing.Point(234, 237);
            this.cbnoisx.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cbnoisx.Name = "cbnoisx";
            this.cbnoisx.Size = new System.Drawing.Size(212, 47);
            this.cbnoisx.TabIndex = 5;
            this.cbnoisx.SelectedIndexChanged += new System.EventHandler(this.cbnoisx_SelectedIndexChanged_1);
            // 
            // cbmahang
            // 
            this.cbmahang.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbmahang.FormattingEnabled = true;
            this.cbmahang.Location = new System.Drawing.Point(234, 163);
            this.cbmahang.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cbmahang.Name = "cbmahang";
            this.cbmahang.Size = new System.Drawing.Size(212, 47);
            this.cbmahang.TabIndex = 5;
            this.cbmahang.SelectedIndexChanged += new System.EventHandler(this.cbmahang_SelectedIndexChanged_1);
            // 
            // txtgc
            // 
            this.txtgc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtgc.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtgc.Location = new System.Drawing.Point(234, 554);
            this.txtgc.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtgc.Multiline = true;
            this.txtgc.Name = "txtgc";
            this.txtgc.Size = new System.Drawing.Size(472, 210);
            this.txtgc.TabIndex = 4;
            // 
            // txtsl
            // 
            this.txtsl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtsl.Enabled = false;
            this.txtsl.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsl.Location = new System.Drawing.Point(332, 427);
            this.txtsl.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtsl.Name = "txtsl";
            this.txtsl.Size = new System.Drawing.Size(374, 47);
            this.txtsl.TabIndex = 4;
            // 
            // txtdgb
            // 
            this.txtdgb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtdgb.Enabled = false;
            this.txtdgb.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdgb.Location = new System.Drawing.Point(234, 363);
            this.txtdgb.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtdgb.Name = "txtdgb";
            this.txtdgb.Size = new System.Drawing.Size(472, 47);
            this.txtdgb.TabIndex = 4;
            // 
            // txtdgn
            // 
            this.txtdgn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtdgn.Enabled = false;
            this.txtdgn.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdgn.Location = new System.Drawing.Point(234, 300);
            this.txtdgn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtdgn.Name = "txtdgn";
            this.txtdgn.Size = new System.Drawing.Size(472, 47);
            this.txtdgn.TabIndex = 4;
            // 
            // txtten
            // 
            this.txtten.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtten.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtten.Location = new System.Drawing.Point(234, 100);
            this.txtten.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtten.Name = "txtten";
            this.txtten.Size = new System.Drawing.Size(472, 47);
            this.txtten.TabIndex = 4;
            this.txtten.TextChanged += new System.EventHandler(this.txtten_TextChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(12, 440);
            this.label15.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(275, 39);
            this.label15.TabIndex = 2;
            this.label15.Text = "Số Lượng Hiện Có";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(12, 554);
            this.label13.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(131, 39);
            this.label13.TabIndex = 2;
            this.label13.Text = "Ghi Chú";
            // 
            // msds
            // 
            this.msds.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(226)))), ((int)(((byte)(238)))));
            this.msds.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.msds.Dock = System.Windows.Forms.DockStyle.Fill;
            this.msds.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(226)))), ((int)(((byte)(238)))));
            this.msds.Location = new System.Drawing.Point(756, 179);
            this.msds.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.msds.Name = "msds";
            this.msds.Size = new System.Drawing.Size(1142, 654);
            this.msds.TabIndex = 19;
            this.msds.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.msds_CellClick);
            // 
            // tbSanphamBindingSource
            // 
            this.tbSanphamBindingSource.DataMember = "tb_Sanpham";
            this.tbSanphamBindingSource.DataSource = this.qL_DaiLyBiaNuocNgotDataSet;
            // 
            // qL_DaiLyBiaNuocNgotDataSet
            // 
            this.qL_DaiLyBiaNuocNgotDataSet.DataSetName = "QL_DaiLyBiaNuocNgotDataSet";
            this.qL_DaiLyBiaNuocNgotDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(12, 242);
            this.label17.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(121, 39);
            this.label17.TabIndex = 2;
            this.label17.Text = "Nơi SX";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(226)))), ((int)(((byte)(238)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(756, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1142, 96);
            this.panel1.TabIndex = 16;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(340, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(630, 62);
            this.label1.TabIndex = 0;
            this.label1.Text = "DANH MỤC SẢN PHẨM";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(226)))), ((int)(((byte)(238)))));
            this.panel2.Controls.Add(this.txtngay);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.cbnoisx);
            this.panel2.Controls.Add(this.cbmahang);
            this.panel2.Controls.Add(this.txtgc);
            this.panel2.Controls.Add(this.txtsl);
            this.panel2.Controls.Add(this.txtdgb);
            this.panel2.Controls.Add(this.txtdgn);
            this.panel2.Controls.Add(this.txtten);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label17);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.lbnoisx);
            this.panel2.Controls.Add(this.txtma);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.lbhang);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(756, 833);
            this.panel2.TabIndex = 17;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(12, 377);
            this.label12.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(195, 39);
            this.label12.TabIndex = 2;
            this.label12.Text = "Đơn Giá Bán";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(12, 306);
            this.label11.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(215, 39);
            this.label11.TabIndex = 2;
            this.label11.Text = "Đơn Giá Nhập";
            // 
            // lbnoisx
            // 
            this.lbnoisx.AutoSize = true;
            this.lbnoisx.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnoisx.Location = new System.Drawing.Point(462, 242);
            this.lbnoisx.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbnoisx.Name = "lbnoisx";
            this.lbnoisx.Size = new System.Drawing.Size(50, 39);
            this.lbnoisx.TabIndex = 2;
            this.lbnoisx.Text = "---";
            // 
            // txtma
            // 
            this.txtma.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtma.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtma.Location = new System.Drawing.Point(234, 31);
            this.txtma.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtma.Name = "txtma";
            this.txtma.Size = new System.Drawing.Size(472, 47);
            this.txtma.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 175);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 39);
            this.label5.TabIndex = 2;
            this.label5.Text = "Mã Hãng";
            // 
            // lbhang
            // 
            this.lbhang.AutoSize = true;
            this.lbhang.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbhang.Location = new System.Drawing.Point(462, 169);
            this.lbhang.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbhang.Name = "lbhang";
            this.lbhang.Size = new System.Drawing.Size(50, 39);
            this.lbhang.TabIndex = 2;
            this.lbhang.Text = "---";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 106);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(213, 39);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên Sản Phẩm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 42);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(206, 39);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã Sản Phẩm";
            // 
            // tb_SanphamTableAdapter
            // 
            this.tb_SanphamTableAdapter.ClearBeforeFill = true;
            // 
            // frm_Sanpham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1898, 833);
            this.Controls.Add(this.msds);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "frm_Sanpham";
            this.Text = "frm_Sanpham";
            this.Load += new System.EventHandler(this.frm_Sanpham_Load);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.msds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSanphamBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_DaiLyBiaNuocNgotDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btxoa;
        private System.Windows.Forms.Button btsua;
        private System.Windows.Forms.Button btluu;
        private System.Windows.Forms.Button btmoi;
        private System.Windows.Forms.DateTimePicker txtngay;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbnoisx;
        private System.Windows.Forms.ComboBox cbmahang;
        private System.Windows.Forms.TextBox txtgc;
        private System.Windows.Forms.TextBox txtsl;
        private System.Windows.Forms.TextBox txtdgb;
        private System.Windows.Forms.TextBox txtdgn;
        private System.Windows.Forms.TextBox txtten;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView msds;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lbnoisx;
        private System.Windows.Forms.TextBox txtma;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbhang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private QL_DaiLyBiaNuocNgotDataSet qL_DaiLyBiaNuocNgotDataSet;
        private System.Windows.Forms.BindingSource tbSanphamBindingSource;
        private QL_DaiLyBiaNuocNgotDataSetTableAdapters.tb_SanphamTableAdapter tb_SanphamTableAdapter;
    }
}