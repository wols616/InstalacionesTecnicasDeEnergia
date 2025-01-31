using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;


namespace InstalacionesTecnicasDeEnergia.Models
{
    internal class Material
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("nombre")]
        public string Nombre { get; set; }

        [BsonElement("categoria_id")]
        [BsonRepresentation(BsonType.ObjectId)]
        public string CategoriaId { get; set; }

        [BsonElement("marca")]
        public string Marca { get; set; }

        [BsonElement("precio_compra")]
        public double PrecioCompra { get; set; }
        [BsonElement("precio_venta")]
        public double PrecioVenta { get; set; }

        [BsonElement("descripcion")]
        public string Descripcion { get; set; }

        [BsonElement("cantidad")]
        public int Cantidad { get; set; }

        [BsonElement("fecha_compra")]
        public String FechaCompra  { get;  set;}

        //private String _fechaCompra;

    }
}


