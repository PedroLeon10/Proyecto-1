using MySql.Data.MySqlClient;
using project_u5.model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Transactions;

namespace project_u5.data
{
    public class InventariosDAO
    {
        public static List<CLSInventario> GetAll()
        {
            List<CLSInventario> inventarios = null;
            if (Connection.Connect())
            {
                //MySqlTransaction trans = Connection.CurrentConnection.BeginTransaction();
                try
                {
                    String sentence = "obtenerTodoInventario";

                    MySqlCommand command = new MySqlCommand(sentence, Connection.CurrentConnection);
                    command.CommandType = CommandType.StoredProcedure;

                    DataTable dt = new DataTable();
                    MySqlDataAdapter da = new MySqlDataAdapter();
                    da.SelectCommand = command;
                    da.Fill(dt);

                    inventarios = new List<CLSInventario>();
                    //Crear un objeto place por cada fila de la tabla y añadirlo a la lista
                    foreach (DataRow fila in dt.Rows)
                    {
                        CLSArea a = new CLSArea(
                            Convert.ToInt32(fila["aID"]),
                            fila["aNombre"].ToString(),
                            fila["aUbicacion"].ToString()
                            );

                        CLSInventario inventario = new CLSInventario(
                            Convert.ToInt32(fila["iID"]),
                            a,
                            fila["inombreCorto"].ToString(),
                            fila["idescripcion"].ToString(),
                            fila["iserie"].ToString(),
                            fila["icolor"].ToString(),
                            fila["ifechaAdquision"].ToString(),
                            fila["itipoAdquision"].ToString(),
                            fila["iobservaciones"].ToString()
                            );
                        inventarios.Add(inventario);
                    }
                    command.Dispose();
                    //trans.Commit();
                    return inventarios;
                }
                catch (Exception e)
                {
                    //trans.Rollback();
                    return inventarios;
                }
                finally
                {
                    Connection.Disconnect();
                }
            }
            else
            {
                return inventarios;
            }
        }


        public static CLSInventario Get(int inventarioID)
        {
            CLSInventario inventario = null;
            if (Connection.Connect())
            {
                //MySqlTransaction trans = Connection.CurrentConnection.BeginTransaction();
                try
                {
                    String sentence = "obtenerRegistroInventario";

                    MySqlCommand command = new MySqlCommand(sentence, Connection.CurrentConnection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("inventarioID", inventarioID);
                    DataTable dt = new DataTable();
                    MySqlDataAdapter da = new MySqlDataAdapter();
                    da.SelectCommand = command;
                    da.Fill(dt);

                    //Crear un objeto place por cada fila de la tabla y añadirlo a la lista
                    foreach (DataRow fila in dt.Rows)
                    {
                        CLSArea a = new CLSArea(
                           Convert.ToInt32(fila["sID"]),
                           fila["aNombre"].ToString(),
                           fila["aUbicacion"].ToString()
                       );

                       inventario = new CLSInventario(
                            Convert.ToInt32(fila["tID"]),
                            a,
                            fila["aNombreCorto"].ToString(),
                            fila["aDescripcion"].ToString(),
                            fila["aSerie"].ToString(),
                            fila["aColor"].ToString(),
                            fila["aFechaAdquision"].ToString(),
                            fila["aTipoAdquision"].ToString(),
                            fila["aObservaciones"].ToString()
                         );
                    }
                    command.Dispose();
                    //trans.Commit();
                    return inventario;
                }
                catch (Exception e)
                {
                    //trans.Rollback();
                    return inventario;
                }
                finally
                {
                    Connection.Disconnect();
                }
            }
            else
            {
                return inventario;
            }
        }

        public static int AddInventario(CLSInventario i)
        {
            if (Connection.Connect())
            {
                MySqlTransaction inve = Connection.CurrentConnection.BeginTransaction();
                try
                {
                    String sentence = "agregarRegistroInventario";

                    MySqlCommand command = new MySqlCommand(sentence, Connection.CurrentConnection);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("set_area", i.Area.ID);
                    command.Parameters.AddWithValue("set_nombreCorto", i.NombreCorto);
                    command.Parameters.AddWithValue("set_descripcion", i.Descripcion);
                    command.Parameters.AddWithValue("set_serie", i.Serie);
                    command.Parameters.AddWithValue("set_color", i.Color);
                    command.Parameters.AddWithValue("set_fechaAdquision", i.FechaAdquision);
                    command.Parameters.AddWithValue("set_tipoAdquision", i.TipoAdquision);
                    command.Parameters.AddWithValue("set_observaciones", i.Observaciones);

                    command.ExecuteNonQuery();
                    command.Dispose();

                    sentence = "select last_insert_id();";
                    command = new MySqlCommand(sentence, Connection.CurrentConnection);
                    command.Dispose();
                    int id = Convert.ToInt32(command.ExecuteScalar());

                    inve.Commit();
                    return id;
                }
                catch (Exception e)
                {
                    inve.Rollback();
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

        public static bool UpdateInventario(CLSInventario i)
        {
            if (Connection.Connect())
            {
                MySqlTransaction trans = Connection.CurrentConnection.BeginTransaction();
                try
                {
                    String sentence = "actualizarRegistroInventario";

                    MySqlCommand command = new MySqlCommand(sentence, Connection.CurrentConnection);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("set_ID", i.ID);
                    command.Parameters.AddWithValue("set_area", i.Area.ID);
                    command.Parameters.AddWithValue("set_nombreCorto", i.NombreCorto);
                    command.Parameters.AddWithValue("set_descripcion", i.Descripcion);
                    command.Parameters.AddWithValue("set_serie", i.Serie);
                    command.Parameters.AddWithValue("set_color", i.Color);
                    command.Parameters.AddWithValue("set_fechaAdquision", i.FechaAdquision);
                    command.Parameters.AddWithValue("set_tipoAdquision", i.TipoAdquision);
                    command.Parameters.AddWithValue("set_observaciones", i.Observaciones);

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

        public static bool DeleteInventario(int inventarioID)
        {
            if (Connection.Connect())
            {
                MySqlTransaction trans = Connection.CurrentConnection.BeginTransaction();
                try
                {
                    String sentence = "eliminarRegistroInventario";

                    MySqlCommand command = new MySqlCommand(sentence, Connection.CurrentConnection);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("inventarioID", inventarioID);

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

    }
}
