using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace LabFlow.Models
{
    // ====================================================================================
    // Data Model Class (WasteDataLabModel.cs)
    // ====================================================================================
    public class WasteDataLabModel
    {
        // --- Backing fields for properties ---
        private string _wasteDataID;
        private string _analysisNo;
        private string _samplingBy;
        private string _samplingByNo;
        private string _freeChlorine;
        private string _nitrite;
        private string _cyanide;
        private string _physicalstate;
        private string _viscosity;
        private string _bulkdensity;
        private string _heatingValue;
        private string _ncvValue;
        private string _moistureContent;
        private string _waterContent;
        private string _ashContent;
        private string _cl;
        private string _f;
        private string _s;
        private string _sludgeContent;
        private string _solidContent;
        private string _nitrogenContent;
        private string _drybasisContent;
        private string _heavyAs;
        private string _heavyCd;
        private string _heavyCr;
        private string _heavyHg;
        private string _ss;
        private string _acidity;
        private string _alkalinity;
        private string _heavyPb;
        private string _tds;
        private string _ni;
        private string _mn;
        private string _zn;
        private string _cu;
        private string _heavyFe;
        private string _concentrate;

        // --- Public properties with trimming setters ---
        // ใช้ ?.Trim() เพื่อป้องกัน NullReferenceException ถ้าค่าที่เข้ามาเป็น null
        public string WasteDataID { get => _wasteDataID; set => _wasteDataID = value?.Trim(); }
        public string AnalysisNo { get => _analysisNo; set => _analysisNo = value?.Trim(); }
        public string SamplingBy { get => _samplingBy; set => _samplingBy = value?.Trim(); }
        public string SamplingByNo { get => _samplingByNo; set => _samplingByNo = value?.Trim(); }
        public string FreeChlorine { get => _freeChlorine; set => _freeChlorine = value?.Trim(); }
        public string Nitrite { get => _nitrite; set => _nitrite = value?.Trim(); }
        public string Cyanide { get => _cyanide; set => _cyanide = value?.Trim(); }
        public string Physicalstate { get => _physicalstate; set => _physicalstate = value?.Trim(); }
        public string Viscosity { get => _viscosity; set => _viscosity = value?.Trim(); }
        public string Bulkdensity { get => _bulkdensity; set => _bulkdensity = value?.Trim(); }
        public string HeatingValue { get => _heatingValue; set => _heatingValue = value?.Trim(); }
        public string NCVValue { get => _ncvValue; set => _ncvValue = value?.Trim(); }
        public string MoistureContent { get => _moistureContent; set => _moistureContent = value?.Trim(); }
        public string WaterContent { get => _waterContent; set => _waterContent = value?.Trim(); }
        public string AshContent { get => _ashContent; set => _ashContent = value?.Trim(); }
        public string CL { get => _cl; set => _cl = value?.Trim(); }
        public string F { get => _f; set => _f = value?.Trim(); }
        public string S { get => _s; set => _s = value?.Trim(); }
        public string SludgeContent { get => _sludgeContent; set => _sludgeContent = value?.Trim(); }
        public string SolidContent { get => _solidContent; set => _solidContent = value?.Trim(); }
        public string NitrogenContent { get => _nitrogenContent; set => _nitrogenContent = value?.Trim(); }
        public string DrybasisContent { get => _drybasisContent; set => _drybasisContent = value?.Trim(); }
        public string HeavyAs { get => _heavyAs; set => _heavyAs = value?.Trim(); }
        public string HeavyCd { get => _heavyCd; set => _heavyCd = value?.Trim(); }
        public string HeavyCr { get => _heavyCr; set => _heavyCr = value?.Trim(); }
        public string HeavyHg { get => _heavyHg; set => _heavyHg = value?.Trim(); }
        public string SS { get => _ss; set => _ss = value?.Trim(); }
        public string Acidity { get => _acidity; set => _acidity = value?.Trim(); }
        public string Alkalinity { get => _alkalinity; set => _alkalinity = value?.Trim(); }
        public string HeavyPb { get => _heavyPb; set => _heavyPb = value?.Trim(); }
        public string TDS { get => _tds; set => _tds = value?.Trim(); }
        public string Ni { get => _ni; set => _ni = value?.Trim(); }
        public string Mn { get => _mn; set => _mn = value?.Trim(); }
        public string Zn { get => _zn; set => _zn = value?.Trim(); }
        public string Cu { get => _cu; set => _cu = value?.Trim(); }
        public string HeavyFe { get => _heavyFe; set => _heavyFe = value?.Trim(); }
        public string Concentrate { get => _concentrate; set => _concentrate = value?.Trim(); }
    }

    // ====================================================================================
    // Database Helper Class (DatabaseHelper.cs)
    // ====================================================================================
    public static class DatabaseHelper
    {
        private static readonly string connectionString = ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString;

        public static async Task<string> GetWasteDataID(string wasteNo)
        {
            string wasteDataId = string.Empty;
            const string query = "SELECT WasteDataID FROM tbWasteDataCR WHERE WasteNo = @WasteNo";

            using (var conn = new SqlConnection(connectionString))
            using (var cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@WasteNo", wasteNo);
                await conn.OpenAsync();
                object result = await cmd.ExecuteScalarAsync();
                if (result != null && result != DBNull.Value)
                {
                    wasteDataId = result.ToString();
                }
            }
            return wasteDataId;
        }

        public static async Task<WasteDataLabModel> GetWasteDataLab(string wasteDataId)
        {
            WasteDataLabModel labData = null;
            const string query = "SELECT * FROM tbWasteDataLab WHERE WasteDataID = @WasteDataID";

            using (var conn = new SqlConnection(connectionString))
            using (var cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@WasteDataID", wasteDataId);
                await conn.OpenAsync();
                using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
                {
                    if (await reader.ReadAsync())
                    {
                        labData = new WasteDataLabModel
                        {
                            WasteDataID = reader["WasteDataID"]?.ToString(),
                            AnalysisNo = reader["AnalysisNo"]?.ToString(),
                            SamplingBy = reader["SamplingBy"]?.ToString(),
                            SamplingByNo = reader["SamplingByNo"]?.ToString(),
                            FreeChlorine = reader["FreeChlorine"]?.ToString(),
                            Nitrite = reader["Nitrite"]?.ToString(),
                            Cyanide = reader["Cyanide"]?.ToString(),
                            Physicalstate = reader["Physicalstate"]?.ToString(),
                            Viscosity = reader["Viscosity"]?.ToString(),
                            Bulkdensity = reader["Bulkdensity"]?.ToString(),
                            HeatingValue = reader["HeatingValue"]?.ToString(),
                            NCVValue = reader["NCVValue"]?.ToString(),
                            MoistureContent = reader["MoistureContent"]?.ToString(),
                            WaterContent = reader["WaterContent"]?.ToString(),
                            AshContent = reader["AshContent"]?.ToString(),
                            CL = reader["CL"]?.ToString(),
                            F = reader["F"]?.ToString(),
                            S = reader["S"]?.ToString(),
                            SludgeContent = reader["SludgeContent"]?.ToString(),
                            SolidContent = reader["SolidContent"]?.ToString(),
                            NitrogenContent = reader["NitrogenContent"]?.ToString(),
                            DrybasisContent = reader["DrybasisContent"]?.ToString(),
                            HeavyAs = reader["HeavyAs"]?.ToString(),
                            HeavyCd = reader["HeavyCd"]?.ToString(),
                            HeavyCr = reader["HeavyCr"]?.ToString(),
                            HeavyHg = reader["HeavyHg"]?.ToString(),
                            SS = reader["SS"]?.ToString(),
                            Acidity = reader["Acidity"]?.ToString(),
                            Alkalinity = reader["Alkalinity"]?.ToString(),
                            HeavyPb = reader["HeavyPb"]?.ToString(),
                            TDS = reader["Cu"]?.ToString(),
                            Cu = reader["Cut"]?.ToString(),
                            Ni = reader["Ni"]?.ToString(),
                            Mn = reader["Mn"]?.ToString(),
                            Zn = reader["Zn"]?.ToString(),
                            HeavyFe = reader["HeavyFe"]?.ToString(),
                            Concentrate = reader["Concentrate"]?.ToString()
                        };
                    }
                }
            }
            return labData;
        }

        public static async Task<bool> SaveWasteDataLab(WasteDataLabModel data)
        {
            const string checkQuery = "SELECT COUNT(*) FROM tbWasteDataLab WHERE WasteDataID = @WasteDataID";
            int count;
            using (var conn = new SqlConnection(connectionString))
            using (var cmd = new SqlCommand(checkQuery, conn))
            {
                cmd.Parameters.AddWithValue("@WasteDataID", data.WasteDataID);
                await conn.OpenAsync();
                count = (int)await cmd.ExecuteScalarAsync();
            }

            string sql = count > 0 ? GetUpdateQuery() : GetInsertQuery();

            using (var conn = new SqlConnection(connectionString))
            using (var cmd = new SqlCommand(sql, conn))
            {
                AddParameters(cmd, data);
                await conn.OpenAsync();
                int rowsAffected = await cmd.ExecuteNonQueryAsync();
                return rowsAffected > 0;
            }
        }

        private static void AddParameters(SqlCommand cmd, WasteDataLabModel data)
        {
            cmd.Parameters.AddWithValue("@WasteDataID", data.WasteDataID);
            cmd.Parameters.AddWithValue("@AnalysisNo", (object)data.AnalysisNo ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@SamplingBy", (object)data.SamplingBy ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@SamplingByNo", (object)data.SamplingByNo ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@FreeChlorine", (object)data.FreeChlorine ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@Nitrite", (object)data.Nitrite ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@Cyanide", (object)data.Cyanide ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@Physicalstate", (object)data.Physicalstate ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@Viscosity", (object)data.Viscosity ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@Bulkdensity", (object)data.Bulkdensity ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@HeatingValue", (object)data.HeatingValue ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@NCVValue", (object)data.NCVValue ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@MoistureContent", (object)data.MoistureContent ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@WaterContent", (object)data.WaterContent ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@AshContent", (object)data.AshContent ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@CL", (object)data.CL ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@F", (object)data.F ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@S", (object)data.S ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@SludgeContent", (object)data.SludgeContent ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@SolidContent", (object)data.SolidContent ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@NitrogenContent", (object)data.NitrogenContent ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@DrybasisContent", (object)data.DrybasisContent ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@HeavyAs", (object)data.HeavyAs ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@HeavyCd", (object)data.HeavyCd ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@HeavyCr", (object)data.HeavyCr ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@HeavyHg", (object)data.HeavyHg ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@SS", (object)data.SS ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@Acidity", (object)data.Acidity ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@Alkalinity", (object)data.Alkalinity ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@HeavyPb", (object)data.HeavyPb ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@Cu", (object)data.TDS ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@Cut", (object)data.Cu ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@Ni", (object)data.Ni ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@Mn", (object)data.Mn ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@Zn", (object)data.Zn ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@HeavyFe", (object)data.HeavyFe ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@Concentrate", (object)data.Concentrate ?? DBNull.Value);
        }

        private static string GetInsertQuery()
        {
            return @"INSERT INTO tbWasteDataLab (WasteDataID, AnalysisNo, SamplingBy, SamplingByNo, FreeChlorine, Nitrite, Cyanide, Physicalstate, Viscosity, Bulkdensity, HeatingValue, NCVValue, MoistureContent, WaterContent, AshContent, CL, F, S, SludgeContent, SolidContent, NitrogenContent, DrybasisContent, HeavyAs, HeavyCd, HeavyCr, HeavyHg, SS, Acidity, Alkalinity, HeavyPb, Cu, Ni, Mn, Zn, Cut, HeavyFe, Concentrate) 
                     VALUES (@WasteDataID, @AnalysisNo, @SamplingBy, @SamplingByNo, @FreeChlorine, @Nitrite, @Cyanide, @Physicalstate, @Viscosity, @Bulkdensity, @HeatingValue, @NCVValue, @MoistureContent, @WaterContent, @AshContent, @CL, @F, @S, @SludgeContent, @SolidContent, @NitrogenContent, @DrybasisContent, @HeavyAs, @HeavyCd, @HeavyCr, @HeavyHg, @SS, @Acidity, @Alkalinity, @HeavyPb, @Cu, @Ni, @Mn, @Zn, @Cut, @HeavyFe, @Concentrate)";
        }

        private static string GetUpdateQuery()
        {
            return @"UPDATE tbWasteDataLab SET 
                        AnalysisNo = @AnalysisNo, SamplingBy = @SamplingBy, SamplingByNo = @SamplingByNo, FreeChlorine = @FreeChlorine, Nitrite = @Nitrite, Cyanide = @Cyanide, Physicalstate = @Physicalstate, Viscosity = @Viscosity, Bulkdensity = @Bulkdensity, HeatingValue = @HeatingValue, NCVValue = @NCVValue, MoistureContent = @MoistureContent, WaterContent = @WaterContent, AshContent = @AshContent, CL = @CL, F = @F, S = @S, SludgeContent = @SludgeContent, SolidContent = @SolidContent, NitrogenContent = @NitrogenContent, DrybasisContent = @DrybasisContent, HeavyAs = @HeavyAs, HeavyCd = @HeavyCd, HeavyCr = @HeavyCr, HeavyHg = @HeavyHg, SS = @SS, Acidity = @Acidity, Alkalinity = @Alkalinity, HeavyPb = @HeavyPb, Cu = @Cu, Ni = @Ni, Mn = @Mn, Zn = @Zn, Cut = @Cut, HeavyFe = @HeavyFe, Concentrate = @Concentrate
                     WHERE WasteDataID = @WasteDataID";
        }
    }
}
