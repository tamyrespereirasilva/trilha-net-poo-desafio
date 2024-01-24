namespace DesafioPOO.Models
{
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string imei, int memoria, Dictionary<string, string> contatos) : base(numero, modelo, imei, memoria, contatos)
        {
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            List<string> appNokia = new List<string> {"Instagram", "Telegram", "Whatsapp"};

            if (appNokia.Contains(nomeApp))
            {
                Console.WriteLine($"Aplicativo {nomeApp} instalado com sucesso.");
            }
            else
            {
                Console.WriteLine($"O aplicativo {nomeApp} não está disponível no momento.");
            }
        }
    }
}