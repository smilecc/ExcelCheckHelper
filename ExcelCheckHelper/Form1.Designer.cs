namespace ExcelCheckHelper
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.firstFilePathTextBox = new System.Windows.Forms.TextBox();
            this.openFirstFilebutton = new System.Windows.Forms.Button();
            this.secondFilePathTextBox = new System.Windows.Forms.TextBox();
            this.openSecondFilebutton = new System.Windows.Forms.Button();
            this.checkListBox = new System.Windows.Forms.ListBox();
            this.CheckListContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CheckListMenuItem_Add = new System.Windows.Forms.ToolStripMenuItem();
            this.CheckListMenuItem_Change = new System.Windows.Forms.ToolStripMenuItem();
            this.删除所选项ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.saveTableNameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.swapButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.反馈建议与BugToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CheckListContextMenuStrip.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // firstFilePathTextBox
            // 
            this.firstFilePathTextBox.Enabled = false;
            this.firstFilePathTextBox.Location = new System.Drawing.Point(94, 39);
            this.firstFilePathTextBox.Name = "firstFilePathTextBox";
            this.firstFilePathTextBox.Size = new System.Drawing.Size(378, 21);
            this.firstFilePathTextBox.TabIndex = 17;
            // 
            // openFirstFilebutton
            // 
            this.openFirstFilebutton.Location = new System.Drawing.Point(13, 37);
            this.openFirstFilebutton.Name = "openFirstFilebutton";
            this.openFirstFilebutton.Size = new System.Drawing.Size(75, 23);
            this.openFirstFilebutton.TabIndex = 16;
            this.openFirstFilebutton.Text = "打开文件1";
            this.openFirstFilebutton.UseVisualStyleBackColor = true;
            this.openFirstFilebutton.Click += new System.EventHandler(this.openFirstFilebutton_Click);
            // 
            // secondFilePathTextBox
            // 
            this.secondFilePathTextBox.Enabled = false;
            this.secondFilePathTextBox.Location = new System.Drawing.Point(94, 80);
            this.secondFilePathTextBox.Name = "secondFilePathTextBox";
            this.secondFilePathTextBox.Size = new System.Drawing.Size(378, 21);
            this.secondFilePathTextBox.TabIndex = 19;
            // 
            // openSecondFilebutton
            // 
            this.openSecondFilebutton.Location = new System.Drawing.Point(13, 78);
            this.openSecondFilebutton.Name = "openSecondFilebutton";
            this.openSecondFilebutton.Size = new System.Drawing.Size(75, 23);
            this.openSecondFilebutton.TabIndex = 18;
            this.openSecondFilebutton.Text = "打开文件2";
            this.openSecondFilebutton.UseVisualStyleBackColor = true;
            this.openSecondFilebutton.Click += new System.EventHandler(this.openSecondFilebutton_Click);
            // 
            // checkListBox
            // 
            this.checkListBox.ContextMenuStrip = this.CheckListContextMenuStrip;
            this.checkListBox.FormattingEnabled = true;
            this.checkListBox.ItemHeight = 12;
            this.checkListBox.Location = new System.Drawing.Point(12, 121);
            this.checkListBox.Name = "checkListBox";
            this.checkListBox.Size = new System.Drawing.Size(209, 244);
            this.checkListBox.TabIndex = 20;
            // 
            // CheckListContextMenuStrip
            // 
            this.CheckListContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CheckListMenuItem_Add,
            this.CheckListMenuItem_Change,
            this.删除所选项ToolStripMenuItem});
            this.CheckListContextMenuStrip.Name = "CheckListContextMenuStrip";
            this.CheckListContextMenuStrip.Size = new System.Drawing.Size(161, 70);
            this.CheckListContextMenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.CheckListContextMenuStrip_Opening);
            // 
            // CheckListMenuItem_Add
            // 
            this.CheckListMenuItem_Add.Name = "CheckListMenuItem_Add";
            this.CheckListMenuItem_Add.Size = new System.Drawing.Size(160, 22);
            this.CheckListMenuItem_Add.Text = "增加新筛选规则";
            this.CheckListMenuItem_Add.Click += new System.EventHandler(this.CheckListMenuItem_Add_Click);
            // 
            // CheckListMenuItem_Change
            // 
            this.CheckListMenuItem_Change.Name = "CheckListMenuItem_Change";
            this.CheckListMenuItem_Change.Size = new System.Drawing.Size(160, 22);
            this.CheckListMenuItem_Change.Text = "修改所选项规则";
            this.CheckListMenuItem_Change.Click += new System.EventHandler(this.CheckListMenuItem_Change_Click);
            // 
            // 删除所选项ToolStripMenuItem
            // 
            this.删除所选项ToolStripMenuItem.Name = "删除所选项ToolStripMenuItem";
            this.删除所选项ToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.删除所选项ToolStripMenuItem.Text = "删除所选项";
            this.删除所选项ToolStripMenuItem.Click += new System.EventHandler(this.删除所选项ToolStripMenuItem_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(303, 333);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(169, 32);
            this.saveButton.TabIndex = 27;
            this.saveButton.Text = "匹配并导出结果";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(301, 309);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 28;
            this.label1.Text = "存储表名：";
            // 
            // saveTableNameTextBox
            // 
            this.saveTableNameTextBox.Location = new System.Drawing.Point(372, 306);
            this.saveTableNameTextBox.Name = "saveTableNameTextBox";
            this.saveTableNameTextBox.Size = new System.Drawing.Size(100, 21);
            this.saveTableNameTextBox.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(240, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(232, 119);
            this.label2.TabIndex = 30;
            this.label2.Text = "注意：两表对比时，对于 非重复模式 存在\r\n一个基准问题，就是以谁为基础对比对象\r\n最后也已基准的文件为输出\r\n在本程序里默认以文件2为基准。\r\n如果需要以文件1" +
    "为基准请使用翻转文件1\r\n与文件2按钮。\r\n以上描述对 对比重复模式 不存在。";
            // 
            // swapButton
            // 
            this.swapButton.Location = new System.Drawing.Point(243, 243);
            this.swapButton.Name = "swapButton";
            this.swapButton.Size = new System.Drawing.Size(135, 31);
            this.swapButton.TabIndex = 31;
            this.swapButton.Text = "翻转文件1与文件2";
            this.swapButton.UseVisualStyleBackColor = true;
            this.swapButton.Click += new System.EventHandler(this.swapButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.帮助ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(495, 25);
            this.menuStrip1.TabIndex = 32;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.帮助ToolStripMenuItem1,
            this.反馈建议与BugToolStripMenuItem,
            this.关于ToolStripMenuItem});
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.帮助ToolStripMenuItem.Text = "帮助";
            // 
            // 帮助ToolStripMenuItem1
            // 
            this.帮助ToolStripMenuItem1.Name = "帮助ToolStripMenuItem1";
            this.帮助ToolStripMenuItem1.Size = new System.Drawing.Size(159, 22);
            this.帮助ToolStripMenuItem1.Text = "使用说明";
            this.帮助ToolStripMenuItem1.Click += new System.EventHandler(this.帮助ToolStripMenuItem1_Click);
            // 
            // 反馈建议与BugToolStripMenuItem
            // 
            this.反馈建议与BugToolStripMenuItem.Name = "反馈建议与BugToolStripMenuItem";
            this.反馈建议与BugToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.反馈建议与BugToolStripMenuItem.Text = "反馈建议与Bug";
            this.反馈建议与BugToolStripMenuItem.Click += new System.EventHandler(this.反馈建议与BugToolStripMenuItem_Click);
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.关于ToolStripMenuItem.Text = "关于";
            this.关于ToolStripMenuItem.Click += new System.EventHandler(this.关于ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 372);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.swapButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.saveTableNameTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.checkListBox);
            this.Controls.Add(this.secondFilePathTextBox);
            this.Controls.Add(this.openSecondFilebutton);
            this.Controls.Add(this.firstFilePathTextBox);
            this.Controls.Add(this.openFirstFilebutton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Excel 校对助手 1.0 beta - Program by 璨";
            this.CheckListContextMenuStrip.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.TextBox firstFilePathTextBox;
        private System.Windows.Forms.Button openFirstFilebutton;
        private System.Windows.Forms.TextBox secondFilePathTextBox;
        private System.Windows.Forms.Button openSecondFilebutton;
        private System.Windows.Forms.ListBox checkListBox;
        private System.Windows.Forms.ContextMenuStrip CheckListContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem CheckListMenuItem_Add;
        private System.Windows.Forms.ToolStripMenuItem CheckListMenuItem_Change;
        private System.Windows.Forms.ToolStripMenuItem 删除所选项ToolStripMenuItem;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox saveTableNameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button swapButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 反馈建议与BugToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
    }
}

