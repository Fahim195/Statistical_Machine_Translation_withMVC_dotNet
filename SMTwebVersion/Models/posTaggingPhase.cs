using edu.stanford.nlp.tagger.maxent;
using SMTwebVersion.Models.Approaches.DirectApproach;
using SMTwebVersion.Models.Approaches.StatisticalTranslation;
using SMTwebVersion.Models.Approaches.TransferApprach;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SMTwebVersion.Models
{
    public class posTaggingPhase
    {
        string[] word;
        string[] POStag;
        public string postaggingAND_translation(string SourceLanguage,String ApproachName)
        {
            var jarRoot = @"C:\Users\Fahim\source\repos\SMTwebVersion_v1\SMTwebVersion\packages\stanford-postagger-full-2018-02-27";
            var modelsDirectory = jarRoot + @"\models";

            // Loading POS Tagger
            var tagger = new MaxentTagger(modelsDirectory + @"\english-bidirectional-distsim.tagger");
            // Text for tagging           
            string[] words = SourceLanguage.Split(' ');
            word = new string[words.Length];
            POStag = new string[words.Length];
            string abc = "";
            //string tagged = tagger.tagString(SourceLanguage);
            for (int i = 0; i < words.Length; i++)
            {
                string tagged = tagger.tagString(words[i]);     // Initializing Tag for  word
                string[] word_PosTag_split = tagged.Split('_'); // Splitting Word and POS Tag
                word[i] = word_PosTag_split[0];                 // Assinging word to array
                POStag[i] = word_PosTag_split[1];               // Assinging  POS Tag to array
                abc += POStag[i];
            }
             string sentence="";
            if (ApproachName == "Transfer Approach")
            {
                Analysis_stg aAnalysis_Stg = new Analysis_stg();
                sentence = aAnalysis_Stg.getSubject(word, POStag);
            }
            else if (ApproachName == "Direct Approach")
            {
                Morphological_Analysis aMorphological_Analysis = new Morphological_Analysis();
                sentence = aMorphological_Analysis.StarMorphologicalAnalysis(word, POStag);
            }
            else if (ApproachName == "Statistical Translation")
            {
                ExtractTargetLanguage_Results aExtractTargetLanguage_Results = new ExtractTargetLanguage_Results();
                sentence = aExtractTargetLanguage_Results.getTargetSentences_According_to_Source(SourceLanguage);
            }
            //else if (ApproachName == "Interlingua Approach") { }

            //else if (ApproachName == "Corpus-based Approach") { }           
            return sentence;

        }
    }
}