namespace CPT185HOMEWORK
{
    partial class Chapter2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Chapter2));
            this.Phrase = new System.Windows.Forms.TextBox();
            this.Title = new System.Windows.Forms.Label();
            this.Info = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Phrase
            // 
            this.Phrase.BackColor = System.Drawing.SystemColors.Menu;
            this.Phrase.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Phrase.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Phrase.Location = new System.Drawing.Point(289, 184);
            this.Phrase.Name = "Phrase";
            this.Phrase.Size = new System.Drawing.Size(317, 22);
            this.Phrase.TabIndex = 0;
            this.Phrase.Text = "Full and half-marathon runners are welcome!";
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(326, 135);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(227, 37);
            this.Title.TabIndex = 2;
            this.Title.Text = "Fall Marathon";
            // 
            // Info
            // 
            this.Info.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Info.Location = new System.Drawing.Point(8, 323);
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(251, 27);
            this.Info.TabIndex = 3;
            this.Info.Text = "Click here for marathon details";
            this.Info.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(8, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(251, 305);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Chapter2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 373);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Info);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.Phrase);
            this.Name = "Chapter2";
            this.Text = "Testing";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Phrase;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Button Info;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

