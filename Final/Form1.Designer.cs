namespace Final
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label tytul;
        private System.Windows.Forms.TextBox wstep;
        private System.Windows.Forms.Label blokpytanie;
        private System.Windows.Forms.Button que1;
        private System.Windows.Forms.Button que2;
        private System.Windows.Forms.Button que3;
        private System.Windows.Forms.Button que4;
        private System.Windows.Forms.Button smierc;
        private System.Windows.Forms.Button uciekaj;
        private System.Windows.Forms.Button wysluchaj;
        private System.Windows.Forms.Button pytanie;
        private System.Windows.Forms.Button ponownie;
        private System.Windows.Forms.Button poddaj;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.tytul = new System.Windows.Forms.Label();
            this.wstep = new System.Windows.Forms.TextBox();
            this.blokpytanie = new System.Windows.Forms.Label();
            this.que1 = new System.Windows.Forms.Button();
            this.que2 = new System.Windows.Forms.Button();
            this.que3 = new System.Windows.Forms.Button();
            this.que4 = new System.Windows.Forms.Button();
            this.smierc = new System.Windows.Forms.Button();
            this.uciekaj = new System.Windows.Forms.Button();
            this.wysluchaj = new System.Windows.Forms.Button();
            this.pytanie = new System.Windows.Forms.Button();
            this.ponownie = new System.Windows.Forms.Button();
            this.poddaj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tytul
            // 
            this.tytul.AutoSize = true;
            this.tytul.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.tytul.Location = new System.Drawing.Point(20, 10);
            this.tytul.Name = "tytul";
            this.tytul.Size = new System.Drawing.Size(250, 30);
            this.tytul.TabIndex = 0;
            this.tytul.Text = "Przygoda ze Sfinksem";
            // 
            // wstep
            // 
            this.wstep.Location = new System.Drawing.Point(20, 50);
            this.wstep.Multiline = true;
            this.wstep.Name = "wstep";
            this.wstep.ReadOnly = true;
            this.wstep.Size = new System.Drawing.Size(500, 100);
            this.wstep.TabIndex = 1;
            // 
            // blokpytanie
            // 
            this.blokpytanie.AutoSize = true;
            this.blokpytanie.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.blokpytanie.Location = new System.Drawing.Point(20, 170);
            this.blokpytanie.Name = "blokpytanie";
            this.blokpytanie.Size = new System.Drawing.Size(0, 21);
            this.blokpytanie.TabIndex = 2;
            // 
            // que1
            // 
            this.que1.Location = new System.Drawing.Point(20, 210);
            this.que1.Name = "que1";
            this.que1.Size = new System.Drawing.Size(230, 40);
            this.que1.TabIndex = 3;
            this.que1.Text = "que1";
            this.que1.UseVisualStyleBackColor = true;
            // 
            // que2
            // 
            this.que2.Location = new System.Drawing.Point(290, 210);
            this.que2.Name = "que2";
            this.que2.Size = new System.Drawing.Size(230, 40);
            this.que2.TabIndex = 4;
            this.que2.Text = "que2";
            this.que2.UseVisualStyleBackColor = true;
            // 
            // que3
            // 
            this.que3.Location = new System.Drawing.Point(20, 270);
            this.que3.Name = "que3";
            this.que3.Size = new System.Drawing.Size(230, 40);
            this.que3.TabIndex = 5;
            this.que3.Text = "que3";
            this.que3.UseVisualStyleBackColor = true;
            // 
            // que4
            // 
            this.que4.Location = new System.Drawing.Point(290, 270);
            this.que4.Name = "que4";
            this.que4.Size = new System.Drawing.Size(230, 40);
            this.que4.TabIndex = 6;
            this.que4.Text = "que4";
            this.que4.UseVisualStyleBackColor = true;
            // 
            // smierc
            // 
            this.smierc.Location = new System.Drawing.Point(20, 330);
            this.smierc.Name = "smierc";
            this.smierc.Size = new System.Drawing.Size(100, 35);
            this.smierc.TabIndex = 7;
            this.smierc.Text = "Śmierć";
            this.smierc.UseVisualStyleBackColor = true;
            // 
            // uciekaj
            // 
            this.uciekaj.Location = new System.Drawing.Point(130, 330);
            this.uciekaj.Name = "uciekaj";
            this.uciekaj.Size = new System.Drawing.Size(100, 35);
            this.uciekaj.TabIndex = 8;
            this.uciekaj.Text = "Uciekaj";
            this.uciekaj.UseVisualStyleBackColor = true;
            // 
            // wysluchaj
            // 
            this.wysluchaj.Location = new System.Drawing.Point(240, 330);
            this.wysluchaj.Name = "wysluchaj";
            this.wysluchaj.Size = new System.Drawing.Size(100, 35);
            this.wysluchaj.TabIndex = 9;
            this.wysluchaj.Text = "Wysłuchaj";
            this.wysluchaj.UseVisualStyleBackColor = true;
            // 
            // pytanie
            // 
            this.pytanie.Location = new System.Drawing.Point(350, 330);
            this.pytanie.Name = "pytanie";
            this.pytanie.Size = new System.Drawing.Size(100, 35);
            this.pytanie.TabIndex = 10;
            this.pytanie.Text = "Pytanie";
            this.pytanie.UseVisualStyleBackColor = true;
            // 
            // ponownie
            // 
            this.ponownie.Location = new System.Drawing.Point(460, 330);
            this.ponownie.Name = "ponownie";
            this.ponownie.Size = new System.Drawing.Size(100, 35);
            this.ponownie.TabIndex = 11;
            this.ponownie.Text = "Ponownie";
            this.ponownie.UseVisualStyleBackColor = true;
            // 
            // poddaj
            // 
            this.poddaj.Location = new System.Drawing.Point(570, 330);
            this.poddaj.Name = "poddaj";
            this.poddaj.Size = new System.Drawing.Size(100, 35);
            this.poddaj.TabIndex = 12;
            this.poddaj.Text = "Poddaj się";
            this.poddaj.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(700, 400);
            this.Controls.Add(this.tytul);
            this.Controls.Add(this.wstep);
            this.Controls.Add(this.blokpytanie);
            this.Controls.Add(this.que1);
            this.Controls.Add(this.que2);
            this.Controls.Add(this.que3);
            this.Controls.Add(this.que4);
            this.Controls.Add(this.smierc);
            this.Controls.Add(this.uciekaj);
            this.Controls.Add(this.wysluchaj);
            this.Controls.Add(this.pytanie);
            this.Controls.Add(this.ponownie);
            this.Controls.Add(this.poddaj);
            this.Name = "Form1";
            this.Text = "Przygoda ze Sfinksem";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
