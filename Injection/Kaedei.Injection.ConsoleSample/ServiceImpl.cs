using System;

namespace Kaedei.Injection.ConsoleSample
{
	/// <summary>
	/// 实现IService接口的服务
	/// </summary>
	class ServiceImpl : IService
	{
		public string GetNumber()
		{
			return new Random(Environment.TickCount).NextDouble().ToString();
		}
	}
}