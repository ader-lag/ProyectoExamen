using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Source.Models
{
    public static class DBConnection
    {
        public static IMongoDatabase Connect()
        {
            var client = new MongoClient("mongodb+srv://reptando:71859304@cluster0-nsnhc.mongodb.net/test?retryWrites=true&w=majority");
            return client.GetDatabase("ProyectoVotaciones");
        }
    }
}
