using SMTwebVersion.Models.DAL.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace SMTwebVersion.Models.Approaches.StatisticalTranslation
{
    public class ExtractTargetLanguage_Results
    {
        public string getTargetSentences_According_to_Source(string SourceLang)
        {
            string query = "Select * from TrainDataset where SourceLang like '"+ SourceLang + "'";
            SqlConnection connection = DBconnection.OpenConnection();
            SqlCommand action = new SqlCommand(query, connection);
            SqlDataAdapter sda = new SqlDataAdapter();
            DataTable aDTResult = new DataTable();
            sda.SelectCommand = action;
            sda.Fill(aDTResult);
            string resilt = "";
            if (aDTResult!=null)
            {
                CompareResults aCompareResults = new CompareResults();
                resilt = aCompareResults.Start_Statistical_translation(aDTResult);
            }

            return resilt;
        }
    }
}