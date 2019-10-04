using System;
using CoreEscuela.Entidades;

namespace ETAPA1
{
    class Program
    {
        static void Main(string[] args)
        {
            var Escuela= new Escuela("federalismo argentino",2012,"argentina", "san miguel de tucuman");
            Escuela.tipoEscuela=TipoEscuela.Primaria;
            Console.WriteLine("el nombre de la escuela es:"+Escuela.ToString());
            var Curso=new Curso("matematica",TiposJornada.mañana);
            Console.WriteLine(Curso);
        }
    }
}
