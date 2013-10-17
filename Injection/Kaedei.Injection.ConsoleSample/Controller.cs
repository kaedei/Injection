using System;

namespace Kaedei.Injection.ConsoleSample
{
	public class Controller : GeneralInjected
	{
		[Inject]
		public IService MyService { get; set; } 

		public void OutputNumberToConsole()
		{
			var text = MyService.GetNumber();
			Console.WriteLine("My Number is: " + text);
		}
	}
}