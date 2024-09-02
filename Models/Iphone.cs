namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
        }

        // TODO: Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo (string nomeApp)
        {
            Console.WriteLine($"Instalando aplicativo {nomeApp} na AppStore");
            AplicativosInstalados.Add(nomeApp);
        }

        public override void LerAplicativosInstalados()
        {
            Console.WriteLine("Aplicativos instalados na AppStore:");
            foreach (var app in AplicativosInstalados)
            {
                Console.WriteLine(app);
            }
        }
    }
}