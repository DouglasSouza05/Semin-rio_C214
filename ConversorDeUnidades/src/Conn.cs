using MongoDB.Driver;
using System;
using System.Threading.Tasks;

public class Conn
{
    private IMongoCollection<Conversao> GetCollection()
    {
        var server = new MongoServerAddress(host: "172.16.0.14", port: 27017);
        var credentials = MongoCredential.CreateCredential(
            databaseName: "admin",
            username: "test",
            password: "test"
        );
        var mongodbClientSettings = new MongoClientSettings
        {
            Credential = credentials,
            Server = server,
            ConnectionMode = ConnectionMode.Standalone,
            ServerSelectionTimeout = TimeSpan.FromSeconds(3)
        };
        MongoClient dbClient = new MongoClient(mongodbClientSettings);

        var database = dbClient.GetDatabase("Conversion");
        var collection = database.GetCollection<Conversao>("Conversoes"); // "Conversoes" é o nome da coleção
        return collection;
    }

    public async Task InsertOneAsync(Conversao conversao)
    {
        await GetCollection().InsertOneAsync(conversao);
    }
}
