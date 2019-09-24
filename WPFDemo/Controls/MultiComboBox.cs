using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;

namespace WPFDemo.Controls
{
    public class MultiComboBox : ComboBox
    {
        static MultiComboBox()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(MultiComboBox), new FrameworkPropertyMetadata(typeof(MultiComboBox)));
        }


        private static void OnPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            d.SetValue(e.Property, e.NewValue);
        }

        /// <summary>
        /// 选中项列表
        /// </summary>
        public ObservableCollection<MultiCbxBaseData> ChekedItems=new ObservableCollection<MultiCbxBaseData>(); 

        /// <summary>
        /// ListBox竖向列表
        /// </summary>
        private ListBox _ListBoxV;

        /// <summary>
        /// ListBox横向列表
        /// </summary>
        private ListBox _ListBoxH;

        public override void OnApplyTemplate()
        {
            base.OnApplyTemplate();
            _ListBoxV = Template.FindName("PART_ListBox", this) as ListBox;
            _ListBoxH = Template.FindName("PART_ListBoxChk", this) as ListBox;
            _ListBoxH.ItemsSource = ChekedItems;
            _ListBoxV.SelectionChanged += _ListBoxV_SelectionChanged;
            _ListBoxH.SelectionChanged += _ListBoxH_SelectionChanged;

            if (ItemsSource != null)
            {
                foreach (var item in ItemsSource)
                {
                    MultiCbxBaseData bdc = item as MultiCbxBaseData;
                    if (bdc.IsCheck)
                    {
                        _ListBoxV.SelectedItems.Add(bdc);
                    }
                }
            }
        }

        private void _ListBoxH_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            foreach (var item in e.RemovedItems)
            {
                MultiCbxBaseData datachk = item as MultiCbxBaseData;

                for (int i = 0; i < _ListBoxV.SelectedItems.Count; i++)
                {
                    MultiCbxBaseData datachklist = _ListBoxV.SelectedItems[i] as MultiCbxBaseData;
                    if (datachklist.ID == datachk.ID)
                    {
                        _ListBoxV.SelectedItems.Remove(_ListBoxV.SelectedItems[i]);
                    }
                }
            }
        }

        void _ListBoxV_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            foreach (var item in e.AddedItems)
            {
                MultiCbxBaseData datachk = item as MultiCbxBaseData;
                datachk.IsCheck = true;
                if (ChekedItems.IndexOf(datachk) < 0)
                {
                    ChekedItems.Add(datachk);
                }
            }

            foreach (var item in e.RemovedItems)
            {
                MultiCbxBaseData datachk = item as MultiCbxBaseData;
                datachk.IsCheck = false;
                ChekedItems.Remove(datachk);
            }
        }

        public class MultiCbxBaseData
        {
            private int _id;
            /// <summary>
            /// 关联主键
            /// </summary>
            public int ID
            {
                get { return _id; }
                set { _id = value; }
            }

            private string _viewName;
            /// <summary>
            /// 显示名称
            /// </summary>
            public string ViewName
            {
                get { return _viewName; }
                set
                {
                    _viewName = value;
                }
            }

            private bool _isCheck;
            /// <summary>
            /// 是否选中
            /// </summary>
            public bool IsCheck
            {
                get { return _isCheck; }
                set { _isCheck = value; }
            }
        }
    }
}
