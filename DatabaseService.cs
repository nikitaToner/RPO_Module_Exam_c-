using Npgsql;
using System;
using System.Data;
using Serilog;
using DotNetEnv;

namespace MediTrack
{
    public class DatabaseService
    {
        private readonly string _connectionString;

        public DatabaseService()
        {
            // Чтение из .env (если пакет подключен)
            Env.Load();
            var host = DotNetEnv.Env.GetString("DB_HOST");
            var port = DotNetEnv.Env.GetString("DB_PORT");
            var db = DotNetEnv.Env.GetString("DB_NAME");
            var user = DotNetEnv.Env.GetString("DB_USER");
            var pass = DotNetEnv.Env.GetString("DB_PASSWORD");
             if (host == null || port == null || db == null || user == null || pass == null)
             {
                 Log.Warning("Некоторые переменные окружения не найдены!\nОбратитесь к ПО админу");
                 return; 
             }
            _connectionString = $"Host={host};Port={port};Database={db};Username={user};Password={pass};";
        }

        public DataTable GetMedications()
        {
            var table = new DataTable();
            try
            {
                using var conn = new NpgsqlConnection(_connectionString);
                conn.Open();
                Log.Information("Успешное подключение к базе данных PostgreSQL.");
                
                using var cmd = new NpgsqlCommand("SELECT * FROM medications", conn);
                using var adapter = new NpgsqlDataAdapter(cmd);
                adapter.Fill(table);
            }
            catch (Exception ex)
            {
                //нельзя такое
                //System.Windows.MessageBox.Show("Произошла ошибка при загрузке данных.");
                Log.Error($"Произошла ошибка при загрузке данных. ({ex})");
            }
            return table;
        }
    }
}
