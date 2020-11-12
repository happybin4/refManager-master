using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinDataSetData;

namespace WinDataSet
{
    public class CommonService : IDisposable
    {
        CommonDAC dac;
        public CommonService()
        {
            dac = new CommonDAC();
        }

        public void Dispose()
        {
            dac.Dispose();
        }

        public DataSet GetCommonCode(string[] categorys)
        {
            return dac.GetCommonCode(categorys);
        }
    }
}
