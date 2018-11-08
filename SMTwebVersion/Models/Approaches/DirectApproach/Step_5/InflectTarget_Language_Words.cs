using SMTwebVersion.Models.Ambiguity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace SMTwebVersion.Models.Approaches.DirectApproach.Step_5
{
    public class InflectTarget_Language_Words
    {
        string VerbEng = "", VerbMeaning = "", TargetSunbectMeaning, InflectedTargetLanguage = "";
        private int MorfINDEX = 0;
        string[] TargetLanMorphines;
        DataTable meaningDT;
        public string TargetLanguage_REpresentation(string[] Words, string[] PoSTags, string[] ReOrderedMorphines, string Subject, string Subject_tag, string Verb, string VerbTag, DataSet LookupDataSet)
        {
            VerbEng = Verb;
            //Generating Verb Meaning
            try
            {
                VerbMeaning = LookupDataSet.Tables[1].Rows[0][0].ToString();
            }
            catch
            {
                VerbMeaning = VerbEng;
            }
            try
            {
                meaningDT = LookupDataSet.Tables[2];
            }
            catch { }
            //Generating Subject Meaning
            try
            {
                TargetSunbectMeaning = LookupDataSet.Tables[0].Rows[0][0].ToString();
            }
            catch
            {
                TargetSunbectMeaning = Subject;
            }
            AmbiguitySolution aAmbiguitySolution = new AmbiguitySolution();
            TargetLanMorphines = new string[ReOrderedMorphines.Length];
            for (int MorfIndex = 0; MorfIndex < ReOrderedMorphines.Length; MorfIndex++)
            {

                if (ReOrderedMorphines[MorfIndex].Contains("VP"))
                {

                    string verbalSolution = aAmbiguitySolution.RemoveVerbalAmbiguity(Subject, VerbMeaning, VerbTag, 0);
                    MorfINDEX = MorfIndex;
                    InitializingTargetMorphines(verbalSolution);
                }
                else if (ReOrderedMorphines[MorfIndex].Contains("SP"))
                {
                    string SubjectPart = ReOrderedMorphines[MorfIndex].Replace("  SP", "");
                    int Noof_SubjectPart_Mporphenes = SubjectPart.Split(' ').Length;
                    string[] SubjectPart_Mporphenes = SubjectPart.Split(' ');
                    string[] SubjectPart_MporphenesPosTag = Get_Postag_for_Morphins(Words, PoSTags, SubjectPart_Mporphenes);
                    string SubjectPartSolution = aAmbiguitySolution.NounPhrase_Ambiguity_Solution(meaningDT, SubjectPart_Mporphenes, SubjectPart_MporphenesPosTag, null, null, Subject, Verb, Noof_SubjectPart_Mporphenes - 1, Subject);
                    SubjectPartSolution = SubjectPartSolution + " " + TargetSunbectMeaning + " ";
                    if (SubjectPartSolution.Contains("টিটি"))
                    {
                        SubjectPartSolution = SubjectPartSolution.Replace("টিটি ", " ");
                        SubjectPartSolution += "টি ";
                    }
                    if (SubjectPartSolution.Contains("গুলো"))
                    {
                        SubjectPartSolution = SubjectPartSolution.Replace("গুলো ", " ");
                        SubjectPartSolution += "গুলো ";
                    }
                    MorfINDEX = MorfIndex;
                    InitializingTargetMorphines(SubjectPartSolution);
                }
                else if (ReOrderedMorphines[MorfIndex].Contains("case"))
                {
                    string[] PpMorphines = ReOrderedMorphines[MorfIndex].Split(' ');
                    int prepositionalMorphinLength = ReOrderedMorphines[MorfIndex].Split(' ').Length;
                    string pCase = PpMorphines[prepositionalMorphinLength - 1];
                    string PPmorphineWithout_Case = ReOrderedMorphines[MorfIndex].Replace("  " + pCase, "");
                    PpMorphines = PPmorphineWithout_Case.Split(' ');
                    int Noof_PP_Part_Mporphenes = PPmorphineWithout_Case.Split(' ').Length;
                    string[] PrepositionPart_MporphenesPosTag = Get_Postag_for_Morphins(Words, PoSTags, PpMorphines);
                    string PrepositionPartSolution = aAmbiguitySolution.removePrepositionalAmbiguity(meaningDT, PpMorphines, PrepositionPart_MporphenesPosTag, null, null, Subject, Verb, Noof_PP_Part_Mporphenes, -1, pCase) + " ";
                    MorfINDEX = MorfIndex;
                    if (PrepositionPartSolution.Contains(TargetLanMorphines[MorfINDEX - 1])) { PrepositionPartSolution = PrepositionPartSolution.Replace(TargetLanMorphines[MorfINDEX - 1], ""); }
                    InitializingTargetMorphines(PrepositionPartSolution);
                }
                else if (ReOrderedMorphines[MorfIndex].Contains("OPM"))
                {
                    string Multiple_Object_Part = ReOrderedMorphines[MorfIndex].Replace("  OPM", "");
                    //int Multiple_Object_PartMorphinLength = ReOrderedMorphines[MorfIndex].Length;
                    string[] MultipleObject_Morphines = Multiple_Object_Part.Split(' ');
                    string Multiple_Object_PartSolution = Multiple_or_single_Morphine_MeaningGeneration(MultipleObject_Morphines, meaningDT);
                    MorfINDEX = MorfIndex;
                    InitializingTargetMorphines(Multiple_Object_PartSolution);
                }
                else if (ReOrderedMorphines[MorfIndex].Contains("OPS"))
                {
                    string Single_Object_Part = ReOrderedMorphines[MorfIndex].Replace("  OPS", "");
                    string[] SingleObject_Morphines = { Single_Object_Part };
                    string Single_Object_PartSolution = Multiple_or_single_Morphine_MeaningGeneration(SingleObject_Morphines, meaningDT);
                    MorfINDEX = MorfIndex;
                    InitializingTargetMorphines(Single_Object_PartSolution);
                }
            }
            TagetLanguage_MorphinRepresentation();
            return InflectedTargetLanguage;
        }
        private void TagetLanguage_MorphinRepresentation()
        {
            for (int i = 0; i < TargetLanMorphines.Length; i++)
            {
                InflectedTargetLanguage += TargetLanMorphines[i];
            }

        }
        private void InitializingTargetMorphines(string MorphineTag)
        {
            TargetLanMorphines[MorfINDEX] = MorphineTag;
        }
        private string[] Get_Postag_for_Morphins(string[] Words, string[] PosTags, string[] Morphine)
        {
            string[] Morphon_postag = new string[Morphine.Length];
            int j = 0;
            for (int i = 0; i < Morphine.Length; i++)
            {
                for (int wordIndex = 0; wordIndex < Words.Length; wordIndex++)
                {
                    if (Morphine[i] == Words[wordIndex])
                    {
                        Morphon_postag[i] = PosTags[wordIndex];
                    }
                }
            }

            return Morphon_postag;
        }
        private string Multiple_or_single_Morphine_MeaningGeneration(string[] Multiple_or_single_Morphines, DataTable MeaningNDT)
        {
            int no_of_objects = MeaningNDT.Rows.Count;
            string Multiple_or_single_Morphine_Meaning = "";
            for (int WrdIndexIn_morphine = 0; WrdIndexIn_morphine < Multiple_or_single_Morphines.Length; WrdIndexIn_morphine++)
            {
                string meaning = "";
                if (no_of_objects == 0)
                {
                    for (int indeX = 0; indeX <= no_of_objects; indeX++)
                    {
                        try
                        {
                            if (Multiple_or_single_Morphines[WrdIndexIn_morphine].ToLower() == MeaningNDT.Rows[indeX][0].ToString().ToLower())
                            {
                                meaning = MeaningNDT.Rows[indeX][1].ToString();

                            }
                        }
                        catch { meaning = Multiple_or_single_Morphines[WrdIndexIn_morphine]; }
                        if (meaning == "")
                        {
                            meaning = Multiple_or_single_Morphines[WrdIndexIn_morphine];
                        }
                    }
                }
                else
                {
                    for (int indeX = 0; indeX < no_of_objects; indeX++)
                    {
                        if (Multiple_or_single_Morphines[WrdIndexIn_morphine].ToLower() == MeaningNDT.Rows[indeX][0].ToString().ToLower())
                        {
                            meaning = MeaningNDT.Rows[indeX][1].ToString();

                        }
                        if (meaning == "")
                        {
                            meaning = Multiple_or_single_Morphines[WrdIndexIn_morphine];
                        }
                    }

                    if (Multiple_or_single_Morphine_Meaning.Contains("টি"))
                    {
                        Multiple_or_single_Morphine_Meaning = Multiple_or_single_Morphine_Meaning.Replace("টি", " ");
                        Multiple_or_single_Morphine_Meaning = meaning + " টি ";
                    }
                    else { Multiple_or_single_Morphine_Meaning += " " + meaning + " "; }
                    
                }
                
            }
            return Multiple_or_single_Morphine_Meaning;
        }
    }
}
