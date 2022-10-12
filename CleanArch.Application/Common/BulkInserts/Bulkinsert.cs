using Application.Common.Interfaces;
using Domain.Interfaces;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Threading.Tasks;

namespace Application.Common.BulkInserts
{
    public class BulkInsert : IBulkInsert, IDisposable
    {
        private string _tableTemp;
        private Guid _userId;
        private DataTable _validationResultTable;
        private readonly IWebHostEnvironment _hostingEnvironment;
        private readonly string _connectionString;


        private readonly SqlConnection _connection;
        private readonly IUnitOfWork _unitOfWork;


        public string _path;


        public BulkInsert(IWebHostEnvironment environment, IUnitOfWork unitOfWork)
        {
            _hostingEnvironment = environment;
            _unitOfWork = unitOfWork;
            _validationResultTable = new DataTable();
            _connectionString = _unitOfWork.GetDbConnection();
            _connection = new SqlConnection(_connectionString);
            _userId = new Guid("c640b650-44d9-4ab9-bdb4-caca89a5720c");
        }


        public async Task SetPath(string path)
        {
            await Task.FromResult(path);

        }


        public void setTemporalTable(string table)
        {
            _tableTemp = table;
        }


        public async Task<DataTable> SaveFile(IFormFile Request)
        {
            try
            {
                string uploads = Path.Combine(_hostingEnvironment.WebRootPath, "uploads");

                string filePath = Path.Combine(uploads, _userId.ToString());
                if (Request.Length > 0)
                {
                    using (Stream fileStream = new FileStream(filePath, FileMode.Create))
                    {
                        await Request.CopyToAsync(fileStream);
                    }
                }



                var strconn = ("Provider=Microsoft.ACE.OLEDB.12.0;" +
                ("Data Source=" + (filePath + ";Extended Properties=\"Excel 12.0;HDR=YES\"")));

                DataTable dataTable = new DataTable();





                OleDbConnection mconn = new OleDbConnection(strconn);
                mconn.Open();
                DataTable dtSchema = mconn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);

                if ((null != dtSchema) && (dtSchema.Rows.Count > 0))
                {

                    string firstSheetName = "data$";
                    new OleDbDataAdapter("SELECT * FROM [" + firstSheetName.Trim() + "]", mconn).Fill(dataTable);
                }
                mconn.Close();


                var now = DateTime.Now;
                
                dataTable.Columns.Add("User", typeof(Guid));
                dataTable.Columns.Add("CreatedAt", typeof(DateTime));
                dataTable.Columns.Add("CreatedByName", typeof(string));
                foreach (DataRow dr in dataTable.Rows)
                {
                    dr["User"] = _userId;
                    dr["CreatedAt"] = now;
                    dr["CreatedByName"] = "Cristian";
                }


                return dataTable;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);

            }
        }



        public async Task<DataTable> Bulk(DataTable dt)
        {


            await TruncateTable(_tableTemp, _userId);
            await _connection.OpenAsync();

            using (SqlBulkCopy bulkcopy = new SqlBulkCopy(_connection))
            {
                bulkcopy.DestinationTableName = _tableTemp;
                bulkcopy.ColumnMappings.Add("TIPO_HORA", "OvertimeTypeName");
                bulkcopy.ColumnMappings.Add("LOGIN", "Login");
                bulkcopy.ColumnMappings.Add("CAMPANA", "CampaingName");
                bulkcopy.ColumnMappings.Add("FECHA_HORA_EXTRA", "OvertimeDayText");
                bulkcopy.ColumnMappings.Add("NOMBRE_COLABORADOR", "Names");
                bulkcopy.ColumnMappings.Add("CARGO", "JobName");
                bulkcopy.ColumnMappings.Add("DOCUMENTO", "Document");
                bulkcopy.ColumnMappings.Add("HORA_LOGUEO", "LoginTimeText");
                bulkcopy.ColumnMappings.Add("APLICA_COMPENSATORIO", "CompensatoryAppliesText");
                bulkcopy.ColumnMappings.Add("HORA_INICO_RECARGO", "InitialHourText");
                bulkcopy.ColumnMappings.Add("HORA_FIN_RECARGO", "EndHourText");
                bulkcopy.ColumnMappings.Add("User", "CreatedBy");
                bulkcopy.ColumnMappings.Add("CreatedAt", "CreatedAt");
                bulkcopy.ColumnMappings.Add("CreatedByName", "CreatedByName");
                try
                {
                    bulkcopy.WriteToServer(dt);
                    await _connection.CloseAsync();
                    return await ValidateBulk("P_validateOvertimesTemps");
                }
                catch (Exception ex)
                {
                    throw new Exception("Error Insert the Excel data " + ex.InnerException);
                    
                }
            }
        }





        public void Dispose()
        {
            _connection.Close();
        }


        public async Task<DataTable> ValidateBulk(string table)
        {

            try
            {

                _validationResultTable.Clear();
                SqlCommand InsertCommand = new SqlCommand(table, _connection);
                InsertCommand.CommandType = CommandType.StoredProcedure;
                SqlParameter parameter = new SqlParameter();
                InsertCommand.Parameters.Clear();
                InsertCommand.Parameters.AddWithValue("@userId", _userId);
                _connection.Open();
                SqlDataReader reader = await InsertCommand.ExecuteReaderAsync();
                _validationResultTable.Load(reader);
                _connection.Close();
                return _validationResultTable;

            }
            catch (Exception ex)
            {
                throw new Exception("Error al ejecutar procedimiento almacenado. \n" + ex.Message.ToString());
            }
        }

   


        public async Task TruncateTable(string table)
        {

            try
            {


                SqlCommand comandoInsert = new SqlCommand("TRUNCATE TABLE " + table, _connection);
                comandoInsert.CommandType = CommandType.Text;
                SqlParameter parameter = new SqlParameter();
                comandoInsert.Parameters.Clear();
                _connection.Open();
                SqlDataReader reader = await comandoInsert.ExecuteReaderAsync();
                _connection.Close();

            }
            catch (Exception ex)
            {
                throw new Exception("Error al ejecutar procedimiento almacenado. \n" + ex.Message.ToString());
            }
        }

        public async Task TruncateTable(string table,Guid UserId)
        {

            try
            {

                string command = String.Concat("Delete from ", table, $" where CreatedBy ='{UserId}' ");

                SqlCommand comandoInsert = new SqlCommand( command, _connection);
                comandoInsert.CommandType = CommandType.Text;
                SqlParameter parameter = new SqlParameter();
                comandoInsert.Parameters.Clear();
                _connection.Open();
                SqlDataReader reader = await comandoInsert.ExecuteReaderAsync();
                _connection.Close();

            }
            catch (Exception ex)
            {
                throw new Exception("Error al ejecutar procedimiento almacenado. \n" + ex.Message.ToString());
            }
        }



        protected DataTable CargarExcel(string cadenaConexion)
        {

            try
            {
                var strconn = ("Provider=Microsoft.ACE.OLEDB.12.0;" +
                ("Data Source=" + (cadenaConexion + ";Extended Properties=\"Excel 12.0;HDR=YES\"")));

                DataTable dataTable = new DataTable();


                OleDbConnection mconn = new OleDbConnection(strconn);
                mconn.Open();
                DataTable dtSchema = mconn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);

                if ((null != dtSchema) && (dtSchema.Rows.Count > 0))
                {
                    string firstSheetName1 = dtSchema.Rows[2]["TABLE_NAME"].ToString();
                    string firstSheetName = "Cargue$";
                    new OleDbDataAdapter("SELECT * FROM [" + firstSheetName.Trim() + "]", mconn).Fill(dataTable);
                }
                mconn.Close();

                return dataTable;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }


        }

    }
}
