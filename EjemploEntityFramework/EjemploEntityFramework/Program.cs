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
            // INSERT MASIVO CON ENTITY

            int numeroLotes = 5000;
            Random rand = new Random();
            using (SampleEntityFramework db = new SampleEntityFramework())
            {
                for (int i=0; i <10000; i++)
                {
                    var oGente = new Gente();
                    oGente.edad = i;
                    oGente.nombre = $"Nombre {i}";
                    oGente.idSexo = rand.Next(1, 4);

                    db.Gente.Add(oGente);

                    if (i % numeroLotes == 0)
                        db.SaveChanges();
                }
                db.SaveChanges();




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
                //db.Entry(oGente).State = System.Data.Entity.EntityState.Modified;
                //db.SaveChanges();

                //                         DELETE REGISTRO CON ENTITY
                //Gente oGente = db.Gente.Find(6);
                //db.Gente.Remove(oGente);
                //db.SaveChanges();





                //var lst = db.Gente;
                //foreach (var oGente_ in lst)
                //{
                //    Console.WriteLine(oGente_.nombre);
                //}
            }
            Console.ReadLine();

        }
    }
}
