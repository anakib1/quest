namespace quest_firstA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.firstA = new System.Windows.Forms.Button();
            this.secondA = new System.Windows.Forms.Button();
            this.foursA = new System.Windows.Forms.Button();
            this.thirdA = new System.Windows.Forms.Button();
            this.description = new System.Windows.Forms.Label();
            this.mmc_count = new System.Windows.Forms.Label();
            this.debug_l = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(254, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUEST BY SLAVKA";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // firstA
            // 
            this.firstA.BackColor = System.Drawing.Color.Lime;
            this.firstA.Location = new System.Drawing.Point(78, 230);
            this.firstA.Name = "firstA";
            this.firstA.Size = new System.Drawing.Size(200, 73);
            this.firstA.TabIndex = 1;
            this.firstA.Text = "FIRST ANSWER";
            this.firstA.UseVisualStyleBackColor = false;
            this.firstA.Click += new System.EventHandler(this.firstA_Click);
            // 
            // secondA
            // 
            this.secondA.BackColor = System.Drawing.Color.Lime;
            this.secondA.Location = new System.Drawing.Point(443, 230);
            this.secondA.Name = "secondA";
            this.secondA.Size = new System.Drawing.Size(187, 73);
            this.secondA.TabIndex = 2;
            this.secondA.Text = "SECOND ANSWER";
            this.secondA.UseVisualStyleBackColor = false;
            this.secondA.Click += new System.EventHandler(this.secondA_Click);
            // 
            // foursA
            // 
            this.foursA.BackColor = System.Drawing.Color.Lime;
            this.foursA.Location = new System.Drawing.Point(443, 353);
            this.foursA.Name = "foursA";
            this.foursA.Size = new System.Drawing.Size(187, 69);
            this.foursA.TabIndex = 3;
            this.foursA.Text = "FOURS ANSWER";
            this.foursA.UseVisualStyleBackColor = false;
            this.foursA.Click += new System.EventHandler(this.foursA_Click);
            // 
            // thirdA
            // 
            this.thirdA.BackColor = System.Drawing.Color.Lime;
            this.thirdA.Location = new System.Drawing.Point(78, 353);
            this.thirdA.Name = "thirdA";
            this.thirdA.Size = new System.Drawing.Size(200, 69);
            this.thirdA.TabIndex = 4;
            this.thirdA.Text = "THIRD ANSWER";
            this.thirdA.UseVisualStyleBackColor = false;
            this.thirdA.Click += new System.EventHandler(this.thirdA_Click);
            // 
            // description
            // 
            this.description.AutoSize = true;
            this.description.Font = new System.Drawing.Font("Segoe Script", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.description.ForeColor = System.Drawing.Color.Fuchsia;
            this.description.Location = new System.Drawing.Point(78, 125);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(0, 19);
            this.description.TabIndex = 5;
            this.description.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // mmc_count
            // 
            this.mmc_count.AutoSize = true;
            this.mmc_count.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mmc_count.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.mmc_count.Location = new System.Drawing.Point(665, 88);
            this.mmc_count.Name = "mmc_count";
            this.mmc_count.Size = new System.Drawing.Size(90, 24);
            this.mmc_count.TabIndex = 6;
            this.mmc_count.Text = "100 MMC";
            // 
            // debug_l
            // 
            this.debug_l.AutoSize = true;
            this.debug_l.Location = new System.Drawing.Point(666, 158);
            this.debug_l.Name = "debug_l";
            this.debug_l.Size = new System.Drawing.Size(0, 13);
            this.debug_l.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.debug_l);
            this.Controls.Add(this.mmc_count);
            this.Controls.Add(this.description);
            this.Controls.Add(this.thirdA);
            this.Controls.Add(this.foursA);
            this.Controls.Add(this.secondA);
            this.Controls.Add(this.firstA);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Quest";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button firstA;
        private System.Windows.Forms.Button secondA;
        private System.Windows.Forms.Button foursA;
        private System.Windows.Forms.Button thirdA;
        private System.Windows.Forms.Label description;
        private System.Windows.Forms.Label mmc_count;
        private System.Windows.Forms.Label debug_l;
    }
}

