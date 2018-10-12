namespace MorseCode
{
    partial class ConvertToMorse
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
            this.ConvertText = new System.Windows.Forms.Button();
            this.Output = new System.Windows.Forms.TextBox();
            this.Input = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ConvertText
            // 
            this.ConvertText.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConvertText.Location = new System.Drawing.Point(12, 158);
            this.ConvertText.Name = "ConvertText";
            this.ConvertText.Size = new System.Drawing.Size(775, 137);
            this.ConvertText.TabIndex = 5;
            this.ConvertText.Text = "Convert";
            this.ConvertText.UseVisualStyleBackColor = true;
            this.ConvertText.Click += new System.EventHandler(this.ConvertText_Click);
            // 
            // Output
            // 
            this.Output.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Output.Location = new System.Drawing.Point(12, 301);
            this.Output.Multiline = true;
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(775, 137);
            this.Output.TabIndex = 4;
            this.Output.TextChanged += new System.EventHandler(this.Output_TextChanged);
            // 
            // Input
            // 
            this.Input.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Input.Location = new System.Drawing.Point(13, 13);
            this.Input.Multiline = true;
            this.Input.Name = "Input";
            this.Input.Size = new System.Drawing.Size(775, 137);
            this.Input.TabIndex = 3;
            this.Input.TextChanged += new System.EventHandler(this.Input_TextChanged);
            // 
            // ConvertToMorse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ConvertText);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.Input);
            this.MaximizeBox = false;
            this.Name = "ConvertToMorse";
            this.Text = "ConvertToMorse";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ConvertToMorse_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ConvertText;
        private System.Windows.Forms.TextBox Output;
        private System.Windows.Forms.TextBox Input;
    }
}