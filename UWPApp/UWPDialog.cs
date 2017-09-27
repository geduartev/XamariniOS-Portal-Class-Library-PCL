//-----------------------------------------------------------------------
// <copyright file="UWPDialog.cs" company="Ingeniería GD®">
//     Copyright (c) Ingeniería GD® 2017. All rights reserved.
// </copyright>
// <author>Gabriel Eduardo Duarte Vega</author>
// <date>9/27/2017 11:08:54 AM</date>
//-----------------------------------------------------------------------
namespace UWPApp
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Class.
    /// </summary>
    public class UWPDialog : PCLProject.IDialog
    {
        public async void Show(string message)
        {
            var Dialog = new Windows.UI.Popups.MessageDialog(message);
            await Dialog.ShowAsync();
        }
    }
}