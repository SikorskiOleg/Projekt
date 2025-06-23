namespace Test
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
            this.tytul = new System.Windows.Forms.Label();
            this.wstep = new System.Windows.Forms.TextBox();
            this.smierc = new System.Windows.Forms.Button();
            this.wysluchaj = new System.Windows.Forms.Button();
            this.uciekaj = new System.Windows.Forms.Button();
            this.ponownie = new System.Windows.Forms.Button();
            this.poddaj = new System.Windows.Forms.Button();
            this.que1 = new System.Windows.Forms.Button();
            this.que2 = new System.Windows.Forms.Button();
            this.que3 = new System.Windows.Forms.Button();
            this.que4 = new System.Windows.Forms.Button();
            this.pytanie = new System.Windows.Forms.Button();
            this.blokpytanie = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tytul
            // 
            this.tytul.AutoSize = true;
            this.tytul.Font = new System.Drawing.Font("Times New Roman", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tytul.Location = new System.Drawing.Point(378, 37);
            this.tytul.Name = "tytul";
            this.tytul.Size = new System.Drawing.Size(483, 90);
            this.tytul.TabIndex = 0;
            this.tytul.Text = "Próba Sfinxa";
            // 
            // wstep
            // 
            this.wstep.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.wstep.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.wstep.Location = new System.Drawing.Point(60, 210);
            this.wstep.Multiline = true;
            this.wstep.Name = "wstep";
            this.wstep.Size = new System.Drawing.Size(1146, 289);
            this.wstep.TabIndex = 1;
            // 
            // smierc
            // 
            this.smierc.Location = new System.Drawing.Point(564, 556);
            this.smierc.Name = "smierc";
            this.smierc.Size = new System.Drawing.Size(180, 85);
            this.smierc.TabIndex = 2;
            this.smierc.Text = "Obejdź Sfinxa";
            this.smierc.UseVisualStyleBackColor = true;
            // 
            // wysluchaj
            // 
            this.wysluchaj.Location = new System.Drawing.Point(825, 556);
            this.wysluchaj.Name = "wysluchaj";
            this.wysluchaj.Size = new System.Drawing.Size(198, 85);
            this.wysluchaj.TabIndex = 3;
            this.wysluchaj.Text = "Wysłuchaj Zagadek";
            this.wysluchaj.UseVisualStyleBackColor = true;
            // 
            // uciekaj
            // 
            this.uciekaj.Location = new System.Drawing.Point(290, 556);
            this.uciekaj.Name = "uciekaj";
            this.uciekaj.Size = new System.Drawing.Size(180, 85);
            this.uciekaj.TabIndex = 4;
            this.uciekaj.Text = "Uciekaj";
            this.uciekaj.UseVisualStyleBackColor = true;
            // 
            // ponownie
            // 
            this.ponownie.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ponownie.Location = new System.Drawing.Point(188, 548);
            this.ponownie.Name = "ponownie";
            this.ponownie.Size = new System.Drawing.Size(344, 86);
            this.ponownie.TabIndex = 5;
            this.ponownie.Text = "Spróbuj Ponownie";
            this.ponownie.UseVisualStyleBackColor = true;
            this.ponownie.Visible = false;
            // 
            // poddaj
            // 
            this.poddaj.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.poddaj.Location = new System.Drawing.Point(611, 556);
            this.poddaj.Name = "poddaj";
            this.poddaj.Size = new System.Drawing.Size(344, 86);
            this.poddaj.TabIndex = 6;
            this.poddaj.Text = "Poddaj się";
            this.poddaj.UseVisualStyleBackColor = true;
            this.poddaj.Visible = false;
            // 
            // que1
            // 
            this.que1.Location = new System.Drawing.Point(353, 227);
            this.que1.Name = "que1";
            this.que1.Size = new System.Drawing.Size(127, 62);
            this.que1.TabIndex = 7;
            this.que1.Text = "button1";
            this.que1.UseVisualStyleBackColor = true;
            this.que1.Visible = false;
            // 
            // que2
            // 
            this.que2.Location = new System.Drawing.Point(700, 227);
            this.que2.Name = "que2";
            this.que2.Size = new System.Drawing.Size(127, 62);
            this.que2.TabIndex = 8;
            this.que2.Text = "button2";
            this.que2.UseVisualStyleBackColor = true;
            this.que2.Visible = false;
            // 
            // que3
            // 
            this.que3.Location = new System.Drawing.Point(353, 319);
            this.que3.Name = "que3";
            this.que3.Size = new System.Drawing.Size(127, 62);
            this.que3.TabIndex = 9;
            this.que3.Text = "button3";
            this.que3.UseVisualStyleBackColor = true;
            this.que3.Visible = false;
            // 
            // que4
            // 
            this.que4.Location = new System.Drawing.Point(700, 319);
            this.que4.Name = "que4";
            this.que4.Size = new System.Drawing.Size(127, 62);
            this.que4.TabIndex = 10;
            this.que4.Text = "button4";
            this.que4.UseVisualStyleBackColor = true;
            this.que4.Visible = false;
            // 
            // pytanie
            // 
            this.pytanie.Location = new System.Drawing.Point(564, 556);
            this.pytanie.Name = "pytanie";
            this.pytanie.Size = new System.Drawing.Size(180, 85);
            this.pytanie.TabIndex = 11;
            this.pytanie.Text = "button5";
            this.pytanie.UseVisualStyleBackColor = true;
            this.pytanie.Visible = false;
            // 
            // blokpytanie
            // 
            this.blokpytanie.Location = new System.Drawing.Point(353, 84);
            this.blokpytanie.Multiline = true;
            this.blokpytanie.Name = "blokpytanie";
            this.blokpytanie.Size = new System.Drawing.Size(474, 101);
            this.blokpytanie.TabIndex = 12;
            this.blokpytanie.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1260, 690);
            this.Controls.Add(this.blokpytanie);
            this.Controls.Add(this.pytanie);
            this.Controls.Add(this.que4);
            this.Controls.Add(this.que3);
            this.Controls.Add(this.que2);
            this.Controls.Add(this.que1);
            this.Controls.Add(this.poddaj);
            this.Controls.Add(this.ponownie);
            this.Controls.Add(this.uciekaj);
            this.Controls.Add(this.wysluchaj);
            this.Controls.Add(this.smierc);
            this.Controls.Add(this.wstep);
            this.Controls.Add(this.tytul);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tytul;
        private System.Windows.Forms.TextBox wstep;
        private System.Windows.Forms.Button smierc;
        private System.Windows.Forms.Button wysluchaj;
        private System.Windows.Forms.Button uciekaj;
        private System.Windows.Forms.Button ponownie;
        private System.Windows.Forms.Button poddaj;
        private System.Windows.Forms.Button que1;
        private System.Windows.Forms.Button que2;
        private System.Windows.Forms.Button que3;
        private System.Windows.Forms.Button que4;
        private System.Windows.Forms.Button pytanie;
        private System.Windows.Forms.TextBox blokpytanie;
    }
}

