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
        //NO PONER ESTO EN ESTATICOOOOOOO
        public IMongoCollection<Empleado> EmpleadoDb { get; set; }
        public IMongoCollection<TipoContrato_Empleado_> TipoEmpleadoDb { get; set; }

        public IMongoCollection<Material> MaterialDb { get; set; }
        public IMongoCollection<CategoriaMaterial> CategoriaMaterialDb { get; set; }
        public IMongoCollection<Bitacora> BitacoraDb { get; set; }
        public IMongoCollection<ManoObra> ManoObraDb { get; set; }
        public IMongoCollection<CategoriaManoObra> CategoriaManoObraDb { get; set; }
        public IMongoCollection<Trabajo> TrabajoDb { get; set; }
        public IMongoCollection<Asistencia> AsistenciaDb { get; set; }

        public Conexion()
        {
            var client = new MongoClient("mongodb://localhost:27017");
            var db = client.GetDatabase("ITEDB");


            EmpleadoDb = db.GetCollection<Empleado>("Empleado");
            MaterialDb = db.GetCollection<Material>("Material");
            CategoriaMaterialDb = db.GetCollection<CategoriaMaterial>("CategoriaMaterial");
            BitacoraDb = db.GetCollection<Bitacora>("Bitacora");
            ManoObraDb = db.GetCollection<ManoObra>("ManoObra");
            CategoriaManoObraDb = db.GetCollection<CategoriaManoObra>("CategoriaManoObra");
            TrabajoDb = db.GetCollection<Trabajo>("Trabajo");
            TipoEmpleadoDb = db.GetCollection<TipoContrato_Empleado_>("TipoContratoEmpleado");
            AsistenciaDb = db.GetCollection<Asistencia>("Asistencia");
        }


    }
}
