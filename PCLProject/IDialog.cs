//-----------------------------------------------------------------------
// <copyright file="IDialog.cs" company="Ingeniería GD®">
//     Copyright (c) Ingeniería GD® 2017. All rights reserved.
// </copyright>
// <author>Gabriel Eduardo Duarte Vega</author>
// <date>9/27/2017 10:45:12 AM</date>
//-----------------------------------------------------------------------
namespace PCLProject
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Interface.
    /// </summary>
    public interface IDialog
    {
        /// <summary>
        /// Muestra un mensaje en la pantalla.
        /// </summary>
        /// <param name="message">Mensaje a mostrar en pantalla.</param>
        void Show(string message);
    }
}
