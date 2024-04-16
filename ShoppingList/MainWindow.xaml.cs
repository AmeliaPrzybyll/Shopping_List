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
using System.Data.SqlClient;

namespace ShoppingList
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void DeleteShoppingList_Click(object sender, RoutedEventArgs e)
        {

        }

        private void CreateShoppingList_Click(object sender, RoutedEventArgs e)
        {

        }

        private void AddProductToDatabase_Click(object sender, RoutedEventArgs e)
        {
            Window1 window1 = new Window1();
            window1.Show();




        //    AddProductWindow addProductWindow = new AddProductWindow();
        //    addProductWindow.ShowDialog();

        //    // Tutaj dodaj kod, który ma być wykonany po zamknięciu okna dialogowego
        //    if (addProductWindow.DialogResult == true)
        //    {
        //        // Pobierz dane wprowadzone przez użytkownika
        //        string nazwa = addProductWindow.Nazwa;
        //        string producent = addProductWindow.Producent;
        //        float cena = addProductWindow.Cena;

        //        // Wywołaj metodę dodającą nowy wiersz do bazy danych
        //        DataAcces dataAcces = new DataAcces("data source=Amelia\\SQLEXPRESS;initial catalog=master;trusted_connection=true");
        //        dataAcces.AddNewRow(nazwa, producent, cena);
        //    }
        }

     


        //private void Window1(object sender, RoutedEventArgs e)
        //{
        //    Window1 objSecondWindow = new Window1();
        //    this.Visibility = Visibility.Visible;
        //    objSecondWindow.Show();
        //}

    }

    //internal class AddProductWindow
    //{
    //    internal string Nazwa;
    //    internal string Producent;
    //    internal float Cena;
    //    internal bool DialogResult;

    //    internal bool? ShowDialog()
    //    {
    //        throw new NotImplementedException();
    //    }
    //}

    public class DataAcces
    {
        private string connectionstring;// "data source=Amelia\\SQLEXPRESS;initial catalog=master;trusted_connection=true";

        public DataAcces(string v)
        {
        }

        public void DataAccess(string connectionstring) // ewentualnie usunać voida
        {
            this.connectionstring = connectionstring;
        }
        public void AddNewRow(string nazwa, string producent, float cena)
        {
            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                string query = "INSERT INTO List(ProductName,Producer,Price) VALUES(@nazwa,@producent,@cena)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@nazwa", nazwa);
                command.Parameters.AddWithValue("@producent", producent);
                command.Parameters.AddWithValue("@cena", cena);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}