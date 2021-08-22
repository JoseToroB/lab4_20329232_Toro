using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Control
{
    /// <summary>
    /// La clase Controlador contiene toda la lógica del programa, usa al Modelo y es usado por Vista.
    /// </summary>
    public class Controlador
    {
        //Atributos
        private RedS redS;//utiliza una red social
        private bool cargado;
        private static Controlador instancia;

        //Constructor
        /// <summary>
        /// Constructor de controlador, crea una instancia de RS
        /// </summary>
        public Controlador()
        {
            this.redS = new RedS();
            this.cargado= false;
        }

        //Metodos
        /// <value> Devuelve la instancia del controlador, la crea si no existe </value>
        public static Controlador Instancia
        {
            get
            {
                if (instancia == null)
                {
                    instancia = new Controlador();
                }
                return instancia;
            }

        }

        /// <value> Devuelve o Setea la variable que indica si ya se cargo la información inicial </value>
        public bool Cargado { get => cargado; set => cargado = value; }

        /// <summary>
        /// poblar la RS con 4 usuarios, 5 publis y 5 comentarios.
        /// </summary>
        public void rellenarRS()
        {
            //Etiquetas
            if (cargado == false)
            {
               //crear los usuarios
               //crear las preguntas
               //crear comentarios

                cargado = true;
            }

        }

        /// <summary>
        /// Registra a un nuevo usuario, retorna true o false  dependiendo si logra registrarse
        /// </summary>

        /// <returns>
        /// true si se registra, false si no 
        /// </returns>
        public bool Register(string username, string password)
        {
            //reviso si es posible registrar
            if (redS.Usuarios.Any(i => i.Username == username)) {
                //Se encontro un usuario asique retorno false
                return false;
            }else
            {   //lo registro
                Usuario newUsuario = new Usuario(username, password);
                redS.Usuarios.Add(newUsuario);
                return true;
            }

        }

        public bool Login(string username, string password)
        {
            //verifica datos
            if (redS.Usuarios.Any(i => i.Username == username && i.Password == password))
            {
                //Si se encontro al usuario y su contraseña corresponde se establece como usuario conectado
                redS.UsuarioConectado = redS.Usuarios.Find(i => i.Username == username);
                //ahora hay alguien conectado
                redS.Conectado = true;
                //Retorna true
                return true;
            }
            return false;
        }

        
        /// <returns>
        /// true si hay un conectado
        /// </returns>
        public bool existeOnline()
        {
            if(redS.Conectado == true)
            {
                return true;
            } else
            {
                return false;
            }
        }

        /// <summary>
        /// Consigue y retorna el nombre del usuario conectado.
        /// </summary>

        /// <returns>
        /// El nombre del user online
        /// </returns>
        public string getUsernameOnline()
        {
            if (redS.Conectado == true)
            {
                return redS.UsuarioConectado.Username;
            }
            return "";
        }

        /// <summary>
        /// Consigue y retorna las publicaciones
        /// </summary>

        /// <returns>
        /// las publicaciones.
        /// </returns>
        public List<Publicaciones> GetPublis()
        {
            return redS.Publis;
        }

        /// <summary>
        /// Desconecta al usuario Online
        /// </summary>
        public void Logout()
        {
            redS.Conectado = false;

        }

        /// <summary>
        /// Consigue y retorna el contenido de una publicacion segun  indice
        /// </summary>

        /// <returns>
        /// El string del contenido de la publi
        /// </returns>
        public string getContenido(int indice)
        {
            return "";
        }


        /// <summary>
        /// Consigue y retorna la lista de comentarios de una publi según indice
        /// </summary>

        /// <returns>
        /// lista comentarios de una publi
        /// </returns>
        public List<Comentario> GetComentarios(int indice)
        {
            return "";
        }

        /// <summary>
        /// Consigue y retorna la fecha de una publi segun indice
        /// </summary>

        /// <returns>
        /// La fecha de una publicacion
        /// </returns>
        public string getPubliFecha(int indice)
        {
            return "";
        }

        /// <summary>
        /// Consigue y retorna la cantidad de likes segun indice de publicacion
        /// </summary>

        /// <returns>
        /// el entero que representa los likes de la publi
        /// </returns>
        public int getLikesPubli(int indice)
        {
            return 1;
        }


        /// <summary>
        /// Consigue y retorna el username del autor de una publicacion
        /// </summary>

        /// <returns>
        /// String Nombre del autor
        /// </returns>
        public string GetPubliAutor(int indice)
        {
            return " ";
        }

        /// <summary>
        /// Consigue y retorna el id de una  publi segun indice
        /// </summary>

        /// <returns>
        /// El entero que representa el id 
        /// </returns>
        public int GetPubliId(int indice)
        {
            return 0;
        }

        /// <summary>
        /// Consigue y retorna una publi por indice
        /// </summary>

        /// <returns>
        /// Una publi
        /// </returns>
        public Pregunta GetPubliIndex(int indice)
        {
            return stack.Preguntas[indice];
        }


        /// <summary>
        /// Consigue y retorna el Autor de un comentario, dado comentario

        /// <returns>
        /// string del username del autor
        /// </returns>
        public string GetComentarioAutor(Comentario coment)
        {
            return "";
        }

        /// <summary>
        /// Consigue y retorna la lista de usuarios 
        /// </summary>

        /// <returns>
        /// La lista de usuarios.
        /// </returns>
        public List<Usuario> GetAllUsers()
        {
            return redS.Usuarios;
        }

        /// <summary>
        /// Publica una nueva respuesta a una pregunta en el stack, recibe como entrada la pregunta a responder y el contenido de la respuesta.
        /// </summary>
        public void Answer(Pregunta pregunta, string contenido)
        {
            //Se crea la respuesta
            Comentario respuesta = new Comentario(contenido);
            //Se consigue al autor de la respuesta y se asigna
            respuesta.Autor = stack.UsuarioConectado;
            //Se agrega la respuesta creada al usuario correspondiente
            stack.UsuarioConectado.RespuestasRealizadas.Add(respuesta);
            //Se añade la respuesta a la lista de respuestas de la pregunta
            pregunta.Respuestas.Add(respuesta);
        }

        /// <summary>
        /// Publica una nueva pregunta en el stack, para ello recibe el titulo, contenido y lista de etiquetas de la pregunta a publicar.
        /// </summary>
        public void Ask(string titulo, string contenido, List<Etiqueta> etiquetas)
        {
            //Se crea la pregunta
            Pregunta pregunta = new Pregunta(titulo, contenido, etiquetas);
            //Se agrega al autor de la pregunta
            pregunta.Autor = stack.UsuarioConectado;
            //Se agrega la pregunta al stack
            stack.Preguntas.Add(pregunta);
            //Se agrega la pregunta al usuario que la hizo
            stack.UsuarioConectado.PreguntasRealizadas.Add(pregunta);
        }

        /// <summary>
        /// Consigue y retorna las publis hechas por el usuario  conectado.
        /// </summary>

        /// <returns>
        /// Lista de preguntas.
        /// </returns>
        public List<Publicacion> GetPublisByConnectedUser()
        {
            return ;
        }

    }
}
