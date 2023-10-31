using MongoDB.Driver;
using RebarExercise.Models;

namespace RebarExercise.Data
{
	public class MongoDBContext
	{
		private readonly IMongoDatabase _database;

		public MongoDBContext(string connectionString, string databaseName)
		{
			var client = new MongoClient(connectionString);
			_database = client.GetDatabase(databaseName);
		}

		public IMongoCollection<MenuShake> MenuShakes => _database.GetCollection<MenuShake>("menuShakes");
	}
}
