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
using System.Windows.Controls.Ribbon;

namespace Jiuyong
{
	/// <summary>
	/// MainWindow.xaml 的交互逻辑
	/// </summary>
	public partial class MainWindow : RibbonWindow
	{
		public MainWindow()
		{
			InitializeComponent();
		}

		private void WebBrowser_LoadCompleted(object sender, NavigationEventArgs e)
		{

		}

		private void WebBrowser_Navigated(object sender, NavigationEventArgs e)
		{

		}

		private void WebBrowser_Navigating(object sender, NavigatingCancelEventArgs e)
		{

		}

	}
}
