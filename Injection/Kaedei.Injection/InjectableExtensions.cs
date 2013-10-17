using System.Linq;

namespace Kaedei.Injection
{
	public static class InjectableExtensions
	{
		/// <summary>
		/// 执行注入操作
		/// </summary>
		/// <remarks>此方法将会注入并初始化类中所有标记了InjectAttribute的Property</remarks>
		public static void Inject(this IInjectable injectable)
		{
			injectable.InjectionContext = injectable.InjectionContext ?? InjectionContext.Default;
			injectable.GetType()
				.GetProperties()
				.Where(m => m.GetCustomAttributes(typeof(InjectAttribute), true).Any())
				.ToList()
				.ForEach(m => m.SetValue(injectable, injectable.InjectionContext.GetObject(m.PropertyType), null));
		}
	}
}