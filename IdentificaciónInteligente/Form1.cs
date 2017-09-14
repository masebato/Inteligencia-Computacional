using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IdentificaciónInteligente.Clases;

namespace IdentificaciónInteligente
{
    public partial class Form1 : Form
    {

        OpenFileDialog op = new OpenFileDialog();
        AE AlgoEvolutivo;
        int[,] BitImg;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void bt_tratamiento_Click(object sender, EventArgs e)
        {
            Algoritmo alg = new Algoritmo();
            Bitmap bit = new Bitmap(pictureBox_Color.Image);

            this.pictureBox_Gris.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_Gris.Image = alg.EscalaDeGrises(bit, 60);
            list_proceso.Items.Add(" - Escala de Grises");
            BitImg = alg.Binarizacion(bit, 60, list_binarizacion);
            list_proceso.Items.Add(" - Binarización de la imagen cargada");
            bt_Alg_Evo.Enabled = true;
        }


        private void bt_salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bt_examinar_Click(object sender, EventArgs e)
        {
            if (op.ShowDialog() == DialogResult.OK)
            {
                this.pictureBox_Color.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox_Color.Image = Image.FromFile(op.FileName);
                list_proceso.Items.Add(" - Iniciando Sistema");
            }
        }

        private void bt_Alg_Evo_Click(object sender, EventArgs e)
        {
            list_proceso.Items.Clear();
            Color NuevoColor = System.Drawing.Color.FromArgb(255, 0, 0);
            Bitmap BitImag = new Bitmap(pictureBox_Gris.Image);
            Bitmap BitImag_limp = new Bitmap(pictureBox_Gris.Image);
            int NValidez = 0, epocas = 0;
            list_proceso.Items.Add("- Iniciar Evolución");
            AE AlgoEvolutivo = new AE(BitImg, 10, 60);
            list_proceso.Items.Add("- Generar individuos");
            do
            {
                AlgoEvolutivo.AzarIndividuo(BitImg.GetLength(0), BitImg.GetLength(1));
            } while (ObtenerValidez(AlgoEvolutivo.IND));

            for (int i = 0; i < AlgoEvolutivo.IND.Count; i++)
            {
                BitImag.SetPixel(AlgoEvolutivo.IND[i].Y, AlgoEvolutivo.IND[i].X, NuevoColor);
            }
            pictureBox_Gris.Image = BitImag;
            pictureBox_Gris.Refresh();
            list_proceso.Items.Add("- Buscar distancias");
            AlgoEvolutivo.BuscarDistancia();
            list_proceso.Items.Add("- Generar población");
            AlgoEvolutivo.GenerarPoblacion();

            pictureBox_Gris.Image = BitImag_limp;
            list_proceso.Items.Add("- Evolucionar población");
            epocas = AlgoEvolutivo.Evolucionar(0, AlgoEvolutivo.IND.Count, pictureBox_Gris, BitImag_limp);
            for (int i = 0; i < AlgoEvolutivo.IND.Count; i++)
            {
                BitImag_limp.SetPixel(AlgoEvolutivo.IND[i].Y, AlgoEvolutivo.IND[i].X, NuevoColor);
            }
            pictureBox_Gris.Image = BitImag_limp;
            list_proceso.Items.Add("Numero de epocos que realizo el algoritmo es: " + epocas);
            for (int i = 0; i < AlgoEvolutivo.IND.Count; i++)
            {
                if (AlgoEvolutivo.IND[i].Validez == 1)
                {
                    NValidez++;
                }
            }
            list_proceso.Items.Add("Numero de acertaciones es: " + NValidez + " de " + AlgoEvolutivo.IND.Count + " individuos");
        }
        private bool ObtenerValidez(List<Individuo> individuo)
        {
            for (int i = 0; i < individuo.Count; i++)
            {
                if (individuo[i].Validez == 1)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
