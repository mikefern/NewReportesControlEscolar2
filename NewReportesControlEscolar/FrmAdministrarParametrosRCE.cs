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

        Clase_Reportes parametros;
        Keys LastKeyPressed;
        int posicioncuandoescribe = 0;
        bool CellIsBeingEdited = false;
        bool modoinser = false;
        bool flagInicio = false;
        bool flagModificar = false;
        bool flag2 = false;
        bool flagModificarNoSelection = true;

        string valorAlEscribir = "";
        string valorAlEscribirenCelda2 = "";
        public FrmAdministrarParametrosRCE()
        {
            modoinser = false;
            InitializeComponent();
            parametros = new Clase_Reportes();
            llenadoListaParametros();

            DGV_parametros.Columns[0].ReadOnly = true;

           

           // DGV_parametros.Columns[2].ReadOnly = true;
            label1.Text = DGV_parametros.Rows.Count.ToString();

            DGV_parametros.CellEndEdit += new DataGridViewCellEventHandler(DGV_parametros_CellEndEdit);
            DGV_parametros.EditingControlShowing += new DataGridViewEditingControlShowingEventHandler(DGV_parametros_EditingControlShowing);

            
          

        }

        private void FrmAdministrarParametrosRCE_Load(object sender, EventArgs e)
        {
            modoinser = false;
            flagInicio = true;
            flagModificar = false;
            this.DGV_parametros.Rows[DGV_parametros.Rows.Count-1].Cells[2].ReadOnly = true;
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
                    keyData == Keys.Left ||
                    keyData == Keys.Up ||
                    keyData == Keys.Down ||
                    keyData == Keys.Tab)
                {
                    if (modoinser)
                    {
                        string nombre = DGV_parametros.CurrentCell.EditedFormattedValue.ToString().Trim();
                        flag2 = true;

                        if (nombre != "")
                        {

                            if (MessageBox.Show("ProcessCmdKey \n Esta seguro de ingresar este nuevo Registro?", "Confirmacion", MessageBoxButtons.YesNo) == DialogResult.Yes)
                            {
                                parametros = new Clase_Reportes();
                                if (parametros.ParametrosReportes("1", "", nombre, ""))
                                {
                                    MessageBox.Show("Parametro Ingresado", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    modoinser = false;
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
                                modoinser = false;
                            }
                        }
                        else
                        {
                            DGV_parametros.Rows.RemoveAt(posicioncuandoescribe);
                            modoinser = false;
                        }
                    }//-------------------------------------------------------------------------
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
                                parametros = new Clase_Reportes();
                                if (parametros.ParametrosReportes("2", id, nombre, valor))
                                {
                                    flagModificar = true;
                                    MessageBox.Show("Parametro Modificado", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    modoinser = false;
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
                           // MessageBox.Show("El Campo no puede quedar vacio ", "Correccion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            //flagModificar = false;
                            DGV_parametros.Rows[posicioncuandoescribe].Cells[1].Value = valorAlEscribir.Trim();
                            modoinser = false;
                        }
                    }
                }
                else
                
                {
                    //valorAlEscribir = DGV_parametros.Rows[posicioncuandoescribe].Cells[1].Value.ToString();
                    flagModificar = true;
                    flagModificarNoSelection = true;
                    Console.WriteLine("Cell Edit mode Keypress > " + keyData);
                    // do any checking here for invalid keys pressed
                    // example if you wanted to allow only numeric keys to be pressed in a column of int cells
                    // simply check if the key is numeric and if not ignore it...
                    //if (!char.IsDigit(((char)keyData))) {
                    //  return true;
                    //}
                }
                LastKeyPressed = keyData;
            }
            //Console.WriteLine("ProcessCmdKey -> Leave");
            return base.ProcessCmdKey(ref msg, keyData);
        }


        public void llenadoListaParametros()
        {
            parametros.MostrarParametros();
            DGV_parametros.DataSource = parametros.Lector.Tables[0];
            this.DGV_parametros.Rows[DGV_parametros.Rows.Count - 1].Cells[2].ReadOnly = true;
        }

        private void DGV_parametros_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
           
        }

        private void button1_Click(object sender2, EventArgs ee)
        {
            DGV_parametros.RowsAdded += (sender, e) =>
            {
                

                    if (MessageBox.Show("Estas Seguro de Agregar este Parametro", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Console.WriteLine(e.RowIndex);
                    }
                    else try
                        {
                            DGV_parametros.Rows.RemoveAt(e.RowIndex);
                        }
                        catch (System.InvalidOperationException x)
                        { MessageBox.Show(""); }
                 
                //   this.DGV_parametros.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.DGV_parametros_RowsAdded);
            };
        }

        private void DGV_parametros_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (DGV_parametros.CurrentCell.IsInEditMode == true)
            //{
            //    int i = DGV_parametros.CurrentRow.Index;
            //    button1.Text = i.ToString();
            //    // MessageBox.Show(i.ToString());
            //}

         
        }

        int cuantosrenglones = 0;
        private void DGV_parametros_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                cuantosrenglones = DGV_parametros.SelectedRows.Count;
            }
        }

        private void DGV_parametros_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            //e.KeyCode == Keys.Enter &&
            if ( DGV_parametros.CurrentCell.IsInEditMode == true)
            {
                int i = DGV_parametros.CurrentRow.Index;
                button1.Text = i.ToString();
               // MessageBox.Show(i.ToString());
            }
        }

        private void DGV_parametros_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            CellIsBeingEdited = true;
        }

        private void DGV_parametros_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            Console.WriteLine("Pressed Key to finish editing was -> " + LastKeyPressed);
            // if you wanted to "move" the next active cell to some non-default cell
            // then in this event… you should be able to set the grids CurrentCell to whatever cell you want.
            //   Example, move the active cell to the right as opposed to down when the “Enter” key is pressed 
            CellIsBeingEdited = false;
            Console.WriteLine("No cell is being edited! -----------");
            //Console.WriteLine("DGV_CellEndEdit -> Leave");
        }
      

        private void DGV_parametros_RowsAdded_1(object sender, DataGridViewRowsAddedEventArgs e)
        {
            if (flagInicio)
            {
                modoinser = true;
                //renglonadd = DGV_parametros.CurrentRow.ToString();
                label1.Text = DGV_parametros.Rows.Count.ToString();
                flag2 = false;
            }
        }

        private void DGV_parametros_SelectionChanged(object sender, EventArgs e)
        {
            if (modoinser)
            {
                if (flag2==false)
                {
                     string nombre = DGV_parametros.Rows[posicioncuandoescribe].Cells[1].EditedFormattedValue.ToString().Trim();
                    if (nombre != "")
                    {
                        if (MessageBox.Show("DGV_parametros_SelectionChanged - Quieres Insertar el Nuevo Registro de la posi?" + posicioncuandoescribe, "Confirmacion", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            parametros = new Clase_Reportes();
                            if (parametros.ParametrosReportes("1", "", nombre, ""))
                            {
                                MessageBox.Show("Parametro Ingresado", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                modoinser = false;
                                flagInicio = false;
                                flagModificar = false;
                                llenadoListaParametros();
                                DGV_parametros.FirstDisplayedScrollingRowIndex = DGV_parametros.RowCount - 1;
                                flagInicio = true;
                            }
                            else
                            {
                                MessageBox.Show("Error en el Procedimiento \n", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                modoinser = false;
                            }

                        }
                        else
                        {
                            modoinser = false;
                            DGV_parametros.Rows.RemoveAt(posicioncuandoescribe);
                        }
                    }
                    else
                    {
                        modoinser = false;
                        DGV_parametros.Rows.RemoveAt(posicioncuandoescribe);
                    }
                }
            }//Modificacion
            else //--------------------------------------------------------------
            {
                //Console.WriteLine( );


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
                                parametros = new Clase_Reportes();
                                if (parametros.ParametrosReportes("2", id, nombre, valor))
                                {
                                    MessageBox.Show("Parametro Modificado", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    modoinser = false;
                                    flagInicio = true;
                                    flagModificar = false;
                                    //llenadoListaParametros();
                                    //DGV_parametros.FirstDisplayedScrollingRowIndex = DGV_parametros.RowCount - 1;
                                    //flagInicio = true;
                                }
                                else MessageBox.Show("Error en el Procedimiento \n", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                MessageBox.Show("El Campo no puede quedar vacio ", "Correccion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                DGV_parametros.Rows[posicioncuandoescribe].Cells[1].Value = valorAlEscribir;
                                modoinser = false;
                            }

                        }
                    }
                    flagModificar = false;
                }
            }
        }


        int count = 1;
        private void DGV_parametros_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            //count = DGV_parametros.SelectedRows.Count;
            //Console.WriteLine(DGV_parametros.CurrentRow.Index.ToString() );
            //Console.WriteLine(DGV_parametros.SelectedRows[DGV_parametros.SelectedRows.Count-1].Cells[0]);
            

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
