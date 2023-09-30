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
using System.Windows.Shapes;

namespace LocationVehicule
{
    /// <summary>
    /// Logique d'interaction pour Acces.xaml
    /// </summary>
    public partial class Acces : Window
    {
        
        public Acces()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, RoutedEventArgs e)
        {
            

            if(!String.IsNullOrEmpty(txtUtilisateur.Text) && !string.IsNullOrEmpty(pxbPassword.Password)
                && txtUtilisateur.Text=="admin" && pxbPassword.Password=="123")
            {
                MessageBox.Show("Bienvnus",
                    "Hello", MessageBoxButton.OK, MessageBoxImage.Information);
                MainWindow mainWindow = new MainWindow();
                mainWindow.ShowDialog();

            }
            else
            {
                MessageBox.Show("Tous les champs son obligatoire",
                    "Attention", MessageBoxButton.OK, MessageBoxImage.Information);
            }

            
        }

        private void btnAnnuler_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult reponse = MessageBox.Show("Voulez-vous quitter l'application?",
                    "Attention", MessageBoxButton.YesNo, MessageBoxImage.Question);
          
            if (reponse == MessageBoxResult.Yes)
            {
                Application.Current.Shutdown();
            }
        }
    }
}
