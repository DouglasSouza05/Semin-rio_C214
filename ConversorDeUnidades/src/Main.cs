using System;
using MongoDB.Driver;

class Program
{
    static void Main()
    {
        // Defina as credenciais
        var username = "root";
        var password = "root";
        var databaseName = "admin";
        // Substitua as variáveis abaixo com suas informações admin:pass
        const string connectionString = "mongodb://root:root@mongodb-1:27017/admin"; // ou o endereço do seu contêiner Docker MongoDB
        string collectionName = "conversoes";

        // Criar cliente MongoDB
        var client = new MongoClient(connectionString);

        // Obter referência do banco de dados e coleção
        // var database = client.GetDatabase(databaseName);
        // var collection = database.GetCollection<Conversao>(collectionName);

        // Insira os dados de exemplo no banco de dados
        // InserirDados(collection, "Metro", "Polegada", 2.54, 5.08); // Exemplo de conversão de 2.54 metros para polegadas

        // Exiba os dados do banco de dados
        // MostrarDados(collection);
    }

    // // Método para inserir dados
    // static void InserirDados(IMongoCollection<Conversao> collection, string medida1, string medida2, double valor, double resultado)
    // {
    //     var conversao = new Conversao
    //     {
    //         Medida1 = medida1,
    //         Medida2 = medida2,
    //         Valor = valor,
    //         Resultado = resultado
    //     };

    //     collection.InsertOne(conversao);
    // }

    // Método para exibir dados
    // static void MostrarDados(IMongoCollection<Conversao> collection)
    // {
    //     var conversoes = collection.Find(_ => true).ToList();

    //     Console.WriteLine("Medida1\tMedida2\tValor\tResultado");
    //     foreach (var conversao in conversoes)
    //     {
    //         Console.WriteLine($"{conversao.Medida1}\t{conversao.Medida2}\t{conversao.Valor}\t{conversao.Resultado}");
    //     }
    // }
}

// Definição de classe para representar os dados de conversão
// class Conversao
// {
//     public string Medida1 { get; set; }
//     public string Medida2 { get; set; }
//     public double Valor { get; set; }
//     public double Resultado { get; set; }
// }
