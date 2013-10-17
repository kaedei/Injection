using System.Reflection;
using System.Text;

namespace Kaedei.Injection
{
	public interface IInjectable
	{
		/// <summary>
		/// 执行注入的上下文
		/// </summary>
		InjectionContext InjectionContext { get; set; }
	}

	//public interface IInjectable
	//{
	//	T GetObject<T>();
	//	void Bind<T1, T2>(bool reusable);
	//}
}