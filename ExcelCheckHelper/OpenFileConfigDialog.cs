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
    public partial class OpenFileConfigDialog : Form
    {
        public OpenFileConfigDialog()
        {
            InitializeComponent();
            this.ControlBox = false;
        }

        public int FileOrder = 1;

        private void submitButton_Click(object sender, EventArgs e)
        {
            if (tableNameTextBox.Text.Equals("") || rowsTextBox.Text.Equals(""))
            {
                MessageBox.Show("请完善信息");
                return;
            }
            SendFileConfigHandler(tableNameTextBox.Text, firstHDRYesButton.Checked, int.Parse(rowsTextBox.Text), FileOrder);
            this.Close();
        }

        public delegate void SendFileConfig(string tableName, bool hdr, int rowCount, int callbackFileOrder);
        public event SendFileConfig SendFileConfigHandler;
    }
}
