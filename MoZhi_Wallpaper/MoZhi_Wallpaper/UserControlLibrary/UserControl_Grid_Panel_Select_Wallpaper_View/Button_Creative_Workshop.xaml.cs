using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MoZhi_Wallpaper.UserControlLibrary.UserControl_Grid_Panel_Select_Wallpaper_View
{
    /// <summary>
    /// Button_Creative_Workshop.xaml 的交互逻辑
    /// </summary>
    public partial class Button_Creative_Workshop : UserControl
    {
        public Button_Creative_Workshop()
        {
            InitializeComponent();
        }

        public bool BoolMouseLeftDown;

        private void UserControl_MouseEnter(object sender, MouseEventArgs e)
        {
            if (!BoolMouseLeftDown)
                Border_Hover_BackGround.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF1163F2"));
        }

        private void UserControl_MouseLeave(object sender, MouseEventArgs e)
        {
            if (!BoolMouseLeftDown)
                Border_Hover_BackGround.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#00000000"));
        }
    }
}
