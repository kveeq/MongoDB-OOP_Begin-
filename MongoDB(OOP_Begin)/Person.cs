using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;

namespace MongoDB_OOP_Begin_
{
    class Person
    {
        [BsonId]
        [BsonIgnoreIfDefault]
        public ObjectId _id { get; set; }
        [BsonElement]
        public string Name { get; set; }
        [BsonElement]
        public int Age { get; set; }
        [BsonElement]
        public string Addres { get; set; }

        public Person(string name, int age, string addres)
        {
            Name = name;
            Age = age;
            Addres = addres;
        }

        public void Add(Person person)
        {
            MongoClient client = new MongoClient(); // чтобы подключится к серверу надо передать в качестве аргумента {uri}
            var db = client.GetDatabase("Persons");
            var collection = db.GetCollection<Person>("person");
            collection.InsertOne(person);
        }

        public static List<Person> TakeList()
        {
            MongoClient client = new MongoClient();
            var db = client.GetDatabase("Persons");
            var collection = db.GetCollection<Person>("person");
            List<Person> lst = collection.AsQueryable().ToList();
            return lst;
        }
    }
}
