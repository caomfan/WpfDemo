using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WPFDemo.Model;

namespace WPFDemo.Data
{
  public  class DataGridDataInit
    {
        private static DataGridDataInit dataInit;

        public static DataGridDataInit Instance
        {
            get
            {
                if (dataInit == null)
                    dataInit = new DataGridDataInit();
                return dataInit;
            }
        }

        private DataGridDataInit()
        {
            StudentList = new List<StudentInfo>()
            {
                new StudentInfo()
                {
                    Name="张三",
                    Class="三班",
                    Sex="男",
                    ClassRank=10,
                    SchoolRank=103
                },
                new StudentInfo()
                {
                    Name="李四",
                    Class="三班",
                    Sex="男",
                    ClassRank=12,
                    SchoolRank=110
                },
                new StudentInfo()
                {
                    Name="李梅",
                    Class="三班",
                    Sex="女",
                    ClassRank=3,
                    SchoolRank=70
                },
            };
        }
        public List<StudentInfo> StudentList { get; set; }
    }
}
