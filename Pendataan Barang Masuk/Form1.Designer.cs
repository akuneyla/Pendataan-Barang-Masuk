namespace Pendataan_Barang_Masuk
{
    partial class SaveButton
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
            this.tanggalbox = new System.Windows.Forms.DateTimePicker();
            this.namatext = new System.Windows.Forms.TextBox();
            this.jeniscombo = new System.Windows.Forms.ComboBox();
            this.ListBox1 = new System.Windows.Forms.ListBox();
            this.jumlahtext = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.NamaBox = new System.Windows.Forms.Label();
            this.JenisBox = new System.Windows.Forms.Label();
            this.JumlahBox = new System.Windows.Forms.Label();
            this.InputButton = new System.Windows.Forms.Button();
            this.HapusButton = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tanggalbox
            // 
            this.tanggalbox.Location = new System.Drawing.Point(132, 14);
            this.tanggalbox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tanggalbox.Name = "tanggalbox";
            this.tanggalbox.Size = new System.Drawing.Size(233, 21);
            this.tanggalbox.TabIndex = 0;
            // 
            // namatext
            // 
            this.namatext.Location = new System.Drawing.Point(132, 44);
            this.namatext.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.namatext.Name = "namatext";
            this.namatext.Size = new System.Drawing.Size(233, 21);
            this.namatext.TabIndex = 1;
            this.namatext.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // jeniscombo
            // 
            this.jeniscombo.FormattingEnabled = true;
            this.jeniscombo.Items.AddRange(new object[] {
            "Makanan",
            "Minuman"});
            this.jeniscombo.Location = new System.Drawing.Point(132, 80);
            this.jeniscombo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.jeniscombo.Name = "jeniscombo";
            this.jeniscombo.Size = new System.Drawing.Size(233, 23);
            this.jeniscombo.TabIndex = 2;
            // 
            // ListBox1
            // 
            this.ListBox1.FormattingEnabled = true;
            this.ListBox1.ItemHeight = 15;
            this.ListBox1.Location = new System.Drawing.Point(26, 204);
            this.ListBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ListBox1.Name = "ListBox1";
            this.ListBox1.Size = new System.Drawing.Size(745, 184);
            this.ListBox1.TabIndex = 3;
            this.ListBox1.SelectedIndexChanged += new System.EventHandler(this.ListBox1_SelectedIndexChanged);
            // 
            // jumlahtext
            // 
            this.jumlahtext.Location = new System.Drawing.Point(132, 116);
            this.jumlahtext.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.jumlahtext.Name = "jumlahtext";
            this.jumlahtext.Size = new System.Drawing.Size(233, 21);
            this.jumlahtext.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tanggal";
            // 
            // NamaBox
            // 
            this.NamaBox.AutoSize = true;
            this.NamaBox.Location = new System.Drawing.Point(34, 50);
            this.NamaBox.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NamaBox.Name = "NamaBox";
            this.NamaBox.Size = new System.Drawing.Size(84, 15);
            this.NamaBox.TabIndex = 6;
            this.NamaBox.Text = "Nama Barang";
            // 
            // JenisBox
            // 
            this.JenisBox.AutoSize = true;
            this.JenisBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JenisBox.Location = new System.Drawing.Point(34, 83);
            this.JenisBox.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.JenisBox.Name = "JenisBox";
            this.JenisBox.Size = new System.Drawing.Size(79, 15);
            this.JenisBox.TabIndex = 7;
            this.JenisBox.Text = "Jenis Barang";
            // 
            // JumlahBox
            // 
            this.JumlahBox.AutoSize = true;
            this.JumlahBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JumlahBox.Location = new System.Drawing.Point(34, 116);
            this.JumlahBox.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.JumlahBox.Name = "JumlahBox";
            this.JumlahBox.Size = new System.Drawing.Size(91, 15);
            this.JumlahBox.TabIndex = 8;
            this.JumlahBox.Text = "Jumlah Barang";
            // 
            // InputButton
            // 
            this.InputButton.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.InputButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.InputButton.Location = new System.Drawing.Point(488, 0);
            this.InputButton.Name = "InputButton";
            this.InputButton.Size = new System.Drawing.Size(154, 53);
            this.InputButton.TabIndex = 9;
            this.InputButton.Text = "Input Data";
            this.InputButton.UseVisualStyleBackColor = false;
            this.InputButton.Click += new System.EventHandler(this.InputButton_Click);
            // 
            // HapusButton
            // 
            this.HapusButton.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.HapusButton.Location = new System.Drawing.Point(488, 79);
            this.HapusButton.Name = "HapusButton";
            this.HapusButton.Size = new System.Drawing.Size(154, 52);
            this.HapusButton.TabIndex = 10;
            this.HapusButton.Text = "Hapus Data";
            this.HapusButton.UseVisualStyleBackColor = false;
            this.HapusButton.Click += new System.EventHandler(this.HapusButton_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button3.Location = new System.Drawing.Point(693, 411);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(182, 26);
            this.button3.TabIndex = 11;
            this.button3.Text = "Sive File";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(34, 175);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "Tanggal Masuk";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(485, 175);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "Nama Barang";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(221, 175);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 15);
            this.label7.TabIndex = 14;
            this.label7.Text = "Jenis Barang";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(355, 175);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 15);
            this.label8.TabIndex = 15;
            this.label8.Text = "Jumlah Barang";
            // 
            // SaveButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 458);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.HapusButton);
            this.Controls.Add(this.InputButton);
            this.Controls.Add(this.jumlahtext);
            this.Controls.Add(this.ListBox1);
            this.Controls.Add(this.jeniscombo);
            this.Controls.Add(this.namatext);
            this.Controls.Add(this.tanggalbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NamaBox);
            this.Controls.Add(this.JenisBox);
            this.Controls.Add(this.JumlahBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "SaveButton";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.SaveButton_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker tanggalbox;
        private System.Windows.Forms.TextBox namatext;
        private System.Windows.Forms.ComboBox jeniscombo;
        private System.Windows.Forms.ListBox ListBox1;
        private System.Windows.Forms.TextBox jumlahtext;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label NamaBox;
        private System.Windows.Forms.Label JenisBox;
        private System.Windows.Forms.Label JumlahBox;
        private System.Windows.Forms.Button InputButton;
        private System.Windows.Forms.Button HapusButton;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

