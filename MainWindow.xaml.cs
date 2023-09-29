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

namespace Wpf_Quentin_Vernaison_TP1
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int N1 = 0;
        int N2 = 0;
        int Max = 0;
        double Taille = 0;
        double Poid = 0;
        double IMC = 0;
        int NombreX = 0;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Btn01_Click(object sender, RoutedEventArgs e)
        {
            N1 = int.Parse(TBN01.Text);
            N2 = int.Parse(TBN02.Text);
            if (N1 > N2)
                Max = N1;
            else
                Max = N2;
            TBMax.Text = Max.ToString();


        }

        private void BTN02_Click(object sender, RoutedEventArgs e)
        {
            Taille = double.Parse(TBTaille.Text);
            Poid = double.Parse(TBPoid.Text);

            double IMC = Poid / (Taille * Taille);

            if (IMC < 18)
            {
                TBImc.Text = "Mince.";
            }
            else if (IMC >= 18 && IMC < 25)
            {
                TBImc.Text = "En bonne santé.";
            }
            else if (IMC >= 25 && IMC < 30)
            {
                TBImc.Text = "Quelques kilos en trop.";
            }
            else
            {
                TBImc.Text = "Obèse.";



            }
        }

        private void Btn03_Click(object sender, RoutedEventArgs e)
        {
            
            for (NombreX = 0; NombreX < 16; NombreX++)
                    if (NombreX % 2 == 0)
            {
                        TBPairImpaire.AppendText(NombreX + " est pair"+ Environment.NewLine); 
            }
                    else
            {
                        TBPairImpaire.AppendText(NombreX + " est impair" + Environment.NewLine); 

                    
                }
        }
    }
}
