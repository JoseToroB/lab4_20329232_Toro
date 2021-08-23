using modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace controlador
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
        /// poblar la RS con 4 usuarios, 6 publis y 4 comentarios.
        /// </summary>
        public void rellenarRS()
        {
            //Etiquetas
            if (cargado == false)
            {
                //crear los 4 usuarios
                Usuario user1 = new Usuario("toro", "123");
                Usuario user2 = new Usuario("pipo", "123");
                Usuario user3 = new Usuario("pepe", "123");
                Usuario user4 = new Usuario("popo", "123");
                //crear las publis
                List<string> et = new List<string>(); //en ninguna publicacion se hacen etiquetados
                Publicacion Publi1 = new Publicacion(user1, "gente me mudo a chillan :c",et, "texto");
                user1.PublisRealizadas.Add(Publi1);
                Publicacion Publi2 = new Publicacion(user1, "amigos, cuando venga a stgo quien va a querer longanizas?",et,"texto");
                user1.PublisRealizadas.Add(Publi2);
                Publicacion Publi3 = new Publicacion(user1, "hace frio en chillan, pero almenos las longanizas saben de pana", et, "texto");
                user1.PublisRealizadas.Add(Publi3);
                Publicacion Publi4 = new Publicacion(user2, "algun datito de pega en talca?, que no sea vendiendo completos porfa ", et, "texto");
                user2.PublisRealizadas.Add(Publi4);
                Publicacion Publi5 = new Publicacion(user3, "alguien que venda una bici, con las 3b en antofa?", et, "texto");
                user3.PublisRealizadas.Add(Publi5);
                Publicacion Publi6 = new Publicacion(user4, "amigos, tengo el mejor internet de la zona, llamenme al +569 1234 5678 para contratarlo", et, "texto");
                user4.PublisRealizadas.Add(Publi6);
                //crear comentarios
                Comentario com1 = new Comentario(user1, "me interesa, podria darme mas info?");
                user1.ComentariosRealizados.Add(com1);
                Comentario com2 = new Comentario(user2, "disponible en calama?");
                user2.ComentariosRealizados.Add(com2);
                Comentario com3 = new Comentario(user3, "es fibra?");
                user3.ComentariosRealizados.Add(com3);
                Comentario com4 = new Comentario(user4, "se me olvido decir que solo es para pto montt, perdon");
                user4.ComentariosRealizados.Add(com4);
                //todos los comentarios son  a la publicacion 6.
                Publi6.Comentarios.Add(com1);
                Publi6.Comentarios.Add(com2);
                Publi6.Comentarios.Add(com3);
                Publi6.Comentarios.Add(com4);
                //agrego las publis, comentarios y usuarios a la redS
                redS.Comentarios.Add(com1);
                redS.Comentarios.Add(com2);
                redS.Comentarios.Add(com3);
                redS.Comentarios.Add(com4);
                //
                redS.Publis.Add(Publi1);
                redS.Publis.Add(Publi2);
                redS.Publis.Add(Publi3);
                redS.Publis.Add(Publi4);
                redS.Publis.Add(Publi5);
                redS.Publis.Add(Publi6);
                //
                redS.Usuarios.Add(user1);
                redS.Usuarios.Add(user2);
                redS.Usuarios.Add(user3);
                redS.Usuarios.Add(user4);
                //seteo cargado como true
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
        public List<Publicacion> GetPublis()
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
            return redS.Publis[indice].Contenido;
        }


        /// <summary>
        /// Consigue y retorna la lista de comentarios de una publi según indice
        /// </summary>

        /// <returns>
        /// lista comentarios de una publi
        /// </returns>
        public List<Comentario> GetComentarios(int indice)
        {
            return redS.Publis[indice].Comentarios;
        }

        /// <summary>
        /// Consigue y retorna la fecha de una publi segun indice
        /// </summary>

        /// <returns>
        /// La fecha de una publicacion
        /// </returns>
        public string getPubliFecha(int indice)
        {
            return redS.Publis[indice].Fecha;
        }

        /// <summary>
        /// Consigue y retorna la cantidad de likes segun indice de publicacion
        /// </summary>

        /// <returns>
        /// el entero que representa los likes de la publi
        /// </returns>
        public int getLikesPubli(int indice)
        {
            return redS.Publis[indice].Likes;
        }


        /// <summary>
        /// Consigue y retorna el username del autor de una publicacion
        /// </summary>

        /// <returns>
        /// String Nombre del autor
        /// </returns>
        public string GetPubliAutor(int indice)
        {
            return redS.Publis[indice].Autor.Username;
        }

        /// <summary>
        /// Consigue y retorna el id de una  publi segun indice
        /// </summary>

        /// <returns>
        /// El entero que representa el id 
        /// </returns>
        public int GetPubliId(int indice)
        {
            return redS.Publis[indice].Id;
        }

        /// <summary>
        /// Consigue y retorna una publi por indice
        /// </summary>

        /// <returns>
        /// Una publi
        /// </returns>
        public Publicacion GetPubliIndex(int indice)
        {
            return redS.Publis[indice-1];
        }

        /// <summary>
        /// Consigue y retorna un comentario por indice
        /// </summary>

        /// <returns>
        /// Un comentario
        /// </returns>
        public Comentario GetComentarioIndex(int indice)
        {
            return redS.Comentarios[indice-1];
        }
        /// <summary>
        /// Consigue y retorna el Autor de un comentario, dado comentario

        /// <returns>
        /// string del username del autor
        /// </returns>
        public string GetComentarioAutor(Comentario coment)
        {
            return coment.Autor.Username;
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
        /// Consigue y retorna el online
        /// </summary>

        /// <returns>
        /// el user online
        /// </returns>
        public Usuario GetUserOnCompleto()
        {
            return redS.UsuarioConectado;
        }

        /// <summary>
        /// Consigue y retorna las publis hechas por el usuario  conectado.
        /// </summary>

        /// <returns>
        /// Lista de publis del usuario online
        /// </returns>
        public List<Publicacion> GetPublisByConnectedUser()
        {
            return redS.UsuarioConectado.PublisRealizadas;
        }

        //
        //Funciones 
        //para el funcionamiento de la RS
        //

        //post
        /// <summary>
        /// funcion que sirve para crear una publicacion
        /// </summary>
        public bool post(string contenido, List<string> et,string tipo)
        {
            Publicacion publi = new Publicacion(redS.UsuarioConectado, contenido, et,tipo);//genero la publicacion
            redS.Publis.Add(publi);//la agrego a la rs
            redS.UsuarioConectado.PublisRealizadas.Add(publi);//la agrego a la lista del user
            return true;
        }

        //comentar
        /// <summary>
        /// funcion que sirve para comentar a una publi
        /// </summary>
        public bool comentarPubli(Publicacion publi,string contenido,Usuario autor)
        {
            Comentario coment = new Comentario(autor, contenido);//creo el comentario
            publi.Comentarios.Add(coment);//agrego el comentario a la publicacion
            autor.ComentariosRealizados.Add(coment);//agrego el comentario al autor
            return true;
        }
        /// <summary>
        /// funcion que sirve para comentar a un comentario
        /// </summary>
        public bool comentarComentario(string contenido,Comentario comentObj,Usuario autor)
        {
            Comentario coment = new Comentario(autor, contenido);//creo el comentario
            comentObj.Comentarios.Add(coment);//agrego el comentario al comentario objetivo
            autor.ComentariosRealizados.Add(coment);//agrego el comentario al usuario
            return true;
        }

        //like
        /// <summary>
        /// funcion que permite dar like a una publicacion
        /// </summary>
        public bool likePublicacion(Publicacion publi)
        {
            publi.Likes++;
            return true;
        }
        

        /// <summary>
        /// funcion que permite dar like a un comentario
        /// </summary>
        public bool likeComentario(Comentario coment)
        {
            coment.Likes++;
            return true;
         }
        //follow
        ///<summary>
        ///funcion que permite al usuario conectado, seguir al usuario deseado en caso de existir
        ///</sumary>
        public bool follow(string userAseguir)
        {
            if(redS.UsuarioConectado.Username == userAseguir)
            {
                return false;
            }
            if (redS.Usuarios.Any(i => i.Username == userAseguir))//si el user existe
            {
                if(redS.UsuarioConectado.Seguidos.Any(i => i == userAseguir))//si encuentra que ya lo sigue
                {
                    return false;
                }
                else
                {
                    redS.UsuarioConectado.Seguidos.Add(userAseguir);//lo agrego a sus seguidos
                    return true;
                }
            }
            else
            {
                return false;
            }
        }

        //share
        ///<summary>
        ///funcion que permite compartir una publicacion 
        ///</summary>
        public void share(Publicacion publi, List<string> et)
        {
            Compartidas compart = new Compartidas(publi, et);//creo la compartida
            redS.UsuarioConectado.PublisCompartidas.Add(compart);//agrego la compartida al usuario
        }
    }

}
