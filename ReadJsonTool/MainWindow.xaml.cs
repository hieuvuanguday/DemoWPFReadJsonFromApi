using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ReadJsonTool
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ApiServices _apiServices = new ApiServices();

        public MainWindow()
        {
            InitializeComponent();
        }

        private async void UsersDataGrid_Loaded(object sender, RoutedEventArgs e)
        {
            var list = await _apiServices.GetUsersAsync();
            UsersDataGrid.ItemsSource = list;
        }
    }
}