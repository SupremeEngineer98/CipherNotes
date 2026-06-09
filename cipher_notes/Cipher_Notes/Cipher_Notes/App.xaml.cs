namespace Cipher_Notes
{
    public partial class App : Application
    {
        public App(MainPage main_page)
        {
            InitializeComponent();
            MainPage = main_page;
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(new MainPage()) { Title = "Cipher_Notes" };
        }
    }
}
