using System;
using Npgsql;

class Program
{
    static void Main()
    {
        // Substitua as variáveis abaixo com suas informações
        string host = "localhost"; // ou o IP do seu contêiner Docker
        string database = "BANCO_PADRAO";
        string username = "TesteInatel";
        string password = "senhateste123";
        int port = 5432; // Porta padrão do PostgreSQL

        // String de conexão
        string connString = $"Host={host};Username={username};Password={password};Database={database};Port={port}";

        // Instância da conexão
        using (NpgsqlConnection conn = new NpgsqlConnection(connString))
        {
            conn.Open(); // Abre a conexão

            // Insira os dados de exemplo no banco de dados
            InserirDados(conn, "Metro", "Polegada", 2.54, 5.08); // Exemplo de conversão de 2.54 metros para polegadas

            // Exiba os dados do banco de dados
            MostrarDados(conn);
        }
    }

    // Método para inserir dados
    static void InserirDados(NpgsqlConnection conn, string medida1, string medida2, double valor, double resultado)
    {
        using (NpgsqlCommand cmd = new NpgsqlCommand())
        {
            cmd.Connection = conn;
            cmd.CommandText = "INSERT INTO conversoes (medida1, medida2, valor, resultado) VALUES (@medida1, @medida2, @valor, @resultado)";

            // Parâmetros
            cmd.Parameters.AddWithValue("medida1", medida1);
            cmd.Parameters.AddWithValue("medida2", medida2);
            cmd.Parameters.AddWithValue("valor", valor);
            cmd.Parameters.AddWithValue("resultado", resultado);

            // Executa a consulta
            cmd.ExecuteNonQuery();
        }
    }

    // Método para exibir dados
    static void MostrarDados(NpgsqlConnection conn)
    {
        using (NpgsqlCommand cmd = new NpgsqlCommand("SELECT * FROM sua_tabela", conn))
        {
            using (NpgsqlDataReader reader = cmd.ExecuteReader())
            {
                Console.WriteLine("Medida1\tMedida2\tValor\tResultado");
                while (reader.Read())
                {
                    Console.WriteLine($"{reader.GetString(1)}\t{reader.GetString(2)}\t{reader.GetDouble(3)}\t{reader.GetDouble(4)}");
                }
            }
        }
    }
}
