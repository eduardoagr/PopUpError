
namespace PopUpError.Views {
    public partial class PopUp : Popup {
        public PopUp(PopUpViewModel popUpViewModel) {
            InitializeComponent();
            BindingContext = popUpViewModel;
        }
    }
}