namespace Sifreleme_Algoritması
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.text_a = new System.Windows.Forms.TextBox();
            this.text_b = new System.Windows.Forms.TextBox();
            this.text_c = new System.Windows.Forms.TextBox();
            this.text_sifrelenecekmetin = new System.Windows.Forms.TextBox();
            this.text_sifrelimetin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button_sifrele = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.text_cozumlenecekmetin = new System.Windows.Forms.TextBox();
            this.buton_sifrecoz = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.text_cozumlenmismetin = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // text_a
            // 
            this.text_a.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.text_a.Location = new System.Drawing.Point(125, 68);
            this.text_a.Name = "text_a";
            this.text_a.Size = new System.Drawing.Size(140, 30);
            this.text_a.TabIndex = 0;
            // 
            // text_b
            // 
            this.text_b.Location = new System.Drawing.Point(125, 136);
            this.text_b.Name = "text_b";
            this.text_b.Size = new System.Drawing.Size(140, 30);
            this.text_b.TabIndex = 1;
            // 
            // text_c
            // 
            this.text_c.Location = new System.Drawing.Point(125, 191);
            this.text_c.Name = "text_c";
            this.text_c.Size = new System.Drawing.Size(140, 30);
            this.text_c.TabIndex = 2;
            // 
            // text_sifrelenecekmetin
            // 
            this.text_sifrelenecekmetin.Location = new System.Drawing.Point(12, 356);
            this.text_sifrelenecekmetin.Name = "text_sifrelenecekmetin";
            this.text_sifrelenecekmetin.Size = new System.Drawing.Size(505, 30);
            this.text_sifrelenecekmetin.TabIndex = 3;
            // 
            // text_sifrelimetin
            // 
            this.text_sifrelimetin.Location = new System.Drawing.Point(584, 85);
            this.text_sifrelimetin.Name = "text_sifrelimetin";
            this.text_sifrelimetin.Size = new System.Drawing.Size(546, 30);
            this.text_sifrelimetin.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.MenuText;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(46, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "a =";
            this.label1.Click += new System.EventHandler(this.button_sifrele_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.MenuText;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(46, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "b =";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.MenuText;
            this.label3.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label3.Location = new System.Drawing.Point(46, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 23);
            this.label3.TabIndex = 8;
            this.label3.Text = "c =";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(118, 297);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 23);
            this.label4.TabIndex = 9;
            this.label4.Text = "Sifrelenecek Metin";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(776, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 23);
            this.label5.TabIndex = 10;
            this.label5.Text = "Sifrelenmis Metin";
            // 
            // button_sifrele
            // 
            this.button_sifrele.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_sifrele.Location = new System.Drawing.Point(152, 428);
            this.button_sifrele.Name = "button_sifrele";
            this.button_sifrele.Size = new System.Drawing.Size(161, 58);
            this.button_sifrele.TabIndex = 11;
            this.button_sifrele.Text = "Sifrele";
            this.button_sifrele.UseVisualStyleBackColor = false;
            this.button_sifrele.Click += new System.EventHandler(this.button_sifrele_Click_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label6.Location = new System.Drawing.Point(765, 297);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(170, 23);
            this.label6.TabIndex = 12;
            this.label6.Text = "Cozumlenecek Metin";
            // 
            // text_cozumlenecekmetin
            // 
            this.text_cozumlenecekmetin.Location = new System.Drawing.Point(601, 356);
            this.text_cozumlenecekmetin.Name = "text_cozumlenecekmetin";
            this.text_cozumlenecekmetin.Size = new System.Drawing.Size(529, 30);
            this.text_cozumlenecekmetin.TabIndex = 13;
            // 
            // buton_sifrecoz
            // 
            this.buton_sifrecoz.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buton_sifrecoz.Location = new System.Drawing.Point(766, 429);
            this.buton_sifrecoz.Name = "buton_sifrecoz";
            this.buton_sifrecoz.Size = new System.Drawing.Size(169, 57);
            this.buton_sifrecoz.TabIndex = 14;
            this.buton_sifrecoz.Text = "Sifre Coz";
            this.buton_sifrecoz.UseVisualStyleBackColor = false;
            this.buton_sifrecoz.Click += new System.EventHandler(this.buton_sifrecoz_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(765, 167);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(162, 23);
            this.label7.TabIndex = 15;
            this.label7.Text = "Cozumlenmis Metin";
            // 
            // text_cozumlenmismetin
            // 
            this.text_cozumlenmismetin.Location = new System.Drawing.Point(584, 225);
            this.text_cozumlenmismetin.Name = "text_cozumlenmismetin";
            this.text_cozumlenmismetin.Size = new System.Drawing.Size(546, 30);
            this.text_cozumlenmismetin.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(1167, 528);
            this.Controls.Add(this.text_cozumlenmismetin);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.buton_sifrecoz);
            this.Controls.Add(this.text_cozumlenecekmetin);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button_sifrele);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.text_sifrelimetin);
            this.Controls.Add(this.text_sifrelenecekmetin);
            this.Controls.Add(this.text_c);
            this.Controls.Add(this.text_b);
            this.Controls.Add(this.text_a);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox text_a;
        private TextBox text_b;
        private TextBox text_c;
        private TextBox text_sifrelenecekmetin;
        private TextBox text_sifrelimetin;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button button_sifrele;
        private Label label6;
        private TextBox text_cozumlenecekmetin;
        private Button buton_sifrecoz;
        private Label label7;
        private TextBox text_cozumlenmismetin;
    }
}