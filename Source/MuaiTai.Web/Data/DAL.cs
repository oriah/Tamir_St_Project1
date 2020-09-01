using System;
using System.Data;
using System.Data.SqlClient;

namespace MuaiTai.Web.Data
{
  public class DAL
  {
    //defining and initializing the objects needed connecting to dataBase.
    SqlConnection conn = new SqlConnection();
    SqlCommand command = new SqlCommand();
    SqlDataAdapter adapter = new SqlDataAdapter();
    SqlDataReader reader;

    public DAL(string connString)
    {//initialiing needed properties for connecting to dataBase using current dataAccessLayer.
      conn.ConnectionString = connString;
      command.Connection = conn;
      adapter.SelectCommand = command;
    }

    public void Open()
    {//opens a connection.
      conn.Open();
    }

    public void Close()
    {//closes a connection.
      conn.Close();
    }

    public int Execute(string sql)
    {//executes a query in dataBase by the sql query supplies to the method.
      int affectedRows;
      //string dateFormatConfig = ConfigurationManager.AppSettings["dateTimeFormat"];
      //var pre = $@"Set dateformat {dateFormatConfig };";
      //command.CommandText = pre + sql;
      command.CommandType = CommandType.Text;


      if (conn.State == ConnectionState.Open)
        affectedRows = command.ExecuteNonQuery();
      else
      {//in case connection not open yet, opens it. executes the query and closes
       // it back after action.
        conn.Open();
        affectedRows = command.ExecuteNonQuery();
        conn.Close();
      }
      //returns how many rows affected by last query execution.
      return affectedRows;
    }

    public object GetScalar(string sql)
    {
      //defining the object, that will hold the scalar result from the query.
      object obj;
      command.CommandText = sql;
      command.CommandType = CommandType.Text;

      if (conn.State == ConnectionState.Open)
        //executing the query, inserting the result into the object defined on early
        // stage.
        obj = command.ExecuteScalar();
      else
      {//in case connection not open yet, opens it. executes the query and closes
       // it back after action.
        conn.Open();
        obj = command.ExecuteScalar();
        conn.Close();
      }

      return obj;
    }



    public DataTable GetTable(string sql)
    {// gets quert runs it on dataBase, and filling a dataTable with the result of the query.
     //returning the dataTable.
      command.CommandText = sql;
      command.CommandType = CommandType.Text;
      DataTable table = new DataTable();
      //Filling the table with the result of th query.
      adapter.Fill(table);
      //returning the table.
      return table;
    }



    #region Data RowReader Functionality properties, and methods.
    public void RowReaderOpen(string sql)
    {//opens a dataReader for reading multiple values from rows in dataBase.
      bool needOpen = (conn.State != ConnectionState.Open);

      command.CommandText = sql;
      command.CommandType = CommandType.Text;

      if (needOpen)
        conn.Open();
      //running the givven query to dataBase, filling the result into the dataReader object.
      reader = command.ExecuteReader();
    }


    private bool vRowReaderHasMoreRows = false;
    public bool RowReaderHasMoreRows
    {//property gets if the dataRowReader has more rows to read from, after the last
     //query that filled it with result.
      get
      {
        return vRowReaderHasMoreRows;
      }
    }

    public void RowReaderClose()
    {//closes the dataRowReader object.
      reader.Close();
    }

    public void RowReaderGetNextRow()
    {//advances the dataRowReader to next row from the query result.
      vRowReaderHasMoreRows = reader.Read();
    }

    /// <summary>
    /// this method expects the 'OpenRowReader' and 'CloseRowReader' to run before and after running it.
    /// returns the value at the givven columnName, at the current readen row by the RowReader object.
    /// in case there are no values left on the RowDetailsReader, returns null. 
    /// </summary>
    /// <param name="sql"></param>
    /// <returns></returns>
    public object GetRowReaderValue(string columnName)
    {//returns the objectType value at the columnName supplies at the current readen row by the
     //dataRowReader object.
      return reader[columnName];
    }

    /// <summary>
    /// this method expects the 'OpenRowReader' and 'CloseRowReader' to run before and after running it.
    /// returns the String value at the givven columnName, at the current readen row by the RowReader object.
    /// in case there are no values left on the RowDetailsReader, returns null. 
    /// </summary>
    /// <param name="column"></param>
    /// <returns></returns>
    public string GetRowReaderStringValue(int column)
    {//returns the string value at the columnName supplies at the current readen row by the
     //dataRowReader object.
      return reader.GetString(column);
    }

    /// <summary>
    /// this method expects the 'OpenRowReader' and 'CloseRowReader' to run before and after running it.
    /// returns the DateTime value at the givven columnName, at the current readen row by the RowReader object.
    /// in case there are no values left on the RowDetailsReader, returns null. 
    /// </summary>
    /// <param name="column"></param>
    /// <returns></returns>
    public DateTime GetRowReaderDateTimeValue(int column)
    {//returns the dateTime value at the columnName supplies at the current readen row by the
     //dataRowReader object.
      return reader.GetDateTime(column);
    }

    #endregion

    public void FillDataSetWithQuery(DataSet DataSet, string SrcTableName, string Sql)
    {//gets a data set, a srcTableName and a query, and fills the query result
     //after running it to dataBase, into the specified TableName ito the dataSet.
      adapter.SelectCommand.CommandText = Sql;
      adapter.Fill(DataSet, SrcTableName);
    }

    /// <summary>
    /// gets multipleQueries in a stringArray. runs all of the queries in the same
    /// transaction in the dataBase. returns true in case transaction succeeded to run, false otherwise.
    /// </summary>
    /// <param name="sqlQueries"></param>
    /// <returns></returns>
    public bool ExecuteQueries(string[] sqlQueries)
    {
      conn.Open();
      //open new transaction, for insertion of the data. and the defining the command
      // object to run in that transaction.
      SqlTransaction tran = conn.BeginTransaction();
      command.Transaction = tran;
      try
      {
        //iterates through the sqlQuert Array and runs each query in database,
        // at same transaction.
        foreach (string sqlQuery in sqlQueries)
        {
          Execute(sqlQuery);
        }
        //do Commit for queries in case all worked ok.
        tran.Commit();
        return true;
      }
      catch (Exception)
      {
        //do rollback in case transaction failed to run.
        tran.Rollback();
        return false;
      }
      finally
      {//no matter what occured while running the up queries,
       //close the connection.
        conn.Close();
      }
    }
  }

}
