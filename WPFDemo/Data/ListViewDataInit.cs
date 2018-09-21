using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WPFDemo.Model;

namespace WPFDemo.Data
{
   public class ListViewDataInit
    {
        private static ListViewDataInit dataInit;

        public static ListViewDataInit Instance
        {
            get
            {
                if (dataInit == null)
                    dataInit = new ListViewDataInit();
                return dataInit;
            }
        }

        private ListViewDataInit()
        {
            ListViewDataList = new List<ListViewData>();
            for (int i = 0; i < 10; i++)
            {
                ListViewDataList.Add(new ListViewData()
                {
                    Num = i,
                    Name = "No_" + i.ToString(),
                    Template = "Temlate:" + i.ToString()
                });
            }
        }
        public List<ListViewData> ListViewDataList { get; set; }
    }
}
