namespace Kaedei.Injection
{
	/// <summary>
	/// 最基本可注入的基类
	/// </summary>
	public abstract class GeneralInjected :IInjectable
	{
		public GeneralInjected()
		{
			this.Inject();
		}

		/// <summary>
		/// 执行注入的上下文
		/// </summary>
		public InjectionContext InjectionContext { get; set; }
	}
}