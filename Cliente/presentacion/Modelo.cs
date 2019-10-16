using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Cliente.presentacion
{
    public class Modelo
    {
        private Vista ventana;
        private bool R, A, V, RI, AI, VI;

        public Modelo()
        {

        }


        public Vista getVentana()
        {
            if (ventana == null)
            {
                ventana = new Vista(this);
            }
            return ventana;
        }


        public void iniciar()
        {
            getVentana().Size = new System.Drawing.Size(900, 500);
            getVentana().Visible = true;
            Application.Run(getVentana());
        }


        public void encenderLuz(string sOpcion)
        {
            switch (sOpcion)
            {
                case "ckbAmarillo":
                    ventana.getImgSemaforo().Image = Image.FromFile(Application.StartupPath + @"\img\amarillo.png");
                    ventana.getCkbAmarilloIntermitente().Checked = false;
                    getVentana().getTimer().Stop();
                    break;
                case "ckbRojo":
                    ventana.getImgSemaforo().Image = Image.FromFile(Application.StartupPath + @"\img\rojo.png");
                    ventana.getCkbRojoIntermitente().Checked = false;
                    getVentana().getTimer().Stop();
                    break;
                case "ckbVerde":
                    ventana.getImgSemaforo().Image = Image.FromFile(Application.StartupPath + @"\img\verde.png");
                    ventana.getCkbVerdeIntermitente().Checked = false;
                    getVentana().getTimer().Stop();
                    break;
                case "ckbApagado":
                    Apagar();
                    ventana.getImgSemaforo().Image = Image.FromFile(Application.StartupPath + @"\img\apagado.png");
                    getVentana().getTimer().Stop();
                    break;
                case "ckbRojoIntermitente":
                    ventana.getCkbRojo().Checked = false;
                    getVentana().getTimer().Start();
                    break;
                case "ckbAmarilloIntermitente":
                    ventana.getCkbAmarillo().Checked = false;
                    getVentana().getTimer().Start();
                    break;
                case "ckbVerdeIntermitente":
                    ventana.getCkbVerde().Checked = false;
                    getVentana().getTimer().Start();
                    break;
            }
        }


        public void Apagar()
        {
            var lstCheck = getVentana().Controls;

            foreach (CheckBox item in lstCheck.OfType<CheckBox>())
            {
                if (item.Name != "ckbApagado")
                    item.Checked = false;
            }
        }


        public void timer()
        {
            bool[] lst = GetCombinacion();



            if (!getVentana().blnEncendido)
            {
                if (getVentana().getCkbRojoIntermitente().Checked)
                    getVentana().getImgSemaforo().Image = Image.FromFile(Application.StartupPath + @"\img\rojo.png");
                else if (getVentana().getCkbAmarilloIntermitente().Checked)
                    getVentana().getImgSemaforo().Image = Image.FromFile(Application.StartupPath + @"\img\amarillo.png");
                else if (getVentana().getCkbVerdeIntermitente().Checked)
                    getVentana().getImgSemaforo().Image = Image.FromFile(Application.StartupPath + @"\img\verde.png");
                else
                    return;
            }
            else
                getVentana().getImgSemaforo().Image = Image.FromFile(Application.StartupPath + @"\img\apagado.png");

            getVentana().blnEncendido  = !getVentana().blnEncendido;

        }



        public bool[] GetCombinacion()
        {
            bool[] lstEstado = new bool[7]; 
            var lstCheck = getVentana().Controls;

            foreach (CheckBox item in lstCheck.OfType<CheckBox>())
            {
                if (item.Name != "ckbApagado")
                {
                    switch (item.Name)
                    {
                        case "ckbRojo":
                            lstEstado[0] = item.Checked;
                            break;
                        case "ckbAmarillo":
                            lstEstado[1] = item.Checked;
                            break;
                        case "ckbVerde":
                            lstEstado[2] = item.Checked;
                            break;
                        case "ckbRojoIntermitente":
                            lstEstado[3] = item.Checked;
                            break;
                        case "ckbAmarilloIntermitente":
                            lstEstado[4] = item.Checked;
                            break;
                        case "ckbVerdeIntermitente":
                            lstEstado[5] = item.Checked;
                            break;
                    }
                }
            }
            lstEstado[6] = getVentana().blnEncendido;

            return lstEstado;

        }


    }
}
