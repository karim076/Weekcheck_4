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
            //	Doe hier ook de andere checks of de invoer juist is
            if (yes.IsChecked == true)
            {
                park += 5;
            }

            if (int.Parse(kortingPercentage.Text) > 100)
            {
                kortingPercentage.Text = "Er bestaat geen precentage boven het 100%";
            }
            // Hier komt de berekening van het eindbedrag
            int tbPriceAdult = int.Parse(tbAantalVolwassenen.Text) * 8;
            int tbPriceKids = int.Parse(tbAantalKinderen.Text) * 4;
            int tbTotal = tbPriceAdult + tbPriceKids;
            decimal total = tbTotal + park;
            decimal korting = total / 100 * int.Parse(kortingPercentage.Text);
            decimal eindBedrag = total - korting;
            string.Format("{0:0.00}", eindBedrag);
            if (notEmpty.SelectedIndex == -1)
            {
                end.Text = "Aub kies uit standaard of luxe";
                return;
            }
            else
            {
                end.Text = $"{eindBedrag}";
            }
        }
    }
}
