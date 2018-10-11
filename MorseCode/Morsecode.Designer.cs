namespace MorseCode
{
    partial class Morsecode
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
            this.ConvertToMorse = new System.Windows.Forms.Button();
            this.ConvertToText = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ConvertToMorse
            // 
            this.ConvertToMorse.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConvertToMorse.Location = new System.Drawing.Point(12, 12);
            this.ConvertToMorse.Name = "ConvertToMorse";
            this.ConvertToMorse.Size = new System.Drawing.Size(324, 186);
            this.ConvertToMorse.TabIndex = 0;
            this.ConvertToMorse.Text = "Convert to Morse";
            this.ConvertToMorse.UseVisualStyleBackColor = true;
            this.ConvertToMorse.Click += new System.EventHandler(this.ConvertToMorse_Click);
            // 
            // ConvertToText
            // 
            this.ConvertToText.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold);
            this.ConvertToText.Location = new System.Drawing.Point(360, 12);
            this.ConvertToText.Name = "ConvertToText";
            this.ConvertToText.Size = new System.Drawing.Size(324, 186);
            this.ConvertToText.TabIndex = 1;
            this.ConvertToText.Text = "Convert to Text";
            this.ConvertToText.UseVisualStyleBackColor = true;
            this.ConvertToText.Click += new System.EventHandler(this.ConvertToText_Click);
            // 
            // Morsecode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 215);
            this.Controls.Add(this.ConvertToText);
            this.Controls.Add(this.ConvertToMorse);
            this.MaximizeBox = false;
            this.Name = "Morsecode";
            this.Text = "Morsecode";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Morsecode_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ConvertToMorse;
        private System.Windows.Forms.Button ConvertToText;
    }
}

