using edu.stanford.nlp.tagger.maxent;
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
        public string postaggingAND_translation(string SourceLanguage)
        {
            var jarRoot = @"C:\Users\fahim\Desktop\WebApplication4\stanford-postagger-2017-06-09\stanford-postagger-2017-06-09";
            var modelsDirectory = jarRoot + @"\models";

            // Loading POS Tagger
            var tagger = new MaxentTagger(modelsDirectory + @"\english-bidirectional-distsim.tagger");
            // Text for tagging           
            string[] words = SourceLanguage.Split(' ');
            word = new string[words.Length];
            POStag = new string[words.Length];
            string abc = "";
            for (int i = 0; i < words.Length; i++)
            {
                String tagged = tagger.tagString(words[i]); //Initializing Tag for  word
                string[] word_PosTag_split = tagged.Split('_'); // Splitting Word and POS Tag
                word[i] = word_PosTag_split[0];              /// Assinging word to array
                POStag[i] = word_PosTag_split[1];           /// Assinging  POS Tag to array
                abc += POStag[i];
            }
            int a = word.Length;
            Analysis_stg aAnalysis_Stg = new Analysis_stg();
            string sentence = aAnalysis_Stg.getSubject(word, POStag);
            return sentence;

        }
    }
}