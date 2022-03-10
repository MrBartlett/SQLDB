namespace SQLDB
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
            this.btnInput = new System.Windows.Forms.Button();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.txtinput3 = new System.Windows.Forms.TextBox();
            this.txtinput2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnInput
            // 
            this.btnInput.Location = new System.Drawing.Point(31, 194);
            this.btnInput.Name = "btnInput";
            this.btnInput.Size = new System.Drawing.Size(105, 38);
            this.btnInput.TabIndex = 0;
            this.btnInput.Text = "Input";
            this.btnInput.UseVisualStyleBackColor = true;
            this.btnInput.Click += new System.EventHandler(this.btnInput_Click);
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(31, 57);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(291, 26);
            this.txtInput.TabIndex = 1;
            // 
            // txtinput3
            // 
            this.txtinput3.Location = new System.Drawing.Point(31, 147);
            this.txtinput3.Name = "txtinput3";
            this.txtinput3.Size = new System.Drawing.Size(291, 26);
            this.txtinput3.TabIndex = 2;
            // 
            // txtinput2
            // 
            this.txtinput2.Location = new System.Drawing.Point(31, 99);
            this.txtinput2.Name = "txtinput2";
            this.txtinput2.Size = new System.Drawing.Size(291, 26);
            this.txtinput2.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(650, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 29);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(585, 87);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(203, 125);
            this.textBox1.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(524, 22);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 29);
            this.button2.TabIndex = 6;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtinput2);
            this.Controls.Add(this.txtinput3);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.btnInput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInput;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.TextBox txtinput3;
        private System.Windows.Forms.TextBox txtinput2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
    }
}

