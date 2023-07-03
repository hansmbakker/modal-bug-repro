namespace ModalBugRepro.ViewModels;

public partial class MainViewModel : BaseViewModel
{
    [RelayCommand]
    private async Task ShowModalAsync()
    {
        await Shell.Current.GoToAsync(nameof(ModalPage));
    }
}
