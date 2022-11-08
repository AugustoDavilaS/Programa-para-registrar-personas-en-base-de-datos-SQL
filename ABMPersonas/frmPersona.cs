using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ABMPersonas
{
    public partial class frmPersona : Form
    {
        bool nuevo = false;
        const int tamanio = 10;
        Persona[] aPersonas = new Persona[tamanio]; // arreglo estático de tamanio de Personas 
        int ultimo;

        SqlConnection conexion = new SqlConnection(@"Data Source=CX-OSCAR;Initial Catalog=TUPPI;Integrated Security=True");
        SqlCommand comando = new SqlCommand();
        SqlDataReader lector;

        public frmPersona()
        {
            InitializeComponent();
        }

        private void frmPersona_Load(object sender, EventArgs e)
        {
            habilitar(false);

            //conexion.ConnectionString = @"Data Source=CX-OSCAR;Initial Catalog=TUPPI;Integrated Security=True";
            conexion.Open();

            comando.Connection = conexion;
            comando.CommandType = CommandType.Text;
            comando.CommandText = "SELECT * FROM tipo_documento ORDER BY 2";

            DataTable tabla = new DataTable();
            tabla.Load(comando.ExecuteReader());

            conexion.Close();

            cboTipoDocumento.DataSource = tabla;
            cboTipoDocumento.DisplayMember = "n_tipo_documento";
            cboTipoDocumento.ValueMember = "id_tipo_documento";

            //conexion.ConnectionString = @"Data Source=CX-OSCAR;Initial Catalog=TUPPI;Integrated Security=True";
            conexion.Open();

            comando.Connection = conexion;
            comando.CommandType = CommandType.Text;
            comando.CommandText = "SELECT * FROM estado_civil ORDER BY 2";

            DataTable tabla1 = new DataTable();
            tabla1.Load(comando.ExecuteReader());

            conexion.Close();

            cboEstadoCivil.DataSource = tabla1;
            cboEstadoCivil.DisplayMember = "n_estado_civil";
            cboEstadoCivil.ValueMember = "id_estado_civil";
            cboEstadoCivil.SelectedIndex = 0;

            this.cargarLista(lstPersonas, "personas");

        }
  
        private void cargarLista(ListBox lista,string nombreTabla)
        {
            ultimo = 0;

            conexion.Open();
            comando.Connection = conexion;
            comando.CommandType = CommandType.Text;
            comando.CommandText = "SELECT * FROM " + nombreTabla;
            lector = comando.ExecuteReader();

            while (lector.Read())
            {
                Persona p = new Persona();
                if (!lector.IsDBNull(0))
                    p.pApellido = lector.GetString(0);
                if (!lector.IsDBNull(1))
                    p.pNombres = lector["nombres"].ToString();
                if (!lector.IsDBNull(2))
                    p.pTipoDocumento = Convert.ToInt32(lector["tipo_documento"]);
                if (!lector.IsDBNull(3))
                    p.pDocumento = lector.GetInt32(3);
                if (!lector.IsDBNull(4))
                    p.pEstadoCivil = lector.GetInt32(4);
                if (!lector.IsDBNull(5))
                    p.pSexo = lector.GetInt32(5);
                if (!lector.IsDBNull(6))
                    p.pFallecio = lector.GetBoolean(6);

                aPersonas[ultimo]= p;
                ultimo++;
                if (ultimo==tamanio)
                {
                    MessageBox.Show("Se completó el arreglo!!!");
                    break;
                }
            }
            lector.Close();
            conexion.Close();

            lista.Items.Clear();
            for (int i = 0; i < ultimo; i++)
            {
                lista.Items.Add(aPersonas[i].ToString());
            }
            lista.SelectedIndex = 0;
        }
        private void habilitar(bool x)
        {
            txtApellido.Enabled = x;
            txtNombres.Enabled = x;
            cboTipoDocumento.Enabled = x;
            txtDocumento.Enabled = x;
            cboEstadoCivil.Enabled = x;
            rbtFemenino.Enabled = x;
            rbtMasculino.Enabled = x;
            chkFallecio.Enabled = x;
            btnGrabar.Enabled = x;
            btnCancelar.Enabled = x;
            btnNuevo.Enabled = !x;
            btnEditar.Enabled = !x;
            btnBorrar.Enabled = !x;
            btnSalir.Enabled = !x;
            lstPersonas.Enabled = !x;
        }

        private void limpiar()
        {
            txtApellido.Text = "";
            txtNombres.Text = "";
            cboTipoDocumento.SelectedIndex = 0;
            txtDocumento.Text = "";
            cboEstadoCivil.SelectedIndex = -1;
            rbtFemenino.Checked = false;
            rbtMasculino.Checked = false;
            chkFallecio.Checked = false;
        }
      
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            nuevo = true;
            habilitar(true);
            limpiar();
            txtApellido.Focus();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            habilitar(true);
            txtDocumento.Enabled = false; //deshabilitar la PK
            txtApellido.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            
            limpiar();
            habilitar(false);
            nuevo = false;
            cargarLista(lstPersonas, "Personas");
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            //validar todo los datos!!!
            Persona p = new Persona();
            p.pApellido = txtApellido.Text;
            p.pNombres = txtNombres.Text;
            p.pDocumento = Convert.ToInt32(txtDocumento.Text);
            p.pTipoDocumento = Convert.ToInt32(cboTipoDocumento.SelectedValue);
            p.pEstadoCivil = Convert.ToInt32(cboEstadoCivil.SelectedValue);
            p.pFallecio = chkFallecio.Checked;
            if (rbtFemenino.Checked)
                p.pSexo = 1;
            else
                p.pSexo = 2;

            if (nuevo) //(nuevo==true) es equivalente
            {

                // VALIDAR QUE NO EXISTA LA PK !!!!!! (SI NO ES AUTOINCREMENTAL / IDENTITY)



                // insert con sentencia SQL tradicional
                string SqlInsert = "INSERT INTO Personas VALUES('" + p.pApellido + "','"
                                                                + p.pNombres + "',"
                                                                + p.pTipoDocumento + ","
                                                                + p.pDocumento + ","
                                                                + p.pEstadoCivil + ","
                                                                + p.pSexo + ",'"
                                                                + p.pFallecio + "')";

                // insert usando parámetros
               
                //string insertQuery = "INSERT INTO Personas VALUES (@apellido, @nombres, @tipo_documento, @documento, @estado_civil, @sexo, @fallecio)";

                //conexion.ConnectionString = @"Data Source=CX-OSCAR;Initial Catalog=TUPPI;Integrated Security=True";
                conexion.Open();

                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;
                comando.CommandText = SqlInsert;
                comando.ExecuteNonQuery();

                conexion.Close();

            }
            else
            {
                //update...

                // update usando parámetros
                string updateQuery = "UPDATE Personas SET apellido=@apellido, " +
                                                         "nombres=@nombres, " +
                                                         "tipo_documento=@tipo_documento, " +
                                                         "estado_civil=@estado_civil, " +
                                                         "sexo=@sexo, " +
                                                         "fallecio=@fallecio" +
                                                         " WHERE documento=" + p.pDocumento;

                insertar_o_updatear_Db(updateQuery,p);
            }

            habilitar(false);
            nuevo = false;
            cargarLista(lstPersonas, "Personas");
        }

        private void insertar_o_updatear_Db(string query,Persona oPersona)
        {
            conexion.Open();
            comando.Connection = conexion;
            comando.CommandType = CommandType.Text;

            comando.Parameters.AddWithValue("@apellido", oPersona.pApellido);
            comando.Parameters.AddWithValue("@nombres", oPersona.pNombres);
            comando.Parameters.AddWithValue("@tipo_documento", oPersona.pTipoDocumento);
            comando.Parameters.AddWithValue("@documento", oPersona.pDocumento);
            comando.Parameters.AddWithValue("@estado_civil", oPersona.pEstadoCivil);
            comando.Parameters.AddWithValue("@sexo", oPersona.pSexo);
            comando.Parameters.AddWithValue("@fallecio", oPersona.pFallecio);

            comando.CommandText = query;
            comando.ExecuteNonQuery();
            conexion.Close();
        }


        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro de abandonar la aplicación ?",
                "SALIR", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                
                this.Close();
        }

        private void lstPersonas_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.cargarCampos(lstPersonas.SelectedIndex);
        }

        private void cargarCampos(int posicion)
        {
            //desde el arreglo...
            txtApellido.Text = aPersonas[posicion].pApellido;
            txtNombres.Text = aPersonas[posicion].pNombres;
            cboTipoDocumento.SelectedValue = aPersonas[posicion].pTipoDocumento;
            txtDocumento.Text = aPersonas[posicion].pDocumento.ToString();
            cboEstadoCivil.SelectedValue = aPersonas[posicion].pEstadoCivil;
            if (aPersonas[posicion].pSexo == 1)
                rbtFemenino.Checked = true;
            else
                rbtMasculino.Checked = true;
            chkFallecio.Checked = aPersonas[posicion].pFallecio;
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Está seguro de eliminar a "+aPersonas[lstPersonas.SelectedIndex]+" ?",
                "BORRANDO",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button2)==DialogResult.Yes)
            {
                //Delete ---> update de un campo logico!!!
                //Delete ---> borramos el objeto seleccionado en la lista
                string consultaSql = "DELETE FROM personas WHERE documento=" + aPersonas[lstPersonas.SelectedIndex].pDocumento;
                conexion.Open();
                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;
                comando.CommandText = consultaSql;
                comando.ExecuteNonQuery();
                conexion.Close();

                cargarLista(lstPersonas, "personas");
            }
        }
    }
}
