using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploEntityFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            using (SampleEntityFramework db = new SampleEntityFramework())
            {
                //                      AGREGAR REGISTRO CON ENTITY // 

                //Gente xGente = new Gente();
                //xGente.nombre = "Martina";
                //xGente.edad = 22;
                //xGente.idSexo = 1;
                //db.Gente.Add(xGente);
                //db.SaveChanges();

                //                         EDIT REGISTRO CON ENTITY
                //Gente oGente = db.Gente.Where(d => d.nombre == "Martina").First();

                //oGente.edad = 55;

                //                         DELETE REGISTRO CON ENTITY

                //db.Entry(oGente).State = System.Data.Entity.EntityState.Modified;
                //db.SaveChanges();

                Gente oGente = db.Gente.Find(6);
                db.Gente.Remove(oGente);
                db.SaveChanges();

                var lst = db.Gente;
                foreach (var oGente_ in lst)
                {
                    Console.WriteLine(oGente_.nombre);
                }
            }
            Console.ReadLine();

        }
    }
}
