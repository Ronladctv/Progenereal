﻿using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using Xamarin.Forms.Xaml;
using Xamarin.Forms;

namespace Progenereal
{

    [ContentProperty(nameof(Source))]
    public class Imagen : IMarkupExtension
    {
        public string Source { get; set; }

        public object ProvideValue(IServiceProvider serviceProvider)
        {
            if (Source == null)
            {
                return null;
            }

            // Se asume que la imagen está incrustada en el ensamblado con el nombre de espacio 'Tarea02.Img'
            var imageSource = ImageSource.FromResource(Source, typeof(Imagen).GetTypeInfo().Assembly);

            return imageSource;
        }
    }



}
