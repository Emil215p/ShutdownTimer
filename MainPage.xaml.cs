using ShutdownTimer.ViewModel;

namespace ShutdownTimer
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
        }
        public MainPage(MainViewModel vm)
        {
            InitializeComponent();
            BindingContext = vm;
        }
    }

}
