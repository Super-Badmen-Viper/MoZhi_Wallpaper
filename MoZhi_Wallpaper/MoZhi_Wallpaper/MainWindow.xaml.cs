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

namespace MoZhi_Wallpaper
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Window_Loaded();
        }

        /// <summary>
        /// 拖动窗口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            try
            {
                this.DragMove();
            }
            catch { }
        }

        /// <summary>
        /// 窗体初始化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Window_Loaded()
        {
            thickness_Grid_1_Normal = Grid_Panel_Select_Wallpaper_View.Margin;
            thickness_Grid_2_Normal = Grid_2.Margin;
            thickness_Grid_3_Normal = Grid_3.Margin;
            thickness_Grid_1_Small = Grid_Panel_Select_Wallpaper_View.Margin;
            thickness_Grid_2_Small = Grid_2.Margin;
            thickness_Grid_3_Small = Grid_3.Margin;
            thickness_Grid_1_Normal.Right = 330;
            thickness_Grid_2_Normal.Right = 330;
            thickness_Grid_3_Normal.Right = 330;
        }

        Thickness thickness_Grid_1_Small = new Thickness();
        Thickness thickness_Grid_2_Small = new Thickness();
        Thickness thickness_Grid_3_Small = new Thickness();
        Thickness thickness_Grid_1_Normal = new Thickness();
        Thickness thickness_Grid_2_Normal = new Thickness();
        Thickness thickness_Grid_3_Normal = new Thickness();
        /// <summary>
        /// 窗体大小变化事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Window_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            Grid_Panel_Select_Wallpaper_View.Margin = thickness_Grid_1_Normal;
            Grid_2.Margin = thickness_Grid_2_Normal;
            Grid_3.Margin = thickness_Grid_3_Normal;
        }
        /// <summary>
        /// 应用关闭
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Window_Closed(object sender, EventArgs e)
        {
            //关闭桌面写真
            
        }

        
    }
}
