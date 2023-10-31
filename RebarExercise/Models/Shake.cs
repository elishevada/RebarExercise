﻿using MongoDB.Bson.Serialization.Attributes;
using System.Drawing;

namespace RebarExercise.Models
{
    //public record ShakeBasicDetails(string Name, string Description);
    public class Shake
	{
        [BsonId]
        public Guid MenuShakeId { get; }= Guid.NewGuid();
        //public ShakeBasicDetails ShakeBasicDetails { get; set; }
        [BsonElement("name")]
        public string Name { get; set; }= string.Empty;
        [BsonElement("description")]
        public string Description { get; set; }=string.Empty;

        [BsonElement("priceL")]
        public decimal PriceL { get; set; }
        [BsonElement("priceM")]
        public decimal PriceM { get; set; }
        [BsonElement("priceS")]
        public decimal PriceS { get; set; }
        //public Shake()
        //{
        //    MenuShakeId = Guid.NewGuid();
        //}

	}
}
