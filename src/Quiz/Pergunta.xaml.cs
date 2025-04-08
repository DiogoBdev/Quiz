namespace Quiz;

public partial class Pergunta : ContentPage
{
	public Pergunta()
	{
		InitializeComponent();
	}

    private void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
    {
		DisplayAlert("Immes", "Quiz", "Fechar");
    }
}