using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Media;
using WPFDemo.Model;

namespace WPFDemo.Data
{
  public  class ListBoxDataInit
    {
        private static ListBoxDataInit dataInit;

        public static ListBoxDataInit Instance
        {
            get
            {
                if (dataInit == null)
                    dataInit = new ListBoxDataInit();
                return dataInit;
            }
        }

        private ListBoxDataInit()
        {
            UserList = new List<UserInfo>()
            {
                new UserInfo(){
                    UserBackground=new SolidColorBrush((Color)ColorConverter.ConvertFromString("#ff9f4c")),
                    Header="群",
                    Name="DESKTOP-0N",
                    Info="我要像风一样自由!",
                    Count=3
                },
                new UserInfo(){
                    UserBackground=new SolidColorBrush((Color)ColorConverter.ConvertFromString("#ff9f4c")),
                    Header="张",
                    Name="张三丰",
                    Info="我要像风一样自由!",
                    Count=5
                },
                new UserInfo(){
                    UserBackground=new SolidColorBrush((Color)ColorConverter.ConvertFromString("#9d9d9d")),
                    Header="鬼",
                    Name="鬼见愁",
                    Info="我要像风一样自由!",
                    Count=2
                },
            };
        }
        public List<UserInfo> UserList { get; set; }
    }
}
