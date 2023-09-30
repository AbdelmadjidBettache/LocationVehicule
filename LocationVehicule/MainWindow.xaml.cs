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

namespace LocationVehicule
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string prenom="", nom="", sexe ="Masculin", type="", cat="A";

        private void btnValider_Click(object sender, RoutedEventArgs e)
        {
            prenom=txtPrenom.Text;
            nom=txtNom.Text;   
            
            if(!string.IsNullOrEmpty(prenom) && !string.IsNullOrEmpty(nom))
            {
                if (rbtnF.IsChecked==true)
                {
                    sexe = "Féminin";
                }
                if (rbtnB.IsChecked == true)
                {
                    cat = "B";
                }
                else if (rbtnC.IsChecked == true)
                {
                    cat = "C";
                }
                if(rbntBerline.IsChecked == true)
                {
                    type = " Berline";
                }

                if (rbtnCoupe.IsChecked == true)
                {
                    type = "Coupé";
                }
                else if (rbtnFamiliale.IsChecked == true)
                {
                    type = "Familiale";
                }

                txtAffiche.Text = "Le client est de sexe: "+ sexe+ " son nom est : "
                    +nom + " son prenom: "+prenom+ " La categorie de sa voiture: "+
                    cat + " elle est de type: "+type;
                if(type == "Berline")
                {
                    image.Source = new BitmapImage(new Uri(@"/berline.jpg", UriKind.Relative));
                }
                else if (type == "Coupé")
                {
                    image.Source = new BitmapImage(new Uri(@"/coupe.jpg", UriKind.Relative));
                }
                else
                {
                    image.Source = new BitmapImage(new Uri(@"/familiale.jpg", UriKind.Relative));
                }

            }
            else
            {
                MessageBox.Show("Le nom et le prenom sont requis", 
                    "Attention", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        public MainWindow()
        {
            InitializeComponent();
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void btnReset_Click(object sender, RoutedEventArgs e)
        {
            txtNom.Text=string.Empty;
            txtPrenom.Text=string.Empty;
            txtAffiche.Text=string.Empty;

            rbtnM.IsChecked = true;
            rbtnF.IsChecked = false;

            rbtnA.IsChecked = true;
            rbtnB.IsChecked = false;
            rbtnC.IsChecked = false;

            rbntBerline.IsChecked = true;
            rbtnCoupe.IsChecked = false;
            rbtnFamiliale.IsChecked = false;

            image.Source = null; 
           

        }
    }
}
