namespace ModalBugRepro.ViewModels;

public partial class ModalViewModel : BaseViewModel
{
    [RelayCommand]
    private async Task ShowNonModalAsync()
    {
        await Shell.Current.GoToAsync(nameof(NonModalPage));
    }
}
