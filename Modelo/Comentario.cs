using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo
{
    /// <summary>
    /// La clase Comentario contiene todas las caracteristicas de un comentario
    /// </summary>
    public class Comentario
    {
        //Atributos
        private static int idContador = 0;
        private Usuario autor;
        private string fecha;
        private string contenido;
        private int id;
        private int likes;
        private List<Comentario> comentarios;

        //Constructor
        /// <summary>
        /// Constructor de una respuesta, recibe el contenido a publicar.
        /// </summary>
        public Comentario(Usuario autor,string contenido)
        {
            this.autor = autor;
            this.contenido = contenido;
            idContador += 1;
            this.id = idContador;
            this.likes = 0;
            this.comentarios = new List<Comentario>();
            //obtener fecha
            DateTime fecha = DateTime.Now;
            this.fecha = fecha.ToString("dd'/'MM'/'yyyy");
        }

        //Getters y setters
        /// <value> Devuelve o setea el valor del contador autoincremental </value>
        public static int IdContador { get => idContador; set => idContador = value; }
        /// <value> Devuelve o setea al autor </value>
        public Usuario Autor { get => autor; set => autor = value; }
        /// <value> Devuelve o setea la fecha  </value>
        public string Fecha { get => fecha; set => fecha = value; }
        /// <value> Devuelve o setea el contenido </value>
        public string Contenido { get => contenido; set => contenido = value; }
        /// <value> Devuelve o setea el id </value>
        public int Id { get => id; set => id = value; }
        /// <value> Devuelve o setea los likes </value>
        public int Likes { get => likes; set => likes = value; }
        /// <value> Devuelve o setea la lista de comentarios </value>
        public List<Comentario> Comentarios { get => comentarios; set => comentarios = value; }
    }
}
