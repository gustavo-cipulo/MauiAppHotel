
namespace MauiAppHotel.Views
{
    public partial class ContratacaoHospedagem : ContentPage
    {
        public ContratacaoHospedagem()
        {
            InitializeComponent();
        }

        private async void Sobre_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Sobre());
        }

        private async void Avancar_Clicked(object sender, EventArgs e)
        {
            if (stp_adultos.Value < 1)
            {
                await DisplayAlertAsync("Atenção",
                    "Selecione pelo menos um adulto.", "OK");
                return;
            }

            if (pck_quarto.SelectedIndex == -1)
            {
                await DisplayAlertAsync("Atenção",
                    "Selecione uma suíte.", "OK");
                return;
            }

            if (dtpck_checkout.Date <= dtpck_checkin.Date)
            {
                await DisplayAlertAsync("Atenção",
                    "O check-out deve ser depois do check-in.", "OK");
                return;
            }

            await Navigation.PushAsync(new HospedagemContratada());
        }
    }
}
