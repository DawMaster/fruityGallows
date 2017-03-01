namespace fruityGallows
{
    partial class Form3
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
            this.questionPB = new System.Windows.Forms.PictureBox();
            this.flw3 = new System.Windows.Forms.FlowLayoutPanel();
            this.nextPB = new System.Windows.Forms.PictureBox();
            this.backPB = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.questionPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nextPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backPB)).BeginInit();
            this.SuspendLayout();
            // 
            // questionPB
            // 
            this.questionPB.BackColor = System.Drawing.Color.White;
            this.questionPB.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.questionPB.Location = new System.Drawing.Point(240, 12);
            this.questionPB.Name = "questionPB";
            this.questionPB.Size = new System.Drawing.Size(520, 500);
            this.questionPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.questionPB.TabIndex = 0;
            this.questionPB.TabStop = false;
            // 
            // flw3
            // 
            this.flw3.BackColor = System.Drawing.Color.Transparent;
            this.flw3.Location = new System.Drawing.Point(240, 565);
            this.flw3.Name = "flw3";
            this.flw3.Size = new System.Drawing.Size(520, 138);
            this.flw3.TabIndex = 1;
            // 
            // nextPB
            // 
            this.nextPB.BackColor = System.Drawing.Color.Transparent;
            this.nextPB.Image = global::fruityGallows.Properties.Resources.next;
            this.nextPB.Location = new System.Drawing.Point(766, 206);
            this.nextPB.Name = "nextPB";
            this.nextPB.Size = new System.Drawing.Size(206, 130);
            this.nextPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.nextPB.TabIndex = 2;
            this.nextPB.TabStop = false;
            this.nextPB.Click += new System.EventHandler(this.nextPB_Click);
            // 
            // backPB
            // 
            this.backPB.BackColor = System.Drawing.Color.Transparent;
            this.backPB.Image = global::fruityGallows.Properties.Resources.backButton;
            this.backPB.Location = new System.Drawing.Point(12, 206);
            this.backPB.Name = "backPB";
            this.backPB.Size = new System.Drawing.Size(206, 130);
            this.backPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.backPB.TabIndex = 3;
            this.backPB.TabStop = false;
            this.backPB.Visible = false;
            this.backPB.Click += new System.EventHandler(this.backPB_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::fruityGallows.Properties.Resources.bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(984, 761);
            this.Controls.Add(this.backPB);
            this.Controls.Add(this.nextPB);
            this.Controls.Add(this.flw3);
            this.Controls.Add(this.questionPB);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lesson";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.questionPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nextPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backPB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox questionPB;
        private System.Windows.Forms.FlowLayoutPanel flw3;
        private System.Windows.Forms.PictureBox nextPB;
        private System.Windows.Forms.PictureBox backPB;
    }
}