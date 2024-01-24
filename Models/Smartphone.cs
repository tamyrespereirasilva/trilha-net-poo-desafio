namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        protected string Modelo { get; set; }
        protected string IMEI { get; set; }
        protected int Memoria { get; set; }
        protected Dictionary<string, string> Contatos { get; set; }
     

        public Smartphone(string numero, string modelo, string imei, int memoria, Dictionary<string, string> contatos)
        {
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
            Contatos = contatos;
            
        }

        public void Ligar()
        {
            Console.WriteLine("Digite o número: ");
            string numeroContato = Console.ReadLine();
        
            if (Contatos.ContainsKey(numeroContato)) {
                string nomeContato = Contatos[numeroContato];
                Console.WriteLine($"Ligando para {nomeContato}...");
            }
            else
            {
                Console.WriteLine($"Ligando para {numeroContato}...");
            } 
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}