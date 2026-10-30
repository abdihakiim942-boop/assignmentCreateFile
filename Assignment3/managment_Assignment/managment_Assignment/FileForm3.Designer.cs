namespace managment_Assignment
{
    partial class FileForm3
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
            this.lbFileName = new System.Windows.Forms.Label();
            this.tbFileName = new System.Windows.Forms.TextBox();
            this.lbInput = new System.Windows.Forms.Label();
            this.tbInput = new System.Windows.Forms.TextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnWrite = new System.Windows.Forms.Button();
            this.btnRead = new System.Windows.Forms.Button();
            this.btnAppend = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lbOutput = new System.Windows.Forms.Label();
            this.tbOutput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbFileName
            // 
            this.lbFileName.AutoSize = true;
            this.lbFileName.Location = new System.Drawing.Point(15, 15);
            this.lbFileName.Name = "lbFileName";
            this.lbFileName.Size = new System.Drawing.Size(60, 13);
            this.lbFileName.TabIndex = 0;
            this.lbFileName.Text = "File Name:";
            // 
            // tbFileName
            // 
            this.tbFileName.Location = new System.Drawing.Point(15, 35);
            this.tbFileName.Name = "tbFileName";
            this.tbFileName.Size = new System.Drawing.Size(300, 20);
            this.tbFileName.TabIndex = 1;
            this.tbFileName.Text = "notes.txt";
            // 
            // lbInput
            // 
            this.lbInput.AutoSize = true;
            this.lbInput.Location = new System.Drawing.Point(15, 70);
            this.lbInput.Name = "lbInput";
            this.lbInput.Size = new System.Drawing.Size(60, 13);
            this.lbInput.TabIndex = 2;
            this.lbInput.Text = "Write Text Here:";
            // 
            // tbInput
            // 
            this.tbInput.Multiline = true;
            this.tbInput.Location = new System.Drawing.Point(15, 90);
            this.tbInput.Name = "tbInput";
            this.tbInput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbInput.Size = new System.Drawing.Size(300, 110);
            this.tbInput.TabIndex = 3;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(15, 215);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(95, 32);
            this.btnCreate.TabIndex = 4;
            this.btnCreate.Text = "New File";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnWrite
            // 
            this.btnWrite.Location = new System.Drawing.Point(118, 215);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new System.Drawing.Size(95, 32);
            this.btnWrite.TabIndex = 5;
            this.btnWrite.Text = "Write";
            this.btnWrite.UseVisualStyleBackColor = true;
            this.btnWrite.Click += new System.EventHandler(this.btnWrite_Click);
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(221, 215);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(95, 32);
            this.btnRead.TabIndex = 6;
            this.btnRead.Text = "Read";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // btnAppend
            // 
            this.btnAppend.Location = new System.Drawing.Point(15, 257);
            this.btnAppend.Name = "btnAppend";
            this.btnAppend.Size = new System.Drawing.Size(95, 32);
            this.btnAppend.TabIndex = 7;
            this.btnAppend.Text = "Add Text";
            this.btnAppend.UseVisualStyleBackColor = true;
            this.btnAppend.Click += new System.EventHandler(this.btnAppend_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(118, 257);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(95, 32);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(221, 257);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(95, 32);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lbOutput
            // 
            this.lbOutput.AutoSize = true;
            this.lbOutput.Location = new System.Drawing.Point(340, 15);
            this.lbOutput.Name = "lbOutput";
            this.lbOutput.Size = new System.Drawing.Size(45, 13);
            this.lbOutput.TabIndex = 10;
            this.lbOutput.Text = "File Content:";
            // 
            // tbOutput
            // 
            this.tbOutput.Multiline = true;
            this.tbOutput.Location = new System.Drawing.Point(340, 35);
            this.tbOutput.Name = "tbOutput";
            this.tbOutput.ReadOnly = true;
            this.tbOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbOutput.Size = new System.Drawing.Size(340, 325);
            this.tbOutput.TabIndex = 11;
            // 
            // FileForm3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 380);
            this.Controls.Add(this.lbFileName);
            this.Controls.Add(this.tbFileName);
            this.Controls.Add(this.lbInput);
            this.Controls.Add(this.tbInput);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.btnWrite);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.btnAppend);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lbOutput);
            this.Controls.Add(this.tbOutput);
            this.Name = "FileForm3";
            this.Text = "Create File 3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbFileName;
        private System.Windows.Forms.TextBox tbFileName;
        private System.Windows.Forms.Label lbInput;
        private System.Windows.Forms.TextBox tbInput;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnWrite;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Button btnAppend;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lbOutput;
        private System.Windows.Forms.TextBox tbOutput;
    }
}
