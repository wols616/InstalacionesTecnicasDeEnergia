using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace InstalacionesTecnicasDeEnergia.Models
{
    internal class ManoObra
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("nombre")]
        public string Nombre { get; set; }

        [BsonElement("categoria_id")]
        [BsonRepresentation(BsonType.ObjectId)]
        public string CategoriaId { get; set; }

        [BsonElement("descripcion")]
        public string Descripcion { get; set; }

        [BsonElement("precio")]
        public Double Precio { get; set; }

    }
}
