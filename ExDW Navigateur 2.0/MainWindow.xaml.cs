using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ExDW_Navigateur_2._0
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

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Favoris_Click(object sender, RoutedEventArgs e)
        {
            frame.Content = new Favoris();
        }
        private void Rechercher_Click(object sender, RoutedEventArgs e)
        {
            string url = urlTxt.Text;
            //TODO: Vérifie si c'est une URL Ok..
            try
            {
                navigateur.Navigate(url);
            }
            catch
            {
                Console.WriteLine("Erreur");
            }
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            if (navigateur.CanGoBack)
            {
                navigateur.GoBack();
            }
            
        }
        private void Forward_Click(object sender, RoutedEventArgs e)
        {
            if (navigateur.CanGoForward)
            {
                navigateur.GoForward();
            }
            
        }

        private void Nouveau_Code_Click(object sender, RoutedEventArgs e)
        {
            AdminCode fen = new AdminCode();
            fen.Show();
        }
    }
}
