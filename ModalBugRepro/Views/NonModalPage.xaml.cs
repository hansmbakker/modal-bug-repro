namespace ModalBugRepro.Views;

public partial class NonModalPage : ContentPage
{
	public NonModalPage(NonModalViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}
