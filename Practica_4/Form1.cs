using Microsoft.VisualBasic;
using System.Data;
using System.Text.RegularExpressions;

namespace Practica_4
{
    public partial class Form1 : Form
    {
        DataSet ds = new DataSet();
        EquipoBLL logicaEquipos = new EquipoBLL();
        public Form1()
        {
            InitializeComponent();
            Cargar_DataBase();
            Mostrar_Grillas();
        }



        public void Cargar_DataBase()
        {

            ds.Tables.Add(logicaEquipos.Obtener_Equipos());
        }
        public void Mostrar_Grillas()
        {
            try
            {
                Grilla_Equipos.DataSource = null;
                Grilla_Equipos.DataSource = ds;
                Grilla_Equipos.DataMember = "EQUIPOS";

                DataTable data = ds.Tables["EQUIPOS"];

                if (!data.Columns.Contains("VALOR_RESIDUAL"))
                {
                    data.Columns.Add("VALOR_RESIDUAL", typeof(decimal));
                }
                if (!data.Columns.Contains("DIAS_EN_EMPRESA"))
                {
                    data.Columns.Add("DIAS_EN_EMPRESA", typeof(decimal));
                }

                DateTime hoy = DateTime.Today;

                foreach (DataRow fila in data.Rows)
                {
                    if (fila["PRECIO"] != DBNull.Value && fila["FECHA_ALTA"] != DBNull.Value)
                    {
                        decimal valorresidual = Convert.ToDecimal(fila["PRECIO"]);

                        int aniosTranscurridos = hoy.Year - Convert.ToDateTime(fila["FECHA_ALTA"]).Year;

                        for (int i = 0; i < aniosTranscurridos; i++)
                        {
                            valorresidual *= 0.85m;
                        }

                        if (valorresidual < 0) valorresidual = 0;

                        fila["VALOR_RESIDUAL"] = Math.Round(valorresidual, 2);
                    }

                    DateTime fecha_lejana = new DateTime(2999, 1, 1);

                    /// Si la fecha de alta y baja son distintas de null 
                    if (fila["FECHA_ALTA"] != DBNull.Value && Convert.ToDateTime(fila["FECHA_BAJA"]).Year != fecha_lejana.Year)
                    {
                        DateTime Fecha_Alta = Convert.ToDateTime(fila["FECHA_ALTA"]);
                        DateTime Fecha_Baja = Convert.ToDateTime(fila["FECHA_BAJA"]);

                        int dias = (Fecha_Baja - Fecha_Alta).Days;

                        fila["DIAS_EN_EMPRESA"] = dias;

                    }
                    else
                    {
                        /// En caso de que FECHA_BAJA sea null
                        DateTime fecha_alta = Convert.ToDateTime(fila["FECHA_ALTA"]);
                        int dias = (DateTime.Now - fecha_alta).Days;
                        fila["DIAS_EN_EMPRESA"] = dias;
                    }

                }

                DataView dv = new DataView(ds.Tables["EQUIPOS"]);

                dv.RowFilter = $"USO = false";

                Grilla_Baja_Equipos.DataSource = null;
                Grilla_Baja_Equipos.DataSource = dv;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        public void Buscar_Repetidos(string codigo)
        {
            foreach (DataGridViewRow dr in Grilla_Equipos.Rows)
            {
                if (dr.Cells["CODIGO"].Value?.ToString() == codigo)
                {
                    throw new Exception("Este codigo ya existe ");
                }
            }
        }
        private void BTN_AGREGAR_Click(object sender, EventArgs e)
        {
            EquipoBE newEquipo = new EquipoBE();
            try
            {
                string codigo = Interaction.InputBox("Ingresar Codigo ");

                string cadena = "EQ-" + $"{PIKER_ALTA.Value.Year}-" + $"{codigo}";

                Regex validador = new Regex(@"^EQ-\d{4}-\d{3}$");

                if (!validador.IsMatch(cadena))
                    throw new ArgumentException("Ingrese nuevamente el codigo");

                Buscar_Repetidos(codigo);


                string nro_compra1 = Interaction.InputBox("Ingresar nro compra");
                if (!int.TryParse(nro_compra1, out int resulta))
                {
                    throw new ArgumentException(" Ingrese un numero valido ");
                }
                string uso = Interaction.InputBox("Ingrese true or false");
                bool uso1;
                if (string.Equals(uso, "true"))
                {
                    uso1 = true;
                    newEquipo.Fecha_Baja = new DateTime(2999, 1, 1);
                }
                else
                {
                    uso1 = false;
                    newEquipo.Fecha_Baja = PIKER_BAJA.Value;
                }

                string precio = Interaction.InputBox("Ingrese precio del producto");
                if (!decimal.TryParse(precio, out decimal precioconvertido))
                    throw new ArgumentException("Ingrese un precio valido");


                newEquipo.Codigo = cadena;
                newEquipo.Fecha_Alta = PIKER_ALTA.Value;
                newEquipo.Nro_Compra = Convert.ToInt32(nro_compra1);
                newEquipo.Uso = uso1;
                newEquipo.Precio = precioconvertido;

                DataRow newRow = ds.Tables["EQUIPOS"].NewRow();

                newRow["CODIGO"] = newEquipo.Codigo;
                newRow["FECHA_ALTA"] = newEquipo.Fecha_Alta;
                newRow["FECHA_BAJA"] = newEquipo.Fecha_Baja;
                newRow["NRO_COMPRA"] = newEquipo.Nro_Compra;
                newRow["USO"] = newEquipo.Uso;
                newRow["PRECIO"] = newEquipo.Precio;

                ds.Tables["EQUIPOS"].Rows.Add(newRow);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Mostrar_Grillas();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BTN_UPDATE_Click(object sender, EventArgs e)
        {
            try
            {
                logicaEquipos.UPDATE(ds);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FILTRO_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string text = FILTRO.Text;

                DataView dv = new DataView(ds.Tables["EQUIPOS"]);

                if (text.Contains("-"))
                {
                    string[] parte = text.Split('-');

                    dv.RowFilter = $"VALOR_RESIDUAL >= {Convert.ToDecimal(parte[0])} AND VALOR_RESIDUAL <= {Convert.ToDecimal(parte[1])}";
                    dv.Sort = "FECHA_BAJA ASC";

                    Grilla_Filtro.DataSource = null;
                    Grilla_Filtro.DataSource = dv;
                }
                
            }
            catch( Exception ex )
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
