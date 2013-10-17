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
}