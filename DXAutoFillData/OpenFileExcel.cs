using ExcelDataReader;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DXAutoFillData
{
    public class OpenFileExcel
    {
        public static DataTable getDataExcelFromFileToDataTable(string filePath, string selectSheet)
        {
            using (var stream = File.Open(filePath, FileMode.Open, FileAccess.Read))
            {
                // Auto-detect format, supports:
                //  - Binary Excel files (2.0-2003 format; *.xls)
                //  - OpenXml Excel files (2007 format; *.xlsx)
                using (var reader = ExcelReaderFactory.CreateReader(stream))
                {
                    var result = reader.AsDataSet(new ExcelDataSetConfiguration()
                    {
                        ConfigureDataTable = (data) => new ExcelDataTableConfiguration()
                        {
                            UseHeaderRow = true
                        }
                    });
                    //Get all Table
                    DataTableCollection tables = result.Tables;
                    //Get Table
                    string sheet = selectSheet.Split('$')[0].ToString().Trim();
                    DataTable dt = tables[0];
                    return dt;
                }

            }
        }

        public static DataTable getDataExcelFromFileToDataTable(string filePath)
        {
            using (var stream = File.Open(filePath, FileMode.Open, FileAccess.Read))
            {
                // Auto-detect format, supports:
                //  - Binary Excel files (2.0-2003 format; *.xls)
                //  - OpenXml Excel files (2007 format; *.xlsx)
                using (var reader = ExcelReaderFactory.CreateReader(stream))
                {
                    var result = reader.AsDataSet(new ExcelDataSetConfiguration()
                    {
                        ConfigureDataTable = (data) => new ExcelDataTableConfiguration()
                        {
                            UseHeaderRow = true
                        }
                    });
                    //Get all Table
                    DataTableCollection tables = result.Tables;
                    //Get Table
                    DataTable dt = tables[0];
                    return dt;
                }

            }
        }


        public static string moveFile(string target)
        {
            try
            {
                string fileSource = @"FileImportData.xlsx";
                string fileTarget = target + @"\FileImportData.xlsx";
                if (!File.Exists(fileSource))
                {
                    // This statement ensures that the file is created,
                    // but the handle is not kept.
                    using (FileStream fs = File.Create(fileSource)) { }
                }

                // Ensure that the target does not exist.
                if (File.Exists(fileTarget))
                    File.Delete(fileTarget);

                // Move the file.
                File.Copy(fileSource, fileTarget);
                return fileTarget;
            }
            catch (Exception e)
            {
                return null;
            }
        }
    
    }
}
