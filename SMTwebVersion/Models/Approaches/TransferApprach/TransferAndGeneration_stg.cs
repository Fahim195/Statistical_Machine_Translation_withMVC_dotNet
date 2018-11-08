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
        int ObjectTable_Rows = 0, searchInitial_index = 0, MainSubjectIndex;
        //private string[] WORDS;
        private string[] POSTAGs;
        DataTable meaningDT;
        public string getInterpreted_Sentence(string[] words, string[] postags, string subject, string Subject_tag, string verb, string v_tag, string[] objects, string[] object_postags,int mainSubjectIndex)
        {
            MainSubjectIndex = mainSubjectIndex;
            searchInitial_index = MainSubjectIndex;
            subjectEng = subject;
            VerbEng = verb;
            v_Tag = v_tag;
           
            POSTAGs = postags;           
            Interpretation aInterpretation = new Interpretation();
            DataSet aDSet = aInterpretation.GetMeaning_E2B(subject, Subject_tag, verb, v_tag, objects);
            try
            {
                meaningDT = aDSet.Tables[2];
            }
            catch { }
            Generation(aDSet, v_tag, objects, object_postags, words);
            return sentence;
        }
        public void Generation(DataSet aDSet, string v_tag, string[] objects, string[] object_postags, string[] WORDS)
        {
            //Generating Subject Meaning
            try
            {
                subject = aDSet.Tables[0].Rows[0][0].ToString();
            }
            catch
            {
                subject = subjectEng;
            }
            //Generating Verb Meaning
            try
            {
                verb = aDSet.Tables[1].Rows[0][0].ToString();
            }
            catch
            {
                verb = VerbEng;
            }
            //Generating Object Meaning
            try
            {
                ObjectTable_Rows = aDSet.Tables[2].Rows.Count;
                if (ObjectTable_Rows==0) {
                    for (int j = 0; j <= ObjectTable_Rows; j++)
                    {
                        for (int k = 0; k < objects.Length && objects[k]!=null; k++)
                        {
                          
                                objectWithOut_Preposition +=" "+ objects[k];
                        }
                    }
                }
                else {
                    for (int j = 0; j < ObjectTable_Rows; j++)
                    {
                        for (int k = 0; k < ObjectTable_Rows; k++)
                        {
                            if (objects[j].ToLower() == aDSet.Tables[2].Rows[k][0].ToString().ToLower())
                            {
                                objectWithOut_Preposition += " " + aDSet.Tables[2].Rows[k][1].ToString();
                                break;
                            }
                        }

                    }
                }
                
            }
            catch
            {
                        //no object
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
            //verbal Ambiguity solution
            verb = aAmguitySolution.RemoveVerbalAmbiguity(subjectEng, verb, v_Tag,MainSubjectIndex);
            //object with prepositin
            int worldLength = WORDS.Length;
            objectWithPreposition = aAmguitySolution.removePrepositionalAmbiguity(meaningDT, WORDS, POSTAGs, objects, object_postags, subjectEng, VerbEng, worldLength,MainSubjectIndex,null);
            if (objectWithPreposition == ""|| objectWithPreposition == " "|| objectWithPreposition == null)
            {
                objectPart = objectWithOut_Preposition;
            }
            else
            {
                objectPart = objectWithPreposition;
            }
            //NounPhrase ambiguity Solutiion
            string BeforeMainSubject = aAmguitySolution.NounPhrase_Ambiguity_Solution(meaningDT, WORDS, POSTAGs, objects, object_postags, subjectEng, VerbEng,MainSubjectIndex,subject);
            subject = BeforeMainSubject + " " + subject+" " ;
            if (subject.Contains("টিটি"))
            {
                subject=subject.Replace("টিটি "," ");
                subject += "টি ";
            }
        }
        public string IdetifyObjects_NotRelatedWith_Preposition(int PrepositionStructure_start, int PrepositionStructure_end, string[] WORDS, DataTable meaningDT, string SUBJECT, string VERB)
        {
            string objects = "", objectsSingle = "";
            
            for (int k = searchInitial_index; k < PrepositionStructure_start; k++)
            {
                if (WORDS[k] == SUBJECT || WORDS[k] == VERB || WORDS[k] == "am" || WORDS[k] == "is" || WORDS[k] == "are" || WORDS[k] == "have" || WORDS[k] == "has" || WORDS[k] == "was" || WORDS[k] == "were" || WORDS[k] == "had" || WORDS[k] == "will" || WORDS[k] == "shall" || WORDS[k] == "be" || WORDS[k] == "been" || WORDS[k] == "should" || WORDS[k] == "would" || WORDS[k] == "could")
                {
                    objects = "";
                }
                else
                {
                    if (objects == " ")
                    {
                        objectsSingle = GetMeaning_Objects_NotRelatedWith_Preposition(k, WORDS, meaningDT);
                    }
                    else
                    {
                        objectsSingle = GetMeaning_Objects_NotRelatedWith_Preposition(k, WORDS, meaningDT);
                        if (objects.Contains("টি"))
                        {
                            objects = objects.Replace("টি", "");
                            objectsSingle = objectsSingle + " টি ";
                        }
                        else if(objects.Contains(objectsSingle))
                        {
                            objectsSingle = "";
                        }
                        
                    }
                    //if (objects == "")
                    //{
                    //    objectsSingle = WORDS[k] + " কে ";
                    //}
                }
                objects += objectsSingle + " ";
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
                    nounMeaning = meaningDT.Rows[j][1].ToString()+" ";
                }
                j++;
            }
            return nounMeaning;
        }
    }
}