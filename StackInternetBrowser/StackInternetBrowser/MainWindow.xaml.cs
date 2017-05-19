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
			Loaded += MainWindow_Loaded;
		}

		ViewModels.MainWindowViewModel VM => DataContext as ViewModels.MainWindowViewModel;


		private void MainWindow_Loaded(object sender, RoutedEventArgs e)
		{

			WebBrowser_Init();
			BindingCommands();
			SubscriptEvents();
		}

		private void SubscriptEvents()
		{
			this.Subscribe(Events.AddUri, async url =>
			 {

				 var frame = MainBrowser.GetBrowser().MainFrame;
				 var textJP = await frame.EvaluateScriptAsync(
					 "document.activeElement.innerText"
					 );
				 var text = textJP.Result as string;
				 var hrefJP = await frame.EvaluateScriptAsync(
					 //"document"
					 "document.activeElement.href"
					 //"document.getElementById('element_Id');"
					 );
				 var href = hrefJP.Result as string;

				 if (url == href)
				 {
					 if (String.IsNullOrWhiteSpace(text))
					 {
						 text = href;
					 }

					 Dispatcher.Invoke(() =>
					 {
						 VM.OpeningLinkes.Add(new ViewModels.ALink { Href = href, Text = text });
					 });
				 }
				 else
				 {
					 Events.Error(new Exception($"应该打开的地址为“{url}”，但激活的超链接目标为“{href}”。"));
				 }
			 });
		}

		private void BindingCommands()
		{
			//throw new NotImplementedException();
		}

		private void WebBrowser_Init()
		{
			MainBrowser.LifeSpanHandler = new LifeSpanHandler();
			MainBrowser.BrowserSettings.ApplicationCache = CefSharp.CefState.Enabled;
		}

		private void TestRibbonButton_Click(object sender, RoutedEventArgs e)
		{

		}
	}
}
