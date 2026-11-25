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

namespace RejestrWynagrodzenWPF
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

        private void btn_Click(object sender, RoutedEventArgs e)
        {
            float pay;
            float zusTax;
            float healthTax;
            float pitTax;
            
            float.TryParse(wynagrodzenie.Text, out pay);

            if (pay > 0)
            {
                zusTax = pay*0.1371f;
                healthTax = (pay - zusTax) * 0.09f;
                if (ulga.IsChecked == true)
                    pitTax = 0;
                else
                    pitTax = (pay - zusTax) * 0.12f;
                
                WynagrodzenieNetto.Text = "Wynagrodzenie netto: " + (pay-zusTax-healthTax-pitTax).ToString() + "PLN";
                zus.Text = "Składki ZUS (społeczne): " + (zusTax).ToString() + "PLN";
                zdrowotna.Text =

            }
        }
    }
}