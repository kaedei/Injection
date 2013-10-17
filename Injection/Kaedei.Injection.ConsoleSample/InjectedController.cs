namespace Kaedei.Injection.ConsoleSample
{
	public abstract class InjectedController : IInjectable
	{
		public InjectedController()
		{
			this.Inject();
		}

		public InjectionContext InjectionContext { get; set; }
	}
}