using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace Logica
{
    public class PersistenciaDeDatos
    {
        readonly string RutaListaSocio = @"C:\repo\BitBucket\Socios\Socios.txt";
        readonly string RutaListaProfesor = @"C:\repo\BitBucket\Socios\Profesores.txt";
        readonly string RutaListaElemento = @"C:\repo\BitBucket\Socios\Elementos.txt";
        readonly string RutaListaActividad = @"C:\repo\BitBucket\Socios\Actividades.txt";

        public void InicializarArchivos()
        {
            if (!File.Exists(RutaListaSocio))
            {
                File.Create(RutaListaSocio).Close();
            }
            if (!File.Exists(RutaListaActividad))
            {
                File.Create(RutaListaActividad).Close();
            }
            if (!File.Exists(RutaListaElemento))
            {
                File.Create(RutaListaElemento).Close();
            }
            if (!File.Exists(RutaListaProfesor))
            {
                File.Create(RutaListaProfesor).Close();
            }
        }
        public List<Socio> LeerArchivoSocio()
        {
            string locationFile = RutaListaSocio;
            using(StreamReader reader = new StreamReader(locationFile))
            {
                string contenido = reader.ReadToEnd();
                List<Socio> ListaSocios = JsonConvert.DeserializeObject<List<Socio>>(contenido);
                return ListaSocios;
            }
        }
        public List<Profesor> LeerArchivoProfesor()
        {
            string locationFile = RutaListaProfesor;
            using (StreamReader reader = new StreamReader(locationFile))
            {
                string contenido = reader.ReadToEnd();
                List<Profesor> ListaProfesores = JsonConvert.DeserializeObject<List<Profesor>>(contenido);
                return ListaProfesores;
            }
        }
        public List<Elemento> LeerArchivoElemento()
        {
            string locationFile = RutaListaElemento;
            using (StreamReader reader = new StreamReader(locationFile))
            {
                string contenido = reader.ReadToEnd();
                List<Elemento> ListaElementos = JsonConvert.DeserializeObject<List<Elemento>>(contenido);
                return ListaElementos;
            }
        }
        public List<Actividad> LeerArchivoActividad()
        {
            string locationFile = RutaListaActividad;
            using (StreamReader reader = new StreamReader(locationFile))
            {
                string contenido = reader.ReadToEnd();
                List<Actividad> ListaActividad = JsonConvert.DeserializeObject<List<Actividad>>(contenido);
                return ListaActividad;
            }
        }
        public void GuardarArchivoSocio(List<Socio>ListaSocios)
        {
            string locationFile = RutaListaSocio;
            using (StreamWriter writer = new StreamWriter(locationFile,false))
            {
                string contenido = JsonConvert.SerializeObject(ListaSocios);
                writer.Write(contenido);
            }
        }
        public void GuardarArchivoProfesor(List<Profesor> ListaProfesores)
        {
            string locationFile = RutaListaProfesor;
            using (StreamWriter writer = new StreamWriter(locationFile, false))
            {
                string contenido = JsonConvert.SerializeObject(ListaProfesores);
                writer.Write(contenido);
            }
        }
        public void GuardarArchivoElemento(List<Elemento> ListaElementos)
        {
            string locationFile = RutaListaElemento;
            using (StreamWriter writer = new StreamWriter(locationFile, false))
            {
                string contenido = JsonConvert.SerializeObject(ListaElementos);
                writer.Write(contenido);
            }
        }
        public void GuardarArchivoActividad(List<Actividad> ListaActividades)
        {
            string locationFile = RutaListaActividad;
            using (StreamWriter writer = new StreamWriter(locationFile, false))
            {
                string contenido = JsonConvert.SerializeObject(ListaActividades);
                writer.Write(contenido);
            }
        }

    }
}
