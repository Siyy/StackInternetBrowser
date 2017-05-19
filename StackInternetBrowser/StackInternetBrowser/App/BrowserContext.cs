using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jiuyong
{
	public class BrowserContext
	{
		#region 网址记录操作

		//AddUri	
		/// <summary>
		/// 添加、注册 - 一个新的网址记录到库中。
		/// </summary>
		/// <param name="url"></param>
		void AddUri(string url) { }

		//DelUri	删除、	 - 将网址从库中删除，意味着相关的地址已经不存在有价值的数据，删除以便排除无用数据干扰和节约空间。

		//Navigate 
		/// <summary>
		/// 访问当前 Uri 。
		/// </summary>
		/// <param name="uriIndex"></param>
		void Navigating(int uriIndex) { }

		//保持 - 添加纪录到临时库中，并同时记录到持久库中。

		///<summary>
		///封存 - 从当前待访问列表中去除，但是相关数据依然存在持久库中。
		///</summary>
		void Remove(int uriIndex) { }

		//分类、标签

		//添加标注

		#endregion
	}
}
