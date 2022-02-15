namespace Converter
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
            this.convButton = new System.Windows.Forms.Button();
            this.usdBox = new System.Windows.Forms.TextBox();
            this.rate = new System.Windows.Forms.TextBox();
            this.jpyBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // convButton
            // 
            this.convButton.Location = new System.Drawing.Point(211, 203);
            this.convButton.Name = "convButton";
            this.convButton.Size = new System.Drawing.Size(93, 29);
            this.convButton.TabIndex = 0;
            this.convButton.Text = "Convert";
            this.convButton.UseVisualStyleBackColor = true;
            this.convButton.Click += new System.EventHandler(this.convButtonClicked);
            // 
            // usdBox
            // 
            this.usdBox.Location = new System.Drawing.Point(194, 58);
            this.usdBox.Name = "usdBox";
            this.usdBox.Size = new System.Drawing.Size(110, 19);
            this.usdBox.TabIndex = 1;
            // 
            // rate
            // 
            this.rate.Location = new System.Drawing.Point(194, 120);
            this.rate.Name = "rate";
            this.rate.Size = new System.Drawing.Size(110, 19);
            this.rate.TabIndex = 2;
            // 
            // jpyBox
            // 
            this.jpyBox.Location = new System.Drawing.Point(194, 150);
            this.jpyBox.Name = "jpyBox";
            this.jpyBox.Size = new System.Drawing.Size(110, 19);
            this.jpyBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(42, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Price in USD";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(42, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Current Rate";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(42, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Price in JPY";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 265);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.jpyBox);
            this.Controls.Add(this.rate);
            this.Controls.Add(this.usdBox);
            this.Controls.Add(this.convButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button convButton;
        private System.Windows.Forms.TextBox usdBox;
        private System.Windows.Forms.TextBox rate;
        private System.Windows.Forms.TextBox jpyBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

