using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;
using Tavisca.Tripster.Contracts;
using Tavisca.Tripster.Contracts.DatabaseSettings;
using Tavisca.Tripster.Data.Models;

namespace Tavisca.Tripster.Data.UnitOfWork
{
    public class TripUnitOfWork
    {
        private IMongoDatabase _database;
        private BaseRepository<Trip> _trips;
        private string _collectionName;

        public TripUnitOfWork(IDatabaseSettings databaseSettings)
        {
            var client = new MongoClient(databaseSettings.ConnectionString);
            _database = client.GetDatabase(databaseSettings.DatabaseName);
            _collectionName = databaseSettings.CollectionName;
        }

        public BaseRepository<Trip> Trips
        {
            get
            {
                if (_trips == null) _trips = new BaseRepository<Trip>(_database, _collectionName);
                return _trips;
            }
        }
    }
}
