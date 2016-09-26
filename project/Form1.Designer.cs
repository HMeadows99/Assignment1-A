namespace project
{
    partial class FrmGreetings
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
            this.btnIlluminati = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnIlluminati
            // 
            this.btnIlluminati.Location = new System.Drawing.Point(91, 42);
            this.btnIlluminati.Name = "btnIlluminati";
            this.btnIlluminati.Size = new System.Drawing.Size(75, 23);
            this.btnIlluminati.TabIndex = 0;
            this.btnIlluminati.Text = "?";
            this.btnIlluminati.UseVisualStyleBackColor = true;
            this.btnIlluminati.Click += new System.EventHandler(this.btnIlluminati_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Location = new System.Drawing.Point(91, 93);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(0, 13);
            this.lblWelcome.TabIndex = 1;
            this.lblWelcome.Click += new System.EventHandler(this.lblWelcome_Click);
            // 
            // FrmGreetings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.btnIlluminati);
            this.Name = "FrmGreetings";
            this.Text = "Greetings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIlluminati;
        private System.Windows.Forms.Label lblWelcome;
    }
}

