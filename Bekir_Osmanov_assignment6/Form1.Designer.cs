namespace Bekir_Osmanov_assignment6
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.computer_choice = new System.Windows.Forms.PictureBox();
            this.user_choice = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rock_choice = new System.Windows.Forms.PictureBox();
            this.scissors_choice = new System.Windows.Forms.PictureBox();
            this.paper_choice = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.computer_choice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.user_choice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rock_choice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scissors_choice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paper_choice)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(179, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(410, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "ROCK, PAPER, SCISSORS\r\n";
            // 
            // computer_choice
            // 
            this.computer_choice.Image = global::Bekir_Osmanov_assignment6.Properties.Resources.Question_mark__black__svg;
            this.computer_choice.Location = new System.Drawing.Point(425, 125);
            this.computer_choice.Name = "computer_choice";
            this.computer_choice.Size = new System.Drawing.Size(243, 189);
            this.computer_choice.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.computer_choice.TabIndex = 1;
            this.computer_choice.TabStop = false;
            // 
            // user_choice
            // 
            this.user_choice.Image = global::Bekir_Osmanov_assignment6.Properties.Resources.Question_mark__black__svg;
            this.user_choice.Location = new System.Drawing.Point(93, 125);
            this.user_choice.Name = "user_choice";
            this.user_choice.Size = new System.Drawing.Size(243, 189);
            this.user_choice.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.user_choice.TabIndex = 2;
            this.user_choice.TabStop = false;
            this.user_choice.Click += new System.EventHandler(this.user_choice_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(352, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 47);
            this.label2.TabIndex = 3;
            this.label2.Text = "VS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(179, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 37);
            this.label3.TabIndex = 4;
            this.label3.Text = "ME";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(455, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(182, 37);
            this.label4.TabIndex = 5;
            this.label4.Text = "CYBER-ENEMY";
            // 
            // rock_choice
            // 
            this.rock_choice.Image = global::Bekir_Osmanov_assignment6.Properties.Resources.stone_PNG13588;
            this.rock_choice.Location = new System.Drawing.Point(16, 107);
            this.rock_choice.Name = "rock_choice";
            this.rock_choice.Size = new System.Drawing.Size(62, 60);
            this.rock_choice.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.rock_choice.TabIndex = 6;
            this.rock_choice.TabStop = false;
            this.rock_choice.Click += new System.EventHandler(this.rock_choice_Click);
            // 
            // scissors_choice
            // 
            this.scissors_choice.Image = global::Bekir_Osmanov_assignment6.Properties.Resources.Scissor_PNG_Clipart;
            this.scissors_choice.Location = new System.Drawing.Point(16, 264);
            this.scissors_choice.Name = "scissors_choice";
            this.scissors_choice.Size = new System.Drawing.Size(62, 60);
            this.scissors_choice.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.scissors_choice.TabIndex = 7;
            this.scissors_choice.TabStop = false;
            this.scissors_choice.Click += new System.EventHandler(this.scissors_choice_Click);
            // 
            // paper_choice
            // 
            this.paper_choice.Image = global::Bekir_Osmanov_assignment6.Properties.Resources.Paper_Sheet;
            this.paper_choice.Location = new System.Drawing.Point(16, 183);
            this.paper_choice.Name = "paper_choice";
            this.paper_choice.Size = new System.Drawing.Size(62, 60);
            this.paper_choice.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.paper_choice.TabIndex = 8;
            this.paper_choice.TabStop = false;
            this.paper_choice.Click += new System.EventHandler(this.paper_choice_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(455, 345);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 37);
            this.label5.TabIndex = 9;
            this.label5.Text = "Let\'s Go";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(12, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(294, 21);
            this.label6.TabIndex = 11;
            this.label6.Text = "Rules: Click on figure you want to choose\r\n";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(775, 446);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.paper_choice);
            this.Controls.Add(this.scissors_choice);
            this.Controls.Add(this.rock_choice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.user_choice);
            this.Controls.Add(this.computer_choice);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.computer_choice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.user_choice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rock_choice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scissors_choice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paper_choice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private PictureBox computer_choice;
        private PictureBox user_choice;
        private Label label2;
        private Label label3;
        private Label label4;
        private PictureBox rock_choice;
        private PictureBox scissors_choice;
        private PictureBox paper_choice;
        private Label label5;
        private Label label6;
    }
}