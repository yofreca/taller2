﻿using System;
using System.Drawing;
using System.Windows.Forms;

namespace Cliente.presentacion
{
    public class Controlador
    {
        private Vista ventana;
        private Modelo modelo;

        public Controlador(Vista aThis)
        {
            ventana = aThis;
            modelo = ventana.getModelo();
            ventana.getCkbAmarillo().CheckedChanged += new EventHandler(MyClickEvent);
            ventana.getCkbVerde().CheckedChanged += new EventHandler(MyClickEvent);
            ventana.getCkbRojo().CheckedChanged += new EventHandler(MyClickEvent);
            ventana.getCkbAmarilloIntermitente().CheckedChanged += new EventHandler(MyClickEvent);
            ventana.getCkbVerdeIntermitente().CheckedChanged += new EventHandler(MyClickEvent);
            ventana.getCkbRojoIntermitente().CheckedChanged += new EventHandler(MyClickEvent);
            ventana.getCkbApagado().CheckedChanged += new EventHandler(MyClickEvent);
            ventana.getTimer().Tick += new EventHandler(timer);
        }


        public void MyClickEvent(object sender, EventArgs e)
        {
            CheckBox chk = (CheckBox)sender;

            if(chk.Checked)
                modelo.encenderLuz(chk.Name);
        }


        public void timer(object sender, EventArgs e)
        {
            modelo.timer();
        }

    }
}
