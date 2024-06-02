namespace Ejercicio4
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            // Obtener el número ingresado
            int numero = Convert.ToInt32(Num.Text);

            // Calcular el cuadrado y el cubo del número
            int cuadrado = numero * numero;
            int cubo = numero * numero * numero;

            // Mostrar los resultados en los labels
            Cuadrado.Text = $"El cuadrado de {numero} es: {cuadrado}";
            Cubo.Text = $"El cubo de {numero} es: {cubo}";
        }
    }

}
