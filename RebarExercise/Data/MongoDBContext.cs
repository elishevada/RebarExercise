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
		
		public IMongoCollection<Shake> Shakes => _database.GetCollection<Shake>("shakes");
		public IMongoCollection<Order> Orders => _database.GetCollection<Order>("orders");
		//public IMongoCollection<Account> Accounts => _database.GetCollection<Account>("accounts");


	}

}
