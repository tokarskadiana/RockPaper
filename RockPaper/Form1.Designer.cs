namespace RockPaper
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
            this.buttonPaper = new System.Windows.Forms.Button();
            this.buttonScissors = new System.Windows.Forms.Button();
            this.buttonRock = new System.Windows.Forms.Button();
            this.textResoult = new System.Windows.Forms.TextBox();
            this.textUser = new System.Windows.Forms.TextBox();
            this.textComputer = new System.Windows.Forms.TextBox();
            this.userLabel = new System.Windows.Forms.Label();
            this.computerLable = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonPaper
            // 
            this.buttonPaper.Location = new System.Drawing.Point(12, 139);
            this.buttonPaper.Name = "buttonPaper";
            this.buttonPaper.Size = new System.Drawing.Size(75, 68);
            this.buttonPaper.TabIndex = 0;
            this.buttonPaper.Text = "Paper";
            this.buttonPaper.UseVisualStyleBackColor = true;
            this.buttonPaper.Click += new System.EventHandler(this.buttonPaper_Click);
            // 
            // buttonScissors
            // 
            this.buttonScissors.Location = new System.Drawing.Point(197, 139);
            this.buttonScissors.Name = "buttonScissors";
            this.buttonScissors.Size = new System.Drawing.Size(75, 68);
            this.buttonScissors.TabIndex = 1;
            this.buttonScissors.Text = "Scissors";
            this.buttonScissors.UseVisualStyleBackColor = true;
            this.buttonScissors.Click += new System.EventHandler(this.buttonScissors_Click);
            // 
            // buttonRock
            // 
            this.buttonRock.Location = new System.Drawing.Point(105, 139);
            this.buttonRock.Name = "buttonRock";
            this.buttonRock.Size = new System.Drawing.Size(75, 68);
            this.buttonRock.TabIndex = 2;
            this.buttonRock.Text = "Rock";
            this.buttonRock.UseVisualStyleBackColor = true;
            this.buttonRock.Click += new System.EventHandler(this.buttonRock_Click);
            // 
            // textResoult
            // 
            this.textResoult.Enabled = false;
            this.textResoult.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textResoult.Location = new System.Drawing.Point(12, 80);
            this.textResoult.Name = "textResoult";
            this.textResoult.ReadOnly = true;
            this.textResoult.Size = new System.Drawing.Size(260, 31);
            this.textResoult.TabIndex = 3;
            this.textResoult.Text = "Wynik";
            this.textResoult.TextChanged += new System.EventHandler(this.textResoult_TextChanged);
            // 
            // textUser
            // 
            this.textUser.Enabled = false;
            this.textUser.Location = new System.Drawing.Point(12, 43);
            this.textUser.Name = "textUser";
            this.textUser.Size = new System.Drawing.Size(100, 20);
            this.textUser.TabIndex = 4;
            // 
            // textComputer
            // 
            this.textComputer.Enabled = false;
            this.textComputer.Location = new System.Drawing.Point(172, 43);
            this.textComputer.Name = "textComputer";
            this.textComputer.Size = new System.Drawing.Size(100, 20);
            this.textComputer.TabIndex = 5;
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.Location = new System.Drawing.Point(9, 13);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(37, 13);
            this.userLabel.TabIndex = 6;
            this.userLabel.Text = "USER";
            // 
            // computerLable
            // 
            this.computerLable.AutoSize = true;
            this.computerLable.Location = new System.Drawing.Point(204, 13);
            this.computerLable.Name = "computerLable";
            this.computerLable.Size = new System.Drawing.Size(68, 13);
            this.computerLable.TabIndex = 7;
            this.computerLable.Text = "COMPUTER";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.computerLable);
            this.Controls.Add(this.userLabel);
            this.Controls.Add(this.textComputer);
            this.Controls.Add(this.textUser);
            this.Controls.Add(this.textResoult);
            this.Controls.Add(this.buttonRock);
            this.Controls.Add(this.buttonScissors);
            this.Controls.Add(this.buttonPaper);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonPaper;
        private System.Windows.Forms.Button buttonScissors;
        private System.Windows.Forms.Button buttonRock;
        private System.Windows.Forms.TextBox textResoult;
        private System.Windows.Forms.TextBox textUser;
        private System.Windows.Forms.TextBox textComputer;
        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.Label computerLable;
    }
}

