namespace UWToDoMobile
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
        }

        public static AppShell? CurrentAppShell => Current as AppShell;

    }
}
