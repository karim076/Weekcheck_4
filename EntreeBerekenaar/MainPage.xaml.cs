using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace EntreeBerekenaar
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var park = 0;
            if (int.TryParse(tbAantalKinderen.Text, out int aantalKinderen) == false)
            {
                tbAantalKinderen.Text = "aantal kinderen is ongeldig";
                return;
            }
            if (tbAantalVolwassenen.Text == "")
            {
                tbAantalVolwassenen.Text = "aantal Volwassenen is ongeldig";
            }
            int tbPriceAdult = int.Parse(tbAantalVolwassenen.Text) * 8;
            int tbPriceKids = int.Parse(tbAantalKinderen.Text) * 4;
            int tbTotal = tbPriceAdult + tbPriceKids;
            //	Doe hier ook de andere checks of de invoer juist is
            if (yes.IsChecked == true)
            {
                park += 5;
                return;
            }
            else
            {
                park = 0;
            }

            if (int.Parse(kortingPercentage.Text) > 100)
            {
                kortingPercentage.Text = "Er bestaat geen precentage boven het 100%";
            }
            double total = tbTotal + park;
            double eindBedrag = total / 100 * int.Parse(kortingPercentage.Text);


            // Hier komt de berekening van het eindbedrag
            end.Text = $"{eindBedrag}";
            tbAantalKinderen.Text = $"{eindBedrag}";

        }
    }
}
