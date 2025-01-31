using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstalacionesTecnicasDeEnergia.Models
{
    internal class Asistencia
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("empleado_id")]
        [BsonRepresentation(BsonType.ObjectId)]
        public string EmpleadoId { get; set; }

        [BsonElement("fecha")]
        public DateTime Fecha { get; set; } = DateTime.Now;

        [BsonElement("estado")]
        public string Estado { get; set; } // "Presente", "Tarde", "Ausente"
    }
}
