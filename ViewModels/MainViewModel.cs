
namespace PopUpError.ViewModels;

public partial class MainViewModel(IPopupService popupService) : BaseViewModel {

    [RelayCommand]
    void Open() {

        popupService.ShowPopup<PopUpViewModel>();
    }
}
