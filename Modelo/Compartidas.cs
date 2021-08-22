using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{   /// <summary>
    /// la clase compartidas tiene las caracteristicas de una publicacion compartida
    /// </summary>
    public class Compartidas
    {
        //Atributos
        private string fecha;
        private Publicacion publi;
        private List<string> et;

        public Compartidas(Publicacion publi, List<string> et)
        {
            this.publi = publi;
            this.et = et;
            //conseguir la fecha mediante datetime
            DateTime fecha = DateTime.Now;
            this.fecha = fecha.ToString("dd'/'MM'/'yyyy");
        }
        //Getters y Setters
        /// <value> Devuelve o setea la fecha </value>
        public string Fecha { get => fecha; set => fecha = value; }
        /// <value> Devuelve o setea la publicacion </value>
        public Publicacion Publi { get => publi; set => publi = value; }
        /// <value> Devuelve o setea los etiquetados </value>
        public List<string> Et { get => et; set => et = value; }
    }
}
