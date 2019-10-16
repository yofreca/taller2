using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cliente.presentacion
{
    public partial class Vista : Form
    {
        public bool blnEncendido { get; set; }


        private Controlador control;
        private Modelo modelo;

        public Modelo getModelo()
        {
            return modelo;
        }

        public Controlador getControl()
        {
            if (control == null)
            {
                control = new Controlador(this);
            }
            return control;
        }

        public Vista(Modelo m)
        {
            modelo = m;
            InitializeComponent();
            getControl();
            InciarSemaforo();
            blnEncendido = false;
        }


        public void InciarSemaforo()
        {
            pcbSemaforo.Image = Image.FromFile(Application.StartupPath + @"\img\apagado.png");
        }




        public PictureBox getImgSemaforo()
        {
            return pcbSemaforo;
        }
        
        public CheckBox getCkbRojo()
        {
            return ckbRojo;
        }


        public CheckBox getCkbApagado()
        {
            return ckbApagado;
        }

        public CheckBox getCkbAmarillo()
        {
            return ckbAmarillo;
        }

        public CheckBox getCkbVerde()
        {
            return ckbVerde;
        }

        public CheckBox getCkbRojoIntermitente()
        {
            return ckbRojoIntermitente;
        }

        public CheckBox getCkbAmarilloIntermitente()
        {
            return ckbAmarilloIntermitente;
        }

        public CheckBox getCkbVerdeIntermitente()
        {
            return ckbVerdeIntermitente;
        }


        public Timer getTimer()
        {
            return timer1;
        }

    }
}
