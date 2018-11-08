using SMTwebVersion.Models.Approaches.DirectApproach.Step_2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SMTwebVersion.Models.Approaches.DirectApproach
{
    public class Morphological_Analysis
    {
        private int IndexNO = 0, MainSubjectIndex,MorphinINDEX=0;
        private string Subject, Subject_tag,verb, verbTag,PrepositionRule="";
        private string[]  word;
        private string[] Morphines = new string[10];
        public string StarMorphologicalAnalysis(string[] Word,string[] PoSTags)
        {
            word = Word;
            //Identifying Subject Norphines
            for (int i=0;i<Word.Length;i++)
            {
                if (PoSTags[i] == "PRP " || PoSTags[i] == "NN " || PoSTags[i] == "NNP " || PoSTags[i] == "PRP$ " || PoSTags[i] == "NNP 's" || PoSTags[i] == "NNS " || PoSTags[i] == "NNS 's")
                {
                    if (PoSTags[i] == "NN ") // Akib Ahmed Adnan is eating rice
                    {
                        Subject = Word[i];
                        Subject_tag = PoSTags[i];
                        MainSubjectIndex = i;
                        int IndexCount = i; ;
                        while (PoSTags[IndexCount + 1] == "NN " || PoSTags[IndexCount + 1] == "NNS " || PoSTags[IndexCount + 1] == "NNS 's")
                        {
                            Subject = Word[IndexCount + 1];
                            Subject_tag = PoSTags[IndexCount + 1];
                            MainSubjectIndex = IndexCount + 1;
                            IndexCount++;
                        }
                        if (PoSTags[i + 1] == "VBG " && PoSTags[i + 2] == "NN ")
                        {
                            Subject = Word[i + 2];
                            Subject_tag = PoSTags[i + 2];
                            MainSubjectIndex = i + 1;
                        }
                    }
                    else if (PoSTags[i] == "NNP ")
                    {
                        Subject = Word[i];
                        Subject_tag = PoSTags[i];

                        MainSubjectIndex = i;
                        if (PoSTags[i + 1] == "NNP 's" && PoSTags[i + 2] == "NN ")//Brother Fahim's dog
                        {
                            Subject = Word[i + 2];
                            Subject_tag = PoSTags[i + 2];
                            MainSubjectIndex = i + 2;
                            int IndexCount = i + 2; ;
                            while (PoSTags[IndexCount + 1] == "NN ")
                            {
                                Subject = Word[IndexCount + 1];
                                Subject_tag = PoSTags[IndexCount + 1];
                                MainSubjectIndex = IndexCount + 1;
                                IndexCount++;
                            }
                        }
                        else if (PoSTags[i + 1] == "NNP ")
                        {
                            Subject = Word[i + 1];
                            Subject_tag = PoSTags[i + 1];
                            MainSubjectIndex = i + 1;
                            int IndexCount = i + 1; ;
                            while (PoSTags[IndexCount + 1] == "NNP ")
                            {
                                Subject = Word[IndexCount + 1];
                                Subject_tag = PoSTags[IndexCount + 1];
                                MainSubjectIndex = IndexCount + 1;
                                IndexCount++;
                            }
                        }
                        else if (PoSTags[i + 1] == "NNP 's" && (PoSTags[i + 2] == "JJS " || PoSTags[i + 2] == "JJ ") && PoSTags[i + 3] == "NN ")
                        {
                            Subject = Word[i + 3];
                            Subject_tag = PoSTags[i + 3];
                            MainSubjectIndex = i + 3;
                            int IndexCount = i + 3; ;
                            while (PoSTags[IndexCount + 1] == "NN ")
                            {
                                Subject = Word[IndexCount + 1];
                                Subject_tag = PoSTags[IndexCount + 1];
                                MainSubjectIndex = IndexCount + 1;
                                IndexCount++;
                            }
                        }
                    }
                    else if (PoSTags[i] == "PRP$ ")
                    {
                        Subject = Word[i];
                        Subject_tag = PoSTags[i];

                        MainSubjectIndex = i;
                        if ((PoSTags[i + 1] == "NNP 's"|| PoSTags[i + 1] == "NN 's") && (PoSTags[i + 2] == "NN "|| PoSTags[i + 2] == "NNS "))//My brother's dog
                        {
                            Subject = Word[i + 2];
                            Subject_tag = PoSTags[i + 2];
                            MainSubjectIndex = i + 2;
                        }
                        else if ((PoSTags[i + 1] == "CD " || PoSTags[i + 1] == "DT ") && PoSTags[i + 2] == "NNS ")//My four/4 brother 
                        {                                                                                    //My all children
                            Subject = Word[i + 2];
                            Subject_tag = PoSTags[i + 2];
                            MainSubjectIndex = i + 2;
                        }
                        else if ((PoSTags[i + 1] == "JJ " || PoSTags[i + 1] == "RB ") && PoSTags[i + 2] == "NN ")//Our white dog
                        {                                                                                        //
                            Subject = Word[i + 2];
                            Subject_tag = PoSTags[i + 2];
                            MainSubjectIndex = i + 2;
                        }
                        else if (PoSTags[i + 1] == "NN ") // Our Kishor Laskar Aksh....
                        {
                            Subject = Word[i + 1];
                            Subject_tag = PoSTags[i + 1];
                            MainSubjectIndex = i + 1;
                            int IndexCount = i + 1; ;
                            while (PoSTags[IndexCount + 1] == "NN ")
                            {
                                Subject = Word[IndexCount + 1];
                                Subject_tag = PoSTags[IndexCount + 1];
                                MainSubjectIndex = IndexCount + 1;
                            }

                        }
                    }
                    else if (PoSTags[i] == "NNP 's")
                    {
                        Subject = Word[i];
                        Subject_tag = PoSTags[i];

                        MainSubjectIndex = i;
                        if ((PoSTags[i + 1] == "JJS " || PoSTags[i + 1] == "JJ ") && PoSTags[i + 2] == "NN ")//My brother's dog
                        {
                            Subject = Word[i + 2];
                            Subject_tag = PoSTags[i + 2];
                            MainSubjectIndex = i + 2;
                            int IndexCount = i + 2; ;
                            while (PoSTags[IndexCount + 1] == "NN ")
                            {
                                Subject = Word[IndexCount + 1];
                                Subject_tag = PoSTags[IndexCount + 1];
                                MainSubjectIndex = IndexCount + 1;
                                IndexCount++;
                            }

                        }
                        else if (PoSTags[i + 1] == "NN ")
                        {
                            Subject = Word[i + 1];
                            Subject_tag = PoSTags[i + 1];
                            MainSubjectIndex = i + 1;
                            int IndexCount = i + 1; ;
                            while (PoSTags[IndexCount + 1] == "NN ")
                            {
                                Subject = Word[IndexCount + 1];
                                Subject_tag = PoSTags[IndexCount + 1];
                                MainSubjectIndex = IndexCount + 1;
                                IndexCount++;
                            }
                        }
                    }
                    else if (PoSTags[i] == "NNS ")
                    {
                        Subject = Word[i];
                        Subject_tag = PoSTags[i];

                        MainSubjectIndex = i;
                    }
                    else if (PoSTags[i] == "NNS 's")
                    {
                        Subject = Word[i];
                        Subject_tag = PoSTags[i];

                        MainSubjectIndex = i;
                        int IndexCount = i; ;
                        while (PoSTags[IndexCount + 1] == "NN ")
                        {
                            Subject = Word[IndexCount + 1];
                            Subject_tag = PoSTags[IndexCount + 1];
                            MainSubjectIndex = IndexCount + 1;
                            IndexCount++;
                        }
                    }
                    else if (PoSTags[i] == "PRP ")
                    {
                        Subject = Word[i];
                        Subject_tag = PoSTags[i];

                        MainSubjectIndex = i;
                    }
                    IndexNO = MainSubjectIndex+1;
                    addMorphinesTo_array(0, MainSubjectIndex);
                    Morphines[MorphinINDEX-1] += " "+"SP";
                    break;
                }
            }
            //Identifying Verbal,Prepositional and other Morphines
            for (int IndexNo= IndexNO; IndexNo<Word.Length;IndexNo++)
            {
                //Identifying Veral Norphines
                if (PoSTags[IndexNo] == "NNS "||PoSTags[IndexNo] == "VB " || PoSTags[IndexNo] == "VBD " || PoSTags[IndexNo] == "VBG " || PoSTags[IndexNo] == "VBN " || PoSTags[IndexNo] == "VBP " || PoSTags[IndexNo] == "VBZ "|| Word[IndexNo].ToLower() == "am" || Word[IndexNo].ToLower() == "is" || Word[IndexNo].ToLower() == "are" || Word[IndexNo].ToLower() == "was" || Word[IndexNo].ToLower() == "were" || Word[IndexNo].ToLower() == "will" || Word[IndexNo].ToLower() == "would" || Word[IndexNo].ToLower() == "should" || Word[IndexNo].ToLower() == "may" || Word[IndexNo].ToLower() == "might" || Word[IndexNo].ToLower() == "can" || Word[IndexNo].ToLower() == "could")
                {
                    int verbIndex = 0;
                    if ((PoSTags[IndexNo] == "VBZ " && (Word[IndexNo] != "have" && Word[IndexNo] != "has" && Word[IndexNo] != "is")) || (PoSTags[IndexNo] == "NNS " && (Word[IndexNo] != "have" && Word[IndexNo] != "has")) || (PoSTags[IndexNo] == "VB " && (Word[IndexNo] != "have" && Word[IndexNo] != "has")) || Word[IndexNo] == "can " || Word[IndexNo] == "may")
                    {
                        verb = Word[IndexNo];
                        verbIndex = IndexNo;
                        verbTag = "P_in";

                    }
                    else if (Word[IndexNo] == "am" || Word[IndexNo] == "is" || Word[IndexNo] == "are" || Word[IndexNo] == "has" || Word[IndexNo] == "have")
                    {
                        verbTag = "P";
                        verb = Word[IndexNo];
                        verbIndex = IndexNo;

                        if (PoSTags[IndexNo + 1] == "VBG ") //word with ing

                            if (PoSTags[IndexNo + 1] == "VBG " || PoSTags[IndexNo + 1] == "NN ") //word with ing
                            {
                                verbTag += "_con";
                                verb = Word[IndexNo + 1];
                                verbIndex = IndexNo + 1;
                            }
                            else if ((PoSTags[IndexNo + 1] == "VBN " || PoSTags[IndexNo + 1] == "VBD ") && Word[IndexNo + 1] != "been") //word in Past Participle form
                            {
                                verbTag += "_per";
                                verb = Word[IndexNo + 1];
                                verbIndex = IndexNo + 1;
                            }
                            else if (Word[IndexNo + 1] == "been") //indefinite + been 
                            {
                                try
                                {
                                    if (PoSTags[IndexNo + 2] == "VBG ") //indefinite + been + word with ing
                                    {
                                        verbTag += "_per_con";
                                        verb = Word[IndexNo + 2];
                                        verbIndex = IndexNo + 2;
                                    }
                                }
                                catch { }
                            }
                            else
                            {
                                verbTag += "_in";
                            }
                    }
                    // detecting PAST tense
                    else if (PoSTags[IndexNo] == "VBN " || (PoSTags[IndexNo] == "VBD " && (Word[IndexNo] != "had" && Word[IndexNo] != "was" && Word[IndexNo] != "were")) || Word[IndexNo] == "could" || Word[IndexNo] == "might")

                    {
                        verb = Word[IndexNo];
                        verbIndex = IndexNo;
                        verbTag = "Pa_in";
                    }

                    else if (Word[IndexNo] == "was" || Word[IndexNo] == "were" || Word[IndexNo] == "had")
                    {
                        verbTag = "Pa";
                        verb = Word[IndexNo];
                        verbIndex = IndexNo;
                            if (PoSTags[IndexNo + 1] == "VBG " || PoSTags[IndexNo + 1] == "NN ")

                            {
                                verbTag += "_con";
                                verb = Word[IndexNo + 1];
                                verbIndex = IndexNo + 1;
                            }
                            else if ((PoSTags[IndexNo + 1] == "VBN " || PoSTags[IndexNo + 1] == "VBD ") && Word[IndexNo + 1] != "been") //word in Past Participle form
                            {
                                verbTag += "_per";
                                verb = Word[IndexNo + 1];
                                verbIndex = IndexNo + 1;
                            }
                            else if (Word[IndexNo + 1] == "been") //indefinite + been 
                            {
                                try
                                {
                                    if (PoSTags[IndexNo + 2] == "VBG ") //indefinite + been + word with ing
                                    {
                                        verbTag += "_per_con";
                                        verb = Word[IndexNo + 2];
                                        verbIndex = IndexNo + 2;
                                    }
                                }
                                catch { }
                            }
                            else
                            {
                                verbTag += "_in";
                            }
                    }
                    // detecting FUTURE tense
                    else if (Word[IndexNo] == "will" || Word[IndexNo] == "shall")
                    {
                        verbTag = "F";
                        if ((PoSTags[IndexNo + 1] == "VB " || PoSTags[IndexNo + 1] == "NN ") && Word[IndexNo + 1] != "be" && Word[IndexNo + 1] != "have") //Future Indefinite
                        {
                            verb = Word[IndexNo + 1];
                            verbIndex = IndexNo + 1;
                            verbTag += "_in";
                        }
                        else if (Word[IndexNo + 1] == "be" || PoSTags[IndexNo + 1] == "NN ")  //Future Continious

                        {
                            if (PoSTags[IndexNo + 2] == "VBG ")
                            {
                                verb = Word[IndexNo + 2];
                                verbIndex = IndexNo + 2;
                                verbTag += "_con";
                            }
                        }
                        else if (Word[IndexNo + 1] == "have")   //Future Perfect
                        {
                            if ((PoSTags[IndexNo + 2] == "VBN " || PoSTags[IndexNo + 2] == "VBD ") && Word[IndexNo + 2] != "been")
                            {
                                verb = Word[IndexNo + 2];
                                verbIndex = IndexNo + 2;
                                verbTag += "_per";
                            }
                            else if (Word[IndexNo + 2] == "been")
                            {
                                if (PoSTags[IndexNo + 3] == "VBG ")
                                {
                                    verbTag += "_per_con";
                                    verb = Word[IndexNo + 3];
                                    verbIndex = IndexNo + 3;
                                }
                            }

                        }
                        else
                        {
                            verbTag = "_in";
                            verb = Word[IndexNo + 2];
                            verbIndex = IndexNo + 2;
                        }
                    }

                    addMorphinesTo_array(IndexNo, verbIndex);
                    IndexNo = verbIndex;
                    Morphines[MorphinINDEX - 1] += " " + "VP";
                }


                //Identifying Prepositional Morphines
                else if (PoSTags[IndexNo] == "IN " || PoSTags[IndexNo] == "TO ")
                {

                    int PStructure_start = 0, PStructure_end = 0;
                    //in your house
                     if ((PoSTags[IndexNo + 1] == "PRP$ ") && (PoSTags[IndexNo + 2] == "NN " || PoSTags[IndexNo + 2] == "NNS " || PoSTags[IndexNo + 2] == "NNP " || PoSTags[IndexNo + 2] == "NNPS "))
                    {
                        PStructure_start = IndexNo;
                        PStructure_end = IndexNo + 2;
                        PrepositionRule = "case7";
                    }
                    //in summer
                    else if ((Word[IndexNo + 1] == "summer" || Word[IndexNo + 1] == "spring" || Word[IndexNo + 1] == "fall" || Word[IndexNo + 1] == "rainy"))
                    {
                        PStructure_start = IndexNo;
                        PStructure_end = IndexNo + 1;
                        PrepositionRule = "case32";
                    }
                    //to him,Fahim,me
                    else if(((PoSTags[IndexNo + 1] == "PRP " && Word[IndexNo + 1] != "it") || Word[IndexNo + 1] == "her" || (PoSTags[IndexNo + 1] == "NN " || PoSTags[IndexNo + 1] == "NNS " || PoSTags[IndexNo + 1] == "NNP " || PoSTags[IndexNo + 1] == "NNPS " || PoSTags[IndexNo + 1] == "PRP " || PoSTags[IndexNo + 1] == "PRP$ ")))
                    {
                        PStructure_start = IndexNo;
                        PStructure_end = IndexNo;

                        while ((PoSTags[PStructure_end + 1] == "NNP " || PoSTags[PStructure_end + 1] == "NN " || PoSTags[PStructure_end + 1] == "NNS ") && PStructure_end<PoSTags.Length)
                        {
                            PStructure_end++;
                            if (PStructure_end== PoSTags.Length-1) { break; }
                        }
                        if (PStructure_end == IndexNo) { PStructure_end = PStructure_end + 1; }//increment when no repeatation of noun
                        PrepositionRule = "case1";
                    }
                    //in the morning
                    else if (Word[IndexNo + 1] == "the" && (Word[IndexNo + 2] == "morning" || Word[IndexNo + 2] == "evening" || Word[IndexNo + 2] == "afternoon"))
                    {
                        PStructure_start = IndexNo;
                        PStructure_end = IndexNo + 2;                        
                        PrepositionRule = "case10";
                    }
                    // in the house
                    else if ((Word[IndexNo + 1] == "a" || Word[IndexNo + 1] == "an" || Word[IndexNo + 1] == "the") /*DT=article*/ && (PoSTags[IndexNo + 2] == "NN " || PoSTags[IndexNo + 2] == "NNS " || PoSTags[IndexNo + 2] == "NNP " || PoSTags[IndexNo + 2] == "NNPS " || PoSTags[IndexNo + 2] == "PRP " || PoSTags[IndexNo + 2] == "PRP$ "))
                    {
                        PStructure_start = IndexNo;
                        PStructure_end = IndexNo + 2;
                        PrepositionRule = "case2";
                    }
                    //to this,that,those,these,it(PRP)
                    else if ((Word[IndexNo + 1] == "this" || Word[IndexNo + 1] == "that" || Word[IndexNo + 1] == "those" || Word[IndexNo + 1] == "these" || Word[IndexNo + 1] == "it"))
                    {
                        PStructure_start = IndexNo;
                        PStructure_end = IndexNo + 1;
                        PrepositionRule = "case5";
                    }
                    //in any house,behind that building
                    else if ((Word[IndexNo + 1] == "any" || Word[IndexNo + 1] == "every" || Word[IndexNo + 1] == "both" || Word[IndexNo + 1] == "all") && (PoSTags[IndexNo + 2] == "NN " || PoSTags[IndexNo + 2] == "NNS " || PoSTags[IndexNo + 2] == "NNP " || PoSTags[IndexNo + 2] == "NNPS "))
                    {
                        PStructure_start = IndexNo;
                        PStructure_end = IndexNo + 1;
                        PrepositionRule = "case6";//also applicable for case 24
                    }
                    
                    //in january
                    else if ((Word[IndexNo + 1] == "January" || Word[IndexNo + 1] == "February" || Word[IndexNo + 1] == "March" || Word[IndexNo + 1] == "April" || Word[IndexNo + 1] == "May" || Word[IndexNo + 1] == "June" || Word[IndexNo + 1] == "July" || Word[IndexNo + 1] == "August" || Word[IndexNo + 1] == "September" || Word[IndexNo + 1] == "October" || Word[IndexNo + 1] == "November" || Word[IndexNo + 1] == "December"))
                    {
                        PStructure_start = IndexNo;
                        PStructure_end = IndexNo + 1;
                        PrepositionRule = "case8";
                    }
                    //at 6,six_am/pm
                    else if ((PoSTags[IndexNo + 1] == "CD am" || PoSTags[IndexNo + 1] == "CD AM" || PoSTags[IndexNo + 1] == "CD pm" || PoSTags[IndexNo + 1] == "CD PM") || (PoSTags[IndexNo + 1] == "CD " && (Word[IndexNo + 2] == "AM" || Word[IndexNo + 2] == "PM" || Word[IndexNo + 2] == "am" || Word[IndexNo + 2] == "pm")))
                    {
                        PStructure_start = IndexNo;
                        PStructure_end = IndexNo + 2;
                        PrepositionRule = "case8";
                    }
                    //in morning
                    else if ((Word[IndexNo + 1] == "morning" || Word[IndexNo + 1] == "evening" || Word[IndexNo + 1] == "afternoon"))
                    {
                        PStructure_start = IndexNo;
                        PStructure_end = IndexNo + 1;
                        PrepositionRule = "case9";
                    }

                    //P+a+few+weeks,months....
                    else if (Word[IndexNo + 1] == "a" && Word[IndexNo + 2] == "few" && (Word[IndexNo + 3] == "minutes" || Word[IndexNo + 3] == "hours" || Word[IndexNo + 3] == "days" || Word[IndexNo + 3] == "months" || Word[IndexNo + 3] == "weeks"))
                    {
                        PStructure_start = IndexNo;
                        PStructure_end = IndexNo + 3;
                        PrepositionRule = "case11";
                    }
                    //in a week/in 10 days....
                    else if (Word[IndexNo + 1] == "a" || PoSTags[IndexNo + 1] == "CD " && (Word[IndexNo + 2] == "minutes" || Word[IndexNo + 2] == "hours" || Word[IndexNo + 2] == "days" || Word[IndexNo + 2] == "months" || Word[IndexNo + 2] == "weeks"))
                    {
                        PStructure_start = IndexNo;
                        PStructure_end = IndexNo + 2;
                        PrepositionRule = "case12";
                    }
                    //of mine
                    else if (Word[IndexNo + 1] == "mine")
                    {
                        PStructure_start = IndexNo;
                        PStructure_end = IndexNo + 1;
                        PrepositionRule = "case13";
                    }
                    // above 6%,10,two
                    else if ((Word[IndexNo + 1] == "a" || PoSTags[IndexNo + 1] == "CD " || PoSTags[IndexNo + 1] == "CD %"))
                    {
                        PStructure_start = IndexNo;
                        PStructure_end = IndexNo + 1;
                        PrepositionRule = "case14";
                    }
                    //since going home
                    else if ((PoSTags[IndexNo + 1] == "VBG ") && (PoSTags[IndexNo + 2] == "NN " || PoSTags[IndexNo + 2] == "NNS " || PoSTags[IndexNo + 2] == "NNP " || PoSTags[IndexNo + 2] == "NNPS "))
                    {
                        PStructure_start = IndexNo;
                        PStructure_end = IndexNo + 2;
                        PrepositionRule = "case15";
                    }
                    //except for her book
                    else if (Word[IndexNo + 1] == "for" && (PoSTags[IndexNo + 2] == "PRP$ " || Word[IndexNo + 2] == "her") && (PoSTags[IndexNo + 3] == "NN " || PoSTags[IndexNo + 3] == "NNS " || PoSTags[IndexNo + 3] == "NNP " || PoSTags[IndexNo + 3] == "NNPS "))
                    {
                        PStructure_start = IndexNo;
                        PStructure_end = IndexNo + 3;
                        PrepositionRule = "case16";
                    }
                    //on one foot
                    else if ((Word[IndexNo + 1] == "a" || Word[IndexNo + 1] == "an" || PoSTags[IndexNo + 1] == "CD ") && (PoSTags[IndexNo + 1] == "NN " || PoSTags[IndexNo + 2] == "NNS " || PoSTags[IndexNo + 2] == "NNP " || PoSTags[IndexNo + 2] == "NNPS "))
                    {
                        PStructure_start = IndexNo;
                        PStructure_end = IndexNo + 2;
                        PrepositionRule = "case18";
                    }
                    //on Saturday
                    else if ((Word[IndexNo + 1] == "saturday" || Word[IndexNo + 1] == "sunday" || Word[IndexNo + 1] == "monday" || Word[IndexNo + 1] == "tuesday" || Word[IndexNo + 1] == "wednesday" || Word[IndexNo + 1] == "thrustday" || Word[IndexNo + 1] == "friday"))
                    {
                        PStructure_start = IndexNo;
                        PStructure_end = IndexNo + 1;
                        PrepositionRule = "case19";
                    }
                    //on,to left
                    else if ((Word[IndexNo + 1] == "Left" || Word[IndexNo + 1] == "Right" || Word[IndexNo + 1] == "Back" || Word[IndexNo + 1] == "Bottom" || Word[IndexNo + 1] == "left" || Word[IndexNo + 1] == "right" || Word[IndexNo + 1] == "back" || Word[IndexNo + 1] == "Right"))
                    {
                        PStructure_start = IndexNo;
                        PStructure_end = IndexNo + 1;
                        PrepositionRule = "case20";
                    }
                    else if (Word[IndexNo + 1] == "the" && (Word[IndexNo + 2] == "Left" || Word[IndexNo + 2] == "Right" || Word[IndexNo + 2] == "Back" || Word[IndexNo + 2] == "Bottom" || Word[IndexNo + 2] == "left" || Word[IndexNo + 2] == "right" || Word[IndexNo + 2] == "back" || Word[IndexNo + 2] == "Right"))
                    {
                        PStructure_start = IndexNo;
                        PStructure_end = IndexNo + 2;
                        PrepositionRule = "case21";
                    }
                    //like this house
                    else if ((Word[IndexNo + 1] == "this" || Word[IndexNo + 1] == "that" || Word[IndexNo + 1] == "those" || Word[IndexNo + 1] == "these") && (PoSTags[IndexNo + 2] == "NN " || PoSTags[IndexNo + 2] == "NNS " || PoSTags[IndexNo + 2] == "NNP " || PoSTags[IndexNo + 2] == "NNPS "))
                    {
                        PStructure_start = IndexNo;
                        PStructure_end = IndexNo + 2;
                        PrepositionRule = "case24";
                    }
                    //like yours,theirs
                    else if (Word[IndexNo + 1] == "yours" || Word[IndexNo + 1] == "theirs" || Word[IndexNo + 1] == "him" || Word[IndexNo + 1] == "ours")
                    {
                        PStructure_start = IndexNo;
                        PStructure_end = IndexNo + 1;
                        PrepositionRule = "case25";
                    }
                    //between Abid and Sahin
                    else if ((PoSTags[IndexNo + 1] == "NN " || PoSTags[IndexNo + 1] == "NNS " || PoSTags[IndexNo + 1] == "NNP " || PoSTags[IndexNo + 1] == "NNPS ") && (Word[IndexNo + 2] == "and") && (PoSTags[IndexNo + 3] == "NN " || PoSTags[IndexNo + 3] == "NNS " || PoSTags[IndexNo + 3] == "NNP " || PoSTags[IndexNo + 3] == "NNPS "))
                    {
                        PStructure_start = IndexNo;
                        PStructure_end = IndexNo + 3;
                        PrepositionRule = "case26";
                    }
                    //between the Canada and the America
                    else if (Word[IndexNo + 1] == "the" && (PoSTags[IndexNo + 2] == "NN " || PoSTags[IndexNo + 2] == "NNS " || PoSTags[IndexNo + 2] == "NNP " || PoSTags[IndexNo + 2] == "NNPS ") && (Word[IndexNo + 3] == "and") && Word[IndexNo + 4] == "the" && (PoSTags[IndexNo + 5] == "NN " || PoSTags[IndexNo + 5] == "NNS " || PoSTags[IndexNo + 5] == "NNP " || PoSTags[IndexNo + 5] == "NNPS "))
                    {
                        PStructure_start = IndexNo;
                        PStructure_end = IndexNo + 5;
                        PrepositionRule = "case27";
                    }
                    //between the 2/two books
                    else if (Word[IndexNo + 1] == "the" && PoSTags[IndexNo + 2] == "CD " && PoSTags[IndexNo + 3] == "NNS ")
                    {
                        PStructure_start = IndexNo;
                        PStructure_end = IndexNo + 2;
                        PrepositionRule = "case28";
                    }
                    //since getting the book
                    else if (PoSTags[IndexNo + 1] == "VVG " && Word[IndexNo + 2] == "the" && (PoSTags[IndexNo + 3] == "NN " || PoSTags[IndexNo + 3] == "NNS " || PoSTags[IndexNo + 3] == "NNP " || PoSTags[IndexNo + 3] == "NNPS "))
                    {
                        PStructure_start = IndexNo;
                        PStructure_end = IndexNo + 3;
                        PrepositionRule = "case29";
                    }
                    //under an hour
                    else if (Word[IndexNo + 1] == "an" && Word[IndexNo + 2] == "hour")
                    {
                        PStructure_start = IndexNo;
                        PStructure_end = IndexNo + 1;
                        PrepositionRule = "case30";
                    }
                    //concerning then,now
                    else if ((Word[IndexNo + 1] == "now" || Word[IndexNo + 1] == "then"))
                    {
                        PStructure_start = IndexNo;
                        PStructure_end = IndexNo + 1;
                        PrepositionRule = "case31";
                    }
                    
                    //unlike most systems
                    else if ((Word[IndexNo + 1] == "most") && (PoSTags[IndexNo + 2] == "NN " || PoSTags[IndexNo + 2] == "NNS " || PoSTags[IndexNo + 2] == "NNP " || PoSTags[IndexNo + 2] == "NNPS "))
                    {
                        PStructure_start = IndexNo;
                        PStructure_end = IndexNo + 2;
                        PrepositionRule = "case35";
                    }
                    //without some tools
                    else if ((Word[IndexNo + 1] == "any" || Word[IndexNo + 1] == "some" || Word[IndexNo + 1] == "all" || Word[IndexNo + 1] == "other") && (PoSTags[IndexNo + 2] == "NN " || PoSTags[IndexNo + 2] == "NNS " || PoSTags[IndexNo + 2] == "NNP " || PoSTags[IndexNo + 2] == "NNPS "))
                    {
                        PStructure_start = IndexNo;
                        PStructure_end = IndexNo + 2;
                        PrepositionRule = "case36";
                    }
                    //without some other seeds
                    else if ((Word[IndexNo + 1] == "any" || Word[IndexNo + 1] == "some" || Word[IndexNo + 1] == "all") && (Word[IndexNo + 2] == "other") && (PoSTags[IndexNo + 3] == "NN " || PoSTags[IndexNo + 3] == "NNS " || PoSTags[IndexNo + 3] == "NNP " || PoSTags[IndexNo + 3] == "NNPS "))
                    {
                        PStructure_start = IndexNo;
                        PStructure_end = IndexNo + 3;
                        PrepositionRule = "case42";
                    }
                    //wthout going any house
                    else if (PoSTags[IndexNo + 1] == "VBG " && (PoSTags[IndexNo + 1] == "any" || PoSTags[IndexNo + 1] == "some") && (PoSTags[IndexNo + 3] == "NN " || PoSTags[IndexNo + 3] == "NNS " || PoSTags[IndexNo + 3] == "NNP " || PoSTags[IndexNo + 3] == "NNPS "))
                    {
                        PStructure_start = IndexNo;
                        PStructure_end = IndexNo + 3;
                        PrepositionRule = "case39";
                    }
                    //for more systems
                    else if ((Word[IndexNo + 1] == "more") && (PoSTags[IndexNo + 2] == "NN " || PoSTags[IndexNo + 2] == "NNS " || PoSTags[IndexNo + 2] == "NNP " || PoSTags[IndexNo + 2] == "NNPS "))
                    {
                        PStructure_start = IndexNo;
                        PStructure_end = IndexNo + 2;
                        PrepositionRule = "case43";
                    }
                    //for that/this one
                    else if ((Word[IndexNo + 1] == "this" || Word[IndexNo + 1] == "that" || Word[IndexNo + 1] == "those" || Word[IndexNo + 1] == "these") && Word[IndexNo + 2] == "one")
                    {
                        PStructure_start = IndexNo;
                        PStructure_end = IndexNo + 2;
                        PrepositionRule = "case44";
                    }
                    else if ((PoSTags[IndexNo + 1] == "NN " || PoSTags[IndexNo + 1] == "NNS " || PoSTags[IndexNo + 1] == "NNP " || PoSTags[IndexNo + 1] == "NNPS ") && Word[IndexNo + 2] == "to" && (PoSTags[IndexNo + 3] == "NN " || PoSTags[IndexNo + 3] == "NNS " || PoSTags[IndexNo + 3] == "NNP " || PoSTags[IndexNo + 3] == "NNPS "))
                    {
                        PStructure_start = IndexNo;
                        PStructure_end = IndexNo + 3;
                        PrepositionRule = "case46";
                    }
                    else if (PoSTags[IndexNo + 1] == "CD " && (PoSTags[IndexNo + 2] == "NN " || PoSTags[IndexNo + 2] == "NNS " || PoSTags[IndexNo + 2] == "NNP " || PoSTags[IndexNo + 2] == "NNPS ") && Word[IndexNo + 3] == "to" && PoSTags[IndexNo + 4] == "CD " && (PoSTags[IndexNo + 5] == "NN " || PoSTags[IndexNo + 5] == "NNS " || PoSTags[IndexNo + 5] == "NNP " || PoSTags[IndexNo + 5] == "NNPS "))
                    {
                        PStructure_start = IndexNo;
                        PStructure_end = IndexNo + 5;
                        PrepositionRule = "case47";
                    }
                    else if (Word[IndexNo + 1] == "a" && (Word[IndexNo + 2] == "few" && (Word[IndexNo + 3] == "days" || Word[IndexNo + 3] == "months" || Word[IndexNo + 3] == "hours" || Word[IndexNo + 3] == "seconds" || Word[IndexNo + 3] == "moments")))
                    {
                        PStructure_start = IndexNo;
                        PStructure_end = IndexNo + 3;
                        PrepositionRule = "case49";
                    }
                    else if ((PoSTags[IndexNo + 1] == "IN " || PoSTags[IndexNo + 1] == "TO ") && Word[IndexNo + 2] == "all" && Word[IndexNo + 3] == "the" && (PoSTags[IndexNo + 4] == "NN " || PoSTags[IndexNo + 4] == "NNS " || PoSTags[IndexNo + 4] == "NNP " || PoSTags[IndexNo + 4] == "NNPS "))
                    {
                        PStructure_start = IndexNo;
                        PStructure_end = IndexNo + 3;
                        PrepositionRule = "case50";
                    }
                    else if ((PoSTags[IndexNo + 1] == "IN " || PoSTags[IndexNo + 1] == "TO ") && Word[IndexNo + 2] == "all" && (PoSTags[IndexNo + 4] == "NN " || PoSTags[IndexNo + 4] == "NNS " || PoSTags[IndexNo + 4] == "NNP " || PoSTags[IndexNo + 4] == "NNPS "))
                    {
                        PStructure_start = IndexNo;
                        PStructure_end = IndexNo + 2;
                        PrepositionRule = "case51";
                    }
                    else if ((PoSTags[IndexNo + 1] == "NN " || PoSTags[IndexNo + 1] == "NNS " || PoSTags[IndexNo + 1] == "NNP " || PoSTags[IndexNo + 1] == "NNPS ") && (PoSTags[IndexNo + 2] == "IN " || PoSTags[IndexNo + 2] == "TO ") && (PoSTags[IndexNo + 3] == "NN " || PoSTags[IndexNo + 3] == "NNS " || PoSTags[IndexNo + 3] == "NNP " || PoSTags[IndexNo + 3] == "NNPS "))
                    {
                        PStructure_start = IndexNo - 1;
                        PStructure_end = IndexNo + 1;
                        PrepositionRule = "case52";
                    }
                    else if ((PoSTags[IndexNo + 1] == "NN " || PoSTags[IndexNo + 1] == "NNS " || PoSTags[IndexNo + 1] == "NNP " || PoSTags[IndexNo + 1] == "NNPS ") && (PoSTags[IndexNo + 2] == "IN " || PoSTags[IndexNo + 2] == "TO ") && Word[IndexNo + 3] == "the" && (PoSTags[IndexNo + 4] == "NN " || PoSTags[IndexNo + 4] == "NNS " || PoSTags[IndexNo + 4] == "NNP " || PoSTags[IndexNo + 4] == "NNPS "))
                    {
                        PStructure_start = IndexNo - 1;
                        PStructure_end = IndexNo + 2;
                        PrepositionRule = "case53";
                    }
                    else if (Word[IndexNo + 1] == "air" || Word[IndexNo + 1] == "land" || Word[IndexNo + 1] == "sea")
                    {
                        PStructure_start = IndexNo;
                        PStructure_end = IndexNo + 1;
                        PrepositionRule = "case54";
                    }
                    else if (Word[IndexNo + 1] == "tomorrow" || Word[IndexNo + 1] == "yesterday" || Word[IndexNo + 1] == "today" || Word[IndexNo + 1] == "now")
                    {
                        PStructure_start = IndexNo;
                        PStructure_end = IndexNo + 1;
                        PrepositionRule = "case55";
                    }
                    else if ((Word[IndexNo + 1] == "this" || Word[IndexNo + 1] == "that" || Word[IndexNo + 1] == "these" || Word[IndexNo + 1] == "those") && (PoSTags[IndexNo + 2] == "NN " || PoSTags[IndexNo + 2] == "NNS " || PoSTags[IndexNo + 2] == "NNP " || PoSTags[IndexNo + 2] == "NNPS "))
                    {
                        PStructure_start = IndexNo;
                        PStructure_end = IndexNo + 2;
                        PrepositionRule = "case56";
                    }
                    else if (Word[IndexNo + 1] == "outside" && Word[IndexNo + 2] == "of" && PoSTags[IndexNo + 3] == "DT " && (PoSTags[IndexNo + 4] == "NN " || PoSTags[IndexNo + 4] == "NNS " || PoSTags[IndexNo + 4] == "NNP " || PoSTags[IndexNo + 4] == "NNPS "))
                    {
                        PStructure_start = IndexNo;
                        PStructure_end = IndexNo + 3;
                        PrepositionRule = "case58";
                    }
                    else if (Word[IndexNo + 1] == "anything" || Word[IndexNo + 1] == "everything" || Word[IndexNo + 1] == "nothing")
                    {
                        PStructure_start = IndexNo;
                        PStructure_end = IndexNo + 1;
                        PrepositionRule = "case59";
                    }
                    //concerning the future of the company
                    else if (Word[IndexNo + 1] == "the" && (PoSTags[IndexNo + 2] == "NN " || PoSTags[IndexNo + 2] == "NNS " || PoSTags[IndexNo + 2] == "NNP " || PoSTags[IndexNo + 2] == "NNPS ") && Word[IndexNo + 3] == "of" && Word[IndexNo + 4] == "the" && (PoSTags[IndexNo + 5] == "NN " || PoSTags[IndexNo + 5] == "NNS " || PoSTags[IndexNo + 5] == "NNP " || PoSTags[IndexNo + 5] == "NNPS "))
                    {
                        PStructure_start = IndexNo;
                        PStructure_end = IndexNo + 5;
                        PrepositionRule = "case61";
                    }
                    //since then ,from then 
                    else if (Word[IndexNo + 1] == "then")
                    {
                        PStructure_start = IndexNo;
                        PStructure_end = IndexNo + 1;
                        PrepositionRule = "case62";
                    }
                    else if ((PoSTags[IndexNo + 1] == "PRP " || PoSTags[IndexNo + 1] == "NN " || PoSTags[IndexNo + 1] == "NNS " || PoSTags[IndexNo + 1] == "NNP " || PoSTags[IndexNo + 1] == "NNPS ") && (PoSTags[IndexNo + 2] == "VB " || PoSTags[IndexNo + 2] == "VBZ "))
                    {
                        PStructure_start = IndexNo;
                        PStructure_end = IndexNo + 2;
                        PrepositionRule = "case63";
                    }
                    //towards china gate
                    else if (PoSTags[IndexNo + 1] == "NN " && PoSTags[IndexNo + 2] == "NN ")
                    {
                        PStructure_start = IndexNo;
                        PStructure_end = IndexNo + 2;
                        PrepositionRule = "case64";
                    }
                    //until the bus comes
                    else if ((Word[IndexNo + 1] == "a" || Word[IndexNo + 1] == "an" || Word[IndexNo + 1] == "the") && (PoSTags[IndexNo + 2] == "NN " || PoSTags[IndexNo + 2] == "NNS " || PoSTags[IndexNo + 2] == "NNP " || PoSTags[IndexNo + 2] == "NNPS ") && (PoSTags[IndexNo + 3] == "VB " || PoSTags[IndexNo + 3] == "VBZ " || PoSTags[IndexNo + 3] == "VBP "))
                    {

                        PStructure_start = IndexNo;
                        PStructure_end = IndexNo + 3;
                        PrepositionRule = "case65";
                    }
                    //with anybody
                    else if (Word[IndexNo + 1] == "anybody" || Word[IndexNo + 1] == "somebody")
                    {
                        PStructure_start = IndexNo;
                        PStructure_end = IndexNo + 1;
                        PrepositionRule = "case66";
                    }
                    //with the black panther
                    else if (Word[IndexNo + 1] == "the" && PoSTags[IndexNo + 2] == "NN " && PoSTags[IndexNo + 3] == "NN ")
                    {
                        PStructure_start = IndexNo;
                        PStructure_end = IndexNo + 3;
                        PrepositionRule = "case67";
                    }
                    //5 to 10
                    else if (PoSTags[IndexNo + 1] == "CD " && PoSTags[IndexNo + 3] == "CD ")
                    {
                        PStructure_start = IndexNo - 1;
                        PStructure_end = IndexNo + 1;
                        PrepositionRule = "case68";
                    }
                    // to meet him/fahim
                    else if ((PoSTags[IndexNo + 1] == "VB " || PoSTags[IndexNo + 1] == "VBZ " || PoSTags[IndexNo + 1] == "VBP ") && (Word[IndexNo + 3] == "this" || Word[IndexNo + 3] == "that" || Word[IndexNo + 3] == "those" || Word[IndexNo + 3] == "these" || PoSTags[IndexNo + 3] == "NN " || PoSTags[IndexNo + 3] == "NNS " || PoSTags[IndexNo + 3] == "NNP " || PoSTags[IndexNo + 3] == "NNPS " || PoSTags[IndexNo + 3] == "PRP " || PoSTags[IndexNo + 3] == "PRP$ "))
                    {
                        PStructure_start = IndexNo;
                        PStructure_end = IndexNo + 2;
                        PrepositionRule = "case69";
                    }
                    //to get
                    else if (PoSTags[IndexNo + 1] == "VB " || PoSTags[IndexNo + 1] == "VBZ " || PoSTags[IndexNo + 1] == "VBP ")
                    {
                        PStructure_start = IndexNo;
                        PStructure_end = IndexNo + 1;
                        PrepositionRule = "case70";
                    }

                    addMorphinesTo_array(PStructure_start, PStructure_end);
                    IndexNo = PStructure_end;
                    Morphines[MorphinINDEX - 1] += " " + PrepositionRule;
                }

                //Other Morphines starts with ARTICLES (TagHint: OPM-Other Multiple Morphines)
                else if (Word[IndexNo] == "a" || Word[IndexNo] == "an" || Word[IndexNo] == "the")
                {
                    int endingIndex = 0;
                    for (int i = IndexNo + 1; i < Word.Length; i++)
                    {
                        if ((PoSTags[i] == "NN " || PoSTags[i] == "NNS ") /*&& (PoSTags[i + 1] != "NN " || PoSTags[i + 1] != "NNS " || PoSTags[i + 1] != "NNP ")*/)
                        {
                            addMorphinesTo_array(IndexNo, i);
                            IndexNo = i;
                            Morphines[MorphinINDEX - 1] += " " + "OPM";
                            break;
                        }
                        else if (PoSTags[i] == "NNP ")
                        {
                            endingIndex = i;
                            // Search for More NNP (Proper Noun)
                            for (int j = i + 1; j < Word.Length; j++)
                            {
                                if (PoSTags[j] == "NNP ")
                                {
                                    endingIndex = j;
                                }
                            }
                            addMorphinesTo_array(IndexNo, endingIndex);
                            IndexNo = i;
                            Morphines[MorphinINDEX - 1] += " " + "OPM";
                            break;
                        }
                        else if (PoSTags[i] == "JJ " || PoSTags[i] == "JJS " || PoSTags[i] == "JJR " || PoSTags[i] == "JJ " || PoSTags[i] == "RB ")
                        {
                            for (int j = i + 1; j < Word.Length; j++)
                            {
                                if (PoSTags[j] == "JJ " || PoSTags[j] == "JJS " || PoSTags[j] == "JJR " || PoSTags[j] == "JJ " || PoSTags[j] == "RB ")
                                {
                                    i++;
                                }
                            }
                            if ((PoSTags[i] == "NN " || PoSTags[i] == "NNS ") /*&& (PoSTags[i + 1] != "NN " || PoSTags[i + 1] != "NNS " || PoSTags[i + 1] != "NNP ")*/)
                            {
                                addMorphinesTo_array(IndexNo, i);
                                IndexNo = i;
                                Morphines[MorphinINDEX - 1] += " " + "OPM";
                                break;
                            }
                            else if (PoSTags[i] == "NNP ")
                            {
                                endingIndex = i;
                                // Search for More NNP (Proper Noun)
                                for (int j = i + 1; j < Word.Length; j++)
                                {
                                    if (PoSTags[j] == "NNP ")
                                    {
                                        endingIndex = j;
                                    }
                                }
                                addMorphinesTo_array(IndexNo, endingIndex);
                                IndexNo = i;
                                Morphines[MorphinINDEX - 1] += " " + "OPM";
                                break;
                            }
                        }
                    }

                }

                //Other Morphines starts with with mulpiple adv., adj, noun
                else if (PoSTags[IndexNo] == "JJ " || PoSTags[IndexNo] == "JJS " || PoSTags[IndexNo] == "JJR " || PoSTags[IndexNo] == "JJ " || PoSTags[IndexNo] == "RB ")
                {
                    int EndungIndex = IndexNo;
                    //Searching more adverb/adj.
                    for (int j = IndexNo + 1; j < Word.Length; j++)
                    {
                        if (PoSTags[j] == "JJ " || PoSTags[j] == "JJS " || PoSTags[j] == "JJR " || PoSTags[j] == "JJ " || PoSTags[j] == "RB ")
                        {
                            EndungIndex++;
                        }
                    }
                    //if (EndungIndex!= IndexNo) { EndungIndex = EndungIndex + 1; }
                    if ((PoSTags[EndungIndex] == "NN " || PoSTags[EndungIndex] == "NNS ") && (PoSTags[EndungIndex + 1] != "NN " || PoSTags[EndungIndex + 1] != "NNS " || PoSTags[EndungIndex + 1] != "NNP "))
                    {
                        addMorphinesTo_array(IndexNo, EndungIndex);
                        IndexNo = EndungIndex;
                        Morphines[MorphinINDEX - 1] += " " + "OPM";
                    }
                    else if (PoSTags[EndungIndex] == "NNP ")
                    {

                        // Search for More NNP (Proper Noun)
                        for (int j = EndungIndex + 1; j < Word.Length; j++)
                        {
                            if (PoSTags[j] == "NNP ")
                            {
                                EndungIndex = j;
                            }
                        }
                        addMorphinesTo_array(IndexNo, EndungIndex);
                        IndexNo = EndungIndex;
                        Morphines[MorphinINDEX - 1] += " " + "OPM";
                    }
                    else {
                        addMorphinesTo_array(IndexNo, EndungIndex);
                        IndexNo = EndungIndex;
                        Morphines[MorphinINDEX - 1] += " " + "OPM";
                    }
                }
                
                //single morphines
                else
                {
                    addMorphinesTo_array(IndexNo, IndexNo);
                    Morphines[MorphinINDEX - 1] += " " + "OPS"; //Other Morphin Single
                }
            }
            Identifying_Constituents aIdentifying_Constituents = new Identifying_Constituents();
            string TargetSentence = aIdentifying_Constituents.IdentifyConsituents(Word, PoSTags,Morphines, Subject, Subject_tag,verb, verbTag);
            return TargetSentence;
        }        
        private void addMorphinesTo_array(int morf_startIndex,int morf_EndIndex)
        {
            for (int i= morf_startIndex;i<= morf_EndIndex;i++)
            {
                Morphines[MorphinINDEX] += word[i]+" ";
            }
            MorphinINDEX++;
        }
    }
}