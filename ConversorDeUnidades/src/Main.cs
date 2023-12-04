using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;


class Program
{
    static void Main()
    {
        var databaseName = "admin";
        const string connectionString = "mongodb://test:test@mongodb:27017/admin";
        string collectionName = "conversoes";

        var client = new MongoClient(connectionString);

        var database = client.GetDatabase(databaseName);
        var collection = database.GetCollection<Conversao>(collectionName);

        InserirDados(collection, "Metro", "Polegada", 2.54, 5.08);
        MostrarDados(collection);
    }

    static void InserirDados(IMongoCollection<Conversao> collection, string medida1, string medida2, double valor, double resultado)
    {
        var conversao = new Conversao
        {
            Medida1 = medida1,
            Medida2 = medida2,
            Valor = valor,
            Resultado = resultado
        };

        collection.InsertOne(conversao);
    }

    // Método para exibir dados
    static void MostrarDados(IMongoCollection<Conversao> collection)
    {
        var conversoes = collection.Find(_ => true).ToList();

        Console.WriteLine("Medida1\tMedida2\tValor\tResultado");
        foreach (var conversao in conversoes)
        {
            Console.WriteLine($"{conversao.Medida1}\t{conversao.Medida2}\t{conversao.Valor}\t{conversao.Resultado}");
        }
    }
}

class Conversao
{

    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string Id { get; set; }
    public string Medida1 { get; set; }
    public string Medida2 { get; set; }
    public double Valor { get; set; }
    public double Resultado { get; set; }
}
