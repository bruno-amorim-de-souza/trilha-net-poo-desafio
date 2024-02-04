namespace DesafioPOO.Models
{
    // (TODO: Herdar da classe "Smartphone") OK
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
        }

        // (TODO: Sobrescrever o método "InstalarAplicativo") OK
        public override void InstalarAplicativo(string nomeApp)
        {
            System.Console.WriteLine($"O aplicativo {nomeApp} está sendo instalado");;
        }
    }
}