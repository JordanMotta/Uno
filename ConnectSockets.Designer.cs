namespace Uno
{
    partial class ConnectSockets
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
            this.ListenerPortButton = new System.Windows.Forms.Button();
            this.SenderPortButton = new System.Windows.Forms.Button();
            this.ListenerPortText = new System.Windows.Forms.TextBox();
            this.SenderPortText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ListenerPortButton
            // 
            this.ListenerPortButton.Location = new System.Drawing.Point(332, 49);
            this.ListenerPortButton.Name = "ListenerPortButton";
            this.ListenerPortButton.Size = new System.Drawing.Size(75, 23);
            this.ListenerPortButton.TabIndex = 0;
            this.ListenerPortButton.Text = "Primero";
            this.ListenerPortButton.UseVisualStyleBackColor = true;
            this.ListenerPortButton.Click += new System.EventHandler(this.ListenerPortButton_Click);
            // 
            // SenderPortButton
            // 
            this.SenderPortButton.Location = new System.Drawing.Point(332, 121);
            this.SenderPortButton.Name = "SenderPortButton";
            this.SenderPortButton.Size = new System.Drawing.Size(75, 23);
            this.SenderPortButton.TabIndex = 1;
            this.SenderPortButton.Text = "Segundo";
            this.SenderPortButton.UseVisualStyleBackColor = true;
            this.SenderPortButton.Click += new System.EventHandler(this.SenderPortButton_Click);
            // 
            // ListenerPortText
            // 
            this.ListenerPortText.Location = new System.Drawing.Point(70, 52);
            this.ListenerPortText.Name = "ListenerPortText";
            this.ListenerPortText.Size = new System.Drawing.Size(213, 20);
            this.ListenerPortText.TabIndex = 2;
            // 
            // SenderPortText
            // 
            this.SenderPortText.Location = new System.Drawing.Point(70, 121);
            this.SenderPortText.Name = "SenderPortText";
            this.SenderPortText.Size = new System.Drawing.Size(213, 20);
            this.SenderPortText.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Listener port";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Sender port";
            // 
            // ConnectSockets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 261);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SenderPortText);
            this.Controls.Add(this.ListenerPortText);
            this.Controls.Add(this.SenderPortButton);
            this.Controls.Add(this.ListenerPortButton);
            this.Name = "ConnectSockets";
            this.Text = "ConnectSockets";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ListenerPortButton;
        private System.Windows.Forms.Button SenderPortButton;
        private System.Windows.Forms.TextBox ListenerPortText;
        private System.Windows.Forms.TextBox SenderPortText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}