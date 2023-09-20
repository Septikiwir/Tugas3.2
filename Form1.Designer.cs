namespace AplikasiLatihanTugas
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Name = new System.Windows.Forms.TextBox();
            this.Pendidikan = new System.Windows.Forms.ComboBox();
            this.ListPekerja = new System.Windows.Forms.ListBox();
            this.pesan1 = new System.Windows.Forms.TextBox();
            this.pesan2 = new System.Windows.Forms.TextBox();
            this.pesan3 = new System.Windows.Forms.TextBox();
            this.Tampilkan = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label2.Location = new System.Drawing.Point(3, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "pekerjaan";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label3.Location = new System.Drawing.Point(3, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "pendidikan";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Name
            // 
            this.Name.Location = new System.Drawing.Point(156, 3);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(138, 20);
            this.Name.TabIndex = 3;
            // 
            // Pendidikan
            // 
            this.Pendidikan.FormattingEnabled = true;
            this.Pendidikan.Items.AddRange(new object[] {
            "SD",
            "SMP",
            "SMA",
            "Diploma",
            "Sarjana",
            "Pascasarjana"});
            this.Pendidikan.Location = new System.Drawing.Point(156, 51);
            this.Pendidikan.Name = "Pendidikan";
            this.Pendidikan.Size = new System.Drawing.Size(138, 21);
            this.Pendidikan.TabIndex = 4;
            this.Pendidikan.Text = "select";
            // 
            // ListPekerja
            // 
            this.ListPekerja.FormattingEnabled = true;
            this.ListPekerja.Items.AddRange(new object[] {
            "Pedagang",
            "PNS",
            "Dosen",
            "Swasta",
            "ABRI"});
            this.ListPekerja.Location = new System.Drawing.Point(156, 99);
            this.ListPekerja.Name = "ListPekerja";
            this.ListPekerja.Size = new System.Drawing.Size(138, 95);
            this.ListPekerja.TabIndex = 5;
            this.ListPekerja.SelectedIndexChanged += new System.EventHandler(this.ListPekerja_SelectedIndexChanged);
            // 
            // pesan1
            // 
            this.pesan1.Enabled = false;
            this.pesan1.Location = new System.Drawing.Point(3, 3);
            this.pesan1.Name = "pesan1";
            this.pesan1.Size = new System.Drawing.Size(220, 20);
            this.pesan1.TabIndex = 6;
            // 
            // pesan2
            // 
            this.pesan2.Enabled = false;
            this.pesan2.Location = new System.Drawing.Point(3, 29);
            this.pesan2.Name = "pesan2";
            this.pesan2.Size = new System.Drawing.Size(220, 20);
            this.pesan2.TabIndex = 7;
            // 
            // pesan3
            // 
            this.pesan3.Enabled = false;
            this.pesan3.Location = new System.Drawing.Point(3, 55);
            this.pesan3.Name = "pesan3";
            this.pesan3.Size = new System.Drawing.Size(220, 20);
            this.pesan3.TabIndex = 8;
            // 
            // Tampilkan
            // 
            this.Tampilkan.Location = new System.Drawing.Point(3, 81);
            this.Tampilkan.Name = "Tampilkan";
            this.Tampilkan.Size = new System.Drawing.Size(220, 23);
            this.Tampilkan.TabIndex = 9;
            this.Tampilkan.Text = "tampilkan";
            this.Tampilkan.UseVisualStyleBackColor = true;
            this.Tampilkan.Click += new System.EventHandler(this.Tampilkan_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.Pendidikan, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.ListPekerja, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.Name, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(-5, 1);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 104F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(306, 221);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.pesan1);
            this.flowLayoutPanel1.Controls.Add(this.pesan2);
            this.flowLayoutPanel1.Controls.Add(this.pesan3);
            this.flowLayoutPanel1.Controls.Add(this.Tampilkan);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(36, 228);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(228, 181);
            this.flowLayoutPanel1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 421);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.flowLayoutPanel1);
           // this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Name;
        private System.Windows.Forms.ComboBox Pendidikan;
        private System.Windows.Forms.ListBox ListPekerja;
        private System.Windows.Forms.TextBox pesan1;
        private System.Windows.Forms.TextBox pesan2;
        private System.Windows.Forms.TextBox pesan3;
        private System.Windows.Forms.Button Tampilkan;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}

