using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExcelCheckHelper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            openFileDialog.Filter = "Office Excel文件(*.xls)|*.xls";
            addDialog.AddItemHandler += AddItemCallback;
            changeDialog.ChangeItemHandler += ChangeItemCallback;
            openFileConfigDialog.SendFileConfigHandler += SendFileConfigCallback;

            if (MessageBox.Show("您是第一次使用吗？\n如果是第一次使用请使用之前请一定看看菜单栏 帮助 里的使用说明\n点击确定打开说明，点击取消取消打开操作", "提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                帮助ToolStripMenuItem1_Click(null, null);
            }
        }
        const string version = "1.0 beta";
        // 初始化Excel助手类
        ExcelHelper firstExcelHelper;
        ExcelHelper secondExcelHelper;

        // 初始化对话框
        AddDialog addDialog = new AddDialog();
        ChangeDialog changeDialog = new ChangeDialog();
        OpenFileConfigDialog openFileConfigDialog = new OpenFileConfigDialog();

        List<CheckCfg> checkCfgList = new List<CheckCfg>();


        /// <summary>
        /// 增加项目所发生的回调
        /// </summary>
        /// <param name="fir"></param>
        /// <param name="sec"></param>
        /// <param name="mode"></param>
        void AddItemCallback(int fir, int sec, int mode)
        {
            checkCfgList.Add(new CheckCfg(fir, sec, mode));
            checkListBox.Items.Add("列" + fir.ToString() + " => 列" + sec.ToString() + " :" + CheckCfg.GetModeName(mode));
        }
        /// <summary>
        /// 当修改表项时发生的事件回调
        /// </summary>
        /// <param name="changeItem">修改表项的内容</param>
        /// <param name="changeIndex">修改表项的序号</param>
        void ChangeItemCallback(CheckCfg changeItem, int changeIndex)
        {
            checkCfgList[changeIndex] = changeItem;
            checkListBox.Items.RemoveAt(changeIndex);
            checkListBox.Items.Insert(changeIndex, "列" + changeItem.firstUI.ToString() + " => 列" + changeItem.secondUI.ToString() + " :" + CheckCfg.GetModeName(changeItem.mode));
        }

        void SendFileConfigCallback(string tableName, bool hdr, int rowCount, int callbackFileOrder)
        {
            switch (callbackFileOrder)
            {
                case 1:
                    changeExcelHelperCfg(ref firstExcelHelper, tableName, hdr, rowCount);
                    break;
                case 2:
                    changeExcelHelperCfg(ref secondExcelHelper, tableName, hdr, rowCount);
                    break;
                default:
                    break;
            }
        }

        void changeExcelHelperCfg(ref ExcelHelper eh, string tableName, bool hdr, int rowCount)
        {
            eh = new ExcelHelper();
            eh.tableName = tableName;
            eh.HdrBool = hdr;
            eh.rowsCount = rowCount;
        }
        /// <summary>
        /// 用于响应第一与第二Excel表的打开事件
        /// </summary>
        /// <param name="operatedExcelHelper">被操作的excelHelper类</param>
        /// <param name="operatedTextbox">要改变内容的Textbox</param>
        private void openFileButton_Click(ExcelHelper operatedExcelHelper, TextBox operatedTextbox)
        {
            openFileDialog.FileName = "";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // 设置地址
                operatedExcelHelper.FilePath = openFileDialog.FileName;
                operatedTextbox.Text = openFileDialog.FileName;
                // 预读取数据
                try
                {
                    Thread th = new Thread(new ThreadStart(operatedExcelHelper.readData));
                    th.Start();
                }
                catch (Exception err)
                {
                    operatedTextbox.Text = "";
                    MessageBox.Show(err.Message);
                }
            }
        }

        private void openFirstFilebutton_Click(object sender, EventArgs e)
        {
            openFileConfigDialog.FileOrder = 1;
            openFileConfigDialog.ShowDialog();
            openFileButton_Click(firstExcelHelper, firstFilePathTextBox);
        }

        private void openSecondFilebutton_Click(object sender, EventArgs e)
        {
            openFileConfigDialog.FileOrder = 2;
            openFileConfigDialog.ShowDialog();
            openFileButton_Click(secondExcelHelper, secondFilePathTextBox);
        }

        private void CheckListMenuItem_Add_Click(object sender, EventArgs e)
        {
            addDialog.ShowDialog();
        }

        /// <summary>
        /// 响应过滤规则列表菜单打开事件，在不同位置显示不同的项目
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CheckListContextMenuStrip_Opening(object sender, CancelEventArgs e)
        {
            if (checkListBox.SelectedIndex == -1)
            {
                CheckListMenuItem_Change.Visible = false;
                删除所选项ToolStripMenuItem.Visible = false;
            }
            else
            {
                CheckListMenuItem_Change.Visible = true;
                删除所选项ToolStripMenuItem.Visible = true;
            }
        }

        /// <summary>
        /// 过滤列表修改
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CheckListMenuItem_Change_Click(object sender, EventArgs e)
        {
            changeDialog.changeInit(checkCfgList[checkListBox.SelectedIndex], checkListBox.SelectedIndex);
            changeDialog.ShowDialog();
        }

        /// <summary>
        /// 过滤列表删除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 删除所选项ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            checkCfgList.RemoveAt(checkListBox.SelectedIndex);
            checkListBox.Items.Remove(checkListBox.SelectedItem);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (saveTableNameTextBox.Text.Equals(""))
            {
                MessageBox.Show("请完善数据");
                return;
            }
            try
            {
                var result =
                    isSwap ?
                    ExcelChecker.Check(checkCfgList, secondExcelHelper, firstExcelHelper) :
                    ExcelChecker.Check(checkCfgList, firstExcelHelper, secondExcelHelper);

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    ExcelHelper save = new ExcelHelper(openFileDialog.FileName, true);
                    save.tableList = result;
                    save.saveData(saveTableNameTextBox.Text);
                    MessageBox.Show("保存完成");
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }


        bool isSwap = false;
        private void swapButton_Click(object sender, EventArgs e)
        {
            isSwap = !isSwap;
            checkListBox.Items.Clear();
            foreach (var cfg in checkCfgList)
            {
                cfg.swap();
                checkListBox.Items.Add("列" + cfg.firstUI.ToString() + " => 列" + cfg.secondUI.ToString() + " :" + CheckCfg.GetModeName(cfg.mode));
            }
            string temp = firstFilePathTextBox.Text;
            firstFilePathTextBox.Text = secondFilePathTextBox.Text;
            secondFilePathTextBox.Text = temp;
            if (isSwap) swapButton.Text = "已翻转 点击翻回";
            else swapButton.Text = "翻转文件1与文件2";
        }

        private void 帮助ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://cuican.name/?page_id=293");
        }

        private void 反馈建议与BugToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://cuican.name/?page_id=288");
        }

        private void 关于ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Program by 璨\n当前版本：" + version + "\n完成时间：2015/6/13", "Excel检查助手 关于", MessageBoxButtons.OK);
        }
    }
}
