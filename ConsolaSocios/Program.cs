using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logica;

namespace ConsolaSocios
{
    public class Program
    {
        static void Main(string[] args)

        {
            Principal principal = new Principal(); 
            Socio user = new Socio();
            user.dni = 44632196;
            user.nombre = "santiago";
            user.apellido = "quiroga";
            user.fechaNac = new DateTime(2003, 03, 26);
            user.telefono = 3493426629;
            user.idSocio = 12434;
            user.direccion = "montalbetti 1558";


            principal.AltaSocio(user);
            
        }
        
    }
}
