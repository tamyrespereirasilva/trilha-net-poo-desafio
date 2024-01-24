namespace DesafioPOO.Models
{
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei, int memoria, Dictionary<string, string> contatos) : base(numero, modelo, imei, memoria, contatos)
        {
            
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            List<string> appIphone = new List<string> {"Facebook", "X", "Zoom"};

            if (appIphone.Contains(nomeApp))
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
