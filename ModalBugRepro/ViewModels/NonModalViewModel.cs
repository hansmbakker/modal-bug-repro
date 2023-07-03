namespace ModalBugRepro.ViewModels;

public partial class NonModalViewModel : BaseViewModel
{
    [RelayCommand]
    private async Task ShowNonModalAsync()
    {
        await Shell.Current.GoToAsync(nameof(NonModalPage));
    }
}
