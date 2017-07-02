namespace Uno
{
    partial class Test
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
            this.Hand = new System.Windows.Forms.GroupBox();
            this.Deck2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Hand
            // 
            this.Hand.Location = new System.Drawing.Point(26, 267);
            this.Hand.Name = "Hand";
            this.Hand.Size = new System.Drawing.Size(747, 62);
            this.Hand.TabIndex = 0;
            this.Hand.TabStop = false;
            this.Hand.Text = "groupBox1";
            // 
            // Deck2
            // 
            this.Deck2.Enabled = false;
            this.Deck2.Location = new System.Drawing.Point(371, 109);
            this.Deck2.Name = "Deck2";
            this.Deck2.Size = new System.Drawing.Size(56, 71);
            this.Deck2.TabIndex = 1;
            this.Deck2.UseVisualStyleBackColor = true;
            // 
            // Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 341);
            this.Controls.Add(this.Deck2);
            this.Controls.Add(this.Hand);
            this.Name = "Test";
            this.Text = "Test";
            this.Load += new System.EventHandler(this.Test_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Hand;
        private System.Windows.Forms.Button Deck2;
    }
}