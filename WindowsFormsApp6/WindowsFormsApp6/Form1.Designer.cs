
namespace WindowsFormsApp6
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btrandevu = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbsaatler = new System.Windows.Forms.ListBox();
            this.dtTarih = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.randevunoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hastaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tcDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doktornoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tarihDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saatnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.randevular1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hastanerandevuDataSet = new WindowsFormsApp6.hastanerandevuDataSet();
            this.lbdoktor = new System.Windows.Forms.ListBox();
            this.lbpol = new System.Windows.Forms.ListBox();
            this.randevular1TableAdapter = new WindowsFormsApp6.hastanerandevuDataSetTableAdapters.randevular1TableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.randevular1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastanerandevuDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.btrandevu);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lbsaatler);
            this.panel1.Controls.Add(this.dtTarih);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.lbdoktor);
            this.panel1.Controls.Add(this.lbpol);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(816, 425);
            this.panel1.TabIndex = 0;
            // 
            // btrandevu
            // 
            this.btrandevu.Location = new System.Drawing.Point(365, 112);
            this.btrandevu.Name = "btrandevu";
            this.btrandevu.Size = new System.Drawing.Size(75, 32);
            this.btrandevu.TabIndex = 13;
            this.btrandevu.Text = "Randevu Al";
            this.btrandevu.UseVisualStyleBackColor = true;
            this.btrandevu.Click += new System.EventHandler(this.btrandevu_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(484, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "SAAT";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(265, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "HASTA TC";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(265, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "HASTA AD-SOYAD";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(365, 75);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 9;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(365, 49);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(139, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "DOKTORLAR";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "POLİKİNLİK";
            // 
            // lbsaatler
            // 
            this.lbsaatler.DisplayMember = "saatler";
            this.lbsaatler.FormattingEnabled = true;
            this.lbsaatler.Location = new System.Drawing.Point(487, 20);
            this.lbsaatler.Name = "lbsaatler";
            this.lbsaatler.Size = new System.Drawing.Size(120, 147);
            this.lbsaatler.TabIndex = 5;
            this.lbsaatler.ValueMember = "saatno";
            // 
            // dtTarih
            // 
            this.dtTarih.Location = new System.Drawing.Point(265, 20);
            this.dtTarih.Name = "dtTarih";
            this.dtTarih.Size = new System.Drawing.Size(200, 20);
            this.dtTarih.TabIndex = 4;
            this.dtTarih.ValueChanged += new System.EventHandler(this.dtTarih_ValueChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.randevunoDataGridViewTextBoxColumn,
            this.hastaDataGridViewTextBoxColumn,
            this.tcDataGridViewTextBoxColumn,
            this.doktornoDataGridViewTextBoxColumn,
            this.tarihDataGridViewTextBoxColumn,
            this.saatnoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.randevular1BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(18, 191);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(618, 231);
            this.dataGridView1.TabIndex = 3;
            // 
            // randevunoDataGridViewTextBoxColumn
            // 
            this.randevunoDataGridViewTextBoxColumn.DataPropertyName = "randevuno";
            this.randevunoDataGridViewTextBoxColumn.HeaderText = "randevuno";
            this.randevunoDataGridViewTextBoxColumn.Name = "randevunoDataGridViewTextBoxColumn";
            // 
            // hastaDataGridViewTextBoxColumn
            // 
            this.hastaDataGridViewTextBoxColumn.DataPropertyName = "hasta";
            this.hastaDataGridViewTextBoxColumn.HeaderText = "hasta";
            this.hastaDataGridViewTextBoxColumn.Name = "hastaDataGridViewTextBoxColumn";
            // 
            // tcDataGridViewTextBoxColumn
            // 
            this.tcDataGridViewTextBoxColumn.DataPropertyName = "tc";
            this.tcDataGridViewTextBoxColumn.HeaderText = "tc";
            this.tcDataGridViewTextBoxColumn.Name = "tcDataGridViewTextBoxColumn";
            // 
            // doktornoDataGridViewTextBoxColumn
            // 
            this.doktornoDataGridViewTextBoxColumn.DataPropertyName = "doktorno";
            this.doktornoDataGridViewTextBoxColumn.HeaderText = "doktorno";
            this.doktornoDataGridViewTextBoxColumn.Name = "doktornoDataGridViewTextBoxColumn";
            // 
            // tarihDataGridViewTextBoxColumn
            // 
            this.tarihDataGridViewTextBoxColumn.DataPropertyName = "tarih";
            this.tarihDataGridViewTextBoxColumn.HeaderText = "tarih";
            this.tarihDataGridViewTextBoxColumn.Name = "tarihDataGridViewTextBoxColumn";
            // 
            // saatnoDataGridViewTextBoxColumn
            // 
            this.saatnoDataGridViewTextBoxColumn.DataPropertyName = "saatno";
            this.saatnoDataGridViewTextBoxColumn.HeaderText = "saatno";
            this.saatnoDataGridViewTextBoxColumn.Name = "saatnoDataGridViewTextBoxColumn";
            // 
            // randevular1BindingSource
            // 
            this.randevular1BindingSource.DataMember = "randevular1";
            this.randevular1BindingSource.DataSource = this.hastanerandevuDataSet;
            // 
            // hastanerandevuDataSet
            // 
            this.hastanerandevuDataSet.DataSetName = "hastanerandevuDataSet";
            this.hastanerandevuDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lbdoktor
            // 
            this.lbdoktor.DisplayMember = "doktor";
            this.lbdoktor.FormattingEnabled = true;
            this.lbdoktor.Location = new System.Drawing.Point(139, 20);
            this.lbdoktor.Name = "lbdoktor";
            this.lbdoktor.Size = new System.Drawing.Size(120, 147);
            this.lbdoktor.TabIndex = 1;
            this.lbdoktor.ValueMember = "doktorno";
            // 
            // lbpol
            // 
            this.lbpol.DisplayMember = "pol";
            this.lbpol.FormattingEnabled = true;
            this.lbpol.Location = new System.Drawing.Point(21, 20);
            this.lbpol.Name = "lbpol";
            this.lbpol.Size = new System.Drawing.Size(112, 147);
            this.lbpol.TabIndex = 0;
            this.lbpol.ValueMember = "polno";
            this.lbpol.SelectedIndexChanged += new System.EventHandler(this.lbpol_SelectedIndexChanged);
            // 
            // randevular1TableAdapter
            // 
            this.randevular1TableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(17, 58);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Sil";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(633, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(150, 111);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sil";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Silinecek Randevu no ";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(17, 32);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 16;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(650, 165);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 16;
            this.button2.Text = "Çıkış";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.randevular1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastanerandevuDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ListBox lbdoktor;
        private System.Windows.Forms.ListBox lbpol;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbsaatler;
        private System.Windows.Forms.DateTimePicker dtTarih;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btrandevu;
        private hastanerandevuDataSet hastanerandevuDataSet;
        private System.Windows.Forms.BindingSource randevular1BindingSource;
        private hastanerandevuDataSetTableAdapters.randevular1TableAdapter randevular1TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn randevunoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hastaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tcDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doktornoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarihDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn saatnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

