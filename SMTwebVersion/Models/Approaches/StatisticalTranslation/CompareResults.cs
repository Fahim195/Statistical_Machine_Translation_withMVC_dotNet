using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace SMTwebVersion.Models.Approaches.StatisticalTranslation
{
    public class CompareResults
    {
        public String Start_Statistical_translation(DataTable DtResult)
        {
            string TargetLaguage = "";
            float[] calculationSorage; 
            int TotalResults = DtResult.Rows.Count,resultingIndex;
            calculationSorage = new float[TotalResults];
            float Porb_of_ebyf = 0,prob_of_e=0,res=0,ComapreResult=0;

            for (int resultIndex=0;resultIndex< TotalResults; resultIndex++)
            {
                Porb_of_ebyf=float.Parse(DtResult.Rows[resultIndex][2].ToString()) ;
                prob_of_e = float.Parse(DtResult.Rows[resultIndex][3].ToString());
                res = Porb_of_ebyf * prob_of_e;
                calculationSorage[resultIndex] = res;
            }
            // Comparing Result total probability of eby f
            ComapreResult = calculationSorage.Max();
            resultingIndex = Array.IndexOf(calculationSorage, ComapreResult);
            TargetLaguage = DtResult.Rows[resultingIndex][1].ToString() ;
            return TargetLaguage;
        } 
    }
}