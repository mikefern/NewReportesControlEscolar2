using ProyectoLoboSostenido;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewReportesControlEscolar
{
    public partial class FrmAdministrarParametrosRCE : Form
    {

        #region VARIABLES
        Clase_ReportesCE parametros;
        string valorAlEscribir = "";
        string valorAlEscribirenCelda2 = "";
        bool CellIsBeingEdited = false;
        bool FlagInsertar = false;
        bool flagInicio = false;
        bool flagModificar = false;
        bool flag2 = false;
        bool flagModificarNoSelection = true;
        int posicioncuandoescribe = 0;
        int cuantosrenglones = 0;
        int count = 1;
        Keys LastKeyPressed;
        #endregion 

        public FrmAdministrarParametrosRCE()
        {
            FlagInsertar = false;
            InitializeComponent();
            parametros = new Clase_ReportesCE();
            llenadoListaParametros();
            DGV_parametros.Columns[0].ReadOnly = true;
            DGV_parametros.CellEndEdit += new DataGridViewCellEventHandler(DGV_parametros_CellEndEdit);
            DGV_parametros.EditingControlShowing += new DataGridViewEditingControlShowingEventHandler(DGV_parametros_EditingControlShowing);
        }

        private void FrmAdministrarParametrosRCE_Load(object sender, EventArgs e)
        {
            FlagInsertar = false;
            flagInicio = true;
            flagModificar = false;
            DGV_parametros.Rows[DGV_parametros.Rows.Count-1].Cells[2].ReadOnly = true;
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (CellIsBeingEdited)
            {
                Console.WriteLine(posicioncuandoescribe);
                posicioncuandoescribe = DGV_parametros.CurrentCell.RowIndex;
                valorAlEscribir = DGV_parametros.Rows[posicioncuandoescribe].Cells[1].Value.ToString();
                valorAlEscribirenCelda2 = DGV_parametros.Rows[posicioncuandoescribe].Cells[2].Value.ToString();

                if (keyData == Keys.Enter ||
                    keyData == Keys.Right ||
                    keyData == Keys.Left  ||
                    keyData == Keys.Up    ||
                    keyData == Keys.Down  ||
                    keyData == Keys.Tab)
                {
                    if (FlagInsertar)
                    {
                        string nombre = DGV_parametros.CurrentCell.EditedFormattedValue.ToString().Trim();
                        flag2 = true;

                        if (nombre != "")
                        {
                            if (MessageBox.Show("¿Esta seguro de ingresar este nuevo Registro?", "Confirmacion", MessageBoxButtons.YesNo) == DialogResult.Yes)
                            {
                                parametros = new Clase_ReportesCE();
                                if (parametros.ParametrosReportes("1", "", nombre, ""))
                                {
                                    MessageBox.Show("Parametro Ingresado", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    FlagInsertar = false;
                                    flagInicio = false;
                                    flagModificar = false;
                                    llenadoListaParametros();
                                    DGV_parametros.FirstDisplayedScrollingRowIndex = DGV_parametros.RowCount - 1;
                                    flagInicio = true;
                                }
                                else MessageBox.Show("Error en el Procedimiento \n", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                DGV_parametros.Rows.RemoveAt(posicioncuandoescribe);
                                FlagInsertar = false;
                            }
                        }
                        else
                        {
                            DGV_parametros.Rows.RemoveAt(posicioncuandoescribe);
                            FlagInsertar = false;
                        }
                    }//--------------------------------------------------------------------------------------------------------------------
                    else //Modificacion
                    {
                        
                        string id = DGV_parametros.Rows[posicioncuandoescribe].Cells[0].Value.ToString();
                        string nombre = DGV_parametros.Rows[posicioncuandoescribe].Cells[1].EditedFormattedValue.ToString();
                        string valor = DGV_parametros.Rows[posicioncuandoescribe].Cells[2].EditedFormattedValue.ToString();

                        if (valor == null) valor = "";
                        flag2 = true;
                        if (nombre != "")
                        {
                            if (valorAlEscribir.Trim() != DGV_parametros.Rows[posicioncuandoescribe].Cells[1].EditedFormattedValue.ToString().Trim()||
                                valorAlEscribirenCelda2.Trim() != DGV_parametros.Rows[posicioncuandoescribe].Cells[2].EditedFormattedValue.ToString().Trim())
                            {
                                parametros = new Clase_ReportesCE();
                                if (parametros.ParametrosReportes("2", id, nombre, valor))
                                {
                                    flagModificar = true;
                                    MessageBox.Show("Parametro Modificado", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    FlagInsertar = false;
                                    flagInicio = true;
                                    flagModificarNoSelection = false;
                                    //llenadoListaParametros();
                                    //DGV_parametros.FirstDisplayedScrollingRowIndex = DGV_parametros.RowCount - 1;
                                    //flagInicio = true;
                                }
                                else MessageBox.Show("Error en el Procedimiento \n", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            DGV_parametros.Rows[posicioncuandoescribe].Cells[1].Value = valorAlEscribir.Trim();
                            FlagInsertar = false;
                        }
                    }
                }
                else
                {
                    flagModificar = true;
                    flagModificarNoSelection = true;
                }
                LastKeyPressed = keyData;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        public void llenadoListaParametros()
        {
            parametros.MostrarParametros();
            DGV_parametros.DataSource = parametros.Lector.Tables[0];
            this.DGV_parametros.Rows[DGV_parametros.Rows.Count - 1].Cells[2].ReadOnly = true;
        }

        
        private void DGV_parametros_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                cuantosrenglones = DGV_parametros.SelectedRows.Count;
            }
        }

        private void DGV_parametros_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            CellIsBeingEdited = true;
        }

        private void DGV_parametros_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            //Console.WriteLine("Pressed Key to finish editing was -> " + LastKeyPressed);
            CellIsBeingEdited = false;
            //Console.WriteLine("No cell is being edited! -----------");
        }

        private void DGV_parametros_RowsAdded_1(object sender, DataGridViewRowsAddedEventArgs e)
        {
            if (flagInicio)
            {
                FlagInsertar = true;
                flag2 = false;
            }
        }

        private void DGV_parametros_SelectionChanged(object sender, EventArgs e)
        {
            if (FlagInsertar)
            {
                if (flag2==false)
                {
                     string nombre = DGV_parametros.Rows[posicioncuandoescribe].Cells[1].EditedFormattedValue.ToString().Trim();
                    if (nombre != "")
                    {
                        if (MessageBox.Show("DGV_parametros_SelectionChanged - Quieres Insertar el Nuevo Registro de la posi?" + posicioncuandoescribe, "Confirmacion", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            parametros = new Clase_ReportesCE();
                            if (parametros.ParametrosReportes("1", "", nombre, ""))
                            {
                                MessageBox.Show("Parametro Ingresado", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                FlagInsertar = false;
                                flagInicio = false;
                                flagModificar = false;
                                llenadoListaParametros();
                                DGV_parametros.FirstDisplayedScrollingRowIndex = DGV_parametros.RowCount - 1;
                                flagInicio = true;
                            }
                            else
                            {
                                MessageBox.Show("Error en el Procedimiento \n", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                FlagInsertar = false;
                            }
                        }
                        else
                        {
                            FlagInsertar = false;
                            DGV_parametros.Rows.RemoveAt(posicioncuandoescribe);
                        }
                    }
                    else
                    {
                        FlagInsertar = false;
                        DGV_parametros.Rows.RemoveAt(posicioncuandoescribe);
                    }
                }
            }//Modificacion
            else //--------------------------------------------------------------
            {
                if (flagModificar)
                {
                    if (flagModificarNoSelection)
                    {
                        if (valorAlEscribir.Trim() != DGV_parametros.Rows[posicioncuandoescribe].Cells[1].EditedFormattedValue.ToString().Trim() ||
                            valorAlEscribirenCelda2.Trim() != DGV_parametros.Rows[posicioncuandoescribe].Cells[2].EditedFormattedValue.ToString().Trim())
                        {
                            string id = DGV_parametros.Rows[posicioncuandoescribe].Cells[0].Value.ToString();
                            string nombre = DGV_parametros.Rows[posicioncuandoescribe].Cells[1].Value.ToString().Trim();
                            string valor = DGV_parametros.Rows[posicioncuandoescribe].Cells[2].Value.ToString().Trim();

                            if (valor == null) valor = "";
                            flag2 = true;
                            if (nombre != "")
                            {
                                parametros = new Clase_ReportesCE();
                                if (parametros.ParametrosReportes("2", id, nombre, valor))
                                {
                                    MessageBox.Show("Parametro Modificado", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    FlagInsertar = false;
                                    flagInicio = true;
                                    flagModificar = false;
                                }
                                else MessageBox.Show("Error en el Procedimiento \n", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                MessageBox.Show("El Campo no puede quedar vacio ", "Correccion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                DGV_parametros.Rows[posicioncuandoescribe].Cells[1].Value = valorAlEscribir;
                                FlagInsertar = false;
                            }
                        }
                    }
                    flagModificar = false;
                }
            }
        }
        
        private void DGV_parametros_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            string id = DGV_parametros.SelectedRows[DGV_parametros.SelectedRows.Count - count].Cells[0].Value.ToString();
            string nameX = DGV_parametros.SelectedRows[DGV_parametros.SelectedRows.Count - count].Cells[1].Value.ToString();
            if (MessageBox.Show("Desea Eliminar el Registro " + nameX, "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
               if (parametros.ParametrosReportes("3", id, "", ""))
                {
                    MessageBox.Show("Eliminacion exitosa", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else MessageBox.Show("Error en el Procedimiento \n", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else { e.Cancel = true; count = count+1; };

            cuantosrenglones = cuantosrenglones - 1;
            if (cuantosrenglones == 0) count = 1;
        }
    }
}
