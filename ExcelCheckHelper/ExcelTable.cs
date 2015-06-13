using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelCheckHelper
{
    public class ExcelTable
    {
        public List<string> ItemArray;
        public ExcelTable(int TableLength)
        {
            ItemArray = new List<string>(TableLength);
        }

        public static bool operator==(ExcelTable lhs,ExcelTable rhs)
        {
            if (lhs.ItemArray.Count != rhs.ItemArray.Count) return false;

            foreach (string value in lhs.ItemArray)
            {
                if (rhs.ItemArray.Contains(value)) continue;
                else return false;
            }
            return true;
        }

        public static bool operator !=(ExcelTable lhs, ExcelTable rhs)
        {
            return !(lhs == rhs);
        }

        public override bool Equals(object obj)
        {
            return this == (ExcelTable)obj;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
