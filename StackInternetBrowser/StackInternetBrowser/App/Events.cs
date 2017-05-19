using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jiuyong
{
	public class Events:AggregatorEvents
	{
#region 地址记录操作

		//AddUri	添加、注册 - 一个新的网址记录到库中
		//DelUri	删除、	 - 将网址从库中删除，意味着相关的地址已经不存在有价值的数据，删除以便排除无用数据干扰和节约空间。
		//Navigate 访问、	 - 访问当前 Uri 。
		//保持、	 - 添加纪录到临时库中，并同时记录到持久库中。
		//Remove 封存、		 - 从当前待访问列表中去除，但是相关数据依然存在持久库中。
		//分类、标签
		//添加标注

		/// <summary>
		/// 添加网址。
		/// </summary>
		public static readonly Action<string> AddUri = EventAggregator<string>.CreateEvent(() => AddUri);

#endregion
	}
}
