using DesafioPOO.Models;

Dictionary<string, string> agenda = new Dictionary<string, string>
{
    {"1111-1111", "João"},
    {"2222-2222", "José"},
    {"3333-3333", "Ananda"}
};
Smartphone nokia = new Nokia(numero: "4444-4444", modelo: "Modelo 1", imei: "111111111", memoria: 64, contatos: agenda);
Console.WriteLine("## INICIANDO NOKIA ##");
nokia.Ligar();
Console.WriteLine("\n");
nokia.ReceberLigacao();
Console.WriteLine("\n");
Console.WriteLine("Digite o nome do aplicativo: ");
string aplicativoNokia = Console.ReadLine();
nokia.InstalarAplicativo(aplicativoNokia);

Console.WriteLine("\n");

Smartphone iphone = new Iphone(numero: "2222-3333", modelo: "Modelo 2", imei: "222222222", memoria: 128, contatos: agenda);
Console.WriteLine("## INICIANDO IPHONE ##");
iphone.Ligar();
Console.WriteLine("\n");
iphone.ReceberLigacao();
Console.WriteLine("\n");
Console.WriteLine("Digite o nome do aplicativo: ");
string aplicativoIphone = Console.ReadLine();
iphone.InstalarAplicativo(aplicativoIphone);