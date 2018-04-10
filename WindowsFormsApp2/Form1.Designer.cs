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
            this.URLlabel = new System.Windows.Forms.Label();
            this.Tekstlabel = new System.Windows.Forms.Label();
            this.Emaillabel = new System.Windows.Forms.Label();
            this.Wykonajbutton = new System.Windows.Forms.Button();
            this.Tasklistbox = new System.Windows.Forms.ListBox();
            this.Dodajbutton = new System.Windows.Forms.Button();
            this.Serialbutton = new System.Windows.Forms.Button();
            this.Czyscbutton = new System.Windows.Forms.Button();
            this.Nazwalabel = new System.Windows.Forms.Label();
            this.Nazwatextbox = new System.Windows.Forms.TextBox();
            this.DeSerialbutton = new System.Windows.Forms.Button();
            this.Stanlabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
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
            this.Totolabel.Location = new System.Drawing.Point(46, 184);
            this.Totolabel.Name = "Totolabel";
            this.Totolabel.Size = new System.Drawing.Size(88, 16);
            this.Totolabel.TabIndex = 2;
            this.Totolabel.Text = "to wykonaj to:";
            // 
            // Conditionlabel
            // 
            this.Conditionlabel.AutoSize = true;
            this.Conditionlabel.Location = new System.Drawing.Point(6, 9);
            this.Conditionlabel.Name = "Conditionlabel";
            this.Conditionlabel.Size = new System.Drawing.Size(325, 13);
            this.Conditionlabel.TabIndex = 3;
            this.Conditionlabel.Text = "na danej stronie znajduje się obrazek, którego podpis zawiera tekst:";
            // 
            // Actionlabel
            // 
            this.Actionlabel.AutoSize = true;
            this.Actionlabel.Location = new System.Drawing.Point(6, 3);
            this.Actionlabel.Name = "Actionlabel";
            this.Actionlabel.Size = new System.Drawing.Size(327, 13);
            this.Actionlabel.TabIndex = 4;
            this.Actionlabel.Text = "wyślij na podany adres e-mail wiadomość ze znalezionym obrazkiem:";
            // 
            // URLTextbox
            // 
            this.URLTextbox.Location = new System.Drawing.Point(80, 33);
            this.URLTextbox.Name = "URLTextbox";
            this.URLTextbox.Size = new System.Drawing.Size(219, 20);
            this.URLTextbox.TabIndex = 5;
            // 
            // TextTextbox
            // 
            this.TextTextbox.Location = new System.Drawing.Point(80, 59);
            this.TextTextbox.Name = "TextTextbox";
            this.TextTextbox.Size = new System.Drawing.Size(219, 20);
            this.TextTextbox.TabIndex = 6;
            // 
            // MailTextbox
            // 
            this.MailTextbox.Location = new System.Drawing.Point(65, 29);
            this.MailTextbox.Name = "MailTextbox";
            this.MailTextbox.Size = new System.Drawing.Size(219, 20);
            this.MailTextbox.TabIndex = 7;
            // 
            // URLlabel
            // 
            this.URLlabel.AutoSize = true;
            this.URLlabel.Location = new System.Drawing.Point(28, 37);
            this.URLlabel.Name = "URLlabel";
            this.URLlabel.Size = new System.Drawing.Size(32, 13);
            this.URLlabel.TabIndex = 9;
            this.URLlabel.Text = "URL:";
            // 
            // Tekstlabel
            // 
            this.Tekstlabel.AutoSize = true;
            this.Tekstlabel.Location = new System.Drawing.Point(23, 66);
            this.Tekstlabel.Name = "Tekstlabel";
            this.Tekstlabel.Size = new System.Drawing.Size(37, 13);
            this.Tekstlabel.TabIndex = 10;
            this.Tekstlabel.Text = "Tekst:";
            // 
            // Emaillabel
            // 
            this.Emaillabel.AutoSize = true;
            this.Emaillabel.Location = new System.Drawing.Point(18, 32);
            this.Emaillabel.Name = "Emaillabel";
            this.Emaillabel.Size = new System.Drawing.Size(38, 13);
            this.Emaillabel.TabIndex = 11;
            this.Emaillabel.Text = "E-mail:";
            // 
            // Wykonajbutton
            // 
            this.Wykonajbutton.Location = new System.Drawing.Point(500, 176);
            this.Wykonajbutton.Name = "Wykonajbutton";
            this.Wykonajbutton.Size = new System.Drawing.Size(75, 55);
            this.Wykonajbutton.TabIndex = 12;
            this.Wykonajbutton.Text = "Wykonaj";
            this.Wykonajbutton.UseVisualStyleBackColor = true;
            this.Wykonajbutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // Tasklistbox
            // 
            this.Tasklistbox.FormattingEnabled = true;
            this.Tasklistbox.Location = new System.Drawing.Point(502, 64);
            this.Tasklistbox.Name = "Tasklistbox";
            this.Tasklistbox.Size = new System.Drawing.Size(235, 108);
            this.Tasklistbox.TabIndex = 13;
            // 
            // Dodajbutton
            // 
            this.Dodajbutton.Location = new System.Drawing.Point(113, 378);
            this.Dodajbutton.Name = "Dodajbutton";
            this.Dodajbutton.Size = new System.Drawing.Size(125, 33);
            this.Dodajbutton.TabIndex = 14;
            this.Dodajbutton.Text = "Dodaj do listy ";
            this.Dodajbutton.UseVisualStyleBackColor = true;
            this.Dodajbutton.Click += new System.EventHandler(this.button2_Click);
            // 
            // Serialbutton
            // 
            this.Serialbutton.Location = new System.Drawing.Point(662, 205);
            this.Serialbutton.Name = "Serialbutton";
            this.Serialbutton.Size = new System.Drawing.Size(75, 26);
            this.Serialbutton.TabIndex = 15;
            this.Serialbutton.Text = "Serialize";
            this.Serialbutton.UseVisualStyleBackColor = true;
            this.Serialbutton.Click += new System.EventHandler(this.Serialbutton_Click);
            // 
            // Czyscbutton
            // 
            this.Czyscbutton.Location = new System.Drawing.Point(581, 176);
            this.Czyscbutton.Name = "Czyscbutton";
            this.Czyscbutton.Size = new System.Drawing.Size(75, 55);
            this.Czyscbutton.TabIndex = 16;
            this.Czyscbutton.Text = "Czyść";
            this.Czyscbutton.UseVisualStyleBackColor = true;
            this.Czyscbutton.Click += new System.EventHandler(this.Czyscbutton_Click);
            // 
            // Nazwalabel
            // 
            this.Nazwalabel.AutoSize = true;
            this.Nazwalabel.Location = new System.Drawing.Point(110, 355);
            this.Nazwalabel.Name = "Nazwalabel";
            this.Nazwalabel.Size = new System.Drawing.Size(72, 13);
            this.Nazwalabel.TabIndex = 17;
            this.Nazwalabel.Text = "Nazwa tasku:";
            // 
            // Nazwatextbox
            // 
            this.Nazwatextbox.Location = new System.Drawing.Point(179, 352);
            this.Nazwatextbox.Name = "Nazwatextbox";
            this.Nazwatextbox.Size = new System.Drawing.Size(218, 20);
            this.Nazwatextbox.TabIndex = 18;
            // 
            // DeSerialbutton
            // 
            this.DeSerialbutton.Location = new System.Drawing.Point(662, 174);
            this.DeSerialbutton.Name = "DeSerialbutton";
            this.DeSerialbutton.Size = new System.Drawing.Size(75, 26);
            this.DeSerialbutton.TabIndex = 19;
            this.DeSerialbutton.Text = "De Serialize";
            this.DeSerialbutton.UseVisualStyleBackColor = true;
            this.DeSerialbutton.Click += new System.EventHandler(this.DeSerialbutton_Click_1);
            // 
            // Stanlabel
            // 
            this.Stanlabel.AutoSize = true;
            this.Stanlabel.Location = new System.Drawing.Point(479, 265);
            this.Stanlabel.Name = "Stanlabel";
            this.Stanlabel.Size = new System.Drawing.Size(0, 13);
            this.Stanlabel.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(558, 292);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "label1";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(105, 42);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(371, 130);
            this.tabControl1.TabIndex = 21;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.Conditionlabel);
            this.tabPage1.Controls.Add(this.URLTextbox);
            this.tabPage1.Controls.Add(this.URLlabel);
            this.tabPage1.Controls.Add(this.Tekstlabel);
            this.tabPage1.Controls.Add(this.TextTextbox);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(363, 104);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Sprawdź stronę";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.textBox2);
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(363, 104);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Sprawdź pogodę ";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(247, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Temperatura w tym mieście jest wyższa niż wartość";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(91, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(160, 20);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(91, 67);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(162, 20);
            this.textBox2.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Miasto:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Temperatura:";
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Location = new System.Drawing.Point(109, 205);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(364, 129);
            this.tabControl2.TabIndex = 22;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.Actionlabel);
            this.tabPage3.Controls.Add(this.MailTextbox);
            this.tabPage3.Controls.Add(this.Emaillabel);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(356, 103);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Wyślij e-mail";
            this.tabPage3.UseVisualStyleBackColor = true;
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.label5);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(356, 103);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Pokaż komunikat";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Wyświetl komunikat na ektanie";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(502, 247);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(235, 95);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 413);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.tabControl2);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.Stanlabel);
            this.Controls.Add(this.DeSerialbutton);
            this.Controls.Add(this.Nazwatextbox);
            this.Controls.Add(this.Nazwalabel);
            this.Controls.Add(this.Czyscbutton);
            this.Controls.Add(this.Serialbutton);
            this.Controls.Add(this.Dodajbutton);
            this.Controls.Add(this.Tasklistbox);
            this.Controls.Add(this.Wykonajbutton);
            this.Controls.Add(this.Totolabel);
            this.Controls.Add(this.Tolabel);
            this.Controls.Add(this.Jezelilabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabControl2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
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
        private System.Windows.Forms.Label URLlabel;
        private System.Windows.Forms.Label Tekstlabel;
        private System.Windows.Forms.Label Emaillabel;
        private System.Windows.Forms.Button Wykonajbutton;
        private System.Windows.Forms.ListBox Tasklistbox;
        private System.Windows.Forms.Button Dodajbutton;
        private System.Windows.Forms.Button Serialbutton;
        private System.Windows.Forms.Button Czyscbutton;
        private System.Windows.Forms.Label Nazwalabel;
        private System.Windows.Forms.TextBox Nazwatextbox;
        private System.Windows.Forms.Button DeSerialbutton;
        private System.Windows.Forms.Label Stanlabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox listBox1;
    }
}

