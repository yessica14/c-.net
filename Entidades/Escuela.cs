namespace CoreEscuela.Entidades
{
    class Escuela{
        public string nombre{ get;set; } 
        public int AñodeCreacion{ get;set; }
        public string pais { get; set;}
        public string ciudad {get; set;}
        public TipoEscuela tipoEscuela{get; set;}
        

        public Escuela(string nombre, int AñodeCreacion, string pais,string ciudad){
            this.nombre=nombre;
            this.AñodeCreacion=AñodeCreacion;
            this.pais=pais;
            this.ciudad=ciudad;

        }

        public override string ToString(){
         return $"nombre{nombre}, tipoEscuela{tipoEscuela}, \n pais{pais}, ciudad{ciudad}";
        }

    }
}