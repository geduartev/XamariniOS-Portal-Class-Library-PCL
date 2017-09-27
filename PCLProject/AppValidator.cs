//-----------------------------------------------------------------------
// <copyright file="AppValidator.cs" company="Ingeniería GD®">
//     Copyright (c) Ingeniería GD® 2017. All rights reserved.
// </copyright>
// <author>Gabriel Eduardo Duarte Vega</author>
// <date>9/27/2017 10:44:42 AM</date>
//-----------------------------------------------------------------------
namespace PCLProject
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Clase con código compartido entre plataformas con la lógica del negocio.
    /// </summary>
    public class AppValidator
    {
        IDialog Dialog;

        /// <summary>
        /// Inyecta el objeto IDialog que ejecute el código específico de la plataforma.
        /// </summary>
        /// <param name="platformDialog">Objeto IDialog específico de la plataforma.</param>
        public AppValidator(IDialog platformDialog)
        {
            Dialog = platformDialog;
        }

        public string Email { get; set; }
        public string Password { get; set; }
        public string Device { get; set; }

        /// <summary>
        /// Lógica de negocio para validar y mostrar en pantalla mensaje.
        /// </summary>
        public void Validate()
        {
            string Result;
            /* Aquí se puede implementar la funcionalidad
             * principal de la clase. Por el momento solo 
             * devuelve una cadena fija. */

            Result = "¡Aplicación validada!";

            /* Invocar el código específico de la plataforma. */
            Dialog.Show(Result);
        }
    }
}