namespace DesafioPOO.Models
{
<<<<<<< HEAD
=======
    
>>>>>>> 7535a1472d7fb3288ed5a3b06c29c6ce2b6b8c34
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string imei, int memoria, Dictionary<string, string> contatos) : base(numero, modelo, imei, memoria, contatos)
        {
        }

<<<<<<< HEAD
=======
        
>>>>>>> 7535a1472d7fb3288ed5a3b06c29c6ce2b6b8c34
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
