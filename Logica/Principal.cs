using System.Collections.Generic;
using System.Linq;
using System.Xml.Serialization;

namespace Logica
{
    public class Principal
    {
        List<Socio> ListaSocios = new List<Socio>();
        List<Profesor> ListaProfesores = new List<Profesor>();
        List<Actividad> ListaActividades = new List<Actividad>();
        List<Elemento> ListaElemento = new List<Elemento>();
        PersistenciaDeDatos InstanciaPersistenciaDeDatos = new PersistenciaDeDatos();
        
        public void RellenarLista()
        {
            ListaSocios = InstanciaPersistenciaDeDatos.LeerArchivoSocio();
            ListaElemento = InstanciaPersistenciaDeDatos.LeerArchivoElemento();
            ListaActividades = InstanciaPersistenciaDeDatos.LeerArchivoActividad();
            ListaProfesores = InstanciaPersistenciaDeDatos.LeerArchivoProfesor();
        }
        public List<Socio> ValidarSocio()                                                            
        {
            ListaSocios = InstanciaPersistenciaDeDatos.LeerArchivoSocio();
            if (ListaSocios == null)
            {
                ListaSocios = new List<Socio>();

            }
                return ListaSocios;
        }
        public List<Profesor> ValidarProfesor()
        {
            ListaProfesores = InstanciaPersistenciaDeDatos.LeerArchivoProfesor();
            if (ListaProfesores == null)
            {
                ListaProfesores = new List<Profesor>();

            }

            return ListaProfesores;

        }
        public List<Actividad> ValidarActividad()
        {
            ListaActividades = InstanciaPersistenciaDeDatos.LeerArchivoActividad();
            if (ListaActividades == null)
            {
                ListaActividades = new List<Actividad>();

            }

            return ListaActividades;
        }
        public List<Elemento> ValidarElemento()
        {
            ListaElemento = InstanciaPersistenciaDeDatos.LeerArchivoElemento();
            if (ListaElemento == null)
            {
                ListaElemento = new List<Elemento>();

            }


            return ListaElemento;

        }
        public List<Socio> BuscarSocioPorDni(int dni)
        {
            List<Socio> nuevaListaSocio = new List<Socio>();
            ListaSocios = ValidarSocio();
            if(ListaSocios == null)
            {
                return nuevaListaSocio;
            }else
            {
                var SocioObtenido = ListaSocios.Find(x => dni == x.dni);
                nuevaListaSocio.Add(SocioObtenido);
                return nuevaListaSocio;
            }

        }
        public List<Profesor> BuscarProfesorPorDni(int dni)
        {
            List<Profesor> nuevaListaProfesor = new List<Profesor>();
            ListaProfesores = ValidarProfesor();
            if(ListaProfesores == null)
            {
                return nuevaListaProfesor;
                
            }else
            {
                var ProfesorObtenido = ListaProfesores.Find(x => dni == x.dni);
                nuevaListaProfesor.Add(ProfesorObtenido);
                return nuevaListaProfesor;
            }
        }
        public List<Elemento> BuscarElementoPorNombre(string nombre)
        {
            List<Elemento> nuevaListaElemento = new List<Elemento>();
            ListaElemento = ValidarElemento();
            if(ListaElemento == null)
            {
                return nuevaListaElemento;
            }else
            {
                var ElementoObtenido = ListaElemento.Find(x => nombre == x.nombre);
                nuevaListaElemento.Add(ElementoObtenido);
                return nuevaListaElemento;
            }
        }
        public List<Actividad> BuscarActividadPorNombre(string nombre)
        {
            List<Actividad> nuevaListaActividad = new List<Actividad>();
            ListaActividades = ValidarActividad();
            if(ListaActividades == null)
            {
                return nuevaListaActividad;

            }else
            {
                var ActividadObtenida = ListaActividades.Find(x => nombre == x.nombre);
                nuevaListaActividad.Add(ActividadObtenida);
                return nuevaListaActividad;
            }
        }
        public void AltaSocio(Socio socioNuevo)
        {
            Socio nuevoSocio = new Socio();
            ListaSocios = ValidarSocio();
            if (ListaSocios.Count == 0)
            {
                int IDSocio = ListaSocios.Count;
                IDSocio = IDSocio + 1;
                nuevoSocio.idSocio = IDSocio;
            }else
            {
                int IDSocio = ListaSocios.Count;
                IDSocio = IDSocio + 1;
                nuevoSocio.idSocio = IDSocio;
            }
            nuevoSocio.nombre = socioNuevo.nombre;
            nuevoSocio.apellido = socioNuevo.apellido;
            nuevoSocio.fechaNac = socioNuevo.fechaNac;
            nuevoSocio.direccion = socioNuevo.direccion;
            nuevoSocio.tipoDoc = socioNuevo.tipoDoc;
            nuevoSocio.dni = socioNuevo.dni;
            nuevoSocio.activo = socioNuevo.activo;
            nuevoSocio.telefono = socioNuevo.telefono;
            ListaSocios.Add(nuevoSocio);
            InstanciaPersistenciaDeDatos.GuardarArchivoSocio(ListaSocios);
            

        }
        public void AltaProfesor(Profesor profesorNuevo)
        {
            Profesor nuevoProfesor = new Profesor();
            ListaProfesores = ValidarProfesor();
            if (ListaProfesores.Count == 0)
            {
                int idProfesor = ListaProfesores.Count;
                idProfesor = idProfesor + 1;
                nuevoProfesor.idProfesor = idProfesor;
            }
            else
            {
                int idProfesor = ListaActividades.Count;
                idProfesor = idProfesor + 1;
                nuevoProfesor.idProfesor = idProfesor;
            }
            nuevoProfesor.dni = profesorNuevo.dni;
            nuevoProfesor.nombre = profesorNuevo.nombre;
            nuevoProfesor.apellido = profesorNuevo.apellido;
            
            nuevoProfesor.fechaNac = profesorNuevo.fechaNac;
            nuevoProfesor.telefono = profesorNuevo.telefono;
            nuevoProfesor.correoElec = profesorNuevo.correoElec;
            nuevoProfesor.activo = true;
            nuevoProfesor.tipoDoc = profesorNuevo.tipoDoc;
            
            ListaProfesores.Add(nuevoProfesor);
            InstanciaPersistenciaDeDatos.GuardarArchivoProfesor(ListaProfesores);

        }
        public void AltaActividad(Actividad actividadNuevo)
        {
            Actividad nuevoActividad = new Actividad();
            ListaActividades = ValidarActividad();
            if (ListaActividades.Count == 0)
            {
                int idActividad = ListaActividades.Count;
                idActividad = idActividad + 1;
                nuevoActividad.idActividad = idActividad;
            }
            else
            {
                int idActividad = ListaActividades.Count;
                idActividad = idActividad + 1;
                nuevoActividad.idActividad = idActividad;
            }
            
            nuevoActividad.nombre = actividadNuevo.nombre;
            nuevoActividad.profesor = actividadNuevo.profesor;
            nuevoActividad.horarioInicio = actividadNuevo.horarioInicio;
            nuevoActividad.horarioFin = actividadNuevo.horarioFin;
            ListaActividades.Add(nuevoActividad);
            InstanciaPersistenciaDeDatos.GuardarArchivoActividad(ListaActividades);

        }
        public void AltaElemento(Elemento elementoNuevo)
        {
            
            Elemento nuevoElemento = new Elemento();
            ListaElemento = ValidarElemento();
            if (ListaElemento.Count == 0)
            {
                int idElemento = ListaElemento.Count;
                idElemento = idElemento + 1;
                nuevoElemento.idElemento = idElemento;
            }
            else
            {
                int idElemento = ListaElemento.Count;
                idElemento = idElemento + 1;
                nuevoElemento.idElemento = idElemento;
            }
            
            nuevoElemento.nombre = elementoNuevo.nombre;
            nuevoElemento.cantidad = elementoNuevo.cantidad;
            ListaElemento.Add(nuevoElemento);
            InstanciaPersistenciaDeDatos.GuardarArchivoElemento(ListaElemento);
        }
        public void ModificarSocio(Socio socioNuevo, int idSocio)
        {
            var socioModficado = ListaSocios.Find(s => s.idSocio == idSocio);
            socioModficado.nombre = socioNuevo.nombre;
            socioModficado.idSocio = idSocio;
            socioModficado.apellido = socioNuevo.apellido;
            socioModficado.fechaNac = socioNuevo.fechaNac;
            socioModficado.dni = socioNuevo.dni;
            socioModficado.direccion = socioNuevo.direccion;
            socioModficado.telefono = socioNuevo.telefono;
            var socioDesactualizado = ListaSocios.Find(x => idSocio == x.idSocio);
            ListaSocios.Remove(socioDesactualizado);
            ListaSocios.Add(socioModficado);
            
            InstanciaPersistenciaDeDatos.GuardarArchivoSocio(ListaSocios);



        }
        public void ModificarProfesor(Profesor profesorNuevo, int idProfesor)
        {
            var profesorModificado = ListaProfesores.Find(x => idProfesor == x.idProfesor);
            profesorModificado.idProfesor = idProfesor;
            profesorModificado.dni = profesorNuevo.dni;
            profesorModificado.apellido = profesorNuevo.apellido;
            profesorModificado.nombre = profesorNuevo.nombre;
            profesorModificado.correoElec = profesorNuevo.correoElec;
            profesorModificado.fechaNac = profesorNuevo.fechaNac;
            profesorModificado.telefono = profesorNuevo.telefono;
            var profesorDesactualizado = ListaProfesores.Find(x => x.idProfesor == idProfesor);
            ListaProfesores.Remove(profesorDesactualizado);
            ListaProfesores.Add(profesorModificado);

            InstanciaPersistenciaDeDatos.GuardarArchivoProfesor(ListaProfesores);
        }
        public void ModificarActividad(Actividad actividadNueva, int idActividad)
        {
            var actividadModificada = ListaActividades.Find(x => idActividad == x.idActividad);
            actividadModificada.idActividad = idActividad;
            actividadModificada.nombre = actividadNueva.nombre;
            actividadModificada.profesor = actividadNueva.profesor;
            actividadModificada.horarioInicio = actividadNueva.horarioInicio;
            actividadModificada.horarioFin = actividadNueva.horarioFin;
            var actividadDesactualizada = ListaActividades.Find(x => x.idActividad == x.idActividad);
            ListaActividades.Remove(actividadDesactualizada);
            ListaActividades.Add(actividadModificada);
            InstanciaPersistenciaDeDatos.GuardarArchivoActividad(ListaActividades);
        }
        public void ModificarElemento(Elemento elementoNuevo, int idElemento)
        {
            var elementoModificado = ListaElemento.Find(x => x.idElemento == idElemento);
            elementoModificado.nombre = elementoNuevo.nombre;
            elementoModificado.idElemento = idElemento;
            elementoModificado.cantidad = elementoNuevo.cantidad;
            var elementoDesactualizado = ListaElemento.Find(x => x.idElemento == x.idElemento);

            ListaElemento.Remove(elementoDesactualizado);
            ListaElemento.Add(elementoModificado);
            InstanciaPersistenciaDeDatos.GuardarArchivoElemento(ListaElemento);
        }
        public void BajaSocio(int idSocio)
        {
            ListaSocios = ValidarSocio();
            var socioBaja = ListaSocios.Find(x => x.idSocio == idSocio);
            socioBaja.activo = false;
            InstanciaPersistenciaDeDatos.GuardarArchivoSocio(ListaSocios);
        }
        public void BajaProfesor(int idProfesor)
        {
            ListaProfesores = ValidarProfesor();
            var profesorBaja = ListaProfesores.Find(x => x.idProfesor == idProfesor);
            profesorBaja.activo = false;
            InstanciaPersistenciaDeDatos.GuardarArchivoProfesor(ListaProfesores);
        }
        public void BajaActividad(int idActividad)
        {
            ListaActividades = ValidarActividad();
            var actividadEliminada = ListaActividades.Find(x => x.idActividad == idActividad);
            ListaActividades.Remove(actividadEliminada);
            InstanciaPersistenciaDeDatos.GuardarArchivoActividad(ListaActividades);


        }
        public void BajaElemento(int idElemento)
        {
            ListaElemento = ValidarElemento();
            var elementoEliminado = ListaElemento.Find(x => x.idElemento == idElemento);
            ListaElemento.Remove(elementoEliminado);
            InstanciaPersistenciaDeDatos.GuardarArchivoElemento(ListaElemento);
        }
        public void NuevoAltaSocio(int idSocio)
        {
            ListaSocios = ValidarSocio();
            var socioNuevo = ListaSocios.Find(x =>x.idSocio == idSocio);
            socioNuevo.activo = true;
            InstanciaPersistenciaDeDatos.GuardarArchivoSocio(ListaSocios);
        }
        public void NuevoAltaProfesor(int idProfesor)
        {
            ListaProfesores = ValidarProfesor();
            var profesorNuevo = ListaProfesores.Find(x => x.idProfesor == idProfesor);
            profesorNuevo.activo = true;
            InstanciaPersistenciaDeDatos.GuardarArchivoProfesor(ListaProfesores);
        }
        
    }

}
