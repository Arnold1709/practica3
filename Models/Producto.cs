using System.ComponentModel.DataAnnotations;

namespace practica3.Models
{
   public class Producto
    {
        [Required]
        public int Id {get; set; }
        [Required]
        public string NomProducto {get;set; }
        [Required]
        public string Foto {get;set; }
        [Required]
        public string  Descripcion {get; set;}
        [Required]
        public string  Precio {get;set;}
       [Required]
        public string Celular {get;set;}
        [Required]
       public string Lugar {get;set;}
       [Required]

       public string Nombre {get;set;}
        public Categoria Categoria {get;set;}

        public int CategoriaId {get;set; }
    }


    
}