
namespace PopUpError.ViewModels;

public partial class MainViewModel(IPopupService popupService) : BaseViewModel {

    [ObservableProperty]
    Color originalColor;

    [RelayCommand]
    void Open() {
        popupService.ShowPopup<PopUpViewModel>();
    }
}
