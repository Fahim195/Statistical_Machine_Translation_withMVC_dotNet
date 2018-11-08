using SMTwebVersion.Models.Approaches.DirectApproach.Step_3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SMTwebVersion.Models.Approaches.DirectApproach.Step_2
{
    public class Identifying_Constituents
    {
        public string IdentifyConsituents(string[] Words, string[] PoSTags,string[] Morphines, string subject,string Subject_tag, string Verb,string VerbTag)
        {
            string TargetSentence= "Error";
            if (subject == " " || Verb == " " || VerbTag == " ")
            {
                return TargetSentence;
            }
            else
            {
                int no_of_morphines = 0;
                int i = 0;
                while (Morphines[i]!=null)
                { no_of_morphines++;i++; }
                string[] MOrphines = new string[no_of_morphines];
                for (int j=0;j< no_of_morphines;j++)
                {
                    MOrphines[j] = Morphines[j];
                }
                Reordering_to_Target_Lang aReordering_to_Target_Lang = new Reordering_to_Target_Lang();
                TargetSentence= aReordering_to_Target_Lang.ReOrder_Source_to_TargetFormat(Words, PoSTags, MOrphines, subject, Subject_tag, Verb, VerbTag);
                return TargetSentence;
            }
            
        }
    }
}