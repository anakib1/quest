namespace quest_firstA
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.hit_b = new System.Windows.Forms.Button();
            this.description2 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // hit_b
            // 
            this.hit_b.BackColor = System.Drawing.Color.Yellow;
            this.hit_b.ForeColor = System.Drawing.Color.Red;
            this.hit_b.Location = new System.Drawing.Point(319, 280);
            this.hit_b.Name = "hit_b";
            this.hit_b.Size = new System.Drawing.Size(167, 70);
            this.hit_b.TabIndex = 0;
            this.hit_b.Text = "HIT!";
            this.hit_b.UseVisualStyleBackColor = false;
            this.hit_b.Click += new System.EventHandler(this.hit_b_Click);
            // 
            // description2
            // 
            this.description2.AutoSize = true;
            this.description2.Font = new System.Drawing.Font("Unispace", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.description2.Location = new System.Drawing.Point(137, 95);
            this.description2.Name = "description2";
            this.description2.Size = new System.Drawing.Size(0, 19);
            this.description2.TabIndex = 1;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(199, 197);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(396, 30);
            this.progressBar1.TabIndex = 2;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.description2);
            this.Controls.Add(this.hit_b);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "BATTLE";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button hit_b;
        private System.Windows.Forms.Label description2;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}