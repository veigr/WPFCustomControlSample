using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace CustomControlSample.ViewModels
{
    public class MainWindowViewModel
    {
        public DetailViewModel[] Details { get; set; }
            = new DetailViewModel[]{
                new DetailViewModel { IsEditable = false, Text = "1" },
                new DetailViewModel { IsEditable = false, Text = "2" },
                new DetailViewModel { IsEditable = false, Text = "3" },
                new DetailViewModel { IsEditable = false, Text = "4" },
                new DetailViewModel { IsEditable = false, Text = "5" },
            };
    }
}
