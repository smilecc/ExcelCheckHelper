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
    public partial class AddDialog : Form
    {
        public AddDialog()
        {
            InitializeComponent();
            table1TextBox.Text = "";
            table2TextBox.Text = "";
            // 增加检查模式
            for (int i = 0; i < CheckCfg.ModeCount;++i )
                CheckModeComboBox.Items.Add(CheckCfg.GetModeName(i));
            CheckModeComboBox.SelectedIndex = 0;
        }


        public delegate void AddItem(int fir,int sec,int mode);
        public event AddItem AddItemHandler;
        private void AddButton_Click(object sender, EventArgs e)
        {
            AddItemHandler(int.Parse(table1TextBox.Text), int.Parse(table2TextBox.Text), CheckModeComboBox.SelectedIndex);
            this.Close();
        }
    }
}
