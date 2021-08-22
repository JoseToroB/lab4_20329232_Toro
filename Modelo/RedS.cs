using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo
{
    /// <summary>
    /// La clase RS contiene las caracteristicas de la red social
    /// </summary>
    public class RedS
    {
        //Atributos
        private List<Publicacion> publis;
        private List<Usuario> usuarios;
        private List<Comentario> comentarios;
        private Usuario usuarioConectado;
        private bool conectado = false;

        //Constructor
        /// <summary>
        /// Constructor de un Stack, inicializa listas para almacenar datos.
        /// </summary>
        public RedS()
        {
            this.publis = new List<Publicacion>();
            this.usuarios = new List<Usuario>();
            this.comentarios = new List<Comentario>();
        }

        //Getters y Setters
        /// <value> Devuelve o setea la lista de preguntask </value>
        public List<Publicacion> Publis { get => publis; set => publis= value; }
        /// <value> Devuelve o setea la lista de usuarios  </value>
        public List<Usuario> Usuarios { get => usuarios; set => usuarios = value; }
        /// <value> Devuelve o setea al usuario conectado </value>
        public Usuario UsuarioConectado { get => usuarioConectado; set => usuarioConectado = value; }
        /// <value> Devuelve o setea el valor de si hay alguien conectado  </value>
        public bool Conectado { get => conectado; set => conectado = value; }
        /// <value> Devuelve o setea la lista de comentarios</value>
        public List<Comentario> Comentarios { get => comentarios; set => comentarios = value; }
    }
}
