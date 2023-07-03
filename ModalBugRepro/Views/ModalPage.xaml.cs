namespace ModalBugRepro.Views;

public partial class ModalPage : ContentPage
{
	public ModalPage(ModalViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}
