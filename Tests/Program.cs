using Newtonsoft.Json.Linq;
using RestSharp;


Console.WriteLine("Press Any key to Start");

Console.WriteLine("Numero de repeticiones");
int num = Convert.ToInt32(Console.ReadLine());
var bandera = 1;
do
{

    for (int i = 0; i < num; i++)
    {
        var client = new RestClient("https://localhost:44330/frontoffice/MassSignature/CallBack");
        //var client = new RestClient("https://pruebas.firmaseguro.co/frontoffice/MassSignature/CallBack");
        var request = new RestRequest();
        request.Method = Method.Post; 
        request.AlwaysMultipartFormData = true;
        request.AddParameter("processId", "12291");
        client.ExecuteAsync(request);
        Console.WriteLine($"repetición # {i}");
    }
    Console.WriteLine("Desea repetir el ciclo 1. si");
    bandera = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Numero de repeticiones");
    num = Convert.ToInt32(Console.ReadLine());
} while (bandera == 1);


