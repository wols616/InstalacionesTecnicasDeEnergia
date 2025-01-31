using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace InstalacionesTecnicasDeEnergia.Models
{
    public class Trabajo
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }



        [BsonElement("nombre_cliente")]
        public string NombreCliente { get; set; }

        [BsonElement("descripcion_proyecto")]
        public string DescripcionProyecto { get; set; }

        [BsonElement("lugar")]
        public string Lugar { get; set; }

        [BsonElement("fecha")]
        public DateTime Fecha { get; set; }

        [BsonElement("presupuesto")]
        public double Presupuesto { get; set; }

        [BsonElement("estado")]
        public string Estado { get; set; }

        [BsonElement("materiales")]
        public List<MaterialUsado> Materiales { get; set; } = new List<MaterialUsado>();

        [BsonElement("mano_obra")]
        public List<ManoObraUsada> ManoObra { get; set; } = new List<ManoObraUsada>();

        [BsonElement("encargados")]
        public List<Encargado> Encargados { get; set; } = new List<Encargado>();

    }

    public class MaterialUsado
    {
        [BsonElement("material_id")]
        [BsonRepresentation(BsonType.ObjectId)]
        public string MaterialId { get; set; }

        [BsonElement("cantidad")]
        public int Cantidad { get; set; }
    }

    public class ManoObraUsada
    {
        [BsonElement("mano_obra_id")]
        [BsonRepresentation(BsonType.ObjectId)]
        public string ManoObraId { get; set; }

        [BsonElement("cantidad")]
        public int Cantidad { get; set; }
    }

    public class Encargado
    {
        [BsonElement("empleado_id")]
        [BsonRepresentation(BsonType.ObjectId)]
        public string EmpleadoId { get; set; }

    }
}
