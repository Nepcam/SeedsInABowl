namespace Seeds_in_a_bowl
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
            this.pictureBoxBowl = new System.Windows.Forms.PictureBox();
            this.buttonDraw = new System.Windows.Forms.Button();
            this.textBoxNumSeeds = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBowl)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxBowl
            // 
            this.pictureBoxBowl.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxBowl.Name = "pictureBoxBowl";
            this.pictureBoxBowl.Size = new System.Drawing.Size(557, 426);
            this.pictureBoxBowl.TabIndex = 0;
            this.pictureBoxBowl.TabStop = false;
            // 
            // buttonDraw
            // 
            this.buttonDraw.Location = new System.Drawing.Point(586, 152);
            this.buttonDraw.Name = "buttonDraw";
            this.buttonDraw.Size = new System.Drawing.Size(202, 50);
            this.buttonDraw.TabIndex = 1;
            this.buttonDraw.Text = "Draw";
            this.buttonDraw.UseVisualStyleBackColor = true;
            // 
            // textBoxNumSeeds
            // 
            this.textBoxNumSeeds.Location = new System.Drawing.Point(586, 106);
            this.textBoxNumSeeds.Name = "textBoxNumSeeds";
            this.textBoxNumSeeds.Size = new System.Drawing.Size(202, 20);
            this.textBoxNumSeeds.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(583, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Please input number of seeds to be drawn";
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(586, 223);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(202, 50);
            this.buttonClear.TabIndex = 4;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(586, 295);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(202, 50);
            this.buttonExit.TabIndex = 5;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxNumSeeds);
            this.Controls.Add(this.buttonDraw);
            this.Controls.Add(this.pictureBoxBowl);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBowl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxBowl;
        private System.Windows.Forms.Button buttonDraw;
        private System.Windows.Forms.TextBox textBoxNumSeeds;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonExit;
    }
}

