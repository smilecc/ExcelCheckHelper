using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelCheckHelper
{
    public class ExcelChecker
    {
        /// <summary>
        /// 通过CheckCfg配置表匹配并整合内容
        /// </summary>
        /// <param name="cfgList"></param>
        /// <param name="firstTable"></param>
        /// <param name="secondTable"></param>
        public static List<ExcelTable> Check(List<CheckCfg> cfgList, ExcelHelper firstTable, ExcelHelper secondTable)
        {
            List<List<ExcelTable>> returnList = new List<List<ExcelTable>>();
            if (cfgList.Count == 0) throw new Exception("没有任何一条筛选规则");

            foreach (CheckCfg cfg in cfgList)
            {
                // 用Switch利于扩展
                switch (cfg.mode)
                {
                    case 0:
                    case 1:
                        returnList.Add(CheckRepeat(cfg, firstTable.tableList, secondTable.tableList));
                        break;
                    default:
                        break;
                }
            }

            if (cfgList.Count == 1) return returnList[0];
            else
            {
                CheckCfg NullTemp = new CheckCfg(0, 0, 0);
                List<ExcelTable> checkResult = CheckRepeat(NullTemp, returnList[0], returnList[1], true);
                if (cfgList.Count == 2) return checkResult;
                else
                {
                    for (int i = 2; i < cfgList.Count; ++i)
                    {
                        checkResult = CheckRepeat(NullTemp, checkResult, returnList[i], true);
                    }
                    return checkResult;
                }
            }
        }

        /// <summary>
        /// 重复与非重复匹配
        /// </summary>
        /// <param name="cfg">配置实例，全行匹配模式下无效</param>
        /// <param name="firstTable"></param>
        /// <param name="secondTable"></param>
        /// <param name="allLine">全行匹配模式</param>
        public static List<ExcelTable> CheckRepeat(CheckCfg cfg, List<ExcelTable> firstTable, List<ExcelTable> secondTable, bool allLine = false)
        {
            List<ExcelTable> returnList = new List<ExcelTable>();

            if (allLine)
            {
                foreach (ExcelTable line in firstTable)
                {
                    if (secondTable.Contains(line)) returnList.Add(line);
                }
            }
            else
            {

                // 是否是翻转模式
                bool isUn = (cfg.mode == 0 ? false : true);

                // 提取第一表所要匹配的关键词
                List<string> keywordList = new List<string>(firstTable.Count);
                foreach (ExcelTable line in firstTable)
                {
                    keywordList.Add(line.ItemArray[cfg._first]);
                }

                foreach (ExcelTable line in secondTable)
                {
                    bool isHave = keywordList.Contains(line.ItemArray[cfg._second]);
                    // 匹配到重复内容 且没有翻转
                    if (isHave && !isUn)
                    {
                        returnList.Add(line);
                    }// 没有匹配到重复内容 且翻转为匹配非重复内容
                    else if (!isHave && isUn)
                    {
                        returnList.Add(line);
                    }
                }
            }
            return returnList;
        }
    }
}
