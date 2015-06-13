namespace ExcelCheckHelper
{
    partial class OpenFileConfigDialog
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
            this.firstHDRNoButton = new System.Windows.Forms.RadioButton();
            this.firstHDRYesButton = new System.Windows.Forms.RadioButton();
            this.tableNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rowsTextBox = new System.Windows.Forms.TextBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // firstHDRNoButton
            // 
            this.firstHDRNoButton.AutoSize = true;
            this.firstHDRNoButton.Checked = true;
            this.firstHDRNoButton.Location = new System.Drawing.Point(120, 69);
            this.firstHDRNoButton.Name = "firstHDRNoButton";
            this.firstHDRNoButton.Size = new System.Drawing.Size(107, 16);
            this.firstHDRNoButton.TabIndex = 13;
            this.firstHDRNoButton.TabStop = true;
            this.firstHDRNoButton.Text = "第一行不为表头";
            this.firstHDRNoButton.UseVisualStyleBackColor = true;
            // 
            // firstHDRYesButton
            // 
            this.firstHDRYesButton.AutoSize = true;
            this.firstHDRYesButton.Location = new System.Drawing.Point(19, 69);
            this.firstHDRYesButton.Name = "firstHDRYesButton";
            this.firstHDRYesButton.Size = new System.Drawing.Size(95, 16);
            this.firstHDRYesButton.TabIndex = 12;
            this.firstHDRYesButton.Text = "第一行为表头";
            this.firstHDRYesButton.UseVisualStyleBackColor = true;
            // 
            // tableNameTextBox
            // 
            this.tableNameTextBox.Location = new System.Drawing.Point(91, 28);
            this.tableNameTextBox.Name = "tableNameTextBox";
            this.tableNameTextBox.Size = new System.Drawing.Size(136, 21);
            this.tableNameTextBox.TabIndex = 24;
            this.tableNameTextBox.Text = "Sheet1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 23;
            this.label1.Text = "工作表名：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 25;
            this.label2.Text = "总列数：";
            // 
            // rowsTextBox
            // 
            this.rowsTextBox.Location = new System.Drawing.Point(91, 111);
            this.rowsTextBox.Name = "rowsTextBox";
            this.rowsTextBox.Size = new System.Drawing.Size(100, 21);
            this.rowsTextBox.TabIndex = 26;
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(81, 165);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(94, 35);
            this.submitButton.TabIndex = 27;
            this.submitButton.Text = "确认";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // OpenFileConfigDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 225);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.rowsTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tableNameTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.firstHDRNoButton);
            this.Controls.Add(this.firstHDRYesButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "OpenFileConfigDialog";
            this.Text = "OpenFileConfigDialog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton firstHDRNoButton;
        private System.Windows.Forms.RadioButton firstHDRYesButton;
        private System.Windows.Forms.TextBox tableNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox rowsTextBox;
        private System.Windows.Forms.Button submitButton;

    }
}