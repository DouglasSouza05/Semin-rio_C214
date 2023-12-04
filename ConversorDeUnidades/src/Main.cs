using System;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        var conn = new Conn();

        // Exemplo de utilização do método InsertOneAsync
        var conversao = new Conversao
        {
            Unidade = "Metro para Quilômetro",
            Numero = 100,
            Resposta = 0.1
        };

        await conn.InsertOneAsync(conversao);

        // Outras operações podem ser realizadas aqui

        // Console.WriteLine("Operações concluídas. Pressione qualquer tecla para sair.");
        // Console.ReadKey();
    }
}

public class Conversao
{
    public string Unidade { get; set; }
    public double Numero { get; set; }
    public double Resposta { get; set; }
}
