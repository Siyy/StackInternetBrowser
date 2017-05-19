using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections.ObjectModel;

namespace Jiuyong.ViewModels
{
	public class MainWindowViewModel : ViewModelBase
	{
		#region OpeningLinkes - 当前访问的链接

		/// <summary>
		/// 当前访问的链接。
		/// </summary>
		private ObservableCollection<ALink> _OpeningLinkes
			= new ObservableCollection<ALink>()
			;

		/// <summary>
		/// 当前访问的链接。
		/// </summary>
		//[System.ComponentModel.DataAnnotations.Display(Name="当前访问的链接",Description="当前访问的链接。",AutoGenerateField = true)]
		//[System.ComponentModel.DataAnnotations.Required(ErrorMessage="“当前访问的链接”不能为空！")]
		[System.ComponentModel.Category("模型")]  //可用于属性面板中的分组。
		[System.ComponentModel.Description("当前访问的链接。")]
		////在编辑面板（例如 Blend ）中如何显示。
		[System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		////在属性面板（例如 VisualStudio）中隐藏。
		//[System.ComponentModel.Browsable(false)]
		//[Newtonsoft.Json.JsonIgnore]
		public ObservableCollection<ALink> OpeningLinkes
		{
			get { return _OpeningLinkes; }
			//set
			//{
			//	OnPropertyChanging(nameof(OpeningLinkes));
			//	ValidateProperty(nameof(OpeningLinkes), value);
			//	_OpeningLinkes = value;
			//	OnPropertyChanged(nameof(OpeningLinkes));
			//}
		}

		#endregion
	}

	public class ALink
	{
		public string Href { get; set; }
		public string Text { get; set; }
	}
}
