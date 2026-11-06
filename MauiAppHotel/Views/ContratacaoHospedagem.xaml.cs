
using MauiAppHotel.Models;

namespace MauiAppHotel.Views
{
    public partial class ContratacaoHospedagem : ContentPage
    {
        public ContratacaoHospedagem()
        {
            InitializeComponent();

            App propriedadesApp = (App)Application.Current!;

            pck_quarto.ItemsSource = propriedadesApp.lista_quartos;

            DateTime hoje = DateTime.Today;

            dtpck_checkin.MinimumDate = hoje;
            dtpck_checkin.MaximumDate = hoje.AddMonths(1);
            dtpck_checkin.Date = hoje;

            dtpck_checkout.MinimumDate = hoje.AddDays(1);
            dtpck_checkout.MaximumDate = hoje.AddMonths(6);
            dtpck_checkout.Date = hoje.AddDays(1);
        }

        private void dtpck_checkin_DateSelected(
            object sender, DateChangedEventArgs e)
        {
            DateTime dataCheckin = e.NewDate ?? DateTime.Today;

            dtpck_checkout.MinimumDate =
                dataCheckin.AddDays(1);

            dtpck_checkout.MaximumDate =
                dataCheckin.AddMonths(6);

            DateTime dataCheckout =
                dtpck_checkout.Date ?? dataCheckin.AddDays(1);

            if (dataCheckout < dtpck_checkout.MinimumDate)
            {
                dtpck_checkout.Date =
                    dtpck_checkout.MinimumDate;
            }
            else if (dataCheckout > dtpck_checkout.MaximumDate)
            {
                dtpck_checkout.Date =
                    dtpck_checkout.MaximumDate;
            }
        }

        private async void Avancar_Clicked(
            object sender, EventArgs e)
        {
            if (stp_adultos.Value < 1)
            {
                await DisplayAlertAsync(
                    "Atenção",
                    "Selecione pelo menos um adulto.",
                    "OK");
                return;
            }

            if (pck_quarto.SelectedItem is not Quarto)
            {
                await DisplayAlertAsync(
                    "Atenção",
                    "Selecione uma suíte.",
                    "OK");
                return;
            }

            DateTime checkin =
                dtpck_checkin.Date ?? DateTime.Today;

            DateTime checkout =
                dtpck_checkout.Date ?? DateTime.Today;

            if (checkout <= checkin)
            {
                await DisplayAlertAsync(
                    "Atenção",
                    "O check-out deve ser depois do check-in.",
                    "OK");
                return;
            }

            await Navigation.PushAsync(
                new HospedagemContratada());
        }

        private async void Sobre_Clicked(
            object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Sobre());
        }
    }
}
