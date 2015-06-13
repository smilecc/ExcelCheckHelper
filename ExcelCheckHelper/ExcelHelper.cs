using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ExcelCheckHelper
{
    public class ExcelHelper
    {
        /// <summary>
        /// 文件地址
        /// </summary>
        string _FilePath;
        /// <summary>
        /// 连接字符串
        /// </summary>
        string _ConStr;
        const string conStrModel = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0};Extended Properties='Excel 8.0;HDR={1};IMEX=2'";
        /// <summary>
        /// 第一行是否为表头
        /// </summary>
        bool _HDR = false;
        /// <summary>
        /// 表名称
        /// </summary>
        string _tableName;
        bool tableNameIsSet = false;

        public int rowsCount;
        public string tableName
        {
            get
            {
                if (!tableNameIsSet) throw new Exception("表名未设置");
                return _tableName;
            }
            set
            {
                tableNameIsSet = true;
                _tableName = value;
            }
        }
        public List<ExcelTable> tableList = new List<ExcelTable>();
        void ConStrReload()
        {
            _ConStr = string.Format(conStrModel, FilePath, HdrString);
        }
        public string HdrString
        {
            get { return (_HDR ? "YES" : "NO"); }
            set
            {
                switch (value)
                {
                    case "YES":
                        _HDR = true;
                        break;
                    case "NO":
                        _HDR = false;
                        break;
                    default:
                        break;
                }
                ConStrReload();
            }
        }

        public bool HdrBool
        {
            get { return _HDR; }
            set
            {
                _HDR = value;
                ConStrReload();
            }
        }

        public string FilePath
        {
            get
            {
                return _FilePath;
            }
            set
            {
                _FilePath = value;
                ConStrReload();
            }
        }

        public ExcelHelper()
        {
        }

        public ExcelHelper(string File, bool Hdr)
        {
            FilePath = File;
            HdrBool = Hdr;
        }

        public void readData()
        {
            OleDbConnection OleConn = new OleDbConnection(_ConStr);
            OleConn.Open();
            String sql = "SELECT * FROM  [" + tableName + "$]";

            OleDbDataAdapter OleDaExcel = new OleDbDataAdapter(sql, OleConn);
            DataSet OleDsExcle = new DataSet();
            OleDaExcel.Fill(OleDsExcle, tableName);
            OleConn.Close();

            foreach (DataRow row in OleDsExcle.Tables[0].Rows)
            {
                ExcelTable insertTable = new ExcelTable(rowsCount);
                for (int i = 0; i < insertTable.ItemArray.Capacity; ++i)
                {
                    insertTable.ItemArray.Add(row[i].ToString());
                }
                tableList.Add(insertTable);
            }
        }

        public void saveData(string saveTableName)
        {
            OleDbConnection OleConn = new OleDbConnection(_ConStr);
            OleConn = new OleDbConnection(_ConStr);
            OleConn.Open();

            string qs = "CREATE TABLE " + saveTableName + " ([0列] VarChar";
            int tableMaxLength = 0;
            foreach (ExcelTable et in tableList)
            {
                if (et.ItemArray.Count > tableMaxLength) tableMaxLength = et.ItemArray.Count;
            }
            for (int i = 1; i < tableMaxLength; ++i)
            {
                qs = qs + string.Format(",[{0}列] VarChar", i);
            }
            qs = qs + ")";


            OleDbCommand cmd = new OleDbCommand(qs, OleConn);
            cmd.ExecuteNonQuery();

            foreach (var m in tableList)
            {
                string sql = "insert into [" + saveTableName + "$] values('" + m.ItemArray[0] + "'";
                for (int i = 1; i < m.ItemArray.Count; ++i)
                {
                    sql = sql + ",'" + m.ItemArray[i] + "'";
                }
                sql = sql + ")";
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
            }
            OleConn.Close();
        }
    }
}