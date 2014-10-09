namespace irairabou
{
    partial class StartForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.exitButton = new System.Windows.Forms.Button();
            this.stage2Button = new System.Windows.Forms.Button();
            this.stage1Button = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.exitButton);
            this.panel1.Controls.Add(this.stage2Button);
            this.panel1.Controls.Add(this.stage1Button);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(260, 225);
            this.panel1.TabIndex = 0;
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Calibri", 40F);
            this.exitButton.Location = new System.Drawing.Point(0, 153);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(260, 70);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // stage2Button
            // 
            this.stage2Button.Font = new System.Drawing.Font("Calibri", 40F);
            this.stage2Button.Location = new System.Drawing.Point(0, 77);
            this.stage2Button.Name = "stage2Button";
            this.stage2Button.Size = new System.Drawing.Size(260, 70);
            this.stage2Button.TabIndex = 1;
            this.stage2Button.Text = "STAGE2";
            this.stage2Button.UseVisualStyleBackColor = true;
            this.stage2Button.Click += new System.EventHandler(this.stage2Button_Click);
            // 
            // stage1Button
            // 
            this.stage1Button.Font = new System.Drawing.Font("Calibri", 40F);
            this.stage1Button.Location = new System.Drawing.Point(0, 1);
            this.stage1Button.Name = "stage1Button";
            this.stage1Button.Size = new System.Drawing.Size(260, 70);
            this.stage1Button.TabIndex = 0;
            this.stage1Button.Text = "STAGE1";
            this.stage1Button.UseVisualStyleBackColor = true;
            this.stage1Button.Click += new System.EventHandler(this.stage1Button_Click);
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 247);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "StartForm";
            this.Text = "スタート画面";
            this.Load += new System.EventHandler(this.StartForm_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button stage2Button;
        private System.Windows.Forms.Button stage1Button;
    }
}