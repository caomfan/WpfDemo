using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WPFDemo.Data;

namespace WPFDemo
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            InitData();
        }

        private void InitData()
        {
            TreeViewOrg.ItemsSource = TreeviewDataInit.Instance.OrgList;
            MultiCmb.ItemsSource = MultiComboBoxList.Instance.MultiComboBoxListData;
            DataGrid.ItemsSource= DataGridDataInit.Instance.StudentList;
            UserInfoList.ItemsSource = ListBoxDataInit.Instance.UserList;
            ListView.ItemsSource = ListViewDataInit.Instance.ListViewDataList;
        }

        
    }
}
