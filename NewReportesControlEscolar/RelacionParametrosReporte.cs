﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoLoboSostenido;

namespace NewReportesControlEscolar
{
    public partial class RelacionParametrosReporte : Form
    {
        #region MoverFORM
        //--------- MOVER FORMS
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void RelacionParametrosReporte_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion
        public RelacionParametrosReporte()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MostrarReportesDetalle()
        {
            Clase_Reportes mostrar = new Clase_Reportes();
            mostrar.GetNombreReporte();
            GridViewDetalles.DataSource = mostrar.Lector.Tables[0];
            GridViewDetalles.AllowUserToResizeRows = false;
            GridViewDetalles.AllowUserToAddRows = false;
            foreach (DataGridViewColumn column in GridViewDetalles.Columns) column.SortMode = DataGridViewColumnSortMode.NotSortable;
            GridViewDetalles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            GridViewDetalles.AutoResizeColumns();

            GridViewDetalles.Columns[0].Visible = false;
            GridViewDetalles.Columns[2].Visible = false;
            GridViewDetalles.Columns[3].Visible = false;
            GridViewDetalles.Columns[4].Visible = false;
            GridViewDetalles.Columns[5].Visible = false;
            GridViewDetalles.Columns[6].Visible = false;
            GridViewDetalles.Columns[7].Visible = false;
            GridViewDetalles.Columns[8].Visible = false;
            GridViewDetalles.Columns[9].Visible = false;

            if (GridViewDetalles.RowCount > 0)
            {
                // MessageBox.Show("Reportes en DB");
            }
            else
            {
                //MessageBox.Show("No se puede mostrar la información");
            }
        }

        private void RelacionParametrosReporte_Load(object sender, EventArgs e)
        {
            MostrarReportesDetalle();
            getParametros();
            checkbox();

        }

        private void GridViewDetalles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIDReporte.Text = GridViewDetalles.CurrentRow.Cells[0].Value.ToString();
            txtNombreReporte.Text = GridViewDetalles.CurrentRow.Cells[1].Value.ToString();
            Guardados();
        }

        private void getParametros()
        {
            Clase_Reportes parametros = new Clase_Reportes();
            parametros.MostrarParametros();
            listViewParametros.Items.Clear();
            if (parametros.Lector.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < parametros.Lector.Tables[0].Rows.Count; i++)
                {
                    var item = new ListViewItem();
                    item.Text = parametros.Lector.Tables[0].Rows[i][0].ToString();
                    item.SubItems.Add(parametros.Lector.Tables[0].Rows[i][1].ToString()); // 1st column text
                    listViewParametros.Items.Add(item);

                }
            }
        }
        private void checkbox()
        {
            foreach (CheckBox c in listViewParametros.Controls)
            {
                c.Checked = false;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Clase_Reportes agregar = new Clase_Reportes();
            string idparametro = "";
            if (txtIDReporte != null && txtNombreReporte != null)
            {

                for (int i = 0; i < listViewParametros.Items.Count; i++)
                {

                    if (listViewParametros.Items[i].Checked)
                    {
                        idparametro = idparametro + "," + listViewParametros.Items[i].Text;
                    }
                }
                if (idparametro != "")
                    idparametro = idparametro.Substring(1);
                MessageBox.Show("Se han agregado los parametros", "Confirmado", MessageBoxButtons.OK);
                MessageBox.Show(idparametro);
                agregar.AsignarParametros(txtIDReporte.Text, idparametro);
            }


        }
        private void Guardados()
        {
            if (txtIDReporte != null)
            {
                try
                {
                    Clase_Reportes guardados= new Clase_Reportes();
                    if (guardados.GetParametrosOK(txtIDReporte.Text))
                    {

                        for (int i = 0; i < listViewParametros.Items.Count; i++)
                            listViewParametros.Items[i].Checked = false;

                        for (int i = 0; i < listViewParametros.Items.Count; i++)
                        {
                            for (int j = 0; j < guardados.Lector.Tables[0].Rows.Count; j++)
                            {
                                if (guardados.Lector.Tables[0].Rows[j][0].ToString() == listViewParametros.Items[i].Text.ToString())
                                {
                                    listViewParametros.Items[i].Checked = true;
                                }
                            }
                               
                            
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "No se pudieron extraer los datos de la base de datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        

    }
}


