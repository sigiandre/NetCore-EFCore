using System.ComponentModel;
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using System.Linq;

namespace LeerData
{
    class Program
    {
        static void Main(string[] args)
        {
            using(var db = new AppVentaCursosContext()){
                var cursoAlgebra = new Curso{
                    Titulo = "Curso Algebra",
                    Descripcion = "Curso Basico de matematica"
                };
                db.Add(cursoAlgebra);

                var cursoLenguaje = new Curso {
                    Titulo = "Curso Lenguaje",
                    Descripcion = "Lengua Española"
                };
                db.Add(cursoLenguaje);
                
                var estadoTransaccion = db.SaveChanges();
                Console.WriteLine("Estado de Transaccion MYSQL ===>" + estadoTransaccion);
            }
        }
    }
}
