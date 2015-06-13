using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExcelCheckHelper
{
    public partial class ChangeDialog : Form
    {
        public ChangeDialog()
        {
            InitializeComponent();
            // 增加检查模式
            for (int i = 0; i < CheckCfg.ModeCount; ++i)
                CheckModeComboBox.Items.Add(CheckCfg.GetModeName(i));
            CheckModeComboBox.SelectedIndex = 0;
        }
        int ChangeIndex = 0;
        public void changeInit(CheckCfg changeObj, int changeIndex)
        {
            table1TextBox.Text = changeObj.firstUI.ToString();
            table2TextBox.Text = changeObj.secondUI.ToString();
            CheckModeComboBox.SelectedIndex = changeObj.mode;
            ChangeIndex = changeIndex;
        }
        public delegate void ChangeItem(CheckCfg changeItem, int changeIndex);
        public event ChangeItem ChangeItemHandler;
        private void ChangeButton_Click(object sender, EventArgs e)
        {
            ChangeItemHandler(new CheckCfg(int.Parse(table1TextBox.Text), int.Parse(table2TextBox.Text), CheckModeComboBox.SelectedIndex), ChangeIndex);
            this.Close();
        }
    }
}
