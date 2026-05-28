namespace CombustivelSimples
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                double etanol = Convert.ToDouble(txtEtanol.Text);
                double gasolina = Convert.ToDouble(txtGasolina.Text);

                string marca = txtMarca.Text;
                string modelo = txtModelo.Text;

                string msg;

                if (etanol <= gasolina * 0.7)
                {
                    msg = $"O etanol está compensando para o seu {marca} {modelo}";
                }
                else
                {
                    msg = $"A gasolina está compensando para o seu {marca} {modelo}";
                }

                await DisplayAlertAsync("Resultado", msg, "OK");
            }
            catch
            {
                await DisplayAlertAsync("Erro", "Preencha corretamente!", "OK");
            }
        }
    }
}