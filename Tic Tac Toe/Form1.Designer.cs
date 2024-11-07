namespace Tic_Tac_Toe
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btnuceuc = new System.Windows.Forms.Button();
            this.btnbesebes = new System.Windows.Forms.Button();
            this.btnyediyeyedi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(126, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tic TacToe";
            // 
            // btnuceuc
            // 
            this.btnuceuc.BackColor = System.Drawing.Color.DarkRed;
            this.btnuceuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnuceuc.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnuceuc.Location = new System.Drawing.Point(163, 91);
            this.btnuceuc.Name = "btnuceuc";
            this.btnuceuc.Size = new System.Drawing.Size(107, 92);
            this.btnuceuc.TabIndex = 1;
            this.btnuceuc.Text = "3X3";
            this.btnuceuc.UseVisualStyleBackColor = false;
            this.btnuceuc.Click += new System.EventHandler(this.btnuceuc_Click);
            // 
            // btnbesebes
            // 
            this.btnbesebes.BackColor = System.Drawing.Color.DarkRed;
            this.btnbesebes.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnbesebes.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnbesebes.Location = new System.Drawing.Point(163, 229);
            this.btnbesebes.Name = "btnbesebes";
            this.btnbesebes.Size = new System.Drawing.Size(107, 92);
            this.btnbesebes.TabIndex = 2;
            this.btnbesebes.Text = "5X5";
            this.btnbesebes.UseVisualStyleBackColor = false;
            this.btnbesebes.Click += new System.EventHandler(this.btnbesebes_Click);
            // 
            // btnyediyeyedi
            // 
            this.btnyediyeyedi.BackColor = System.Drawing.Color.DarkRed;
            this.btnyediyeyedi.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnyediyeyedi.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnyediyeyedi.Location = new System.Drawing.Point(163, 361);
            this.btnyediyeyedi.Name = "btnyediyeyedi";
            this.btnyediyeyedi.Size = new System.Drawing.Size(107, 92);
            this.btnyediyeyedi.TabIndex = 3;
            this.btnyediyeyedi.Text = "7X7";
            this.btnyediyeyedi.UseVisualStyleBackColor = false;
            this.btnyediyeyedi.Click += new System.EventHandler(this.btnyediyeyedi_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(436, 514);
            this.Controls.Add(this.btnyediyeyedi);
            this.Controls.Add(this.btnbesebes);
            this.Controls.Add(this.btnuceuc);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tic Tac Toe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnuceuc;
        private System.Windows.Forms.Button btnbesebes;
        private System.Windows.Forms.Button btnyediyeyedi;
    }
}

