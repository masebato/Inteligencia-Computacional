using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IdentificaciónInteligente.Clases;
using System.Windows.Forms;

namespace IdentificaciónInteligente.Clases
{
    class Algoritmo
    {
        // METODO DE ESCALA DE GRISES
        public Bitmap EscalaDeGrises(Bitmap source, int Umbral)
        {
            // Bitmap con la imagen binaria
            Bitmap imagen = new Bitmap(source.Width, source.Height, source.PixelFormat);
            Imagen img = new Imagen(source.Width, source.Height, imagen);
           
            //Imagen img = new Imagen(source.Width, source.Height, imagen);
            // Recorrer pixel de la imagen
            for (int i = 0; i < source.Height; i++)
            {
                for (int e = 0; e < source.Width; e++)
                {
                    // Color del pixel
                    Color coloor = source.GetPixel(e, i);
                    // Escala de grises
                    byte gray = (byte)(coloor.R * 0.3f + coloor.G * 0.59f + coloor.B * 0.11f);
                    // Blanco o negro
                    byte value = 0;
                    //img.llenarMatrix(i, e, 0);
                    if (gray > Umbral)
                    {
                        value = 255;
                        //img.llenarMatrix(i, e, 1);
                    }

                    // Asginar nuevo color
                    Color NuevoColor = System.Drawing.Color.FromArgb(value, value, value);
                    imagen.SetPixel(e, i, NuevoColor);
                }
            }
            return imagen;
        }

        // METODO DE BINARIZACION

        public int[,] Binarizacion(Bitmap image, int Umbral, ListBox list_binarizacion)
        {

            string valor = "";
            list_binarizacion.Items.Clear(); // Limpia el listbox de la binarizacion
            // Bitmap con la imagen binaria
            Bitmap imagen = new Bitmap(image.Width, image.Height, image.PixelFormat);
            //Imagen img = new Imagen(source.Width, source.Height, imagen);
            // Recorrer pixel de la imagen

            int[,] matrizBinaria = new int[imagen.Height, imagen.Width];
            for (int i = 0; i < image.Height; i++)
            {
                valor = "";
                for (int e = 0; e < image.Width; e++)
                {
                    // Color del pixel
                    Color coloor = image.GetPixel(e, i);
                    // Escala de grises
                    byte gray = (byte)(coloor.R * 0.3f + coloor.G * 0.59f + coloor.B * 0.11f);
                    // Blanco o negro
                    //img.llenarMatrix(i, e, 0);
                    if (gray > Umbral)
                    {
                        //img.llenarMatrix(i, e, 1);
                        matrizBinaria[i, e] = 0;
                    }
                    else
                    {
                        matrizBinaria[i, e] = 1;
                    }
                    valor = valor + matrizBinaria[i, e];
                }
                list_binarizacion.Items.Add(valor);
            }
            return matrizBinaria;
        }
    }
}
