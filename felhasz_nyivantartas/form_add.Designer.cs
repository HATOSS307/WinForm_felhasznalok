namespace felhasz_nyivantartas
{
    partial class form_add
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
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1_nev = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.list_adatok = new System.Windows.Forms.ListBox();
            this.button_save = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button_kep_feltolt = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(469, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 83;
            this.label3.Text = "Profilkép:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(526, 126);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(196, 20);
            this.dateTimePicker1.TabIndex = 82;
            // 
            // textBox_id
            // 
            this.textBox_id.Location = new System.Drawing.Point(526, 62);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.ReadOnly = true;
            this.textBox_id.Size = new System.Drawing.Size(84, 20);
            this.textBox_id.TabIndex = 81;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(501, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 13);
            this.label5.TabIndex = 80;
            this.label5.Text = "Id:";
            // 
            // textBox1_nev
            // 
            this.textBox1_nev.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
            this.textBox1_nev.Location = new System.Drawing.Point(526, 96);
            this.textBox1_nev.Name = "textBox1_nev";
            this.textBox1_nev.Size = new System.Drawing.Size(84, 20);
            this.textBox1_nev.TabIndex = 79;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(490, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 78;
            this.label2.Text = "Név:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(436, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 77;
            this.label1.Text = "Születési dátum:";
            // 
            // list_adatok
            // 
            this.list_adatok.FormattingEnabled = true;
            this.list_adatok.Location = new System.Drawing.Point(76, 22);
            this.list_adatok.Name = "list_adatok";
            this.list_adatok.Size = new System.Drawing.Size(274, 407);
            this.list_adatok.TabIndex = 76;
            this.list_adatok.SelectedIndexChanged += new System.EventHandler(this.list_adatok_SelectedIndexChanged);
            // 
            // button_save
            // 
            this.button_save.Location = new System.Drawing.Point(526, 371);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(196, 44);
            this.button_save.TabIndex = 85;
            this.button_save.Text = "Adatok mentése";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button_kep_feltolt
            // 
            this.button_kep_feltolt.Location = new System.Drawing.Point(526, 327);
            this.button_kep_feltolt.Name = "button_kep_feltolt";
            this.button_kep_feltolt.Size = new System.Drawing.Size(196, 38);
            this.button_kep_feltolt.TabIndex = 86;
            this.button_kep_feltolt.Text = "Kép feltöltése";
            this.button_kep_feltolt.UseVisualStyleBackColor = true;
            this.button_kep_feltolt.Click += new System.EventHandler(this.button_kep_feltolt_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(537, 163);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(185, 147);
            this.pictureBox1.TabIndex = 87;
            this.pictureBox1.TabStop = false;
            // 
            // form_add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button_kep_feltolt);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBox_id);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox1_nev);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.list_adatok);
            this.Name = "form_add";
            this.Text = "form_add";
            this.Load += new System.EventHandler(this.form_add_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1_nev;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox list_adatok;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button_kep_feltolt;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}