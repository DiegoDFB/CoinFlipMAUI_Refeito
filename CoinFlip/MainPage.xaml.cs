namespace CoinFlip
{
    public partial class MainPage : ContentPage
    {
      
        public MainPage()
        {
            InitializeComponent();
        }

        private void GirarButton_Clicked (object sender, EventArgs e)
        {
            //Pegar oque o usuário selecionou no picker
            //Girar a moeda (Sortear o lado que "caiu" a moeda) 0 = cara e 1 = coroa
            //Comparar o que o usuário selecionou e o que foi sorteado
            //Exibir se ele venceu ou se perdeu
            //Trocar a imagem

            string resultado;
            string ladoSelecionado = SelecaoPicker.SelectedItem.ToString();
            string ladoSorteado = new Random().Next(2).ToString();
            if(ladoSorteado == "0")
            {
                ladoSorteado = "cara";
                MoedaImage.Source = ladoSorteado + ".png";

            }
            else
            {
                ladoSorteado = "coroa";
                MoedaImage.Source = ladoSorteado + ".png";

            }

            if (ladoSelecionado == ladoSorteado)
            {
               resultado = "Parábens, você venceu!";
            }
            else
            {
               resultado = "Que pena, você perdeu!";
            }
            ResultadoLabel.Text = resultado;
        }

    }
}