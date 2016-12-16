using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace e_Plagas.Models
{
    public class UsuarioModelo
    {

        /// <summary>
        /// Identificador unico del usuario
        /// </summary>
        [Display(Name = "Identificador del usuario")]
        public int id_usuario { get; set; }
        /// <summary>
        /// nombre del usuario
        /// </summary>
        [Display(Name = "nombre Usuario")]
        public string Nombre { get; set; }

        /// <summary>
        /// Apellidos del usuario
        /// </summary>
        [Display(Name = "Apellidos del usuario")]
        public string Apellidos { get; set; }

        /// <summary>
        /// Usuario para ingresar al sistema
        /// </summary>
        [Required]
        [Display(Name = "Usuario")]
        public string usuario { get; set; }

        /// <summary>
        /// Password del usuario encriptado
        /// </summary>
        [Required]
        [Display(Name = "Password")]
        public string Password { get; set; }

        /// <summary>
        /// fecha en la que se dio de alta en el, sistema
        /// </summary>
        [Display(Name = "Fecha de Alta")]
        public string Alta { get; set; }

        /// <summary>
        /// Estado en el cual realisa las actividades 
        /// </summary>
        [Display(Name = "Estado")]
        public string Estado { get; set; }

        /// <summary>
        /// Municipio en el que realiza sus actividades
        /// </summary>
        [Display(Name = "Municipio")]
        public string Municipio { get; set; }

        /// <summary>
        /// Colonia donde realiza sus actividades el usuario
        /// </summary>
        [Display(Name = "Colonia")]
        public string Colonia { get; set; }

        /// <summary>
        /// Nivel de acceso al sistema
        /// </summary>
        [Display(Name = "Nivel de acceso al sistema")]
        public int Nivel { get; set; }

        /// <summary>
        /// Puesto que desempeña el usuario
        /// </summary>
        [Display(Name = "Puesto Desenpeñado")]
        public string puesto { get; set; }

        /// <summary>
        /// Ruta donde se almacena la fotografia del usuario en caso de tener una
        /// </summary>
        [Display(Name = "Foto")]
        public string RutaFoto { get; set; }

        public class Seguridad
        {
            public string Encriptar(string clave)
            {
                string result = string.Empty;
                byte[] encryted = System.Text.Encoding.Unicode.GetBytes(clave);
                result = Convert.ToBase64String(encryted);
                return result;
            }

            public string DesEncriptar(string clave)
            {
                string result = string.Empty;
                byte[] decryted = Convert.FromBase64String(clave);
                //result = System.Text.Encoding.Unicode.GetString(decryted, 0, decryted.ToArray().Length);
                result = System.Text.Encoding.Unicode.GetString(decryted);
                return result;
            }

        }
    }

}