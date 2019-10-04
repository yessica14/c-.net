using System;

namespace CoreEscuela.Entidades
{
    public class Curso
    {
        public string UniqueId{get;private set;}
        public string nombre{get;set;}
        public TiposJornada Jornada {get; set;}

        public Curso(string nombre, TiposJornada Jornada){
            UniqueId=Guid.NewGuid().ToString();
            this.nombre=nombre;
            this.Jornada=Jornada;
           
        }
        public override string ToString(){
         return $"UniqueId{UniqueId}, nombre{nombre}, \n TiposJornada{Jornada}";
        }

        

    }
}