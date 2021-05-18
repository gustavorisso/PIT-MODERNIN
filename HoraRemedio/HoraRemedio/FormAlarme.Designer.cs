
namespace HoraRemedio
{
    partial class FormAlarme
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbSeg = new System.Windows.Forms.CheckBox();
            this.cbTer = new System.Windows.Forms.CheckBox();
            this.cbQui = new System.Windows.Forms.CheckBox();
            this.cbQua = new System.Windows.Forms.CheckBox();
            this.cbDom = new System.Windows.Forms.CheckBox();
            this.cbSab = new System.Windows.Forms.CheckBox();
            this.cbSex = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.clbAlarme = new System.Windows.Forms.CheckedListBox();
            this.clbSons = new System.Windows.Forms.CheckedListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.numHora = new System.Windows.Forms.NumericUpDown();
            this.numMinuto = new System.Windows.Forms.NumericUpDown();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.metroButton4 = new MetroFramework.Controls.MetroButton();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.numHora)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinuto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Intro ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Hora:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Intro ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(112, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Minuto:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(13, 250);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(197, 26);
            this.textBox1.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Intro ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "Remédio:";
            // 
            // cbSeg
            // 
            this.cbSeg.AutoSize = true;
            this.cbSeg.Location = new System.Drawing.Point(17, 311);
            this.cbSeg.Name = "cbSeg";
            this.cbSeg.Size = new System.Drawing.Size(45, 17);
            this.cbSeg.TabIndex = 8;
            this.cbSeg.Text = "Seg";
            this.cbSeg.UseVisualStyleBackColor = true;
            // 
            // cbTer
            // 
            this.cbTer.AutoSize = true;
            this.cbTer.Location = new System.Drawing.Point(17, 334);
            this.cbTer.Name = "cbTer";
            this.cbTer.Size = new System.Drawing.Size(42, 17);
            this.cbTer.TabIndex = 9;
            this.cbTer.Text = "Ter";
            this.cbTer.UseVisualStyleBackColor = true;
            // 
            // cbQui
            // 
            this.cbQui.AutoSize = true;
            this.cbQui.Location = new System.Drawing.Point(68, 311);
            this.cbQui.Name = "cbQui";
            this.cbQui.Size = new System.Drawing.Size(42, 17);
            this.cbQui.TabIndex = 11;
            this.cbQui.Text = "Qui";
            this.cbQui.UseVisualStyleBackColor = true;
            // 
            // cbQua
            // 
            this.cbQua.AutoSize = true;
            this.cbQua.Location = new System.Drawing.Point(16, 357);
            this.cbQua.Name = "cbQua";
            this.cbQua.Size = new System.Drawing.Size(46, 17);
            this.cbQua.TabIndex = 10;
            this.cbQua.Text = "Qua";
            this.cbQua.UseVisualStyleBackColor = true;
            // 
            // cbDom
            // 
            this.cbDom.AutoSize = true;
            this.cbDom.Location = new System.Drawing.Point(116, 311);
            this.cbDom.Name = "cbDom";
            this.cbDom.Size = new System.Drawing.Size(48, 17);
            this.cbDom.TabIndex = 14;
            this.cbDom.Text = "Dom";
            this.cbDom.UseVisualStyleBackColor = true;
            // 
            // cbSab
            // 
            this.cbSab.AutoSize = true;
            this.cbSab.Location = new System.Drawing.Point(68, 357);
            this.cbSab.Name = "cbSab";
            this.cbSab.Size = new System.Drawing.Size(45, 17);
            this.cbSab.TabIndex = 13;
            this.cbSab.Text = "Sab";
            this.cbSab.UseVisualStyleBackColor = true;
            this.cbSab.CheckedChanged += new System.EventHandler(this.checkBox6_CheckedChanged);
            // 
            // cbSex
            // 
            this.cbSex.AutoSize = true;
            this.cbSex.Location = new System.Drawing.Point(68, 334);
            this.cbSex.Name = "cbSex";
            this.cbSex.Size = new System.Drawing.Size(44, 17);
            this.cbSex.TabIndex = 12;
            this.cbSex.Text = "Sex";
            this.cbSex.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Intro ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 288);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 19);
            this.label5.TabIndex = 15;
            this.label5.Text = "Dias:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Intro ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(314, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(173, 19);
            this.label6.TabIndex = 17;
            this.label6.Text = "Alarmes Prontos:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // clbAlarme
            // 
            this.clbAlarme.FormattingEnabled = true;
            this.clbAlarme.Location = new System.Drawing.Point(318, 98);
            this.clbAlarme.Name = "clbAlarme";
            this.clbAlarme.Size = new System.Drawing.Size(363, 274);
            this.clbAlarme.TabIndex = 18;
            this.clbAlarme.SelectedIndexChanged += new System.EventHandler(this.clbAlarme_SelectedIndexChanged);
            // 
            // clbSons
            // 
            this.clbSons.FormattingEnabled = true;
            this.clbSons.Items.AddRange(new object[] {
            "Som 1",
            "Som 2",
            "Som 3"});
            this.clbSons.Location = new System.Drawing.Point(159, 369);
            this.clbSons.Name = "clbSons";
            this.clbSons.Size = new System.Drawing.Size(110, 49);
            this.clbSons.TabIndex = 19;
            this.clbSons.SelectedIndexChanged += new System.EventHandler(this.checkedListBox2_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Intro ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(181, 347);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 19);
            this.label7.TabIndex = 23;
            this.label7.Text = "Sons:";
            // 
            // numHora
            // 
            this.numHora.Location = new System.Drawing.Point(13, 195);
            this.numHora.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.numHora.Name = "numHora";
            this.numHora.Size = new System.Drawing.Size(97, 20);
            this.numHora.TabIndex = 24;
            this.numHora.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numMinuto
            // 
            this.numMinuto.Location = new System.Drawing.Point(116, 195);
            this.numMinuto.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numMinuto.Name = "numMinuto";
            this.numMinuto.Size = new System.Drawing.Size(94, 20);
            this.numMinuto.TabIndex = 25;
            this.numMinuto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HoraRemedio.Properties.Resources.untitleddesign_1_original_24;
            this.pictureBox1.Location = new System.Drawing.Point(23, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // metroButton4
            // 
            this.metroButton4.Location = new System.Drawing.Point(13, 396);
            this.metroButton4.Name = "metroButton4";
            this.metroButton4.Size = new System.Drawing.Size(71, 22);
            this.metroButton4.TabIndex = 29;
            this.metroButton4.Text = "VOLTAR";
            this.metroButton4.UseSelectable = true;
            this.metroButton4.Click += new System.EventHandler(this.metroButton4_Click);
            // 
            // metroButton3
            // 
            this.metroButton3.Location = new System.Drawing.Point(318, 385);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(143, 23);
            this.metroButton3.TabIndex = 30;
            this.metroButton3.Text = "SALVAR ALARME";
            this.metroButton3.UseSelectable = true;
            this.metroButton3.Click += new System.EventHandler(this.metroButton3_Click_1);
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(538, 385);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(143, 23);
            this.metroButton1.TabIndex = 31;
            this.metroButton1.Text = "REMOVER ALARME";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click_1);
            // 
            // FormAlarme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 441);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.metroButton3);
            this.Controls.Add(this.metroButton4);
            this.Controls.Add(this.numMinuto);
            this.Controls.Add(this.numHora);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.clbSons);
            this.Controls.Add(this.clbAlarme);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbDom);
            this.Controls.Add(this.cbSab);
            this.Controls.Add(this.cbSex);
            this.Controls.Add(this.cbQui);
            this.Controls.Add(this.cbQua);
            this.Controls.Add(this.cbTer);
            this.Controls.Add(this.cbSeg);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormAlarme";
            this.Text = "Alarme";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.FormAlarme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numHora)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinuto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox cbSeg;
        private System.Windows.Forms.CheckBox cbTer;
        private System.Windows.Forms.CheckBox cbQui;
        private System.Windows.Forms.CheckBox cbQua;
        private System.Windows.Forms.CheckBox cbDom;
        private System.Windows.Forms.CheckBox cbSab;
        private System.Windows.Forms.CheckBox cbSex;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckedListBox clbAlarme;
        private System.Windows.Forms.CheckedListBox clbSons;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numHora;
        private System.Windows.Forms.NumericUpDown numMinuto;
        private MetroFramework.Controls.MetroButton metroButton4;
        private MetroFramework.Controls.MetroButton metroButton3;
        private MetroFramework.Controls.MetroButton metroButton1;
    }
}