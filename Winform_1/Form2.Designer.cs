namespace Winform_1
{
    partial class Form2
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.queInp = new System.Windows.Forms.TextBox();
            this.lopInp = new System.Windows.Forms.TextBox();
            this.hotenInp = new System.Windows.Forms.TextBox();
            this.msvInp = new System.Windows.Forms.TextBox();
            this.khoaInp = new System.Windows.Forms.TextBox();
            this.ngaysinhDatePick = new System.Windows.Forms.DateTimePicker();
            this.diemComboBox = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.msvDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hotenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaysinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioitinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.queDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lopDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.khoaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hocphiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sVBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qlsvDataSet = new Winform_1.qlsvDataSet();
            this.gtNamRadBtn = new System.Windows.Forms.RadioButton();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.msvLabel = new System.Windows.Forms.Label();
            this.hotenLabel = new System.Windows.Forms.Label();
            this.queLabel = new System.Windows.Forms.Label();
            this.lopLabel = new System.Windows.Forms.Label();
            this.hocphiLabel = new System.Windows.Forms.Label();
            this.khoaLabel = new System.Windows.Forms.Label();
            this.ngaysinhLabel = new System.Windows.Forms.Label();
            this.diemLabel = new System.Windows.Forms.Label();
            this.btnGiam = new System.Windows.Forms.Button();
            this.tbnTang = new System.Windows.Forms.Button();
            this.gtGroupBox = new System.Windows.Forms.GroupBox();
            this.gtNuRadBtn = new System.Windows.Forms.RadioButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.addUpdateTabPage = new System.Windows.Forms.TabPage();
            this.hocphiInp = new System.Windows.Forms.NumericUpDown();
            this.deleteTabPage = new System.Windows.Forms.TabPage();
            this.msvlabelDelete = new System.Windows.Forms.Label();
            this.msvInpDelete = new System.Windows.Forms.TextBox();
            this.sVTableAdapter = new Winform_1.qlsvDataSetTableAdapters.SVTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sVBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qlsvDataSet)).BeginInit();
            this.gtGroupBox.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.addUpdateTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hocphiInp)).BeginInit();
            this.deleteTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1133, 386);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 58);
            this.button1.TabIndex = 0;
            this.button1.Text = "openConnect";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1140, 486);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(154, 58);
            this.button2.TabIndex = 1;
            this.button2.Text = "closeConnect";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // queInp
            // 
            this.queInp.Location = new System.Drawing.Point(274, 69);
            this.queInp.Name = "queInp";
            this.queInp.Size = new System.Drawing.Size(100, 26);
            this.queInp.TabIndex = 2;
            this.queInp.TextChanged += new System.EventHandler(this.queInp_TextChanged);
            // 
            // lopInp
            // 
            this.lopInp.Location = new System.Drawing.Point(397, 69);
            this.lopInp.Name = "lopInp";
            this.lopInp.Size = new System.Drawing.Size(100, 26);
            this.lopInp.TabIndex = 3;
            this.lopInp.TextChanged += new System.EventHandler(this.lopInp_TextChanged);
            // 
            // hotenInp
            // 
            this.hotenInp.Location = new System.Drawing.Point(152, 69);
            this.hotenInp.Name = "hotenInp";
            this.hotenInp.Size = new System.Drawing.Size(100, 26);
            this.hotenInp.TabIndex = 4;
            this.hotenInp.TextChanged += new System.EventHandler(this.hotenInp_TextChanged);
            // 
            // msvInp
            // 
            this.msvInp.Location = new System.Drawing.Point(20, 69);
            this.msvInp.Name = "msvInp";
            this.msvInp.Size = new System.Drawing.Size(100, 26);
            this.msvInp.TabIndex = 5;
            this.msvInp.TextChanged += new System.EventHandler(this.msvInp_TextChanged);
            // 
            // khoaInp
            // 
            this.khoaInp.Location = new System.Drawing.Point(20, 169);
            this.khoaInp.Name = "khoaInp";
            this.khoaInp.Size = new System.Drawing.Size(100, 26);
            this.khoaInp.TabIndex = 6;
            this.khoaInp.TextChanged += new System.EventHandler(this.khoaInp_TextChanged);
            // 
            // ngaysinhDatePick
            // 
            this.ngaysinhDatePick.Location = new System.Drawing.Point(152, 169);
            this.ngaysinhDatePick.Name = "ngaysinhDatePick";
            this.ngaysinhDatePick.Size = new System.Drawing.Size(200, 26);
            this.ngaysinhDatePick.TabIndex = 8;
            this.ngaysinhDatePick.ValueChanged += new System.EventHandler(this.ngaysinhDatePick_ValueChanged);
            // 
            // diemComboBox
            // 
            this.diemComboBox.DisplayMember = "1";
            this.diemComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.diemComboBox.FormattingEnabled = true;
            this.diemComboBox.Items.AddRange(new object[] {
            "10",
            "9",
            "8",
            "7",
            "6",
            "5",
            "4",
            "3",
            "2",
            "1",
            "0"});
            this.diemComboBox.Location = new System.Drawing.Point(376, 169);
            this.diemComboBox.Name = "diemComboBox";
            this.diemComboBox.Size = new System.Drawing.Size(121, 28);
            this.diemComboBox.TabIndex = 9;
            this.diemComboBox.SelectedIndexChanged += new System.EventHandler(this.diemComboBox_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.msvDataGridViewTextBoxColumn,
            this.hotenDataGridViewTextBoxColumn,
            this.ngaysinhDataGridViewTextBoxColumn,
            this.gioitinhDataGridViewTextBoxColumn,
            this.queDataGridViewTextBoxColumn,
            this.lopDataGridViewTextBoxColumn,
            this.khoaDataGridViewTextBoxColumn,
            this.diemDataGridViewTextBoxColumn,
            this.hocphiDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.sVBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1409, 287);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.DataSourceChanged += new System.EventHandler(this.dataGridView1_DataSourceChanged);
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // msvDataGridViewTextBoxColumn
            // 
            this.msvDataGridViewTextBoxColumn.DataPropertyName = "msv";
            this.msvDataGridViewTextBoxColumn.HeaderText = "msv";
            this.msvDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.msvDataGridViewTextBoxColumn.Name = "msvDataGridViewTextBoxColumn";
            this.msvDataGridViewTextBoxColumn.Width = 150;
            // 
            // hotenDataGridViewTextBoxColumn
            // 
            this.hotenDataGridViewTextBoxColumn.DataPropertyName = "hoten";
            this.hotenDataGridViewTextBoxColumn.HeaderText = "hoten";
            this.hotenDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.hotenDataGridViewTextBoxColumn.Name = "hotenDataGridViewTextBoxColumn";
            this.hotenDataGridViewTextBoxColumn.Width = 150;
            // 
            // ngaysinhDataGridViewTextBoxColumn
            // 
            this.ngaysinhDataGridViewTextBoxColumn.DataPropertyName = "ngaysinh";
            this.ngaysinhDataGridViewTextBoxColumn.HeaderText = "ngaysinh";
            this.ngaysinhDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.ngaysinhDataGridViewTextBoxColumn.Name = "ngaysinhDataGridViewTextBoxColumn";
            this.ngaysinhDataGridViewTextBoxColumn.Width = 150;
            // 
            // gioitinhDataGridViewTextBoxColumn
            // 
            this.gioitinhDataGridViewTextBoxColumn.DataPropertyName = "gioitinh";
            this.gioitinhDataGridViewTextBoxColumn.HeaderText = "gioitinh";
            this.gioitinhDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.gioitinhDataGridViewTextBoxColumn.Name = "gioitinhDataGridViewTextBoxColumn";
            this.gioitinhDataGridViewTextBoxColumn.Width = 150;
            // 
            // queDataGridViewTextBoxColumn
            // 
            this.queDataGridViewTextBoxColumn.DataPropertyName = "que";
            this.queDataGridViewTextBoxColumn.HeaderText = "que";
            this.queDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.queDataGridViewTextBoxColumn.Name = "queDataGridViewTextBoxColumn";
            this.queDataGridViewTextBoxColumn.Width = 150;
            // 
            // lopDataGridViewTextBoxColumn
            // 
            this.lopDataGridViewTextBoxColumn.DataPropertyName = "lop";
            this.lopDataGridViewTextBoxColumn.HeaderText = "lop";
            this.lopDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.lopDataGridViewTextBoxColumn.Name = "lopDataGridViewTextBoxColumn";
            this.lopDataGridViewTextBoxColumn.Width = 150;
            // 
            // khoaDataGridViewTextBoxColumn
            // 
            this.khoaDataGridViewTextBoxColumn.DataPropertyName = "khoa";
            this.khoaDataGridViewTextBoxColumn.HeaderText = "khoa";
            this.khoaDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.khoaDataGridViewTextBoxColumn.Name = "khoaDataGridViewTextBoxColumn";
            this.khoaDataGridViewTextBoxColumn.Width = 150;
            // 
            // diemDataGridViewTextBoxColumn
            // 
            this.diemDataGridViewTextBoxColumn.DataPropertyName = "diem";
            this.diemDataGridViewTextBoxColumn.HeaderText = "diem";
            this.diemDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.diemDataGridViewTextBoxColumn.Name = "diemDataGridViewTextBoxColumn";
            this.diemDataGridViewTextBoxColumn.Width = 150;
            // 
            // hocphiDataGridViewTextBoxColumn
            // 
            this.hocphiDataGridViewTextBoxColumn.DataPropertyName = "hocphi";
            this.hocphiDataGridViewTextBoxColumn.HeaderText = "hocphi";
            this.hocphiDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.hocphiDataGridViewTextBoxColumn.Name = "hocphiDataGridViewTextBoxColumn";
            this.hocphiDataGridViewTextBoxColumn.Width = 150;
            // 
            // sVBindingSource
            // 
            this.sVBindingSource.DataMember = "SV";
            this.sVBindingSource.DataSource = this.qlsvDataSet;
            // 
            // qlsvDataSet
            // 
            this.qlsvDataSet.DataSetName = "qlsvDataSet";
            this.qlsvDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gtNamRadBtn
            // 
            this.gtNamRadBtn.AutoSize = true;
            this.gtNamRadBtn.Location = new System.Drawing.Point(20, 23);
            this.gtNamRadBtn.Name = "gtNamRadBtn";
            this.gtNamRadBtn.Size = new System.Drawing.Size(67, 24);
            this.gtNamRadBtn.TabIndex = 13;
            this.gtNamRadBtn.Text = "Nam";
            this.gtNamRadBtn.UseVisualStyleBackColor = true;
            this.gtNamRadBtn.CheckedChanged += new System.EventHandler(this.gtNamRadBtn_CheckedChanged);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(747, 37);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 47);
            this.btnThem.TabIndex = 14;
            this.btnThem.Text = "them";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(747, 142);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 48);
            this.btnSua.TabIndex = 15;
            this.btnSua.Text = "sua";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(428, 74);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 47);
            this.btnXoa.TabIndex = 16;
            this.btnXoa.Text = "xoa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // msvLabel
            // 
            this.msvLabel.AutoSize = true;
            this.msvLabel.Location = new System.Drawing.Point(23, 36);
            this.msvLabel.Name = "msvLabel";
            this.msvLabel.Size = new System.Drawing.Size(37, 20);
            this.msvLabel.TabIndex = 18;
            this.msvLabel.Text = "msv";
            // 
            // hotenLabel
            // 
            this.hotenLabel.AutoSize = true;
            this.hotenLabel.Location = new System.Drawing.Point(148, 36);
            this.hotenLabel.Name = "hotenLabel";
            this.hotenLabel.Size = new System.Drawing.Size(50, 20);
            this.hotenLabel.TabIndex = 19;
            this.hotenLabel.Text = "hoten";
            this.hotenLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // queLabel
            // 
            this.queLabel.AutoSize = true;
            this.queLabel.Location = new System.Drawing.Point(270, 36);
            this.queLabel.Name = "queLabel";
            this.queLabel.Size = new System.Drawing.Size(36, 20);
            this.queLabel.TabIndex = 20;
            this.queLabel.Text = "que";
            // 
            // lopLabel
            // 
            this.lopLabel.AutoSize = true;
            this.lopLabel.Location = new System.Drawing.Point(395, 36);
            this.lopLabel.Name = "lopLabel";
            this.lopLabel.Size = new System.Drawing.Size(30, 20);
            this.lopLabel.TabIndex = 21;
            this.lopLabel.Text = "lop";
            // 
            // hocphiLabel
            // 
            this.hocphiLabel.AutoSize = true;
            this.hocphiLabel.Location = new System.Drawing.Point(519, 36);
            this.hocphiLabel.Name = "hocphiLabel";
            this.hocphiLabel.Size = new System.Drawing.Size(56, 20);
            this.hocphiLabel.TabIndex = 22;
            this.hocphiLabel.Text = "hocphi";
            // 
            // khoaLabel
            // 
            this.khoaLabel.AutoSize = true;
            this.khoaLabel.Location = new System.Drawing.Point(23, 124);
            this.khoaLabel.Name = "khoaLabel";
            this.khoaLabel.Size = new System.Drawing.Size(44, 20);
            this.khoaLabel.TabIndex = 23;
            this.khoaLabel.Text = "khoa";
            // 
            // ngaysinhLabel
            // 
            this.ngaysinhLabel.AutoSize = true;
            this.ngaysinhLabel.Location = new System.Drawing.Point(148, 137);
            this.ngaysinhLabel.Name = "ngaysinhLabel";
            this.ngaysinhLabel.Size = new System.Drawing.Size(72, 20);
            this.ngaysinhLabel.TabIndex = 24;
            this.ngaysinhLabel.Text = "ngaysinh";
            // 
            // diemLabel
            // 
            this.diemLabel.AutoSize = true;
            this.diemLabel.Location = new System.Drawing.Point(382, 137);
            this.diemLabel.Name = "diemLabel";
            this.diemLabel.Size = new System.Drawing.Size(43, 20);
            this.diemLabel.TabIndex = 25;
            this.diemLabel.Text = "diem";
            // 
            // btnGiam
            // 
            this.btnGiam.Location = new System.Drawing.Point(927, 486);
            this.btnGiam.Name = "btnGiam";
            this.btnGiam.Size = new System.Drawing.Size(161, 58);
            this.btnGiam.TabIndex = 26;
            this.btnGiam.Text = "sx giam theo diem";
            this.btnGiam.UseVisualStyleBackColor = true;
            // 
            // tbnTang
            // 
            this.tbnTang.Location = new System.Drawing.Point(927, 386);
            this.tbnTang.Name = "tbnTang";
            this.tbnTang.Size = new System.Drawing.Size(161, 58);
            this.tbnTang.TabIndex = 27;
            this.tbnTang.Text = "sx tang theo diem";
            this.tbnTang.UseVisualStyleBackColor = true;
            // 
            // gtGroupBox
            // 
            this.gtGroupBox.Controls.Add(this.gtNuRadBtn);
            this.gtGroupBox.Controls.Add(this.gtNamRadBtn);
            this.gtGroupBox.Location = new System.Drawing.Point(523, 139);
            this.gtGroupBox.Name = "gtGroupBox";
            this.gtGroupBox.Size = new System.Drawing.Size(200, 58);
            this.gtGroupBox.TabIndex = 28;
            this.gtGroupBox.TabStop = false;
            this.gtGroupBox.Text = "gioiTinh";
            // 
            // gtNuRadBtn
            // 
            this.gtNuRadBtn.AutoSize = true;
            this.gtNuRadBtn.Checked = true;
            this.gtNuRadBtn.Location = new System.Drawing.Point(93, 25);
            this.gtNuRadBtn.Name = "gtNuRadBtn";
            this.gtNuRadBtn.Size = new System.Drawing.Size(54, 24);
            this.gtNuRadBtn.TabIndex = 14;
            this.gtNuRadBtn.TabStop = true;
            this.gtNuRadBtn.Text = "Nu";
            this.gtNuRadBtn.UseVisualStyleBackColor = true;
            this.gtNuRadBtn.CheckedChanged += new System.EventHandler(this.gtNuRadBtn_CheckedChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.addUpdateTabPage);
            this.tabControl1.Controls.Add(this.deleteTabPage);
            this.tabControl1.ItemSize = new System.Drawing.Size(87, 30);
            this.tabControl1.Location = new System.Drawing.Point(43, 305);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(857, 301);
            this.tabControl1.TabIndex = 29;
            // 
            // addUpdateTabPage
            // 
            this.addUpdateTabPage.Controls.Add(this.hocphiInp);
            this.addUpdateTabPage.Controls.Add(this.hotenInp);
            this.addUpdateTabPage.Controls.Add(this.khoaInp);
            this.addUpdateTabPage.Controls.Add(this.msvInp);
            this.addUpdateTabPage.Controls.Add(this.btnThem);
            this.addUpdateTabPage.Controls.Add(this.btnSua);
            this.addUpdateTabPage.Controls.Add(this.hocphiLabel);
            this.addUpdateTabPage.Controls.Add(this.ngaysinhDatePick);
            this.addUpdateTabPage.Controls.Add(this.lopLabel);
            this.addUpdateTabPage.Controls.Add(this.diemComboBox);
            this.addUpdateTabPage.Controls.Add(this.queLabel);
            this.addUpdateTabPage.Controls.Add(this.gtGroupBox);
            this.addUpdateTabPage.Controls.Add(this.hotenLabel);
            this.addUpdateTabPage.Controls.Add(this.diemLabel);
            this.addUpdateTabPage.Controls.Add(this.msvLabel);
            this.addUpdateTabPage.Controls.Add(this.khoaLabel);
            this.addUpdateTabPage.Controls.Add(this.ngaysinhLabel);
            this.addUpdateTabPage.Controls.Add(this.queInp);
            this.addUpdateTabPage.Controls.Add(this.lopInp);
            this.addUpdateTabPage.Location = new System.Drawing.Point(4, 34);
            this.addUpdateTabPage.Name = "addUpdateTabPage";
            this.addUpdateTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.addUpdateTabPage.Size = new System.Drawing.Size(849, 263);
            this.addUpdateTabPage.TabIndex = 0;
            this.addUpdateTabPage.Text = "Them/Sua";
            this.addUpdateTabPage.UseVisualStyleBackColor = true;
            // 
            // hocphiInp
            // 
            this.hocphiInp.Increment = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.hocphiInp.Location = new System.Drawing.Point(523, 69);
            this.hocphiInp.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.hocphiInp.Name = "hocphiInp";
            this.hocphiInp.Size = new System.Drawing.Size(120, 26);
            this.hocphiInp.TabIndex = 30;
            this.hocphiInp.ValueChanged += new System.EventHandler(this.hocphiInp_ValueChanged);
            // 
            // deleteTabPage
            // 
            this.deleteTabPage.Controls.Add(this.msvlabelDelete);
            this.deleteTabPage.Controls.Add(this.msvInpDelete);
            this.deleteTabPage.Controls.Add(this.btnXoa);
            this.deleteTabPage.Location = new System.Drawing.Point(4, 34);
            this.deleteTabPage.Name = "deleteTabPage";
            this.deleteTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.deleteTabPage.Size = new System.Drawing.Size(849, 263);
            this.deleteTabPage.TabIndex = 1;
            this.deleteTabPage.Text = "Xoa";
            this.deleteTabPage.UseVisualStyleBackColor = true;
            // 
            // msvlabelDelete
            // 
            this.msvlabelDelete.AutoSize = true;
            this.msvlabelDelete.Location = new System.Drawing.Point(206, 46);
            this.msvlabelDelete.Name = "msvlabelDelete";
            this.msvlabelDelete.Size = new System.Drawing.Size(136, 20);
            this.msvlabelDelete.TabIndex = 18;
            this.msvlabelDelete.Text = "nhap msv can xoa";
            // 
            // msvInpDelete
            // 
            this.msvInpDelete.Location = new System.Drawing.Point(210, 84);
            this.msvInpDelete.Name = "msvInpDelete";
            this.msvInpDelete.Size = new System.Drawing.Size(116, 26);
            this.msvInpDelete.TabIndex = 17;
            this.msvInpDelete.TextChanged += new System.EventHandler(this.msvInpDelete_TextChanged);
            // 
            // sVTableAdapter
            // 
            this.sVTableAdapter.ClearBeforeFill = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1466, 628);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.tbnTang);
            this.Controls.Add(this.btnGiam);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bai Tap LTW";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sVBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qlsvDataSet)).EndInit();
            this.gtGroupBox.ResumeLayout(false);
            this.gtGroupBox.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.addUpdateTabPage.ResumeLayout(false);
            this.addUpdateTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hocphiInp)).EndInit();
            this.deleteTabPage.ResumeLayout(false);
            this.deleteTabPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox queInp;
        private System.Windows.Forms.TextBox lopInp;
        private System.Windows.Forms.TextBox hotenInp;
        private System.Windows.Forms.TextBox msvInp;
        private System.Windows.Forms.TextBox khoaInp;
        private System.Windows.Forms.DateTimePicker ngaysinhDatePick;
        private System.Windows.Forms.ComboBox diemComboBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RadioButton gtNamRadBtn;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Label msvLabel;
        private System.Windows.Forms.Label hotenLabel;
        private System.Windows.Forms.Label queLabel;
        private System.Windows.Forms.Label lopLabel;
        private System.Windows.Forms.Label hocphiLabel;
        private System.Windows.Forms.Label khoaLabel;
        private System.Windows.Forms.Label ngaysinhLabel;
        private System.Windows.Forms.Label diemLabel;
        private System.Windows.Forms.Button btnGiam;
        private System.Windows.Forms.Button tbnTang;
        private System.Windows.Forms.GroupBox gtGroupBox;
        private System.Windows.Forms.RadioButton gtNuRadBtn;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage addUpdateTabPage;
        private System.Windows.Forms.TabPage deleteTabPage;
        private System.Windows.Forms.Label msvlabelDelete;
        private System.Windows.Forms.TextBox msvInpDelete;
        private qlsvDataSet qlsvDataSet;
        private System.Windows.Forms.BindingSource sVBindingSource;
        private qlsvDataSetTableAdapters.SVTableAdapter sVTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn msvDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hotenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaysinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioitinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn queDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lopDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn khoaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hocphiDataGridViewTextBoxColumn;
        private System.Windows.Forms.NumericUpDown hocphiInp;
    }
}