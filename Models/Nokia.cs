namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
        }

        // TODO: Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo (string nomeApp)
        {
            Console.WriteLine($"Instalando aplicativo {nomeApp} na OviStore");
            AplicativosInstalados.Add(nomeApp);
        }

        public override void LerAplicativosInstalados()
        {
            Console.WriteLine("Aplicativos instalados OviStore:");
            foreach (var app in AplicativosInstalados)
            {
                Console.WriteLine(app);
            }
        }
    }
}