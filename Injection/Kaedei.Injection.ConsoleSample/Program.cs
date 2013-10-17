using System;

namespace Kaedei.Injection.ConsoleSample
{
	class Program
	{
		static void Main(string[] args)
		{
			RegisterBinding();
			var testController = new Controller(); //初始化时即注入
			testController.OutputNumberToConsole(); //测试注入后的类
			Console.ReadLine();
		}

		/// <summary>
		/// 绑定接口和实现
		/// </summary>
		private static void RegisterBinding()
		{
			InjectionContext.Default.Bind<IService, ServiceImpl>();
		}
	}
}
