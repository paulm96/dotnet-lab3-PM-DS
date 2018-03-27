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
            // URLTextbox
            // 
            this.URLTextbox.Location = new System.Drawing.Point(201, 92);
            this.URLTextbox.Name = "URLTextbox";
            this.URLTextbox.Size = new System.Drawing.Size(219, 20);
            this.URLTextbox.TabIndex = 5;
            // 
            // TextTextbox
            // 
            this.TextTextbox.Location = new System.Drawing.Point(201, 118);
            this.TextTextbox.Name = "TextTextbox";
            this.TextTextbox.Size = new System.Drawing.Size(219, 20);
            this.TextTextbox.TabIndex = 6;
            // 
            // MailTextbox
            // 
            this.MailTextbox.Location = new System.Drawing.Point(200, 240);
            this.MailTextbox.Name = "MailTextbox";
            this.MailTextbox.Size = new System.Drawing.Size(219, 20);
            this.MailTextbox.TabIndex = 7;
            // 
            // URLlabel
            // 
            this.URLlabel.AutoSize = true;
            this.URLlabel.Location = new System.Drawing.Point(142, 95);
            this.URLlabel.Name = "URLlabel";
            this.URLlabel.Size = new System.Drawing.Size(32, 13);
            this.URLlabel.TabIndex = 9;
            this.URLlabel.Text = "URL:";
            // 
            // Tekstlabel
            // 
            this.Tekstlabel.AutoSize = true;
            this.Tekstlabel.Location = new System.Drawing.Point(142, 121);
            this.Tekstlabel.Name = "Tekstlabel";
            this.Tekstlabel.Size = new System.Drawing.Size(37, 13);
            this.Tekstlabel.TabIndex = 10;
            this.Tekstlabel.Text = "Tekst:";
            // 
            // Emaillabel
            // 
            this.Emaillabel.AutoSize = true;
            this.Emaillabel.Location = new System.Drawing.Point(136, 243);
            this.Emaillabel.Name = "Emaillabel";
            this.Emaillabel.Size = new System.Drawing.Size(38, 13);
            this.Emaillabel.TabIndex = 11;
            this.Emaillabel.Text = "E-mail:";
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
            // Tasklistbox
            // 
            this.Tasklistbox.FormattingEnabled = true;
            this.Tasklistbox.Location = new System.Drawing.Point(482, 92);
            this.Tasklistbox.Name = "Tasklistbox";
            this.Tasklistbox.Size = new System.Drawing.Size(235, 95);
            this.Tasklistbox.TabIndex = 13;
            // 
            // Dodajbutton
            // 
            this.Dodajbutton.Location = new System.Drawing.Point(243, 302);
            this.Dodajbutton.Name = "Dodajbutton";
            this.Dodajbutton.Size = new System.Drawing.Size(117, 23);
            this.Dodajbutton.TabIndex = 14;
            this.Dodajbutton.Text = "Dodaj do listy ";
            this.Dodajbutton.UseVisualStyleBackColor = true;
            this.Dodajbutton.Click += new System.EventHandler(this.button2_Click);
            // 
            // Serialbutton
            // 
            this.Serialbutton.Location = new System.Drawing.Point(642, 219);
            this.Serialbutton.Name = "Serialbutton";
            this.Serialbutton.Size = new System.Drawing.Size(75, 26);
            this.Serialbutton.TabIndex = 15;
            this.Serialbutton.Text = "Serialize";
            this.Serialbutton.UseVisualStyleBackColor = true;
            // 
            // Czyscbutton
            // 
            this.Czyscbutton.Location = new System.Drawing.Point(561, 190);
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
            this.Nazwalabel.Location = new System.Drawing.Point(99, 276);
            this.Nazwalabel.Name = "Nazwalabel";
            this.Nazwalabel.Size = new System.Drawing.Size(72, 13);
            this.Nazwalabel.TabIndex = 17;
            this.Nazwalabel.Text = "Nazwa tasku:";
            // 
            // Nazwatextbox
            // 
            this.Nazwatextbox.Location = new System.Drawing.Point(200, 276);
            this.Nazwatextbox.Name = "Nazwatextbox";
            this.Nazwatextbox.Size = new System.Drawing.Size(218, 20);
            this.Nazwatextbox.TabIndex = 18;
            // 
            // DeSerialbutton
            // 
            this.DeSerialbutton.Location = new System.Drawing.Point(642, 190);
            this.DeSerialbutton.Name = "DeSerialbutton";
            this.DeSerialbutton.Size = new System.Drawing.Size(75, 26);
            this.DeSerialbutton.TabIndex = 19;
            this.DeSerialbutton.Text = "De Serialize";
            this.DeSerialbutton.UseVisualStyleBackColor = true;
            // 
            // Stanlabel
            // 
            this.Stanlabel.AutoSize = true;
            this.Stanlabel.Location = new System.Drawing.Point(479, 265);
            this.Stanlabel.Name = "Stanlabel";
            this.Stanlabel.Size = new System.Drawing.Size(0, 13);
            this.Stanlabel.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 335);
            this.Controls.Add(this.Stanlabel);
            this.Controls.Add(this.DeSerialbutton);
            this.Controls.Add(this.Nazwatextbox);
            this.Controls.Add(this.Nazwalabel);
            this.Controls.Add(this.Czyscbutton);
            this.Controls.Add(this.Serialbutton);
            this.Controls.Add(this.Dodajbutton);
            this.Controls.Add(this.Tasklistbox);
            this.Controls.Add(this.Wykonajbutton);
            this.Controls.Add(this.Emaillabel);
            this.Controls.Add(this.Tekstlabel);
            this.Controls.Add(this.URLlabel);
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
    }
}

