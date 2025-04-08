namespace Quiz
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void BtnCiencia_Clicked(object sender, EventArgs e)
        {
            Navigation
                .PushAsync
                (new Pergunta());
        }
    }
}
