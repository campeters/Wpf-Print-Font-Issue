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

namespace WpfPrintApp
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

        public void PrintItAll()
        {
            var printDialog = new PrintDialog();
            if (printDialog.ShowDialog() == true)
            {
                var fontFamily = new FontFamily("Arial");
                var printme = new TextBlock { FontSize = 11, FontFamily = fontFamily, Width = 800, TextWrapping = TextWrapping.Wrap, Text = "L'autre personne était incapable de prendre soin des enfants en raison d'une déficience des fonctions physiques ou mentales qui l'a obligée, durant une période d'au moins deux semaines, à garder le lit, à se déplacer en fauteuil roulant ou à recevoir des soins dans un hôpital ou un établissement semblable. Joignez un certificat du médecin traitant qui confirme la nature et la durée de la déficience." };
                printDialog.PrintVisual(printme, "Test Print");
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            PrintItAll();
        }
    }
}
