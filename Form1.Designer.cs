namespace PigLatinGenerator
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
            this.tbEnglish = new System.Windows.Forms.TextBox();
            this.tbPigLatin = new System.Windows.Forms.TextBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbEnglish
            // 
            this.tbEnglish.Location = new System.Drawing.Point(12, 12);
            this.tbEnglish.Multiline = true;
            this.tbEnglish.Name = "tbEnglish";
            this.tbEnglish.Size = new System.Drawing.Size(358, 67);
            this.tbEnglish.TabIndex = 0;
            // 
            // tbPigLatin
            // 
            this.tbPigLatin.Location = new System.Drawing.Point(12, 114);
            this.tbPigLatin.Multiline = true;
            this.tbPigLatin.Name = "tbPigLatin";
            this.tbPigLatin.ReadOnly = true;
            this.tbPigLatin.Size = new System.Drawing.Size(358, 67);
            this.tbPigLatin.TabIndex = 1;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(154, 85);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(75, 23);
            this.btnGenerate.TabIndex = 2;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 197);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.tbPigLatin);
            this.Controls.Add(this.tbEnglish);
            this.Name = "Form1";
            this.Text = "Pig Latin Generator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbEnglish;
        private System.Windows.Forms.TextBox tbPigLatin;
        private System.Windows.Forms.Button btnGenerate;
    }
}

