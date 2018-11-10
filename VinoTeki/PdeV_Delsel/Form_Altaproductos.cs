﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PdeV_Delsel
{
    public partial class Form_Altaproductos : Form
    {
        public Form_Altaproductos()
        {
            InitializeComponent();
        }
        Class_ProductoTB P = new Class_ProductoTB();
        //Ocultar fragmebtos de codigo #region y para cerrar #endregion y listo

        #region Diseño para los combo box, que muestre info y al momento de escribir se borre
        private void txt_producto_Enter(object sender, EventArgs e)
        {
            if (txt_producto.Text == "PRODUCTO")
            {
                txt_producto.Text = "";
                txt_producto.ForeColor = Color.White;
            }
        } 

        private void txt_producto_Leave(object sender, EventArgs e)
        {
            if(txt_producto.Text == "")
            {
                txt_producto.Text = "PRODUCTO";
                txt_producto.ForeColor = Color.SeaGreen; 
            }
        }

        private void txt_tipo_Enter(object sender, EventArgs e)
        {
            if (txt_tipo.Text == "TIPO")
            {
                txt_tipo.Text = "";
                txt_tipo.ForeColor = Color.White;
            }
        }

        private void txt_tipo_Leave(object sender, EventArgs e)
        {
            if (txt_tipo.Text == "")
            {
                txt_tipo.Text = "TIPO";
                txt_tipo.ForeColor = Color.SeaGreen;
            }
        }

        private void txt_marca_Enter(object sender, EventArgs e)
        {
            if (txt_marca.Text == "MARCA")
            {
                txt_marca.Text = "";
                txt_marca.ForeColor = Color.White;
            }
        }

        private void txt_marca_Leave(object sender, EventArgs e)
        {
            if (txt_marca.Text == "")
            {
                txt_marca.Text = "MARCA";
                txt_marca.ForeColor = Color.SeaGreen;
            }
        }

        private void txt_modelo_Enter(object sender, EventArgs e)
        {
            if (txt_modelo.Text == "MODELO")
            {
                txt_modelo.Text = "";
                txt_modelo.ForeColor = Color.White;
            }
        }

        private void txt_modelo_Leave(object sender, EventArgs e)
        {
            if (txt_modelo.Text == "")
            {
                txt_modelo.Text = "MODELO";
                txt_modelo.ForeColor = Color.SeaGreen;
            }
        }

        private void txt_descrip_Enter(object sender, EventArgs e)
        {
            if (txt_descrip.Text == "DESCRIPCION")
            {
                txt_descrip.Text = "";
                txt_descrip.ForeColor = Color.White;
            }
        }

        private void txt_descrip_Leave(object sender, EventArgs e)
        {
            if (txt_descrip.Text == "")
            {
                txt_descrip.Text = "DESCRIPCION";
                txt_descrip.ForeColor = Color.SeaGreen;
            }
        }

        private void txt_cantidad_Enter(object sender, EventArgs e)
        {
            if (txt_cantidad.Text == "CANTIDAD")
            {
                txt_cantidad.Text = "";
                txt_cantidad.ForeColor = Color.White;
            }
        }

        private void txt_cantidad_Leave(object sender, EventArgs e)
        {
            if (txt_cantidad.Text == "")
            {
                txt_cantidad.Text = "CANTIDAD";
                txt_cantidad.ForeColor = Color.SeaGreen;
            }
        }

        private void txt_costo_Enter(object sender, EventArgs e)
        {
            if (txt_costo.Text == "COSTO")
            {
                txt_costo.Text = "";
                txt_costo.ForeColor = Color.White;
            }
        }

        private void txt_costo_Leave(object sender, EventArgs e)
        {
            if (txt_costo.Text == "")
            {
                txt_costo.Text = "COSTO";
                txt_costo.ForeColor = Color.SeaGreen;
            }
        }

        private void txt_precio_Enter(object sender, EventArgs e)
        {
            if (txt_precio.Text == "PRECIO")
            {
                txt_precio.Text = "";
                txt_precio.ForeColor = Color.White;
            }
        }

        private void txt_precio_Leave(object sender, EventArgs e)
        {
            if (txt_precio.Text == "")
            {
                txt_precio.Text = "PRECIO";
                txt_precio.ForeColor = Color.SeaGreen;
            }
        }
        #endregion

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            P.Producto1 = txt_producto.Text;
            P.Tipo1 = txt_tipo.Text;
            P.Marca1 = txt_marca.Text;
            P.Modelo1 = txt_modelo.Text;
            P.Descripcion1 = txt_descrip.Text;
            P.Cantidad1 = int.Parse(txt_cantidad.Text);
            P.Costo1 = int.Parse(txt_costo.Text);
            P.Precio1 = int.Parse(txt_precio.Text);
            Class_BasedeDatos.GuardarP(P);
        }
    }
}
