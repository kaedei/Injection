using System.ComponentModel;

namespace Kaedei.Injection.WpfSample
{
	public abstract class InjectedNotifyPropertyChanged : IInjectable, INotifyPropertyChanged
	{
		public InjectedNotifyPropertyChanged()
		{
			this.Inject();
		}

		public InjectionContext InjectionContext { get; set; }


		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged(string propertyName)
		{
			var handler = this.PropertyChanged;
			if (handler != null)
			{
				handler(this, new PropertyChangedEventArgs(propertyName));
			}
		}


	}
}