using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Datos
{
    public class ConexionSQL
    {

        string cadena = null;
        SqlConnection cnn;
        string query = null;


        public void abrirConexion()
        {
            cadena = "Data Source = SQL5061.site4now.net; Initial Catalog = db_a77e97_rentacar; User Id = db_a77e97_rentacar_admin; Password = sqlserver.2021";
            cnn = new SqlConnection(cadena);
            try
            {
                cnn.Open();

            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo abrir la conexion");

            }
        }

        public void cerrarConexion()
        {
            cnn.Close();
        }

        public DataTable consultarVehiculos()
        {
            
            DataTable dt = new DataTable();
           // SqlCommand command;


            try
            {
                abrirConexion();


                query = "SELECT[placa],[modelo],[marca],[annio],[estado],[color],[combustible],[costoalquiler],[tipo]FROM[dbo].[Vehiculos]";

               // command = new SqlCommand(query, cnn);

                SqlDataAdapter da = new SqlDataAdapter(query, cnn);

                da.Fill(dt);
                //dt.Load(command.ExecuteReader());

                //dataReader.Close();
                //command.Dispose();
                
                cnn.Close();


                return dt;
            }
            catch (Exception ex)
            {
                cerrarConexion();
                throw new Exception("No se pudo cargar en DataTable los datos, detalles: " + ex.Message);
            }
            finally
            {
                cerrarConexion();
            }
        }


        public void agregarDatos(string placa, string modelo, string marca, string annio, string estado, string color, string combustible, float costo, string tipo)
        {
            try
            {
                abrirConexion();
                query = "INSERT INTO[dbo].[Vehiculos]([placa],[modelo],[marca],[annio],[estado],[color],[combustible],[costoalquiler],[tipo]) VALUES(@placa,@modelo,@marca ,@annio,@estado,@color,@combustible,@costo,@tipo)";

                
                SqlCommand bd = new SqlCommand(query, cnn);

                bd.Parameters.AddWithValue("@placa", placa);
                bd.Parameters.AddWithValue("@modelo", modelo);
                bd.Parameters.AddWithValue("@marca", marca);
                bd.Parameters.AddWithValue("@annio", annio);
                bd.Parameters.AddWithValue("@estado", estado);
                bd.Parameters.AddWithValue("@color", color);
                bd.Parameters.AddWithValue("@combustible", combustible);
                bd.Parameters.AddWithValue("@costo", costo);
                bd.Parameters.AddWithValue("@tipo", tipo);

                bd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                cerrarConexion();
                throw new Exception("No se pudo agregar los datos, detalles: " + ex.Message);
            }
            finally
            {
                cerrarConexion();
            }
        }


        public void modificar(string placa, string modelo, string marca, string annio, string estado, string color, string combustible, float costo, string tipo)
        {

            try
            {
                abrirConexion();
                query = "UPDATE Vehiculos set modelo = '" + modelo + "', marca = '" + marca + "', annio ='" + annio + "', estado = '" + estado + "',color = '" + color + "',combustible = '" + combustible + "',costoalquiler = '" + costo + "',tipo = '" + tipo + "'where placa= '" + placa + "' ";


                SqlCommand bd = new SqlCommand(query, cnn);
                bd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                cerrarConexion();
                throw new Exception("No se pudo agregar los datos, detalles: " + ex.Message);
            }
            finally
            {
                cerrarConexion();
            }
        }


        public Boolean verificarVehiculo(string placa)
        {
            DataTable dt = new DataTable();
            try
            {
                abrirConexion();

                
                query = "SELECT CASE WHEN EXISTS ( SELECT* from Vehiculos WHERE placa = '" + placa + "')THEN 'TRUE' ELSE 'FALSE' END";

                SqlDataAdapter da = new SqlDataAdapter(query, cnn);

                da.Fill(dt);

                cnn.Close();
               

            }
            catch (Exception ex)
            {
                cerrarConexion();
                throw new Exception("No se encontró la placa, detalles: " + ex.Message);
            }
            finally
            {
                cerrarConexion();
            }

            //if (dt.Rows[0][0].ToString() == 1.ToString())
            //{
            //    return true;
            //}
            //else
            //{
            //    return false;
            //}

            if (dt.Rows[0][0].ToString() == "TRUE")
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public DataTable consultarVehiculo(string placa)
        {
            DataTable dt = new DataTable();
            try
            {
                abrirConexion();

                query = "SELECT * from Vehiculos WHERE placa = '" + placa + "'";
               

                SqlDataAdapter da = new SqlDataAdapter(query, cnn);

                da.Fill(dt);

                cnn.Close();

                return dt;


            }
            catch (Exception ex)
            {
                cerrarConexion();
                throw new Exception("No se encontró la placa, detalles: " + ex.Message);
            }
            finally
            {
                cerrarConexion();
            }


        }


        public void eliminarVehiculo(string placa)
        {
            try
            {
                abrirConexion();

                query = "Delete from Vehiculos WHERE placa = '" + placa + "'";

                SqlCommand bd = new SqlCommand(query, cnn);
                bd.ExecuteNonQuery();


            }
            catch (Exception ex)
            {
                cerrarConexion();
                throw new Exception("No se encontró la placa, detalles: " + ex.Message);
            }
            finally
            {
                cerrarConexion();
            }


        }

        public void montoRecaudadoVehiculo(string fecha)
        {
            try
            {
                abrirConexion();

                query = "SELECT SUM(costoalquiler) from Alquiler WHERE fechaalquiler = '" + fecha + "'";

                SqlCommand bd = new SqlCommand(query, cnn);
                bd.ExecuteNonQuery();


            }
            catch (Exception ex)
            {
                cerrarConexion();
                throw new Exception("No se encontró la placa, detalles: " + ex.Message);
            }
            finally
            {
                cerrarConexion();
            }


        }

        public Boolean validarUsuario(string userName, string passWord)
        {
            DataTable dt = new DataTable();
            try
            {
                abrirConexion();

                query = "SELECT * from Users WHERE uname = '" + userName + "' and Pwd= '" + passWord + "'";

                SqlDataAdapter da = new SqlDataAdapter(query, cnn);

                da.Fill(dt);

                cnn.Close();


                if(dt.Rows.Count == 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }


            }
            catch (Exception ex)
            {
                cerrarConexion();
                throw new Exception("No se encontró la placa, detalles: " + ex.Message);
            }
            finally
            {
                cerrarConexion();
            }

        }


        public DataTable Modelo()
        {
            
            DataTable tabla = new DataTable();
            try
            {

                abrirConexion();

                query = "SELECT modelo from Modelo";

                SqlDataAdapter da = new SqlDataAdapter(query, cnn);

                da.Fill(tabla);

                cnn.Close();

               
            }
            catch (Exception ex)
            {
                cerrarConexion();
                throw new Exception("No se pudo agregar los datos, detalles: " + ex.Message);
            }
            finally
            {
                cerrarConexion();
            }

            return tabla;
        }

        public DataTable Marca()
        {

            DataTable tabla = new DataTable();
            try
            {

                abrirConexion();

                query = "SELECT marca from Marca";

                SqlDataAdapter da = new SqlDataAdapter(query, cnn);

                da.Fill(tabla);

                cnn.Close();


            }
            catch (Exception ex)
            {
                cerrarConexion();
                throw new Exception("No se pudo agregar los datos, detalles: " + ex.Message);
            }
            finally
            {
                cerrarConexion();
            }

            return tabla;
        }

        public DataTable Color()
        {

            DataTable tabla = new DataTable();
            try
            {

                abrirConexion();

                query = "SELECT color from Color";

                SqlDataAdapter da = new SqlDataAdapter(query, cnn);

                da.Fill(tabla);

                cnn.Close();


            }
            catch (Exception ex)
            {
                cerrarConexion();
                throw new Exception("No se pudo agregar los datos, detalles: " + ex.Message);
            }
            finally
            {
                cerrarConexion();
            }

            return tabla;
        }

        public DataTable Combustible()
        {

            DataTable tabla = new DataTable();
            try
            {

                abrirConexion();

                query = "SELECT combustible from Combustible";

                SqlDataAdapter da = new SqlDataAdapter(query, cnn);

                da.Fill(tabla);

                cnn.Close();


            }
            catch (Exception ex)
            {
                cerrarConexion();
                throw new Exception("No se pudo agregar los datos, detalles: " + ex.Message);
            }
            finally
            {
                cerrarConexion();
            }

            return tabla;
        }

        public DataTable Tipo()
        {

            DataTable tabla = new DataTable();
            try
            {

                abrirConexion();

                query = "SELECT tipo from Tipo";

                SqlDataAdapter da = new SqlDataAdapter(query, cnn);

                da.Fill(tabla);

                cnn.Close();


            }
            catch (Exception ex)
            {
                cerrarConexion();
                throw new Exception("No se pudo agregar los datos, detalles: " + ex.Message);
            }
            finally
            {
                cerrarConexion();
            }

            return tabla;
        }

        ///********************** MODELO **************************

        public void insertarModelo(string modelo)
        {
            try
            {
                abrirConexion();
                query = "INSERT INTO Modelo VALUES (@modelo)";


                SqlCommand bd = new SqlCommand(query, cnn);

                bd.Parameters.AddWithValue("@modelo", modelo);


                bd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                cerrarConexion();
                throw new Exception("No se pudo agregar los datos, detalles: " + ex.Message);
            }
            finally
            {
                cerrarConexion();
            }
        }

        public void modificarModelo(string modelo, string nuevo)
        {

            try
            {
                abrirConexion();
                query = "UPDATE Modelo set modelo = '" + nuevo  + "'where modelo= '" + modelo + "' ";


                SqlCommand bd = new SqlCommand(query, cnn);
                bd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                cerrarConexion();
                throw new Exception("No se pudo agregar los datos, detalles: " + ex.Message);
            }
            finally
            {
                cerrarConexion();
            }
        }



        public void eliminarModelo(string modelo)
        {
            try
            {
                abrirConexion();

                query = "Delete from Modelo WHERE modelo = '" + modelo + "'";

                SqlCommand bd = new SqlCommand(query, cnn);
                bd.ExecuteNonQuery();


            }
            catch (Exception ex)
            {
                cerrarConexion();
                throw new Exception("No se encontró la placa, detalles: " + ex.Message);
            }
            finally
            {
                cerrarConexion();
            }
        }

        ///********************** MARCA **************************
        public void insertarMarca(string marca)
        {
            try
            {
                abrirConexion();
                query = "INSERT INTO Marca VALUES (@marca)";


                SqlCommand bd = new SqlCommand(query, cnn);

                bd.Parameters.AddWithValue("@marca", marca);

                bd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                cerrarConexion();
                throw new Exception("No se pudo agregar los datos, detalles: " + ex.Message);
            }
            finally
            {
                cerrarConexion();
            }
        }

        public void modificarMarca(string marca, string nuevo)
        {

            try
            {
                abrirConexion();
                query = "UPDATE Marca set marca = '" + nuevo + "'where marca= '" + marca + "' ";


                SqlCommand bd = new SqlCommand(query, cnn);
                bd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                cerrarConexion();
                throw new Exception("No se pudo agregar los datos, detalles: " + ex.Message);
            }
            finally
            {
                cerrarConexion();
            }
        }



        public void eliminarMarca(string marca)
        {
            try
            {
                abrirConexion();

                query = "Delete from Marca WHERE marca = '" + marca + "'";

                SqlCommand bd = new SqlCommand(query, cnn);
                bd.ExecuteNonQuery();


            }
            catch (Exception ex)
            {
                cerrarConexion();
                throw new Exception("No se encontró la placa, detalles: " + ex.Message);
            }
            finally
            {
                cerrarConexion();
            }
        }


        ///********************** COLOR **************************
        public void insertarColor(string color)
        {
            try
            {
                abrirConexion();
                query = "INSERT INTO Color VALUES (@color)";


                SqlCommand bd = new SqlCommand(query, cnn);

                bd.Parameters.AddWithValue("@color", color);

                bd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                cerrarConexion();
                throw new Exception("No se pudo agregar los datos, detalles: " + ex.Message);
            }
            finally
            {
                cerrarConexion();
            }
        }

        public void modificarColor(string color, string nuevo)
        {

            try
            {
                abrirConexion();
                query = "UPDATE Color set color = '" + nuevo + "'where color= '" + color + "' ";


                SqlCommand bd = new SqlCommand(query, cnn);
                bd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                cerrarConexion();
                throw new Exception("No se pudo agregar los datos, detalles: " + ex.Message);
            }
            finally
            {
                cerrarConexion();
            }
        }



        public void eliminarColor(string color)
        {
            try
            {
                abrirConexion();

                query = "Delete from Color WHERE color = '" + color + "'";

                SqlCommand bd = new SqlCommand(query, cnn);
                bd.ExecuteNonQuery();


            }
            catch (Exception ex)
            {
                cerrarConexion();
                throw new Exception("No se encontró la placa, detalles: " + ex.Message);
            }
            finally
            {
                cerrarConexion();
            }
        }



        ///********************** COMBUSTIBLE **************************
        public void insertarCombustible(string combustible)
        {
            try
            {
                abrirConexion();
                query = "INSERT INTO Combustible VALUES (@combustible)";


                SqlCommand bd = new SqlCommand(query, cnn);

                bd.Parameters.AddWithValue("@combustible", combustible);

                bd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                cerrarConexion();
                throw new Exception("No se pudo agregar los datos, detalles: " + ex.Message);
            }
            finally
            {
                cerrarConexion();
            }
        }

        public void modificarCombustible(string combustible, string nuevo)
        {

            try
            {
                abrirConexion();
                query = "UPDATE Combustible set combustible = '" + nuevo + "'where combustible= '" + combustible + "' ";


                SqlCommand bd = new SqlCommand(query, cnn);
                bd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                cerrarConexion();
                throw new Exception("No se pudo agregar los datos, detalles: " + ex.Message);
            }
            finally
            {
                cerrarConexion();
            }
        }



        public void eliminarCombustible(string combustible)
        {
            try
            {
                abrirConexion();

                query = "Delete from Combustible WHERE combustible = '" + combustible + "'";

                SqlCommand bd = new SqlCommand(query, cnn);
                bd.ExecuteNonQuery();


            }
            catch (Exception ex)
            {
                cerrarConexion();
                throw new Exception("No se encontró la placa, detalles: " + ex.Message);
            }
            finally
            {
                cerrarConexion();
            }
        }


        ///********************** TIPO **************************
        public void insertarTipo(string tipo)
        {
            try
            {
                abrirConexion();
                query = "INSERT INTO Tipo VALUES (@tipo)";


                SqlCommand bd = new SqlCommand(query, cnn);

                bd.Parameters.AddWithValue("@tipo", tipo);

                bd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                cerrarConexion();
                throw new Exception("No se pudo agregar los datos, detalles: " + ex.Message);
            }
            finally
            {
                cerrarConexion();
            }
        }

        public void modificarTipo(string tipo, string nuevo)
        {

            try
            {
                abrirConexion();
                query = "UPDATE Tipo set tipo = '" + nuevo + "'where tipo= '" + tipo + "' ";


                SqlCommand bd = new SqlCommand(query, cnn);
                bd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                cerrarConexion();
                throw new Exception("No se pudo agregar los datos, detalles: " + ex.Message);
            }
            finally
            {
                cerrarConexion();
            }
        }



        public void eliminarTipo(string tipo)
        {
            try
            {
                abrirConexion();

                query = "Delete from Tipo WHERE tipo = '" + tipo + "'";

                SqlCommand bd = new SqlCommand(query, cnn);
                bd.ExecuteNonQuery();


            }
            catch (Exception ex)
            {
                cerrarConexion();
                throw new Exception("No se encontró la placa, detalles: " + ex.Message);
            }
            finally
            {
                cerrarConexion();
            }
        }

        public DataTable consultarCriterios(string modelo, string marca, string annio, int costo, string color, string combustible, string tipo)
        {
            try
            {
                abrirConexion();

                query = "SELECT placa, modelo, marca, YEAR(annio) as annio, estado, color, combustible, costoalquiler, tipo from Vehiculos WHERE modelo = '" + modelo + "' and marca= '" + marca + "' and  year(annio)= '" + annio + "' and costoalquiler <=" + costo + " and color= '" + color +
                    "' and combustible= '" + combustible + "' and estado = 'Disponible' and tipo= '" + tipo + "'";

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(query, cnn);

                da.Fill(dt);
                //dt.Load(command.ExecuteReader());

                //dataReader.Close();
                //command.Dispose();

                cnn.Close();


                return dt;


            }
            catch (Exception ex)
            {
                cerrarConexion();
                throw new Exception("No se encontró la placa, detalles: " + ex.Message);
            }
            finally
            {
                cerrarConexion();
            }
        }

        public Boolean verificarCliente(string id)
        {
            DataTable dt = new DataTable();
            try
            {
                abrirConexion();


                query = "SELECT CASE WHEN EXISTS ( SELECT * from Cliente WHERE id = '" + id + "')THEN 'TRUE' ELSE 'FALSE' END";

                SqlDataAdapter da = new SqlDataAdapter(query, cnn);

                da.Fill(dt);

                cnn.Close();


            }
            catch (Exception ex)
            {
                cerrarConexion();
                throw new Exception("No se encontró la placa, detalles: " + ex.Message);
            }
            finally
            {
                cerrarConexion();
            }

            if (dt.Rows[0][0].ToString() == "TRUE")
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public void agregarCliente(string id, string nombre, string primerapellido, string segundoapellido, string fecha, string residencia, string direccion, string tipo)
        {
            try
            {
                abrirConexion();
                query = "INSERT INTO[dbo].[Cliente]([id],[nombre],[primerapellido],[segundoapellido],[fechanacimiento],[residencia],[direccion],[nacionalextranjero]) VALUES(@id,@nombre,@primerapellido ,@segundoapellido,@fecha,@residencia,@direccion,@tipo)";


                SqlCommand bd = new SqlCommand(query, cnn);

                bd.Parameters.AddWithValue("@id", id);
                bd.Parameters.AddWithValue("@nombre", nombre);
                bd.Parameters.AddWithValue("@primerapellido", primerapellido);
                bd.Parameters.AddWithValue("@segundoapellido", segundoapellido);
                bd.Parameters.AddWithValue("@fecha", fecha);
                bd.Parameters.AddWithValue("@residencia", residencia);
                bd.Parameters.AddWithValue("@direccion", direccion);

                if(tipo == "Nacional")
                {
                    bd.Parameters.AddWithValue("@tipo", 1);
                }
                else
                {
                    bd.Parameters.AddWithValue("@tipo", 0);
                }
               

                bd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                cerrarConexion();
                throw new Exception("No se pudo agregar los datos, detalles: " + ex.Message);
            }
            finally
            {
                cerrarConexion();
            }
        }


        public void agregarTarjeta(string numtarjeta, string fecha, string tipo, string id )
        {
            try
            {
                abrirConexion();
                query = "INSERT INTO[dbo].[tarjeta]([numtarjeta],[fechaexpiracion],[tipoTarjeta],[idcliente]) VALUES(@numero,@fecha,@tipo ,@id)";


                SqlCommand bd = new SqlCommand(query, cnn);

                bd.Parameters.AddWithValue("@id", id);
                bd.Parameters.AddWithValue("@numero", numtarjeta);
                bd.Parameters.AddWithValue("@fecha", fecha);
                bd.Parameters.AddWithValue("@tipo", tipo);



                bd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                cerrarConexion();
                throw new Exception("No se pudo agregar los datos, detalles: " + ex.Message);
            }
            finally
            {
                cerrarConexion();
            }
        }

        public void agregarSeguro(string montoseguro, string perdidatotal, string gastoocupante, string id)
        {
            try
            {
                abrirConexion();


                query = "Delete from Seguro WHERE idcliente = '" + id + "'";

                SqlCommand bd = new SqlCommand(query, cnn);
                bd.ExecuteNonQuery();


                query = "INSERT INTO[dbo].[Seguro]([montoseguro],[perdidatotal],[gastoocupante],[idcliente]) VALUES(@montoseguro,@perdidatotal,@gastoocupante ,@id)";


                 bd = new SqlCommand(query, cnn);

                bd.Parameters.AddWithValue("@id", id);
                bd.Parameters.AddWithValue("@montoseguro", montoseguro);
                bd.Parameters.AddWithValue("@perdidatotal", perdidatotal);
                bd.Parameters.AddWithValue("@gastoocupante", gastoocupante);

                

                bd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                cerrarConexion();
                throw new Exception("No se pudo agregar los datos, detalles: " + ex.Message);
            }
            finally
            {
                cerrarConexion();
            }
        }

        public void agregarAlquiler(string id, string placa, string fechasalida, string fechaentrega, Boolean existeSeguro)
        {
            try
            {
                

                float costo = obtenerCosto(placa);
                string numTarjeta = obtenerNumTarjeta(id);

                int seguro = 0;

                Boolean existe = false;


                if (existeSeguro == true)
                {
                    seguro = obtenerSeguro(id);
                    existe = existeSeguro;
                }
                else
                {

                    existe = existeSeguro;
                }
                

                
                modificarEstado(placa);



                abrirConexion();

                query = "INSERT INTO[dbo].[Alquiler]([idcliente],[placa],[fechasalida],[fechaentrega],[estadoalquiler],[costo],[numTarjeta],[seguro]) VALUES(@id,@placa,@fechasalida ,@fechaentrega,@estadoalquiler,@costo,@numTarjeta,@seguro)";

                SqlCommand bd = new SqlCommand(query, cnn);

                bd.Parameters.AddWithValue("@id", id);
                bd.Parameters.AddWithValue("@placa", placa);
                bd.Parameters.AddWithValue("@fechasalida", fechasalida);
                bd.Parameters.AddWithValue("@fechaentrega", fechaentrega);
                bd.Parameters.AddWithValue("@estadoalquiler", "Ocupado");
                bd.Parameters.AddWithValue("@costo", costo);
                bd.Parameters.AddWithValue("@numTarjeta", numTarjeta);


                if (existe == true)
                {
                    bd.Parameters.AddWithValue("@seguro", seguro);

                }
                else
                {

                    bd.Parameters.AddWithValue("@seguro", DBNull.Value);
                }

                bd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                cerrarConexion();
                throw new Exception("No se pudo agregar los datos, detalles: " + ex.Message);
            }
            finally
            {
                cerrarConexion();
            }
        }

        public void modificarEstado(string placa)
        {

            try
            {
                abrirConexion();
                query = "UPDATE Vehiculos set estado = 'Ocupado' where placa= '" + placa + "'";

                 
                SqlCommand bd = new SqlCommand(query, cnn);
                bd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                cerrarConexion();
                throw new Exception("No se pudo agregar los datos, detalles: " + ex.Message);
            }
            finally
            {
                cerrarConexion();
            }
        }

        public string obtenerNumTarjeta(string idcliente)
        {
            string num = null;
            DataTable tabla = new DataTable();
            try
            {

                abrirConexion();

                query = "SELECT numtarjeta from tarjeta where idcliente = '" + idcliente + "'" ;

                SqlDataAdapter da = new SqlDataAdapter(query, cnn);
                da.Fill(tabla);

                cnn.Close();

                num = tabla.Rows[0][0].ToString();


            }
            catch (Exception ex)
            {
                cerrarConexion();
                throw new Exception("No se pudo agregar los datos, detalles: " + ex.Message);
            }
            finally
            {
                cerrarConexion();
            }

            return num;
        }

        public float obtenerCosto(string placa)
        {
            float costo;
            DataTable tabla = new DataTable();
            try
            {

                abrirConexion();

                query = "SELECT costoalquiler from Vehiculos where placa ='" + placa + "'";

                SqlDataAdapter da = new SqlDataAdapter(query, cnn);

                da.Fill(tabla);

                cnn.Close();


                costo = float.Parse(  tabla.Rows[0][0].ToString()  );

            }
            catch (Exception ex)
            {
                cerrarConexion();
                throw new Exception("No se pudo agregar los datos, detalles: " + ex.Message);
            }
            finally
            {
                cerrarConexion();
            }

            return costo;
        }

        public int obtenerSeguro(string idcliente)
        {
            int num = 0;
            DataTable tabla = new DataTable();
            try
            {

                abrirConexion();

                query = "SELECT numseguro from Seguro where idcliente = '" + idcliente + "'";

                SqlDataAdapter da = new SqlDataAdapter(query, cnn);
                da.Fill(tabla);

                cnn.Close();

                num = Int32.Parse(tabla.Rows[0][0].ToString() );


            }
            catch (Exception ex)
            {
                cerrarConexion();
                throw new Exception("No se pudo agregar los datos, detalles: " + ex.Message);
            }
            finally
            {
                cerrarConexion();
            }

            return num;
        }

        public Boolean verificarSeguro(string idcliente)
        {
            DataTable dt = new DataTable();
            try
            {
                abrirConexion();


                query = "SELECT CASE WHEN EXISTS ( SELECT* from Seguro WHERE idcliente = '" + idcliente + "')THEN 'TRUE' ELSE 'FALSE' END";

                SqlDataAdapter da = new SqlDataAdapter(query, cnn);

                da.Fill(dt);

                cnn.Close();


            }
            catch (Exception ex)
            {
                cerrarConexion();
                throw new Exception("No se encontró la placa, detalles: " + ex.Message);
            }
            finally
            {
                cerrarConexion();
            }

            if (dt.Rows[0][0].ToString() == "TRUE")
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public DataTable consultarAlquileres(string idcliente)
        {
            try
            {
                abrirConexion();

                query = "SELECT * from Alquiler WHERE idcliente = '" + idcliente + "' and estadoalquiler = 'Ocupado'";

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(query, cnn);

                da.Fill(dt);
                //dt.Load(command.ExecuteReader());

                //dataReader.Close();
                //command.Dispose();

                cnn.Close();


                return dt;


            }
            catch (Exception ex)
            {
                cerrarConexion();
                throw new Exception("No se encontró la placa, detalles: " + ex.Message);
            }
            finally
            {
                cerrarConexion();
            }
        }


        public void regresarAlquiler(string id)
        {

            try
            {
                abrirConexion();

                query = "UPDATE Alquiler set estadoalquiler = 'Disponible' where consecutivo= '" + id + "'";


                SqlCommand bd = new SqlCommand(query, cnn);
                bd.ExecuteNonQuery();


                query = "UPDATE Vehiculos set estado = 'Disponible' FROM Vehiculos INNER JOIN Alquiler ON Vehiculos.placa = Alquiler.placa WHERE Vehiculos.placa in (SELECT placa from Alquiler WHERE consecutivo = " + id + ")";


                SqlCommand bd2 = new SqlCommand(query, cnn);
                bd2.ExecuteNonQuery();


            }
            catch (Exception ex)
            {
                cerrarConexion();
                throw new Exception("No se pudo agregar los datos, detalles: " + ex.Message);
            }
            finally
            {
                cerrarConexion();
            }
        }

        public int consultarRecaudado(string fecha)
        {

            DataTable dt = new DataTable();
            try
            {
                abrirConexion();


                query = "SELECT SUM(costo) as costo from Alquiler WHERE fechasalida = '" + fecha
                    + "'";
                SqlDataAdapter da = new SqlDataAdapter(query, cnn);

                da.Fill(dt);
                //dt.Load(command.ExecuteReader());

                //dataReader.Close();
                //command.Dispose();

                cnn.Close();

             


            }
            catch (Exception ex)
            {
                cerrarConexion();
                //throw new Exception("No se encontró la fecha, detalles: " + ex.Message);
            }
            finally
            {
                cerrarConexion();
            }


            if (dt.Rows.Count == 0)
            {
                return 0;
            }
            else
            {
                return Int32.Parse(dt.Rows[0][0].ToString());
            }
        }



    }
}
