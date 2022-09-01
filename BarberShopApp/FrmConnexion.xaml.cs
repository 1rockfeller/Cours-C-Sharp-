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

namespace BarberShopApp
{
    
    /// <summary>
    /// Interaction logic for FrmConnexion.xaml
    /// </summary>
    public partial class FrmConnexion : Window
    {
        

        public FrmConnexion()
        {
            InitializeComponent();
        }

        private void btnValider_Click(object sender, RoutedEventArgs e)
        {
            int nb1 = 2;
            int nb2 = 3;
            decimal somme;

            //AffichageDeMessage();


            somme = CalculSomme(nb1, nb2);

            txtPseudo.Text =  ":a somme est :" +somme;
            
        }

        private void chkResterConnecter_Checked(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show("Vous allez rester connectés .... Déclenché depuis un evenment");
            txtPseudo.Text = "Coco";
        }
        
       

        private void txtMotdepasse_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Key == Key.Enter)
            {
                //AffichageDeMessage();
            }
        }

        //visibilite typederetour NomFonction(params sil y a )
        //{

        //}

        

        public decimal CalculSomme(decimal nombre1, decimal nombre2)
        {
            return nombre1 + nombre2;
        }


        public void AffichageDeMessage()
        {
            if (chkResterConnecter.IsChecked == true)
            {
                MessageBox.Show("Vous alez rester connectés ");
            }
            else
            {
                MessageBox.Show("Vous allez vous deconnecter ");
            }
        }

    }
}
