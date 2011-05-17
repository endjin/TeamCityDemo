namespace Endjin.TeamCityDemo.Desktop
{
    #region Using Directives

    using System.Windows;

    using Endjin.TeamCityDemo.Domain;
    using Endjin.TeamCityDemo.Tasks;

    #endregion

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            var domainObject = new MyDomainObject();
            var task = new MyTask();

            task.DoSomething(domainObject);
        }
    }
}
