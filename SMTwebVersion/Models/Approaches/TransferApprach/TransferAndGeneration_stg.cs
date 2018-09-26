using SMTwebVersion.Models.Ambiguity;
using SMTwebVersion.Models.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace SMTwebVersion.Models.Approaches.TransferApprach
{
    public class TransferAndGeneration_stg
    {
        public string sentence = "";
        public string subject, verb, objectWithPreposition = "", objectWithOut_Preposition = "", subjectEng, VerbEng, v_Tag, objectPart;
        int ObjectTable_Rows = 0, searchInitial_index = 0;
        //private string[] WORDS;
        private string[] POSTAGs;
        DataTable meaningDT;
        public string getInterpreted_Sentence(string[] words, string[] postags, string subject, string Subject_tag, string verb, string v_tag, string[] objects, string[] object_postags)
        {
            searchInitial_index = 0;
            subjectEng = subject;
            VerbEng = verb;
            v_Tag = v_tag;
            POSTAGs = postags;
            Interpretation aInterpretation = new Interpretation();
            DataSet aDSet = aInterpretation.GetMeaning_E2B(subject, Subject_tag, verb, v_tag, objects);
            meaningDT = aDSet.Tables[2];
            Generation(aDSet, v_tag, objects, object_postags, words);
            return sentence;
        }
        public void Generation(DataSet aDSet, string v_tag, string[] objects, string[] object_postags, string[] WORDS)
        {
            try
            {
                subject = aDSet.Tables[0].Rows[0][0].ToString();
            }
            catch
            {
                subject = subjectEng;
            }
            verb = aDSet.Tables[1].Rows[0][0].ToString();
            ObjectTable_Rows = aDSet.Tables[2].Rows.Count;
            for (int j = 0; j < ObjectTable_Rows; j++)
            {
                for (int k = 0; k < ObjectTable_Rows; k++)
                {
                    if (objects[j] == aDSet.Tables[2].Rows[k][0].ToString())
                    {
                        objectWithOut_Preposition += " " + aDSet.Tables[2].Rows[k][1].ToString();
                        break;
                    }
                }
            }
            generateSentence(objects, object_postags, WORDS);
        }
        public void generateSentence(string[] objects, string[] object_postags, string[] WORDS)
        {
            RemovingAmbiguity(objects, object_postags, WORDS);
            sentence = subject + objectPart + " " + verb;
        }
        public void RemovingAmbiguity(string[] objects, string[] object_postags, string[] WORDS)
        {
            AmbiguitySolution aAmguitySolution = new AmbiguitySolution();
            verb = aAmguitySolution.RemoveAmbiguity(subjectEng, verb, v_Tag);
            //object with prepositin
            objectWithPreposition = aAmguitySolution.removePrepositionalAmbiguity(meaningDT, WORDS, POSTAGs, objects, object_postags, subjectEng, VerbEng);
            if (objectWithPreposition == ""|| objectWithPreposition == " "|| objectWithPreposition == null)
            {
                objectPart = objectWithOut_Preposition;
            }
            else
            {
                objectPart = objectWithPreposition;
            }
        }
        public string IdetifyObjects_NotRelatedWith_Preposition(int PrepositionStructure_start, int PrepositionStructure_end, string[] WORDS, DataTable meaningDT, string SUBJECT, string VERB)
        {
            string objects = "";
            for (int k = searchInitial_index; k < PrepositionStructure_start; k++)
            {
                if (WORDS[k] == SUBJECT || WORDS[k] == VERB || WORDS[k] == "am" || WORDS[k] == "is" || WORDS[k] == "are" || WORDS[k] == "have" || WORDS[k] == "has" || WORDS[k] == "was" || WORDS[k] == "were" || WORDS[k] == "had" || WORDS[k] == "will" || WORDS[k] == "shall" || WORDS[k] == "be" || WORDS[k] == "been" || WORDS[k] == "should" || WORDS[k] == "would" || WORDS[k] == "could")
                {
                    objects = "";
                }
                else
                {
                    if (objects == "")
                    {
                        objects = GetMeaning_Objects_NotRelatedWith_Preposition(k, WORDS, meaningDT);
                    }
                    else
                    {
                        objects += " " + GetMeaning_Objects_NotRelatedWith_Preposition(k, WORDS, meaningDT);
                    }
                    if (objects == "")
                    {
                        objects = WORDS[k] + " কে ";
                    }
                }
            }
            searchInitial_index = PrepositionStructure_end + 1;
            return objects;
        }
        private string GetMeaning_Objects_NotRelatedWith_Preposition(int k, string[] WORDS, DataTable meaningDT)
        {
            int j = 0;
            int no_of_objects = meaningDT.Rows.Count;
            string nounMeaning = "";
            while (j < no_of_objects)
            {
                if (WORDS[k] == meaningDT.Rows[j][0].ToString().ToLower())
                {
                    nounMeaning = meaningDT.Rows[j][1].ToString();
                }
                j++;
            }
            return nounMeaning;
        }
    }
}