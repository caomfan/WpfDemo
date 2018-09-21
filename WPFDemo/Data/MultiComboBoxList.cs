using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using WPFDemo.Controls;

namespace WPFDemo.Data
{
  public  class MultiComboBoxList
    {
        private static MultiComboBoxList dataInit;

        public static MultiComboBoxList Instance
        {
            get
            {
                if (dataInit == null)
                    dataInit = new MultiComboBoxList();
                return dataInit;
            }
        }

        private MultiComboBoxList()
        {
            MultiComboBoxListData = new ObservableCollection<MultiComboBox.MultiCbxBaseData>()
            {
                new MultiComboBox.MultiCbxBaseData(){
                    ID=0,
                    ViewName="张三",
                    IsCheck=false
                },
                new MultiComboBox.MultiCbxBaseData(){
                    ID=1,
                    ViewName="李四",
                    IsCheck=false
                },
                new MultiComboBox.MultiCbxBaseData(){
                    ID=2,
                    ViewName="王五",
                    IsCheck=false
                },
                new MultiComboBox.MultiCbxBaseData(){
                    ID=3,
                    ViewName="马六",
                    IsCheck=false
                },
                new MultiComboBox.MultiCbxBaseData(){
                    ID=4,
                    ViewName="赵七",
                    IsCheck=false
                },
            };
        }
        public ObservableCollection<MultiComboBox.MultiCbxBaseData> MultiComboBoxListData;
    }
}
