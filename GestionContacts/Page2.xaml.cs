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

namespace GestionContacts
{
    /// <summary>
    /// Interaction logic for Page2.xaml
    /// </summary>
    public partial class Page2 : Window
    {
        public Page2()
        {
            InitializeComponent();
        }

        private void btnEnregistrer_Click(object sender, RoutedEventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtNom.Text) || string.IsNullOrWhiteSpace(txtPrenom.Text) || string.IsNullOrWhiteSpace(txtTelephone.Text))
            {
                MessageBox.Show("Remplissez tous les champs !");
            }
            else
            {
                txtListeContacts.Text = txtListeContacts.Text + "\n" + txtNom.Text + " " + txtPrenom.Text +  " " + txtTelephone.Text;
                //txtListeContacts.Text += txtNom.Text + " " + txtPrenom.Text +  " " + txtTelephone.Text;

                // vider les champs 

                txtNom.Text = string.Empty;
                txtPrenom.Text = string.Empty;
                txtTelephone.Text = string.Empty;
            }
        }
    }
}
