using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows;

namespace Kaedei.Injection.WpfSample
{
	/// <summary>
	/// App.xaml 的交互逻辑
	/// </summary>
	public partial class App : Application
	{
		protected override void OnStartup(StartupEventArgs e)
		{
			base.OnStartup(e);
			//注册绑定
			InjectionContext.Default.Bind<IReverseService, ReverseServiceImpl>();
		}
	}
}
