using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SMTwebVersion.Models.Approaches.TransferApprach
{
    public class Analysis_stg
    {
        String Subject = "", Subject_tag = "";
        String verb = "";
        String verbTag = "";
        int k = 0, MainSubjectIndex;

        public string getSubject(string[] words, string[] POStags)
        {
            while (k < POStags.Length)
            {
                if (POStags[k] == "PRP " || POStags[k] == "NN " || POStags[k] == "NNP " || POStags[k] == "PRP$ " || POStags[k] == "NNP 's"|| POStags[k] == "NNS " || POStags[k] == "NNS 's")
                {
                    if (POStags[k] == "NN ") // Akib Ahmed Adnan is eating rice
                    {
                        Subject = words[k];
                        Subject_tag = POStags[k];
                        MainSubjectIndex = k;
                        int IndexCount = k; ;
                        while (POStags[IndexCount + 1] == "NN " || POStags[IndexCount + 1] == "NNS " || POStags[IndexCount + 1] == "NNS 's")
                        {
                            Subject = words[IndexCount + 1];
                            Subject_tag = POStags[IndexCount + 1];
                            MainSubjectIndex = IndexCount + 1;
                            IndexCount++;
                        }
                        if (POStags[k + 1] == "VBG " && POStags[k + 2] == "NN ")
                        {
                            Subject = words[k + 2];
                            Subject_tag = POStags[k + 2];
                            MainSubjectIndex = k + 1;
                        }
                    }
                    else if (POStags[k] == "NNP ")
                    {
                        Subject = words[k];
                        Subject_tag = POStags[k];
                        MainSubjectIndex = k;
                        if (POStags[k + 1] == "NNP 's" && POStags[k + 2] == "NN ")//Brother Fahim's dog
                        {
                            Subject = words[k + 2];
                            Subject_tag = POStags[k + 2];
                            MainSubjectIndex = k + 2;
                            int IndexCount = k + 2; ;
                            while (POStags[IndexCount + 1] == "NN ")
                            {
                                Subject = words[IndexCount + 1];
                                Subject_tag = POStags[IndexCount + 1];
                                MainSubjectIndex = IndexCount + 1;
                                IndexCount++;
                            }
                        }
                        else if (POStags[k + 1] == "NNP ")
                        {

                            Subject = words[k + 1];
                            Subject_tag = POStags[k + 1];
                            MainSubjectIndex = k + 1;
                            int IndexCount = k + 1; ;
                            while (POStags[IndexCount + 1] == "NNP ")
                            {
                                Subject = words[IndexCount + 1];
                                Subject_tag = POStags[IndexCount + 1];
                                MainSubjectIndex = IndexCount + 1;
                                IndexCount++;
                            }
                        }
                        else if (POStags[k + 1] == "NNP 's" && (POStags[k + 2] == "JJS " || POStags[k + 2] == "JJ ") && POStags[k + 3] == "NN ")
                        {
                            Subject = words[k + 3];
                            Subject_tag = POStags[k + 3];
                            MainSubjectIndex = k + 3;
                            int IndexCount = k + 3; ;
                            while (POStags[IndexCount + 1] == "NN ")
                            {
                                Subject = words[IndexCount + 1];
                                Subject_tag = POStags[IndexCount + 1];
                                MainSubjectIndex = IndexCount + 1;
                                IndexCount++;
                            }
                        }
                    }
                    else if (POStags[k] == "PRP$ ")
                    {
                        Subject = words[k];
                        Subject_tag = POStags[k];
                        MainSubjectIndex = k;
                        if (POStags[k + 1] == "NNP 's" && POStags[k + 2] == "NN ")//My brother's dog
                        {
                            Subject = words[k + 2];
                            Subject_tag = POStags[k + 2];
                            MainSubjectIndex = k + 2;
                        }
                        else if ((POStags[k + 1] == "CD " || POStags[k + 1] == "DT ") && POStags[k + 2] == "NNS ")//My four/4 brother 
                        {                                                                                    //My all children
                            Subject = words[k + 2];
                            Subject_tag = POStags[k + 2];
                            MainSubjectIndex = k + 2;
                        }
                        else if ((POStags[k + 1] == "JJ " || POStags[k + 1] == "RB ") && POStags[k + 2] == "NN ")//Our white dog
                        {                                                                                        //
                            Subject = words[k + 2];
                            Subject_tag = POStags[k + 2];
                            MainSubjectIndex = k + 2;
                        }
                        else if (POStags[k + 1] == "NN ") // Our Kishor Laskar Aksh....
                        {
                            Subject = words[k + 1];
                            Subject_tag = POStags[k + 1];
                            MainSubjectIndex = k + 1;
                            int IndexCount = k + 1; ;
                            while (POStags[IndexCount + 1] == "NN ")
                            {
                                Subject = words[IndexCount + 1];
                                Subject_tag = POStags[IndexCount + 1];
                                MainSubjectIndex = IndexCount + 1;
                            }

                        }
                    }
                    else if (POStags[k] == "NNP 's")
                    {
                        Subject = words[k];
                        Subject_tag = POStags[k];
                        MainSubjectIndex = k;
                        if ((POStags[k + 1] == "JJS " || POStags[k + 1] == "JJ ") && POStags[k + 2] == "NN ")//My brother's dog
                        {
                            Subject = words[k + 2];
                            Subject_tag = POStags[k + 2];
                            MainSubjectIndex = k + 2;
                            int IndexCount = k + 2; ;
                            while (POStags[IndexCount + 1] == "NN ")
                            {
                                Subject = words[IndexCount + 1];
                                Subject_tag = POStags[IndexCount + 1];
                                MainSubjectIndex = IndexCount + 1;
                                IndexCount++;
                            }

                        }
                        else if (POStags[k + 1] == "NN ")
                        {
                            Subject = words[k + 1];
                            Subject_tag = POStags[k + 1];
                            MainSubjectIndex = k + 1;
                            int IndexCount = k + 1; ;
                            while (POStags[IndexCount + 1] == "NN ")
                            {
                                Subject = words[IndexCount + 1];
                                Subject_tag = POStags[IndexCount + 1];
                                MainSubjectIndex = IndexCount + 1;
                                IndexCount++;
                            }
                        }
                    }
                    else if (POStags[k] == "NNS ")
                    {
                        Subject = words[k];
                        Subject_tag = POStags[k];
                        MainSubjectIndex = k;
                    }
                    else if (POStags[k] == "NNS 's")
                    {
                        Subject = words[k];
                        Subject_tag = POStags[k];
                        MainSubjectIndex = k;
                        int IndexCount = k; ;
                        while (POStags[IndexCount + 1] == "NN ")
                        {
                            Subject = words[IndexCount + 1];
                            Subject_tag = POStags[IndexCount + 1];
                            MainSubjectIndex = IndexCount + 1;
                            IndexCount++;
                        }
                    }
                    else if (POStags[k] == "PRP ")
                    {
                        Subject = words[k];
                        Subject_tag = POStags[k];
                        MainSubjectIndex = k;
                    }
                    break;
                    }
                k = k + 1;
            }
            string sentence = detectVerb(words, POStags);
            return sentence;

        }
        public string detectVerb(string[] words, string[] POStags)
        {
            k = MainSubjectIndex+1;
            while (k < POStags.Length)
            {
                // detecting PRESENT tense
                if (/*POStags[k] == "NN " || */(POStags[k] == "VBZ " && (words[k] != "have" && words[k] != "has" && words[k] != "is")) || (POStags[k] == "NNS " && (words[k] != "have" && words[k] != "has")) || (POStags[k] == "VB " && (words[k] != "have" && words[k] != "has")) || words[k] == "can " || words[k] == "may")
                {
                    verb = words[k];
                    verbTag = "P_in";
                    break;
                }
                else if (words[k] == "am" || words[k] == "is" || words[k] == "are" || words[k] == "has" || words[k] == "have")
                {
                    verbTag = "P";
                    verb = words[k];

                    if (POStags[k + 1] == "VBG ") //word with ing

                        if (POStags[k + 1] == "VBG " || POStags[k + 1] == "NN ") //word with ing

                        {
                            verbTag += "_con";
                            verb = words[k + 1];
                        }
                        else if ((POStags[k + 1] == "VBN " || POStags[k + 1] == "VBD ") && words[k + 1] != "been") //word in Past Participle form
                        {
                            verbTag += "_per";
                            verb = words[k + 1];
                        }
                        else if (words[k + 1] == "been") //indefinite + been 
                        {
                            try
                            {
                                if (POStags[k + 2] == "VBG ") //indefinite + been + word with ing
                                {
                                    verbTag += "_per_con";
                                    verb = words[k + 2];
                                }
                            }
                            catch { }
                        }
                        else
                        {
                            verbTag += "_in";
                        }
                    break;
                }
                // detecting PAST tense
                else if (POStags[k] == "VBN " || (POStags[k] == "VBD " && (words[k] != "had" && words[k] != "was" && words[k] != "were")) || words[k] == "could" || words[k] == "might")

                {
                    verb = words[k];
                    verbTag = "Pa_in";
                    break;
                }

                else if (words[k] == "was" || words[k] == "were" || words[k] == "had")
                {
                    verbTag = "Pa";
                    verb = words[k];
                        if (POStags[k + 1] == "VBG " || POStags[k + 1] == "NN ")

                        {
                            verbTag += "_con";
                            verb = words[k + 1];
                        }
                        else if ((POStags[k + 1] == "VBN " || POStags[k + 1] == "VBD ") && words[k + 1] != "been") //word in Past Participle form
                        {
                            verbTag += "_per";
                            verb = words[k + 1];
                        }
                        else if (words[k + 1] == "been") //indefinite + been 
                        {
                            try
                            {
                                if (POStags[k + 2] == "VBG ") //indefinite + been + word with ing
                                {
                                    verbTag += "_per_con";
                                    verb = words[k + 2];
                                }
                            }
                            catch { }
                        }
                        else
                        {
                            verbTag += "_in";
                        }
                    break;
                }
                // detecting FUTURE tense
                else if (words[k] == "will" || words[k] == "shall")
                {
                    verbTag = "F";
                    if ((POStags[k + 1] == "VB "|| POStags[k + 1] == "NN ") && words[k + 1] != "be" && words[k + 1] != "have") //Future Indefinite
                    {
                        verb = words[k + 1];
                        verbTag += "_in";
                    }
                    else if (words[k + 1] == "be" || POStags[k + 1] == "NN ")  //Future Continious

                    {
                        if (POStags[k + 2] == "VBG ")
                        {
                            verb = words[k + 2];
                            verbTag += "_con";
                        }
                    }
                    else if (words[k + 1] == "have")   //Future Perfect
                    {
                        if ((POStags[k + 2] == "VBN " || POStags[k + 2] == "VBD ") && words[k + 2] != "been")
                        {
                            verb = words[k + 2];
                            verbTag += "_per";
                        }
                        else if (words[k + 2] == "been")
                        {
                            if (POStags[k + 3] == "VBG ")
                            {
                                verbTag += "_per_con";
                                verb = words[k + 3];
                            }
                        }

                    }
                    else
                    {
                        verbTag = "_in";
                        verb = words[k + 2];
                    }
                    break;
                }

                k = k + 1;
            }

            string sentence = detectObjects(words, POStags);
            return sentence;
        }
        public string detectObjects(string[] words, string[] POStags)
        {
            string[] objects = new string[POStags.Length];
            string[] object_postags = new string[POStags.Length];
            int j = 0;
            k = 0;
            int objectArrayLength = objects.Length;
            while (k < objectArrayLength)
            {
                if (words[k] != Subject && words[k] != verb && words[k] != "am" && words[k] != "is" && words[k] != "are" && words[k] != "have" && words[k] != "has" && words[k] != "was" && words[k] != "were" && words[k] != "had" && words[k] != "will" && words[k] != "shall" && words[k] != "be" && words[k] != "been")
                {
                    objects[j] = words[k];
                    object_postags[j] = POStags[k];
                    j++;
                }
                else
                {
                    // error handing
                }
                k = k + 1;
            }
            k = 0;


            TransferAndGeneration_stg atransferAndGeneration_stg = new TransferAndGeneration_stg();
            string sentence = atransferAndGeneration_stg.getInterpreted_Sentence(words, POStags, Subject, Subject_tag, verb, verbTag, objects, object_postags, MainSubjectIndex);
            return sentence;

        }

    }
}