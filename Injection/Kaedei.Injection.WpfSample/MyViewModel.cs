using System.Linq;
using System.Windows.Input;

namespace Kaedei.Injection.WpfSample
{
	/// <summary>
	/// 主窗口的ViewModel
	/// </summary>
	public class MyViewModel : InjectedNotifyPropertyChanged
	{
		[Inject]
		public IReverseService ReverseService { get; set; }

		private string m_myInput;
		/// <summary>
		/// 用户的输入
		/// </summary>
		public string MyInput
		{
			get { return m_myInput; }
			set
			{
				m_myInput = value;
				OnPropertyChanged("MyInput");
				//当发生改变时更新下面的输出(使用注入的Service)
				MyOutput = ReverseService.Reverse(m_myInput);
			}
		}

		private string m_myOutput;
		/// <summary>
		/// 输出
		/// </summary>
		public string MyOutput
		{
			get { return m_myOutput; }
			set
			{
				m_myOutput = value;
				OnPropertyChanged("MyOutput");
			}
		}



	}

	public interface IReverseService
	{
		string Reverse(string input);
	}

	class ReverseServiceImpl : IReverseService
	{
		/// <summary>
		/// 将输入的字符串翻转
		/// </summary>
		public string Reverse(string input)
		{
			return new string(input.ToCharArray().Reverse().ToArray());
		}
	}
}