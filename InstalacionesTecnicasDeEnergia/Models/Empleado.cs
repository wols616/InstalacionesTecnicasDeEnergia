using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace InstalacionesTecnicasDeEnergia.Models
{
    internal class Empleado
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("nombres")]
        public string Nombres { get; set; }

        [BsonElement("apellidos")]
        public string Apellidos { get; set; }

        [BsonElement("dui")]
        public string Dui { get; set; }

        [BsonElement("direccion")]
        public string Direccion { get; set; }

        [BsonElement("telefono_celular")]
        public string TelefonoCelular { get; set; }

        [BsonElement("telefono_casa")]
        public string TelefonoCasa { get; set; }

        [BsonElement("correo")]
        public string Correo { get; set; }

        [BsonElement("tipo_contrato")]
        public string TipoContrato { get; set; }

        [BsonElement("fecha_contratacion")]
        public string FechaContratacion { get; set; }

        [BsonElement("fecha_despido")]
        public string FechaDespido { get; set; }

        [BsonElement("salario")]
        public string Salario { get; set; }

        [BsonElement("comentarios_personales")]
        public string ComentariosPersonales { get; set; }



    }
}
