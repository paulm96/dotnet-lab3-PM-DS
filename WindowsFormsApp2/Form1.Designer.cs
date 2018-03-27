namespace WindowsFormsApp2
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.Jezelilabel = new System.Windows.Forms.Label();
            this.Tolabel = new System.Windows.Forms.Label();
            this.Totolabel = new System.Windows.Forms.Label();
            this.Conditionlabel = new System.Windows.Forms.Label();
            this.Actionlabel = new System.Windows.Forms.Label();
            this.URLTextbox = new System.Windows.Forms.TextBox();
            this.TextTextbox = new System.Windows.Forms.TextBox();
            this.MailTextbox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Wykonajbutton = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.Stanlabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Jezelilabel
            // 
            this.Jezelilabel.AutoSize = true;
            this.Jezelilabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Jezelilabel.Location = new System.Drawing.Point(249, 13);
            this.Jezelilabel.Name = "Jezelilabel";
            this.Jezelilabel.Size = new System.Drawing.Size(81, 25);
            this.Jezelilabel.TabIndex = 0;
            this.Jezelilabel.Text = "JEŻELI";
            // 
            // Tolabel
            // 
            this.Tolabel.AutoSize = true;
            this.Tolabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Tolabel.Location = new System.Drawing.Point(70, 42);
            this.Tolabel.Name = "Tolabel";
            this.Tolabel.Size = new System.Drawing.Size(22, 16);
            this.Tolabel.TabIndex = 1;
            this.Tolabel.Text = "to:";
            // 
            // Totolabel
            // 
            this.Totolabel.AutoSize = true;
            this.Totolabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Totolabel.Location = new System.Drawing.Point(44, 169);
            this.Totolabel.Name = "Totolabel";
            this.Totolabel.Size = new System.Drawing.Size(88, 16);
            this.Totolabel.TabIndex = 2;
            this.Totolabel.Text = "to wykonaj to:";
            // 
            // Conditionlabel
            // 
            this.Conditionlabel.AutoSize = true;
            this.Conditionlabel.Location = new System.Drawing.Point(102, 67);
            this.Conditionlabel.Name = "Conditionlabel";
            this.Conditionlabel.Size = new System.Drawing.Size(325, 13);
            this.Conditionlabel.TabIndex = 3;
            this.Conditionlabel.Text = "na danej stronie znajduje się obrazek, którego podpis zawiera tekst:";
            // 
            // Actionlabel
            // 
            this.Actionlabel.AutoSize = true;
            this.Actionlabel.Location = new System.Drawing.Point(102, 211);
            this.Actionlabel.Name = "Actionlabel";
            this.Actionlabel.Size = new System.Drawing.Size(327, 13);
            this.Actionlabel.TabIndex = 4;
            this.Actionlabel.Text = "wyślij na podany adres e-mail wiadomość ze znalezionym obrazkiem:";
            // 
            // URLlabel
            // 
            this.URLTextbox.Location = new System.Drawing.Point(201, 92);
            this.URLTextbox.Name = "URLlabel";
            this.URLTextbox.Size = new System.Drawing.Size(219, 20);
            this.URLTextbox.TabIndex = 5;
            // 
            // Textlabel
            // 
            this.TextTextbox.Location = new System.Drawing.Point(201, 118);
            this.TextTextbox.Name = "Textlabel";
            this.TextTextbox.Size = new System.Drawing.Size(219, 20);
            this.TextTextbox.TabIndex = 6;
            // 
            // Maillabel
            // 
            this.MailTextbox.Location = new System.Drawing.Point(200, 240);
            this.MailTextbox.Name = "Maillabel";
            this.MailTextbox.Size = new System.Drawing.Size(219, 20);
            this.MailTextbox.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(142, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "URL:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(142, 121);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Tekst:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(136, 243);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "E-mail:";
            // 
            // Wykonajbutton
            // 
            this.Wykonajbutton.Location = new System.Drawing.Point(482, 190);
            this.Wykonajbutton.Name = "Wykonajbutton";
            this.Wykonajbutton.Size = new System.Drawing.Size(75, 55);
            this.Wykonajbutton.TabIndex = 12;
            this.Wykonajbutton.Text = "Wykonaj";
            this.Wykonajbutton.UseVisualStyleBackColor = true;
            this.Wykonajbutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(482, 92);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(235, 95);
            this.listBox1.TabIndex = 13;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(243, 302);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "Dodaj do listy ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(642, 219);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 26);
            this.button3.TabIndex = 15;
            this.button3.Text = "Serialize";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(561, 190);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 55);
            this.button4.TabIndex = 16;
            this.button4.Text = "Czyść";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(99, 276);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Nazwa tekstu:";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(200, 276);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(218, 20);
            this.textBox4.TabIndex = 18;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(642, 190);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 26);
            this.button5.TabIndex = 19;
            this.button5.Text = "De Serialize";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // Stanlabel
            // 
            this.Stanlabel.AutoSize = true;
            this.Stanlabel.Location = new System.Drawing.Point(388, 307);
            this.Stanlabel.Name = "Stanlabel";
            this.Stanlabel.Size = new System.Drawing.Size(41, 13);
            this.Stanlabel.TabIndex = 20;
            this.Stanlabel.Text = "label10";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 335);
            this.Controls.Add(this.Stanlabel);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.Wykonajbutton);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.MailTextbox);
            this.Controls.Add(this.TextTextbox);
            this.Controls.Add(this.URLTextbox);
            this.Controls.Add(this.Actionlabel);
            this.Controls.Add(this.Conditionlabel);
            this.Controls.Add(this.Totolabel);
            this.Controls.Add(this.Tolabel);
            this.Controls.Add(this.Jezelilabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Jezelilabel;
        private System.Windows.Forms.Label Tolabel;
        private System.Windows.Forms.Label Totolabel;
        private System.Windows.Forms.Label Conditionlabel;
        private System.Windows.Forms.Label Actionlabel;
        private System.Windows.Forms.TextBox URLTextbox;
        private System.Windows.Forms.TextBox TextTextbox;
        private System.Windows.Forms.TextBox MailTextbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button Wykonajbutton;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label Stanlabel;
    }
}

