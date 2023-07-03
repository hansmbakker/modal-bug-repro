namespace ModalBugRepro;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

        Routing.RegisterRoute(nameof(ModalPage), typeof(ModalPage));
        Routing.RegisterRoute(nameof(NonModalPage), typeof(NonModalPage));
    }
}
