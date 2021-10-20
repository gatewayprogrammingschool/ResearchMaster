using Microsoft.Maui;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.PlatformConfiguration.WindowsSpecific;
using Application = Microsoft.Maui.Controls.Application;

namespace ResearchMaster
{
	public partial class App
	{
		public App()
		{
			InitializeComponent();

			MainPage = new MainPage();
		}
	}
}
