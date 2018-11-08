using SMTwebVersion.Models.Approaches.DirectApproach.Step_4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace SMTwebVersion.Models.Approaches.DirectApproach.Step_3
{
    public class Reordering_to_Target_Lang
    {
        public string ReOrder_Source_to_TargetFormat(string[] Words, string[] PoSTags, string[] Morphines, string subject,string Subject_tag, string Verb, string VerbTag)
        {
            string[] ReOrderedMorphines = new string[Morphines.Length];
            int ReorderingIndex = Morphines.Length - 2;
            for (int MorfIndex=0; MorfIndex< Morphines.Length; MorfIndex++)
            {
                if (Morphines[MorfIndex].Contains("SP")) { ReOrderedMorphines[0] = Morphines[MorfIndex]; }
                else if (Morphines[MorfIndex].Contains("VP")) { ReOrderedMorphines[Morphines.Length - 1] = Morphines[MorfIndex]; }
                else
                {
                    
                    ReOrderedMorphines[ReorderingIndex] = Morphines[MorfIndex];
                    ReorderingIndex--;
                }
            }
            Loockup_In_Dictionary aLoockup_In_Dictionary = new Loockup_In_Dictionary();
            string TargetSentence = aLoockup_In_Dictionary.LookUpInDictionary(Words, PoSTags, ReOrderedMorphines, subject, Subject_tag, Verb, VerbTag);
            return TargetSentence;
        }
    }
}