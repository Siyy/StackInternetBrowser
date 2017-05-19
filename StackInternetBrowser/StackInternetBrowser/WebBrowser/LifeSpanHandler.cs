using CefSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jiuyong
{
	public class LifeSpanHandler: ILifeSpanHandler
	{
		public bool OnBeforePopup(IWebBrowser browserControl, IBrowser browser, IFrame frame, string targetUrl, string targetFrameName, WindowOpenDisposition targetDisposition, bool userGesture, IPopupFeatures popupFeatures, IWindowInfo windowInfo, IBrowserSettings browserSettings, ref bool noJavascriptAccess, out IWebBrowser newBrowser)
		{
			//throw new NotImplementedException();
			newBrowser = null;
			Events.AddUri(targetUrl);

			return true;
		}

		public void OnAfterCreated(IWebBrowser browserControl, IBrowser browser)
		{
			//var r = browser.MainFrame.EvaluateScriptAsync("document.activeElement()").Result;

			//throw new NotImplementedException();
		}

		public bool DoClose(IWebBrowser browserControl, IBrowser browser)
		{
			//throw new NotImplementedException();
			return true;
		}

		public void OnBeforeClose(IWebBrowser browserControl, IBrowser browser)
		{
			//throw new NotImplementedException();
		}
	}
}
