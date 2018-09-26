using SMTwebVersion.Models.DAL.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace SMTwebVersion.Models.DAL
{
    public class Interpretation
    {
        public DataSet dSet = new DataSet();
        public bool logic = false;
        public DataSet GetMeaning_E2B(string subject, string Subject_tag, string verb, string v_tag, string[] objects)
        {
            string query = QueryGenerate(subject, Subject_tag, verb, objects);
            SqlConnection connection = DBconnection.OpenConnection();
            SqlCommand action = new SqlCommand(query, connection);
            SqlDataAdapter sda = new SqlDataAdapter();
            sda.SelectCommand = action;
            sda.Fill(dSet);
            return dSet;
        }
        public string QueryGenerate(string subject, string Subject_tag, string verb, string[] objects)
        {
            string query = "";
            if (Subject_tag != "" && (Subject_tag != "NN" || Subject_tag != "NNS" || Subject_tag != "NNP"))//Subject is a pronoun(not noun)
            {
                query = "SELECT Bangla from NounOthers where English='" + subject + "' ";
            }
            if (verb != "")
            {
                query += "SELECT Bangla from Verb where Verb='" + verb + "' or Past='" + verb + "' or PP='" + verb + "' or S_ES='" + verb + "' or Continious='" + verb + "' ";
            }
            if (objects != null)
            {
                query += "SELECT English,Bangla from NounOthers where ";
                int no_of_objects = objects.Length;
                int obj_count = 0;
                while (obj_count < no_of_objects && objects[obj_count] != null)
                {
                    if (logic == false)
                    {
                        query += " English='" + objects[obj_count] + "'";
                        logic = true;
                    }
                    else
                    {
                        query += " OR English='" + objects[obj_count] + "' ";
                    }
                    obj_count++;
                }
            }
            return query;

        }
    }
}