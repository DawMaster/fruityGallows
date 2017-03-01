namespace fruityGallows
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
            this.questionPB = new System.Windows.Forms.PictureBox();
            this.flw = new System.Windows.Forms.FlowLayoutPanel();
            this.flw2 = new System.Windows.Forms.FlowLayoutPanel();
            this.gallowPB = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.correctPB = new System.Windows.Forms.PictureBox();
            this.nextPB = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.questionPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gallowPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.correctPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nextPB)).BeginInit();
            this.SuspendLayout();
            // 
            // questionPB
            // 
            this.questionPB.BackColor = System.Drawing.Color.White;
            this.questionPB.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.questionPB.Location = new System.Drawing.Point(331, 12);
            this.questionPB.Name = "questionPB";
            this.questionPB.Size = new System.Drawing.Size(310, 267);
            this.questionPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.questionPB.TabIndex = 0;
            this.questionPB.TabStop = false;
            this.questionPB.MouseDown += new System.Windows.Forms.MouseEventHandler(this.questionPB_MouseDown);
            // 
            // flw
            // 
            this.flw.BackColor = System.Drawing.Color.Transparent;
            this.flw.CausesValidation = false;
            this.flw.Location = new System.Drawing.Point(179, 600);
            this.flw.Name = "flw";
            this.flw.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.flw.Size = new System.Drawing.Size(600, 200);
            this.flw.TabIndex = 1;
            // 
            // flw2
            // 
            this.flw2.BackColor = System.Drawing.Color.Transparent;
            this.flw2.CausesValidation = false;
            this.flw2.Location = new System.Drawing.Point(300, 357);
            this.flw2.Margin = new System.Windows.Forms.Padding(0);
            this.flw2.Name = "flw2";
            this.flw2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.flw2.Size = new System.Drawing.Size(400, 100);
            this.flw2.TabIndex = 2;
            // 
            // gallowPB
            // 
            this.gallowPB.BackColor = System.Drawing.Color.Transparent;
            this.gallowPB.Location = new System.Drawing.Point(647, 12);
            this.gallowPB.Name = "gallowPB";
            this.gallowPB.Size = new System.Drawing.Size(315, 267);
            this.gallowPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gallowPB.TabIndex = 3;
            this.gallowPB.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::fruityGallows.Properties.Resources.fruity;
            this.pictureBox1.Location = new System.Drawing.Point(-18, 347);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(209, 247);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(221, 156);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox2_MouseDown);
            // 
            // correctPB
            // 
            this.correctPB.BackColor = System.Drawing.Color.Transparent;
            this.correctPB.Image = global::fruityGallows.Properties.Resources.correct;
            this.correctPB.Location = new System.Drawing.Point(429, 463);
            this.correctPB.Name = "correctPB";
            this.correctPB.Size = new System.Drawing.Size(143, 110);
            this.correctPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.correctPB.TabIndex = 6;
            this.correctPB.TabStop = false;
            this.correctPB.Visible = false;
            // 
            // nextPB
            // 
            this.nextPB.BackColor = System.Drawing.Color.Transparent;
            this.nextPB.Image = global::fruityGallows.Properties.Resources.next;
            this.nextPB.Location = new System.Drawing.Point(819, 463);
            this.nextPB.Name = "nextPB";
            this.nextPB.Size = new System.Drawing.Size(143, 110);
            this.nextPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.nextPB.TabIndex = 7;
            this.nextPB.TabStop = false;
            this.nextPB.Visible = false;
            this.nextPB.Click += new System.EventHandler(this.next_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::fruityGallows.Properties.Resources.bg;
            this.ClientSize = new System.Drawing.Size(984, 761);
            this.ControlBox = false;
            this.Controls.Add(this.nextPB);
            this.Controls.Add(this.correctPB);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.gallowPB);
            this.Controls.Add(this.flw2);
            this.Controls.Add(this.flw);
            this.Controls.Add(this.questionPB);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fruity Gallows";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.questionPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gallowPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.correctPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nextPB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox questionPB;
        private System.Windows.Forms.FlowLayoutPanel flw;
        private System.Windows.Forms.FlowLayoutPanel flw2;
        private System.Windows.Forms.PictureBox gallowPB;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox correctPB;
        private System.Windows.Forms.PictureBox nextPB;
    }
}