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
        // --- เปลี่ยนจาก int เป็น string ---
        public string WasteDataID { get; set; }
        public string AnalysisNo { get; set; }
        public string SamplingBy { get; set; }
        public string SamplingByNo { get; set; }
        public string FreeChlorine { get; set; } // "Y" or "N"
        public string Nitrite { get; set; }      // "Y" or "N"
        public string Cyanide { get; set; }      // "Y" or "N"
        public string Physicalstate { get; set; }
        public string Viscosity { get; set; }
        public string Bulkdensity { get; set; }
        public string HeatingValue { get; set; }
        public string NCVValue { get; set; }
        public string MoistureContent { get; set; }
        public string WaterContent { get; set; }
        public string AshContent { get; set; }
        public string CL { get; set; }
        public string F { get; set; }
        public string S { get; set; }
        public string SludgeContent { get; set; }
        public string SolidContent { get; set; }
        public string NitrogenContent { get; set; }
        public string DrybasisContent { get; set; }
        public string HeavyAs { get; set; }
        public string HeavyCd { get; set; }
        public string HeavyCr { get; set; }
        public string HeavyHg { get; set; }
        public string SS { get; set; }
        public string Acidity { get; set; }
        public string Alkalinity { get; set; }
        public string HeavyPb { get; set; }
        public string TDS { get; set; }
        public string Ni { get; set; }
        public string Mn { get; set; }
        public string Zn { get; set; }
        public string Cu { get; set; }
        public string HeavyFe { get; set; }
        public string Concentrate { get; set; }
    }

    // ====================================================================================
    // Database Helper Class (DatabaseHelper.cs)
    // ====================================================================================
    public static class DatabaseHelper
    {
        private static readonly string connectionString = ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString;

        // --- เปลี่ยน Return type เป็น Task<string> ---
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
                    // --- เปลี่ยนการแปลงค่าเป็น .ToString() ---
                    wasteDataId = result.ToString();
                }
            }
            return wasteDataId;
        }

        // --- เปลี่ยน Parameter เป็น string ---
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
                            // --- อ่านค่า WasteDataID เป็น string ---
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
                            Ni = reader["Ni"]?.ToString(),
                            Mn = reader["Mn"]?.ToString(),
                            Zn = reader["Zn"]?.ToString(),
                            Cu = reader["Cut"]?.ToString(),
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
            // --- ไม่มีการเปลี่ยนแปลงในส่วนนี้ แต่ตอนนี้ WasteDataID จะถูกส่งเป็น string ---
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
            cmd.Parameters.AddWithValue("@TDS", (object)data.TDS ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@Ni", (object)data.Ni ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@Mn", (object)data.Mn ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@Zn", (object)data.Zn ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@Cu", (object)data.Cu ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@HeavyFe", (object)data.HeavyFe ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@Concentrate", (object)data.Concentrate ?? DBNull.Value);
        }

        private static string GetInsertQuery()
        {
            return @"INSERT INTO tbWasteDataLab (WasteDataID, AnalysisNo, SamplingBy, SamplingByNo, FreeChlorine, Nitrite, Cyanide, Physicalstate, Viscosity, Bulkdensity, HeatingValue, NCVValue, MoistureContent, WaterContent, AshContent, CL, F, S, SludgeContent, SolidContent, NitrogenContent, DrybasisContent, HeavyAs, HeavyCd, HeavyCr, HeavyHg, SS, Acidity, Alkalinity, HeavyPb, Cu, Ni, Mn, Zn, Cut, HeavyFe, Concentrate) 
                     VALUES (@WasteDataID, @AnalysisNo, @SamplingBy, @SamplingByNo, @FreeChlorine, @Nitrite, @Cyanide, @Physicalstate, @Viscosity, @Bulkdensity, @HeatingValue, @NCVValue, @MoistureContent, @WaterContent, @AshContent, @CL, @F, @S, @SludgeContent, @SolidContent, @NitrogenContent, @DrybasisContent, @HeavyAs, @HeavyCd, @HeavyCr, @HeavyHg, @SS, @Acidity, @Alkalinity, @HeavyPb, @TDS, @Ni, @Mn, @Zn, @Cu, @HeavyFe, @Concentrate)";
        }

        private static string GetUpdateQuery()
        {
            return @"UPDATE tbWasteDataLab SET 
                        AnalysisNo = @AnalysisNo, SamplingBy = @SamplingBy, SamplingByNo = @SamplingByNo, FreeChlorine = @FreeChlorine, Nitrite = @Nitrite, Cyanide = @Cyanide, Physicalstate = @Physicalstate, Viscosity = @Viscosity, Bulkdensity = @Bulkdensity, HeatingValue = @HeatingValue, NCVValue = @NCVValue, MoistureContent = @MoistureContent, WaterContent = @WaterContent, AshContent = @AshContent, CL = @CL, F = @F, S = @S, SludgeContent = @SludgeContent, SolidContent = @SolidContent, NitrogenContent = @NitrogenContent, DrybasisContent = @DrybasisContent, HeavyAs = @HeavyAs, HeavyCd = @HeavyCd, HeavyCr = @HeavyCr, HeavyHg = @HeavyHg, SS = @SS, Acidity = @Acidity, Alkalinity = @Alkalinity, HeavyPb = @HeavyPb, Cu = @TDS, Ni = @Ni, Mn = @Mn, Zn = @Zn, Cut = @Cu, HeavyFe = @HeavyFe, Concentrate = @Concentrate
                     WHERE WasteDataID = @WasteDataID";
        }
    }
}
