namespace MorseCode
{
    partial class ConvertToText
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
            this.Input = new System.Windows.Forms.TextBox();
            this.Output = new System.Windows.Forms.TextBox();
            this.ConvertText = new System.Windows.Forms.Button();
            this.Reset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Input
            // 
            this.Input.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold);
            this.Input.Location = new System.Drawing.Point(13, 13);
            this.Input.Multiline = true;
            this.Input.Name = "Input";
            this.Input.Size = new System.Drawing.Size(775, 137);
            this.Input.TabIndex = 0;
            this.Input.TextChanged += new System.EventHandler(this.Input_TextChanged);
            // 
            // Output
            // 
            this.Output.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Output.Location = new System.Drawing.Point(12, 301);
            this.Output.Multiline = true;
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(775, 137);
            this.Output.TabIndex = 1;
            this.Output.TextChanged += new System.EventHandler(this.Output_TextChanged);
            // 
            // ConvertText
            // 
            this.ConvertText.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConvertText.Location = new System.Drawing.Point(12, 158);
            this.ConvertText.Name = "ConvertText";
            this.ConvertText.Size = new System.Drawing.Size(775, 137);
            this.ConvertText.TabIndex = 2;
            this.ConvertText.Text = "Convert";
            this.ConvertText.UseVisualStyleBackColor = true;
            this.ConvertText.Click += new System.EventHandler(this.ConvertText_Click);
            // 
            // Reset
            // 
            this.Reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reset.Location = new System.Drawing.Point(795, 13);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(197, 425);
            this.Reset.TabIndex = 3;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // ConvertToText
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 451);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.ConvertText);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.Input);
            this.MaximizeBox = false;
            this.Name = "ConvertToText";
            this.Text = "ConvertToText";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ConvertToText_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Input;
        private System.Windows.Forms.TextBox Output;
        private System.Windows.Forms.Button ConvertText;
        private System.Windows.Forms.Button Reset;
    }
}