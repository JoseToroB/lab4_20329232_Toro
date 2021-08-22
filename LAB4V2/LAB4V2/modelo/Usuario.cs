using System;
using System.Collections.Generic;
using System.Text;

namespace modelo
{
    /// <summary>
    /// La clase Usuario contiene todas las caracteristicas que tiene un usuario.
    /// </summary>
    public class Usuario
    {
        //Atributos
        private string username;
        private string password;
        private List<Publicacion> publisRealizadas;
        private List<Comentario> comentariosRealizados;
        private List<string> seguidos;
        private List<Compartidas> publisCompartidas;

        //Constructor
        /// <summary>
        /// Constructor de un Usuario, recibe el nombre de usuario y contraseña del nuevo usuario.
        /// </summary>
        public Usuario(string username, string password)
        {
            this.username = username;
            this.password = password;
            this.publisRealizadas = new List<Publicacion>();

            this.publisCompartidas = new List<Compartidas>();

            this.comentariosRealizados = new List<Comentario>();

            this.seguidos = new List<string>();
        }

        //Getter y Setters
        /// <value> Devuelve o setea el nombre del usuario </value>
        public string Username { get => username; set => username = value; }
        /// <value> Devuelve o setea la contraseña del usuario </value>
        public string Password { get => password; set => password = value; }
        /// <value> Devuelve o setea la lista de preguntas  </value>
        public List<Publicacion> PublisRealizadas { get => publisRealizadas; set => publisRealizadas = value; }
        /// <value> Devuelve o setea la lista de respuestas </value>
        public List<Comentario> ComentariosRealizados { get => comentariosRealizados; set => comentariosRealizados = value; }
        /// <value> Devuelve o setea los seguidos </value>
        public List<string> Seguidos { get => seguidos; set => seguidos = value; }
        /// <value> Devuelve o setea las compartidas </value>
        public List<Compartidas> PublisCompartidas { get => publisCompartidas; set => publisCompartidas = value;}
    }
}
