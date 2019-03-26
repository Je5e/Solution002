using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace DataAccesFactory
{
    public partial class App : Application
    {
        private static Model.Database Repository_BF;
        public static Model.Database Repository
        {
            get
            {
                if (Repository_BF == null)
                {
                    Repository_BF = new Model.Database
                        (FactoryFilePath.GetDatabaseFilePath()
                        .Invoke().GetFullFilePath("Northwind.db3"));
                }
                return Repository_BF;
            }
           
        }
        public static IDatabaseFilePathFactory FactoryFilePath { get; set; }
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
