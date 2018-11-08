using SMTwebVersion.Models.Approaches.DirectApproach.Step_5;
using SMTwebVersion.Models.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace SMTwebVersion.Models.Approaches.DirectApproach.Step_4
{
    public class Loockup_In_Dictionary
    {
        public string LookUpInDictionary(string[] Words, string[] PoSTags, string[] ReOrderedMorphines, string Subject,string Subject_tag, string Verb, string VerbTag)
        {
            string[] Objects = new string[Words.Length];
            int j = 0;
            int k = 0;
            int objectArrayLength = Objects.Length;
            while (k < objectArrayLength)
            {
                if (Words[k] != Subject && Words[k] != Verb && Words[k] != "am" && Words[k] != "is" && Words[k] != "are" && Words[k] != "have" && Words[k] != "has" && Words[k] != "was" && Words[k] != "were" && Words[k] != "had" && Words[k] != "will" && Words[k] != "shall" && Words[k] != "be" && Words[k] != "been")
                {
                    Objects[j] = Words[k];
                    //object_postags[j] = POStags[k];
                    j++;
                }
                else
                {
                    // error handing
                }
                k = k + 1;
            }
            Interpretation aInterpretation = new Interpretation();
            DataSet LookUpDataSet = aInterpretation.GetMeaning_E2B(Subject, Subject_tag, Verb, VerbTag, Objects);
            InflectTarget_Language_Words aInflectTarget_Language_Words = new InflectTarget_Language_Words();
            string TargetSentence = aInflectTarget_Language_Words.TargetLanguage_REpresentation(Words,PoSTags,ReOrderedMorphines,Subject,Subject_tag,Verb,VerbTag, LookUpDataSet);
            return TargetSentence;
        }
    }
}