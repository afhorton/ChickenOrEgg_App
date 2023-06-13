namespace ChickenOrEgg
{
    partial class frmMain
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoNeither = new System.Windows.Forms.RadioButton();
            this.rdoEgg = new System.Windows.Forms.RadioButton();
            this.rdoChicken = new System.Windows.Forms.RadioButton();
            this.picAnswer = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAnswer)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoNeither);
            this.groupBox1.Controls.Add(this.rdoEgg);
            this.groupBox1.Controls.Add(this.rdoChicken);
            this.groupBox1.Location = new System.Drawing.Point(75, 107);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 133);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Which came first?";
            // 
            // rdoNeither
            // 
            this.rdoNeither.AutoSize = true;
            this.rdoNeither.Location = new System.Drawing.Point(24, 97);
            this.rdoNeither.Name = "rdoNeither";
            this.rdoNeither.Size = new System.Drawing.Size(59, 17);
            this.rdoNeither.TabIndex = 2;
            this.rdoNeither.TabStop = true;
            this.rdoNeither.Text = "Neither";
            this.rdoNeither.UseVisualStyleBackColor = true;
            this.rdoNeither.CheckedChanged += new System.EventHandler(this.rdoNeither_CheckedChanged);
            // 
            // rdoEgg
            // 
            this.rdoEgg.AutoSize = true;
            this.rdoEgg.Location = new System.Drawing.Point(24, 64);
            this.rdoEgg.Name = "rdoEgg";
            this.rdoEgg.Size = new System.Drawing.Size(44, 17);
            this.rdoEgg.TabIndex = 1;
            this.rdoEgg.TabStop = true;
            this.rdoEgg.Text = "Egg";
            this.rdoEgg.UseVisualStyleBackColor = true;
            this.rdoEgg.CheckedChanged += new System.EventHandler(this.rdoEgg_CheckedChanged);
            // 
            // rdoChicken
            // 
            this.rdoChicken.AutoSize = true;
            this.rdoChicken.Location = new System.Drawing.Point(24, 31);
            this.rdoChicken.Name = "rdoChicken";
            this.rdoChicken.Size = new System.Drawing.Size(64, 17);
            this.rdoChicken.TabIndex = 0;
            this.rdoChicken.TabStop = true;
            this.rdoChicken.Text = "Chicken";
            this.rdoChicken.UseVisualStyleBackColor = true;
            this.rdoChicken.CheckedChanged += new System.EventHandler(this.rdoChicken_CheckedChanged);
            // 
            // picAnswer
            // 
            this.picAnswer.Location = new System.Drawing.Point(330, 48);
            this.picAnswer.Name = "picAnswer";
            this.picAnswer.Size = new System.Drawing.Size(213, 253);
            this.picAnswer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAnswer.TabIndex = 1;
            this.picAnswer.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightYellow;
            this.ClientSize = new System.Drawing.Size(600, 360);
            this.Controls.Add(this.picAnswer);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmMain";
            this.Text = "Important Question";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAnswer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoEgg;
        private System.Windows.Forms.RadioButton rdoChicken;
        private System.Windows.Forms.PictureBox picAnswer;
        private System.Windows.Forms.RadioButton rdoNeither;
    } // end of class
} // end of namespace

