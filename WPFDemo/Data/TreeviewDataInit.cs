using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using WPFDemo.Model;

namespace WPFDemo.Data
{
    public class TreeviewDataInit
    {
        private static TreeviewDataInit dataInit;

        public static TreeviewDataInit Instance
        {
            get
            {
                if (dataInit == null)
                    dataInit = new TreeviewDataInit();
                return dataInit;
            }
        }
        private TreeviewDataInit()
        {
            OrgList = new ObservableCollection<OrgModel>()
            {
                new OrgModel()
                {
                    IsGrouping = true,
                    DisplayName = "单位名称(3/7)",
                    Children = new ObservableCollection<OrgModel>()
                    {
                        new OrgModel(){
                            IsGrouping=true,
                            DisplayName="未分组联系人(2/4)",
                            Children=new ObservableCollection<OrgModel>()
                            {
                                new OrgModel(){
                                    IsGrouping=false,
                                    SurName="刘",
                                    Name="刘棒",
                                    Info="我要走向天空！",
                                    Count=3
                                }
                            }
                        }
                    },
                }

            };
        }
        public ObservableCollection<OrgModel> OrgList { get; set; }

    }
}
