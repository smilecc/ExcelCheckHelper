using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelCheckHelper
{
    public class CheckCfg
    {
        public int _first, _second;
        public int firstUI
        {
            get { return _first + 1; }
            set { _first = value - 1; }
        }
        public int secondUI
        {
            get { return _second + 1; }
            set { _second = value - 1; }
        }
        public int mode;
        public CheckCfg(int Fir, int Sec, int Mode)
        {
            firstUI = Fir;
            secondUI = Sec;
            mode = Mode;
        }
        public const int ModeCount = 2;
        /// <summary>
        /// 通过模式序号获取模式名称
        /// </summary>
        /// <param name="mode"></param>
        /// <returns></returns>
        public static string GetModeName(int mode)
        {
            string modeName;
            switch (mode)
            {
                case 0:
                    modeName = "取重复部分";
                    break;
                case 1:
                    modeName = "取非重复部分";
                    break;
                default:
                    modeName = "错误";
                    break;
            }
            return modeName;
        }

        public void swap()
        {
            int temp = _first;
            _first = _second;
            _second = temp;
        }
    }
}
