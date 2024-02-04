namespace DesafioPOO.Models
{
    // (TODO: Herdar da classe "Smartphone") OK
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
        }

        // (TODO: Sobrescrever o método "InstalarAplicativo") OK
        public override void InstalarAplicativo(string nomeApp)
        {
            System.Console.WriteLine($"O aplicativo {nomeApp} foi instalado com sucesso!");;
        }
    }
}