namespace ortalama_Hesaplama_2
{
    partial class Form1
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
            this.txtOrtalama = new System.Windows.Forms.TextBox();
            this.txtDevamsizlik = new System.Windows.Forms.TextBox();
            this.btnKontrol = new System.Windows.Forms.Button();
            this.lblOrtalama = new System.Windows.Forms.Label();
            this.lblDevamsızlık = new System.Windows.Forms.Label();
            this.lblSonuc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtOrtalama
            // 
            this.txtOrtalama.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtOrtalama.Location = new System.Drawing.Point(159, 29);
            this.txtOrtalama.Name = "txtOrtalama";
            this.txtOrtalama.Size = new System.Drawing.Size(100, 24);
            this.txtOrtalama.TabIndex = 0;
            // 
            // txtDevamsizlik
            // 
            this.txtDevamsizlik.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtDevamsizlik.Location = new System.Drawing.Point(159, 59);
            this.txtDevamsizlik.Name = "txtDevamsizlik";
            this.txtDevamsizlik.Size = new System.Drawing.Size(100, 24);
            this.txtDevamsizlik.TabIndex = 1;
            // 
            // btnKontrol
            // 
            this.btnKontrol.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKontrol.Location = new System.Drawing.Point(159, 104);
            this.btnKontrol.Name = "btnKontrol";
            this.btnKontrol.Size = new System.Drawing.Size(100, 50);
            this.btnKontrol.TabIndex = 2;
            this.btnKontrol.Text = "Kontrol Et";
            this.btnKontrol.UseVisualStyleBackColor = true;
            this.btnKontrol.Click += new System.EventHandler(this.btnKontrol_Click);
            // 
            // lblOrtalama
            // 
            this.lblOrtalama.AutoSize = true;
            this.lblOrtalama.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOrtalama.Location = new System.Drawing.Point(71, 35);
            this.lblOrtalama.Name = "lblOrtalama";
            this.lblOrtalama.Size = new System.Drawing.Size(82, 18);
            this.lblOrtalama.TabIndex = 3;
            this.lblOrtalama.Text = "Ortalama:";
            // 
            // lblDevamsızlık
            // 
            this.lblDevamsızlık.AutoSize = true;
            this.lblDevamsızlık.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDevamsızlık.Location = new System.Drawing.Point(49, 65);
            this.lblDevamsızlık.Name = "lblDevamsızlık";
            this.lblDevamsızlık.Size = new System.Drawing.Size(104, 18);
            this.lblDevamsızlık.TabIndex = 4;
            this.lblDevamsızlık.Text = "Devamsızlık:";
            // 
            // lblSonuc
            // 
            this.lblSonuc.AutoSize = true;
            this.lblSonuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSonuc.Location = new System.Drawing.Point(92, 173);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(61, 18);
            this.lblSonuc.TabIndex = 5;
            this.lblSonuc.Text = "Sonuç:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 218);
            this.Controls.Add(this.lblSonuc);
            this.Controls.Add(this.lblDevamsızlık);
            this.Controls.Add(this.lblOrtalama);
            this.Controls.Add(this.btnKontrol);
            this.Controls.Add(this.txtDevamsizlik);
            this.Controls.Add(this.txtOrtalama);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtOrtalama;
        private System.Windows.Forms.TextBox txtDevamsizlik;
        private System.Windows.Forms.Button btnKontrol;
        private System.Windows.Forms.Label lblOrtalama;
        private System.Windows.Forms.Label lblDevamsızlık;
        private System.Windows.Forms.Label lblSonuc;
    }
}

