using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Media;

namespace WPFDemo.Model
{
    public class UserInfo
    {
        public Brush UserBackground { get; set; }
        public string Header { get; set; }
        public string Name { get; set; }
        public string Info { get; set; }
        public int Count { get; set; }
    }
}
