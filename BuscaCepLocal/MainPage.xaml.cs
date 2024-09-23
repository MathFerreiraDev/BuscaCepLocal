using BuscaCepLocal.Model;
using BuscaCepLocal.Services;

namespace BuscaCepLocal
{
    public partial class MainPage : ContentPage
    {
        

        public MainPage()
        {
            InitializeComponent();
        }

       

        private async  void   Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                Endereco? dados_endereco = await DataServiceCep.GetEnderecoByCep(txt_cep.Text);
                BindingContext = dados_endereco;
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops", ex.Message, "OK");
            }
        }

        
    }

}
