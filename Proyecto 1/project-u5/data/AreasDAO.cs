using MySql.Data.MySqlClient;
using project_u5.model;
using project_u5.view;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace project_u5.data
{
    public class AreasDAO
    {
        public static List<CLSArea> GetAll()
        {
            List<CLSArea> stores = new List<CLSArea>();
            if (Connection.Connect())
            {
                //MySqlTransaction trans = Connection.CurrentConnection.BeginTransaction();
                try
                {
                    String sentence = "obtenerTodasAreas";

                    MySqlCommand command = new MySqlCommand(sentence, Connection.CurrentConnection);
                    command.CommandType = CommandType.StoredProcedure;
                    //command.CommandText = sentence;
                    //command.Connection = Connection.CurrentConnection;
                    DataTable dt = new DataTable();
                    MySqlDataAdapter da = new MySqlDataAdapter();
                    
                    da.SelectCommand = command;
                    da.Fill(dt);

                    //Crear un objeto place por cada fila de la tabla y añadirlo a la lista
                    stores = new List<CLSArea>();
                    foreach (DataRow fila in dt.Rows)
                    {
                        CLSArea area = new CLSArea(
                            Convert.ToInt32(fila["id"]),
                            fila["nombre"].ToString(),
                            fila["ubicacion"].ToString()
                            );
                        stores.Add(area);
                    }
                    command.Dispose();
                    //trans.Commit();
                    return stores;
                }
                catch (Exception e)
                {
                    //MessageBox.Show("aqui");
                    //trans.Rollback();
                    return stores;
                }
                finally
                {
                    Connection.Disconnect();
                }
            }
            else
            {
                return stores;
            }
        }

        public static CLSArea Get(int areaID)
        {
            CLSArea area = null;
            if (Connection.Connect())
            {
                //MySqlTransaction trans = Connection.CurrentConnection.BeginTransaction();
                try
                {
                    String sentence = "obtenerArea";

                    MySqlCommand command = new MySqlCommand(sentence, Connection.CurrentConnection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("AreaID", areaID);
                    DataTable dt = new DataTable();
                    MySqlDataAdapter da = new MySqlDataAdapter();
                    da.SelectCommand = command;
                    da.Fill(dt);

                    //Crear un objeto place por cada fila de la tabla y añadirlo a la lista
                    foreach (DataRow fila in dt.Rows)
                    {
                        area = new CLSArea(
                            Convert.ToInt32(fila["id"]),
                            fila["nombre"].ToString(),
                            fila["ubicacion"].ToString()
                            );
                    }
                    command.Dispose();
                    //trans.Commit();
                    return area;
                }
                catch (Exception e)
                {
                    //trans.Rollback();
                    return area;
                }
                finally
                {
                    Connection.Disconnect();
                }
            }
            else
            {
                return area;
            }
        }

        public static int AddArea(CLSArea a)
        {
            if (Connection.Connect())
            {
                MySqlTransaction trans = Connection.CurrentConnection.BeginTransaction();
                try
                {
                    String sentence = "agregarArea";

                    MySqlCommand command = new MySqlCommand(sentence, Connection.CurrentConnection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("AreaNombre", a.Nombre);
                    command.Parameters.AddWithValue("AreaUbicacion", a.Ubicacion);

                    command.ExecuteNonQuery();
                    command.Dispose();

                    sentence = "select last_insert_id();";
                    command = new MySqlCommand(sentence, Connection.CurrentConnection);
                    command.Dispose();
                    int id = Convert.ToInt32(command.ExecuteScalar());

                    trans.Commit();
                    return id;
                }
                catch (Exception e)
                {
                    trans.Rollback();
                    return 0;
                }
                finally
                {
                    Connection.Disconnect();
                }
            }
            else
            {
                return 0;
            }
        }

        public static bool UpdateArea(CLSArea a)
        {
            if (Connection.Connect())
            {
                MySqlTransaction trans = Connection.CurrentConnection.BeginTransaction();
                try
                {
                    String sentence = "actualizarArea";

                    MySqlCommand command = new MySqlCommand(sentence, Connection.CurrentConnection);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("areaID", a.ID);
                    command.Parameters.AddWithValue("areaNombre", a.Nombre);
                    command.Parameters.AddWithValue("areaUbicacion", a.Ubicacion);

                    command.ExecuteNonQuery();
                    command.Dispose();
                    trans.Commit();

                    return true;
                }
                catch (Exception e)
                {
                    trans.Rollback();
                    return false;
                }
                finally
                {
                    Connection.Disconnect();
                }
            }
            else
            {
                return false;
            }
        }

        public static int DeleteArea(int areaID)
        {
            if (Connection.Connect())
            {
                MySqlTransaction trans = Connection.CurrentConnection.BeginTransaction();
                try
                {
                    String sentence = "eliminarArea";

                    MySqlCommand command = new MySqlCommand(sentence, Connection.CurrentConnection);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("areaID", areaID);

                    command.ExecuteNonQuery();
                    command.Dispose();
                    trans.Commit();

                    return 1;
                }
                catch (MySqlException e)
                {
                    trans.Rollback();
                    return e.Number;
                }
                catch (Exception e)
                {
                    trans.Rollback();
                    return -1; 
                }
                finally
                {
                    Connection.Disconnect();
                }
            }
            else
            {
                return -2;
            }
        }

    }
}
