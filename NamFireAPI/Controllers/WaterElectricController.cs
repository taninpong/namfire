using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
using NamFireAPI.Models;

namespace NamFireAPI.Controllers
{
    [Route("api/[controller]/[action]/")]
    [ApiController]
    public class WaterElectricController : ControllerBase
    {
        IMongoCollection<Building> BuildingCollection { get; set; }
        IMongoCollection<Level> LevelCollection { get; set; }
        IMongoCollection<Room> RoomCollection { get; set; }

        public WaterElectricController()
        {
            var settings = MongoClientSettings.FromUrl(new MongoUrl("mongodb://admin:p123456@ds243812.mlab.com:43812/demo"));
            settings.SslSettings = new SslSettings()
            {
                EnabledSslProtocols = SslProtocols.Tls12
            };
            var mongoClient = new MongoClient(settings);
            var database = mongoClient.GetDatabase("demo");
            BuildingCollection = database.GetCollection<Building>("Building");
            LevelCollection = database.GetCollection<Level>("Level");
            RoomCollection = database.GetCollection<Room>("Room");
        }
        [HttpGet]
        public IEnumerable<Building> GetAllBuilding()
        {
            var buildingAll = BuildingCollection.Find(bl => true).ToList();
            return buildingAll;
        }

        [HttpGet]
        public IEnumerable<Level> GetAllLevel()
        {
            var levelAll = LevelCollection.Find(bl => true).ToList();
            return levelAll;
        }

        [HttpGet]
        public IEnumerable<Room> GetAllRoom()
        {
            var roomAll = RoomCollection.Find(bl => true).ToList();
            return roomAll;
        }

        [HttpPost]
        public void AddBuilding([FromBody]Building newBuilding)
        {
            newBuilding.id = Guid.NewGuid().ToString();
            BuildingCollection.InsertOne(newBuilding);
        }

        [HttpPost]
        public void AddLevel([FromBody]Level newLevel)
        {
            newLevel.id = Guid.NewGuid().ToString();
            LevelCollection.InsertOne(newLevel);
        }

        [HttpPost]
        public void AddRoom([FromBody]Room newRoom)
        {
            newRoom.id = Guid.NewGuid().ToString();
            RoomCollection.InsertOne(newRoom);
        }

        [HttpGet("{id}")]
        public IEnumerable<Building> GetBuilding(string id)
        {
            var getBuilding = BuildingCollection.Find(it => it.id == id).ToList();
            return getBuilding;
        }

        [HttpGet("{id}")]
        public IEnumerable<Level> GetLevel(string id)
        {
            var getLevel = LevelCollection.Find(it => it.id == id).ToList();
            return getLevel;
        }

        [HttpGet("{id}")]
        public IEnumerable<Room> GetRoom(string id)
        {
            var getRoom = RoomCollection.Find(it => it.id == id).ToList();
            return getRoom;
        }
    }
}
