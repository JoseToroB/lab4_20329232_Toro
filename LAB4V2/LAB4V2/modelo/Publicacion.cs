using System;
using System.Collections.Generic;
using System.Text;

namespace modelo
{
    /// <summary>
    /// la clase publicacion tiene las caracteristicas de una publicacion
    /// </summary>
    public class Publicacion
    {
        //Atributos
        private static int idContador = 0;
        private List<Comentario> comentarios;
        private string contenido;
        private string fecha;
        private string tipo;
        private Usuario autor;
        private int id;
        private int likes;
        private List<string> et;

        //Constructor
        /// <summary>
        /// Constructor de una pregunta, recibe un titulo, contenido y lista de etiquetas para la pregunta.
        /// </summary>
        public Publicacion(Usuario autor, string contenido, List<string> et,string tipo)
        {
            this.contenido = contenido;
            this.autor = autor;
            this.likes = 0;
            this.comentarios = new List<Comentario>();
            this.et = new List<string>();
            idContador += 1;
            this.id = idContador;
            this.et = et;
            this.tipo = tipo;
            //conseguir la fecha mediante datetime
            DateTime fecha = DateTime.Now;
            this.fecha = fecha.ToString("dd'/'MM'/'yyyy");
        }
        //Getters y Setters
        /// <value> Devuelve o setea el valor del contador autoincremental </value>
        public static int IdContador { get => idContador; set => idContador = value; }
        /// <value> Devuelve o setea la lista de comentarios </value>
        public List<Comentario> Comentarios { get => comentarios; set => comentarios = value; }
        /// <value> Devuelve o setea el contenido  </value>
        public string Contenido { get => contenido; set => contenido = value; }
        /// <value> Devuelve o setea la fecha </value>
        public string Fecha { get => fecha; set => fecha = value; }
        /// <value> Devuelve o setea al Autor  </value>
        public Usuario Autor { get => autor; set => autor = value; }
        /// <value> Devuelve o setea el id  </value>
        public int Id { get => id; set => id = value; }
        /// <value> Devuelve o setea los likes </value>
        public int Likes { get => likes; set => likes = value; }
        /// <value> devuelve o sete el tipo </value>

        public string Tipo { get => tipo; set => tipo = value; }
    }
}