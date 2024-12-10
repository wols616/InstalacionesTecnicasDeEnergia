using InstalacionesTecnicasDeEnergia.Models;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstalacionesTecnicasDeEnergia
{
    internal class Conexion
    {
        public MongoClient client;
        public IMongoDatabase db;

        public static IMongoCollection<Empleado> EmpleadoDb { get; set; }
        public static IMongoCollection<Material> MaterialDb { get; set; }
        public static IMongoCollection<CategoriaMaterial> CategoriaMaterialDb { get; set; }
        public static IMongoCollection<Bitacora> BitacoraDb { get; set; }
        public static IMongoCollection<ManoObra> ManoObraDb { get; set; }
        public static IMongoCollection<Trabajo> TrabajoDb { get; set; }

        public Conexion()
        {
            client = new MongoClient("mongodb://localhost:27017");
            db = client.GetDatabase("ITEDB");


            EmpleadoDb = db.GetCollection<Empleado>("Empleado");
            MaterialDb = db.GetCollection<Material>("Material");
            CategoriaMaterialDb = db.GetCollection<CategoriaMaterial>("CategoriaMaterial");
            BitacoraDb = db.GetCollection<Bitacora>("Bitacora");
            ManoObraDb = db.GetCollection<ManoObra>("ManoObra");
            TrabajoDb = db.GetCollection<Trabajo>("Trabajo");
        }


    }
}
