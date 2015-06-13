namespace ExcelCheckHelper
{
    partial class ChangeDialog
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
            if ( disposing && ( components != null ) )
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
            this.ChangeButton = new System.Windows.Forms.Button();
            this.CheckModeComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.table2TextBox = new System.Windows.Forms.TextBox();
            this.table1TextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ChangeButton
            // 
            this.ChangeButton.Location = new System.Drawing.Point(107, 114);
            this.ChangeButton.Name = "ChangeButton";
            this.ChangeButton.Size = new System.Drawing.Size(84, 35);
            this.ChangeButton.TabIndex = 15;
            this.ChangeButton.Text = "修改";
            this.ChangeButton.UseVisualStyleBackColor = true;
            this.ChangeButton.Click += new System.EventHandler(this.ChangeButton_Click);
            // 
            // CheckModeComboBox
            // 
            this.CheckModeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CheckModeComboBox.FormattingEnabled = true;
            this.CheckModeComboBox.Location = new System.Drawing.Point(83, 71);
            this.CheckModeComboBox.Name = "CheckModeComboBox";
            this.CheckModeComboBox.Size = new System.Drawing.Size(196, 20);
            this.CheckModeComboBox.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 13;
            this.label4.Text = "对比模式：";
            // 
            // table2TextBox
            // 
            this.table2TextBox.Location = new System.Drawing.Point(186, 35);
            this.table2TextBox.Name = "table2TextBox";
            this.table2TextBox.Size = new System.Drawing.Size(93, 21);
            this.table2TextBox.TabIndex = 12;
            // 
            // table1TextBox
            // 
            this.table1TextBox.Location = new System.Drawing.Point(53, 35);
            this.table1TextBox.Name = "table1TextBox";
            this.table1TextBox.Size = new System.Drawing.Size(86, 21);
            this.table1TextBox.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(145, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 12);
            this.label3.TabIndex = 10;
            this.label3.Text = "表2：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 9;
            this.label2.Text = "表1：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 12);
            this.label1.TabIndex = 8;
            this.label1.Text = "对比列 (请填阿拉伯数字，列数从第1列开始计算)";
            // 
            // ChangeDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 171);
            this.Controls.Add(this.ChangeButton);
            this.Controls.Add(this.CheckModeComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.table2TextBox);
            this.Controls.Add(this.table1TextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ChangeDialog";
            this.Text = "修改数据";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ChangeButton;
        private System.Windows.Forms.ComboBox CheckModeComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox table2TextBox;
        private System.Windows.Forms.TextBox table1TextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}