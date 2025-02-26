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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnInput = new System.Windows.Forms.Button();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.txtinput3 = new System.Windows.Forms.TextBox();
            this.txtinput2 = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.btnSelectAll = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbFnameS = new System.Windows.Forms.TextBox();
            this.txbSNameS = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pbSuccess = new System.Windows.Forms.PictureBox();
            this.pbFail = new System.Windows.Forms.PictureBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtDelWhere = new System.Windows.Forms.TextBox();
            this.btnDelWhere = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbSuccess)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFail)).BeginInit();
            this.SuspendLayout();
            // 
            // btnInput
            // 
            this.btnInput.Location = new System.Drawing.Point(28, 155);
            this.btnInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnInput.Name = "btnInput";
            this.btnInput.Size = new System.Drawing.Size(93, 30);
            this.btnInput.TabIndex = 0;
            this.btnInput.Text = "Input";
            this.btnInput.UseVisualStyleBackColor = true;
            this.btnInput.Click += new System.EventHandler(this.btnInput_Click);
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(28, 46);
            this.txtInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(168, 22);
            this.txtInput.TabIndex = 1;
            // 
            // txtinput3
            // 
            this.txtinput3.Location = new System.Drawing.Point(28, 118);
            this.txtinput3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtinput3.Name = "txtinput3";
            this.txtinput3.Size = new System.Drawing.Size(168, 22);
            this.txtinput3.TabIndex = 2;
            // 
            // txtinput2
            // 
            this.txtinput2.Location = new System.Drawing.Point(28, 79);
            this.txtinput2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtinput2.Name = "txtinput2";
            this.txtinput2.Size = new System.Drawing.Size(168, 22);
            this.txtinput2.TabIndex = 3;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(225, 155);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(123, 23);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(11, 267);
            this.txtOutput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(1032, 144);
            this.txtOutput.TabIndex = 5;
            // 
            // btnSelectAll
            // 
            this.btnSelectAll.Location = new System.Drawing.Point(410, 46);
            this.btnSelectAll.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSelectAll.Name = "btnSelectAll";
            this.btnSelectAll.Size = new System.Drawing.Size(85, 23);
            this.btnSelectAll.TabIndex = 6;
            this.btnSelectAll.Text = "Select All";
            this.btnSelectAll.UseVisualStyleBackColor = true;
            this.btnSelectAll.Click += new System.EventHandler(this.btnSelectAll_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Enter into DB";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(221, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Search Where";
            // 
            // txbFnameS
            // 
            this.txbFnameS.Location = new System.Drawing.Point(225, 46);
            this.txbFnameS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbFnameS.Name = "txbFnameS";
            this.txbFnameS.Size = new System.Drawing.Size(170, 22);
            this.txbFnameS.TabIndex = 9;
            this.txbFnameS.Text = "Fname";
            // 
            // txbSNameS
            // 
            this.txbSNameS.Location = new System.Drawing.Point(225, 79);
            this.txbSNameS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbSNameS.Name = "txbSNameS";
            this.txbSNameS.Size = new System.Drawing.Size(170, 22);
            this.txbSNameS.TabIndex = 10;
            this.txbSNameS.Text = "Sname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 246);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Output";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(406, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Select all";
            // 
            // pbSuccess
            // 
            this.pbSuccess.Image = ((System.Drawing.Image)(resources.GetObject("pbSuccess.Image")));
            this.pbSuccess.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbSuccess.InitialImage")));
            this.pbSuccess.Location = new System.Drawing.Point(757, 46);
            this.pbSuccess.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbSuccess.Name = "pbSuccess";
            this.pbSuccess.Size = new System.Drawing.Size(286, 183);
            this.pbSuccess.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSuccess.TabIndex = 13;
            this.pbSuccess.TabStop = false;
            this.pbSuccess.Visible = false;
            // 
            // pbFail
            // 
            this.pbFail.Image = ((System.Drawing.Image)(resources.GetObject("pbFail.Image")));
            this.pbFail.Location = new System.Drawing.Point(757, 11);
            this.pbFail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbFail.Name = "pbFail";
            this.pbFail.Size = new System.Drawing.Size(271, 234);
            this.pbFail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFail.TabIndex = 14;
            this.pbFail.TabStop = false;
            this.pbFail.Visible = false;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(410, 75);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(85, 23);
            this.btnClear.TabIndex = 15;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(528, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 16);
            this.label5.TabIndex = 17;
            this.label5.Text = "Delete all";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(644, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 16);
            this.label6.TabIndex = 18;
            this.label6.Text = "Delete Where";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(519, 45);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(98, 23);
            this.btnDelete.TabIndex = 19;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtDelWhere
            // 
            this.txtDelWhere.Location = new System.Drawing.Point(637, 45);
            this.txtDelWhere.Name = "txtDelWhere";
            this.txtDelWhere.Size = new System.Drawing.Size(114, 22);
            this.txtDelWhere.TabIndex = 20;
            // 
            // btnDelWhere
            // 
            this.btnDelWhere.Location = new System.Drawing.Point(647, 79);
            this.btnDelWhere.Name = "btnDelWhere";
            this.btnDelWhere.Size = new System.Drawing.Size(98, 23);
            this.btnDelWhere.TabIndex = 21;
            this.btnDelWhere.Text = "Delete Where";
            this.btnDelWhere.UseVisualStyleBackColor = true;
            this.btnDelWhere.Click += new System.EventHandler(this.btnDelWhere_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 422);
            this.Controls.Add(this.btnDelWhere);
            this.Controls.Add(this.txtDelWhere);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.pbFail);
            this.Controls.Add(this.pbSuccess);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbSNameS);
            this.Controls.Add(this.txbFnameS);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSelectAll);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtinput2);
            this.Controls.Add(this.txtinput3);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.btnInput);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbSuccess)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInput;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.TextBox txtinput3;
        private System.Windows.Forms.TextBox txtinput2;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Button btnSelectAll;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbFnameS;
        private System.Windows.Forms.TextBox txbSNameS;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pbSuccess;
        private System.Windows.Forms.PictureBox pbFail;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtDelWhere;
        private System.Windows.Forms.Button btnDelWhere;
    }
}

