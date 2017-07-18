namespace WindowsFormsApplication1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.firstNamebox = new System.Windows.Forms.TextBox();
            this.ageTextBox = new System.Windows.Forms.TextBox();
            this.lastNamebox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.UserLabel = new System.Windows.Forms.Label();
            this.PassLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter your First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter your Age";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Enter your Last Name";
            // 
            // firstNamebox
            // 
            this.firstNamebox.Location = new System.Drawing.Point(240, 38);
            this.firstNamebox.Name = "firstNamebox";
            this.firstNamebox.Size = new System.Drawing.Size(100, 20);
            this.firstNamebox.TabIndex = 3;
            // 
            // ageTextBox
            // 
            this.ageTextBox.Location = new System.Drawing.Point(240, 104);
            this.ageTextBox.Name = "ageTextBox";
            this.ageTextBox.Size = new System.Drawing.Size(100, 20);
            this.ageTextBox.TabIndex = 4;
            // 
            // lastNamebox
            // 
            this.lastNamebox.Location = new System.Drawing.Point(240, 72);
            this.lastNamebox.Name = "lastNamebox";
            this.lastNamebox.Size = new System.Drawing.Size(100, 20);
            this.lastNamebox.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(96, 155);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(253, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Generate Username and Password";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Username Generated :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(61, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Password Generated :";
            // 
            // UserLabel
            // 
            this.UserLabel.AutoSize = true;
            this.UserLabel.Location = new System.Drawing.Point(199, 221);
            this.UserLabel.Name = "UserLabel";
            this.UserLabel.Size = new System.Drawing.Size(0, 13);
            this.UserLabel.TabIndex = 9;
            // 
            // PassLabel
            // 
            this.PassLabel.AutoSize = true;
            this.PassLabel.Location = new System.Drawing.Point(199, 245);
            this.PassLabel.Name = "PassLabel";
            this.PassLabel.Size = new System.Drawing.Size(0, 13);
            this.PassLabel.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(91, 1);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(338, 25);
            this.label6.TabIndex = 12;
            this.label6.Text = "Login Id and Password generation";
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.AutoSize = true;
            this.ErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.ErrorLabel.Location = new System.Drawing.Point(61, 194);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(0, 13);
            this.ErrorLabel.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 320);
            this.Controls.Add(this.ErrorLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.PassLabel);
            this.Controls.Add(this.UserLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lastNamebox);
            this.Controls.Add(this.ageTextBox);
            this.Controls.Add(this.firstNamebox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox firstNamebox;
        private System.Windows.Forms.TextBox ageTextBox;
        private System.Windows.Forms.TextBox lastNamebox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label UserLabel;
        private System.Windows.Forms.Label PassLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label ErrorLabel;
    }
}

