using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.ComponentModel.DataAnnotations.Schema;

namespace Compliance.Domain.Models
{
    [Table("Payment")]
    public class Payment
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [JsonProperty("id")]
        public int ID { get; set; }
        
        [JsonProperty("description")]
        [Column("Description")]
        public string Description { get; set; }

        [JsonProperty("due")]
        public DateTime? Due { get; set; }

        [JsonProperty("ammount")]
        public decimal Ammount { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }
}