namespace PopUpError.ViewModels;
public partial class PopUpViewModel : ObservableObject {

    [RelayCommand]
    void close(Popup popup) {

        popup.Close();
    }

}
