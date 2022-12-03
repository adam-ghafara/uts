
namespace Peminjaman_Buku
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.epAttention = new System.Windows.Forms.ErrorProvider(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbID = new System.Windows.Forms.TextBox();
            this.tbNama = new System.Windows.Forms.TextBox();
            this.rtbAlamat = new System.Windows.Forms.TextBox();
            this.tbBookName = new System.Windows.Forms.TextBox();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.rbFem = new System.Windows.Forms.RadioButton();
            this.dtPinjam = new System.Windows.Forms.DateTimePicker();
            this.dtKembali = new System.Windows.Forms.DateTimePicker();
            this.btSimpan = new System.Windows.Forms.Button();
            this.cobBuku = new System.Windows.Forms.ComboBox();
            this.btcek = new System.Windows.Forms.Button();
            this.epWarning = new System.Windows.Forms.ErrorProvider(this.components);
            this.epCorrect = new System.Windows.Forms.ErrorProvider(this.components);
            this.label10 = new System.Windows.Forms.Label();
            this.tbNoHP = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cb16plus = new System.Windows.Forms.CheckBox();
            this.cb12plus = new System.Windows.Forms.CheckBox();
            this.cb7plus = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.epAttention)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epWarning)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCorrect)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // epAttention
            // 
            this.epAttention.ContainerControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Anggota";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nama";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Jenis Kelamin";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Alamat";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(67, 347);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Jenis Buku";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(67, 374);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Judul Buku";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(11, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(393, 28);
            this.label7.TabIndex = 6;
            this.label7.Text = "DATA ANGGOTA PEMINJAMAN BUKU";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(67, 406);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Tanggal Pinjam";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(67, 438);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Tanggal Kembali";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(153, 67);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(142, 20);
            this.tbID.TabIndex = 0;
            this.tbID.TextChanged += new System.EventHandler(this.tbID_TextChanged);
            // 
            // tbNama
            // 
            this.tbNama.Location = new System.Drawing.Point(153, 93);
            this.tbNama.Name = "tbNama";
            this.tbNama.Size = new System.Drawing.Size(142, 20);
            this.tbNama.TabIndex = 1;
            this.tbNama.TextChanged += new System.EventHandler(this.tbNama_TextChanged);
            // 
            // rtbAlamat
            // 
            this.rtbAlamat.Location = new System.Drawing.Point(153, 232);
            this.rtbAlamat.Multiline = true;
            this.rtbAlamat.Name = "rtbAlamat";
            this.rtbAlamat.Size = new System.Drawing.Size(142, 54);
            this.rtbAlamat.TabIndex = 12;
            this.rtbAlamat.TextChanged += new System.EventHandler(this.rtbAlamat_TextChanged);
            // 
            // tbBookName
            // 
            this.tbBookName.Location = new System.Drawing.Point(153, 371);
            this.tbBookName.Name = "tbBookName";
            this.tbBookName.Size = new System.Drawing.Size(145, 20);
            this.tbBookName.TabIndex = 15;
            this.tbBookName.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Location = new System.Drawing.Point(155, 148);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(70, 17);
            this.rbMale.TabIndex = 5;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Laki - laki";
            this.rbMale.UseVisualStyleBackColor = true;
            this.rbMale.CheckedChanged += new System.EventHandler(this.rbMale_CheckedChanged);
            // 
            // rbFem
            // 
            this.rbFem.AutoSize = true;
            this.rbFem.Location = new System.Drawing.Point(231, 148);
            this.rbFem.Name = "rbFem";
            this.rbFem.Size = new System.Drawing.Size(79, 17);
            this.rbFem.TabIndex = 6;
            this.rbFem.TabStop = true;
            this.rbFem.Text = "Perempuan";
            this.rbFem.UseVisualStyleBackColor = true;
            this.rbFem.CheckedChanged += new System.EventHandler(this.rbFem_CheckedChanged);
            // 
            // dtPinjam
            // 
            this.dtPinjam.Location = new System.Drawing.Point(153, 406);
            this.dtPinjam.Name = "dtPinjam";
            this.dtPinjam.Size = new System.Drawing.Size(200, 20);
            this.dtPinjam.TabIndex = 16;
            // 
            // dtKembali
            // 
            this.dtKembali.Location = new System.Drawing.Point(153, 438);
            this.dtKembali.Name = "dtKembali";
            this.dtKembali.Size = new System.Drawing.Size(200, 20);
            this.dtKembali.TabIndex = 17;
            // 
            // btSimpan
            // 
            this.btSimpan.Location = new System.Drawing.Point(179, 464);
            this.btSimpan.Name = "btSimpan";
            this.btSimpan.Size = new System.Drawing.Size(75, 23);
            this.btSimpan.TabIndex = 18;
            this.btSimpan.Text = "Simpan";
            this.btSimpan.UseVisualStyleBackColor = true;
            this.btSimpan.Click += new System.EventHandler(this.btSimpan_Click);
            // 
            // cobBuku
            // 
            this.cobBuku.FormattingEnabled = true;
            this.cobBuku.Items.AddRange(new object[] {
            "Novel",
            "Komik",
            "Buku Ilmiah",
            "Cerita Anak",
            "Majalah",
            "Lainnya"});
            this.cobBuku.Location = new System.Drawing.Point(153, 344);
            this.cobBuku.Name = "cobBuku";
            this.cobBuku.Size = new System.Drawing.Size(145, 21);
            this.cobBuku.TabIndex = 14;
            // 
            // btcek
            // 
            this.btcek.Location = new System.Drawing.Point(179, 292);
            this.btcek.Name = "btcek";
            this.btcek.Size = new System.Drawing.Size(75, 23);
            this.btcek.TabIndex = 13;
            this.btcek.Text = "Check";
            this.btcek.UseVisualStyleBackColor = true;
            this.btcek.Click += new System.EventHandler(this.btcek_Click);
            // 
            // epWarning
            // 
            this.epWarning.ContainerControl = this;
            this.epWarning.Icon = ((System.Drawing.Icon)(resources.GetObject("epWarning.Icon")));
            // 
            // epCorrect
            // 
            this.epCorrect.ContainerControl = this;
            this.epCorrect.Icon = ((System.Drawing.Icon)(resources.GetObject("epCorrect.Icon")));
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(69, 201);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "Umur";
            // 
            // tbNoHP
            // 
            this.tbNoHP.Location = new System.Drawing.Point(152, 119);
            this.tbNoHP.Name = "tbNoHP";
            this.tbNoHP.Size = new System.Drawing.Size(142, 20);
            this.tbNoHP.TabIndex = 2;
            this.tbNoHP.TextChanged += new System.EventHandler(this.tbNoHP_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(66, 121);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(39, 13);
            this.label11.TabIndex = 26;
            this.label11.Text = "No HP";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(56, 137);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(267, 44);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cb16plus);
            this.groupBox2.Controls.Add(this.cb12plus);
            this.groupBox2.Controls.Add(this.cb7plus);
            this.groupBox2.Location = new System.Drawing.Point(56, 178);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(267, 48);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            // 
            // cb16plus
            // 
            this.cb16plus.AutoSize = true;
            this.cb16plus.Location = new System.Drawing.Point(184, 19);
            this.cb16plus.Name = "cb16plus";
            this.cb16plus.Size = new System.Drawing.Size(44, 17);
            this.cb16plus.TabIndex = 2;
            this.cb16plus.Text = "16+";
            this.cb16plus.UseVisualStyleBackColor = true;
            this.cb16plus.CheckedChanged += new System.EventHandler(this.cb16plus_CheckedChanged);
            // 
            // cb12plus
            // 
            this.cb12plus.AutoSize = true;
            this.cb12plus.Location = new System.Drawing.Point(134, 19);
            this.cb12plus.Name = "cb12plus";
            this.cb12plus.Size = new System.Drawing.Size(44, 17);
            this.cb12plus.TabIndex = 1;
            this.cb12plus.Text = "12+";
            this.cb12plus.UseVisualStyleBackColor = true;
            this.cb12plus.CheckedChanged += new System.EventHandler(this.cb12plus_CheckedChanged);
            // 
            // cb7plus
            // 
            this.cb7plus.AutoSize = true;
            this.cb7plus.Location = new System.Drawing.Point(89, 19);
            this.cb7plus.Name = "cb7plus";
            this.cb7plus.Size = new System.Drawing.Size(38, 17);
            this.cb7plus.TabIndex = 0;
            this.cb7plus.Text = "7+";
            this.cb7plus.UseVisualStyleBackColor = true;
            this.cb7plus.CheckedChanged += new System.EventHandler(this.cb7plus_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(425, 521);
            this.Controls.Add(this.tbNoHP);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btcek);
            this.Controls.Add(this.cobBuku);
            this.Controls.Add(this.btSimpan);
            this.Controls.Add(this.dtKembali);
            this.Controls.Add(this.dtPinjam);
            this.Controls.Add(this.rbFem);
            this.Controls.Add(this.rbMale);
            this.Controls.Add(this.tbBookName);
            this.Controls.Add(this.rtbAlamat);
            this.Controls.Add(this.tbNama);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Anggota Peminjaman Buku";
            ((System.ComponentModel.ISupportInitialize)(this.epAttention)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epWarning)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCorrect)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.TextBox tbNama;
        private System.Windows.Forms.TextBox rtbAlamat;
        private System.Windows.Forms.TextBox tbBookName;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.RadioButton rbFem;
        private System.Windows.Forms.DateTimePicker dtPinjam;
        private System.Windows.Forms.DateTimePicker dtKembali;
        private System.Windows.Forms.Button btSimpan;
        private System.Windows.Forms.ComboBox cobBuku;
        private System.Windows.Forms.Button btcek;
        private System.Windows.Forms.ErrorProvider epWarning;
        private System.Windows.Forms.ErrorProvider epCorrect;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ErrorProvider epAttention;
        private System.Windows.Forms.TextBox tbNoHP;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox cb12plus;
        private System.Windows.Forms.CheckBox cb7plus;
        private System.Windows.Forms.CheckBox cb16plus;
    }
}

