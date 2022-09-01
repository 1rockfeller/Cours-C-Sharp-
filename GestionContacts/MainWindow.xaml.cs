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

namespace GestionContacts
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string nomUtilisateur = "admin";
        string motdePasse = "admin";  

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnValider_Click(object sender, RoutedEventArgs e)
        {
            //traitement : verifier si les 2 champs sont remplis
            
            
            if(txtNomUtilisateur.Text != "" && txtMotdepasse.Password != "")
            {
                if(nomUtilisateur == txtNomUtilisateur.Text && motdePasse == txtMotdepasse.Password)
                {
                    // traitement si le nom d'utilisateur est correct

                    //Ouverture d'une page 

                    Page2 page = new Page2();
                    page.Show();

                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Informations incorrectes");
                }
            }
            else
            {
                // traitement si les champs ne sont pas remplis
                MessageBox.Show("Les champs doivent être remplis");
            }
            
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
