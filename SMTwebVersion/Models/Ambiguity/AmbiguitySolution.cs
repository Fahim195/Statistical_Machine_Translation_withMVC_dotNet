using SMTwebVersion.Models.Approaches.TransferApprach;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace SMTwebVersion.Models.Ambiguity
{
    public class AmbiguitySolution
    {
        private string verb, verb_tag, verbalAmbiguity_Solution, pronounMeaning, nounMeaning, prepositionlaAmbiguitySolution;
        private string vRoot = "", solution = "",/* Case = "",*/ verbMeaning, monthSeasonMeaming, dayMeaning;
        private int PStructure_end = 0, PStructure_start = 0;
        public string RemoveAmbiguity(string subject, string initialVerb, string v_tag)
        {
            verb = initialVerb;
            verb_tag = v_tag;
            verbalAmbiguity_Solution = removeVerbalAmguity(subject);
            IdentifyV_root(verb);
            solution = verb.Replace(vRoot, verbalAmbiguity_Solution);
            if (solution != vRoot)
            {
                return solution;
            }
            else
            {
                return verbalAmbiguity_Solution;
            }
        }
        private string removeVerbalAmguity(string subject)
        {
            string result = "";
            if (subject == "I" || subject == "We")
            {
                if (verb.Contains("আনা") || verb == "আনা")
                {
                    switch (verb_tag)
                    {
                        case "P_in":
                            result = "আনি";
                            break;
                        case "P_con":
                            result = "আনছি";
                            break;
                        case "P_per":
                            result = "এনেছিলাম";
                            break;
                        case "P_per_con":
                            result = "আনছি";
                            break;
                        case "Pa_in":
                            result = "আনছিলাম";
                            break;
                        case "Pa_con":
                            result = "এনেছিলাম";
                            break;
                        case "Pa_per":
                            result = "এনেছি";
                            break;
                        case "Pa_per_con":
                            result = "আনছিলাম";
                            break;
                        case "F_in":
                            result = "আনবো";
                            break;
                        case "F_con":
                            result = "আনতে থাকবো";
                            break;
                        case "F_per":
                            result = "আনবো";
                            break;
                        case "F_per_con":
                            result = "আনতে থাকবো";
                            break;
                        default: break;
                    }
                }
                else if (verb.Contains("আঁকা") || verb == "আঁকা")
                {
                    switch (verb_tag)
                    {
                        case "P_in":
                            result = "আঁকি";
                            break;
                        case "P_con":
                            result = "আঁকছি";
                            break;
                        case "P_per":
                            result = "এঁকেছি";
                            break;
                        case "P_per_con":
                            result = "আঁকছি";
                            break;
                        case "Pa_in":
                            result = "এঁকেছিলাম";
                            break;
                        case "Pa_con":
                            result = "আঁকছিলাম";
                            break;
                        case "Pa_per":
                            result = "এঁকেছিলাম";
                            break;
                        case "Pa_per_con":
                            result = "আঁকছিলাম";
                            break;
                        case "F_in":
                            result = "আঁকবো";
                            break;
                        case "F_con":
                            result = "আঁকতে থাকবো";
                            break;
                        case "F_per":
                            result = "আঁকবো";
                            break;
                        case "F_per_con":
                            result = "আঁকতে থাকবো";
                            break;
                        default: break;
                    }
                }
                else if (verb.Contains("বাঁধা") || verb == "বাঁধা")
                {
                    switch (verb_tag)
                    {
                        case "P_in":
                            result = "বাঁধি";
                            break;
                        case "P_con":
                            result = "বাঁধছি";
                            break;
                        case "P_per":
                            result = "বেঁধেছি";
                            break;
                        case "P_per_con":
                            result = "বাঁধছি";
                            break;
                        case "Pa_in":
                            result = "বেঁধেছিলাম";
                            break;
                        case "Pa_con":
                            result = "বাঁধছিলাম";
                            break;
                        case "Pa_per":
                            result = "বেঁধেছিলাম";
                            break;
                        case "Pa_per_con":
                            result = "বাঁধছিলাম";
                            break;
                        case "F_in":
                            result = "বাধবো";
                            break;
                        case "F_con":
                            result = "বাঁধতে থাকবো";
                            break;
                        case "F_per":
                            result = "বাধবো";
                            break;
                        case "F_per_con":
                            result = "বাঁধতে থাকবো";
                            break;
                        default: break;
                    }
                }
                else if (verb.Contains("বসা") || verb == "বসা")
                {
                    switch (verb_tag)
                    {
                        case "P_in":
                            result = "বসি";
                            break;
                        case "P_con":
                            result = "বসছি";
                            break;
                        case "P_per":
                            result = "বসেছি";
                            break;
                        case "P_per_con":
                            result = "বসছি";
                            break;
                        case "Pa_in":
                            result = "বসেছিলাম";
                            break;
                        case "Pa_con":
                            result = "বসছিলাম";
                            break;
                        case "Pa_per":
                            result = "বসছিলাম";
                            break;
                        case "Pa_per_con":
                            result = "বসছিলাম";
                            break;
                        case "F_in":
                            result = "বসবো";
                            break;
                        case "F_con":
                            result = "বসতে থাকবো";
                            break;
                        case "F_per":
                            result = "বসবো";
                            break;
                        case "F_per_con":
                            result = "বসতে থাকবো";
                            break;
                        default: break;
                    }
                }
                else if (verb.Contains("বসান") || verb == "বসান")
                {
                    switch (verb_tag)
                    {
                        case "P_in":
                            result = "বসাই";
                            break;
                        case "P_con":
                            result = "বসাচ্ছি";
                            break;
                        case "P_per":
                            result = "বসিয়েছি";
                            break;
                        case "P_per_con":
                            result = "বসাচ্ছি";
                            break;
                        case "Pa_in":
                            result = "বসিয়েছিলাম";
                            break;
                        case "Pa_con":
                            result = "বসাচ্ছিলাম ";
                            break;
                        case "Pa_per":
                            result = "বসিয়েছিলাম";
                            break;
                        case "Pa_per_con":
                            result = "বসাচ্ছিলাম";
                            break;
                        case "F_in":
                            result = "বসাবো";
                            break;
                        case "F_con":
                            result = "বসাতে থাকবো";
                            break;
                        case "F_per":
                            result = "বসাবো";
                            break;
                        case "F_per_con":
                            result = "বসাতে থাকবো";
                            break;
                        default: break;
                    }
                }
                else if (verb.Contains("বলা") || verb == "বলা")
                {
                    switch (verb_tag)
                    {
                        case "P_in":
                            result = "বলি";
                            break;
                        case "P_con":
                            result = "বলছি";
                            break;
                        case "P_per":
                            result = "বলেছি";
                            break;
                        case "P_per_con":
                            result = "বলছি";
                            break;
                        case "Pa_in":
                            result = "বলেছিলাম";
                            break;
                        case "Pa_con":
                            result = "বলছিলাম";
                            break;
                        case "Pa_per":
                            result = "বলেছিলাম";
                            break;
                        case "Pa_per_con":
                            result = "বলছিলাম";
                            break;
                        case "F_in":
                            result = "বলবো";
                            break;
                        case "F_con":
                            result = "বলতে থাকবো";
                            break;
                        case "F_per":
                            result = "বলবো";
                            break;
                        case "F_per_con":
                            result = "বলতে থাকবো";
                            break;
                        default: break;
                    }
                }
                else if (verb.Contains("বানান") || verb == "বানান")
                {
                    switch (verb_tag)
                    {
                        case "P_in":
                            result = "বানাই ";
                            break;
                        case "P_con":
                            result = "বানাচ্ছি ";
                            break;
                        case "P_per":
                            result = "বানিয়েছি ";
                            break;
                        case "P_per_con":
                            result = "বানাচ্ছি ";
                            break;
                        case "Pa_in":
                            result = "বানিয়েছিলাম";
                            break;
                        case "Pa_con":
                            result = "বানাচ্ছিলাম";
                            break;
                        case "Pa_per":
                            result = "বানিয়েছিলাম";
                            break;
                        case "Pa_per_con":
                            result = "বানাচ্ছিলাম";
                            break;
                        case "F_in":
                            result = "বানাবো";
                            break;
                        case "F_con":
                            result = "বানাতে থাকবো";
                            break;
                        case "F_per":
                            result = "বানাবো";
                            break;
                        case "F_per_con":
                            result = "বানাতে থাকবো";
                            break;
                        default: break;
                    }
                }
                else if (verb.Contains("বাড়ান") || verb == "বাড়ান")
                {
                    switch (verb_tag)
                    {
                        case "P_in":
                            result = "বাড়াই ";
                            break;
                        case "P_con":
                            result = "বাড়াচ্ছি";
                            break;
                        case "P_per":
                            result = "বাড়িয়েছি";
                            break;
                        case "P_per_con":
                            result = "বাড়াচ্ছি";
                            break;
                        case "Pa_in":
                            result = "বাড়িয়েছিলাম";
                            break;
                        case "Pa_con":
                            result = "বাড়াচ্ছিলাম";
                            break;
                        case "Pa_per":
                            result = "বাড়িয়েছিলাম";
                            break;
                        case "Pa_per_con":
                            result = "বাড়াচ্ছিলাম";
                            break;
                        case "F_in":
                            result = "বাড়াবো";
                            break;
                        case "F_con":
                            result = "বাড়াতে থাকবো";
                            break;
                        case "F_per":
                            result = "বাড়াবো";
                            break;
                        case "F_per_con":
                            result = "বাড়াতে থাকবো";
                            break;
                        default: break;
                    }
                }
                else if (verb.Contains("বোঝানো") || verb == "বোঝানো")
                {
                    switch (verb_tag)
                    {
                        case "P_in":
                            result = "বুঝাই";
                            break;
                        case "P_con":
                            result = "বুঝাচ্ছি";
                            break;
                        case "P_per":
                            result = "বুঝিয়েছি";
                            break;
                        case "P_per_con":
                            result = "বুঝাচ্ছি";
                            break;
                        case "Pa_in":
                            result = "বুঝিয়েছিলাম";
                            break;
                        case "Pa_con":
                            result = "বুঝাচ্ছিলাম";
                            break;
                        case "Pa_per":
                            result = "বুঝিয়েছিলাম";
                            break;
                        case "Pa_per_con":
                            result = "বুঝাচ্ছিলাম";
                            break;
                        case "F_in":
                            result = "বুঝাবো";
                            break;
                        case "F_con":
                            result = "বোঝাতে থাকবো";
                            break;
                        case "F_per":
                            result = "বুঝাবো";
                            break;
                        case "F_per_con":
                            result = "বোঝাতে থাকবো";
                            break;
                        default: break;
                    }
                }
                else if (verb.Contains("বাজান") || verb == "বাজান")
                {
                    switch (verb_tag)
                    {
                        case "P_in":
                            result = "বাজাই";
                            break;
                        case "P_con":
                            result = "বাজাচ্ছি";
                            break;
                        case "P_per":
                            result = "বাজিয়েছি";
                            break;
                        case "P_per_con":
                            result = "বাজাচ্ছি";
                            break;
                        case "Pa_in":
                            result = "বাজাবো";
                            break;
                        case "Pa_con":
                            result = "বাজাচ্ছিলাম";
                            break;
                        case "Pa_per":
                            result = "বাজাবো";
                            break;
                        case "Pa_per_con":
                            result = "বাজাচ্ছিলাম";
                            break;
                        case "F_in":
                            result = "বাজাবো";
                            break;
                        case "F_con":
                            result = "বাজাতে থাকবো";
                            break;
                        case "F_per":
                            result = "বাজাবো";
                            break;
                        case "F_per_con":
                            result = "বাজাতে থাকবো";
                            break;
                        default: break;
                    }
                }
                else if (verb.Contains("চাওয়া") || verb == "চাওয়া")
                {
                    switch (verb_tag)
                    {
                        case "P_in":
                            result = "চাই";
                            break;
                        case "P_con":
                            result = "চাচ্ছি";
                            break;
                        case "P_per":
                            result = "চেয়েছি";
                            break;
                        case "P_per_con":
                            result = "চাচ্ছি";
                            break;
                        case "Pa_in":
                            result = "চেয়েছিলাম";
                            break;
                        case "Pa_con":
                            result = "চাচ্ছিলাম";
                            break;
                        case "Pa_per":
                            result = "চেয়েছিলাম";
                            break;
                        case "Pa_per_con":
                            result = "চাচ্ছিলাম";
                            break;
                        case "F_in":
                            result = "চাইবো";
                            break;
                        case "F_con":
                            result = "চাইতে থাকবো";
                            break;
                        case "F_per":
                            result = "চাইবো";
                            break;
                        case "F_per_con":
                            result = "চাইতে থাকবো";
                            break;
                        default: break;
                    }
                }
                else if (verb.Contains("চাটা") || verb == "চাটা")
                {
                    switch (verb_tag)
                    {
                        case "P_in":
                            result = "চাটি";
                            break;
                        case "P_con":
                            result = "চাটছি";
                            break;
                        case "P_per":
                            result = "চেটেছি";
                            break;
                        case "P_per_con":
                            result = "চাটছি";
                            break;
                        case "Pa_in":
                            result = "চেঁটেছিলাম";
                            break;
                        case "Pa_con":
                            result = "চাটছিলাম";
                            break;
                        case "Pa_per":
                            result = "চেঁটেছিলাম";
                            break;
                        case "Pa_per_con":
                            result = "চাটছিলাম";
                            break;
                        case "F_in":
                            result = "চাটবো";
                            break;
                        case "F_con":
                            result = "চাটতে থাকবো";
                            break;
                        case "F_per":
                            result = "চাটবো";
                            break;
                        case "F_per_con":
                            result = "চাটতে থাকবো";
                            break;
                        default: break;
                    }
                }
                else if (verb.Contains("ছড়ান") || verb == "ছড়ান")
                {
                    switch (verb_tag)
                    {
                        case "P_in":
                            result = "ছড়াই";
                            break;
                        case "P_con":
                            result = "ছড়াচ্ছি";
                            break;
                        case "P_per":
                            result = "ছড়িয়েছি";
                            break;
                        case "P_per_con":
                            result = "ছড়াচ্ছি";
                            break;
                        case "Pa_in":
                            result = "ছড়িয়েছিলাম";
                            break;
                        case "Pa_con":
                            result = "ছড়াচ্ছিলাম";
                            break;
                        case "Pa_per":
                            result = "ছড়িয়েছিলাম";
                            break;
                        case "Pa_per_con":
                            result = "ছড়াচ্ছিলাম";
                            break;
                        case "F_in":
                            result = "ছড়াবো";
                            break;
                        case "F_con":
                            result = "ছড়াতে থাকবো";
                            break;
                        case "F_per":
                            result = "ছড়াবো";
                            break;
                        case "F_per_con":
                            result = "ছড়াতে থাকবো";
                            break;
                        default: break;
                    }
                }
                else if (verb.Contains("চেনা") || verb == "চেনা")
                {
                    switch (verb_tag)
                    {
                        case "P_in":
                            result = "চিনি";
                            break;
                        case "P_con":
                            result = "চিনছি";
                            break;
                        case "P_per":
                            result = "চিনেছি";
                            break;
                        case "P_per_con":
                            result = "চিনছি";
                            break;
                        case "Pa_in":
                            result = "চিনেছিলাম";
                            break;
                        case "Pa_con":
                            result = "চিনতেছিলাম";
                            break;
                        case "Pa_per":
                            result = "চিনেছিলাম";
                            break;
                        case "Pa_per_con":
                            result = "চিনতেছিলাম";
                            break;
                        case "F_in":
                            result = "চিনবো";
                            break;
                        case "F_con":
                            result = "চিনতে থাকবো";
                            break;
                        case "F_per":
                            result = "চিনবো";
                            break;
                        case "F_per_con":
                            result = "চিনতে থাকবো";
                            break;
                        default: break;
                    }
                }
                else if (verb.Contains("চিবান") || verb == "চিবান")
                {
                    switch (verb_tag)
                    {
                        case "P_in":
                            result = "চিবাই";
                            break;
                        case "P_con":
                            result = "চিবাচ্ছি";
                            break;
                        case "P_per":
                            result = "চিবিয়েছি";
                            break;
                        case "P_per_con":
                            result = "চিবাচ্ছি";
                            break;
                        case "Pa_in":
                            result = "চিবিয়েছিলাম";
                            break;
                        case "Pa_con":
                            result = "চিবাচ্ছিলাম";
                            break;
                        case "Pa_per":
                            result = "চিবিয়েছিলাম";
                            break;
                        case "Pa_per_con":
                            result = "চিবাচ্ছিলাম";
                            break;
                        case "F_in":
                            result = "চিবাবো";
                            break;
                        case "F_con":
                            result = "চিবাতে থাকবো";
                            break;
                        case "F_per":
                            result = "চিবাবো";
                            break;
                        case "F_per_con":
                            result = "চিবাতে থাকবো";
                            break;
                        default: break;
                    }
                }
                else if (verb.Contains("চালান") || verb == "চালান")
                {
                    switch (verb_tag)
                    {
                        case "P_in":
                            result = "চালাই";
                            break;
                        case "P_con":
                            result = "চালাচ্ছি";
                            break;
                        case "P_per":
                            result = "চালিয়েছি";
                            break;
                        case "P_per_con":
                            result = "চালাচ্ছি";
                            break;
                        case "Pa_in":
                            result = "চালিয়েছিলাম";
                            break;
                        case "Pa_con":
                            result = "চালাচ্ছিলাম";
                            break;
                        case "Pa_per":
                            result = "চালিয়েছিলাম";
                            break;
                        case "Pa_per_con":
                            result = "চালাচ্ছিলাম";
                            break;
                        case "F_in":
                            result = "চালাবো";
                            break;
                        case "F_con":
                            result = "চালাতে থাকবো";
                            break;
                        case "F_per":
                            result = "চালাবো";
                            break;
                        case "F_per_con":
                            result = "চালাতে থাকবো";
                            break;
                        default: break;
                    }
                }
                else if (verb.Contains("দেয়া") || verb == "দেয়া")
                {
                    switch (verb_tag)
                    {
                        case "P_in":
                            result = "দেই";
                            break;
                        case "P_con":
                            result = "দিচ্ছি";
                            break;
                        case "P_per":
                            result = "দিয়েছি";
                            break;
                        case "P_per_con":
                            result = "দিয়েছি";
                            break;
                        case "Pa_in":
                            result = "দিয়েছিলাম";
                            break;
                        case "Pa_con":
                            result = "দিচ্ছিলাম";
                            break;
                        case "Pa_per":
                            result = "দিয়েছিলাম";
                            break;
                        case "Pa_per_con":
                            result = "দিচ্ছিলাম";
                            break;
                        case "F_in":
                            result = "দিবো";
                            break;
                        case "F_con":
                            result = "দিতে থাকবো";
                            break;
                        case "F_per":
                            result = "দিবো";
                            break;
                        case "F_per_con":
                            result = "দিতে থাকবো";
                            break;
                        default: break;
                    }
                }
                else if (verb.Contains("দেখা") || verb == "দেখা")
                {
                    switch (verb_tag)
                    {
                        case "P_in":
                            result = "দেখি";
                            break;
                        case "P_con":
                            result = "দেখছি";
                            break;
                        case "P_per":
                            result = "দেখেছি";
                            break;
                        case "P_per_con":
                            result = "দেখছি";
                            break;
                        case "Pa_in":
                            result = "দেখেছিলাম";
                            break;
                        case "Pa_con":
                            result = "দেখছিলাম";
                            break;
                        case "Pa_per":
                            result = "দেখেছিলাম";
                            break;
                        case "Pa_per_con":
                            result = "দেখছিলাম";
                            break;
                        case "F_in":
                            result = "দেখবো";
                            break;
                        case "F_con":
                            result = "দেখতে থাকবো";
                            break;
                        case "F_per":
                            result = "দেখবো";
                            break;
                        case "F_per_con":
                            result = "দেখতে থাকবো";
                            break;
                        default: break;
                    }
                }
                else if (verb.Contains("দাঁড়ান") || verb == "দাঁড়ান")
                {
                    switch (verb_tag)
                    {
                        case "P_in":
                            result = "দাঁড়াই";
                            break;
                        case "P_con":
                            result = "দাঁড়াচ্ছি";
                            break;
                        case "P_per":
                            result = "দাঁড়িয়েছি";
                            break;
                        case "P_per_con":
                            result = "দাঁড়াচ্ছি";
                            break;
                        case "Pa_in":
                            result = "দাঁড়িয়েছিলাম";
                            break;
                        case "Pa_con":
                            result = "দাঁড়াইতেছিলাম";
                            break;
                        case "Pa_per":
                            result = "দাঁড়িয়েছিলাম";
                            break;
                        case "Pa_per_con":
                            result = "দাঁড়াইতেছিলাম";
                            break;
                        case "F_in":
                            result = "দাঁড়াব";
                            break;
                        case "F_con":
                            result = "দাঁড়িয়ে থাকব";
                            break;
                        case "F_per":
                            result = "দাঁড়াব";
                            break;
                        case "F_per_con":
                            result = "দাঁড়িয়ে থাকব";
                            break;
                        default: break;
                    }
                }
                else if (verb.Contains("দেখানো") || verb == "দেখানো")
                {
                    switch (verb_tag)
                    {
                        case "P_in":
                            result = "দেখাই";
                            break;
                        case "P_con":
                            result = "দেখাচ্ছি";
                            break;
                        case "P_per":
                            result = "দেখিয়েছি";
                            break;
                        case "P_per_con":
                            result = "দেখাচ্ছি";
                            break;
                        case "Pa_in":
                            result = "দেখিয়েছিলাম";
                            break;
                        case "Pa_con":
                            result = "দেখাইতেছিলাম";
                            break;
                        case "Pa_per":
                            result = "দেখিয়েছিলাম";
                            break;
                        case "Pa_per_con":
                            result = "দেখাইতেছিলাম";
                            break;
                        case "F_in":
                            result = "দেখাবো";
                            break;
                        case "F_con":
                            result = "দেখাইতে থাকব";
                            break;
                        case "F_per":
                            result = "দেখাবো";
                            break;
                        case "F_per_con":
                            result = "দেখাইতে থাকব";
                            break;
                        default: break;
                    }
                }
                else if (verb.Contains("ঢাকা") || verb == "ঢাকা")
                {
                    switch (verb_tag)
                    {
                        case "P_in":
                            result = "ঢাকি";
                            break;
                        case "P_con":
                            result = "ঢাকছি";
                            break;
                        case "P_per":
                            result = "ঢেকেছি";
                            break;
                        case "P_per_con":
                            result = "ঢাকছি";
                            break;
                        case "Pa_in":
                            result = "ঢেকেছিলাম";
                            break;
                        case "Pa_con":
                            result = "ঢাকছিলাম";
                            break;
                        case "Pa_per":
                            result = "ঢেকেছিলাম";
                            break;
                        case "Pa_per_con":
                            result = "ঢাকছিলাম";
                            break;
                        case "F_in":
                            result = "ঢাকবো";
                            break;
                        case "F_con":
                            result = "ঢাকতে থাকবো";
                            break;
                        case "F_per":
                            result = "ঢাকবো";
                            break;
                        case "F_per_con":
                            result = "ঢাকতে থাকবো";
                            break;
                        default: break;
                    }
                }
                else if (verb.Contains("ডাকা") || verb == "ডাকা")
                {
                    switch (verb_tag)
                    {
                        case "P_in":
                            result = "ডাকি";
                            break;
                        case "P_con":
                            result = "ডাকছি";
                            break;
                        case "P_per":
                            result = "ডেকেছি";
                            break;
                        case "P_per_con":
                            result = "ডাকছি";
                            break;
                        case "Pa_in":
                            result = "ডেকেছিলাম";
                            break;
                        case "Pa_con":
                            result = "ডাকছিলাম";
                            break;
                        case "Pa_per":
                            result = "ডেকেছিলাম";
                            break;
                        case "Pa_per_con":
                            result = "ডাকছিলাম";
                            break;
                        case "F_in":
                            result = "ডাকবো";
                            break;
                        case "F_con":
                            result = "ডাকতে থাকব";
                            break;
                        case "F_per":
                            result = "ডাকবো";
                            break;
                        case "F_per_con":
                            result = "ডাকতে থাকব";
                            break;
                        default: break;
                    }
                }
                else if (verb.Contains("ধরা") || verb == "ধরা")
                {
                    switch (verb_tag)
                    {
                        case "P_in":
                            result = "ধরি";
                            break;
                        case "P_con":
                            result = "ধরছি";
                            break;
                        case "P_per":
                            result = "ধরেছি";
                            break;
                        case "P_per_con":
                            result = "ধরেছি";
                            break;
                        case "Pa_in":
                            result = "ধরেছিলাম";
                            break;
                        case "Pa_con":
                            result = "ধরতেছিলাম";
                            break;
                        case "Pa_per":
                            result = "ধরেছিলাম";
                            break;
                        case "Pa_per_con":
                            result = "ধরতেছিলাম";
                            break;
                        case "F_in":
                            result = "ধরব";
                            break;
                        case "F_con":
                            result = "ধরতে থাকব";
                            break;
                        case "F_per":
                            result = "ধরব";
                            break;
                        case "F_per_con":
                            result = "ধরতে থাকব";
                            break;
                        default: break;
                    }
                }
                else if (verb.Contains("ডিঙ্গান") || verb == "ডিঙ্গান")
                {
                    switch (verb_tag)
                    {
                        case "P_in":
                            result = "ডিঙ্গাই";
                            break;
                        case "P_con":
                            result = "ডিঙ্গাচ্ছি";
                            break;
                        case "P_per":
                            result = "ডিঙ্গেয়েছি";
                            break;
                        case "P_per_con":
                            result = "ডিঙ্গাচ্ছি";
                            break;
                        case "Pa_in":
                            result = "ডিঙ্গিয়েছিলাম";
                            break;
                        case "Pa_con":
                            result = "ডিঙ্গাচ্ছিলাম";
                            break;
                        case "Pa_per":
                            result = "ডিঙ্গিয়েছিলাম";
                            break;
                        case "Pa_per_con":
                            result = "ডিঙ্গাচ্ছিলাম";
                            break;
                        case "F_in":
                            result = "ডিঙ্গাবো";
                            break;
                        case "F_con":
                            result = "ডিঙ্গাইতে থাকব";
                            break;
                        case "F_per":
                            result = "ডিঙ্গাবো";
                            break;
                        case "F_per_con":
                            result = "ডিঙ্গাইতে থাকব";
                            break;
                        default: break;
                    }
                }
                else if (verb.Contains("ঢোকান") || verb == "ঢোকান")
                {
                    switch (verb_tag)
                    {
                        case "P_in":
                            result = "ঢোকাই";
                            break;
                        case "P_con":
                            result = "ঢুকাচ্ছি";
                            break;
                        case "P_per":
                            result = "ঢুকিয়েছি";
                            break;
                        case "P_per_con":
                            result = "ঢুকাচ্ছি";
                            break;
                        case "Pa_in":
                            result = "ঢুকিয়েছিলাম";
                            break;
                        case "Pa_con":
                            result = "ঢুকাচ্ছিলাম";
                            break;
                        case "Pa_per":
                            result = "ঢুকিয়েছিলাম";
                            break;
                        case "Pa_per_con":
                            result = "ঢুকাচ্ছিলাম";
                            break;
                        case "F_in":
                            result = "ঢুকাবো";
                            break;
                        case "F_con":
                            result = "ঢুকাইতে থাকব";
                            break;
                        case "F_per":
                            result = "ঢুকাবো";
                            break;
                        case "F_per_con":
                            result = "ঢুকাইতে থাকব";
                            break;
                        default: break;
                    }
                }
                else if (verb.Contains("ফেরা") || verb == "ফেরা")
                {
                    switch (verb_tag)
                    {
                        case "P_in":
                            result = "ফিরি";
                            break;
                        case "P_con":
                            result = "ফিরছি";
                            break;
                        case "P_per":
                            result = "ফিরেছি";
                            break;
                        case "P_per_con":
                            result = "ফিরছি";
                            break;
                        case "Pa_in":
                            result = "ফিরেছিলাম";
                            break;
                        case "Pa_con":
                            result = "ফিরছিলাম";
                            break;
                        case "Pa_per":
                            result = "ফিরেছিলাম";
                            break;
                        case "Pa_per_con":
                            result = "ফিরছিলাম";
                            break;
                        case "F_in":
                            result = "ফিরব";
                            break;
                        case "F_con":
                            result = "ফিরতে থাকব";
                            break;
                        case "F_per":
                            result = "ফিরব";
                            break;
                        case "F_per_con":
                            result = "ফিরতে থাকব";
                            break;
                        default: break;
                    }
                }
                else if (verb.Contains("ফেলা") || verb == "ফেলা")
                {
                    switch (verb_tag)
                    {
                        case "P_in":
                            result = "ফেলি";
                            break;
                        case "P_con":
                            result = "ফেলছি";
                            break;
                        case "P_per":
                            result = "ফেলেছি";
                            break;
                        case "P_per_con":
                            result = "ফেলছি";
                            break;
                        case "Pa_in":
                            result = "ফেলেছিলাম";
                            break;
                        case "Pa_con":
                            result = "ফেলাইতেছিলাম";
                            break;
                        case "Pa_per":
                            result = "ফেলেছিলাম";
                            break;
                        case "Pa_per_con":
                            result = "ফেলাইতেছিলাম";
                            break;
                        case "F_in":
                            result = "ফেলবো";
                            break;
                        case "F_con":
                            result = "ফেলতে থাকব";
                            break;
                        case "F_per":
                            result = "ফেলবো";
                            break;
                        case "F_per_con":
                            result = "ফেলতে থাকব";
                            break;
                        default: break;
                    }
                }
                else if (verb.Contains("ফুটান") || verb == "ফুটান")
                {
                    switch (verb_tag)
                    {
                        case "P_in":
                            result = "ফুটাই";
                            break;
                        case "P_con":
                            result = "ফুটাচ্ছি";
                            break;
                        case "P_per":
                            result = "ফুটিয়েছি";
                            break;
                        case "P_per_con":
                            result = "ফুটাচ্ছি";
                            break;
                        case "Pa_in":
                            result = "ফুটিয়েছিলাম";
                            break;
                        case "Pa_con":
                            result = "ফুটাচ্ছিলাম";
                            break;
                        case "Pa_per":
                            result = "ফুটিয়েছিলাম";
                            break;
                        case "Pa_per_con":
                            result = "ফুটাচ্ছিলাম";
                            break;
                        case "F_in":
                            result = "ফুটাব";
                            break;
                        case "F_con":
                            result = "ফুটাইতে থাকব";
                            break;
                        case "F_per":
                            result = "ফুটাব";
                            break;
                        case "F_per_con":
                            result = "ফুটাইতে থাকব";
                            break;
                        default: break;
                    }
                }
                else if (verb.Contains("ঘটা") || verb == "ঘটা")
                {
                    switch (verb_tag)
                    {
                        case "P_in":
                            result = "ঘটাই";
                            break;
                        case "P_con":
                            result = "ঘটাচ্ছি";
                            break;
                        case "P_per":
                            result = "ঘটিয়েছি";
                            break;
                        case "P_per_con":
                            result = "ঘটাচ্ছি";
                            break;
                        case "Pa_in":
                            result = "ঘটিয়েছিলাম";
                            break;
                        case "Pa_con":
                            result = "ঘটাচ্ছিলাম";
                            break;
                        case "Pa_per":
                            result = "ঘটিয়েছিলাম";
                            break;
                        case "Pa_per_con":
                            result = "ঘটাচ্ছিলাম";
                            break;
                        case "F_in":
                            result = "ঘটাব";
                            break;
                        case "F_con":
                            result = "ঘটাইতে থাকব";
                            break;
                        case "F_per":
                            result = "ঘটাব";
                            break;
                        case "F_per_con":
                            result = "ঘটাইতে থাকব";
                            break;
                        default: break;
                    }
                }
                else if (verb.Contains("ঘুমান") || verb == "ঘুমান")
                {
                    switch (verb_tag)
                    {
                        case "P_in":
                            result = "ঘুমাই";
                            break;
                        case "P_con":
                            result = "ঘুমাচ্ছি";
                            break;
                        case "P_per":
                            result = "ঘুমিয়েছি";
                            break;
                        case "P_per_con":
                            result = "ঘুমাচ্ছি";
                            break;
                        case "Pa_in":
                            result = "ঘুমিয়েছিলাম";
                            break;
                        case "Pa_con":
                            result = "ঘুমাচ্ছিলাম";
                            break;
                        case "Pa_per":
                            result = "ঘুমিয়েছিলাম";
                            break;
                        case "Pa_per_con":
                            result = "ঘুমাচ্ছিলাম";
                            break;
                        case "F_in":
                            result = "ঘুমাব";
                            break;
                        case "F_con":
                            result = "ঘুমাইতে থাকব";
                            break;
                        case "F_per":
                            result = "ঘুমাব";
                            break;
                        case "F_per_con":
                            result = "ঘুমাইতে থাকব";
                            break;
                        default: break;
                    }
                }
                else if (verb.Contains("গুটান") || verb == "গুটান")
                {
                    switch (verb_tag)
                    {
                        case "P_in":
                            result = "গুটাই";
                            break;
                        case "P_con":
                            result = "গুটাচ্ছি";
                            break;
                        case "P_per":
                            result = "গুটিয়েছি";
                            break;
                        case "P_per_con":
                            result = "গুটাচ্ছি";
                            break;
                        case "Pa_in":
                            result = "গুটিয়েছিলাম";
                            break;
                        case "Pa_con":
                            result = "গুটাচ্ছিলাম";
                            break;
                        case "Pa_per":
                            result = "গুটিয়েছিলাম";
                            break;
                        case "Pa_per_con":
                            result = "গুটাচ্ছিলাম";
                            break;
                        case "F_in":
                            result = "গুটাব";
                            break;
                        case "F_con":
                            result = "গুটাইতে থাকব";
                            break;
                        case "F_per":
                            result = "গুটাব";
                            break;
                        case "F_per_con":
                            result = "গুটাইতে থাকব";
                            break;
                        default: break;
                    }
                }
                else if (verb.Contains("গাওয়া") || verb == "গাওয়া")
                {
                    switch (verb_tag)
                    {
                        case "P_in":
                            result = "গাই";
                            break;
                        case "P_con":
                            result = "গাচ্ছি";
                            break;
                        case "P_per":
                            result = "গেয়েছি";
                            break;
                        case "P_per_con":
                            result = "গাচ্ছি";
                            break;
                        case "Pa_in":
                            result = "গেয়েছিলাম";
                            break;
                        case "Pa_con":
                            result = "গাইতেছিলাম";
                            break;
                        case "Pa_per":
                            result = "গেয়েছিলাম";
                            break;
                        case "Pa_per_con":
                            result = "গাইতেছিলাম";
                            break;
                        case "F_in":
                            result = "গাইবো";
                            break;
                        case "F_con":
                            result = "গাইতে থাকব";
                            break;
                        case "F_per":
                            result = "গাইবো";
                            break;
                        case "F_per_con":
                            result = "গাইতে থাকব";
                            break;
                        default: break;
                    }
                }
                else if (verb.Contains("গোঙান") || verb == "গোঙান")
                {
                    switch (verb_tag)
                    {
                        case "P_in":
                            result = "গুঙাই";
                            break;
                        case "P_con":
                            result = "গুঙ্গাচ্ছি";
                            break;
                        case "P_per":
                            result = "গুঙিয়েছি";
                            break;
                        case "P_per_con":
                            result = "গুঙ্গাচ্ছি";
                            break;
                        case "Pa_in":
                            result = "গুঙিয়েছিলাম";
                            break;
                        case "Pa_con":
                            result = "গুঙ্গাচ্ছিলাম";
                            break;
                        case "Pa_per":
                            result = "গুঙিয়েছিলাম";
                            break;
                        case "Pa_per_con":
                            result = "গুঙ্গাচ্ছিলাম";
                            break;
                        case "F_in":
                            result = "গুঙ্গাব";
                            break;
                        case "F_con":
                            result = "গুঙ্গাতে থাকব";
                            break;
                        case "F_per":
                            result = "গুঙ্গাব";
                            break;
                        case "F_per_con":
                            result = "গুঙ্গাতে থাকব";
                            break;
                        default: break;
                    }
                }
                else if (verb.Contains("হওয়া") || verb == "হওয়া")
                {
                    switch (verb_tag)
                    {
                        case "P_in":
                            result = "হই";
                            break;
                        case "P_con":
                            result = "হচ্ছি";
                            break;
                        case "P_per":
                            result = "হইছি";
                            break;
                        case "P_per_con":
                            result = "হচ্ছি";
                            break;
                        case "Pa_in":
                            result = "হয়েছিলাম";
                            break;
                        case "Pa_con":
                            result = "হচ্ছিলাম";
                            break;
                        case "Pa_per":
                            result = "হয়েছিলাম";
                            break;
                        case "Pa_per_con":
                            result = "হচ্ছিলাম";
                            break;
                        case "F_in":
                            result = "হব";
                            break;
                        case "F_con":
                            result = "হইতে থাকব";
                            break;
                        case "F_per":
                            result = "হব";
                            break;
                        case "F_per_con":
                            result = "হইতে থাকব";
                            break;
                        default: break;
                    }
                }
                else if (verb.Contains("হাসা") || verb == "হাসা")
                {
                    switch (verb_tag)
                    {
                        case "P_in":
                            result = "হাসি";
                            break;
                        case "P_con":
                            result = "হাসছি";
                            break;
                        case "P_per":
                            result = "হেসেছি";
                            break;
                        case "P_per_con":
                            result = "হাসছি";
                            break;
                        case "Pa_in":
                            result = "হেসেছিলাম";
                            break;
                        case "Pa_con":
                            result = "হাসছিলাম";
                            break;
                        case "Pa_per":
                            result = "হেসেছিলাম";
                            break;
                        case "Pa_per_con":
                            result = "হাসছিলাম";
                            break;
                        case "F_in":
                            result = "হাসব";
                            break;
                        case "F_con":
                            result = "হাসতে থাকব";
                            break;
                        case "F_per":
                            result = "হাসব";
                            break;
                        case "F_per_con":
                            result = "হাসতে থাকব";
                            break;
                        default: break;
                    }
                }
                else if (verb.Contains("জানান") || verb == "জানান")
                {
                    switch (verb_tag)
                    {
                        case "P_in":
                            result = "জানাই";
                            break;
                        case "P_con":
                            result = "জানাচ্ছি";
                            break;
                        case "P_per":
                            result = "জানিয়েছি";
                            break;
                        case "P_per_con":
                            result = "জানাচ্ছি";
                            break;
                        case "Pa_in":
                            result = "জানিয়েছিলাম";
                            break;
                        case "Pa_con":
                            result = "জানাচ্ছিলাম";
                            break;
                        case "Pa_per":
                            result = "জানিয়েছিলাম";
                            break;
                        case "Pa_per_con":
                            result = "জানাচ্ছিলাম";
                            break;
                        case "F_in":
                            result = "জানাব";
                            break;
                        case "F_con":
                            result = "জানাইতে থাকব";
                            break;
                        case "F_per":
                            result = "জানাব";
                            break;
                        case "F_per_con":
                            result = "জানাইতে থাকব";
                            break;
                        default: break;
                    }
                }
                else if (verb.Contains("যাওয়া") || verb == "যাওয়া")
                {
                    switch (verb_tag)
                    {
                        case "P_in":
                            result = "যাই";
                            break;
                        case "P_con":
                            result = "যাচ্ছি";
                            break;
                        case "P_per":
                            result = "গিয়েছি";
                            break;
                        case "P_per_con":
                            result = "যাচ্ছি";
                            break;
                        case "Pa_in":
                            result = "গিয়েছিলাম";
                            break;
                        case "Pa_con":
                            result = "যাচ্ছিলাম";
                            break;
                        case "Pa_per":
                            result = "গিয়েছিলাম";
                            break;
                        case "Pa_per_con":
                            result = "যাচ্ছিলাম";
                            break;
                        case "F_in":
                            result = "যাব";
                            break;
                        case "F_con":
                            result = "যাইতে থাকব";
                            break;
                        case "F_per":
                            result = "যাব";
                            break;
                        case "F_per_con":
                            result = "যাইতে থাকব";
                            break;
                        default: break;
                    }
                }
                else if (verb.Contains("জাগা") || verb == "জাগা")
                {
                    switch (verb_tag)
                    {
                        case "P_in":
                            result = "জাগি";
                            break;
                        case "P_con":
                            result = "জাগছি";
                            break;
                        case "P_per":
                            result = "জেগেছি";
                            break;
                        case "P_per_con":
                            result = "জাগছি";
                            break;
                        case "Pa_in":
                            result = "জেগেছিলাম";
                            break;
                        case "Pa_con":
                            result = "জাগছিলাম";
                            break;
                        case "Pa_per":
                            result = "জেগেছিলাম";
                            break;
                        case "Pa_per_con":
                            result = "জাগছিলাম";
                            break;
                        case "F_in":
                            result = "জাগব";
                            break;
                        case "F_con":
                            result = "জাগতে থাকবো";
                            break;
                        case "F_per":
                            result = "জাগব";
                            break;
                        case "F_per_con":
                            result = "জাগতে থাকবো";
                            break;
                        default: break;
                    }
                }
                else if (verb.Contains("জ্বালান") || verb == "জ্বালান")
                {
                    switch (verb_tag)
                    {
                        case "P_in":
                            result = "জ্বালাই";
                            break;
                        case "P_con":
                            result = "জ্বালাচ্ছি";
                            break;
                        case "P_per":
                            result = "জ্বালিয়েছি";
                            break;
                        case "P_per_con":
                            result = "জ্বালাচ্ছি";
                            break;
                        case "Pa_in":
                            result = "জ্বালাইছিলাম";
                            break;
                        case "Pa_con":
                            result = "জ্বালাচ্ছিলাম";
                            break;
                        case "Pa_per":
                            result = "জ্বালাইছিলাম";
                            break;
                        case "Pa_per_con":
                            result = "জ্বালাচ্ছিলাম";
                            break;
                        case "F_in":
                            result = "জ্বালাব";
                            break;
                        case "F_con":
                            result = "জ্বালাইতে থাকব";
                            break;
                        case "F_per":
                            result = "জ্বালাব";
                            break;
                        case "F_per_con":
                            result = "জ্বালাইতে থাকব";
                            break;
                        default: break;
                    }
                }
                else if (verb.Contains("ঝাড়া") || verb == "ঝাড়া")
                {
                    switch (verb_tag)
                    {
                        case "P_in":
                            result = "ঝাড়ি";
                            break;
                        case "P_con":
                            result = "ঝাড়ছি";
                            break;
                        case "P_per":
                            result = "ঝেড়েছি";
                            break;
                        case "P_per_con":
                            result = "ঝাড়ছি";
                            break;
                        case "Pa_in":
                            result = "ঝেড়েছিলাম";
                            break;
                        case "Pa_con":
                            result = "ঝাড়তেছিলাম";
                            break;
                        case "Pa_per":
                            result = "ঝেড়েছিলাম";
                            break;
                        case "Pa_per_con":
                            result = "ঝাড়তেছিলাম";
                            break;
                        case "F_in":
                            result = "ঝাড়ব";
                            break;
                        case "F_con":
                            result = "ঝাড়তে থাকব";
                            break;
                        case "F_per":
                            result = "ঝাড়ব";
                            break;
                        case "F_per_con":
                            result = "ঝাড়তে থাকব";
                            break;
                        default: break;
                    }
                }
                else if (verb.Contains("জন্মান") || verb == "জন্মান")
                {
                    switch (verb_tag)
                    {
                        case "P_in":
                            result = "জন্মাই";
                            break;
                        case "P_con":
                            result = "জন্মাচ্ছি";
                            break;
                        case "P_per":
                            result = "জন্মেছি";
                            break;
                        case "P_per_con":
                            result = "জন্মাচ্ছি";
                            break;
                        case "Pa_in":
                            result = "জন্মেছিলাম";
                            break;
                        case "Pa_con":
                            result = "জন্মেতেছিলাম";
                            break;
                        case "Pa_per":
                            result = "জন্মেছিলাম";
                            break;
                        case "Pa_per_con":
                            result = "জন্মেতেছিলাম";
                            break;
                        case "F_in":
                            result = "জন্মাব";
                            break;
                        case "F_con":
                            result = "জন্মাইতে থাকব";
                            break;
                        case "F_per":
                            result = "জন্মাব";
                            break;
                        case "F_per_con":
                            result = "জন্মাইতে থাকব";
                            break;
                        default: break;
                    }
                }
                else if (verb.Contains("ঝুলান") || verb == "ঝুলান")
                {
                    switch (verb_tag)
                    {
                        case "P_in":
                            result = "ঝুলাই";
                            break;
                        case "P_con":
                            result = "ঝুলাচ্ছি";
                            break;
                        case "P_per":
                            result = "ঝুলাইছি";
                            break;
                        case "P_per_con":
                            result = "ঝুলাচ্ছি";
                            break;
                        case "Pa_in":
                            result = "ঝুলাইছিলাম";
                            break;
                        case "Pa_con":
                            result = "ঝুলাচ্ছিলাম";
                            break;
                        case "Pa_per":
                            result = "ঝুলাইছিলাম";
                            break;
                        case "Pa_per_con":
                            result = "ঝুলাচ্ছিলাম";
                            break;
                        case "F_in":
                            result = "ঝুলাব";
                            break;
                        case "F_con":
                            result = "ঝুলাইতে থাকব";
                            break;
                        case "F_per":
                            result = "ঝুলাব";
                            break;
                        case "F_per_con":
                            result = "ঝুলাইতে থাকব";
                            break;
                        default: break;
                    }
                }
                else if (verb.Contains("করা") || verb == "করা")
                {
                    switch (verb_tag)
                    {
                        case "P_in":
                            result = "করি";
                            break;
                        case "P_con":
                            result = "করছি";
                            break;
                        case "P_per":
                            result = "করেছি";
                            break;
                        case "P_per_con":
                            result = "করছি";
                            break;
                        case "Pa_in":
                            result = "করেছিলাম";
                            break;
                        case "Pa_con":
                            result = "করতেছিলাম";
                            break;
                        case "Pa_per":
                            result = "করেছিলাম";
                            break;
                        case "Pa_per_con":
                            result = "করতেছিলাম";
                            break;
                        case "F_in":
                            result = "করব";
                            break;
                        case "F_con":
                            result = "করতে থাকব";
                            break;
                        case "F_per":
                            result = "করব";
                            break;
                        case "F_per_con":
                            result = "করতে থাকব";
                            break;
                        default: break;
                    }
                }
                else if (verb.Contains("জানা") || verb == "জানা")
                {
                    switch (verb_tag)
                    {
                        case "P_in":
                            result = "জানি";
                            break;
                        case "P_con":
                            result = "জানছি";
                            break;
                        case "P_per":
                            result = "জেনেছি";
                            break;
                        case "P_per_con":
                            result = "জানছি";
                            break;
                        case "Pa_in":
                            result = "জেনেছিলাম";
                            break;
                        case "Pa_con":
                            result = "জানতেছিলাম";
                            break;
                        case "Pa_per":
                            result = "জেনেছিলাম";
                            break;
                        case "Pa_per_con":
                            result = "জানতেছিলাম";
                            break;
                        case "F_in":
                            result = "জানব";
                            break;
                        case "F_con":
                            result = "জানতে থাকব";
                            break;
                        case "F_per":
                            result = "জানব";
                            break;
                        case "F_per_con":
                            result = "জানতে থাকব";
                            break;
                        default: break;
                    }
                }
                else if (verb.Contains("কাটা") || verb == "কাটা")
                {
                    switch (verb_tag)
                    {
                        case "P_in":
                            result = "কাটি";
                            break;
                        case "P_con":
                            result = "কাটছি";
                            break;
                        case "P_per":
                            result = "কেটেছি";
                            break;
                        case "P_per_con":
                            result = "কাটছি";
                            break;
                        case "Pa_in":
                            result = "কেটেছিলাম";
                            break;
                        case "Pa_con":
                            result = "কাটতেছিলাম";
                            break;
                        case "Pa_per":
                            result = "কেটেছিলাম";
                            break;
                        case "Pa_per_con":
                            result = "কাটতেছিলাম";
                            break;
                        case "F_in":
                            result = "কাটব";
                            break;
                        case "F_con":
                            result = "কাটতে থাকব";
                            break;
                        case "F_per":
                            result = "কাটব";
                            break;
                        case "F_per_con":
                            result = "কাটতে থাকব";
                            break;
                        default: break;
                    }
                }
                else if (verb.Contains("কামান") || verb == "কামান")
                {
                    switch (verb_tag)
                    {
                        case "P_in":
                            result = "কামাই";
                            break;
                        case "P_con":
                            result = "কামাচ্ছি";
                            break;
                        case "P_per":
                            result = "কামাইছি";
                            break;
                        case "P_per_con":
                            result = "কামাচ্ছি";
                            break;
                        case "Pa_in":
                            result = "কামিয়েছিলাম";
                            break;
                        case "Pa_con":
                            result = "কামাইতেছিলাম";
                            break;
                        case "Pa_per":
                            result = "কামিয়েছিলাম";
                            break;
                        case "Pa_per_con":
                            result = "কামাইতেছিলাম";
                            break;
                        case "F_in":
                            result = "কামাব";
                            break;
                        case "F_con":
                            result = "কামাইতে থাকব";
                            break;
                        case "F_per":
                            result = "কামাব";
                            break;
                        case "F_per_con":
                            result = "কামাইতে থাকব";
                            break;
                        default: break;
                    }
                }
                else if (verb.Contains("কেনা") || verb == "কেনা")
                {
                    switch (verb_tag)
                    {
                        case "P_in":
                            result = "কিনি";
                            break;
                        case "P_con":
                            result = "কিনছি";
                            break;
                        case "P_per":
                            result = "কিনেছি";
                            break;
                        case "P_per_con":
                            result = "কিনছি";
                            break;
                        case "Pa_in":
                            result = "কিনেছিলাম";
                            break;
                        case "Pa_con":
                            result = "কিনতেছিলাম";
                            break;
                        case "Pa_per":
                            result = "কিনেছিলাম";
                            break;
                        case "Pa_per_con":
                            result = "কিনতেছিলাম";
                            break;
                        case "F_in":
                            result = "কিনব";
                            break;
                        case "F_con":
                            result = "কিনতে থাকব";
                            break;
                        case "F_per":
                            result = "কিনব";
                            break;
                        case "F_per_con":
                            result = "কিনতে থাকব";
                            break;
                        default: break;
                    }
                }
                else if (verb.Contains("কমানো") || verb == "কমানো")
                {
                    switch (verb_tag)
                    {
                        case "P_in":
                            result = "কমাই";
                            break;
                        case "P_con":
                            result = "কমাচ্ছি";
                            break;
                        case "P_per":
                            result = "কমাইছি";
                            break;
                        case "P_per_con":
                            result = "কমাচ্ছি";
                            break;
                        case "Pa_in":
                            result = "কমাইছিলাম";
                            break;
                        case "Pa_con":
                            result = "কমাইতেছিলাম";
                            break;
                        case "Pa_per":
                            result = "কমাইছিলাম";
                            break;
                        case "Pa_per_con":
                            result = "কমাইতেছিলাম";
                            break;
                        case "F_in":
                            result = "কমাব";
                            break;
                        case "F_con":
                            result = "কমাইতে থাকব";
                            break;
                        case "F_per":
                            result = "কমাব";
                            break;
                        case "F_per_con":
                            result = "কমাইতে থাকব";
                            break;
                        default: break;
                    }
                }
                else if (verb.Contains("করান") || verb == "করান")
                {
                    switch (verb_tag)
                    {
                        case "P_in":
                            result = "করাই";
                            break;
                        case "P_con":
                            result = "করাচ্ছি";
                            break;
                        case "P_per":
                            result = "করাইছি";
                            break;
                        case "P_per_con":
                            result = "করাচ্ছি";
                            break;
                        case "Pa_in":
                            result = "করিয়েছিলাম";
                            break;
                        case "Pa_con":
                            result = "করাইতেছিলাম";
                            break;
                        case "Pa_per":
                            result = "করিয়েছিলাম";
                            break;
                        case "Pa_per_con":
                            result = "করাইতেছিলাম";
                            break;
                        case "F_in":
                            result = "করাব";
                            break;
                        case "F_con":
                            result = "করাতে থাকব";
                            break;
                        case "F_per":
                            result = "করাব";
                            break;
                        case "F_per_con":
                            result = "করাতে থাকব";
                            break;
                        default: break;
                    }
                }
                else if (verb.Contains("খাওয়া") || verb == "খাওয়া")
                {
                    switch (verb_tag)
                    {
                        case "P_in":
                            result = "খাই";
                            break;
                        case "P_con":
                            result = "খাচ্ছি";
                            break;
                        case "P_per":
                            result = "খেয়েছি";
                            break;
                        case "P_per_con":
                            result = "খাচ্ছি";
                            break;
                        case "Pa_in":
                            result = "খেয়েছিলাম";
                            break;
                        case "Pa_con":
                            result = "খাইতেছিলাম";
                            break;
                        case "Pa_per":
                            result = "খেয়েছিলাম";
                            break;
                        case "Pa_per_con":
                            result = "খাইতেছিলাম";
                            break;
                        case "F_in":
                            result = "খাব";
                            break;
                        case "F_con":
                            result = "খাইতে থাকব";
                            break;
                        case "F_per":
                            result = "খাব";
                            break;
                        case "F_per_con":
                            result = "খাইতে থাকব";
                            break;
                        default: break;
                    }
                }
                else if (verb.Contains("খেলা") || verb == "খেলা")
                {
                    switch (verb_tag)
                    {
                        case "P_in":
                            result = "খেলি";
                            break;
                        case "P_con":
                            result = "খেলছি";
                            break;
                        case "P_per":
                            result = "খেলেছি";
                            break;
                        case "P_per_con":
                            result = "খেলছি";
                            break;
                        case "Pa_in":
                            result = "খেলেছিলাম";
                            break;
                        case "Pa_con":
                            result = "খেলতেছিলাম";
                            break;
                        case "Pa_per":
                            result = "খেলেছিলাম";
                            break;
                        case "Pa_per_con":
                            result = "খেলতেছিলাম";
                            break;
                        case "F_in":
                            result = "খেলব";
                            break;
                        case "F_con":
                            result = "খেলতে থাকব";
                            break;
                        case "F_per":
                            result = "খেলব";
                            break;
                        case "F_per_con":
                            result = "খেলতে থাকব";
                            break;
                        default: break;
                    }
                }
                else if (verb.Contains("খোলা") || verb == "খোলা")
                {
                    switch (verb_tag)
                    {
                        case "P_in":
                            result = "খুলি";
                            break;
                        case "P_con":
                            result = "খুলছি";
                            break;
                        case "P_per":
                            result = "খুলেছি";
                            break;
                        case "P_per_con":
                            result = "খুলছি";
                            break;
                        case "Pa_in":
                            result = "খুলেছিলাম";
                            break;
                        case "Pa_con":
                            result = "খুলতেছিলাম";
                            break;
                        case "Pa_per":
                            result = "খুলেছিলাম";
                            break;
                        case "Pa_per_con":
                            result = "খুলতেছিলাম";
                            break;
                        case "F_in":
                            result = "খুলব";
                            break;
                        case "F_con":
                            result = "খুলতে থাকব";
                            break;
                        case "F_per":
                            result = "খুলব";
                            break;
                        case "F_per_con":
                            result = "খুলতে থাকব";
                            break;
                        default: break;
                    }
                }
                else if (verb.Contains("খাওয়ান") || verb == "খাওয়ান")
                {
                    switch (verb_tag)
                    {
                        case "P_in":
                            result = "খাওয়াই";
                            break;
                        case "P_con":
                            result = "খাওয়াচ্ছি";
                            break;
                        case "P_per":
                            result = "খাইয়েছি";
                            break;
                        case "P_per_con":
                            result = "খাওয়াচ্ছি";
                            break;
                        case "Pa_in":
                            result = "খাইয়েছিলাম";
                            break;
                        case "Pa_con":
                            result = "খাওয়াইতেছিলাম";
                            break;
                        case "Pa_per":
                            result = "খাইয়েছিলাম";
                            break;
                        case "Pa_per_con":
                            result = "খাওয়াইতেছিলাম";
                            break;
                        case "F_in":
                            result = "খাওয়াব";
                            break;
                        case "F_con":
                            result = "খাওয়াতে থাকব";
                            break;
                        case "F_per":
                            result = "খাওয়াব";
                            break;
                        case "F_per_con":
                            result = "খাওয়াতে থাকব";
                            break;
                        default: break;
                    }
                }
                else if (verb.Contains("খোজা") || verb == "খোজা")
                {
                    switch (verb_tag)
                    {
                        case "P_in":
                            result = "খুজি";
                            break;
                        case "P_con":
                            result = "খুজছি";
                            break;
                        case "P_per":
                            result = "খুজেছি";
                            break;
                        case "P_per_con":
                            result = "খুজছি";
                            break;
                        case "Pa_in":
                            result = "খুজেছিলাম";
                            break;
                        case "Pa_con":
                            result = "খুজতেছিলাম";
                            break;
                        case "Pa_per":
                            result = "খুজেছিলাম";
                            break;
                        case "Pa_per_con":
                            result = "খুজতেছিলাম";
                            break;
                        case "F_in":
                            result = "খুজব";
                            break;
                        case "F_con":
                            result = "খুজতে থাকব";
                            break;
                        case "F_per":
                            result = "খুজব";
                            break;
                        case "F_per_con":
                            result = "খুজতে থাকব";
                            break;
                        default: break;
                    }
                }
                else if (verb.Contains("লেখা") || verb == "লেখা")
                {
                    switch (verb_tag)
                    {
                        case "P_in":
                            result = "লেখি";
                            break;
                        case "P_con":
                            result = "লিখছি";
                            break;
                        case "P_per":
                            result = "লিখেছি";
                            break;
                        case "P_per_con":
                            result = "লিখছি";
                            break;
                        case "Pa_in":
                            result = "লিখেছিলাম";
                            break;
                        case "Pa_con":
                            result = "লিখতেছিলাম";
                            break;
                        case "Pa_per":
                            result = "লিখেছিলাম";
                            break;
                        case "Pa_per_con":
                            result = "লিখতেছিলাম";
                            break;
                        case "F_in":
                            result = "লিখব";
                            break;
                        case "F_con":
                            result = "লিখতে থাকব";
                            break;
                        case "F_per":
                            result = "লিখব";
                            break;
                        case "F_per_con":
                            result = "লিখতে থাকব";
                            break;
                        default: break;
                    }
                }
                else if (verb.Contains("লাগানো") || verb == "লাগানো")
                {
                    switch (verb_tag)
                    {
                        case "P_in":
                            result = "লাগাই";
                            break;
                        case "P_con":
                            result = "লাগাচ্ছি";
                            break;
                        case "P_per":
                            result = "লাগিয়েছি";
                            break;
                        case "P_per_con":
                            result = "লাগাচ্ছি";
                            break;
                        case "Pa_in":
                            result = "লাগিয়েছিলাম";
                            break;
                        case "Pa_con":
                            result = "লাগাচ্ছিলাম";
                            break;
                        case "Pa_per":
                            result = "লাগিয়েছিলাম";
                            break;
                        case "Pa_per_con":
                            result = "লাগাচ্ছিলাম";
                            break;
                        case "F_in":
                            result = "";
                            break;
                        case "F_con":
                            result = "";
                            break;
                        case "F_per":
                            result = "";
                            break;
                        case "F_per_con":
                            result = "";
                            break;
                        default: break;
                    }
                }
                else if (verb.Contains("লুকান") || verb == "লুকান")
                {
                    switch (verb_tag)
                    {
                        case "P_in":
                            result = "লুকাই";
                            break;
                        case "P_con":
                            result = "লুকাচ্ছি";
                            break;
                        case "P_per":
                            result = "লুকিয়েছি";
                            break;
                        case "P_per_con":
                            result = "লুকাচ্ছি";
                            break;
                        case "Pa_in":
                            result = "লুকিয়েছিলাম";
                            break;
                        case "Pa_con":
                            result = "লুকাইতে থাকব";
                            break;
                        case "Pa_per":
                            result = "লুকিয়েছিলাম";
                            break;
                        case "Pa_per_con":
                            result = "লুকাইতে থাকব";
                            break;
                        case "F_in":
                            result = "লুকাব";
                            break;
                        case "F_con":
                            result = "লুকাইতে থাকব";
                            break;
                        case "F_per":
                            result = "লুকাব";
                            break;
                        case "F_per_con":
                            result = "লুকাইতে থাকব";
                            break;
                        default: break;
                    }
                }
                else if (verb.Contains("ভাঙ্গা") || verb == "ভাঙ্গা")
                {
                    switch (verb_tag)
                    {
                        case "P_in":
                            result = "ভাঙ্গি";
                            break;
                        case "P_con":
                            result = "ভাঙছি";
                            break;
                        case "P_per":
                            result = "ভেঙ্গেছি";
                            break;
                        case "P_per_con":
                            result = "ভাঙছি";
                            break;
                        case "Pa_in":
                            result = "ভেঙ্গেছিলাম";
                            break;
                        case "Pa_con":
                            result = "ভাঙ্গছিলাম";
                            break;
                        case "Pa_per":
                            result = "ভেঙ্গেছিলাম";
                            break;
                        case "Pa_per_con":
                            result = "ভাঙ্গছিলাম";
                            break;
                        case "F_in":
                            result = "ভাঙ্গব";
                            break;
                        case "F_con":
                            result = "ভাঙ্গতে থাকব";
                            break;
                        case "F_per":
                            result = "ভাঙ্গব";
                            break;
                        case "F_per_con":
                            result = "ভাঙ্গতে থাকব";
                            break;
                        default: break;
                    }
                }
                else if (verb.Contains("ভালবাসা") || verb == "ভালবাসা")
                {
                    switch (verb_tag)
                    {
                        case "P_in":
                            result = "ভালবাসি";
                            break;
                        case "P_con":
                            result = "ভালোবাসছি";
                            break;
                        case "P_per":
                            result = "ভালবেসেছি";
                            break;
                        case "P_per_con":
                            result = "ভালোবাসছি";
                            break;
                        case "Pa_in":
                            result = "ভালবেসেছিলাম";
                            break;
                        case "Pa_con":
                            result = "ভালোবাসছিলাম";
                            break;
                        case "Pa_per":
                            result = "ভালবেসেছিলাম";
                            break;
                        case "Pa_per_con":
                            result = "ভালোবাসছিলাম";
                            break;
                        case "F_in":
                            result = "ভালবাসব";
                            break;
                        case "F_con":
                            result = "ভালবাসতে থাকব";
                            break;
                        case "F_per":
                            result = "ভালবাসব";
                            break;
                        case "F_per_con":
                            result = "ভালবাসতে থাকব";
                            break;
                        default: break;
                    }
                }
                else if (verb.Contains("ভাজা") || verb == "ভাজা")
                {
                    switch (verb_tag)
                    {
                        case "P_in":
                            result = "ভাজি";
                            break;
                        case "P_con":
                            result = "ভাজছি";
                            break;
                        case "P_per":
                            result = "ভেজেছি";
                            break;
                        case "P_per_con":
                            result = "ভাজছি";
                            break;
                        case "Pa_in":
                            result = "ভেজেছিলাম";
                            break;
                        case "Pa_con":
                            result = "ভাজছিলাম";
                            break;
                        case "Pa_per":
                            result = "ভেজেছিলাম";
                            break;
                        case "Pa_per_con":
                            result = "ভাজছিলাম";
                            break;
                        case "F_in":
                            result = "ভাজব";
                            break;
                        case "F_con":
                            result = "ভাজতে থাকব";
                            break;
                        case "F_per":
                            result = "ভাজব";
                            break;
                        case "F_per_con":
                            result = "ভাজতে থাকব";
                            break;
                        default: break;
                    }
                }
                else if (verb.Contains("ভাসান") || verb == "ভাসান")
                {
                    switch (verb_tag)
                    {
                        case "P_in":
                            result = "ভাসাই";
                            break;
                        case "P_con":
                            result = "ভাসাচ্ছি";
                            break;
                        case "P_per":
                            result = "ভাসিয়েছি";
                            break;
                        case "P_per_con":
                            result = "ভাসাচ্ছি";
                            break;
                        case "Pa_in":
                            result = "ভাসিয়েছিলাম";
                            break;
                        case "Pa_con":
                            result = "ভাসাচ্ছিলাম";
                            break;
                        case "Pa_per":
                            result = "ভাসিয়েছিলাম";
                            break;
                        case "Pa_per_con":
                            result = "ভাসাচ্ছিলাম";
                            break;
                        case "F_in":
                            result = "ভাসাব";
                            break;
                        case "F_con":
                            result = "ভাসাতে থাকব";
                            break;
                        case "F_per":
                            result = "ভাসাব";
                            break;
                        case "F_per_con":
                            result = "ভাসাতে থাকব";
                            break;
                        default: break;
                    }
                }
                else if (verb.Contains("তাকান") || verb == "তাকান")
                {
                    switch (verb_tag)
                    {
                        case "P_in":
                            result = "তাকাই";
                            break;
                        case "P_con":
                            result = "তাকাচ্ছি";
                            break;
                        case "P_per":
                            result = "তাকিয়েছি";
                            break;
                        case "P_per_con":
                            result = "তাকাচ্ছি";
                            break;
                        case "Pa_in":
                            result = "তাকিয়েছিলাম";
                            break;
                        case "Pa_con":
                            result = "তাকাচ্ছিলাম";
                            break;
                        case "Pa_per":
                            result = "তাকিয়েছিলাম";
                            break;
                        case "Pa_per_con":
                            result = "তাকাচ্ছিলাম";
                            break;
                        case "F_in":
                            result = "তাকাব";
                            break;
                        case "F_con":
                            result = "তাকাতে থাকব";
                            break;
                        case "F_per":
                            result = "তাকাব";
                            break;
                        case "F_per_con":
                            result = "তাকাতে থাকব";
                            break;
                        default: break;
                    }
                }
                else if (verb.Contains("থাকা") || verb == "থাকা")
                {
                    switch (verb_tag)
                    {
                        case "P_in":
                            result = "থাকি";
                            break;
                        case "P_con":
                            result = "থাকছি";
                            break;
                        case "P_per":
                            result = "থেকেছি";
                            break;
                        case "P_per_con":
                            result = "থাকছি";
                            break;
                        case "Pa_in":
                            result = "থেকেছিলাম";
                            break;
                        case "Pa_con":
                            result = "থাকছিলাম";
                            break;
                        case "Pa_per":
                            result = "থেকেছিলাম";
                            break;
                        case "Pa_per_con":
                            result = "থাকছিলাম";
                            break;
                        case "F_in":
                            result = "থাকব";
                            break;
                        case "F_con":
                            result = "থাকব";
                            break;
                        case "F_per":
                            result = "থাকব";
                            break;
                        case "F_per_con":
                            result = "থাকব";
                            break;
                        default: break;
                    }
                }
                else if (verb.Contains("টানা") || verb == "টানা")
                {
                    switch (verb_tag)
                    {
                        case "P_in":
                            result = "টানি";
                            break;
                        case "P_con":
                            result = "টানছি";
                            break;
                        case "P_per":
                            result = "টেনেছি";
                            break;
                        case "P_per_con":
                            result = "টানছি";
                            break;
                        case "Pa_in":
                            result = "টেনেছিলাম";
                            break;
                        case "Pa_con":
                            result = "টানছিলাম";
                            break;
                        case "Pa_per":
                            result = "টেনেছিলাম";
                            break;
                        case "Pa_per_con":
                            result = "টানছিলাম";
                            break;
                        case "F_in":
                            result = "টানব";
                            break;
                        case "F_con":
                            result = "টানতে থাকব";
                            break;
                        case "F_per":
                            result = "টানব";
                            break;
                        case "F_per_con":
                            result = "টানতে থাকব";
                            break;
                        default: break;
                    }
                }
                else if (verb.Contains("পাঠান") || verb == "পাঠান")
                {
                    switch (verb_tag)
                    {
                        case "P_in":
                            result = "পাঠাই";
                            break;
                        case "P_con":
                            result = "পাঠাচ্ছি";
                            break;
                        case "P_per":
                            result = "পাঠিয়েছি";
                            break;
                        case "P_per_con":
                            result = "পাঠাচ্ছি";
                            break;
                        case "Pa_in":
                            result = "পাঠিয়েছিলাম";
                            break;
                        case "Pa_con":
                            result = "পাঠাচ্ছিলাম";
                            break;
                        case "Pa_per":
                            result = "পাঠিয়েছিলাম";
                            break;
                        case "Pa_per_con":
                            result = "পাঠাচ্ছিলাম";
                            break;
                        case "F_in":
                            result = "পাঠাব";
                            break;
                        case "F_con":
                            result = "পাঠাতে থাকব";
                            break;
                        case "F_per":
                            result = "পাঠাব";
                            break;
                        case "F_per_con":
                            result = "পাঠাতে থাকব";
                            break;
                        default: break;
                    }
                }
                else if (verb.Contains("পড়া") || verb == "পড়া")
                {
                    switch (verb_tag)
                    {
                        case "P_in":
                            result = "পড়ি";
                            break;
                        case "P_con":
                            result = "পড়ছি";
                            break;
                        case "P_per":
                            result = "পড়েছি";
                            break;
                        case "P_per_con":
                            result = "পড়ছি";
                            break;
                        case "Pa_in":
                            result = "পড়েছিলাম";
                            break;
                        case "Pa_con":
                            result = "পড়ছিলাম";
                            break;
                        case "Pa_per":
                            result = "পড়েছিলাম";
                            break;
                        case "Pa_per_con":
                            result = "পড়ছিলাম";
                            break;
                        case "F_in":
                            result = "পড়ব";
                            break;
                        case "F_con":
                            result = "পড়তে থাকব";
                            break;
                        case "F_per":
                            result = "পড়ব";
                            break;
                        case "F_per_con":
                            result = "পড়তে থাকব";
                            break;
                        default: break;
                    }
                }
                else if (verb.Contains("পরান") || verb == "পরান")
                {
                    switch (verb_tag)
                    {
                        case "P_in":
                            result = "পরাই";
                            break;
                        case "P_con":
                            result = "পরাচ্ছি";
                            break;
                        case "P_per":
                            result = "পরিয়েছি";
                            break;
                        case "P_per_con":
                            result = "পরাচ্ছি";
                            break;
                        case "Pa_in":
                            result = "পরিয়েছিলাম";
                            break;
                        case "Pa_con":
                            result = "পরাচ্ছিলাম";
                            break;
                        case "Pa_per":
                            result = "পরিয়েছিলাম";
                            break;
                        case "Pa_per_con":
                            result = "পরাচ্ছিলাম";
                            break;
                        case "F_in":
                            result = "পরাব";
                            break;
                        case "F_con":
                            result = "পরাতে থাকব";
                            break;
                        case "F_per":
                            result = "পরাব";
                            break;
                        case "F_per_con":
                            result = "পরাতে থাকব";
                            break;
                        default: break;
                    }
                }
                else if (verb.Contains("পালানো") || verb == "পালানো")
                {
                    switch (verb_tag)
                    {
                        case "P_in":
                            result = "পালাই";
                            break;
                        case "P_con":
                            result = "পালাচ্ছি";
                            break;
                        case "P_per":
                            result = "পালিয়েছি";
                            break;
                        case "P_per_con":
                            result = "পালাচ্ছি";
                            break;
                        case "Pa_in":
                            result = "পালিয়েছিলাম";
                            break;
                        case "Pa_con":
                            result = "পালাচ্ছিলাম";
                            break;
                        case "Pa_per":
                            result = "পালিয়েছিলাম";
                            break;
                        case "Pa_per_con":
                            result = "পালাচ্ছিলাম";
                            break;
                        case "F_in":
                            result = "পালাব";
                            break;
                        case "F_con":
                            result = "পালাতে থাকব";
                            break;
                        case "F_per":
                            result = "পালাব";
                            break;
                        case "F_per_con":
                            result = "পালাতে থাকব";
                            break;
                        default: break;
                    }
                }
                else if (verb.Contains("পাওয়া") || verb == "পাওয়া")
                {
                    switch (verb_tag)
                    {
                        case "P_in":
                            result = "পাই";
                            break;
                        case "P_con":
                            result = "পাচ্ছি";
                            break;
                        case "P_per":
                            result = "পেয়েছি";
                            break;
                        case "P_per_con":
                            result = "পাচ্ছি";
                            break;
                        case "Pa_in":
                            result = "পেয়েছিলাম";
                            break;
                        case "Pa_con":
                            result = "পাচ্ছিলাম";
                            break;
                        case "Pa_per":
                            result = "পেয়েছিলাম";
                            break;
                        case "Pa_per_con":
                            result = "পাচ্ছিলাম";
                            break;
                        case "F_in":
                            result = "পাব";
                            break;
                        case "F_con":
                            result = "পাইতে থাকব";
                            break;
                        case "F_per":
                            result = "পাব";
                            break;
                        case "F_per_con":
                            result = "পাইতে থাকব";
                            break;
                        default: break;
                    }
                }
                else if (verb.Contains("রাখা") || verb == "রাখা")
                {
                    switch (verb_tag)
                    {
                        case "P_in":
                            result = "রাখি";
                            break;
                        case "P_con":
                            result = "রাখছি";
                            break;
                        case "P_per":
                            result = "রেখেছি";
                            break;
                        case "P_per_con":
                            result = "রাখছি";
                            break;
                        case "Pa_in":
                            result = "রেখেছিলাম";
                            break;
                        case "Pa_con":
                            result = "রাখছিলাম";
                            break;
                        case "Pa_per":
                            result = "রেখেছিলাম";
                            break;
                        case "Pa_per_con":
                            result = "রাখছিলাম";
                            break;
                        case "F_in":
                            result = "রাখব";
                            break;
                        case "F_con":
                            result = "রাখতে থাকব";
                            break;
                        case "F_per":
                            result = "রাখব";
                            break;
                        case "F_per_con":
                            result = "রাখতে থাকব";
                            break;
                        default: break;
                    }
                }
                else if (verb.Contains("নোয়ান") || verb == "নোয়ান")
                {
                    switch (verb_tag)
                    {
                        case "P_in":
                            result = "নুয়াই";
                            break;
                        case "P_con":
                            result = "নুয়াচ্ছি";
                            break;
                        case "P_per":
                            result = "নুয়েছি";
                            break;
                        case "P_per_con":
                            result = "নুয়াচ্ছি";
                            break;
                        case "Pa_in":
                            result = "নুয়েছিলাম";
                            break;
                        case "Pa_con":
                            result = "নুয়াচ্ছিলাম";
                            break;
                        case "Pa_per":
                            result = "নুয়েছিলাম";
                            break;
                        case "Pa_per_con":
                            result = "নুয়াচ্ছিলাম";
                            break;
                        case "F_in":
                            result = "নুয়াব";
                            break;
                        case "F_con":
                            result = "নুয়াতে থাকব";
                            break;
                        case "F_per":
                            result = "নুয়াব";
                            break;
                        case "F_per_con":
                            result = "নুয়াতে থাকব";
                            break;
                        default: break;
                    }
                }
                else if (verb.Contains("নেয়া") || verb == "নেয়া")
                {
                    switch (verb_tag)
                    {
                        case "P_in":
                            result = "নিই";
                            break;
                        case "P_con":
                            result = "নিচ্ছি";
                            break;
                        case "P_per":
                            result = "নিয়েছি";
                            break;
                        case "P_per_con":
                            result = "নিচ্ছি";
                            break;
                        case "Pa_in":
                            result = "নিয়েছিলাম";
                            break;
                        case "Pa_con":
                            result = "নিচ্ছিলাম";
                            break;
                        case "Pa_per":
                            result = "নিয়েছিলাম";
                            break;
                        case "Pa_per_con":
                            result = "নিচ্ছিলাম";
                            break;
                        case "F_in":
                            result = "নিব";
                            break;
                        case "F_con":
                            result = "নিতে থাকব";
                            break;
                        case "F_per":
                            result = "নিব";
                            break;
                        case "F_per_con":
                            result = "নিতে থাকব";
                            break;
                        default: break;
                    }
                }
                else if (verb.Contains("নাড়ান") || verb == "নাড়ান")
                {
                    switch (verb_tag)
                    {
                        case "P_in":
                            result = "নাড়াই";
                            break;
                        case "P_con":
                            result = "নাড়াচ্ছি";
                            break;
                        case "P_per":
                            result = "নাড়িয়েছি";
                            break;
                        case "P_per_con":
                            result = "নাড়াচ্ছি";
                            break;
                        case "Pa_in":
                            result = "নাড়িয়েছিলাম";
                            break;
                        case "Pa_con":
                            result = "নাড়াচ্ছিলাম";
                            break;
                        case "Pa_per":
                            result = "নাড়িয়েছিলাম";
                            break;
                        case "Pa_per_con":
                            result = "নাড়াচ্ছিলাম";
                            break;
                        case "F_in":
                            result = "নাড়াবো";
                            break;
                        case "F_con":
                            result = "নাড়াতে থাকব";
                            break;
                        case "F_per":
                            result = "নাড়াবো";
                            break;
                        case "F_per_con":
                            result = "নাড়াতে থাকব";
                            break;
                        default: break;
                    }
                }
                else if (verb.Contains("নাচা") || verb == "নাচা")
                {
                    switch (verb_tag)
                    {
                        case "P_in":
                            result = "নাচি";
                            break;
                        case "P_con":
                            result = "নাচতেছি";
                            break;
                        case "P_per":
                            result = "নেচেছি";
                            break;
                        case "P_per_con":
                            result = "নাচতেছি";
                            break;
                        case "Pa_in":
                            result = "নেচেছিলাম";
                            break;
                        case "Pa_con":
                            result = "নাচতেছিলাম";
                            break;
                        case "Pa_per":
                            result = "নেচেছিলাম";
                            break;
                        case "Pa_per_con":
                            result = "নাচতেছিলাম";
                            break;
                        case "F_in":
                            result = "নাচবো";
                            break;
                        case "F_con":
                            result = "নাচতে থাকব";
                            break;
                        case "F_per":
                            result = "নাচবো";
                            break;
                        case "F_per_con":
                            result = "নাচতে থাকব";
                            break;
                        default: break;
                    }
                }
                else if (verb.Contains("শেখান") || verb == "শেখান")
                {
                    switch (verb_tag)
                    {
                        case "P_in":
                            result = "শিখাই";
                            break;
                        case "P_con":
                            result = "শেখাচ্ছি";
                            break;
                        case "P_per":
                            result = "শিখিয়েছি";
                            break;
                        case "P_per_con":
                            result = "শেখাচ্ছি";
                            break;
                        case "Pa_in":
                            result = "শিখিয়েছিলাম";
                            break;
                        case "Pa_con":
                            result = "শেখাচ্ছিলাম";
                            break;
                        case "Pa_per":
                            result = "শিখিয়েছিলাম";
                            break;
                        case "Pa_per_con":
                            result = "শেখাচ্ছিলাম";
                            break;
                        case "F_in":
                            result = "শেখাবো";
                            break;
                        case "F_con":
                            result = "নাচতে থাকব";
                            break;
                        case "F_per":
                            result = "শেখাবো";
                            break;
                        case "F_per_con":
                            result = "নাচতে থাকব";
                            break;
                        default: break;
                    }
                }
                else if (verb.Contains("শোনা") || verb == "শোনা")
                {
                    switch (verb_tag)
                    {
                        case "P_in":
                            result = "শুনি";
                            break;
                        case "P_con":
                            result = "শুনছি";
                            break;
                        case "P_per":
                            result = "শুনেছি";
                            break;
                        case "P_per_con":
                            result = "শুনছি";
                            break;
                        case "Pa_in":
                            result = "শুনেছিলাম";
                            break;
                        case "Pa_con":
                            result = "শুনছিলাম";
                            break;
                        case "Pa_per":
                            result = "শুনেছিলাম";
                            break;
                        case "Pa_per_con":
                            result = "শুনছিলাম";
                            break;
                        case "F_in":
                            result = "শুনবো";
                            break;
                        case "F_con":
                            result = "শুনতে থাকব";
                            break;
                        case "F_per":
                            result = "শুনবো";
                            break;
                        case "F_per_con":
                            result = "শুনতে থাকব";
                            break;
                        default: break;
                    }
                }
                else if (verb.Contains("শেখা") || verb == "শেখা")
                {
                    switch (verb_tag)
                    {
                        case "P_in":
                            result = "শিখি";
                            break;
                        case "P_con":
                            result = "শিখছি";
                            break;
                        case "P_per":
                            result = "শিখেছি";
                            break;
                        case "P_per_con":
                            result = "শিখছি";
                            break;
                        case "Pa_in":
                            result = "শিখেছিলাম";
                            break;
                        case "Pa_con":
                            result = "শিখছিলাম";
                            break;
                        case "Pa_per":
                            result = "শিখেছিলাম";
                            break;
                        case "Pa_per_con":
                            result = "শিখছিলাম";
                            break;
                        case "F_in":
                            result = "শিখবো";
                            break;
                        case "F_con":
                            result = "শিখতে থাকব";
                            break;
                        case "F_per":
                            result = "শিখবো";
                            break;
                        case "F_per_con":
                            result = "শিখতে থাকব";
                            break;
                        default: break;
                    }
                }
                else if (verb.Contains("সাজান") || verb == "সাজান")
                {
                    switch (verb_tag)
                    {
                        case "P_in":
                            result = "সাজাবো";
                            break;
                        case "P_con":
                            result = "সাজাচ্ছি";
                            break;
                        case "P_per":
                            result = "সাজিয়েছি";
                            break;
                        case "P_per_con":
                            result = "সাজাচ্ছি";
                            break;
                        case "Pa_in":
                            result = "সাজিয়েছিলাম";
                            break;
                        case "Pa_con":
                            result = "সাজাচ্ছিলাম";
                            break;
                        case "Pa_per":
                            result = "সাজিয়েছিলাম";
                            break;
                        case "Pa_per_con":
                            result = "সাজাচ্ছিলাম";
                            break;
                        case "F_in":
                            result = "সাজাবো";
                            break;
                        case "F_con":
                            result = "সাজাতে থাকব";
                            break;
                        case "F_per":
                            result = "সাজাবো";
                            break;
                        case "F_per_con":
                            result = "সাজাতে থাকব";
                            break;
                        default: break;
                    }
                }
                else if (verb.Contains("শুকান") || verb == "শুকান")
                {
                    switch (verb_tag)
                    {
                        case "P_in":
                            result = "শুকাই";
                            break;
                        case "P_con":
                            result = "শুকাচ্ছি";
                            break;
                        case "P_per":
                            result = "শুকিয়েছি";
                            break;
                        case "P_per_con":
                            result = "শুকাচ্ছি";
                            break;
                        case "Pa_in":
                            result = "শুকিয়েছিলাম";
                            break;
                        case "Pa_con":
                            result = "শুকাচ্ছিলাম";
                            break;
                        case "Pa_per":
                            result = "শুকিয়েছিলাম";
                            break;
                        case "Pa_per_con":
                            result = "শুকাচ্ছিলাম";
                            break;
                        case "F_in":
                            result = "শুকাবো";
                            break;
                        case "F_con":
                            result = "শুকাতে থাকব";
                            break;
                        case "F_per":
                            result = "শুকাবো";
                            break;
                        case "F_per_con":
                            result = "শুকাতে থাকব";
                            break;
                        default: break;
                    }
                }
                else if (verb.Contains("শিখান") || verb == "শিখান")
                {
                    switch (verb_tag)
                    {
                        case "P_in":
                            result = "শিখাই";
                            break;
                        case "P_con":
                            result = "শেখাচ্ছি";
                            break;
                        case "P_per":
                            result = "শিখিয়েছি";
                            break;
                        case "P_per_con":
                            result = "শেখাচ্ছি";
                            break;
                        case "Pa_in":
                            result = "শিখিয়েছিলাম";
                            break;
                        case "Pa_con":
                            result = "শেখাচ্ছিলাম";
                            break;
                        case "Pa_per":
                            result = "শিখিয়েছিলাম";
                            break;
                        case "Pa_per_con":
                            result = "শেখাচ্ছিলাম";
                            break;
                        case "F_in":
                            result = "শেখাবো";
                            break;
                        case "F_con":
                            result = "শেখাতে থাকব";
                            break;
                        case "F_per":
                            result = "শেখাবো";
                            break;
                        case "F_per_con":
                            result = "শেখাতে থাকব";
                            break;
                        default: break;
                    }
                }
                else if (verb.Contains("উঠা") || verb == "উঠা")
                {
                    switch (verb_tag)
                    {
                        case "P_in":
                            result = "উঠি";
                            break;
                        case "P_con":
                            result = "উঠছি";
                            break;
                        case "P_per":
                            result = "উঠেছি";
                            break;
                        case "P_per_con":
                            result = "উঠছি";
                            break;
                        case "Pa_in":
                            result = "উঠেছিলাম";
                            break;
                        case "Pa_con":
                            result = "উঠছিলাম";
                            break;
                        case "Pa_per":
                            result = "উঠেছিলাম";
                            break;
                        case "Pa_per_con":
                            result = "উঠছিলাম";
                            break;
                        case "F_in":
                            result = "উঠবো";
                            break;
                        case "F_con":
                            result = "উঠতে থাকব";
                            break;
                        case "F_per":
                            result = "উঠবো";
                            break;
                        case "F_per_con":
                            result = "উঠতে থাকব";
                            break;
                        default: break;
                    }
                }
                else if (verb.Contains("ওঠা") || verb == "ওঠা")
                {
                    switch (verb_tag)
                    {
                        case "P_in":
                            result = "ওঠি";
                            break;
                        case "P_con":
                            result = "ওঠছি";
                            break;
                        case "P_per":
                            result = "ওঠেছি";
                            break;
                        case "P_per_con":
                            result = "ওঠছি";
                            break;
                        case "Pa_in":
                            result = "ওঠেছিলাম";
                            break;
                        case "Pa_con":
                            result = "ওঠছিলাম";
                            break;
                        case "Pa_per":
                            result = "ওঠেছিলাম";
                            break;
                        case "Pa_per_con":
                            result = "ওঠছিলাম";
                            break;
                        case "F_in":
                            result = "ওঠবো";
                            break;
                        case "F_con":
                            result = "ওঠতে থাকব";
                            break;
                        case "F_per":
                            result = "ওঠবো";
                            break;
                        case "F_per_con":
                            result = "ওঠতে থাকব";
                            break;
                        default: break;
                    }
                }
                else if (verb.Contains("উঠান") || verb == "উঠান")
                {
                    switch (verb_tag)
                    {
                        case "P_in":
                            result = "উঠাই";
                            break;
                        case "P_con":
                            result = "উঠাচ্ছি";
                            break;
                        case "P_per":
                            result = "উঠিয়েছি";
                            break;
                        case "P_per_con":
                            result = "উঠাচ্ছি";
                            break;
                        case "Pa_in":
                            result = "উঠিয়েছিলাম";
                            break;
                        case "Pa_con":
                            result = "উঠাচ্ছিলাম";
                            break;
                        case "Pa_per":
                            result = "উঠিয়েছিলাম";
                            break;
                        case "Pa_per_con":
                            result = "উঠাচ্ছিলাম";
                            break;
                        case "F_in":
                            result = "উঠাবো";
                            break;
                        case "F_con":
                            result = "উঠাতে থাকব";
                            break;
                        case "F_per":
                            result = "উঠাবো";
                            break;
                        case "F_per_con":
                            result = "উঠাতে থাকব";
                            break;
                        default: break;
                    }
                }
                else if (verb.Contains("উড়া") || verb == "উড়া")
                {
                    switch (verb_tag)
                    {
                        case "P_in":
                            result = "উড়ি";
                            break;
                        case "P_con":
                            result = "উড়ছি";
                            break;
                        case "P_per":
                            result = "উড়েছি";
                            break;
                        case "P_per_con":
                            result = "উড়ছি";
                            break;
                        case "Pa_in":
                            result = "উড়েছিলাম";
                            break;
                        case "Pa_con":
                            result = "উড়ছিলাম";
                            break;
                        case "Pa_per":
                            result = "উড়েছিলাম";
                            break;
                        case "Pa_per_con":
                            result = "উড়ছিলাম";
                            break;
                        case "F_in":
                            result = "উড়বো";
                            break;
                        case "F_con":
                            result = "উড়তে থাকব";
                            break;
                        case "F_per":
                            result = "উড়বো";
                            break;
                        case "F_per_con":
                            result = "উড়তে থাকব";
                            break;
                        default: break;
                    }
                }
                else if (verb.Contains("মেটান") || verb == "মেটান")
                {
                    switch (verb_tag)
                    {
                        case "P_in":
                            result = "মেটাই";
                            break;
                        case "P_con":
                            result = "মেটাচ্ছি";
                            break;
                        case "P_per":
                            result = "মিটিয়েছি";
                            break;
                        case "P_per_con":
                            result = "মেটাচ্ছি";
                            break;
                        case "Pa_in":
                            result = "মিটিয়েছিলাম";
                            break;
                        case "Pa_con":
                            result = "মেটাচ্ছিলাম";
                            break;
                        case "Pa_per":
                            result = "মিটিয়েছিলাম";
                            break;
                        case "Pa_per_con":
                            result = "মেটাচ্ছিলাম";
                            break;
                        case "F_in":
                            result = "মেটাবো";
                            break;
                        case "F_con":
                            result = "মেটাতে থাকব";
                            break;
                        case "F_per":
                            result = "মেটাবো";
                            break;
                        case "F_per_con":
                            result = "মেটাতে থাকব";
                            break;
                        default: break;
                    }
                }
                else
                { }
                //switch (verb_tag)
                //{
                //    case "P_in" :break;
                //    case "P_con" : break;
                //    case "P_per": break;
                //    case "P_per_con": break;
                //}
            }
            else if (subject == "You")
            {
                if (verb.Contains("আনা") || verb == "আনা")
                {
                    switch (verb_tag)
                    {
                        case "P_in":
                            result = "আনো ";
                            break;
                        case "P_con":
                            result = "আনছো";
                            break;
                        case "P_per":
                            result = "এনেছো";
                            break;
                        case "P_per_con":
                            result = "আনছো";
                            break;
                        case "Pa_in":
                            result = "এনেছিলে";
                            break;
                        case "Pa_con":
                            result = "আনছিলে";
                            break;
                        case "Pa_per":
                            result = "এনেছিলে";
                            break;
                        case "Pa_per_con":
                            result = "আনছিলে";
                            break;
                        case "F_in":
                            result = "আনবে";
                            break;
                        case "F_con":
                            result = "আনতে থাকবে";
                            break;
                        case "F_per":
                            result = "আনবে";
                            break;
                        case "F_per_con":
                            result = "আনতে থাকবো";
                            break;
                        default: break;
                    }
                }
                else if (verb.Contains("আঁকা") || verb == "আঁকা")
                {
                    switch (verb_tag)
                    {
                        case "P_in":
                            result = "আঁকো";
                            break;
                        case "P_con":
                            result = "আঁকছো";
                            break;
                        case "P_per":
                            result = "এঁকেছো";
                            break;
                        case "P_per_con":
                            result = "আঁকছো";
                            break;
                        case "Pa_in":
                            result = "এঁকেছিলে";
                            break;
                        case "Pa_con":
                            result = "আঁকছিলে";
                            break;
                        case "Pa_per":
                            result = "এঁকেছিলে";
                            break;
                        case "Pa_per_con":
                            result = "আঁকছিলে";
                            break;
                        case "F_in":
                            result = "আঁকবে";
                            break;
                        case "F_con":
                            result = "আঁকতে থাকবে";
                            break;
                        case "F_per":
                            result = "আঁকবে";
                            break;
                        case "F_per_con":
                            result = "আঁকতে থাকবে";
                            break;
                        default: break;
                    }
                }
                else if (verb.Contains("বাঁধা") || verb == "বাঁধা")
                {
                    switch (verb_tag)
                    {
                        case "P_in":
                            result = "বাধো";
                            break;
                        case "P_con":
                            result = "বাঁধছো";
                            break;
                        case "P_per":
                            result = "বেঁধেছো";
                            break;
                        case "P_per_con":
                            result = "বাঁধছো";
                            break;
                        case "Pa_in":
                            result = "বেঁধেছিলে";
                            break;
                        case "Pa_con":
                            result = "বাঁধছিলে";
                            break;
                        case "Pa_per":
                            result = "বেঁধেছিলে";
                            break;
                        case "Pa_per_con":
                            result = "বাঁধছিলে";
                            break;
                        case "F_in":
                            result = "বাধবে";
                            break;
                        case "F_con":
                            result = "বাঁধতে থাকবে";
                            break;
                        case "F_per":
                            result = "বাধবে";
                            break;
                        case "F_per_con":
                            result = "বাঁধতে থাকবে";
                            break;
                        default: break;
                    }
                }
                else if (verb.Contains("বসা") || verb == "বসা")
                {
                    switch (verb_tag)
                    {
                        case "P_in":
                            result = "বসো";
                            break;
                        case "P_con":
                            result = "বসছো";
                            break;
                        case "P_per":
                            result = "বসেছো";
                            break;
                        case "P_per_con":
                            result = "বসছো";
                            break;
                        case "Pa_in":
                            result = "বসেছিলে";
                            break;
                        case "Pa_con":
                            result = "বসছিলে";
                            break;
                        case "Pa_per":
                            result = "বসেছিলে";
                            break;
                        case "Pa_per_con":
                            result = "বসছিলে";
                            break;
                        case "F_in":
                            result = "বসবে";
                            break;
                        case "F_con":
                            result = "বসতে থাকবে";
                            break;
                        case "F_per":
                            result = "বসবে";
                            break;
                        case "F_per_con":
                            result = "বসতে থাকবে";
                            break;
                        default: break;
                    }
                }
                else if (verb.Contains("বসান") || verb == "বসান")
                {
                    switch (verb_tag)
                    {
                        case "P_in":
                            result = "বসাও";
                            break;
                        case "P_con":
                            result = "বসাচ্ছো";
                            break;
                        case "P_per":
                            result = "বসিয়েছো";
                            break;
                        case "P_per_con":
                            result = "বসাচ্ছো";
                            break;
                        case "Pa_in":
                            result = "বসিয়েছিলে";
                            break;
                        case "Pa_con":
                            result = "বসাচ্ছিলে";
                            break;
                        case "Pa_per":
                            result = "বসিয়েছিলে";
                            break;
                        case "Pa_per_con":
                            result = "বসাচ্ছিলে";
                            break;
                        case "F_in":
                            result = "বসাবে";
                            break;
                        case "F_con":
                            result = "বসাতে থাকবে";
                            break;
                        case "F_per":
                            result = "বসাবে";
                            break;
                        case "F_per_con":
                            result = "বসাতে থাকবে";
                            break;
                        default: break;
                    }
                }
                else if (verb.Contains("বলা") || verb == "বলা")
                {
                    switch (verb_tag)
                    {
                        case "P_in":
                            result = "বলো";
                            break;
                        case "P_con":
                            result = "বলছো";
                            break;
                        case "P_per":
                            result = "বলেছো";
                            break;
                        case "P_per_con":
                            result = "বলছো";
                            break;
                        case "Pa_in":
                            result = "বলেছিলে";
                            break;
                        case "Pa_con":
                            result = "বলছিলে";
                            break;
                        case "Pa_per":
                            result = "বলেছিলে";
                            break;
                        case "Pa_per_con":
                            result = "বলছিলে";
                            break;
                        case "F_in":
                            result = "বলবে";
                            break;
                        case "F_con":
                            result = "বলতে থাকবে";
                            break;
                        case "F_per":
                            result = "বলবে";
                            break;
                        case "F_per_con":
                            result = "বলতে থাকবে";
                            break;
                        default: break;
                    }
                }
                else if (verb.Contains("বানান") || verb == "বানান")
                {
                    switch (verb_tag)
                    {
                        case "P_in":
                            result = "বানাও";
                            break;
                        case "P_con":
                            result = "বানাচ্ছো";
                            break;
                        case "P_per":
                            result = "বানিয়েছো ";
                            break;
                        case "P_per_con":
                            result = "বানাচ্ছো";
                            break;
                        case "Pa_in":
                            result = "বানিয়েছিলে";
                            break;
                        case "Pa_con":
                            result = "বানাচ্ছিলে";
                            break;
                        case "Pa_per":
                            result = "বানিয়েছিলে";
                            break;
                        case "Pa_per_con":
                            result = "বানাচ্ছিলে";
                            break;
                        case "F_in":
                            result = "বানাবে";
                            break;
                        case "F_con":
                            result = "বানাতে থাকবে";
                            break;
                        case "F_per":
                            result = "বানাবে";
                            break;
                        case "F_per_con":
                            result = "বানাতে থাকবে";
                            break;
                        default: break;
                    }
                }
                else if (verb.Contains("বাড়ান") || verb == "বাড়ান")
                {
                    switch (verb_tag)
                    {
                        case "P_in":
                            result = "বাড়াও";
                            break;
                        case "P_con":
                            result = "বাড়াচ্ছো";
                            break;
                        case "P_per":
                            result = "বাড়িয়েছো";
                            break;
                        case "P_per_con":
                            result = "বাড়াচ্ছো";
                            break;
                        case "Pa_in":
                            result = "বাড়িয়েছিলে";
                            break;
                        case "Pa_con":
                            result = "বাড়াচ্ছিলে";
                            break;
                        case "Pa_per":
                            result = "বাড়িয়েছিলে";
                            break;
                        case "Pa_per_con":
                            result = "বাড়াচ্ছিলে";
                            break;
                        case "F_in":
                            result = "বাড়াবে";
                            break;
                        case "F_con":
                            result = "বাড়াতে থাকবে";
                            break;
                        case "F_per":
                            result = "বাড়াবে";
                            break;
                        case "F_per_con":
                            result = "বাড়াতে থাকবে";
                            break;
                        default: break;
                    }
                }
                else if (verb.Contains("বোঝানো") || verb == "বোঝানো")
                {
                    switch (verb_tag)
                    {
                        case "P_in":
                            result = "বুঝায়";
                            break;
                        case "P_con":
                            result = "বুঝাচ্ছে";
                            break;
                        case "P_per":
                            result = "বুঝিয়েছে";
                            break;
                        case "P_per_con":
                            result = "বুঝাচ্ছে";
                            break;
                        case "Pa_in":
                            result = "বুঝিয়েছিলো";
                            break;
                        case "Pa_con":
                            result = "বুঝাচ্ছিলো";
                            break;
                        case "Pa_per":
                            result = "বুঝিয়েছিলো";
                            break;
                        case "Pa_per_con":
                            result = "বুঝাচ্ছিলো";
                            break;
                        case "F_in":
                            result = "বুঝাবে";
                            break;
                        case "F_con":
                            result = "বোঝাতে থাকবে";
                            break;
                        case "F_per":
                            result = "বুঝাবে";
                            break;
                        case "F_per_con":
                            result = "বোঝাতে থাকবে";
                            break;
                        default: break;
                    }
                }
                else if (verb.Contains("বাজান") || verb == "বাজান")
                {
                    switch (verb_tag)
                    {
                        case "P_in":
                            result = "বাজাও";
                            break;
                        case "P_con":
                            result = "বাজাচ্ছো";
                            break;
                        case "P_per":
                            result = "বাজিয়েছো";
                            break;
                        case "P_per_con":
                            result = "বাজাচ্ছো";
                            break;
                        case "Pa_in":
                            result = "বাজিয়েছিলে";
                            break;
                        case "Pa_con":
                            result = "বাজাচ্ছিলে";
                            break;
                        case "Pa_per":
                            result = "বাজিয়েছিলে";
                            break;
                        case "Pa_per_con":
                            result = "বাজাচ্ছিলে";
                            break;
                        case "F_in":
                            result = "বাজাবে";
                            break;
                        case "F_con":
                            result = "বাজাতে থাকবে";
                            break;
                        case "F_per":
                            result = "বাজাবে";
                            break;
                        case "F_per_con":
                            result = "বাজাতে থাকবে";
                            break;
                        default: break;
                    }
                }
                else if (verb.Contains("চাওয়া") || verb == "চাওয়া")
                {
                    switch (verb_tag)
                    {
                        case "P_in":
                            result = "চাও";
                            break;
                        case "P_con":
                            result = "চাচ্ছো";
                            break;
                        case "P_per":
                            result = "চেয়েছো";
                            break;
                        case "P_per_con":
                            result = "চাচ্ছো";
                            break;
                        case "Pa_in":
                            result = "চেয়েছিলে";
                            break;
                        case "Pa_con":
                            result = "চাচ্ছিলে";
                            break;
                        case "Pa_per":
                            result = "চেয়েছিলে";
                            break;
                        case "Pa_per_con":
                            result = "চাচ্ছিলে";
                            break;
                        case "F_in":
                            result = "চাইবে";
                            break;
                        case "F_con":
                            result = "চাইতে থাকবে";
                            break;
                        case "F_per":
                            result = "চাইবে";
                            break;
                        case "F_per_con":
                            result = "চাইতে থাকবে";
                            break;
                        default: break;
                    }
                }
                else if (verb.Contains("চাটা") || verb == "চাটা")
                {
                    switch (verb_tag)
                    {
                        case "P_in":
                            result = "চাটো";
                            break;
                        case "P_con":
                            result = "চাটছো";
                            break;
                        case "P_per":
                            result = "চেটেছো";
                            break;
                        case "P_per_con":
                            result = "চাটছো";
                            break;
                        case "Pa_in":
                            result = "চেঁটেছিলে";
                            break;
                        case "Pa_con":
                            result = "চাটছিলে";
                            break;
                        case "Pa_per":
                            result = "চেঁটেছিলে";
                            break;
                        case "Pa_per_con":
                            result = "চাটছিলে";
                            break;
                        case "F_in":
                            result = "চাটবে";
                            break;
                        case "F_con":
                            result = "চাটতে থাকবে";
                            break;
                        case "F_per":
                            result = "চাটবে";
                            break;
                        case "F_per_con":
                            result = "চাটতে থাকবে";
                            break;
                        default: break;
                    }
                }
                else if (verb.Contains("ছড়ান") || verb == "ছড়ান")
                {
                    switch (verb_tag)
                    {
                        case "P_in":
                            result = "ছড়াও";
                            break;
                        case "P_con":
                            result = "ছড়াচ্ছো";
                            break;
                        case "P_per":
                            result = "ছড়িয়েছো";
                            break;
                        case "P_per_con":
                            result = "ছড়াচ্ছো";
                            break;
                        case "Pa_in":
                            result = "ছড়িয়েছিলে";
                            break;
                        case "Pa_con":
                            result = "ছড়াচ্ছিলে";
                            break;
                        case "Pa_per":
                            result = "ছড়িয়েছিলে";
                            break;
                        case "Pa_per_con":
                            result = "ছড়াচ্ছিলে";
                            break;
                        case "F_in":
                            result = "ছড়াবে";
                            break;
                        case "F_con":
                            result = "ছড়াতে থাকবে";
                            break;
                        case "F_per":
                            result = "ছড়াবে";
                            break;
                        case "F_per_con":
                            result = "ছড়াতে থাকবে";
                            break;
                        default: break;
                    }
                }
                else if (verb.Contains("চেনা") || verb == "চেনা")
                {
                    switch (verb_tag)
                    {
                        case "P_in":
                            result = "চিনো";
                            break;
                        case "P_con":
                            result = "চিনছো";
                            break;
                        case "P_per":
                            result = "চিনেছো";
                            break;
                        case "P_per_con":
                            result = "চিনছো";
                            break;
                        case "Pa_in":
                            result = "চিনেছিলে";
                            break;
                        case "Pa_con":
                            result = "চিনতেছিলে";
                            break;
                        case "Pa_per":
                            result = "চিনেছিলে";
                            break;
                        case "Pa_per_con":
                            result = "চিনতেছিলে";
                            break;
                        case "F_in":
                            result = "চিনবে";
                            break;
                        case "F_con":
                            result = "চিনতে থাকবে";
                            break;
                        case "F_per":
                            result = "চিনবে";
                            break;
                        case "F_per_con":
                            result = "চিনতে থাকবে";
                            break;
                        default: break;
                    }
                }
                else if (verb.Contains("চিবান") || verb == "চিবান")
                {
                    switch (verb_tag)
                    {
                        case "P_in":
                            result = "চিবাও";
                            break;
                        case "P_con":
                            result = "চিবাচ্ছো";
                            break;
                        case "P_per":
                            result = "চিবিয়েছো";
                            break;
                        case "P_per_con":
                            result = "চিবাচ্ছো";
                            break;
                        case "Pa_in":
                            result = "চিবিয়েছিলে";
                            break;
                        case "Pa_con":
                            result = "চিবাচ্ছিলে";
                            break;
                        case "Pa_per":
                            result = "চিবিয়েছিলে";
                            break;
                        case "Pa_per_con":
                            result = "চিবাচ্ছিলে";
                            break;
                        case "F_in":
                            result = "চিবাবে";
                            break;
                        case "F_con":
                            result = "চিবাতে থাকবে";
                            break;
                        case "F_per":
                            result = "চিবাবে";
                            break;
                        case "F_per_con":
                            result = "চিবাতে থাকবে";
                            break;
                        default: break;
                    }
                }
                else if (verb.Contains("চালান") || verb == "চালান")
                {
                    switch (verb_tag)
                    {
                        case "P_in":
                            result = "চালাও";
                            break;
                        case "P_con":
                            result = "চালাচ্ছো";
                            break;
                        case "P_per":
                            result = "চালিয়েছো";
                            break;
                        case "P_per_con":
                            result = "চালাচ্ছো";
                            break;
                        case "Pa_in":
                            result = "চালিয়েছিলে";
                            break;
                        case "Pa_con":
                            result = "চালাচ্ছিলে";
                            break;
                        case "Pa_per":
                            result = "চালিয়েছিলে";
                            break;
                        case "Pa_per_con":
                            result = "চালাচ্ছিলে";
                            break;
                        case "F_in":
                            result = "চালাবে";
                            break;
                        case "F_con":
                            result = "চালাতে থাকবে";
                            break;
                        case "F_per":
                            result = "চালাবে";
                            break;
                        case "F_per_con":
                            result = "চালাতে থাকবে";
                            break;
                        default: break;
                    }
                }
                else if (verb.Contains("দেয়া") || verb == "দেয়া")
                {
                    switch (verb_tag)
                    {
                        case "P_in":
                            result = "দেও";
                            break;
                        case "P_con":
                            result = "দিচ্ছো";
                            break;
                        case "P_per":
                            result = "দিয়েছো";
                            break;
                        case "P_per_con":
                            result = "দিচ্ছো";
                            break;
                        case "Pa_in":
                            result = "দিয়েছিলে";
                            break;
                        case "Pa_con":
                            result = "দিচ্ছিলে";
                            break;
                        case "Pa_per":
                            result = "দিয়েছিলে";
                            break;
                        case "Pa_per_con":
                            result = "দিচ্ছিলে";
                            break;
                        case "F_in":
                            result = "দিবে";
                            break;
                        case "F_con":
                            result = "দিতে থাকবে";
                            break;
                        case "F_per":
                            result = "দিবে";
                            break;
                        case "F_per_con":
                            result = "দিতে থাকবে";
                            break;
                        default: break;
                    }
                }
                else if (verb.Contains("দেখা") || verb == "দেখা")
                {
                    switch (verb_tag)
                    {
                        case "P_in":
                            result = "দেখো";
                            break;
                        case "P_con":
                            result = "দেখছো";
                            break;
                        case "P_per":
                            result = "দেখেছো";
                            break;
                        case "P_per_con":
                            result = "দেখছো";
                            break;
                        case "Pa_in":
                            result = "দেখেছিলে";
                            break;
                        case "Pa_con":
                            result = "দেখছিলে";
                            break;
                        case "Pa_per":
                            result = "দেখেছিলে";
                            break;
                        case "Pa_per_con":
                            result = "দেখছিলে";
                            break;
                        case "F_in":
                            result = "দেখবে";
                            break;
                        case "F_con":
                            result = "দেখতে থাকবে";
                            break;
                        case "F_per":
                            result = "দেখবে";
                            break;
                        case "F_per_con":
                            result = "দেখতে থাকবে";
                            break;
                        default: break;
                    }
                }
                else if (verb.Contains("দাঁড়ান") || verb == "দাঁড়ান")
                {
                    switch (verb_tag)
                    {
                        case "P_in":
                            result = "দাঁড়াও";
                            break;
                        case "P_con":
                            result = "দাঁড়াচ্ছো";
                            break;
                        case "P_per":
                            result = "দাঁড়িয়েছো";
                            break;
                        case "P_per_con":
                            result = "দাঁড়াচ্ছো";
                            break;
                        case "Pa_in":
                            result = "দাঁড়িয়েছিলে";
                            break;
                        case "Pa_con":
                            result = "দাঁড়াচ্ছিলে";
                            break;
                        case "Pa_per":
                            result = "দাঁড়িয়েছিলে";
                            break;
                        case "Pa_per_con":
                            result = "দাঁড়াচ্ছিলে";
                            break;
                        case "F_in":
                            result = "দাঁড়াবে";
                            break;
                        case "F_con":
                            result = "দাঁড়িয়ে থাকবে";
                            break;
                        case "F_per":
                            result = "দাঁড়াবে";
                            break;
                        case "F_per_con":
                            result = "দাঁড়িয়ে থাকবে";
                            break;
                        default: break;
                    }
                }
                else if (verb.Contains("দেখানো") || verb == "দেখানো")
                {
                    switch (verb_tag)
                    {
                        case "P_in":
                            result = "দেখাও";
                            break;
                        case "P_con":
                            result = "দেখাচ্ছো";
                            break;
                        case "P_per":
                            result = "দেখিয়েছো";
                            break;
                        case "P_per_con":
                            result = "দেখাচ্ছো";
                            break;
                        case "Pa_in":
                            result = "দেখিয়েছিলে";
                            break;
                        case "Pa_con":
                            result = "দেখাচ্ছিলে";
                            break;
                        case "Pa_per":
                            result = "দেখিয়েছিলে";
                            break;
                        case "Pa_per_con":
                            result = "দেখাচ্ছিলে";
                            break;
                        case "F_in":
                            result = "দেখাবে";
                            break;
                        case "F_con":
                            result = "দেখাইতে থাকবে";
                            break;
                        case "F_per":
                            result = "দেখাবে";
                            break;
                        case "F_per_con":
                            result = "দেখাইতে থাকবে";
                            break;
                        default: break;
                    }
                }
                else if (verb.Contains("ঢাকা") || verb == "ঢাকা")
                {
                    switch (verb_tag)
                    {
                        case "P_in":
                            result = "ঢাকো";
                            break;
                        case "P_con":
                            result = "ঢাকছো";
                            break;
                        case "P_per":
                            result = "ঢেকেছো";
                            break;
                        case "P_per_con":
                            result = "ঢাকছো";
                            break;
                        case "Pa_in":
                            result = "ঢেকেছিলে";
                            break;
                        case "Pa_con":
                            result = "ঢাকছিলে";
                            break;
                        case "Pa_per":
                            result = "ঢেকেছিলে";
                            break;
                        case "Pa_per_con":
                            result = "ঢাকছিলে";
                            break;
                        case "F_in":
                            result = "ঢাকবে";
                            break;
                        case "F_con":
                            result = "ঢাকতে থাকবে";
                            break;
                        case "F_per":
                            result = "ঢাকবে";
                            break;
                        case "F_per_con":
                            result = "ঢাকতে থাকবে";
                            break;
                        default: break;
                    }
                }
                else if (verb.Contains("ডাকা") || verb == "ডাকা")
                {
                    switch (verb_tag)
                    {
                        case "P_in":
                            result = "ডাকো";
                            break;
                        case "P_con":
                            result = "ডাকছো";
                            break;
                        case "P_per":
                            result = "ডেকেছো";
                            break;
                        case "P_per_con":
                            result = "ডাকছো";
                            break;
                        case "Pa_in":
                            result = "ডেকেছিলে";
                            break;
                        case "Pa_con":
                            result = "ডাকছিলে";
                            break;
                        case "Pa_per":
                            result = "ডেকেছিলে";
                            break;
                        case "Pa_per_con":
                            result = "ডাকছিলে";
                            break;
                        case "F_in":
                            result = "ডাকবে";
                            break;
                        case "F_con":
                            result = "ডাকতে থাকবে";
                            break;
                        case "F_per":
                            result = "ডাকবে";
                            break;
                        case "F_per_con":
                            result = "ডাকতে থাকবে";
                            break;
                        default: break;
                    }
                }
                else if (verb.Contains("ধরা") || verb == "ধরা")
                {
                    switch (verb_tag)
                    {
                        case "P_in":
                            result = "ধরো";
                            break;
                        case "P_con":
                            result = "ধরছো";
                            break;
                        case "P_per":
                            result = "ধরেছো";
                            break;
                        case "P_per_con":
                            result = "ধরছো";
                            break;
                        case "Pa_in":
                            result = "ধরেছিলে";
                            break;
                        case "Pa_con":
                            result = "ধরতেছিলে";
                            break;
                        case "Pa_per":
                            result = "ধরেছিলে";
                            break;
                        case "Pa_per_con":
                            result = "ধরতেছিলে";
                            break;
                        case "F_in":
                            result = "ধরবে";
                            break;
                        case "F_con":
                            result = "ধরতে থাকবে";
                            break;
                        case "F_per":
                            result = "ধরবে";
                            break;
                        case "F_per_con":
                            result = "ধরতে থাকবে";
                            break;
                        default: break;
                    }
                }
                else if (verb.Contains("ডিঙ্গান") || verb == "ডিঙ্গান")
                {
                    switch (verb_tag)
                    {
                        case "P_in":
                            result = "ডিঙ্গাও";
                            break;
                        case "P_con":
                            result = "ডিঙ্গাচ্ছো";
                            break;
                        case "P_per":
                            result = "ডিঙিয়েছো";
                            break;
                        case "P_per_con":
                            result = "ডিঙ্গাচ্ছো";
                            break;
                        case "Pa_in":
                            result = "ডিঙ্গিয়েছিলে";
                            break;
                        case "Pa_con":
                            result = "ডিঙ্গাচ্ছিলে";
                            break;
                        case "Pa_per":
                            result = "ডিঙ্গিয়েছিলে";
                            break;
                        case "Pa_per_con":
                            result = "ডিঙ্গাচ্ছিলে";
                            break;
                        case "F_in":
                            result = "ডিঙ্গাবে";
                            break;
                        case "F_con":
                            result = "ডিঙ্গাইতে থাকবে";
                            break;
                        case "F_per":
                            result = "ডিঙ্গাবে";
                            break;
                        case "F_per_con":
                            result = "ডিঙ্গাইতে থাকবে";
                            break;
                        default: break;
                    }
                }
                else if (verb.Contains("ঢোকান") || verb == "ঢোকান")
                {
                    switch (verb_tag)
                    {
                        case "P_in":
                            result = "ঢোকাও";
                            break;
                        case "P_con":
                            result = "ঢুকাচ্ছো";
                            break;
                        case "P_per":
                            result = "ঢুকিয়েছো";
                            break;
                        case "P_per_con":
                            result = "ঢুকাচ্ছো";
                            break;
                        case "Pa_in":
                            result = "ঢুকিয়েছিলে";
                            break;
                        case "Pa_con":
                            result = "ঢুকাচ্ছিলে";
                            break;
                        case "Pa_per":
                            result = "ঢুকিয়েছিলে";
                            break;
                        case "Pa_per_con":
                            result = "ঢুকাচ্ছিলে";
                            break;
                        case "F_in":
                            result = "ঢুকাবে";
                            break;
                        case "F_con":
                            result = "ঢুকাইতে থাকবে";
                            break;
                        case "F_per":
                            result = "ঢুকাবে";
                            break;
                        case "F_per_con":
                            result = "ঢুকাইতে থাকবে";
                            break;
                        default: break;
                    }
                }
                else if (verb.Contains("ফেরা") || verb == "ফেরা")
                {
                    switch (verb_tag)
                    {
                        case "P_in":
                            result = "ফিরো";
                            break;
                        case "P_con":
                            result = "ফিরছো";
                            break;
                        case "P_per":
                            result = "ফিরেছো";
                            break;
                        case "P_per_con":
                            result = "ফিরছো";
                            break;
                        case "Pa_in":
                            result = "ফিরেছিলে";
                            break;
                        case "Pa_con":
                            result = "ফিরতেছিলে";
                            break;
                        case "Pa_per":
                            result = "ফিরেছিলে";
                            break;
                        case "Pa_per_con":
                            result = "ফিরতেছিলে";
                            break;
                        case "F_in":
                            result = "ফিরবে";
                            break;
                        case "F_con":
                            result = "ফিরতে থাকবে";
                            break;
                        case "F_per":
                            result = "ফিরবে";
                            break;
                        case "F_per_con":
                            result = "ফিরতে থাকবে";
                            break;
                        default: break;
                    }
                }
                else if (verb.Contains("ফেলা") || verb == "ফেলা")
                {
                    switch (verb_tag)
                    {
                        case "P_in":
                            result = "ফেলো";
                            break;
                        case "P_con":
                            result = "ফেলছো";
                            break;
                        case "P_per":
                            result = "ফেলেছো";
                            break;
                        case "P_per_con":
                            result = "ফেলছো";
                            break;
                        case "Pa_in":
                            result = "ফেলেছিলে";
                            break;
                        case "Pa_con":
                            result = "ফেলছিলে";
                            break;
                        case "Pa_per":
                            result = "ফেলেছিলে";
                            break;
                        case "Pa_per_con":
                            result = "ফেলছিলে";
                            break;
                        case "F_in":
                            result = "ফেলাবে";
                            break;
                        case "F_con":
                            result = "ফেলতে থাকবে";
                            break;
                        case "F_per":
                            result = "ফেলাবে";
                            break;
                        case "F_per_con":
                            result = "ফেলতে থাকবে";
                            break;
                        default: break;
                    }
                }
                else if (verb.Contains("ফুটান") || verb == "ফুটান")
                {
                    switch (verb_tag)
                    {
                        case "P_in":
                            result = "ফুটাও";
                            break;
                        case "P_con":
                            result = "ফুটাচ্ছো";
                            break;
                        case "P_per":
                            result = "ফুটাইছো";
                            break;
                        case "P_per_con":
                            result = "ফুটাচ্ছো";
                            break;
                        case "Pa_in":
                            result = "ফুটিয়েছিলে";
                            break;
                        case "Pa_con":
                            result = "ফুটাচ্ছিলে";
                            break;
                        case "Pa_per":
                            result = "ফুটিয়েছিলে";
                            break;
                        case "Pa_per_con":
                            result = "ফুটাচ্ছিলে";
                            break;
                        case "F_in":
                            result = "ফুটাবে";
                            break;
                        case "F_con":
                            result = "ফুটাইতে থাকবে";
                            break;
                        case "F_per":
                            result = "ফুটাবে";
                            break;
                        case "F_per_con":
                            result = "ফুটাইতে থাকবে";
                            break;
                        default: break;
                    }
                }
                else if (verb.Contains("ঘটা") || verb == "ঘটা")
                {
                    switch (verb_tag)
                    {
                        case "P_in":
                            result = "ঘটাও";
                            break;
                        case "P_con":
                            result = "ঘটাচ্ছো";
                            break;
                        case "P_per":
                            result = "ঘটাইছো";
                            break;
                        case "P_per_con":
                            result = "ঘটাচ্ছো";
                            break;
                        case "Pa_in":
                            result = "ঘটিয়েছিলে";
                            break;
                        case "Pa_con":
                            result = "ঘটাচ্ছিলে";
                            break;
                        case "Pa_per":
                            result = "ঘটিয়েছিলে";
                            break;
                        case "Pa_per_con":
                            result = "ঘটাচ্ছিলে";
                            break;
                        case "F_in":
                            result = "ঘটাবে";
                            break;
                        case "F_con":
                            result = "ঘটাইতে থাকবে";
                            break;
                        case "F_per":
                            result = "ঘটাবে";
                            break;
                        case "F_per_con":
                            result = "ঘটাইতে থাকবে";
                            break;
                        default: break;
                    }
                }
                else if (verb.Contains("গুটান") || verb == "গুটান")
                {
                    switch (verb_tag)
                    {
                        case "P_in":
                            result = "গুটাও";
                            break;
                        case "P_con":
                            result = "গুটাচ্ছো";
                            break;
                        case "P_per":
                            result = "গুটাইছো";
                            break;
                        case "P_per_con":
                            result = "গুটাচ্ছো";
                            break;
                        case "Pa_in":
                            result = "গুটিয়েছিলে";
                            break;
                        case "Pa_con":
                            result = "গুটাচ্ছিলে";
                            break;
                        case "Pa_per":
                            result = "গুটিয়েছিলে";
                            break;
                        case "Pa_per_con":
                            result = "গুটাচ্ছিলে";
                            break;
                        case "F_in":
                            result = "গুটাবে";
                            break;
                        case "F_con":
                            result = "গুটাইতে থাকবে";
                            break;
                        case "F_per":
                            result = "গুটাবে";
                            break;
                        case "F_per_con":
                            result = "গুটাইতে থাকবে";
                            break;
                        default: break;
                    }
                }
                else if (verb.Contains("ঘুমান") || verb == "ঘুমান")
                {
                    switch (verb_tag)
                    {
                        case "P_in":
                            result = "ঘুমায়";
                            break;
                        case "P_con":
                            result = "ঘুমাও";
                            break;
                        case "P_per":
                            result = "ঘুমাচ্ছো";
                            break;
                        case "P_per_con":
                            result = "ঘুমিয়েছো";
                            break;
                        case "Pa_in":
                            result = "ঘুমিয়েছিলে";
                            break;
                        case "Pa_con":
                            result = "ঘুমাচ্ছিলে";
                            break;
                        case "Pa_per":
                            result = "ঘুমিয়েছিলে";
                            break;
                        case "Pa_per_con":
                            result = "ঘুমাচ্ছিলে";
                            break;
                        case "F_in":
                            result = "ঘুমাবে";
                            break;
                        case "F_con":
                            result = "ঘুমাইতে থাকবে";
                            break;
                        case "F_per":
                            result = "ঘুমাবে";
                            break;
                        case "F_per_con":
                            result = "ঘুমাইতে থাকবে";
                            break;
                        default: break;
                    }
                }
                else if (verb.Contains("গাওয়া") || verb == "গাওয়া")
                {
                    switch (verb_tag)
                    {
                        case "P_in":
                            result = "গাও";
                            break;
                        case "P_con":
                            result = "গাচ্ছো";
                            break;
                        case "P_per":
                            result = "গেয়েছো";
                            break;
                        case "P_per_con":
                            result = "গাচ্ছো";
                            break;
                        case "Pa_in":
                            result = "গেয়েছিলে";
                            break;
                        case "Pa_con":
                            result = "গাচ্ছিলে";
                            break;
                        case "Pa_per":
                            result = "গেয়েছিলে";
                            break;
                        case "Pa_per_con":
                            result = "গাচ্ছিলে";
                            break;
                        case "F_in":
                            result = "গাবে";
                            break;
                        case "F_con":
                            result = "গাইতে থাকবে";
                            break;
                        case "F_per":
                            result = "গাবে";
                            break;
                        case "F_per_con":
                            result = "গাইতে থাকবে";
                            break;
                        default: break;
                    }
                }
                else if (verb.Contains("গোঙান") || verb == "গোঙান")
                {
                    switch (verb_tag)
                    {
                        case "P_in":
                            result = "গোঙাও";
                            break;
                        case "P_con":
                            result = "গুঙ্গাচ্ছো";
                            break;
                        case "P_per":
                            result = "গুঙ্গিয়েছো";
                            break;
                        case "P_per_con":
                            result = "গুঙ্গাচ্ছো";
                            break;
                        case "Pa_in":
                            result = "গুঙিয়েছিলে";
                            break;
                        case "Pa_con":
                            result = "গুঙ্গাচ্ছিলে";
                            break;
                        case "Pa_per":
                            result = "গুঙিয়েছিলে";
                            break;
                        case "Pa_per_con":
                            result = "গুঙ্গাচ্ছিলে";
                            break;
                        case "F_in":
                            result = "গুঙ্গাবে";
                            break;
                        case "F_con":
                            result = "গুঙ্গাতে থাকবে";
                            break;
                        case "F_per":
                            result = "গুঙ্গাবে";
                            break;
                        case "F_per_con":
                            result = "গুঙ্গাতে থাকবে";
                            break;
                        default: break;
                    }
                }
                else if (verb.Contains("হওয়া") || verb == "হওয়া")
                {
                    switch (verb_tag)
                    {
                        case "P_in":
                            result = "হও";
                            break;
                        case "P_con":
                            result = "হচ্ছো";
                            break;
                        case "P_per":
                            result = "হয়েছো";
                            break;
                        case "P_per_con":
                            result = "হচ্ছো";
                            break;
                        case "Pa_in":
                            result = "হয়েছিলে";
                            break;
                        case "Pa_con":
                            result = "হচ্ছিলে";
                            break;
                        case "Pa_per":
                            result = "হয়েছিলে";
                            break;
                        case "Pa_per_con":
                            result = "হচ্ছিলে";
                            break;
                        case "F_in":
                            result = "হবে";
                            break;
                        case "F_con":
                            result = "হইতে থাকবে";
                            break;
                        case "F_per":
                            result = "হবে";
                            break;
                        case "F_per_con":
                            result = "হইতে থাকবে";
                            break;
                        default: break;
                    }
                }
                else if (verb.Contains("হাসা") || verb == "হাসা")
                {
                    switch (verb_tag)
                    {
                        case "P_in":
                            result = "হাসো";
                            break;
                        case "P_con":
                            result = "হাসছো";
                            break;
                        case "P_per":
                            result = "হেসেছো";
                            break;
                        case "P_per_con":
                            result = "হাসছো";
                            break;
                        case "Pa_in":
                            result = "হেসেছিলে";
                            break;
                        case "Pa_con":
                            result = "হাসছিলে";
                            break;
                        case "Pa_per":
                            result = "হেসেছিলে";
                            break;
                        case "Pa_per_con":
                            result = "হাসছিলে";
                            break;
                        case "F_in":
                            result = "হাসবে";
                            break;
                        case "F_con":
                            result = "হাসতে থাকবে";
                            break;
                        case "F_per":
                            result = "হাসবে";
                            break;
                        case "F_per_con":
                            result = "হাসতে থাকবে";
                            break;
                        default: break;
                    }
                }
                else if (verb.Contains("জানান") || verb == "জানান")
                {
                    switch (verb_tag)
                    {
                        case "P_in":
                            result = "জানাও";
                            break;
                        case "P_con":
                            result = "জানাচ্ছো";
                            break;
                        case "P_per":
                            result = "জানিয়েছো";
                            break;
                        case "P_per_con":
                            result = "জানাচ্ছো";
                            break;
                        case "Pa_in":
                            result = "জানিয়েছিলে";
                            break;
                        case "Pa_con":
                            result = "জানাচ্ছিলে";
                            break;
                        case "Pa_per":
                            result = "জানিয়েছিলে";
                            break;
                        case "Pa_per_con":
                            result = "জানাচ্ছিলে";
                            break;
                        case "F_in":
                            result = "জানাবে";
                            break;
                        case "F_con":
                            result = "জানাইতে থাকবে";
                            break;
                        case "F_per":
                            result = "জানাবে";
                            break;
                        case "F_per_con":
                            result = "জানাইতে থাকবে";
                            break;
                        default: break;
                    }
                }
                else if (verb.Contains("যাওয়া") || verb == "যাওয়া")
                {
                    switch (verb_tag)
                    {
                        case "P_in":
                            result = "যাও";
                            break;
                        case "P_con":
                            result = "যাচ্ছো";
                            break;
                        case "P_per":
                            result = "গিয়েছো";
                            break;
                        case "P_per_con":
                            result = "যাচ্ছো";
                            break;
                        case "Pa_in":
                            result = "গিয়েছিলে";
                            break;
                        case "Pa_con":
                            result = "যাচ্ছিলে";
                            break;
                        case "Pa_per":
                            result = "গিয়েছিলে";
                            break;
                        case "Pa_per_con":
                            result = "যাচ্ছিলে";
                            break;
                        case "F_in":
                            result = "যাবে";
                            break;
                        case "F_con":
                            result = "যাইতে থাকবে";
                            break;
                        case "F_per":
                            result = "যাবে";
                            break;
                        case "F_per_con":
                            result = "যাইতে থাকবে";
                            break;
                        default: break;
                    }
                }
                else if (verb.Contains("জ্বালান") || verb == "জ্বালান")
                {
                    switch (verb_tag)
                    {
                        case "P_in":
                            result = "জ্বালাও";
                            break;
                        case "P_con":
                            result = "জ্বালাচ্ছো";
                            break;
                        case "P_per":
                            result = "জ্বালিয়েছো";
                            break;
                        case "P_per_con":
                            result = "জ্বালাচ্ছো";
                            break;
                        case "Pa_in":
                            result = "জ্বালিয়েছিলে";
                            break;
                        case "Pa_con":
                            result = "জ্বালাচ্ছিলে";
                            break;
                        case "Pa_per":
                            result = "জ্বালিয়েছিলে";
                            break;
                        case "Pa_per_con":
                            result = "জ্বালাচ্ছিলে";
                            break;
                        case "F_in":
                            result = "জ্বালাবে";
                            break;
                        case "F_con":
                            result = "জ্বালাইতে থাকবে";
                            break;
                        case "F_per":
                            result = "জ্বালাবে";
                            break;
                        case "F_per_con":
                            result = "জ্বালাইতে থাকবে";
                            break;
                        default: break;
                    }
                }
                else if (verb.Contains("জাগা") || verb == "জাগা")
                {
                    switch (verb_tag)
                    {
                        case "P_in":
                            result = "জাগো";
                            break;
                        case "P_con":
                            result = "জাগছো";
                            break;
                        case "P_per":
                            result = "জেগেছো";
                            break;
                        case "P_per_con":
                            result = "জাগছো";
                            break;
                        case "Pa_in":
                            result = "জেগেছিলে";
                            break;
                        case "Pa_con":
                            result = "জাগছিলে";
                            break;
                        case "Pa_per":
                            result = "জেগেছিলে";
                            break;
                        case "Pa_per_con":
                            result = "জাগছিলে";
                            break;
                        case "F_in":
                            result = "জাগবে";
                            break;
                        case "F_con":
                            result = "জাগতে থাকবে";
                            break;
                        case "F_per":
                            result = "জাগবে";
                            break;
                        case "F_per_con":
                            result = "জাগতে থাকবে";
                            break;
                        default: break;
                    }
                }
                else if (verb.Contains("ঝাড়া") || verb == "ঝাড়া")
                {
                    switch (verb_tag)
                    {
                        case "P_in":
                            result = "ঝাড়ো";
                            break;
                        case "P_con":
                            result = "ঝাড়ছো";
                            break;
                        case "P_per":
                            result = "ঝেড়েছো";
                            break;
                        case "P_per_con":
                            result = "ঝাড়ছো";
                            break;
                        case "Pa_in":
                            result = "ঝেড়েছিলে";
                            break;
                        case "Pa_con":
                            result = "ঝাড়তেছিলে";
                            break;
                        case "Pa_per":
                            result = "ঝেড়েছিলে";
                            break;
                        case "Pa_per_con":
                            result = "ঝাড়তেছিলে";
                            break;
                        case "F_in":
                            result = "ঝাড়বে";
                            break;
                        case "F_con":
                            result = "ঝাড়তে থাকবে";
                            break;
                        case "F_per":
                            result = "ঝাড়বে";
                            break;
                        case "F_per_con":
                            result = "ঝাড়তে থাকবে";
                            break;
                        default: break;
                    }
                }
                else if (verb.Contains("জন্মান") || verb == "জন্মান")
                {
                    switch (verb_tag)
                    {
                        case "P_in":
                            result = "জন্মাও";
                            break;
                        case "P_con":
                            result = "জন্মাচ্ছো";
                            break;
                        case "P_per":
                            result = "জন্মেছো";
                            break;
                        case "P_per_con":
                            result = "জন্মাচ্ছো";
                            break;
                        case "Pa_in":
                            result = "জন্মেছিলে";
                            break;
                        case "Pa_con":
                            result = "জন্মেতেছিলে";
                            break;
                        case "Pa_per":
                            result = "জন্মেছিলে";
                            break;
                        case "Pa_per_con":
                            result = "জন্মেতেছিলে";
                            break;
                        case "F_in":
                            result = "জন্মাবে";
                            break;
                        case "F_con":
                            result = "জন্মাইতে থাকবে";
                            break;
                        case "F_per":
                            result = "জন্মাবে";
                            break;
                        case "F_per_con":
                            result = "জন্মাইতে থাকবে";
                            break;
                        default: break;
                    }
                }
                else if (verb.Contains("ঝুলান") || verb == "ঝুলান")
                {
                    switch (verb_tag)
                    {
                        case "P_in":
                            result = "ঝুলাও";
                            break;
                        case "P_con":
                            result = "ঝুলাচ্ছো";
                            break;
                        case "P_per":
                            result = "ঝুলিয়েছো";
                            break;
                        case "P_per_con":
                            result = "ঝুলাচ্ছো";
                            break;
                        case "Pa_in":
                            result = "ঝুলিয়েছিলে";
                            break;
                        case "Pa_con":
                            result = "ঝুলাচ্ছিলে";
                            break;
                        case "Pa_per":
                            result = "ঝুলিয়েছিলে";
                            break;
                        case "Pa_per_con":
                            result = "ঝুলাচ্ছিলে";
                            break;
                        case "F_in":
                            result = "ঝুলাবে";
                            break;
                        case "F_con":
                            result = "ঝুলাইতে থাকবে";
                            break;
                        case "F_per":
                            result = "ঝুলাবে";
                            break;
                        case "F_per_con":
                            result = "ঝুলাইতে থাকবে";
                            break;
                        default: break;
                    }
                }
                else if (verb.Contains("করা") || verb == "করা")
                {
                    switch (verb_tag)
                    {
                        case "P_in":
                            result = "করো";
                            break;
                        case "P_con":
                            result = "করছো";
                            break;
                        case "P_per":
                            result = "করেছো";
                            break;
                        case "P_per_con":
                            result = "করছো";
                            break;
                        case "Pa_in":
                            result = "করেছিলে";
                            break;
                        case "Pa_con":
                            result = "করতেছিলে";
                            break;
                        case "Pa_per":
                            result = "করেছিলে";
                            break;
                        case "Pa_per_con":
                            result = "করতেছিলে";
                            break;
                        case "F_in":
                            result = "করবে";
                            break;
                        case "F_con":
                            result = "করতে থাকবে";
                            break;
                        case "F_per":
                            result = "করবে";
                            break;
                        case "F_per_con":
                            result = "করতে থাকবে";
                            break;
                        default: break;
                    }
                }
                else if (verb.Contains("জানা") || verb == "জানা")
                {
                    switch (verb_tag)
                    {
                        case "P_in":
                            result = "জানো";
                            break;
                        case "P_con":
                            result = "জানছো";
                            break;
                        case "P_per":
                            result = "জেনেছো";
                            break;
                        case "P_per_con":
                            result = "জানছো";
                            break;
                        case "Pa_in":
                            result = "জেনেছিলে";
                            break;
                        case "Pa_con":
                            result = "জানতেছিলে";
                            break;
                        case "Pa_per":
                            result = "জেনেছিলে";
                            break;
                        case "Pa_per_con":
                            result = "জানতেছিলে";
                            break;
                        case "F_in":
                            result = "জানবে";
                            break;
                        case "F_con":
                            result = "জানতে থাকবে";
                            break;
                        case "F_per":
                            result = "জানবে";
                            break;
                        case "F_per_con":
                            result = "জানতে থাকবে";
                            break;
                        default: break;
                    }
                }
                else if (verb.Contains("কাটা") || verb == "কাটা")
                {
                    switch (verb_tag)
                    {
                        case "P_in":
                            result = "কাটো";
                            break;
                        case "P_con":
                            result = "কাটছো";
                            break;
                        case "P_per":
                            result = "কেটেছো";
                            break;
                        case "P_per_con":
                            result = "কাটছো";
                            break;
                        case "Pa_in":
                            result = "কেটেছিলে";
                            break;
                        case "Pa_con":
                            result = "কাটতেছিলে";
                            break;
                        case "Pa_per":
                            result = "কেটেছিলে";
                            break;
                        case "Pa_per_con":
                            result = "কাটতেছিলে";
                            break;
                        case "F_in":
                            result = "কাটবে";
                            break;
                        case "F_con":
                            result = "কাটতে থাকবে";
                            break;
                        case "F_per":
                            result = "কাটবে";
                            break;
                        case "F_per_con":
                            result = "কাটতে থাকবে";
                            break;
                        default: break;
                    }
                }
                else if (verb.Contains("কামান") || verb == "কামান")
                {
                    switch (verb_tag)
                    {
                        case "P_in":
                            result = "কামাও";
                            break;
                        case "P_con":
                            result = "কামাচ্ছো";
                            break;
                        case "P_per":
                            result = "কামিয়েছো";
                            break;
                        case "P_per_con":
                            result = "কামাচ্ছো";
                            break;
                        case "Pa_in":
                            result = "কামিয়েছিলে";
                            break;
                        case "Pa_con":
                            result = "কামাচ্ছিলে";
                            break;
                        case "Pa_per":
                            result = "কামিয়েছিলে";
                            break;
                        case "Pa_per_con":
                            result = "কামাচ্ছিলে";
                            break;
                        case "F_in":
                            result = "কামাবে";
                            break;
                        case "F_con":
                            result = "কামাইতে থাকবে";
                            break;
                        case "F_per":
                            result = "কামাবে";
                            break;
                        case "F_per_con":
                            result = "কামাইতে থাকবে";
                            break;
                        default: break;
                    }
                }
                else if (verb.Contains("কেনা") || verb == "কেনা")
                {
                    switch (verb_tag)
                    {
                        case "P_in":
                            result = "কিনো";
                            break;
                        case "P_con":
                            result = "কিনছো";
                            break;
                        case "P_per":
                            result = "কিনেছো";
                            break;
                        case "P_per_con":
                            result = "কিনছো";
                            break;
                        case "Pa_in":
                            result = "কিনেছিলে";
                            break;
                        case "Pa_con":
                            result = "কিনতেছিলে";
                            break;
                        case "Pa_per":
                            result = "কিনেছিলে";
                            break;
                        case "Pa_per_con":
                            result = "কিনতেছিলে";
                            break;
                        case "F_in":
                            result = "কমাবে";
                            break;
                        case "F_con":
                            result = "কিনতে থাকবে";
                            break;
                        case "F_per":
                            result = "কমাবে";
                            break;
                        case "F_per_con":
                            result = "কিনতে থাকবে";
                            break;
                        default: break;
                    }
                }
                else if (verb.Contains("কমানো") || verb == "কমানো")
                {
                    switch (verb_tag)
                    {
                        case "P_in":
                            result = "কমাও";
                            break;
                        case "P_con":
                            result = "কমাচ্ছো";
                            break;
                        case "P_per":
                            result = "কমিয়েছো";
                            break;
                        case "P_per_con":
                            result = "কমাচ্ছো";
                            break;
                        case "Pa_in":
                            result = "কমাইছিলে";
                            break;
                        case "Pa_con":
                            result = "কমাচ্ছিলে";
                            break;
                        case "Pa_per":
                            result = "কমাইছিলে";
                            break;
                        case "Pa_per_con":
                            result = "কমাচ্ছিলে";
                            break;
                        case "F_in":
                            result = "কমাবে";
                            break;
                        case "F_con":
                            result = "কমাইতে থাকবে";
                            break;
                        case "F_per":
                            result = "কমাবে";
                            break;
                        case "F_per_con":
                            result = "কমাইতে থাকবে";
                            break;
                        default: break;
                    }
                }
                else if (verb.Contains("করান") || verb == "করান")
                {
                    switch (verb_tag)
                    {
                        case "P_in":
                            result = "করাও";
                            break;
                        case "P_con":
                            result = "করাচ্ছো";
                            break;
                        case "P_per":
                            result = "করিয়েছো";
                            break;
                        case "P_per_con":
                            result = "করাচ্ছো";
                            break;
                        case "Pa_in":
                            result = "করিয়েছিলে";
                            break;
                        case "Pa_con":
                            result = "করাচ্ছিলে";
                            break;
                        case "Pa_per":
                            result = "করিয়েছিলে";
                            break;
                        case "Pa_per_con":
                            result = "করাচ্ছিলে";
                            break;
                        case "F_in":
                            result = "করাবে";
                            break;
                        case "F_con":
                            result = "করাতে থাকবে";
                            break;
                        case "F_per":
                            result = "করাবে";
                            break;
                        case "F_per_con":
                            result = "করাতে থাকবে";
                            break;
                        default: break;
                    }
                }
                else if (verb.Contains("খাওয়া") || verb == "খাওয়া")
                {
                    switch (verb_tag)
                    {
                        case "P_in":
                            result = "খাও";
                            break;
                        case "P_con":
                            result = "খাচ্ছো";
                            break;
                        case "P_per":
                            result = "খেয়েছো";
                            break;
                        case "P_per_con":
                            result = "খাচ্ছো";
                            break;
                        case "Pa_in":
                            result = "খেয়েছিলে";
                            break;
                        case "Pa_con":
                            result = "খাচ্ছিলে";
                            break;
                        case "Pa_per":
                            result = "খেয়েছিলে";
                            break;
                        case "Pa_per_con":
                            result = "খাচ্ছিলে";
                            break;
                        case "F_in":
                            result = "খাবে";
                            break;
                        case "F_con":
                            result = "খাইতে থাকবে";
                            break;
                        case "F_per":
                            result = "খাবে";
                            break;
                        case "F_per_con":
                            result = "খাইতে থাকবে";
                            break;
                        default: break;
                    }
                }
                else if (verb.Contains("খেলা") || verb == "খেলা")
                {
                    switch (verb_tag)
                    {
                        case "P_in":
                            result = "খেলো";
                            break;
                        case "P_con":
                            result = "খেলছো";
                            break;
                        case "P_per":
                            result = "খেলেছো";
                            break;
                        case "P_per_con":
                            result = "খেলছো";
                            break;
                        case "Pa_in":
                            result = "খেলেছিলে";
                            break;
                        case "Pa_con":
                            result = "খেলতেছিলে";
                            break;
                        case "Pa_per":
                            result = "খেলেছিলে";
                            break;
                        case "Pa_per_con":
                            result = "খেলতেছিলে";
                            break;
                        case "F_in":
                            result = "খেলবে";
                            break;
                        case "F_con":
                            result = "খেলতে থাকবে";
                            break;
                        case "F_per":
                            result = "খেলবে";
                            break;
                        case "F_per_con":
                            result = "খেলতে থাকবে";
                            break;
                        default: break;
                    }
                }
                else if (verb.Contains("খোলা") || verb == "খোলা")
                {
                    switch (verb_tag)
                    {
                        case "P_in":
                            result = "খেলো";
                            break;
                        case "P_con":
                            result = "খুলছো";
                            break;
                        case "P_per":
                            result = "খুলেছো";
                            break;
                        case "P_per_con":
                            result = "খুলছো";
                            break;
                        case "Pa_in":
                            result = "খুলেছিলে";
                            break;
                        case "Pa_con":
                            result = "খুলতেছিলে";
                            break;
                        case "Pa_per":
                            result = "খুলেছিলে";
                            break;
                        case "Pa_per_con":
                            result = "খুলতেছিলে";
                            break;
                        case "F_in":
                            result = "খুলবে";
                            break;
                        case "F_con":
                            result = "খুলতে থাকবে";
                            break;
                        case "F_per":
                            result = "খুলবে";
                            break;
                        case "F_per_con":
                            result = "খুলতে থাকবে";
                            break;
                        default: break;
                    }
                }
                else if (verb.Contains("খাওয়ান") || verb == "খাওয়ান")
                {
                    switch (verb_tag)
                    {
                        case "P_in":
                            result = "খাওয়াও";
                            break;
                        case "P_con":
                            result = "খাওয়াচ্ছো";
                            break;
                        case "P_per":
                            result = "খাইয়েছো";
                            break;
                        case "P_per_con":
                            result = "খাওয়াচ্ছো";
                            break;
                        case "Pa_in":
                            result = "খাইয়েছিলে";
                            break;
                        case "Pa_con":
                            result = "খাওয়াচ্ছিলে";
                            break;
                        case "Pa_per":
                            result = "খাইয়েছিলে";
                            break;
                        case "Pa_per_con":
                            result = "খাওয়াচ্ছিলে";
                            break;
                        case "F_in":
                            result = "খাওয়াবে";
                            break;
                        case "F_con":
                            result = "খাওয়াতে থাকবে";
                            break;
                        case "F_per":
                            result = "খাওয়াবে";
                            break;
                        case "F_per_con":
                            result = "খাওয়াতে থাকবে";
                            break;
                        default: break;
                    }
                }
                else if (verb.Contains("খোজা") || verb == "খোজা")
                {
                    switch (verb_tag)
                    {
                        case "P_in":
                            result = "খুজো";
                            break;
                        case "P_con":
                            result = "খুজছো";
                            break;
                        case "P_per":
                            result = "খুজেছো";
                            break;
                        case "P_per_con":
                            result = "খুজছো";
                            break;
                        case "Pa_in":
                            result = "খুজতেছিলে";
                            break;
                        case "Pa_con":
                            result = "খুজতেছিলো";
                            break;
                        case "Pa_per":
                            result = "খুজেছিলে";
                            break;
                        case "Pa_per_con":
                            result = "খুজতেছিলে";
                            break;
                        case "F_in":
                            result = "খুজবে";
                            break;
                        case "F_con":
                            result = "খুজতে থাকবে";
                            break;
                        case "F_per":
                            result = "খুজবে";
                            break;
                        case "F_per_con":
                            result = "খুজতে থাকবে";
                            break;
                        default: break;
                    }
                }
                else if (verb.Contains("লেখা") || verb == "লেখা")
                {
                    switch (verb_tag)
                    {
                        case "P_in":
                            result = "লেখো";
                            break;
                        case "P_con":
                            result = "লিখছো";
                            break;
                        case "P_per":
                            result = "লিখেছো";
                            break;
                        case "P_per_con":
                            result = "লিখছো";
                            break;
                        case "Pa_in":
                            result = "লিখেছিলে";
                            break;
                        case "Pa_con":
                            result = "লিখতেছিলে";
                            break;
                        case "Pa_per":
                            result = "লিখেছিলে";
                            break;
                        case "Pa_per_con":
                            result = "লিখতেছিলে";
                            break;
                        case "F_in":
                            result = "লিখবে";
                            break;
                        case "F_con":
                            result = "লিখতে থাকবে";
                            break;
                        case "F_per":
                            result = "লিখবে";
                            break;
                        case "F_per_con":
                            result = "লিখতে থাকবে";
                            break;
                        default: break;
                    }
                }
                else if (verb.Contains("লাগানো") || verb == "লাগানো")
                {
                    switch (verb_tag)
                    {
                        case "P_in":
                            result = "লাগাও";
                            break;
                        case "P_con":
                            result = "লাগাচ্ছো";
                            break;
                        case "P_per":
                            result = "লাগিয়েছো";
                            break;
                        case "P_per_con":
                            result = "লাগাচ্ছো";
                            break;
                        case "Pa_in":
                            result = "লাগিয়েছিলে";
                            break;
                        case "Pa_con":
                            result = "লাগাচ্ছিলে";
                            break;
                        case "Pa_per":
                            result = "লাগিয়েছিলে";
                            break;
                        case "Pa_per_con":
                            result = "লাগাচ্ছিলে";
                            break;
                        case "F_in":
                            result = "লুকাবে";
                            break;
                        case "F_con":
                            result = "লুকাইতে থাকবে";
                            break;
                        case "F_per":
                            result = "লাগাবে";
                            break;
                        case "F_per_con":
                            result = "লাগাইতে থাকবে";
                            break;
                        default: break;
                    }
                }
                else if (verb.Contains("লুকান") || verb == "লুকান")
                {
                    switch (verb_tag)
                    {
                        case "P_in":
                            result = "লুকাও";
                            break;
                        case "P_con":
                            result = "লুকাচ্ছো";
                            break;
                        case "P_per":
                            result = "লুকিয়েছো";
                            break;
                        case "P_per_con":
                            result = "লুকাচ্ছো";
                            break;
                        case "Pa_in":
                            result = "লুকিয়েছিলে";
                            break;
                        case "Pa_con":
                            result = "লুকাচ্ছিলে";
                            break;
                        case "Pa_per":
                            result = "লুকিয়েছিলে";
                            break;
                        case "Pa_per_con":
                            result = "লুকাচ্ছিলে";
                            break;
                        case "F_in":
                            result = "লুকাবে";
                            break;
                        case "F_con":
                            result = "লুকাইতে থাকবে";
                            break;
                        case "F_per":
                            result = "লুকাবে";
                            break;
                        case "F_per_con":
                            result = "লুকাইতে থাকবে";
                            break;
                        default: break;
                    }
                }
                else if (verb.Contains("ভাঙ্গা") || verb == "ভাঙ্গা")
                {
                    switch (verb_tag)
                    {
                        case "P_in":
                            result = "ভাঙ্গ";
                            break;
                        case "P_con":
                            result = "ভাঙছো";
                            break;
                        case "P_per":
                            result = "ভেঙ্গেছো";
                            break;
                        case "P_per_con":
                            result = "ভাঙছো";
                            break;
                        case "Pa_in":
                            result = "ভেঙ্গেছিলে";
                            break;
                        case "Pa_con":
                            result = "ভাঙ্গছিলে";
                            break;
                        case "Pa_per":
                            result = "ভেঙ্গেছিলে";
                            break;
                        case "Pa_per_con":
                            result = "ভাঙ্গছিলে";
                            break;
                        case "F_in":
                            result = "ভাঙ্গবে";
                            break;
                        case "F_con":
                            result = "ভালবাসতে থাকবে";
                            break;
                        case "F_per":
                            result = "ভাঙ্গবে";
                            break;
                        case "F_per_con":
                            result = "ভালবাসতে থাকবে";
                            break;
                        default: break;
                    }
                }
                else if (verb.Contains("ভালবাসা") || verb == "ভালবাসা")
                {
                    switch (verb_tag)
                    {
                        case "P_in":
                            result = "ভালবাসো";
                            break;
                        case "P_con":
                            result = "ভালোবাসছো";
                            break;
                        case "P_per":
                            result = "ভালবেসেছো";
                            break;
                        case "P_per_con":
                            result = "ভালোবাসছো";
                            break;
                        case "Pa_in":
                            result = "ভালেবেসেছিলে";
                            break;
                        case "Pa_con":
                            result = "ভালেবাসছিলে";
                            break;
                        case "Pa_per":
                            result = "ভালেবেসেছিলে";
                            break;
                        case "Pa_per_con":
                            result = "ভালেবাসছিলে";
                            break;
                        case "F_in":
                            result = "ভালবাসবে";
                            break;
                        case "F_con":
                            result = "ভালবাসতে থাকবে";
                            break;
                        case "F_per":
                            result = "ভালবাসবে";
                            break;
                        case "F_per_con":
                            result = "ভালবাসতে থাকবে";
                            break;
                        default: break;
                    }
                }
                else if (verb.Contains("ভাজা") || verb == "ভাজা")
                {
                    switch (verb_tag)
                    {
                        case "P_in":
                            result = "ভাজো";
                            break;
                        case "P_con":
                            result = "ভাজছো";
                            break;
                        case "P_per":
                            result = "ভেজেছো";
                            break;
                        case "P_per_con":
                            result = "ভাজছো";
                            break;
                        case "Pa_in":
                            result = "ভেজেছিলে";
                            break;
                        case "Pa_con":
                            result = "ভাজছিলে";
                            break;
                        case "Pa_per":
                            result = "ভেজেছিলে";
                            break;
                        case "Pa_per_con":
                            result = "ভাজছিলে";
                            break;
                        case "F_in":
                            result = "ভাজবে";
                            break;
                        case "F_con":
                            result = "ভাজতে থাকবে";
                            break;
                        case "F_per":
                            result = "ভাজবে";
                            break;
                        case "F_per_con":
                            result = "ভাজতে থাকবে";
                            break;
                        default: break;
                    }
                }
                else if (verb.Contains("ভাসান") || verb == "ভাসান")
                {
                    switch (verb_tag)
                    {
                        case "P_in":
                            result = "ভাসাও";
                            break;
                        case "P_con":
                            result = "ভাসাচ্ছো";
                            break;
                        case "P_per":
                            result = "ভাসিয়েছো";
                            break;
                        case "P_per_con":
                            result = "ভাসাচ্ছো";
                            break;
                        case "Pa_in":
                            result = "ভাসিয়েছিলে";
                            break;
                        case "Pa_con":
                            result = "ভাসাচ্ছিলে";
                            break;
                        case "Pa_per":
                            result = "ভাসিয়েছিলে";
                            break;
                        case "Pa_per_con":
                            result = "ভাসাচ্ছিলে";
                            break;
                        case "F_in":
                            result = "ভাসাবে";
                            break;
                        case "F_con":
                            result = "ভাসাতে থাকবে";
                            break;
                        case "F_per":
                            result = "ভাসাবে";
                            break;
                        case "F_per_con":
                            result = "ভাসাতে থাকবে";
                            break;
                        default: break;
                    }
                }
                else if (verb.Contains("তাকান") || verb == "তাকান")
                {
                    switch (verb_tag)
                    {
                        case "P_in":
                            result = "তাকাও";
                            break;
                        case "P_con":
                            result = "তাকাচ্ছো";
                            break;
                        case "P_per":
                            result = "তাকিয়েছো";
                            break;
                        case "P_per_con":
                            result = "তাকাচ্ছো";
                            break;
                        case "Pa_in":
                            result = "তাকিয়েছিলে";
                            break;
                        case "Pa_con":
                            result = "তাকাচ্ছিলে";
                            break;
                        case "Pa_per":
                            result = "তাকিয়েছিলে";
                            break;
                        case "Pa_per_con":
                            result = "তাকাচ্ছিলে";
                            break;
                        case "F_in":
                            result = "তাকাবে";
                            break;
                        case "F_con":
                            result = "তাকাতে থাকবে";
                            break;
                        case "F_per":
                            result = "তাকাবে";
                            break;
                        case "F_per_con":
                            result = "তাকাতে থাকবে";
                            break;
                        default: break;
                    }
                }
                else if (verb.Contains("থাকা") || verb == "থাকা")
                {
                    switch (verb_tag)
                    {
                        case "P_in":
                            result = "থাকো";
                            break;
                        case "P_con":
                            result = "থাকছো";
                            break;
                        case "P_per":
                            result = "থেকেছো";
                            break;
                        case "P_per_con":
                            result = "থাকছো";
                            break;
                        case "Pa_in":
                            result = "থেকেছিলে";
                            break;
                        case "Pa_con":
                            result = "থাকছিলে";
                            break;
                        case "Pa_per":
                            result = "থেকেছিলে";
                            break;
                        case "Pa_per_con":
                            result = "থাকছিলে";
                            break;
                        case "F_in":
                            result = "থাকবে";
                            break;
                        case "F_con":
                            result = "থাকবে";
                            break;
                        case "F_per":
                            result = "থাকবে";
                            break;
                        case "F_per_con":
                            result = "থাকবে";
                            break;
                        default: break;
                    }
                }
                else if (verb.Contains("টানা") || verb == "টানা")
                {
                    switch (verb_tag)
                    {
                        case "P_in":
                            result = "টানো";
                            break;
                        case "P_con":
                            result = "টানছো";
                            break;
                        case "P_per":
                            result = "টেনেছো";
                            break;
                        case "P_per_con":
                            result = "টানছো";
                            break;
                        case "Pa_in":
                            result = "টেনেছিলে";
                            break;
                        case "Pa_con":
                            result = "টানছিলে";
                            break;
                        case "Pa_per":
                            result = "টেনেছিলে";
                            break;
                        case "Pa_per_con":
                            result = "টানছিলে";
                            break;
                        case "F_in":
                            result = "টানবে";
                            break;
                        case "F_con":
                            result = "টানতে থাকবে";
                            break;
                        case "F_per":
                            result = "টানবে";
                            break;
                        case "F_per_con":
                            result = "টানতে থাকবে";
                            break;
                        default: break;
                    }
                }
                else if (verb.Contains("পাঠান") || verb == "পাঠান")
                {
                    switch (verb_tag)
                    {
                        case "P_in":
                            result = "পাঠাও";
                            break;
                        case "P_con":
                            result = "পাঠাচ্ছো";
                            break;
                        case "P_per":
                            result = "পাঠিয়েছো";
                            break;
                        case "P_per_con":
                            result = "পাঠাচ্ছো";
                            break;
                        case "Pa_in":
                            result = "পাঠিয়েছিলে";
                            break;
                        case "Pa_con":
                            result = "পাঠাচ্ছিলে";
                            break;
                        case "Pa_per":
                            result = "পাঠিয়েছিলে";
                            break;
                        case "Pa_per_con":
                            result = "পাঠাচ্ছিলে";
                            break;
                        case "F_in":
                            result = "পাঠাবে";
                            break;
                        case "F_con":
                            result = "পাঠাতে থাকবে";
                            break;
                        case "F_per":
                            result = "পাঠাবে";
                            break;
                        case "F_per_con":
                            result = "পাঠাতে থাকবে";
                            break;
                        default: break;
                    }
                }
                else if (verb.Contains("পড়া") || verb == "পড়া")
                {
                    switch (verb_tag)
                    {
                        case "P_in":
                            result = "পড়ো";
                            break;
                        case "P_con":
                            result = "পড়ছো";
                            break;
                        case "P_per":
                            result = "পড়েছো";
                            break;
                        case "P_per_con":
                            result = "পড়ছো";
                            break;
                        case "Pa_in":
                            result = "পড়েছিলে";
                            break;
                        case "Pa_con":
                            result = "পড়ছিলে";
                            break;
                        case "Pa_per":
                            result = "পড়েছিলে";
                            break;
                        case "Pa_per_con":
                            result = "পড়ছিলে";
                            break;
                        case "F_in":
                            result = "পড়াবে";
                            break;
                        case "F_con":
                            result = "পড়াতে থাকবে";
                            break;
                        case "F_per":
                            result = "পড়াবে";
                            break;
                        case "F_per_con":
                            result = "পড়াতে থাকবে";
                            break;
                        default: break;
                    }
                }
                else if (verb.Contains("পরান") || verb == "পরান")
                {
                    switch (verb_tag)
                    {
                        case "P_in":
                            result = "পরাও";
                            break;
                        case "P_con":
                            result = "পরাচ্ছো";
                            break;
                        case "P_per":
                            result = "পরিয়েছো";
                            break;
                        case "P_per_con":
                            result = "পরাচ্ছো";
                            break;
                        case "Pa_in":
                            result = "পরিয়েছিলে";
                            break;
                        case "Pa_con":
                            result = "পরাচ্ছিলে";
                            break;
                        case "Pa_per":
                            result = "পরিয়েছিলে";
                            break;
                        case "Pa_per_con":
                            result = "পরাচ্ছিলো";
                            break;
                        case "F_in":
                            result = "পরাবে";
                            break;
                        case "F_con":
                            result = "পরাতে থাকবে";
                            break;
                        case "F_per":
                            result = "পরাবে";
                            break;
                        case "F_per_con":
                            result = "পরাতে থাকবে";
                            break;
                        default: break;
                    }
                }
                else if (verb.Contains("পালানো") || verb == "পালানো")
                {
                    switch (verb_tag)
                    {
                        case "P_in":
                            result = "পালাও";
                            break;
                        case "P_con":
                            result = "পালাচ্ছো";
                            break;
                        case "P_per":
                            result = "পালিয়েছো";
                            break;
                        case "P_per_con":
                            result = "পালাচ্ছো";
                            break;
                        case "Pa_in":
                            result = "পালিয়েছিলে";
                            break;
                        case "Pa_con":
                            result = "পালাচ্ছিল";
                            break;
                        case "Pa_per":
                            result = "পালিয়েছিলে";
                            break;
                        case "Pa_per_con":
                            result = "পালাচ্ছিলে";
                            break;
                        case "F_in":
                            result = "পালাবে";
                            break;
                        case "F_con":
                            result = "পালাতে থাকবে";
                            break;
                        case "F_per":
                            result = "পালাবে";
                            break;
                        case "F_per_con":
                            result = "পালাতে থাকবে";
                            break;
                        default: break;
                    }
                }
                else if (verb.Contains("পাওয়া") || verb == "পাওয়া")
                {
                    switch (verb_tag)
                    {
                        case "P_in":
                            result = "পাচ্ছো";
                            break;
                        case "P_con":
                            result = "পাচ্ছো";
                            break;
                        case "P_per":
                            result = "পেয়েছো";
                            break;
                        case "P_per_con":
                            result = "পাচ্ছো";
                            break;
                        case "Pa_in":
                            result = "পেয়েছিলে";
                            break;
                        case "Pa_con":
                            result = "পাচ্ছিলে";
                            break;
                        case "Pa_per":
                            result = "পেয়েছিলে";
                            break;
                        case "Pa_per_con":
                            result = "পাচ্ছিলে";
                            break;
                        case "F_in":
                            result = "পাবে";
                            break;
                        case "F_con":
                            result = "পাইতে থাকবে";
                            break;
                        case "F_per":
                            result = "পাবে";
                            break;
                        case "F_per_con":
                            result = "পাইতে থাকবে";
                            break;
                        default: break;
                    }
                }
                else if (verb.Contains("রাখা") || verb == "রাখা")
                {
                    switch (verb_tag)
                    {
                        case "P_in":
                            result = "রাখো";
                            break;
                        case "P_con":
                            result = "রেখেছো";
                            break;
                        case "P_per":
                            result = "রেখেছো";
                            break;
                        case "P_per_con":
                            result = "রেখেছো";
                            break;
                        case "Pa_in":
                            result = "রেখেছিলে";
                            break;
                        case "Pa_con":
                            result = "রাখছিলে";
                            break;
                        case "Pa_per":
                            result = "রেখেছিলে";
                            break;
                        case "Pa_per_con":
                            result = "রাখছিলে";
                            break;
                        case "F_in":
                            result = "রাখবে";
                            break;
                        case "F_con":
                            result = "রাখতে থাকবে";
                            break;
                        case "F_per":
                            result = "রাখবে";
                            break;
                        case "F_per_con":
                            result = "রাখতে থাকবে";
                            break;
                        default: break;
                    }
                }
                else if (verb.Contains("নোয়ান") || verb == "নোয়ান")
                {
                    switch (verb_tag)
                    {
                        case "P_in":
                            result = "নোয়াও";
                            break;
                        case "P_con":
                            result = "নুয়াচ্ছো";
                            break;
                        case "P_per":
                            result = "নুয়েছো";
                            break;
                        case "P_per_con":
                            result = "নুয়াচ্ছো";
                            break;
                        case "Pa_in":
                            result = "নুয়েছিলে";
                            break;
                        case "Pa_con":
                            result = "নুয়াচ্ছিলে";
                            break;
                        case "Pa_per":
                            result = "নুয়েছিলে";
                            break;
                        case "Pa_per_con":
                            result = "নুয়াচ্ছিলে";
                            break;
                        case "F_in":
                            result = "নোয়াবে";
                            break;
                        case "F_con":
                            result = "নুয়াতে থাকবে";
                            break;
                        case "F_per":
                            result = "নোয়াবে";
                            break;
                        case "F_per_con":
                            result = "নুয়াতে থাকবে";
                            break;
                        default: break;
                    }
                }
                else if (verb.Contains("নেয়া") || verb == "নেয়া")
                {
                    switch (verb_tag)
                    {
                        case "P_in":
                            result = "নাও";
                            break;
                        case "P_con":
                            result = "নিচ্ছো";
                            break;
                        case "P_per":
                            result = "নিয়েছো";
                            break;
                        case "P_per_con":
                            result = "নিচ্ছো";
                            break;
                        case "Pa_in":
                            result = "নিয়েছিলে";
                            break;
                        case "Pa_con":
                            result = "নিচ্ছিলে";
                            break;
                        case "Pa_per":
                            result = "নিয়েছিলে";
                            break;
                        case "Pa_per_con":
                            result = "নিচ্ছিলে";
                            break;
                        case "F_in":
                            result = "নিবে";
                            break;
                        case "F_con":
                            result = "নিতে থাকবে";
                            break;
                        case "F_per":
                            result = "নিবে";
                            break;
                        case "F_per_con":
                            result = "নিতে থাকবে";
                            break;
                        default: break;
                    }
                }
                else if (verb.Contains("নাড়ান") || verb == "নাড়ান")
                {
                    switch (verb_tag)
                    {
                        case "P_in":
                            result = "নাড়াও";
                            break;
                        case "P_con":
                            result = "নাড়াচ্ছো";
                            break;
                        case "P_per":
                            result = "নাড়িয়েছো";
                            break;
                        case "P_per_con":
                            result = "নাড়াচ্ছো";
                            break;
                        case "Pa_in":
                            result = "নাড়িয়েছিলে";
                            break;
                        case "Pa_con":
                            result = "নাড়াচ্ছিলে";
                            break;
                        case "Pa_per":
                            result = "নাড়িয়েছিলে";
                            break;
                        case "Pa_per_con":
                            result = "নাড়াচ্ছিলে";
                            break;
                        case "F_in":
                            result = "নাড়াবে";
                            break;
                        case "F_con":
                            result = "নাড়াতে থাকবে";
                            break;
                        case "F_per":
                            result = "নাড়াবে";
                            break;
                        case "F_per_con":
                            result = "নাড়াতে থাকবে";
                            break;
                        default: break;
                    }
                }
                else if (verb.Contains("নাচা") || verb == "নাচা")
                {
                    switch (verb_tag)
                    {
                        case "P_in":
                            result = "নাচো";
                            break;
                        case "P_con":
                            result = "নাচতেছো";
                            break;
                        case "P_per":
                            result = "নেচেছো";
                            break;
                        case "P_per_con":
                            result = "নাচতেছো";
                            break;
                        case "Pa_in":
                            result = "নেচেছিলে";
                            break;
                        case "Pa_con":
                            result = "নাচতেছিলে";
                            break;
                        case "Pa_per":
                            result = "নেচেছিলে";
                            break;
                        case "Pa_per_con":
                            result = "নাচতেছিলে";
                            break;
                        case "F_in":
                            result = "নাচবে";
                            break;
                        case "F_con":
                            result = "নাচতে থাকবে";
                            break;
                        case "F_per":
                            result = "নাচবে";
                            break;
                        case "F_per_con":
                            result = "নাচতে থাকবে";
                            break;
                        default: break;
                    }
                }
                else if (verb.Contains("শেখান") || verb == "শেখান")
                {
                    switch (verb_tag)
                    {
                        case "P_in":
                            result = "শিখাও";
                            break;
                        case "P_con":
                            result = "শেখাচ্ছো";
                            break;
                        case "P_per":
                            result = "শিখিয়েছো";
                            break;
                        case "P_per_con":
                            result = "শেখাচ্ছো";
                            break;
                        case "Pa_in":
                            result = "শিখিয়েছিলে";
                            break;
                        case "Pa_con":
                            result = "শেখাচ্ছিলে";
                            break;
                        case "Pa_per":
                            result = "শিখিয়েছিলে";
                            break;
                        case "Pa_per_con":
                            result = "শেখাচ্ছিলে";
                            break;
                        case "F_in":
                            result = "শেখাবে";
                            break;
                        case "F_con":
                            result = "শেখাতে থাকবে";
                            break;
                        case "F_per":
                            result = "শেখাবে";
                            break;
                        case "F_per_con":
                            result = "শেখাতে থাকবে";
                            break;
                        default: break;
                    }
                }
                else if (verb.Contains("শোনা") || verb == "শোনা")
                {
                    switch (verb_tag)
                    {
                        case "P_in":
                            result = "শুনো";
                            break;
                        case "P_con":
                            result = "শুনছো";
                            break;
                        case "P_per":
                            result = "শুনেছো";
                            break;
                        case "P_per_con":
                            result = "শুনছো";
                            break;
                        case "Pa_in":
                            result = "শুনেছিলে";
                            break;
                        case "Pa_con":
                            result = "শুনছিলে";
                            break;
                        case "Pa_per":
                            result = "শুনেছিলে";
                            break;
                        case "Pa_per_con":
                            result = "শুনছিলে";
                            break;
                        case "F_in":
                            result = "শুনবে";
                            break;
                        case "F_con":
                            result = "শুনতে থাকবে";
                            break;
                        case "F_per":
                            result = "শুনবে";
                            break;
                        case "F_per_con":
                            result = "শুনতে থাকবে";
                            break;
                        default: break;
                    }
                }
                else if (verb.Contains("শেখা") || verb == "শেখা")
                {
                    switch (verb_tag)
                    {
                        case "P_in":
                            result = "শিখো";
                            break;
                        case "P_con":
                            result = "শিখছো";
                            break;
                        case "P_per":
                            result = "শিখেছো";
                            break;
                        case "P_per_con":
                            result = "শিখছো";
                            break;
                        case "Pa_in":
                            result = "শিখেছিলে";
                            break;
                        case "Pa_con":
                            result = "শিখছিলে";
                            break;
                        case "Pa_per":
                            result = "শিখেছিলে";
                            break;
                        case "Pa_per_con":
                            result = "শিখছিলে";
                            break;
                        case "F_in":
                            result = "শিখবে";
                            break;
                        case "F_con":
                            result = "শিখতে থাকবে";
                            break;
                        case "F_per":
                            result = "শিখবে";
                            break;
                        case "F_per_con":
                            result = "শিখতে থাকবে";
                            break;
                        default: break;
                    }
                }
                else if (verb.Contains("সাজান") || verb == "সাজান")
                {
                    switch (verb_tag)
                    {
                        case "P_in":
                            result = "সাজাও";
                            break;
                        case "P_con":
                            result = "সাজাচ্ছো";
                            break;
                        case "P_per":
                            result = "সাজিয়েছো";
                            break;
                        case "P_per_con":
                            result = "সাজাচ্ছো";
                            break;
                        case "Pa_in":
                            result = "সাজিয়েছিলে";
                            break;
                        case "Pa_con":
                            result = "সাজাচ্ছিলে";
                            break;
                        case "Pa_per":
                            result = "সাজিয়েছিলে";
                            break;
                        case "Pa_per_con":
                            result = "সাজাচ্ছিলে";
                            break;
                        case "F_in":
                            result = "সাজায়";
                            break;
                        case "F_con":
                            result = "সাজাতে থাকবে";
                            break;
                        case "F_per":
                            result = "সাজায়";
                            break;
                        case "F_per_con":
                            result = "সাজাতে থাকবে";
                            break;
                        default: break;
                    }
                }
                else if (verb.Contains("শুকান") || verb == "শুকান")
                {
                    switch (verb_tag)
                    {
                        case "P_in":
                            result = "শুকাও";
                            break;
                        case "P_con":
                            result = "শুকাচ্ছো";
                            break;
                        case "P_per":
                            result = "শুকিয়েছো";
                            break;
                        case "P_per_con":
                            result = "শুকাচ্ছো";
                            break;
                        case "Pa_in":
                            result = "শুকিয়েছিলে";
                            break;
                        case "Pa_con":
                            result = "শুকাচ্ছিলে";
                            break;
                        case "Pa_per":
                            result = "শুকিয়েছিলে";
                            break;
                        case "Pa_per_con":
                            result = "শুকাচ্ছিলে";
                            break;
                        case "F_in":
                            result = "শুকাবে";
                            break;
                        case "F_con":
                            result = "শুকাতে থাকবে";
                            break;
                        case "F_per":
                            result = "শুকাবে";
                            break;
                        case "F_per_con":
                            result = "শুকাতে থাকবে";
                            break;
                        default: break;
                    }
                }
                else if (verb.Contains("শিখান") || verb == "শিখান")
                {
                    switch (verb_tag)
                    {
                        case "P_in":
                            result = "শিখাও";
                            break;
                        case "P_con":
                            result = "শেখাচ্ছো";
                            break;
                        case "P_per":
                            result = "শিখিয়েছো";
                            break;
                        case "P_per_con":
                            result = "শেখাচ্ছো";
                            break;
                        case "Pa_in":
                            result = "শিখিয়েছিলে";
                            break;
                        case "Pa_con":
                            result = "শেখাচ্ছিলে";
                            break;
                        case "Pa_per":
                            result = "শিখিয়েছিলে";
                            break;
                        case "Pa_per_con":
                            result = "শেখাচ্ছিলে";
                            break;
                        case "F_in":
                            result = "শিখবে";
                            break;
                        case "F_con":
                            result = "শিখতে থাকবে";
                            break;
                        case "F_per":
                            result = "শিখবে";
                            break;
                        case "F_per_con":
                            result = "শিখতে থাকবে";
                            break;
                        default: break;
                    }
                }
                else if (verb.Contains("উঠা") || verb == "উঠা")
                {
                    switch (verb_tag)
                    {
                        case "P_in":
                            result = "উঠো";
                            break;
                        case "P_con":
                            result = "উঠছো";
                            break;
                        case "P_per":
                            result = "উঠেছো";
                            break;
                        case "P_per_con":
                            result = "উঠছো";
                            break;
                        case "Pa_in":
                            result = "উঠেছিলে";
                            break;
                        case "Pa_con":
                            result = "উঠছিলে";
                            break;
                        case "Pa_per":
                            result = "উঠেছিলে";
                            break;
                        case "Pa_per_con":
                            result = "উঠছিলে";
                            break;
                        case "F_in":
                            result = "উঠবে";
                            break;
                        case "F_con":
                            result = "উঠতে থাকবে";
                            break;
                        case "F_per":
                            result = "উঠবে";
                            break;
                        case "F_per_con":
                            result = "উঠতে থাকবে";
                            break;
                        default: break;
                    }
                }
                else if (verb.Contains("ওঠা") || verb == "ওঠা")
                {
                    switch (verb_tag)
                    {
                        case "P_in":
                            result = "ওঠে";
                            break;
                        case "P_con":
                            result = "ওঠছে";
                            break;
                        case "P_per":
                            result = "ওঠেছে";
                            break;
                        case "P_per_con":
                            result = "ওঠছে";
                            break;
                        case "Pa_in":
                            result = "ওঠেছিলো";
                            break;
                        case "Pa_con":
                            result = "ওঠছিলো";
                            break;
                        case "Pa_per":
                            result = "ওঠেছিলো";
                            break;
                        case "Pa_per_con":
                            result = "ওঠছিলো";
                            break;
                        case "F_in":
                            result = "ওঠবে";
                            break;
                        case "F_con":
                            result = "ওঠতে থাকবে";
                            break;
                        case "F_per":
                            result = "ওঠবে";
                            break;
                        case "F_per_con":
                            result = "ওঠতে থাকবে";
                            break;
                        default: break;
                    }
                }
                else if (verb.Contains("উঠান") || verb == "উঠান")
                {
                    switch (verb_tag)
                    {
                        case "P_in":
                            result = "উঠাও";
                            break;
                        case "P_con":
                            result = "উঠাচ্ছো";
                            break;
                        case "P_per":
                            result = "উঠিয়েছো";
                            break;
                        case "P_per_con":
                            result = "উঠাচ্ছো";
                            break;
                        case "Pa_in":
                            result = "উঠিয়েছিলে";
                            break;
                        case "Pa_con":
                            result = "উঠাচ্ছিলে";
                            break;
                        case "Pa_per":
                            result = "উঠিয়েছিলে";
                            break;
                        case "Pa_per_con":
                            result = "উঠাচ্ছিলে";
                            break;
                        case "F_in":
                            result = "উঠাবে";
                            break;
                        case "F_con":
                            result = "উঠাতে থাকবে";
                            break;
                        case "F_per":
                            result = "উঠাবে";
                            break;
                        case "F_per_con":
                            result = "উঠাতে থাকবে";
                            break;
                        default: break;
                    }
                }
                else if (verb.Contains("উড়া") || verb == "উড়া")
                {
                    switch (verb_tag)
                    {
                        case "P_in":
                            result = "উড়ো";
                            break;
                        case "P_con":
                            result = "উড়ছো";
                            break;
                        case "P_per":
                            result = "উড়েছো";
                            break;
                        case "P_per_con":
                            result = "উড়ছো";
                            break;
                        case "Pa_in":
                            result = "উড়েছিলে";
                            break;
                        case "Pa_con":
                            result = "উড়ছিলে";
                            break;
                        case "Pa_per":
                            result = "উড়েছিলে";
                            break;
                        case "Pa_per_con":
                            result = "উড়ছিলে";
                            break;
                        case "F_in":
                            result = "উড়বে";
                            break;
                        case "F_con":
                            result = "উড়তে থাকবে";
                            break;
                        case "F_per":
                            result = "উড়বে";
                            break;
                        case "F_per_con":
                            result = "উড়তে থাকবে";
                            break;
                        default: break;
                    }
                }
                else if (verb.Contains("মেটান") || verb == "মেটান")
                {
                    switch (verb_tag)
                    {
                        case "P_in":
                            result = "মেটাও";
                            break;
                        case "P_con":
                            result = "মেটাচ্ছো";
                            break;
                        case "P_per":
                            result = "মিটিয়েছো";
                            break;
                        case "P_per_con":
                            result = "মেটাচ্ছো";
                            break;
                        case "Pa_in":
                            result = "মিটিয়েছিলে";
                            break;
                        case "Pa_con":
                            result = "মেটাচ্ছিলে";
                            break;
                        case "Pa_per":
                            result = "মিটিয়েছিলে";
                            break;
                        case "Pa_per_con":
                            result = "মেটাচ্ছিলে";
                            break;
                        case "F_in":
                            result = "মেটাবে";
                            break;
                        case "F_con":
                            result = "মেটাতে থাকবে";
                            break;
                        case "F_per":
                            result = "মেটাবে";
                            break;
                        case "F_per_con":
                            result = "মেটাতে থাকবে";
                            break;
                        default: break;
                    }
                }
                else
                { }
            }
            else
            {
                if (verb.Contains("আনা") || verb == "আনা")
                    if (verb.Contains("আনা") || verb == "আনা")
                    {
                        switch (verb_tag)
                        {
                            case "P_in":
                                result = "এনেছে ";
                                break;
                            case "P_con":
                                result = "আনছে";
                                break;
                            case "P_per":
                                result = "এনেছে ";
                                break;
                            case "P_per_con":
                                result = "আনছে";
                                break;
                            case "Pa_in":
                                result = "এনেছিলো";
                                break;
                            case "Pa_con":
                                result = "আনছিলো";
                                break;
                            case "Pa_per":
                                result = "এনেছিলো";
                                break;
                            case "Pa_per_con":
                                result = "আনছিলো";
                                break;
                            case "F_in":
                                result = "আনবে";
                                break;
                            case "F_con":
                                result = "আনতে থাকবে";
                                break;
                            case "F_per":
                                result = "আনবে";
                                break;
                            case "F_per_con":
                                result = "আনতে থাকবো";
                                break;
                            default: break;
                        }
                    }
                    else if (verb.Contains("আঁকা") || verb == "আঁকা")
                    {
                        switch (verb_tag)
                        {
                            case "P_in":
                                result = "আঁকে";
                                break;
                            case "P_con":
                                result = "আঁকছে";
                                break;
                            case "P_per":
                                result = "এঁকেছে";
                                break;
                            case "P_per_con":
                                result = "আঁকছে";
                                break;
                            case "Pa_in":
                                result = "এঁকেছিলো";
                                break;
                            case "Pa_con":
                                result = "আঁকছিলো";
                                break;
                            case "Pa_per":
                                result = "এঁকেছিলো";
                                break;
                            case "Pa_per_con":
                                result = "আঁকছিলো";
                                break;
                            case "F_in":
                                result = "আঁকবে";
                                break;
                            case "F_con":
                                result = "আঁকতে থাকবে";
                                break;
                            case "F_per":
                                result = "আঁকবে";
                                break;
                            case "F_per_con":
                                result = "আঁকতে থাকবে";
                                break;
                            default: break;
                        }
                    }
                    else if (verb.Contains("বাঁধা") || verb == "বাঁধা")
                    {
                        switch (verb_tag)
                        {
                            case "P_in":
                                result = "বাঁধে";
                                break;
                            case "P_con":
                                result = "বাঁধছে";
                                break;
                            case "P_per":
                                result = "বেঁধেছে";
                                break;
                            case "P_per_con":
                                result = "বাঁধছে";
                                break;
                            case "Pa_in":
                                result = "বেঁধেছিলো";
                                break;
                            case "Pa_con":
                                result = "বাঁধছিলো";
                                break;
                            case "Pa_per":
                                result = "বেঁধেছিলো";
                                break;
                            case "Pa_per_con":
                                result = "বাঁধছিলো";
                                break;
                            case "F_in":
                                result = "বাধবে";
                                break;
                            case "F_con":
                                result = "বাঁধতে থাকবে";
                                break;
                            case "F_per":
                                result = "বাধবে";
                                break;
                            case "F_per_con":
                                result = "বাঁধতে থাকবে";
                                break;
                            default: break;
                        }
                    }
                    else if (verb.Contains("বসা") || verb == "বসা")
                    {
                        switch (verb_tag)
                        {
                            case "P_in":
                                result = "বসে";
                                break;
                            case "P_con":
                                result = "বসছে";
                                break;
                            case "P_per":
                                result = "বসেছে";
                                break;
                            case "P_per_con":
                                result = "বসছে";
                                break;
                            case "Pa_in":
                                result = "বসেছিলো";
                                break;
                            case "Pa_con":
                                result = "বসছিলো";
                                break;
                            case "Pa_per":
                                result = "বসেছিলো";
                                break;
                            case "Pa_per_con":
                                result = "বসছিলো";
                                break;
                            case "F_in":
                                result = "বসবে";
                                break;
                            case "F_con":
                                result = "বসতে থাকবে";
                                break;
                            case "F_per":
                                result = "বসবে";
                                break;
                            case "F_per_con":
                                result = "বসতে থাকবে";
                                break;
                            default: break;
                        }
                    }
                    else if (verb.Contains("বসান") || verb == "বসান")
                    {
                        switch (verb_tag)
                        {
                            case "P_in":
                                result = "বসায়";
                                break;
                            case "P_con":
                                result = "বসাচ্ছে";
                                break;
                            case "P_per":
                                result = "বসিয়েছে";
                                break;
                            case "P_per_con":
                                result = "বসাচ্ছে";
                                break;
                            case "Pa_in":
                                result = "বসিয়েছিলো";
                                break;
                            case "Pa_con":
                                result = "বসাচ্ছিলো ";
                                break;
                            case "Pa_per":
                                result = "বসিয়েছিলো";
                                break;
                            case "Pa_per_con":
                                result = "বসাচ্ছিলো ";
                                break;
                            case "F_in":
                                result = "বসাবে";
                                break;
                            case "F_con":
                                result = "বসাতে থাকবে";
                                break;
                            case "F_per":
                                result = "বসাবে";
                                break;
                            case "F_per_con":
                                result = "বসাতে থাকবে";
                                break;
                            default: break;
                        }
                    }
                    else if (verb.Contains("বলা") || verb == "বলা")
                    {
                        switch (verb_tag)
                        {
                            case "P_in":
                                result = "বলে";
                                break;
                            case "P_con":
                                result = "বলছে";
                                break;
                            case "P_per":
                                result = "বলেছে";
                                break;
                            case "P_per_con":
                                result = "বলছে";
                                break;
                            case "Pa_in":
                                result = "বলেছিলো";
                                break;
                            case "Pa_con":
                                result = "বলছিলো";
                                break;
                            case "Pa_per":
                                result = "বলেছিলো";
                                break;
                            case "Pa_per_con":
                                result = "বলছিলো";
                                break;
                            case "F_in":
                                result = "বলবে";
                                break;
                            case "F_con":
                                result = "বলতে থাকবে";
                                break;
                            case "F_per":
                                result = "বলবে";
                                break;
                            case "F_per_con":
                                result = "বলতে থাকবে";
                                break;
                            default: break;
                        }
                    }
                    else if (verb.Contains("বানান") || verb == "বানান")
                    {
                        switch (verb_tag)
                        {
                            case "P_in":
                                result = "বানায়";
                                break;
                            case "P_con":
                                result = "বানাচ্ছে ";
                                break;
                            case "P_per":
                                result = "বানিয়েছে ";
                                break;
                            case "P_per_con":
                                result = "বানাচ্ছে ";
                                break;
                            case "Pa_in":
                                result = "বানিয়েছিলো";
                                break;
                            case "Pa_con":
                                result = "বানাচ্ছিলো";
                                break;
                            case "Pa_per":
                                result = "বানিয়েছিলো";
                                break;
                            case "Pa_per_con":
                                result = "বানাচ্ছিলো";
                                break;
                            case "F_in":
                                result = "বানাবে";
                                break;
                            case "F_con":
                                result = "বানাতে থাকবে";
                                break;
                            case "F_per":
                                result = "বানাবে";
                                break;
                            case "F_per_con":
                                result = "বানাতে থাকবে";
                                break;
                            default: break;
                        }
                    }
                    else if (verb.Contains("বাড়ান") || verb == "বাড়ান")
                    {
                        switch (verb_tag)
                        {
                            case "P_in":
                                result = "বাড়ায়";
                                break;
                            case "P_con":
                                result = "বাড়াচ্ছে";
                                break;
                            case "P_per":
                                result = "বাড়িয়েছে";
                                break;
                            case "P_per_con":
                                result = "বাড়াচ্ছে";
                                break;
                            case "Pa_in":
                                result = "বাড়িয়েছিলো";
                                break;
                            case "Pa_con":
                                result = "বাড়াচ্ছিলো";
                                break;
                            case "Pa_per":
                                result = "বাড়িয়েছিলো";
                                break;
                            case "Pa_per_con":
                                result = "বাড়াচ্ছিলো";
                                break;
                            case "F_in":
                                result = "বাড়াবে";
                                break;
                            case "F_con":
                                result = "বাড়াতে থাকবে";
                                break;
                            case "F_per":
                                result = "বাড়াবে";
                                break;
                            case "F_per_con":
                                result = "বাড়াতে থাকবে";
                                break;
                            default: break;
                        }
                    }
                    else if (verb.Contains("বোঝানো") || verb == "বোঝানো")
                    {
                        switch (verb_tag)
                        {
                            case "P_in":
                                result = "বুঝায়";
                                break;
                            case "P_con":
                                result = "বুঝাচ্ছে";
                                break;
                            case "P_per":
                                result = "বুঝিয়েছে";
                                break;
                            case "P_per_con":
                                result = "বুঝাচ্ছে";
                                break;
                            case "Pa_in":
                                result = "বুঝিয়েছিলো";
                                break;
                            case "Pa_con":
                                result = "বুঝাচ্ছিলো";
                                break;
                            case "Pa_per":
                                result = "বুঝিয়েছিলো";
                                break;
                            case "Pa_per_con":
                                result = "বুঝাচ্ছিলো";
                                break;
                            case "F_in":
                                result = "বুঝাবে";
                                break;
                            case "F_con":
                                result = "বোঝাতে থাকবে";
                                break;
                            case "F_per":
                                result = "বুঝাবে";
                                break;
                            case "F_per_con":
                                result = "বোঝাতে থাকবে";
                                break;
                            default: break;
                        }
                    }
                    else if (verb.Contains("বাজান") || verb == "বাজান")
                    {
                        switch (verb_tag)
                        {
                            case "P_in":
                                result = "বাজায়";
                                break;
                            case "P_con":
                                result = "বাজাচ্ছে";
                                break;
                            case "P_per":
                                result = "বাজিয়েছে";
                                break;
                            case "P_per_con":
                                result = "বাজাচ্ছে";
                                break;
                            case "Pa_in":
                                result = "বাজিয়েছিলো";
                                break;
                            case "Pa_con":
                                result = "বাজাচ্ছিলো";
                                break;
                            case "Pa_per":
                                result = "বাজিয়েছিলো";
                                break;
                            case "Pa_per_con":
                                result = "বাজাচ্ছিলো";
                                break;
                            case "F_in":
                                result = "বাজাবে";
                                break;
                            case "F_con":
                                result = "বাজাতে থাকবে";
                                break;
                            case "F_per":
                                result = "বাজাবে";
                                break;
                            case "F_per_con":
                                result = "বাজাতে থাকবে";
                                break;
                            default: break;
                        }
                    }
                    else if (verb.Contains("চাওয়া") || verb == "চাওয়া")
                    {
                        switch (verb_tag)
                        {
                            case "P_in":
                                result = "চায়";
                                break;
                            case "P_con":
                                result = "চাচ্ছে";
                                break;
                            case "P_per":
                                result = "চেয়েছে";
                                break;
                            case "P_per_con":
                                result = "চাচ্ছে";
                                break;
                            case "Pa_in":
                                result = "চেয়েছিলো";
                                break;
                            case "Pa_con":
                                result = "চাচ্ছিলো";
                                break;
                            case "Pa_per":
                                result = "চেয়েছিলো";
                                break;
                            case "Pa_per_con":
                                result = "চাচ্ছিলো";
                                break;
                            case "F_in":
                                result = "চাইবে";
                                break;
                            case "F_con":
                                result = "চাইতে থাকবে";
                                break;
                            case "F_per":
                                result = "চাইবে";
                                break;
                            case "F_per_con":
                                result = "চাইতে থাকবে";
                                break;
                            default: break;
                        }
                    }
                    else if (verb.Contains("চাটা") || verb == "চাটা")
                    {
                        switch (verb_tag)
                        {
                            case "P_in":
                                result = "চাটে";
                                break;
                            case "P_con":
                                result = "চাটছিলো";
                                break;
                            case "P_per":
                                result = "চেটেছে";
                                break;
                            case "P_per_con":
                                result = "চাটছিলো";
                                break;
                            case "Pa_in":
                                result = "চেঁটেছিলো";
                                break;
                            case "Pa_con":
                                result = "চাটছিলো";
                                break;
                            case "Pa_per":
                                result = "চেঁটেছিলো";
                                break;
                            case "Pa_per_con":
                                result = "চাটছিলো";
                                break;
                            case "F_in":
                                result = "চাটবে";
                                break;
                            case "F_con":
                                result = "চাটতে থাকবে";
                                break;
                            case "F_per":
                                result = "চাটবে";
                                break;
                            case "F_per_con":
                                result = "চাটতে থাকবে";
                                break;
                            default: break;
                        }
                    }
                    else if (verb.Contains("ছড়ান") || verb == "ছড়ান")
                    {
                        switch (verb_tag)
                        {
                            case "P_in":
                                result = "ছড়ায়";
                                break;
                            case "P_con":
                                result = "ছড়াচ্ছে";
                                break;
                            case "P_per":
                                result = "ছড়িয়েছে";
                                break;
                            case "P_per_con":
                                result = "ছড়াচ্ছে";
                                break;
                            case "Pa_in":
                                result = "ছড়িয়েছিলো";
                                break;
                            case "Pa_con":
                                result = "ছড়াচ্ছিলো";
                                break;
                            case "Pa_per":
                                result = "ছড়িয়েছিলো";
                                break;
                            case "Pa_per_con":
                                result = "ছড়াচ্ছিলো";
                                break;
                            case "F_in":
                                result = "ছড়াবে";
                                break;
                            case "F_con":
                                result = "ছড়াতে থাকবে";
                                break;
                            case "F_per":
                                result = "ছড়াবে";
                                break;
                            case "F_per_con":
                                result = "ছড়াতে থাকবে";
                                break;
                            default: break;
                        }
                    }
                    else if (verb.Contains("চেনা") || verb == "চেনা")
                    {
                        switch (verb_tag)
                        {
                            case "P_in":
                                result = "চিনে";
                                break;
                            case "P_con":
                                result = "চিনছে";
                                break;
                            case "P_per":
                                result = "চিনেছে";
                                break;
                            case "P_per_con":
                                result = "চিনছে";
                                break;
                            case "Pa_in":
                                result = "চিনেছিলো";
                                break;
                            case "Pa_con":
                                result = "চিনতেছিলো";
                                break;
                            case "Pa_per":
                                result = "চিনেছিলো";
                                break;
                            case "Pa_per_con":
                                result = "চিনতেছিলো";
                                break;
                            case "F_in":
                                result = "চিনবে";
                                break;
                            case "F_con":
                                result = "চিনতে থাকবে";
                                break;
                            case "F_per":
                                result = "চিনবে";
                                break;
                            case "F_per_con":
                                result = "চিনতে থাকবে";
                                break;
                            default: break;
                        }
                    }
                    else if (verb.Contains("চিবান") || verb == "চিবান")
                    {
                        switch (verb_tag)
                        {
                            case "P_in":
                                result = "চিবায়";
                                break;
                            case "P_con":
                                result = "চিবাচ্ছে";
                                break;
                            case "P_per":
                                result = "চিবিয়েছে";
                                break;
                            case "P_per_con":
                                result = "চিবাচ্ছে";
                                break;
                            case "Pa_in":
                                result = "চিবিয়েছিলো";
                                break;
                            case "Pa_con":
                                result = "চিবাচ্ছিলো";
                                break;
                            case "Pa_per":
                                result = "চিবিয়েছিলো";
                                break;
                            case "Pa_per_con":
                                result = "চিবাচ্ছিলো";
                                break;
                            case "F_in":
                                result = "চিবাবে";
                                break;
                            case "F_con":
                                result = "চিবাতে থাকবে";
                                break;
                            case "F_per":
                                result = "চিবাবে";
                                break;
                            case "F_per_con":
                                result = "চিবাতে থাকবে";
                                break;
                            default: break;
                        }
                    }
                    else if (verb.Contains("চালান") || verb == "চালান")
                    {
                        switch (verb_tag)
                        {
                            case "P_in":
                                result = "চালায়";
                                break;
                            case "P_con":
                                result = "চালাচ্ছে";
                                break;
                            case "P_per":
                                result = "চালিয়েছে";
                                break;
                            case "P_per_con":
                                result = "চালাচ্ছে";
                                break;
                            case "Pa_in":
                                result = "চালিয়েছিলো";
                                break;
                            case "Pa_con":
                                result = "চালাচ্ছিলো";
                                break;
                            case "Pa_per":
                                result = "চালিয়েছিলো";
                                break;
                            case "Pa_per_con":
                                result = "চালাচ্ছিলো";
                                break;
                            case "F_in":
                                result = "চালাবে";
                                break;
                            case "F_con":
                                result = "চালাতে থাকবে";
                                break;
                            case "F_per":
                                result = "চালাবে";
                                break;
                            case "F_per_con":
                                result = "চালাতে থাকবে";
                                break;
                            default: break;
                        }
                    }
                    else if (verb.Contains("দেয়া") || verb == "দেয়া")
                    {
                        switch (verb_tag)
                        {
                            case "P_in":
                                result = "দেয়";
                                break;
                            case "P_con":
                                result = "দিচ্ছে";
                                break;
                            case "P_per":
                                result = "দিয়েছে";
                                break;
                            case "P_per_con":
                                result = "দিচ্ছে";
                                break;
                            case "Pa_in":
                                result = "দিয়েছিলো";
                                break;
                            case "Pa_con":
                                result = "দিচ্ছিলো";
                                break;
                            case "Pa_per":
                                result = "দিয়েছিলো";
                                break;
                            case "Pa_per_con":
                                result = "দিচ্ছিলো";
                                break;
                            case "F_in":
                                result = "দিবে";
                                break;
                            case "F_con":
                                result = "দিতে থাকবে";
                                break;
                            case "F_per":
                                result = "দিবে";
                                break;
                            case "F_per_con":
                                result = "দিতে থাকবে";
                                break;
                            default: break;
                        }
                    }
                    else if (verb.Contains("দেখা") || verb == "দেখা")
                    {
                        switch (verb_tag)
                        {
                            case "P_in":
                                result = "দেখে";
                                break;
                            case "P_con":
                                result = "দেখছে";
                                break;
                            case "P_per":
                                result = "দেখেছে";
                                break;
                            case "P_per_con":
                                result = "দেখছে";
                                break;
                            case "Pa_in":
                                result = "দেখেছিলো";
                                break;
                            case "Pa_con":
                                result = "দেখছিলো";
                                break;
                            case "Pa_per":
                                result = "দেখেছিলো";
                                break;
                            case "Pa_per_con":
                                result = "দেখছিলো";
                                break;
                            case "F_in":
                                result = "দেখবে";
                                break;
                            case "F_con":
                                result = "দেখতে থাকবে";
                                break;
                            case "F_per":
                                result = "দেখবে";
                                break;
                            case "F_per_con":
                                result = "দেখতে থাকবে";
                                break;
                            default: break;
                        }
                    }
                    else if (verb.Contains("দাঁড়ান") || verb == "দাঁড়ান")
                    {
                        switch (verb_tag)
                        {
                            case "P_in":
                                result = "দাঁড়ায়";
                                break;
                            case "P_con":
                                result = "দাঁড়াচ্ছে";
                                break;
                            case "P_per":
                                result = "দাঁড়িয়েছে";
                                break;
                            case "P_per_con":
                                result = "দাঁড়াচ্ছে";
                                break;
                            case "Pa_in":
                                result = "দাঁড়িয়েছিলো";
                                break;
                            case "Pa_con":
                                result = "দাঁড়াচ্ছিলো";
                                break;
                            case "Pa_per":
                                result = "দাঁড়িয়েছিলো";
                                break;
                            case "Pa_per_con":
                                result = "দাঁড়াচ্ছিলো";
                                break;
                            case "F_in":
                                result = "দাঁড়াবে";
                                break;
                            case "F_con":
                                result = "দাঁড়িয়ে থাকবে";
                                break;
                            case "F_per":
                                result = "দাঁড়াবে";
                                break;
                            case "F_per_con":
                                result = "দাঁড়িয়ে থাকবে";
                                break;
                            default: break;
                        }
                    }
                    else if (verb.Contains("দেখানো") || verb == "দেখানো")
                    {
                        switch (verb_tag)
                        {
                            case "P_in":
                                result = "দেখায়";
                                break;
                            case "P_con":
                                result = "দেখাচ্ছে";
                                break;
                            case "P_per":
                                result = "দেখিয়েছে";
                                break;
                            case "P_per_con":
                                result = "দেখাচ্ছে";
                                break;
                            case "Pa_in":
                                result = "দেখিয়েছিলো";
                                break;
                            case "Pa_con":
                                result = "দেখাচ্ছিলো";
                                break;
                            case "Pa_per":
                                result = "দেখিয়েছিলো";
                                break;
                            case "Pa_per_con":
                                result = "দেখাচ্ছিলো";
                                break;
                            case "F_in":
                                result = "দেখাবে";
                                break;
                            case "F_con":
                                result = "দেখাইতে থাকবে";
                                break;
                            case "F_per":
                                result = "দেখাবে";
                                break;
                            case "F_per_con":
                                result = "দেখাইতে থাকবে";
                                break;
                            default: break;
                        }
                    }
                    else if (verb.Contains("ঢাকা") || verb == "ঢাকা")
                    {
                        switch (verb_tag)
                        {
                            case "P_in":
                                result = "ঢাকে";
                                break;
                            case "P_con":
                                result = "ঢাকছে";
                                break;
                            case "P_per":
                                result = "ঢেকেছে";
                                break;
                            case "P_per_con":
                                result = "ঢাকছে";
                                break;
                            case "Pa_in":
                                result = "ঢেকেছিলো";
                                break;
                            case "Pa_con":
                                result = "ঢাকছিলো";
                                break;
                            case "Pa_per":
                                result = "ঢেকেছিলো";
                                break;
                            case "Pa_per_con":
                                result = "ঢাকছিলো";
                                break;
                            case "F_in":
                                result = "ঢাকবে";
                                break;
                            case "F_con":
                                result = "ঢাকতে থাকবে";
                                break;
                            case "F_per":
                                result = "ঢাকবে";
                                break;
                            case "F_per_con":
                                result = "ঢাকতে থাকবে";
                                break;
                            default: break;
                        }
                    }
                    else if (verb.Contains("ডাকা") || verb == "ডাকা")
                    {
                        switch (verb_tag)
                        {
                            case "P_in":
                                result = "ডাকে";
                                break;
                            case "P_con":
                                result = "ডাকছে";
                                break;
                            case "P_per":
                                result = "ডেকেছে";
                                break;
                            case "P_per_con":
                                result = "ডাকছে";
                                break;
                            case "Pa_in":
                                result = "ডেকেছিলো";
                                break;
                            case "Pa_con":
                                result = "ডাকছিলো";
                                break;
                            case "Pa_per":
                                result = "ডেকেছিলো";
                                break;
                            case "Pa_per_con":
                                result = "ডাকছিলো";
                                break;
                            case "F_in":
                                result = "ডাকবে";
                                break;
                            case "F_con":
                                result = "ডাকতে থাকবে";
                                break;
                            case "F_per":
                                result = "ডাকবে";
                                break;
                            case "F_per_con":
                                result = "ডাকতে থাকবে";
                                break;
                            default: break;
                        }
                    }
                    else if (verb.Contains("ধরা") || verb == "ধরা")
                    {
                        switch (verb_tag)
                        {
                            case "P_in":
                                result = "ধরে";
                                break;
                            case "P_con":
                                result = "ধরছে";
                                break;
                            case "P_per":
                                result = "ধরেছে";
                                break;
                            case "P_per_con":
                                result = "ধরছে";
                                break;
                            case "Pa_in":
                                result = "ধরেছিলো";
                                break;
                            case "Pa_con":
                                result = "ধরতেছিলো";
                                break;
                            case "Pa_per":
                                result = "ধরেছিলো";
                                break;
                            case "Pa_per_con":
                                result = "ধরতেছিলো";
                                break;
                            case "F_in":
                                result = "ধরবে";
                                break;
                            case "F_con":
                                result = "ধরতে থাকবে";
                                break;
                            case "F_per":
                                result = "ধরবে";
                                break;
                            case "F_per_con":
                                result = "ধরতে থাকবে";
                                break;
                            default: break;
                        }
                    }
                    else if (verb.Contains("ডিঙ্গান") || verb == "ডিঙ্গান")
                    {
                        switch (verb_tag)
                        {
                            case "P_in":
                                result = "ডিঙ্গায়";
                                break;
                            case "P_con":
                                result = "ডিঙ্গাচ্ছে";
                                break;
                            case "P_per":
                                result = "ডিঙিয়েছে";
                                break;
                            case "P_per_con":
                                result = "ডিঙ্গাচ্ছে";
                                break;
                            case "Pa_in":
                                result = "ডিঙ্গিয়েছিলো";
                                break;
                            case "Pa_con":
                                result = "ডিঙ্গাচ্ছিলো";
                                break;
                            case "Pa_per":
                                result = "ডিঙ্গিয়েছিলো";
                                break;
                            case "Pa_per_con":
                                result = "ডিঙ্গাচ্ছিলো";
                                break;
                            case "F_in":
                                result = "ডিঙ্গাবে";
                                break;
                            case "F_con":
                                result = "ডিঙ্গাইতে থাকবে";
                                break;
                            case "F_per":
                                result = "ডিঙ্গাবে";
                                break;
                            case "F_per_con":
                                result = "ডিঙ্গাইতে থাকবে";
                                break;
                            default: break;
                        }
                    }
                    else if (verb.Contains("ঢোকান") || verb == "ঢোকান")
                    {
                        switch (verb_tag)
                        {
                            case "P_in":
                                result = "ঢোকায়";
                                break;
                            case "P_con":
                                result = "ঢুকাচ্ছে";
                                break;
                            case "P_per":
                                result = "ঢুকিয়েছে";
                                break;
                            case "P_per_con":
                                result = "ঢুকাচ্ছে";
                                break;
                            case "Pa_in":
                                result = "ঢুকিয়েছিলো";
                                break;
                            case "Pa_con":
                                result = "ঢুকাচ্ছিলো";
                                break;
                            case "Pa_per":
                                result = "ঢুকিয়েছিলো";
                                break;
                            case "Pa_per_con":
                                result = "ঢুকাচ্ছিলো";
                                break;
                            case "F_in":
                                result = "ঢুকাবে";
                                break;
                            case "F_con":
                                result = "ঢুকাইতে থাকবে";
                                break;
                            case "F_per":
                                result = "ঢুকাবে";
                                break;
                            case "F_per_con":
                                result = "ঢুকাইতে থাকবে";
                                break;
                            default: break;
                        }
                    }
                    else if (verb.Contains("ফেরা") || verb == "ফেরা")
                    {
                        switch (verb_tag)
                        {
                            case "P_in":
                                result = "ফিরে";
                                break;
                            case "P_con":
                                result = "ফিরছে";
                                break;
                            case "P_per":
                                result = "ফিরেছে";
                                break;
                            case "P_per_con":
                                result = "ফিরছে";
                                break;
                            case "Pa_in":
                                result = "ফিরেছিলো";
                                break;
                            case "Pa_con":
                                result = "ফিরতেছিলো";
                                break;
                            case "Pa_per":
                                result = "ফিরেছিলো";
                                break;
                            case "Pa_per_con":
                                result = "ফিরতেছিলো";
                                break;
                            case "F_in":
                                result = "ফিরবে";
                                break;
                            case "F_con":
                                result = "ফিরতে থাকবে";
                                break;
                            case "F_per":
                                result = "ফিরবে";
                                break;
                            case "F_per_con":
                                result = "ফিরতে থাকবে";
                                break;
                            default: break;
                        }
                    }
                    else if (verb.Contains("ফেলা") || verb == "ফেলা")
                    {
                        switch (verb_tag)
                        {
                            case "P_in":
                                result = "ফেলে";
                                break;
                            case "P_con":
                                result = "ফেলছে";
                                break;
                            case "P_per":
                                result = "ফেলেছে";
                                break;
                            case "P_per_con":
                                result = "ফেলছে";
                                break;
                            case "Pa_in":
                                result = "ফেলেছিলো";
                                break;
                            case "Pa_con":
                                result = "ফেলছিলো";
                                break;
                            case "Pa_per":
                                result = "ফেলেছিলো";
                                break;
                            case "Pa_per_con":
                                result = "ফেলছিলো";
                                break;
                            case "F_in":
                                result = "ফেলাবে";
                                break;
                            case "F_con":
                                result = "ফেলতে থাকবে";
                                break;
                            case "F_per":
                                result = "ফেলাবে";
                                break;
                            case "F_per_con":
                                result = "ফেলতে থাকবে";
                                break;
                            default: break;
                        }
                    }
                    else if (verb.Contains("ফুটান") || verb == "ফুটান")
                    {
                        switch (verb_tag)
                        {
                            case "P_in":
                                result = "ফুটায়";
                                break;
                            case "P_con":
                                result = "ফুটাচ্ছে";
                                break;
                            case "P_per":
                                result = "ফুটাইছে";
                                break;
                            case "P_per_con":
                                result = "ফুটাচ্ছে";
                                break;
                            case "Pa_in":
                                result = "ফুটিয়েছিলো";
                                break;
                            case "Pa_con":
                                result = "ফুটাচ্ছিলো";
                                break;
                            case "Pa_per":
                                result = "ফুটিয়েছিলো";
                                break;
                            case "Pa_per_con":
                                result = "ফুটাচ্ছিলো";
                                break;
                            case "F_in":
                                result = "ফুটাবে";
                                break;
                            case "F_con":
                                result = "ফুটাইতে থাকবে";
                                break;
                            case "F_per":
                                result = "ফুটাবে";
                                break;
                            case "F_per_con":
                                result = "ফুটাইতে থাকবে";
                                break;
                            default: break;
                        }
                    }
                    else if (verb.Contains("ঘটা") || verb == "ঘটা")
                    {
                        switch (verb_tag)
                        {
                            case "P_in":
                                result = "ঘটায়";
                                break;
                            case "P_con":
                                result = "ঘটাচ্ছে";
                                break;
                            case "P_per":
                                result = "ঘটিয়েছে";
                                break;
                            case "P_per_con":
                                result = "ঘটাচ্ছে";
                                break;
                            case "Pa_in":
                                result = "ঘটিয়েছিলো";
                                break;
                            case "Pa_con":
                                result = "ঘটাচ্ছিলো";
                                break;
                            case "Pa_per":
                                result = "ঘটিয়েছিলো";
                                break;
                            case "Pa_per_con":
                                result = "ঘটাচ্ছিলো";
                                break;
                            case "F_in":
                                result = "ঘটাবে";
                                break;
                            case "F_con":
                                result = "ঘটাইতে থাকবে";
                                break;
                            case "F_per":
                                result = "ঘটাবে";
                                break;
                            case "F_per_con":
                                result = "ঘটাইতে থাকবে";
                                break;
                            default: break;
                        }
                    }
                    else if (verb.Contains("গুটান") || verb == "গুটান")
                    {
                        switch (verb_tag)
                        {
                            case "P_in":
                                result = "গুটায়";
                                break;
                            case "P_con":
                                result = "গুটাচ্ছে";
                                break;
                            case "P_per":
                                result = "গুটাইছে";
                                break;
                            case "P_per_con":
                                result = "গুটাচ্ছে";
                                break;
                            case "Pa_in":
                                result = "গুটিয়েছিলো";
                                break;
                            case "Pa_con":
                                result = "গুটাচ্ছিলো";
                                break;
                            case "Pa_per":
                                result = "গুটিয়েছিলো";
                                break;
                            case "Pa_per_con":
                                result = "গুটাচ্ছিলো";
                                break;
                            case "F_in":
                                result = "গুটাবে";
                                break;
                            case "F_con":
                                result = "গুটাইতে থাকবে";
                                break;
                            case "F_per":
                                result = "গুটাবে";
                                break;
                            case "F_per_con":
                                result = "গুটাইতে থাকবে";
                                break;
                            default: break;
                        }
                    }
                    else if (verb.Contains("ঘুমান") || verb == "ঘুমান")
                    {
                        switch (verb_tag)
                        {
                            case "P_in":
                                result = "ঘুমায়";
                                break;
                            case "P_con":
                                result = "ঘুমাচ্ছে";
                                break;
                            case "P_per":
                                result = "ঘুমিয়েছে";
                                break;
                            case "P_per_con":
                                result = "ঘুমাচ্ছে";
                                break;
                            case "Pa_in":
                                result = "ঘুমিয়েছিলো";
                                break;
                            case "Pa_con":
                                result = "ঘুমাচ্ছিলো";
                                break;
                            case "Pa_per":
                                result = "ঘুমিয়েছিলো";
                                break;
                            case "Pa_per_con":
                                result = "ঘুমাচ্ছিলো";
                                break;
                            case "F_in":
                                result = "ঘুমাবে";
                                break;
                            case "F_con":
                                result = "ঘুমাইতে থাকবে";
                                break;
                            case "F_per":
                                result = "ঘুমাবে";
                                break;
                            case "F_per_con":
                                result = "ঘুমাইতে থাকবে";
                                break;
                            default: break;
                        }
                    }
                    else if (verb.Contains("গাওয়া") || verb == "গাওয়া")
                    {
                        switch (verb_tag)
                        {
                            case "P_in":
                                result = "গায়";
                                break;
                            case "P_con":
                                result = "গাচ্ছিলো";
                                break;
                            case "P_per":
                                result = "গেয়েছে";
                                break;
                            case "P_per_con":
                                result = "গাচ্ছিলো";
                                break;
                            case "Pa_in":
                                result = "গেয়েছিলো";
                                break;
                            case "Pa_con":
                                result = "গাচ্ছিলো";
                                break;
                            case "Pa_per":
                                result = "গেয়েছিলো";
                                break;
                            case "Pa_per_con":
                                result = "গাচ্ছিলো";
                                break;
                            case "F_in":
                                result = "গাবে";
                                break;
                            case "F_con":
                                result = "গাইতে থাকবে";
                                break;
                            case "F_per":
                                result = "গাবে";
                                break;
                            case "F_per_con":
                                result = "গাইতে থাকবে";
                                break;
                            default: break;
                        }
                    }
                    else if (verb.Contains("গোঙান") || verb == "গোঙান")
                    {
                        switch (verb_tag)
                        {
                            case "P_in":
                                result = "গোঙায়";
                                break;
                            case "P_con":
                                result = "গুঙ্গাচ্ছে";
                                break;
                            case "P_per":
                                result = "গুঙ্গিয়েছে";
                                break;
                            case "P_per_con":
                                result = "গুঙ্গাচ্ছে";
                                break;
                            case "Pa_in":
                                result = "গুঙিয়েছিলো";
                                break;
                            case "Pa_con":
                                result = "গুঙ্গাচ্ছিলো";
                                break;
                            case "Pa_per":
                                result = "গুঙিয়েছিলো";
                                break;
                            case "Pa_per_con":
                                result = "গুঙ্গাচ্ছিলো";
                                break;
                            case "F_in":
                                result = "গুঙ্গাবে";
                                break;
                            case "F_con":
                                result = "গুঙ্গাতে থাকবে";
                                break;
                            case "F_per":
                                result = "গুঙ্গাবে";
                                break;
                            case "F_per_con":
                                result = "গুঙ্গাতে থাকবে";
                                break;
                            default: break;
                        }
                    }
                    else if (verb.Contains("হওয়া") || verb == "হওয়া")
                    {
                        switch (verb_tag)
                        {
                            case "P_in":
                                result = "হয়";
                                break;
                            case "P_con":
                                result = "হচ্ছে";
                                break;
                            case "P_per":
                                result = "হয়েছে";
                                break;
                            case "P_per_con":
                                result = "হচ্ছে";
                                break;
                            case "Pa_in":
                                result = "হয়েছিলো";
                                break;
                            case "Pa_con":
                                result = "হচ্ছিলো";
                                break;
                            case "Pa_per":
                                result = "হয়েছিলো";
                                break;
                            case "Pa_per_con":
                                result = "হচ্ছিলো";
                                break;
                            case "F_in":
                                result = "হবে";
                                break;
                            case "F_con":
                                result = "হইতে থাকবে";
                                break;
                            case "F_per":
                                result = "হবে";
                                break;
                            case "F_per_con":
                                result = "হইতে থাকবে";
                                break;
                            default: break;
                        }
                    }
                    else if (verb.Contains("হাসা") || verb == "হাসা")
                    {
                        switch (verb_tag)
                        {
                            case "P_in":
                                result = "হাসে";
                                break;
                            case "P_con":
                                result = "হাসছে";
                                break;
                            case "P_per":
                                result = "হেসেছে";
                                break;
                            case "P_per_con":
                                result = "হাসছে";
                                break;
                            case "Pa_in":
                                result = "হেসেছিলো";
                                break;
                            case "Pa_con":
                                result = "হাসছিলো";
                                break;
                            case "Pa_per":
                                result = "হেসেছিলো";
                                break;
                            case "Pa_per_con":
                                result = "হাসছিলো";
                                break;
                            case "F_in":
                                result = "হাসবে";
                                break;
                            case "F_con":
                                result = "হাসতে থাকবে";
                                break;
                            case "F_per":
                                result = "হাসবে";
                                break;
                            case "F_per_con":
                                result = "হাসতে থাকবে";
                                break;
                            default: break;
                        }
                    }
                    else if (verb.Contains("জানান") || verb == "জানান")
                    {
                        switch (verb_tag)
                        {
                            case "P_in":
                                result = "জানায়";
                                break;
                            case "P_con":
                                result = "জানাচ্ছে";
                                break;
                            case "P_per":
                                result = "জানিয়েছে";
                                break;
                            case "P_per_con":
                                result = "জানাচ্ছে";
                                break;
                            case "Pa_in":
                                result = "জানিয়েছিলো";
                                break;
                            case "Pa_con":
                                result = "জানাচ্ছিলো";
                                break;
                            case "Pa_per":
                                result = "জানিয়েছিলো";
                                break;
                            case "Pa_per_con":
                                result = "জানাচ্ছিলো";
                                break;
                            case "F_in":
                                result = "জানাবে";
                                break;
                            case "F_con":
                                result = "জানাইতে থাকবে";
                                break;
                            case "F_per":
                                result = "জানাবে";
                                break;
                            case "F_per_con":
                                result = "জানাইতে থাকবে";
                                break;
                            default: break;
                        }
                    }
                    else if (verb.Contains("যাওয়া") || verb == "যাওয়া")
                    {
                        switch (verb_tag)
                        {
                            case "P_in":
                                result = "যায়";
                                break;
                            case "P_con":
                                result = "যাচ্ছে";
                                break;
                            case "P_per":
                                result = "গিয়েছে";
                                break;
                            case "P_per_con":
                                result = "যাচ্ছে";
                                break;
                            case "Pa_in":
                                result = "গিয়েছিলো";
                                break;
                            case "Pa_con":
                                result = "যাচ্ছিলো";
                                break;
                            case "Pa_per":
                                result = "গিয়েছিলো";
                                break;
                            case "Pa_per_con":
                                result = "যাচ্ছিলো";
                                break;
                            case "F_in":
                                result = "যাবে";
                                break;
                            case "F_con":
                                result = "যাইতে থাকবে";
                                break;
                            case "F_per":
                                result = "যাবে";
                                break;
                            case "F_per_con":
                                result = "যাইতে থাকবে";
                                break;
                            default: break;
                        }
                    }
                    else if (verb.Contains("জ্বালান") || verb == "জ্বালান")
                    {
                        switch (verb_tag)
                        {
                            case "P_in":
                                result = "জ্বালায়";
                                break;
                            case "P_con":
                                result = "জ্বালাচ্ছে";
                                break;
                            case "P_per":
                                result = "জ্বালাবে";
                                break;
                            case "P_per_con":
                                result = "জ্বালাচ্ছে";
                                break;
                            case "Pa_in":
                                result = "জ্বালিয়েছিলো";
                                break;
                            case "Pa_con":
                                result = "জ্বালাচ্ছিলো";
                                break;
                            case "Pa_per":
                                result = "জ্বালিয়েছিলো";
                                break;
                            case "Pa_per_con":
                                result = "জ্বালাচ্ছিলো";
                                break;
                            case "F_in":
                                result = "জ্বালাবে";
                                break;
                            case "F_con":
                                result = "জ্বালাইতে থাকবে";
                                break;
                            case "F_per":
                                result = "জ্বালাবে";
                                break;
                            case "F_per_con":
                                result = "জ্বালাইতে থাকবে";
                                break;
                            default: break;
                        }
                    }
                    else if (verb.Contains("জাগা") || verb == "জাগা")
                    {
                        switch (verb_tag)
                        {
                            case "P_in":
                                result = "জাগে";
                                break;
                            case "P_con":
                                result = "জাগছে";
                                break;
                            case "P_per":
                                result = "জেগেছে";
                                break;
                            case "P_per_con":
                                result = "জাগছে";
                                break;
                            case "Pa_in":
                                result = "জেগেছিলো";
                                break;
                            case "Pa_con":
                                result = "জাগছিলো";
                                break;
                            case "Pa_per":
                                result = "জেগেছিলো";
                                break;
                            case "Pa_per_con":
                                result = "জাগছিলো";
                                break;
                            case "F_in":
                                result = "জাগবে";
                                break;
                            case "F_con":
                                result = "জাগতে থাকবে";
                                break;
                            case "F_per":
                                result = "জাগবে";
                                break;
                            case "F_per_con":
                                result = "জাগতে থাকবে";
                                break;
                            default: break;
                        }
                    }
                    else if (verb.Contains("ঝাড়া") || verb == "ঝাড়া")
                    {
                        switch (verb_tag)
                        {
                            case "P_in":
                                result = "ঝাড়ে";
                                break;
                            case "P_con":
                                result = "ঝাড়ছে";
                                break;
                            case "P_per":
                                result = "ঝেড়েছে";
                                break;
                            case "P_per_con":
                                result = "ঝাড়ছে";
                                break;
                            case "Pa_in":
                                result = "ঝেড়েছিলো";
                                break;
                            case "Pa_con":
                                result = "ঝাড়তেছিলো";
                                break;
                            case "Pa_per":
                                result = "ঝেড়েছিলো";
                                break;
                            case "Pa_per_con":
                                result = "ঝাড়তেছিলো";
                                break;
                            case "F_in":
                                result = "ঝাড়বে";
                                break;
                            case "F_con":
                                result = "ঝাড়তে থাকবে";
                                break;
                            case "F_per":
                                result = "ঝাড়বে";
                                break;
                            case "F_per_con":
                                result = "ঝাড়তে থাকবে";
                                break;
                            default: break;
                        }
                    }
                    else if (verb.Contains("জন্মান") || verb == "জন্মান")
                    {
                        switch (verb_tag)
                        {
                            case "P_in":
                                result = "জন্মায়";
                                break;
                            case "P_con":
                                result = "জন্মাচ্ছে";
                                break;
                            case "P_per":
                                result = "জন্মেছে";
                                break;
                            case "P_per_con":
                                result = "জন্মাচ্ছে";
                                break;
                            case "Pa_in":
                                result = "জন্মেছিলো";
                                break;
                            case "Pa_con":
                                result = "জন্মেতেছিলো";
                                break;
                            case "Pa_per":
                                result = "জন্মেছিলো";
                                break;
                            case "Pa_per_con":
                                result = "জন্মেতেছিলো";
                                break;
                            case "F_in":
                                result = "জন্মাবে";
                                break;
                            case "F_con":
                                result = "জন্মাইতে থাকবে";
                                break;
                            case "F_per":
                                result = "জন্মাবে";
                                break;
                            case "F_per_con":
                                result = "জন্মাইতে থাকবে";
                                break;
                            default: break;
                        }
                    }
                    else if (verb.Contains("ঝুলান") || verb == "ঝুলান")
                    {
                        switch (verb_tag)
                        {
                            case "P_in":
                                result = "ঝুলায়";
                                break;
                            case "P_con":
                                result = "ঝুলাচ্ছে";
                                break;
                            case "P_per":
                                result = "ঝুলিয়েছে";
                                break;
                            case "P_per_con":
                                result = "ঝুলাচ্ছে";
                                break;
                            case "Pa_in":
                                result = "ঝুলিয়েছিলো";
                                break;
                            case "Pa_con":
                                result = "ঝুলাচ্ছিলো";
                                break;
                            case "Pa_per":
                                result = "ঝুলিয়েছিলো";
                                break;
                            case "Pa_per_con":
                                result = "ঝুলাচ্ছিলো";
                                break;
                            case "F_in":
                                result = "ঝুলাবে";
                                break;
                            case "F_con":
                                result = "ঝুলাইতে থাকবে";
                                break;
                            case "F_per":
                                result = "ঝুলাবে";
                                break;
                            case "F_per_con":
                                result = "ঝুলাইতে থাকবে";
                                break;
                            default: break;
                        }
                    }
                    else if (verb.Contains("করা") || verb == "করা")
                    {
                        switch (verb_tag)
                        {
                            case "P_in":
                                result = "করে";
                                break;
                            case "P_con":
                                result = "করছে";
                                break;
                            case "P_per":
                                result = "করেছে";
                                break;
                            case "P_per_con":
                                result = "করছে";
                                break;
                            case "Pa_in":
                                result = "করেছিলো";
                                break;
                            case "Pa_con":
                                result = "করতেছিলো";
                                break;
                            case "Pa_per":
                                result = "করেছিলো";
                                break;
                            case "Pa_per_con":
                                result = "করতেছিলো";
                                break;
                            case "F_in":
                                result = "করবে";
                                break;
                            case "F_con":
                                result = "করতে থাকবে";
                                break;
                            case "F_per":
                                result = "করবে";
                                break;
                            case "F_per_con":
                                result = "করতে থাকবে";
                                break;
                            default: break;
                        }
                    }
                    else if (verb.Contains("জানা") || verb == "জানা")
                    {
                        switch (verb_tag)
                        {
                            case "P_in":
                                result = "জানে";
                                break;
                            case "P_con":
                                result = "জানছে";
                                break;
                            case "P_per":
                                result = "জেনেছে";
                                break;
                            case "P_per_con":
                                result = "জানছে";
                                break;
                            case "Pa_in":
                                result = "জেনেছিলো";
                                break;
                            case "Pa_con":
                                result = "জানতেছিলো";
                                break;
                            case "Pa_per":
                                result = "জেনেছিলো";
                                break;
                            case "Pa_per_con":
                                result = "জানতেছিলো";
                                break;
                            case "F_in":
                                result = "জানবে";
                                break;
                            case "F_con":
                                result = "জানতে থাকবে";
                                break;
                            case "F_per":
                                result = "জানবে";
                                break;
                            case "F_per_con":
                                result = "জানতে থাকবে";
                                break;
                            default: break;
                        }
                    }
                    else if (verb.Contains("কাটা") || verb == "কাটা")
                    {
                        switch (verb_tag)
                        {
                            case "P_in":
                                result = "কাটে";
                                break;
                            case "P_con":
                                result = "কাটছে";
                                break;
                            case "P_per":
                                result = "কেটেছে";
                                break;
                            case "P_per_con":
                                result = "কাটছে";
                                break;
                            case "Pa_in":
                                result = "কেটেছিলো";
                                break;
                            case "Pa_con":
                                result = "কাটতেছিলো";
                                break;
                            case "Pa_per":
                                result = "কেটেছিলো";
                                break;
                            case "Pa_per_con":
                                result = "কাটতেছিলো";
                                break;
                            case "F_in":
                                result = "কাটবে";
                                break;
                            case "F_con":
                                result = "কাটতে থাকবে";
                                break;
                            case "F_per":
                                result = "কাটবে";
                                break;
                            case "F_per_con":
                                result = "কাটতে থাকবে";
                                break;
                            default: break;
                        }
                    }
                    else if (verb.Contains("কামান") || verb == "কামান")
                    {
                        switch (verb_tag)
                        {
                            case "P_in":
                                result = "কামায়";
                                break;
                            case "P_con":
                                result = "কামাচ্ছে";
                                break;
                            case "P_per":
                                result = "কমিয়েছে";
                                break;
                            case "P_per_con":
                                result = "কামাচ্ছে";
                                break;
                            case "Pa_in":
                                result = "কামিয়েছিলো";
                                break;
                            case "Pa_con":
                                result = "কামাচ্ছিলো";
                                break;
                            case "Pa_per":
                                result = "কামিয়েছিলো";
                                break;
                            case "Pa_per_con":
                                result = "কামাচ্ছিলো";
                                break;
                            case "F_in":
                                result = "কামাবে";
                                break;
                            case "F_con":
                                result = "কামাইতে থাকবে";
                                break;
                            case "F_per":
                                result = "কামাবে";
                                break;
                            case "F_per_con":
                                result = "কামাইতে থাকবে";
                                break;
                            default: break;
                        }
                    }
                    else if (verb.Contains("কেনা") || verb == "কেনা")
                    {
                        switch (verb_tag)
                        {
                            case "P_in":
                                result = "কিনে";
                                break;
                            case "P_con":
                                result = "কিনছে";
                                break;
                            case "P_per":
                                result = "কিনেছে";
                                break;
                            case "P_per_con":
                                result = "কিনছে";
                                break;
                            case "Pa_in":
                                result = "কিনেছিলো";
                                break;
                            case "Pa_con":
                                result = "কিনতেছিলো";
                                break;
                            case "Pa_per":
                                result = "কিনেছিলো";
                                break;
                            case "Pa_per_con":
                                result = "কিনতেছিলো";
                                break;
                            case "F_in":
                                result = "কমাবে";
                                break;
                            case "F_con":
                                result = "কিনতে থাকবে";
                                break;
                            case "F_per":
                                result = "কমাবে";
                                break;
                            case "F_per_con":
                                result = "কিনতে থাকবে";
                                break;
                            default: break;
                        }
                    }
                    else if (verb.Contains("কমানো") || verb == "কমানো")
                    {
                        switch (verb_tag)
                        {
                            case "P_in":
                                result = "কমায়";
                                break;
                            case "P_con":
                                result = "কমাচ্ছে";
                                break;
                            case "P_per":
                                result = "কমিয়েছে";
                                break;
                            case "P_per_con":
                                result = "কমাচ্ছে";
                                break;
                            case "Pa_in":
                                result = "কমাইছিলো";
                                break;
                            case "Pa_con":
                                result = "কমাচ্ছিলো";
                                break;
                            case "Pa_per":
                                result = "কমাইছিলো";
                                break;
                            case "Pa_per_con":
                                result = "কমাচ্ছিলো";
                                break;
                            case "F_in":
                                result = "কমাবে";
                                break;
                            case "F_con":
                                result = "কমাইতে থাকবে";
                                break;
                            case "F_per":
                                result = "কমাবে";
                                break;
                            case "F_per_con":
                                result = "কমাইতে থাকবে";
                                break;
                            default: break;
                        }
                    }
                    else if (verb.Contains("করান") || verb == "করান")
                    {
                        switch (verb_tag)
                        {
                            case "P_in":
                                result = "করায়";
                                break;
                            case "P_con":
                                result = " করাচ্ছে";
                                break;
                            case "P_per":
                                result = "করিয়েছে";
                                break;
                            case "P_per_con":
                                result = "করাচ্ছে";
                                break;
                            case "Pa_in":
                                result = "করিয়েছিলো";
                                break;
                            case "Pa_con":
                                result = "করাচ্ছিলো";
                                break;
                            case "Pa_per":
                                result = "করিয়েছিলো";
                                break;
                            case "Pa_per_con":
                                result = "করাচ্ছিলো";
                                break;
                            case "F_in":
                                result = "করাবে";
                                break;
                            case "F_con":
                                result = "করাতে থাকবে";
                                break;
                            case "F_per":
                                result = "করাবে";
                                break;
                            case "F_per_con":
                                result = "করাতে থাকবে";
                                break;
                            default: break;
                        }
                    }
                    else if (verb.Contains("খাওয়া") || verb == "খাওয়া")
                    {
                        switch (verb_tag)
                        {
                            case "P_in":
                                result = "খায়";
                                break;
                            case "P_con":
                                result = "খাচ্ছে";
                                break;
                            case "P_per":
                                result = "খাচ্ছে";
                                break;
                            case "P_per_con":
                                result = "খাচ্ছে";
                                break;
                            case "Pa_in":
                                result = "খেয়েছিলো";
                                break;
                            case "Pa_con":
                                result = "খাচ্ছিলো";
                                break;
                            case "Pa_per":
                                result = "খেয়েছিলো";
                                break;
                            case "Pa_per_con":
                                result = "খাচ্ছিলো";
                                break;
                            case "F_in":
                                result = "খাবে";
                                break;
                            case "F_con":
                                result = "খাইতে থাকবে";
                                break;
                            case "F_per":
                                result = "খাবে";
                                break;
                            case "F_per_con":
                                result = "খাইতে থাকবে";
                                break;
                            default: break;
                        }
                    }
                    else if (verb.Contains("খেলা") || verb == "খেলা")
                    {
                        switch (verb_tag)
                        {
                            case "P_in":
                                result = "খেলে";
                                break;
                            case "P_con":
                                result = "খেলছে";
                                break;
                            case "P_per":
                                result = "খেলেছে";
                                break;
                            case "P_per_con":
                                result = "খেলছে";
                                break;
                            case "Pa_in":
                                result = "খেলেছিলো";
                                break;
                            case "Pa_con":
                                result = "খেলতেছিলো";
                                break;
                            case "Pa_per":
                                result = "খেলেছিলো";
                                break;
                            case "Pa_per_con":
                                result = "খেলতেছিলো";
                                break;
                            case "F_in":
                                result = "খেলবে";
                                break;
                            case "F_con":
                                result = "খেলতে থাকবে";
                                break;
                            case "F_per":
                                result = "খেলবে";
                                break;
                            case "F_per_con":
                                result = "খেলতে থাকবে";
                                break;
                            default: break;
                        }
                    }
                    else if (verb.Contains("খোলা") || verb == "খোলা")
                    {
                        switch (verb_tag)
                        {
                            case "P_in":
                                result = "খুলে";
                                break;
                            case "P_con":
                                result = "খুলছে";
                                break;
                            case "P_per":
                                result = "খুলেছে";
                                break;
                            case "P_per_con":
                                result = "খুলছে";
                                break;
                            case "Pa_in":
                                result = "খুলেছিলো";
                                break;
                            case "Pa_con":
                                result = "খুলতেছিলো";
                                break;
                            case "Pa_per":
                                result = "খুলেছিলো";
                                break;
                            case "Pa_per_con":
                                result = "খুলতেছিলো";
                                break;
                            case "F_in":
                                result = "খুলবে";
                                break;
                            case "F_con":
                                result = "খুলতে থাকবে";
                                break;
                            case "F_per":
                                result = "খুলবে";
                                break;
                            case "F_per_con":
                                result = "খুলতে থাকবে";
                                break;
                            default: break;
                        }
                    }
                    else if (verb.Contains("খাওয়ান") || verb == "খাওয়ান")
                    {
                        switch (verb_tag)
                        {
                            case "P_in":
                                result = "খাওয়ায়";
                                break;
                            case "P_con":
                                result = "খাওয়াচ্ছে";
                                break;
                            case "P_per":
                                result = "খাইয়েছে";
                                break;
                            case "P_per_con":
                                result = "খাওয়াচ্ছে";
                                break;
                            case "Pa_in":
                                result = "খাইয়েছিলো";
                                break;
                            case "Pa_con":
                                result = "খাওয়াচ্ছিলো";
                                break;
                            case "Pa_per":
                                result = "খাইয়েছিলো";
                                break;
                            case "Pa_per_con":
                                result = "খাওয়াচ্ছিলো";
                                break;
                            case "F_in":
                                result = "খাওয়াবে";
                                break;
                            case "F_con":
                                result = "খাওয়াতে থাকবে";
                                break;
                            case "F_per":
                                result = "খাওয়াবে";
                                break;
                            case "F_per_con":
                                result = "খাওয়াতে থাকবে";
                                break;
                            default: break;
                        }
                    }
                    else if (verb.Contains("খোজা") || verb == "খোজা")
                    {
                        switch (verb_tag)
                        {
                            case "P_in":
                                result = "খুজে";
                                break;
                            case "P_con":
                                result = "খুজছে";
                                break;
                            case "P_per":
                                result = "খুজেছে";
                                break;
                            case "P_per_con":
                                result = "খুজছে";
                                break;
                            case "Pa_in":
                                result = "খুজেছিলো";
                                break;
                            case "Pa_con":
                                result = "খুজতেছিলো";
                                break;
                            case "Pa_per":
                                result = "খুজেছিলো";
                                break;
                            case "Pa_per_con":
                                result = "খুজতেছিলো";
                                break;
                            case "F_in":
                                result = "খুজবে";
                                break;
                            case "F_con":
                                result = "খুজতে থাকবে";
                                break;
                            case "F_per":
                                result = "খুজবে";
                                break;
                            case "F_per_con":
                                result = "খুজতে থাকবে";
                                break;
                            default: break;
                        }
                    }
                    else if (verb.Contains("লেখা") || verb == "লেখা")
                    {
                        switch (verb_tag)
                        {
                            case "P_in":
                                result = "লেখে";
                                break;
                            case "P_con":
                                result = "লিখছে";
                                break;
                            case "P_per":
                                result = "লিখেছে";
                                break;
                            case "P_per_con":
                                result = "লিখছে";
                                break;
                            case "Pa_in":
                                result = "লিখেছিলো";
                                break;
                            case "Pa_con":
                                result = "লিখতেছিলো";
                                break;
                            case "Pa_per":
                                result = "লিখেছিলো";
                                break;
                            case "Pa_per_con":
                                result = "লিখতেছিলো";
                                break;
                            case "F_in":
                                result = "লিখবে";
                                break;
                            case "F_con":
                                result = "লিখতে থাকবে";
                                break;
                            case "F_per":
                                result = "লিখবে";
                                break;
                            case "F_per_con":
                                result = "লিখতে থাকবে";
                                break;
                            default: break;
                        }
                    }
                    else if (verb.Contains("লাগানো") || verb == "লাগানো")
                    {
                        switch (verb_tag)
                        {
                            case "P_in":
                                result = "লাগায়";
                                break;
                            case "P_con":
                                result = "লাগাচ্ছে";
                                break;
                            case "P_per":
                                result = "লাগিয়েছে";
                                break;
                            case "P_per_con":
                                result = "লাগাচ্ছে";
                                break;
                            case "Pa_in":
                                result = "লাগিয়েছিলো";
                                break;
                            case "Pa_con":
                                result = "লাগাচ্ছিলো";
                                break;
                            case "Pa_per":
                                result = "লাগিয়েছিলো";
                                break;
                            case "Pa_per_con":
                                result = "লাগাচ্ছিলো";
                                break;
                            case "F_in":
                                result = "লুকাবে";
                                break;
                            case "F_con":
                                result = "লুকাইতে থাকবে";
                                break;
                            case "F_per":
                                result = "লাগাবে";
                                break;
                            case "F_per_con":
                                result = "লাগাইতে থাকবে";
                                break;
                            default: break;
                        }
                    }
                    else if (verb.Contains("লুকান") || verb == "লুকান")
                    {
                        switch (verb_tag)
                        {
                            case "P_in":
                                result = "লুকায়";
                                break;
                            case "P_con":
                                result = "লুকাচ্ছে";
                                break;
                            case "P_per":
                                result = "লুকিয়েছে";
                                break;
                            case "P_per_con":
                                result = "লুকাচ্ছে";
                                break;
                            case "Pa_in":
                                result = "লুকিয়েছিলো";
                                break;
                            case "Pa_con":
                                result = "লুকাচ্ছিলো";
                                break;
                            case "Pa_per":
                                result = "লুকিয়েছিলো";
                                break;
                            case "Pa_per_con":
                                result = "লুকাচ্ছিলো";
                                break;
                            case "F_in":
                                result = "লুকাবে";
                                break;
                            case "F_con":
                                result = "লুকাইতে থাকবে";
                                break;
                            case "F_per":
                                result = "লুকাবে";
                                break;
                            case "F_per_con":
                                result = "লুকাইতে থাকবে";
                                break;
                            default: break;
                        }
                    }
                    else if (verb.Contains("ভাঙ্গা") || verb == "ভাঙ্গা")
                    {
                        switch (verb_tag)
                        {
                            case "P_in":
                                result = "ভাঙে";
                                break;
                            case "P_con":
                                result = "ভাঙছে";
                                break;
                            case "P_per":
                                result = "ভেঙ্গেছে";
                                break;
                            case "P_per_con":
                                result = "ভাঙছে";
                                break;
                            case "Pa_in":
                                result = "ভেঙ্গেছিলো";
                                break;
                            case "Pa_con":
                                result = "ভাঙ্গছিলো";
                                break;
                            case "Pa_per":
                                result = "ভেঙ্গেছিলো";
                                break;
                            case "Pa_per_con":
                                result = "ভাঙ্গছিলো";
                                break;
                            case "F_in":
                                result = "ভাঙ্গবে";
                                break;
                            case "F_con":
                                result = "ভালবাসতে থাকবে";
                                break;
                            case "F_per":
                                result = "ভাঙ্গবে";
                                break;
                            case "F_per_con":
                                result = "ভালবাসতে থাকবে";
                                break;
                            default: break;
                        }
                    }
                    else if (verb.Contains("ভালবাসা") || verb == "ভালবাসা")
                    {
                        switch (verb_tag)
                        {
                            case "P_in":
                                result = "ভালবাসে";
                                break;
                            case "P_con":
                                result = "ভালোবাসছে";
                                break;
                            case "P_per":
                                result = "ভালবেসেছে";
                                break;
                            case "P_per_con":
                                result = "ভালোবাসছে";
                                break;
                            case "Pa_in":
                                result = "ভালোবেসেছিলো";
                                break;
                            case "Pa_con":
                                result = "ভালোবাসছিলো";
                                break;
                            case "Pa_per":
                                result = "ভালোবেসেছিলো";
                                break;
                            case "Pa_per_con":
                                result = "ভালোবাসছিলো";
                                break;
                            case "F_in":
                                result = "ভালবাসবে";
                                break;
                            case "F_con":
                                result = "ভালবাসতে থাকবে";
                                break;
                            case "F_per":
                                result = "ভালবাসবে";
                                break;
                            case "F_per_con":
                                result = "ভালবাসতে থাকবে";
                                break;
                            default: break;
                        }
                    }
                    else if (verb.Contains("ভাজা") || verb == "ভাজা")
                    {
                        switch (verb_tag)
                        {
                            case "P_in":
                                result = "ভাজে";
                                break;
                            case "P_con":
                                result = "ভাজছে";
                                break;
                            case "P_per":
                                result = "ভেজেছে";
                                break;
                            case "P_per_con":
                                result = "ভাজছে";
                                break;
                            case "Pa_in":
                                result = "ভেজেছিলো";
                                break;
                            case "Pa_con":
                                result = "ভাজছিলো";
                                break;
                            case "Pa_per":
                                result = "ভেজেছিলো";
                                break;
                            case "Pa_per_con":
                                result = "ভাজছিলো";
                                break;
                            case "F_in":
                                result = "ভাজবে";
                                break;
                            case "F_con":
                                result = "ভাজতে থাকবে";
                                break;
                            case "F_per":
                                result = "ভাজবে";
                                break;
                            case "F_per_con":
                                result = "ভাজতে থাকবে";
                                break;
                            default: break;
                        }
                    }
                    else if (verb.Contains("ভাসান") || verb == "ভাসান")
                    {
                        switch (verb_tag)
                        {
                            case "P_in":
                                result = "ভাসায়";
                                break;
                            case "P_con":
                                result = "ভাসাচ্ছে";
                                break;
                            case "P_per":
                                result = "ভাসিয়েছে";
                                break;
                            case "P_per_con":
                                result = "ভাসাচ্ছে";
                                break;
                            case "Pa_in":
                                result = "ভাসিয়েছিলো";
                                break;
                            case "Pa_con":
                                result = "ভাসাচ্ছিলো";
                                break;
                            case "Pa_per":
                                result = "ভাসিয়েছিলো";
                                break;
                            case "Pa_per_con":
                                result = "ভাসাচ্ছিলো";
                                break;
                            case "F_in":
                                result = "ভাসাবে";
                                break;
                            case "F_con":
                                result = "ভাসাতে থাকবে";
                                break;
                            case "F_per":
                                result = "ভাসাবে";
                                break;
                            case "F_per_con":
                                result = "ভাসাতে থাকবে";
                                break;
                            default: break;
                        }
                    }
                    else if (verb.Contains("তাকান") || verb == "তাকান")
                    {
                        switch (verb_tag)
                        {
                            case "P_in":
                                result = "তাকায়";
                                break;
                            case "P_con":
                                result = "তাকাচ্ছে";
                                break;
                            case "P_per":
                                result = "তাকিয়েছে";
                                break;
                            case "P_per_con":
                                result = "তাকাচ্ছে";
                                break;
                            case "Pa_in":
                                result = "তাকিয়েছিলো";
                                break;
                            case "Pa_con":
                                result = "তাকাচ্ছিলো";
                                break;
                            case "Pa_per":
                                result = "তাকিয়েছিলো";
                                break;
                            case "Pa_per_con":
                                result = "তাকাচ্ছিলো";
                                break;
                            case "F_in":
                                result = "তাকাবে";
                                break;
                            case "F_con":
                                result = "তাকাতে থাকবে";
                                break;
                            case "F_per":
                                result = "তাকাবে";
                                break;
                            case "F_per_con":
                                result = "তাকাতে থাকবে";
                                break;
                            default: break;
                        }
                    }
                    else if (verb.Contains("থাকা") || verb == "থাকা")
                    {
                        switch (verb_tag)
                        {
                            case "P_in":
                                result = "থাকে";
                                break;
                            case "P_con":
                                result = "থাকছে";
                                break;
                            case "P_per":
                                result = "থেকেছে";
                                break;
                            case "P_per_con":
                                result = "থাকছে";
                                break;
                            case "Pa_in":
                                result = "থেকেছিলো";
                                break;
                            case "Pa_con":
                                result = "থাকছিলো";
                                break;
                            case "Pa_per":
                                result = "থেকেছিলো";
                                break;
                            case "Pa_per_con":
                                result = "থাকছিলো";
                                break;
                            case "F_in":
                                result = "থাকবে";
                                break;
                            case "F_con":
                                result = "থাকবে";
                                break;
                            case "F_per":
                                result = "থাকবে";
                                break;
                            case "F_per_con":
                                result = "থাকবে";
                                break;
                            default: break;
                        }
                    }
                    else if (verb.Contains("টানা") || verb == "টানা")
                    {
                        switch (verb_tag)
                        {
                            case "P_in":
                                result = "টানে";
                                break;
                            case "P_con":
                                result = "টানছে";
                                break;
                            case "P_per":
                                result = "টেনেছে";
                                break;
                            case "P_per_con":
                                result = "টানছে";
                                break;
                            case "Pa_in":
                                result = "টেনেছিলো";
                                break;
                            case "Pa_con":
                                result = "টানছিলো";
                                break;
                            case "Pa_per":
                                result = "টেনেছিলো";
                                break;
                            case "Pa_per_con":
                                result = "টানছিলো";
                                break;
                            case "F_in":
                                result = "টানবে";
                                break;
                            case "F_con":
                                result = "টানতে থাকবে";
                                break;
                            case "F_per":
                                result = "টানবে";
                                break;
                            case "F_per_con":
                                result = "টানতে থাকবে";
                                break;
                            default: break;
                        }
                    }
                    else if (verb.Contains("পাঠান") || verb == "পাঠান")
                    {
                        switch (verb_tag)
                        {
                            case "P_in":
                                result = "পাঠায়";
                                break;
                            case "P_con":
                                result = "পাঠাচ্ছে";
                                break;
                            case "P_per":
                                result = "পাঠিয়েছে";
                                break;
                            case "P_per_con":
                                result = "পাঠাচ্ছে";
                                break;
                            case "Pa_in":
                                result = "পাঠিয়েছিলো";
                                break;
                            case "Pa_con":
                                result = "পাঠাচ্ছিলো";
                                break;
                            case "Pa_per":
                                result = "পাঠিয়েছিলো";
                                break;
                            case "Pa_per_con":
                                result = "পাঠাচ্ছিলো";
                                break;
                            case "F_in":
                                result = "পাঠাবে";
                                break;
                            case "F_con":
                                result = "পাঠাতে থাকবে";
                                break;
                            case "F_per":
                                result = "পাঠাবে";
                                break;
                            case "F_per_con":
                                result = "পাঠাতে থাকবে";
                                break;
                            default: break;
                        }
                    }
                    else if (verb.Contains("পড়া") || verb == "পড়া")
                    {
                        switch (verb_tag)
                        {
                            case "P_in":
                                result = "পড়ে";
                                break;
                            case "P_con":
                                result = "পড়ছে";
                                break;
                            case "P_per":
                                result = "পড়েছে";
                                break;
                            case "P_per_con":
                                result = "পড়ছে";
                                break;
                            case "Pa_in":
                                result = "পড়েছিলো";
                                break;
                            case "Pa_con":
                                result = "পড়ছিলো";
                                break;
                            case "Pa_per":
                                result = "পড়েছিলো";
                                break;
                            case "Pa_per_con":
                                result = "পড়ছিলো";
                                break;
                            case "F_in":
                                result = "পড়াবে";
                                break;
                            case "F_con":
                                result = "পড়াতে থাকবে";
                                break;
                            case "F_per":
                                result = "পড়াবে";
                                break;
                            case "F_per_con":
                                result = "পড়াতে থাকবে";
                                break;
                            default: break;
                        }
                    }
                    else if (verb.Contains("পরান") || verb == "পরান")
                    {
                        switch (verb_tag)
                        {
                            case "P_in":
                                result = "পরায়";
                                break;
                            case "P_con":
                                result = "পরাচ্ছে";
                                break;
                            case "P_per":
                                result = "পরিয়েছে";
                                break;
                            case "P_per_con":
                                result = "পরাচ্ছে";
                                break;
                            case "Pa_in":
                                result = "পরিয়েছিলো";
                                break;
                            case "Pa_con":
                                result = "পরাচ্ছিলো";
                                break;
                            case "Pa_per":
                                result = "পরিয়েছিলো";
                                break;
                            case "Pa_per_con":
                                result = "পরাচ্ছিলো";
                                break;
                            case "F_in":
                                result = "পরাবে";
                                break;
                            case "F_con":
                                result = "পরাতে থাকবে";
                                break;
                            case "F_per":
                                result = "পরাবে";
                                break;
                            case "F_per_con":
                                result = "পরাতে থাকবে";
                                break;
                            default: break;
                        }
                    }
                    else if (verb.Contains("পালানো") || verb == "পালানো")
                    {
                        switch (verb_tag)
                        {
                            case "P_in":
                                result = "পালায়";
                                break;
                            case "P_con":
                                result = "পালাচ্ছে";
                                break;
                            case "P_per":
                                result = "পালিয়েছে";
                                break;
                            case "P_per_con":
                                result = "পালাচ্ছে";
                                break;
                            case "Pa_in":
                                result = "পালিয়েছিলো";
                                break;
                            case "Pa_con":
                                result = "পালাচ্ছিল";
                                break;
                            case "Pa_per":
                                result = "পালিয়েছিলো";
                                break;
                            case "Pa_per_con":
                                result = "পালাচ্ছিল";
                                break;
                            case "F_in":
                                result = "পালাবে";
                                break;
                            case "F_con":
                                result = "পালাতে থাকবে";
                                break;
                            case "F_per":
                                result = "পালাবে";
                                break;
                            case "F_per_con":
                                result = "পালাতে থাকবে";
                                break;
                            default: break;
                        }
                    }
                    else if (verb.Contains("পাওয়া") || verb == "পাওয়া")
                    {
                        switch (verb_tag)
                        {
                            case "P_in":
                                result = "পায়";
                                break;
                            case "P_con":
                                result = "পাচ্ছে";
                                break;
                            case "P_per":
                                result = "পেয়েছে";
                                break;
                            case "P_per_con":
                                result = "পাচ্ছে";
                                break;
                            case "Pa_in":
                                result = "পেয়েছিলো";
                                break;
                            case "Pa_con":
                                result = "পাচ্ছিলো";
                                break;
                            case "Pa_per":
                                result = "পেয়েছিলো";
                                break;
                            case "Pa_per_con":
                                result = "পাচ্ছিলো";
                                break;
                            case "F_in":
                                result = "পাবে";
                                break;
                            case "F_con":
                                result = "পাইতে থাকবে";
                                break;
                            case "F_per":
                                result = "পাবে";
                                break;
                            case "F_per_con":
                                result = "পাইতে থাকবে";
                                break;
                            default: break;
                        }
                    }
                    else if (verb.Contains("রাখা") || verb == "রাখা")
                    {
                        switch (verb_tag)
                        {
                            case "P_in":
                                result = "রাখে";
                                break;
                            case "P_con":
                                result = "রাখছে";
                                break;
                            case "P_per":
                                result = "রেখেছে";
                                break;
                            case "P_per_con":
                                result = "রাখছে";
                                break;
                            case "Pa_in":
                                result = "রেখেছিলো";
                                break;
                            case "Pa_con":
                                result = "রাখছিলো";
                                break;
                            case "Pa_per":
                                result = "রেখেছিলো";
                                break;
                            case "Pa_per_con":
                                result = "রাখছিলো";
                                break;
                            case "F_in":
                                result = "রাখবে";
                                break;
                            case "F_con":
                                result = "রাখতে থাকবে";
                                break;
                            case "F_per":
                                result = "রাখবে";
                                break;
                            case "F_per_con":
                                result = "রাখতে থাকবে";
                                break;
                            default: break;
                        }
                    }
                    else if (verb.Contains("নোয়ান") || verb == "নোয়ান")
                    {
                        switch (verb_tag)
                        {
                            case "P_in":
                                result = "নুয়ায়";
                                break;
                            case "P_con":
                                result = "নুয়াচ্ছে";
                                break;
                            case "P_per":
                                result = "নুয়েছে";
                                break;
                            case "P_per_con":
                                result = "নুয়াচ্ছে";
                                break;
                            case "Pa_in":
                                result = "নুয়েছিলো";
                                break;
                            case "Pa_con":
                                result = "নুয়াচ্ছিলো";
                                break;
                            case "Pa_per":
                                result = "নুয়েছিলো";
                                break;
                            case "Pa_per_cনুয়াচ্ছিলোon":
                                result = "";
                                break;
                            case "F_in":
                                result = "নোয়াবে";
                                break;
                            case "F_con":
                                result = "নুয়াতে থাকবে";
                                break;
                            case "F_per":
                                result = "নোয়াবে";
                                break;
                            case "F_per_con":
                                result = "নুয়াতে থাকবে";
                                break;
                            default: break;
                        }
                    }
                    else if (verb.Contains("নেয়া") || verb == "নেয়া")
                    {
                        switch (verb_tag)
                        {
                            case "P_in":
                                result = "নেয়";
                                break;
                            case "P_con":
                                result = "নিচ্ছে";
                                break;
                            case "P_per":
                                result = "নিয়েছে";
                                break;
                            case "P_per_con":
                                result = "নিচ্ছে";
                                break;
                            case "Pa_in":
                                result = "নিয়েছিলো";
                                break;
                            case "Pa_con":
                                result = "নিচ্ছিলো";
                                break;
                            case "Pa_per":
                                result = "নিয়েছিলো";
                                break;
                            case "Pa_per_con":
                                result = "নিচ্ছিলো";
                                break;
                            case "F_in":
                                result = "নিবে";
                                break;
                            case "F_con":
                                result = "নিতে থাকবে";
                                break;
                            case "F_per":
                                result = "নিবে";
                                break;
                            case "F_per_con":
                                result = "নিতে থাকবে";
                                break;
                            default: break;
                        }
                    }
                    else if (verb.Contains("নাড়ান") || verb == "নাড়ান")
                    {
                        switch (verb_tag)
                        {
                            case "P_in":
                                result = "নাড়ায়";
                                break;
                            case "P_con":
                                result = "নাড়াচ্ছে";
                                break;
                            case "P_per":
                                result = "নাড়িয়েছে";
                                break;
                            case "P_per_con":
                                result = "নাড়াচ্ছে";
                                break;
                            case "Pa_in":
                                result = "নাড়িয়েছিলো";
                                break;
                            case "Pa_con":
                                result = "নাড়াচ্ছিলো";
                                break;
                            case "Pa_per":
                                result = "নাড়িয়েছিলো";
                                break;
                            case "Pa_per_con":
                                result = "নাড়াচ্ছিলো";
                                break;
                            case "F_in":
                                result = "নাড়াবে";
                                break;
                            case "F_con":
                                result = "নাড়াতে থাকবে";
                                break;
                            case "F_per":
                                result = "নাড়াবে";
                                break;
                            case "F_per_con":
                                result = "নাড়াতে থাকবে";
                                break;
                            default: break;
                        }
                    }
                    else if (verb.Contains("নাচা") || verb == "নাচা")
                    {
                        switch (verb_tag)
                        {
                            case "P_in":
                                result = "নাচে";
                                break;
                            case "P_con":
                                result = "নাচতেছে";
                                break;
                            case "P_per":
                                result = "নেচেছে";
                                break;
                            case "P_per_con":
                                result = "নাচতেছে";
                                break;
                            case "Pa_in":
                                result = "নেচেছিলো";
                                break;
                            case "Pa_con":
                                result = "নাচতেছিলো";
                                break;
                            case "Pa_per":
                                result = "নেচেছিলো";
                                break;
                            case "Pa_per_con":
                                result = "নাচতেছিলো";
                                break;
                            case "F_in":
                                result = "নাচবে";
                                break;
                            case "F_con":
                                result = "নাচতে থাকবে";
                                break;
                            case "F_per":
                                result = "নাচবে";
                                break;
                            case "F_per_con":
                                result = "নাচতে থাকবে";
                                break;
                            default: break;
                        }
                    }
                    else if (verb.Contains("শেখান") || verb == "শেখান")
                    {
                        switch (verb_tag)
                        {
                            case "P_in":
                                result = "";
                                break;
                            case "P_con":
                                result = "";
                                break;
                            case "P_per":
                                result = "";
                                break;
                            case "P_per_con":
                                result = "";
                                break;
                            case "Pa_in":
                                result = "";
                                break;
                            case "Pa_con":
                                result = "";
                                break;
                            case "Pa_per":
                                result = "";
                                break;
                            case "Pa_per_con":
                                result = "";
                                break;
                            case "F_in":
                                result = "";
                                break;
                            case "F_con":
                                result = "";
                                break;
                            case "F_per":
                                result = "";
                                break;
                            case "F_per_con":
                                result = "";
                                break;
                            default: break;
                        }
                    }
                    else if (verb.Contains("শোনা") || verb == "শোনা")
                    {
                        switch (verb_tag)
                        {
                            case "P_in":
                                result = "শুনে";
                                break;
                            case "P_con":
                                result = "শুনছে";
                                break;
                            case "P_per":
                                result = "শুনেছে";
                                break;
                            case "P_per_con":
                                result = "শুনছে";
                                break;
                            case "Pa_in":
                                result = "শুনেছিলো";
                                break;
                            case "Pa_con":
                                result = "শুনছিলো";
                                break;
                            case "Pa_per":
                                result = "শুনেছিলো";
                                break;
                            case "Pa_per_con":
                                result = "শুনছিলো";
                                break;
                            case "F_in":
                                result = "শুনবে";
                                break;
                            case "F_con":
                                result = "শুনতে থাকবে";
                                break;
                            case "F_per":
                                result = "শুনবে";
                                break;
                            case "F_per_con":
                                result = "শুনতে থাকবে";
                                break;
                            default: break;
                        }
                    }
                    else if (verb.Contains("শেখা") || verb == "শেখা")
                    {
                        switch (verb_tag)
                        {
                            case "P_in":
                                result = "শিখে";
                                break;
                            case "P_con":
                                result = "শিখছে";
                                break;
                            case "P_per":
                                result = "শিখেছে";
                                break;
                            case "P_per_con":
                                result = "শিখছে";
                                break;
                            case "Pa_in":
                                result = "শিখেছিলো";
                                break;
                            case "Pa_con":
                                result = "শিখছিলো";
                                break;
                            case "Pa_per":
                                result = "শিখেছিলো";
                                break;
                            case "Pa_per_con":
                                result = "শিখছিলো";
                                break;
                            case "F_in":
                                result = "শিখবে";
                                break;
                            case "F_con":
                                result = "শিখতে থাকবে";
                                break;
                            case "F_per":
                                result = "শিখবে";
                                break;
                            case "F_per_con":
                                result = "শিখতে থাকবে";
                                break;
                            default: break;
                        }
                    }
                    else if (verb.Contains("সাজান") || verb == "সাজান")
                    {
                        switch (verb_tag)
                        {
                            case "P_in":
                                result = "সাজায়";
                                break;
                            case "P_con":
                                result = "সাজাচ্ছে";
                                break;
                            case "P_per":
                                result = "সাজিয়েছে";
                                break;
                            case "P_per_con":
                                result = "সাজাচ্ছে";
                                break;
                            case "Pa_in":
                                result = "সাজিয়েছিলো";
                                break;
                            case "Pa_con":
                                result = "সাজাচ্ছিলো";
                                break;
                            case "Pa_per":
                                result = "সাজিয়েছিলো";
                                break;
                            case "Pa_per_con":
                                result = "সাজাচ্ছিলো";
                                break;
                            case "F_in":
                                result = "সাজায়";
                                break;
                            case "F_con":
                                result = "সাজাতে থাকবে";
                                break;
                            case "F_per":
                                result = "সাজায়";
                                break;
                            case "F_per_con":
                                result = "সাজাতে থাকবে";
                                break;
                            default: break;
                        }
                    }
                    else if (verb.Contains("শুকান") || verb == "শুকান")
                    {
                        switch (verb_tag)
                        {
                            case "P_in":
                                result = "শুকায়";
                                break;
                            case "P_con":
                                result = "শুকাচ্ছে";
                                break;
                            case "P_per":
                                result = "শুকিয়েছে";
                                break;
                            case "P_per_con":
                                result = "শুকাচ্ছে";
                                break;
                            case "Pa_in":
                                result = "শুকিয়েছিলো";
                                break;
                            case "Pa_con":
                                result = "শুকাচ্ছিলো";
                                break;
                            case "Pa_per":
                                result = "শুকিয়েছিলো";
                                break;
                            case "Pa_per_con":
                                result = "শুকাচ্ছিলো";
                                break;
                            case "F_in":
                                result = "শুকাবে";
                                break;
                            case "F_con":
                                result = "শুকাতে থাকবে";
                                break;
                            case "F_per":
                                result = "শুকাবে";
                                break;
                            case "F_per_con":
                                result = "শুকাতে থাকবে";
                                break;
                            default: break;
                        }
                    }
                    else if (verb.Contains("শিখান") || verb == "শিখান")
                    {
                        switch (verb_tag)
                        {
                            case "P_in":
                                result = "শিখায়";
                                break;
                            case "P_con":
                                result = "শিখছে";
                                break;
                            case "P_per":
                                result = "শিখেছে";
                                break;
                            case "P_per_con":
                                result = "শিখছে";
                                break;
                            case "Pa_in":
                                result = "শিখেছিলো";
                                break;
                            case "Pa_con":
                                result = "শিখছিলো";
                                break;
                            case "Pa_per":
                                result = "শিখেছিলো";
                                break;
                            case "Pa_per_con":
                                result = "শিখছিলো";
                                break;
                            case "F_in":
                                result = "শিখবে";
                                break;
                            case "F_con":
                                result = "শিখতে থাকবে";
                                break;
                            case "F_per":
                                result = "শিখবে";
                                break;
                            case "F_per_con":
                                result = "শিখতে থাকবে";
                                break;
                            default: break;
                        }
                    }
                    else if (verb.Contains("উঠা") || verb == "উঠা")
                    {
                        switch (verb_tag)
                        {
                            case "P_in":
                                result = "উঠে";
                                break;
                            case "P_con":
                                result = "উঠছে";
                                break;
                            case "P_per":
                                result = "উঠেছে";
                                break;
                            case "P_per_con":
                                result = "উঠছে";
                                break;
                            case "Pa_in":
                                result = "উঠেছিলো";
                                break;
                            case "Pa_con":
                                result = "উঠছিলো";
                                break;
                            case "Pa_per":
                                result = "উঠেছিলো";
                                break;
                            case "Pa_per_con":
                                result = "উঠছিলো";
                                break;
                            case "F_in":
                                result = "উঠবে";
                                break;
                            case "F_con":
                                result = "উঠতে থাকবে";
                                break;
                            case "F_per":
                                result = "উঠবে";
                                break;
                            case "F_per_con":
                                result = "উঠতে থাকবে";
                                break;
                            default: break;
                        }
                    }
                    else if (verb.Contains("ওঠা") || verb == "ওঠা")
                    {
                        switch (verb_tag)
                        {
                            case "P_in":
                                result = "ওঠে";
                                break;
                            case "P_con":
                                result = "ওঠছে";
                                break;
                            case "P_per":
                                result = "ওঠেছে";
                                break;
                            case "P_per_con":
                                result = "ওঠছে";
                                break;
                            case "Pa_in":
                                result = "ওঠেছিলো";
                                break;
                            case "Pa_con":
                                result = "ওঠছিলো";
                                break;
                            case "Pa_per":
                                result = "ওঠেছিলো";
                                break;
                            case "Pa_per_con":
                                result = "ওঠছিলো";
                                break;
                            case "F_in":
                                result = "ওঠবে";
                                break;
                            case "F_con":
                                result = "ওঠতে থাকবে";
                                break;
                            case "F_per":
                                result = "ওঠবে";
                                break;
                            case "F_per_con":
                                result = "ওঠতে থাকবে";
                                break;
                            default: break;
                        }
                    }
                    else if (verb.Contains("উঠান") || verb == "উঠান")
                    {
                        switch (verb_tag)
                        {
                            case "P_in":
                                result = "উঠায়";
                                break;
                            case "P_con":
                                result = "উঠাচ্ছে";
                                break;
                            case "P_per":
                                result = "উঠিয়েছে";
                                break;
                            case "P_per_con":
                                result = "উঠাচ্ছে";
                                break;
                            case "Pa_in":
                                result = "উঠিয়েছিলো";
                                break;
                            case "Pa_con":
                                result = "উঠাচ্ছিলো";
                                break;
                            case "Pa_per":
                                result = "উঠাচ্ছিলো";
                                break;
                            case "Pa_per_con":
                                result = "উঠিয়েছিলো";
                                break;
                            case "F_in":
                                result = "উঠাবে";
                                break;
                            case "F_con":
                                result = "উঠাতে থাকবে";
                                break;
                            case "F_per":
                                result = "উঠাবে";
                                break;
                            case "F_per_con":
                                result = "উঠাতে থাকবে";
                                break;
                            default: break;
                        }
                    }
                    else if (verb.Contains("উড়া") || verb == "উড়া")
                    {
                        switch (verb_tag)
                        {
                            case "P_in":
                                result = "উড়ে";
                                break;
                            case "P_con":
                                result = "উড়ছে";
                                break;
                            case "P_per":
                                result = "উড়েছে";
                                break;
                            case "P_per_con":
                                result = "উড়ছে";
                                break;
                            case "Pa_in":
                                result = "উড়েছিলো";
                                break;
                            case "Pa_con":
                                result = "উড়ছিলো";
                                break;
                            case "Pa_per":
                                result = "উড়েছিলো";
                                break;
                            case "Pa_per_con":
                                result = "উড়ছিলো";
                                break;
                            case "F_in":
                                result = "উড়বে";
                                break;
                            case "F_con":
                                result = "উড়তে থাকবে";
                                break;
                            case "F_per":
                                result = "উড়বে";
                                break;
                            case "F_per_con":
                                result = "উড়তে থাকবে";
                                break;
                            default: break;
                        }
                    }
                    else if (verb.Contains("মেটান") || verb == "মেটান")
                    {
                        switch (verb_tag)
                        {
                            case "P_in":
                                result = "মেটায়";
                                break;
                            case "P_con":
                                result = "মেটাচ্ছে";
                                break;
                            case "P_per":
                                result = "মিটিয়েছে";
                                break;
                            case "P_per_con":
                                result = "মেটাচ্ছে";
                                break;
                            case "Pa_in":
                                result = "মিটিয়েছিলো";
                                break;
                            case "Pa_con":
                                result = "মেটাচ্ছিলো";
                                break;
                            case "Pa_per":
                                result = "মিটিয়েছিলো";
                                break;
                            case "Pa_per_con":
                                result = "মেটাচ্ছিলো";
                                break;
                            case "F_in":
                                result = "মেটাবে";
                                break;
                            case "F_con":
                                result = "মেটাতে থাকবে";
                                break;
                            case "F_per":
                                result = "মেটাবে";
                                break;
                            case "F_per_con":
                                result = "মেটাতে থাকবে";
                                break;
                            default: break;
                        }
                    }
                    else
                    { }
            }
            return result;
        }
        private void IdentifyV_root(string verb)
        {
            if (verb.Contains("আনা") || verb == "আনা")
            {
                vRoot = "আনা";
            }
            else if (verb.Contains("আঁকা") || verb == "আঁকা")
            {
                vRoot = "আঁকা";
            }
            else if (verb.Contains("বাঁধা") || verb == "বাঁধা")
            {
                vRoot = "বাঁধা";
            }
            else if (verb.Contains("বসা") || verb == "বসা")
            {
                vRoot = "বসা";
            }
            else if (verb.Contains("বসান") || verb == "বসান")
            {
                vRoot = "বসান";
            }
            else if (verb.Contains("বলা") || verb == "বলা")
            {
                vRoot = "বলা";
            }
            else if (verb.Contains("বানান") || verb == "বানান")
            {
                vRoot = "বানান";
            }
            else if (verb.Contains("বাড়ান") || verb == "বাড়ান")
            {
                vRoot = "বাড়ান";
            }
            else if (verb.Contains("বোঝানো") || verb == "বোঝানো")
            {
                vRoot = "বোঝানো";
            }
            else if (verb.Contains("বাজান") || verb == "বাজান")
            {
                vRoot = "বাজান";
            }
            else if (verb.Contains("চাওয়া") || verb == "চাওয়া")
            {
                vRoot = "চাওয়া";
            }
            else if (verb.Contains("চাটা") || verb == "চাটা")
            {
                vRoot = "চাটা";
            }
            else if (verb.Contains("ছড়ান") || verb == "ছড়ান")
            {
                vRoot = "ছড়ান";
            }
            else if (verb.Contains("চেনা") || verb == "চেনা")
            {
                vRoot = "চেনা";
            }
            else if (verb.Contains("চিবান") || verb == "চিবান")
            {
                vRoot = "চিবান";
            }
            else if (verb.Contains("চালান") || verb == "চালান")
            {
                vRoot = "চালান";
            }
            else if (verb.Contains("দেয়া") || verb == "দেয়া")
            {
                vRoot = "দেয়া";
            }
            else if (verb.Contains("দেখা") || verb == "দেখা")
            {
                vRoot = "দেখা";
            }
            else if (verb.Contains("দাঁড়ান") || verb == "দাঁড়ান")
            {
                vRoot = "দাঁড়ান";
            }
            else if (verb.Contains("দেখানো") || verb == "দেখানো")
            {
                vRoot = "দেখানো";
            }
            else if (verb.Contains("ঢাকা") || verb == "ঢাকা")
            {
                vRoot = "ঢাকা";
            }
            else if (verb.Contains("ডাকা") || verb == "ডাকা")
            {
                vRoot = "ডাকা";
            }
            else if (verb.Contains("ধরা") || verb == "ধরা")
            {
                vRoot = "ধরা";
            }
            else if (verb.Contains("ডিঙ্গান") || verb == "ডিঙ্গান")
            {
                vRoot = "ডিঙ্গান";
            }
            else if (verb.Contains("ঢোকান") || verb == "ঢোকান")
            {
                vRoot = "ঢোকান";
            }
            else if (verb.Contains("ফেরা") || verb == "ফেরা")
            {
                vRoot = "ফেরা";
            }
            else if (verb.Contains("ফেলা") || verb == "ফেলা")
            {
                vRoot = "ফেলা";
            }
            else if (verb.Contains("ফুটান") || verb == "ফুটান")
            {
                vRoot = "ফুটান";
            }
            else if (verb.Contains("ঘটা") || verb == "ঘটা")
            {
                vRoot = "ঘটা";
            }
            else if (verb.Contains("গুটান") || verb == "গুটান")
            {
                vRoot = "গুটান";
            }
            else if (verb.Contains("ঘুমান") || verb == "ঘুমান")
            {
                vRoot = "ঘুমান";
            }
            else if (verb.Contains("গাওয়া") || verb == "গাওয়া")
            {
                vRoot = "গাওয়া";
            }
            else if (verb.Contains("গোঙান") || verb == "গোঙান")
            {
                vRoot = "গোঙান";
            }
            else if (verb.Contains("হওয়া") || verb == "হওয়া")
            {
                vRoot = "হওয়া";
            }
            else if (verb.Contains("হাসা") || verb == "হাসা")
            {
                vRoot = "হাসা";
            }
            else if (verb.Contains("জানান") || verb == "জানান")
            {
                vRoot = "জানান";
            }
            else if (verb.Contains("যাওয়া") || verb == "যাওয়া")
            {
                vRoot = "যাওয়া";
            }
            else if (verb.Contains("জ্বালান") || verb == "জ্বালান")
            {
                vRoot = "জ্বালান";
            }
            else if (verb.Contains("জাগা") || verb == "জাগা")
            {
                vRoot = "জাগা";
            }
            else if (verb.Contains("ঝাড়া") || verb == "ঝাড়া")
            {
                vRoot = "ঝাড়া";
            }
            else if (verb.Contains("জন্মান") || verb == "জন্মান")
            {
                vRoot = "জন্মান";
            }
            else if (verb.Contains("ঝুলান") || verb == "ঝুলান")
            {
                vRoot = "ঝুলান";
            }
            else if (verb.Contains("করা") || verb == "করা")
            {
                vRoot = "করা";
            }
            else if (verb.Contains("জানা") || verb == "জানা")
            {
                vRoot = "";
            }
            else if (verb.Contains("কাটা") || verb == "কাটা")
            {
                vRoot = "কাটা";
            }
            else if (verb.Contains("কামান") || verb == "কামান")
            {
                vRoot = "কামান";
            }
            else if (verb.Contains("কেনা") || verb == "কেনা")
            {
                vRoot = "কেনা";
            }
            else if (verb.Contains("কমানো") || verb == "কমানো")
            {
                vRoot = "কমানো";
            }
            else if (verb.Contains("করান") || verb == "করান")
            {
                vRoot = "করান";
            }
            else if (verb.Contains("খাওয়া") || verb == "খাওয়া")
            {
                vRoot = "খাওয়া";
            }
            else if (verb.Contains("খেলা") || verb == "খেলা")
            {
                vRoot = "খেলা";
            }
            else if (verb.Contains("খোলা") || verb == "খোলা")
            {
                vRoot = "খোলা";
            }
            else if (verb.Contains("খাওয়ান") || verb == "খাওয়ান")
            {
                vRoot = "খাওয়ান";
            }
            else if (verb.Contains("খোজা") || verb == "খোজা")
            {
                vRoot = "খোজা";
            }
            else if (verb.Contains("লেখা") || verb == "লেখা")
            {
                vRoot = "লেখা";
            }
            else if (verb.Contains("লাগানো") || verb == "লাগানো")
            {
                vRoot = "লাগানো";
            }
            else if (verb.Contains("লুকান") || verb == "লুকান")
            {
                vRoot = "লুকান";
            }
            else if (verb.Contains("ভাঙ্গা") || verb == "ভাঙ্গা")
            {
                vRoot = "ভাঙ্গা";
            }
            else if (verb.Contains("ভালবাসা") || verb == "ভালবাসা")
            {
                vRoot = "ভালবাসা";
            }
            else if (verb.Contains("ভাজা") || verb == "ভাজা")
            {
                vRoot = "ভাজা";
            }
            else if (verb.Contains("ভাসান") || verb == "ভাসান")
            {
                vRoot = "ভাসান";
            }
            else if (verb.Contains("তাকান") || verb == "তাকান")
            {
                vRoot = "তাকান";
            }
            else if (verb.Contains("থাকা") || verb == "থাকা")
            {
                vRoot = "থাকা";
            }
            else if (verb.Contains("টানা") || verb == "টানা")
            {
                vRoot = "টানা";
            }
            else if (verb.Contains("পাঠান") || verb == "পাঠান")
            {
                vRoot = "পাঠান";
            }
            else if (verb.Contains("পড়া") || verb == "পড়া")
            {
                vRoot = "পরান";
            }
            else if (verb.Contains("পরান") || verb == "পরান")
            {
                vRoot = "";
            }
            else if (verb.Contains("পালানো") || verb == "পালানো")
            {
                vRoot = "পালানো";
            }
            else if (verb.Contains("পাওয়া") || verb == "পাওয়া")
            {
                vRoot = "পাওয়া";
            }
            else if (verb.Contains("রাখা") || verb == "রাখা")
            {
                vRoot = "রাখা";
            }
            else if (verb.Contains("নোয়ান") || verb == "নোয়ান")
            {
                vRoot = "নোয়ান";
            }
            else if (verb.Contains("নেয়া") || verb == "নেয়া")
            {
                vRoot = "নেয়া";
            }
            else if (verb.Contains("নাড়ান") || verb == "নাড়ান")
            {
                vRoot = "নাড়ান";
            }
            else if (verb.Contains("নাচা") || verb == "নাচা")
            {
                vRoot = "নাচা";
            }
            else if (verb.Contains("শেখান") || verb == "শেখান")
            {
                vRoot = "শেখান";
            }
            else if (verb.Contains("শোনা") || verb == "শোনা")
            {
                vRoot = "শোনা";
            }
            else if (verb.Contains("শেখা") || verb == "শেখা")
            {
                vRoot = "শেখা";
            }
            else if (verb.Contains("সাজান") || verb == "সাজান")
            {
                vRoot = "সাজান";
            }
            else if (verb.Contains("শুকান") || verb == "শুকান")
            {
                vRoot = "শুকান";
            }
            else if (verb.Contains("শিখান") || verb == "শিখান")
            {
                vRoot = "শিখান";
            }
            else if (verb.Contains("উঠা") || verb == "উঠা")
            {
                vRoot = "উঠা";
            }
            else if (verb.Contains("ওঠা") || verb == "ওঠা")
            {
                vRoot = "ওঠা";
            }
            else if (verb.Contains("উঠান") || verb == "উঠান")
            {
                vRoot = "উঠান";
            }
            else if (verb.Contains("উড়া") || verb == "উড়া")
            {
                vRoot = "উড়া";
            }
            else if (verb.Contains("মেটান") || verb == "মেটান")
            {
                vRoot = "মেটান";
            }
        }
        public string removePrepositionalAmbiguity(DataTable meaningDT, string[] words, string[] postags, string[] objects, string[] object_postags, string subject, string verb)
        {
            if (words != null)
            {
                TransferAndGeneration_stg aTransferAndGeneration_stg = new TransferAndGeneration_stg();
                for (int i = 0; i < words.Length && words[i] != null; i++)
                {
                    string structure = "";
                    if (words[i] == "for")
                    {
                        structure = idntifyPrepositional_Structure(words, i, postags);
                        switch (structure)
                        {
                            case "case1":
                                prepositionlaAmbiguitySolution += " " + aTransferAndGeneration_stg.IdetifyObjects_NotRelatedWith_Preposition(PStructure_start, PStructure_end, words, meaningDT, subject, verb);
                                if (words[i + 1] == "him")
                                {
                                    prepositionlaAmbiguitySolution += " তার জন্য";
                                }
                                else if (words[i + 1] == "her")
                                {
                                    prepositionlaAmbiguitySolution += " তার জন্য";
                                }
                                else if (words[i + 1] == "them")
                                {
                                    prepositionlaAmbiguitySolution += " তাদের জন্য";
                                }
                                else if (words[i + 1] == "you")
                                {
                                    prepositionlaAmbiguitySolution += " তোমার জন্য";
                                }
                                else if (words[i + 1] == "us")
                                {
                                    prepositionlaAmbiguitySolution += " আমাদের জন্য";
                                }
                                else if (words[i + 1] == "me")
                                {
                                    prepositionlaAmbiguitySolution += " আমার জন্য";
                                }
                                else
                                {
                                    nounMeaning = nounMeaning_Detection(i, 1, words, meaningDT);
                                    prepositionlaAmbiguitySolution = nounMeaning + "এর জন্য";
                                    if (nounMeaning == "")
                                    {
                                        nounMeaning = words[i + 1];
                                    }
                                    prepositionlaAmbiguitySolution += nounMeaning + " এর জন্য";
                                }
                                break;

                            case "case2":
                                prepositionlaAmbiguitySolution += " " + aTransferAndGeneration_stg.IdetifyObjects_NotRelatedWith_Preposition(PStructure_start, PStructure_end, words, meaningDT, subject, verb);
                                nounMeaning = nounMeaning_Detection(i, 2, words, meaningDT);
                                if (words[i + 1] == "a" || words[i + 1] == "an")
                                {
                                    prepositionlaAmbiguitySolution += " একটি" + nounMeaning + " এর জন্য";
                                }
                                else
                                {
                                    prepositionlaAmbiguitySolution += nounMeaning + " টির জন্য";
                                }
                                break;
                            case "case7":
                                nounMeaning = nounMeaning_Detection(i, 2, words, meaningDT);
                                if (words[i + 1] == "his")
                                {
                                    pronounMeaning = "তার";
                                }
                                else if (words[i + 1] == "her")
                                {
                                    pronounMeaning = "তার";
                                }
                                else if (words[i + 1] == "their")
                                {
                                    pronounMeaning = "তাদের";
                                }
                                else if (words[i + 1] == "your")
                                {
                                    pronounMeaning = "তোমার";
                                }
                                else if (words[i + 1] == "our")
                                {
                                    pronounMeaning = "আমাদের";
                                }
                                else if (words[i + 1] == "my")
                                {
                                    pronounMeaning = "আমার";
                                }
                                prepositionlaAmbiguitySolution += pronounMeaning + nounMeaning + "এর জন্য";
                                break;

                            case "case8":
                                prepositionlaAmbiguitySolution += " " + aTransferAndGeneration_stg.IdetifyObjects_NotRelatedWith_Preposition(PStructure_start, PStructure_end, words, meaningDT, subject, verb);
                                monthSeasonMeaming = month_seasonDetection(i, 1, words, meaningDT);
                                if (postags[i + 2] == "CD ")
                                {
                                    monthSeasonMeaming += words[i + 2];
                                }
                                prepositionlaAmbiguitySolution += monthSeasonMeaming + "এর জন্য";
                                break;
                            case "case14":
                                prepositionlaAmbiguitySolution += " " + aTransferAndGeneration_stg.IdetifyObjects_NotRelatedWith_Preposition(PStructure_start, PStructure_end, words, meaningDT, subject, verb);
                                prepositionlaAmbiguitySolution += words[i + 1] + " এর জন্য";
                                break;
                            case "case15":
                                prepositionlaAmbiguitySolution += " " + aTransferAndGeneration_stg.IdetifyObjects_NotRelatedWith_Preposition(PStructure_start, PStructure_end, words, meaningDT, subject, verb);
                                verbMeaning = verbMeaning_Detection(i, 1, words, meaningDT);
                                nounMeaning = nounMeaning_Detection(i, 2, words, meaningDT);
                                prepositionlaAmbiguitySolution += nounMeaning + verbMeaning + " এর জন্য";
                                break;
                            case "case18":
                                prepositionlaAmbiguitySolution += " " + aTransferAndGeneration_stg.IdetifyObjects_NotRelatedWith_Preposition(PStructure_start, PStructure_end, words, meaningDT, subject, verb);
                                nounMeaning = nounMeaning_Detection(i, 2, words, meaningDT);
                                if (postags[i + 2] == "CD " || words[i + 2] == "a" || words[i + 2] == "an")
                                {
                                    if (words[i + 2] == "a" || words[i + 2] == "an")
                                    {
                                        nounMeaning = "একটি" + nounMeaning;
                                    }
                                    else if (words[i + 2] == "the")
                                    {
                                        nounMeaning = words[i + 2] + "টি" + nounMeaning;
                                        nounMeaning = " একটি " + nounMeaning;
                                    }
                                    else
                                    {
                                        nounMeaning = words[i + 2] + " টি " + nounMeaning;
                                    }

                                }
                                prepositionlaAmbiguitySolution += nounMeaning + "এর জন্য";
                                break;
                            case "case43":
                                nounMeaning = nounMeaning_Detection(i, 2, words, meaningDT);
                                prepositionlaAmbiguitySolution += "আরো" + nounMeaning + "এর জন্য";
                                break;
                            case "case44":
                                prepositionlaAmbiguitySolution += " " + aTransferAndGeneration_stg.IdetifyObjects_NotRelatedWith_Preposition(PStructure_start, PStructure_end, words, meaningDT, subject, verb);
                                if (words[i + 1] == "this")
                                {
                                    prepositionlaAmbiguitySolution += " এইটার জন্য";
                                }
                                else
                                {
                                    prepositionlaAmbiguitySolution += " ঐটার জন্য";
                                }
                                break;


                            default: break;
                        }
                    }
                    else if (words[i] == "into")
                    {
                        structure = idntifyPrepositional_Structure(words, i, postags);
                        switch (structure)
                        {
                            case "case1":
                                prepositionlaAmbiguitySolution += " " + aTransferAndGeneration_stg.IdetifyObjects_NotRelatedWith_Preposition(PStructure_start, PStructure_end, words, meaningDT, subject, verb);
                                if (words[i + 1] == "him")
                                {
                                    prepositionlaAmbiguitySolution += " তার মধ্যে";
                                }
                                else if (words[i + 1] == "her")
                                {
                                    prepositionlaAmbiguitySolution += " তার মধ্যে";
                                }
                                else if (words[i + 1] == "them")
                                {
                                    prepositionlaAmbiguitySolution += " তাদের মধ্যে";
                                }
                                else if (words[i + 1] == "you")
                                {
                                    prepositionlaAmbiguitySolution += " তোমার মধ্যে";
                                }
                                else if (words[i + 1] == "us")
                                {
                                    prepositionlaAmbiguitySolution += " আমাদের মধ্যে";
                                }
                                else if (words[i + 1] == "me")
                                {
                                    prepositionlaAmbiguitySolution += " আমার মধ্যে";
                                }
                                else
                                {
                                    nounMeaning = nounMeaning_Detection(i, 1, words, meaningDT);
                                    prepositionlaAmbiguitySolution = nounMeaning + "এ";
                                    if (nounMeaning == "")
                                    {
                                        nounMeaning = words[i + 1];
                                    }
                                    prepositionlaAmbiguitySolution += nounMeaning + " এ";

                                }
                                break;

                            case "case2":
                                prepositionlaAmbiguitySolution += " " + aTransferAndGeneration_stg.IdetifyObjects_NotRelatedWith_Preposition(PStructure_start, PStructure_end, words, meaningDT, subject, verb);
                                nounMeaning = nounMeaning_Detection(i, 2, words, meaningDT);
                                if (words[i + 1] == "a" || words[i + 1] == "an")
                                {
                                    prepositionlaAmbiguitySolution += " একটি " + nounMeaning + " এর মধ্যে";
                                }
                                else
                                {
                                    prepositionlaAmbiguitySolution += nounMeaning + " টির মধ্যে";

                                }
                                break;

                            case "case7":
                                nounMeaning = nounMeaning_Detection(i, 2, words, meaningDT);
                                if (words[i + 1] == "his")
                                {
                                    pronounMeaning = "তার";
                                }
                                else if (words[i + 1] == "her")
                                {
                                    pronounMeaning = "তার";
                                }
                                else if (words[i + 1] == "their")
                                {
                                    pronounMeaning = "তাদের";
                                }
                                else if (words[i + 1] == "your")
                                {
                                    pronounMeaning = "তোমার";
                                }
                                else if (words[i + 1] == "our")
                                {
                                    pronounMeaning = "আমাদের";
                                }
                                else if (words[i + 1] == "my")
                                {
                                    pronounMeaning = "আমার";
                                }
                                prepositionlaAmbiguitySolution += pronounMeaning + nounMeaning + "এর মধ্যে";
                                break;
                            default: break;
                        }
                    }
                    else if (words[i] == "at")
                    {
                        structure = idntifyPrepositional_Structure(words, i, postags);
                        switch (structure)
                        {
                            case "case1":
                                prepositionlaAmbiguitySolution += " " + aTransferAndGeneration_stg.IdetifyObjects_NotRelatedWith_Preposition(PStructure_start, PStructure_end, words, meaningDT, subject, verb);
                                if (words[i + 1] == "him")
                                {
                                    prepositionlaAmbiguitySolution += " তার দিকে";
                                }
                                else if (words[i + 1] == "her")
                                {
                                    prepositionlaAmbiguitySolution += " তার দিকে";
                                }
                                else if (words[i + 1] == "them")
                                {
                                    prepositionlaAmbiguitySolution += " তাদের দিকে";
                                }
                                else if (words[i + 1] == "you")
                                {
                                    prepositionlaAmbiguitySolution += " তোমার দিকে";
                                }
                                else if (words[i + 1] == "us")
                                {
                                    prepositionlaAmbiguitySolution += " আমাদের দিকে";
                                }
                                else if (words[i + 1] == "me")
                                {
                                    prepositionlaAmbiguitySolution += " আমার দিকে";

                                }
                                else
                                {
                                    nounMeaning = nounMeaning_Detection(i, 1, words, meaningDT);
                                    prepositionlaAmbiguitySolution = nounMeaning + "তে";
                                }
                                break;
                            case "case2":
                                nounMeaning = nounMeaning_Detection(i, 2, words, meaningDT);
                                if (words[i + 1] == "a" || words[i + 1] == "a")
                                {
                                    prepositionlaAmbiguitySolution += "একটি" + nounMeaning + "এ";
                                }
                                else
                                {
                                    prepositionlaAmbiguitySolution += nounMeaning + "এ";
                                }
                                break;
                            case "case7":
                                nounMeaning = nounMeaning_Detection(i, 2, words, meaningDT);
                                if (words[i + 1] == "his")
                                {
                                    pronounMeaning = "তার";
                                }
                                else if (words[i + 1] == "her")
                                {
                                    pronounMeaning = "তার";
                                }
                                else if (words[i + 1] == "their")
                                {
                                    pronounMeaning = "তাদের";
                                }
                                else if (words[i + 1] == "your")
                                {
                                    pronounMeaning = "তোমার";
                                }
                                else if (words[i + 1] == "our")
                                {
                                    pronounMeaning = "আমাদের";
                                }
                                else if (words[i + 1] == "my")
                                {
                                    pronounMeaning = "আমার";
                                }
                                prepositionlaAmbiguitySolution += pronounMeaning + nounMeaning + "এর দিকে";
                                break;
                            case "case14":
                                prepositionlaAmbiguitySolution += " " + aTransferAndGeneration_stg.IdetifyObjects_NotRelatedWith_Preposition(PStructure_start, PStructure_end, words, meaningDT, subject, verb);
                                if (words[i + 2] == "o'clock")
                                {
                                    prepositionlaAmbiguitySolution += words[i + 1] + " ঘটিকায়";
                                }
                                else
                                {
                                    prepositionlaAmbiguitySolution += words[i + 1] + " এর জন্য";
                                }

                                break;
                        }
                    }
                    else if (words[i] == "from")
                    {
                        structure = idntifyPrepositional_Structure(words, i, postags);
                        switch (structure)
                        {
                            case "case1":
                                prepositionlaAmbiguitySolution += " " + aTransferAndGeneration_stg.IdetifyObjects_NotRelatedWith_Preposition(PStructure_start, PStructure_end, words, meaningDT, subject, verb);
                                if (words[i + 1] == "him")
                                {
                                    prepositionlaAmbiguitySolution += " তার থেকে";
                                }
                                else if (words[i + 1] == "her")
                                {
                                    prepositionlaAmbiguitySolution += " তার থেকে";
                                }
                                else if (words[i + 1] == "them")
                                {
                                    prepositionlaAmbiguitySolution += " তাদের থেকে";
                                }
                                else if (words[i + 1] == "you")
                                {
                                    prepositionlaAmbiguitySolution += " তোমার থেকে";
                                }
                                else if (words[i + 1] == "us")
                                {
                                    prepositionlaAmbiguitySolution += " আমাদের থেকে";
                                }
                                else if (words[i + 1] == "me")
                                {
                                    prepositionlaAmbiguitySolution += " আমার থেকে";

                                }
                                else
                                {
                                    nounMeaning = nounMeaning_Detection(i, 1, words, meaningDT);
                                    prepositionlaAmbiguitySolution = nounMeaning + "এর থেকে";

                                    if (nounMeaning == "")
                                    {
                                        nounMeaning = words[i + 1];
                                    }
                                    prepositionlaAmbiguitySolution += nounMeaning + "এর থেকে";

                                }
                                break;

                            case "case2":
                                prepositionlaAmbiguitySolution += " " + aTransferAndGeneration_stg.IdetifyObjects_NotRelatedWith_Preposition(PStructure_start, PStructure_end, words, meaningDT, subject, verb);
                                nounMeaning = nounMeaning_Detection(i, 2, words, meaningDT);
                                if (words[i + 1] == "a" || words[i + 1] == "an")
                                {
                                    prepositionlaAmbiguitySolution += " একটি " + nounMeaning + " এর থেকে ";
                                }
                                else
                                {
                                    prepositionlaAmbiguitySolution += nounMeaning + " টির থেকে";
                                }
                                break;

                            case "case7":
                                nounMeaning = nounMeaning_Detection(i, 2, words, meaningDT);
                                if (words[i + 1] == "his")
                                {
                                    pronounMeaning = "তার";
                                }
                                else if (words[i + 1] == "her")
                                {
                                    pronounMeaning = "তার";
                                }
                                else if (words[i + 1] == "their")
                                {
                                    pronounMeaning = "তাদের";
                                }
                                else if (words[i + 1] == "your")
                                {
                                    pronounMeaning = "তোমার";
                                }
                                else if (words[i + 1] == "our")
                                {
                                    pronounMeaning = "আমাদের";
                                }
                                else if (words[i + 1] == "my")
                                {
                                    pronounMeaning = "আমার";
                                }
                                prepositionlaAmbiguitySolution += pronounMeaning + nounMeaning + "থেকে";
                                break;

                            case "case46":
                                prepositionlaAmbiguitySolution += " " + aTransferAndGeneration_stg.IdetifyObjects_NotRelatedWith_Preposition(PStructure_start, PStructure_end, words, meaningDT, subject, verb);
                                nounMeaning = nounMeaning_Detection(i, 1, words, meaningDT);
                                if (nounMeaning == "")
                                {
                                    nounMeaning = words[i + 1];
                                }
                                prepositionlaAmbiguitySolution += nounMeaning + " থেকে";
                                string noun2 = nounMeaning_Detection(i, 3, words, meaningDT);
                                if (noun2 == "")
                                {
                                    noun2 = words[i + 3];
                                }
                                prepositionlaAmbiguitySolution += noun2 + " পর্যন্ত";
                                break;
                            case "case47":
                                prepositionlaAmbiguitySolution += " " + aTransferAndGeneration_stg.IdetifyObjects_NotRelatedWith_Preposition(PStructure_start, PStructure_end, words, meaningDT, subject, verb);
                                nounMeaning = nounMeaning_Detection(i, 2, words, meaningDT);
                                prepositionlaAmbiguitySolution += words[i + 1] + nounMeaning + " থেকে";
                                nounMeaning = nounMeaning_Detection(i, 5, words, meaningDT);
                                prepositionlaAmbiguitySolution += words[i + 4] + nounMeaning + " পর্যন্ত";
                                break;
                        }
                    }
                    else if (words[i] == "on")
                    {
                        structure = idntifyPrepositional_Structure(words, i, postags);
                        switch (structure)
                        {
                            case "case1":
                                prepositionlaAmbiguitySolution += " " + aTransferAndGeneration_stg.IdetifyObjects_NotRelatedWith_Preposition(PStructure_start, PStructure_end, words, meaningDT, subject, verb);
                                if (words[i + 1] == "him")
                                {
                                    prepositionlaAmbiguitySolution += " তার উপর";
                                }
                                else if (words[i + 1] == "her")
                                {
                                    prepositionlaAmbiguitySolution += " তার উপর";
                                }
                                else if (words[i + 1] == "them")
                                {
                                    prepositionlaAmbiguitySolution += " তাদের উপর";
                                }
                                else if (words[i + 1] == "you")
                                {
                                    prepositionlaAmbiguitySolution += " তোমার উপর";
                                }
                                else if (words[i + 1] == "us")
                                {
                                    prepositionlaAmbiguitySolution += " আমাদের উপর";
                                }
                                else if (words[i + 1] == "me")
                                {
                                    prepositionlaAmbiguitySolution += " আমার উপর";

                                }
                                else
                                {
                                    nounMeaning = nounMeaning_Detection(i, 1, words, meaningDT);
                                    if (nounMeaning == "")
                                    {
                                        nounMeaning = words[i + 1];
                                    }
                                    prepositionlaAmbiguitySolution += nounMeaning + " এর উপর";

                                }
                                break;

                            case "case2":
                                prepositionlaAmbiguitySolution += " " + aTransferAndGeneration_stg.IdetifyObjects_NotRelatedWith_Preposition(PStructure_start, PStructure_end, words, meaningDT, subject, verb);
                                nounMeaning = nounMeaning_Detection(i, 2, words, meaningDT);
                                if (words[i + 1] == "a" || words[i + 1] == "an")
                                {
                                    prepositionlaAmbiguitySolution += " একটি " + nounMeaning + " এর উপর";
                                }
                                else
                                {
                                    prepositionlaAmbiguitySolution += nounMeaning + " টির উপর";
                                }
                                break;

                            case "case7":
                                nounMeaning = nounMeaning_Detection(i, 2, words, meaningDT);
                                if (words[i + 1] == "his")
                                {
                                    pronounMeaning = "তার";
                                }
                                else if (words[i + 1] == "her")
                                {
                                    pronounMeaning = "তার";
                                }
                                else if (words[i + 1] == "their")
                                {
                                    pronounMeaning = "তাদের";
                                }
                                else if (words[i + 1] == "your")
                                {
                                    pronounMeaning = "তোমার";
                                }
                                else if (words[i + 1] == "our")
                                {
                                    pronounMeaning = "আমাদের";
                                }
                                else if (words[i + 1] == "my")
                                {
                                    pronounMeaning = "আমার";
                                }
                                prepositionlaAmbiguitySolution += pronounMeaning + nounMeaning + "এর উপর";
                                break;
                            case "case8":
                                prepositionlaAmbiguitySolution += " " + aTransferAndGeneration_stg.IdetifyObjects_NotRelatedWith_Preposition(PStructure_start, PStructure_end, words, meaningDT, subject, verb);
                                monthSeasonMeaming = month_seasonDetection(i, 1, words, meaningDT);
                                if (postags[i + 2] == "CD ")
                                {
                                    monthSeasonMeaming += words[i + 2];
                                }

                                prepositionlaAmbiguitySolution += monthSeasonMeaming + "এর জন্য";
                                break;
                            case "case14":
                                prepositionlaAmbiguitySolution += " " + aTransferAndGeneration_stg.IdetifyObjects_NotRelatedWith_Preposition(PStructure_start, PStructure_end, words, meaningDT, subject, verb);
                                prepositionlaAmbiguitySolution += words[i + 1] + " এ";
                                break;
                            case "case18":
                                prepositionlaAmbiguitySolution += " " + aTransferAndGeneration_stg.IdetifyObjects_NotRelatedWith_Preposition(PStructure_start, PStructure_end, words, meaningDT, subject, verb);
                                nounMeaning = nounMeaning_Detection(i, 2, words, meaningDT);
                                if (postags[i + 2] == "CD " || words[i + 2] == "a" || words[i + 2] == "an")
                                {
                                    if (words[i + 2] == "a" || words[i + 2] == "an")

                                    {
                                        nounMeaning = "এক" + nounMeaning;
                                    }
                                    else
                                    {
                                        nounMeaning = words[i + 2] + "টি" + nounMeaning;
                                    }

                                }
                                prepositionlaAmbiguitySolution += nounMeaning + "এর উপর";
                                break;
                            case "case19":
                                prepositionlaAmbiguitySolution += " " + aTransferAndGeneration_stg.IdetifyObjects_NotRelatedWith_Preposition(PStructure_start, PStructure_end, words, meaningDT, subject, verb);
                                dayMeaning = dayMeaning_Detection(i, 1, words, meaningDT);
                                prepositionlaAmbiguitySolution += dayMeaning + " এ";
                                break;
                            case "case24":
                                prepositionlaAmbiguitySolution += " " + aTransferAndGeneration_stg.IdetifyObjects_NotRelatedWith_Preposition(PStructure_start, PStructure_end, words, meaningDT, subject, verb);
                                nounMeaning = nounMeaning_Detection(i, 2, words, meaningDT);
                                if (words[i + 1] == "this")
                                {
                                    nounMeaning = " এই " + nounMeaning;
                                }
                                else if (words[i + 1] == "that")
                                {
                                    nounMeaning = " ঐ " + nounMeaning;
                                }
                                else if (words[i + 1] == "these")
                                {
                                    nounMeaning = " এই " + nounMeaning + " গুলো ";
                                }
                                else
                                {
                                    nounMeaning = " ঐ " + nounMeaning + " গুলো ";

                                }
                                prepositionlaAmbiguitySolution += nounMeaning + "এর উপর";
                                break;
                            case "case48":
                                prepositionlaAmbiguitySolution += " " + aTransferAndGeneration_stg.IdetifyObjects_NotRelatedWith_Preposition(PStructure_start, PStructure_end, words, meaningDT, subject, verb);
                                nounMeaning = nounMeaning_Detection(i, 1, words, meaningDT);
                                if (nounMeaning == "")
                                {
                                    nounMeaning = words[i + 1];
                                }
                                prepositionlaAmbiguitySolution += nounMeaning + "" + words[i + 2] + " এ";

                                break;
                        }
                    }
                    else if (words[i] == "in")
                    {
                        structure = idntifyPrepositional_Structure(words, i, postags);
                        switch (structure)
                        {
                            case "case1":
                                prepositionlaAmbiguitySolution += " " + aTransferAndGeneration_stg.IdetifyObjects_NotRelatedWith_Preposition(PStructure_start, PStructure_end, words, meaningDT, subject, verb);
                                if (words[i + 1] == "him")
                                {
                                    prepositionlaAmbiguitySolution += " তার মধ্যে";
                                }
                                else if (words[i + 1] == "her")
                                {
                                    prepositionlaAmbiguitySolution += " তার মধ্যে";
                                }
                                else if (words[i + 1] == "them")
                                {
                                    prepositionlaAmbiguitySolution += " তাদের মধ্যে";
                                }
                                else if (words[i + 1] == "you")
                                {
                                    prepositionlaAmbiguitySolution += " তোমার মধ্যে";
                                }
                                else if (words[i + 1] == "us")
                                {
                                    prepositionlaAmbiguitySolution += " আমাদের মধ্যে";
                                }
                                else if (words[i + 1] == "me")
                                {
                                    prepositionlaAmbiguitySolution += " আমার মধ্যে";
                                }
                                else
                                {
                                    nounMeaning = nounMeaning_Detection(i, 1, words, meaningDT);
                                    if (nounMeaning == "")
                                    {
                                        nounMeaning = words[i + 1];
                                    }
                                    prepositionlaAmbiguitySolution += nounMeaning + " এর মধ্যে";
                                }
                                break;

                            case "case2":
                                prepositionlaAmbiguitySolution += " " + aTransferAndGeneration_stg.IdetifyObjects_NotRelatedWith_Preposition(PStructure_start, PStructure_end, words, meaningDT, subject, verb);
                                nounMeaning = nounMeaning_Detection(i, 2, words, meaningDT);
                                if (words[i + 1] == "a" || words[i + 1] == "an")
                                {
                                    prepositionlaAmbiguitySolution += " একটি " + nounMeaning + " এর মধ্যে";
                                }
                                else
                                {
                                    prepositionlaAmbiguitySolution += nounMeaning + " টির মধ্যে";
                                }
                                break;
                            case "case7":
                                prepositionlaAmbiguitySolution += " " + aTransferAndGeneration_stg.IdetifyObjects_NotRelatedWith_Preposition(PStructure_start, PStructure_end, words, meaningDT, subject, verb);
                                nounMeaning = nounMeaning_Detection(i, 2, words, meaningDT);
                                if (words[i + 1] == "his")
                                {
                                    pronounMeaning = " তার ";
                                }
                                else if (words[i + 1] == "her")
                                {
                                    pronounMeaning = " তার ";
                                }
                                else if (words[i + 1] == "their")
                                {
                                    pronounMeaning = " তাদের ";
                                }
                                else if (words[i + 1] == "your")
                                {
                                    pronounMeaning = " তোমার ";
                                }
                                else if (words[i + 1] == "our")
                                {
                                    pronounMeaning = " আমাদের ";
                                }
                                else if (words[i + 1] == "my")
                                {
                                    pronounMeaning = " আমার ";
                                }
                                prepositionlaAmbiguitySolution += pronounMeaning + nounMeaning + "এর মধ্যে";
                                break;
                            case "case8":
                                prepositionlaAmbiguitySolution += " " + aTransferAndGeneration_stg.IdetifyObjects_NotRelatedWith_Preposition(PStructure_start, PStructure_end, words, meaningDT, subject, verb);
                                monthSeasonMeaming = month_seasonDetection(i, 1, words, meaningDT);
                                if (postags[i + 2] == "CD ")
                                {
                                    monthSeasonMeaming += words[i + 2];
                                }
                                prepositionlaAmbiguitySolution += monthSeasonMeaming + " এর মধ্যে";
                                break;
                            case "case10":
                                prepositionlaAmbiguitySolution += " " + aTransferAndGeneration_stg.IdetifyObjects_NotRelatedWith_Preposition(PStructure_start, PStructure_end, words, meaningDT, subject, verb);
                                nounMeaning = nounMeaning_Detection(i, 2, words, meaningDT);
                                prepositionlaAmbiguitySolution += nounMeaning + " এ";//in the morning
                                break;
                            case "case12":
                                prepositionlaAmbiguitySolution += " " + aTransferAndGeneration_stg.IdetifyObjects_NotRelatedWith_Preposition(PStructure_start, PStructure_end, words, meaningDT, subject, verb);
                                nounMeaning = nounMeaning_Detection(i, 2, words, meaningDT);
                                if (int.Parse(words[i + 1]) > 0)
                                {
                                    prepositionlaAmbiguitySolution += words[i + 1] + nounMeaning + " এ";
                                }
                                else if (words[i + 1] == "a")
                                {
                                    prepositionlaAmbiguitySolution += " এক " + nounMeaning + " এ";
                                }
                                else
                                {
                                    string numberMeaning = "";
                                    numberMeaning = nounMeaning_Detection(i, 1, words, meaningDT);
                                    prepositionlaAmbiguitySolution += numberMeaning + nounMeaning + "এ";
                                }
                                break;
                            case "case14":
                                prepositionlaAmbiguitySolution += " " + aTransferAndGeneration_stg.IdetifyObjects_NotRelatedWith_Preposition(PStructure_start, PStructure_end, words, meaningDT, subject, verb);
                                prepositionlaAmbiguitySolution += words[i + 1] + " এর মধ্যে";
                                break;
                            case "case24":
                                if (words[i + 1] == "this")
                                {
                                    nounMeaning = " এই ";
                                    nounMeaning += nounMeaning_Detection(i, 2, words, meaningDT);
                                }
                                else if (words[i + 1] == "that")
                                {
                                    nounMeaning = "ঐ ";
                                    nounMeaning += nounMeaning_Detection(i, 2, words, meaningDT);
                                }
                                else if (words[i + 1] == "thsese")
                                {
                                    nounMeaning = " এই ";
                                    nounMeaning += nounMeaning_Detection(i, 2, words, meaningDT);
                                    nounMeaning += " গুলো ";
                                }
                                else
                                {
                                    nounMeaning = " ঐ ";
                                    nounMeaning += nounMeaning_Detection(i, 2, words, meaningDT);
                                    nounMeaning += " গুলো ";
                                }
                                prepositionlaAmbiguitySolution += nounMeaning + "এর মধ্যে";
                                break;
                            case "case32":
                                prepositionlaAmbiguitySolution += " " + aTransferAndGeneration_stg.IdetifyObjects_NotRelatedWith_Preposition(PStructure_start, PStructure_end, words, meaningDT, subject, verb);
                                nounMeaning = nounMeaning_Detection(i, 1, words, meaningDT);
                                prepositionlaAmbiguitySolution += nounMeaning + " এ";//in summer
                                break;
                            case "case49":
                                prepositionlaAmbiguitySolution += " " + aTransferAndGeneration_stg.IdetifyObjects_NotRelatedWith_Preposition(PStructure_start, PStructure_end, words, meaningDT, subject, verb);
                                if (words[i + 3] == "days")
                                {
                                    nounMeaning = " দিনে ";
                                }
                                else if (words[i + 3] == "hours")
                                {
                                    nounMeaning = " ঘন্টায়  ";
                                }
                                else if (words[i + 3] == "minutes")
                                {
                                    nounMeaning = " মিনিটে ";
                                }
                                else if (words[i + 3] == "seconds")
                                {
                                    nounMeaning = " সেকেন্ডে ";
                                }
                                else if (words[i + 3] == "moments")
                                {
                                    nounMeaning = " মুহূর্তে ";
                                }
                                prepositionlaAmbiguitySolution += " কয়েক" + nounMeaning;//in summer
                                break;

                        }
                    }
                    else if (words[i] == "of")
                    {
                        structure = idntifyPrepositional_Structure(words, i, postags);
                        switch (structure)
                        {
                            case "case1":
                                prepositionlaAmbiguitySolution += " " + aTransferAndGeneration_stg.IdetifyObjects_NotRelatedWith_Preposition(PStructure_start, PStructure_end, words, meaningDT, subject, verb);
                                if (words[i + 1] == "him")
                                {
                                    prepositionlaAmbiguitySolution += " তার ";
                                }
                                else if (words[i + 1] == "her")
                                {
                                    prepositionlaAmbiguitySolution += " তার ";
                                }
                                else if (words[i + 1] == "them")
                                {
                                    prepositionlaAmbiguitySolution += " তাদের ";
                                }
                                else if (words[i + 1] == "you")
                                {
                                    prepositionlaAmbiguitySolution += " তোমার ";
                                }
                                else if (words[i + 1] == "us")
                                {
                                    prepositionlaAmbiguitySolution += " আমাদের ";
                                }
                                else if (words[i + 1] == "me")
                                {
                                    prepositionlaAmbiguitySolution += " আমার ";
                                }
                                else
                                {
                                    nounMeaning = nounMeaning_Detection(i, 1, words, meaningDT);
                                    if (nounMeaning == "")
                                    {
                                        nounMeaning = words[i + 1];
                                    }
                                    prepositionlaAmbiguitySolution += nounMeaning + " এর ";
                                }
                                break;

                            case "case2":
                                prepositionlaAmbiguitySolution += " " + aTransferAndGeneration_stg.IdetifyObjects_NotRelatedWith_Preposition(PStructure_start, PStructure_end, words, meaningDT, subject, verb);
                                nounMeaning = nounMeaning_Detection(i, 2, words, meaningDT);
                                if (words[i + 1] == "a" || words[i + 1] == "an")
                                {
                                    prepositionlaAmbiguitySolution += " একটি " + nounMeaning + " এর ";
                                }
                                else
                                {
                                    prepositionlaAmbiguitySolution += nounMeaning + " টির ";
                                }
                                break;

                            case "case7":
                                prepositionlaAmbiguitySolution += " " + aTransferAndGeneration_stg.IdetifyObjects_NotRelatedWith_Preposition(PStructure_start, PStructure_end, words, meaningDT, subject, verb);
                                nounMeaning = nounMeaning_Detection(i, 2, words, meaningDT);
                                if (words[i + 1] == "his")
                                {
                                    pronounMeaning = " তার ";
                                }
                                else if (words[i + 1] == "her")
                                {
                                    pronounMeaning = " তার ";
                                }
                                else if (words[i + 1] == "their")
                                {
                                    pronounMeaning = " তাদের ";
                                }
                                else if (words[i + 1] == "your")
                                {
                                    pronounMeaning = " তোমার ";
                                }
                                else if (words[i + 1] == "our")
                                {
                                    pronounMeaning = " আমাদের ";
                                }
                                else if (words[i + 1] == "my")
                                {
                                    pronounMeaning = " আমার ";
                                }
                                prepositionlaAmbiguitySolution += pronounMeaning + nounMeaning + " এর";
                                break;
                            case "case14":
                                prepositionlaAmbiguitySolution += " " + aTransferAndGeneration_stg.IdetifyObjects_NotRelatedWith_Preposition(PStructure_start, PStructure_end, words, meaningDT, subject, verb);
                                prepositionlaAmbiguitySolution += words[i + 1] + " এর";
                                break;
                            case "case35":
                                prepositionlaAmbiguitySolution += " " + aTransferAndGeneration_stg.IdetifyObjects_NotRelatedWith_Preposition(PStructure_start, PStructure_end, words, meaningDT, subject, verb);
                                if (words[i + 1] == "most")
                                {
                                    nounMeaning = " অধিকাংশ ";
                                }
                                else if (words[i + 1] == "most")
                                {
                                    nounMeaning = " আরো ";
                                }
                                nounMeaning += nounMeaning_Detection(i, 2, words, meaningDT);
                                prepositionlaAmbiguitySolution += nounMeaning + "এর ";
                                break;
                            case "case50":
                                prepositionlaAmbiguitySolution += " " + aTransferAndGeneration_stg.IdetifyObjects_NotRelatedWith_Preposition(PStructure_start, PStructure_end, words, meaningDT, subject, verb);
                                nounMeaning = "সব ";
                                nounMeaning += nounMeaning_Detection(i, 3, words, meaningDT);
                                prepositionlaAmbiguitySolution += nounMeaning + " এর ";
                                break;
                            case "case51":
                                prepositionlaAmbiguitySolution += " " + aTransferAndGeneration_stg.IdetifyObjects_NotRelatedWith_Preposition(PStructure_start, PStructure_end, words, meaningDT, subject, verb);
                                nounMeaning = "সব ";
                                nounMeaning += nounMeaning_Detection(i, 2, words, meaningDT);
                                prepositionlaAmbiguitySolution += nounMeaning + " এর ";
                                break;
                            case "case52":
                                prepositionlaAmbiguitySolution += " " + aTransferAndGeneration_stg.IdetifyObjects_NotRelatedWith_Preposition(PStructure_start, PStructure_end, words, meaningDT, subject, verb);
                                nounMeaning = nounMeaning_Detection(i, 1, words, meaningDT);
                                nounMeaning += "এর ";
                                nounMeaning += nounMeaning_Detection(i, -1, words, meaningDT);
                                prepositionlaAmbiguitySolution += nounMeaning;
                                break;
                            case "case53":
                                prepositionlaAmbiguitySolution += " " + aTransferAndGeneration_stg.IdetifyObjects_NotRelatedWith_Preposition(PStructure_start, PStructure_end, words, meaningDT, subject, verb);
                                nounMeaning = nounMeaning_Detection(i, 2, words, meaningDT);
                                nounMeaning += " এর ";
                                nounMeaning += nounMeaning_Detection(i, -1, words, meaningDT);
                                prepositionlaAmbiguitySolution += nounMeaning;
                                break;
                        }
                    }
                    else if (words[i] == "by")
                    {
                        structure = idntifyPrepositional_Structure(words, i, postags);
                        switch (structure)
                        {
                            case "case1":
                                prepositionlaAmbiguitySolution += " " + aTransferAndGeneration_stg.IdetifyObjects_NotRelatedWith_Preposition(PStructure_start, PStructure_end, words, meaningDT, subject, verb);
                                if (words[i + 1] == "him")
                                {
                                    prepositionlaAmbiguitySolution += " তার দ্বারা ";
                                }
                                else if (words[i + 1] == "her")
                                {
                                    prepositionlaAmbiguitySolution += " তার দ্বারা ";
                                }
                                else if (words[i + 1] == "them")
                                {
                                    prepositionlaAmbiguitySolution += " তাদের দ্বারা ";
                                }
                                else if (words[i + 1] == "you")
                                {
                                    prepositionlaAmbiguitySolution += " তোমার দ্বারা ";
                                }
                                else if (words[i + 1] == "us")
                                {
                                    prepositionlaAmbiguitySolution += " আমাদের দ্বারা ";
                                }
                                else if (words[i + 1] == "me")
                                {
                                    prepositionlaAmbiguitySolution += " আমার দ্বারা ";
                                }
                                else
                                {
                                    nounMeaning = nounMeaning_Detection(i, 1, words, meaningDT);
                                    if (nounMeaning == "")
                                    {
                                        nounMeaning = words[i + 1];
                                    }
                                    prepositionlaAmbiguitySolution += nounMeaning + " এর দ্বারা ";
                                }
                                break;

                            case "case2":
                                prepositionlaAmbiguitySolution += " " + aTransferAndGeneration_stg.IdetifyObjects_NotRelatedWith_Preposition(PStructure_start, PStructure_end, words, meaningDT, subject, verb);
                                nounMeaning = nounMeaning_Detection(i, 2, words, meaningDT);
                                if (words[i + 1] == "a" || words[i + 1] == "an")
                                {
                                    prepositionlaAmbiguitySolution += " একটি " + nounMeaning + " এর দ্বারা ";
                                }
                                else
                                {
                                    prepositionlaAmbiguitySolution += nounMeaning + " টির দ্বারা ";
                                }
                                break;
                            case "case14":
                                prepositionlaAmbiguitySolution += " " + aTransferAndGeneration_stg.IdetifyObjects_NotRelatedWith_Preposition(PStructure_start, PStructure_end, words, meaningDT, subject, verb);
                                prepositionlaAmbiguitySolution += words[i + 1] + " এর দ্বারা";
                                break;
                            case "case54":
                                prepositionlaAmbiguitySolution += " " + aTransferAndGeneration_stg.IdetifyObjects_NotRelatedWith_Preposition(PStructure_start, PStructure_end, words, meaningDT, subject, verb);
                                if (words[i + 1] == "sea")
                                {
                                    nounMeaning = " নৌপথে ";
                                }
                                else if (words[i + 1] == "land")
                                {
                                    nounMeaning = " স্থলপথে ";
                                }
                                else if (words[i + 1] == "air")
                                {
                                    nounMeaning = " আকাশপথে ";
                                }
                                prepositionlaAmbiguitySolution += nounMeaning;
                                break;
                            case "case55":
                                prepositionlaAmbiguitySolution += " " + aTransferAndGeneration_stg.IdetifyObjects_NotRelatedWith_Preposition(PStructure_start, PStructure_end, words, meaningDT, subject, verb);
                                if (words[i + 1] == "tomorrow")
                                {
                                    nounMeaning = " আগামীকালের মধ্যে ";
                                }
                                else if (words[i + 1] == "yesterday")
                                {
                                    nounMeaning = " গতকালের মধ্যে";
                                }
                                else if (words[i + 1] == "today")
                                {
                                    nounMeaning = " আজকের মধ্যে";
                                }
                                else if (words[i + 1] == "now")
                                {
                                    nounMeaning = " এখনই ";
                                }
                                prepositionlaAmbiguitySolution += nounMeaning;
                                break;
                            case "case56":
                                prepositionlaAmbiguitySolution += " " + aTransferAndGeneration_stg.IdetifyObjects_NotRelatedWith_Preposition(PStructure_start, PStructure_end, words, meaningDT, subject, verb);
                                if (words[i + 1] == "this" && words[i + 2] == "time")
                                {
                                    nounMeaning = " ইতিমধ্যে ";
                                }
                                else if (words[i + 1] == "this")
                                {
                                    nounMeaning = " এই ";
                                    nounMeaning += nounMeaning_Detection(i, 2, words, meaningDT);
                                    nounMeaning += " দ্বারা ";
                                }
                                else if (words[i + 1] == "that")
                                {
                                    nounMeaning = " ওই ";
                                    nounMeaning += nounMeaning_Detection(i, 2, words, meaningDT);
                                    nounMeaning += " দ্বারা ";
                                }
                                else if (words[i + 1] == "these ")
                                {
                                    nounMeaning = " এই ";
                                    nounMeaning += nounMeaning_Detection(i, 2, words, meaningDT);
                                    nounMeaning += " গুলো দ্বারা";
                                }
                                else if (words[i + 1] == "those")
                                {
                                    nounMeaning = " ঐ ";
                                    nounMeaning += nounMeaning_Detection(i, 2, words, meaningDT);
                                    nounMeaning += " গুলো দ্বারা ";
                                }
                                prepositionlaAmbiguitySolution += nounMeaning;
                                break;
                        }
                    }
                    else if (words[i] == "after")
                    {
                        structure = idntifyPrepositional_Structure(words, i, postags);
                        switch (structure)
                        {
                            case "case1":
                                prepositionlaAmbiguitySolution += " " + aTransferAndGeneration_stg.IdetifyObjects_NotRelatedWith_Preposition(PStructure_start, PStructure_end, words, meaningDT, subject, verb);
                                if (words[i + 1] == "him")
                                {
                                    prepositionlaAmbiguitySolution += " তার পর ";
                                }
                                else if (words[i + 1] == "her")
                                {
                                    prepositionlaAmbiguitySolution += " তার পর ";
                                }
                                else if (words[i + 1] == "them")
                                {
                                    prepositionlaAmbiguitySolution += " তাদের পর ";
                                }
                                else if (words[i + 1] == "you")
                                {
                                    prepositionlaAmbiguitySolution += " তোমার পর ";
                                }
                                else if (words[i + 1] == "us")
                                {
                                    prepositionlaAmbiguitySolution += " আমাদের পর ";
                                }
                                else if (words[i + 1] == "me")
                                {
                                    prepositionlaAmbiguitySolution += " আমার পর ";
                                }
                                else if (words[i + 1] == "mine")
                                {
                                    prepositionlaAmbiguitySolution += " আমার পর ";
                                }
                                else
                                {
                                    nounMeaning = nounMeaning_Detection(i, 1, words, meaningDT);
                                    if (nounMeaning == "")
                                    {
                                        nounMeaning = words[i + 1];
                                    }
                                    prepositionlaAmbiguitySolution = nounMeaning + " এর পর ";
                                }
                                break;

                            case "case2":
                                prepositionlaAmbiguitySolution += " " + aTransferAndGeneration_stg.IdetifyObjects_NotRelatedWith_Preposition(PStructure_start, PStructure_end, words, meaningDT, subject, verb);
                                nounMeaning = nounMeaning_Detection(i, 2, words, meaningDT);
                                if (words[i + 1] == "a" || words[i + 1] == "an")
                                {
                                    prepositionlaAmbiguitySolution += " একটি " + nounMeaning + " এর পর ";
                                }
                                else
                                {
                                    prepositionlaAmbiguitySolution += nounMeaning + " টির পর ";
                                }
                                break;

                            case "case14":
                                prepositionlaAmbiguitySolution += " " + aTransferAndGeneration_stg.IdetifyObjects_NotRelatedWith_Preposition(PStructure_start, PStructure_end, words, meaningDT, subject, verb);
                                prepositionlaAmbiguitySolution += words[i + 1] + " এর পর ";
                                break;
                            case "case19":
                                prepositionlaAmbiguitySolution += " " + aTransferAndGeneration_stg.IdetifyObjects_NotRelatedWith_Preposition(PStructure_start, PStructure_end, words, meaningDT, subject, verb);
                                dayMeaning = dayMeaning_Detection(i, 1, words, meaningDT);
                                prepositionlaAmbiguitySolution += dayMeaning + "এর পর ";
                                break;
                            case "case29":
                                prepositionlaAmbiguitySolution += " " + aTransferAndGeneration_stg.IdetifyObjects_NotRelatedWith_Preposition(PStructure_start, PStructure_end, words, meaningDT, subject, verb);
                                if (words[i + 1] == "a" || words[i + 1] == "an")
                                {
                                    nounMeaning = nounMeaning_Detection(i, 3, words, meaningDT);
                                    nounMeaning += " একটি " + nounMeaning;
                                    nounMeaning += nounMeaning_Detection(i, 1, words, meaningDT);
                                    prepositionlaAmbiguitySolution += nounMeaning + " এর পর ";
                                }
                                else
                                {
                                    nounMeaning = nounMeaning_Detection(i, 3, words, meaningDT);
                                    nounMeaning += nounMeaning + " টি ";
                                    nounMeaning += nounMeaning_Detection(i, 1, words, meaningDT);
                                    prepositionlaAmbiguitySolution = nounMeaning + " র পর ";
                                }
                                break;
                        }
                    }
                    else if (words[i] == "above")
                    {
                        switch (structure)
                        {
                            case "case1":
                                prepositionlaAmbiguitySolution += " " + aTransferAndGeneration_stg.IdetifyObjects_NotRelatedWith_Preposition(PStructure_start, PStructure_end, words, meaningDT, subject, verb);
                                if (words[i + 1] == "him")
                                {
                                    prepositionlaAmbiguitySolution += " তার উপর";
                                }
                                else if (words[i + 1] == "her")
                                {
                                    prepositionlaAmbiguitySolution += " তার উপর";
                                }
                                else if (words[i + 1] == "them")
                                {
                                    prepositionlaAmbiguitySolution += " তাদের উপর";
                                }
                                else if (words[i + 1] == "you")
                                {
                                    prepositionlaAmbiguitySolution += " তোমার উপর";
                                }
                                else if (words[i + 1] == "us")
                                {
                                    prepositionlaAmbiguitySolution += " আমাদের উপর";
                                }
                                else if (words[i + 1] == "me")
                                {
                                    prepositionlaAmbiguitySolution += " আমার উপর";
                                }
                                else
                                {
                                    nounMeaning = nounMeaning_Detection(i, 1, words, meaningDT);
                                    if (nounMeaning == "")
                                    {
                                        nounMeaning = words[i + 1];
                                    }
                                    prepositionlaAmbiguitySolution += nounMeaning + " এর উপর";
                                }
                                break;

                            case "case2":
                                prepositionlaAmbiguitySolution += " " + aTransferAndGeneration_stg.IdetifyObjects_NotRelatedWith_Preposition(PStructure_start, PStructure_end, words, meaningDT, subject, verb);
                                nounMeaning = nounMeaning_Detection(i, 2, words, meaningDT);
                                if (words[i + 1] == "a" || words[i + 1] == "an")
                                {
                                    prepositionlaAmbiguitySolution += " একটি " + nounMeaning + " এর উপর ";
                                }
                                else
                                {
                                    prepositionlaAmbiguitySolution += nounMeaning + " টির উপর";
                                }
                                break;

                            case "case7":
                                prepositionlaAmbiguitySolution += " " + aTransferAndGeneration_stg.IdetifyObjects_NotRelatedWith_Preposition(PStructure_start, PStructure_end, words, meaningDT, subject, verb);
                                nounMeaning = nounMeaning_Detection(i, 2, words, meaningDT);
                                if (words[i + 1] == "his")
                                {
                                    pronounMeaning = " তার ";
                                }
                                else if (words[i + 1] == "her")
                                {
                                    pronounMeaning = " তার ";
                                }
                                else if (words[i + 1] == "their")
                                {
                                    pronounMeaning = " তাদের ";
                                }
                                else if (words[i + 1] == "your")
                                {
                                    pronounMeaning = " তোমার ";
                                }
                                else if (words[i + 1] == "our")
                                {
                                    pronounMeaning = " আমাদের ";
                                }
                                else if (words[i + 1] == "my")
                                {
                                    pronounMeaning = " আমার ";
                                }
                                prepositionlaAmbiguitySolution += pronounMeaning + nounMeaning + " এর উপর";
                                break;

                            case "case14":
                                prepositionlaAmbiguitySolution += " " + aTransferAndGeneration_stg.IdetifyObjects_NotRelatedWith_Preposition(PStructure_start, PStructure_end, words, meaningDT, subject, verb);
                                prepositionlaAmbiguitySolution += words[i + 1] + " এর উপর";
                                break;
                            case "case35":
                                prepositionlaAmbiguitySolution += " " + aTransferAndGeneration_stg.IdetifyObjects_NotRelatedWith_Preposition(PStructure_start, PStructure_end, words, meaningDT, subject, verb);
                                if (words[i + 1] == "most")
                                {
                                    nounMeaning = " অধিকাংশ ";
                                }
                                else if (words[i + 1] == "more")
                                {
                                    nounMeaning = " আরো ";
                                }
                                nounMeaning += nounMeaning_Detection(i, 2, words, meaningDT);
                                prepositionlaAmbiguitySolution += nounMeaning + " এর উপর ";
                                break;
                            case "case36":
                                prepositionlaAmbiguitySolution += " " + aTransferAndGeneration_stg.IdetifyObjects_NotRelatedWith_Preposition(PStructure_start, PStructure_end, words, meaningDT, subject, verb);
                                if (words[i + 1] == "any")
                                {
                                    nounMeaning = " অন্য যে কোনো ";
                                }
                                else if (words[i + 1] == "some")
                                {
                                    nounMeaning = " কিছু ";
                                }
                                else if (words[i + 1] == "all")
                                {
                                    nounMeaning = " অন্য সব ";
                                }
                                else if (words[i + 1] == "most")
                                {
                                    nounMeaning = " অধিকাংশ ";
                                }
                                nounMeaning += nounMeaning_Detection(i, 3, words, meaningDT);
                                prepositionlaAmbiguitySolution += nounMeaning + " এর উপর ";
                                break;
                        }
                    }
                    else if (words[i] == "along")
                    {
                        structure = idntifyPrepositional_Structure(words, i, postags);
                        switch (structure)
                        {
                            case "case1":
                                prepositionlaAmbiguitySolution += " " + aTransferAndGeneration_stg.IdetifyObjects_NotRelatedWith_Preposition(PStructure_start, PStructure_end, words, meaningDT, subject, verb);
                                if (words[i + 1] == "him")
                                {
                                    prepositionlaAmbiguitySolution += " তার পাশে ";
                                }
                                else if (words[i + 1] == "her")
                                {
                                    prepositionlaAmbiguitySolution += " তার পাশে ";
                                }
                                else if (words[i + 1] == "them")
                                {
                                    prepositionlaAmbiguitySolution += " তাদের পাশে ";
                                }
                                else if (words[i + 1] == "you")
                                {
                                    prepositionlaAmbiguitySolution += " তোমার পাশে ";
                                }
                                else if (words[i + 1] == "us")
                                {
                                    prepositionlaAmbiguitySolution += " আমাদের পাশে ";
                                }
                                else if (words[i + 1] == "me")
                                {
                                    prepositionlaAmbiguitySolution += " আমার পাশে ";
                                }
                                else
                                {
                                    nounMeaning = nounMeaning_Detection(i, 1, words, meaningDT);
                                    if (nounMeaning == "")
                                    {
                                        nounMeaning = words[i + 1];
                                    }
                                    prepositionlaAmbiguitySolution += nounMeaning + " এর পাশে ";
                                }
                                break;

                            case "case2":
                                prepositionlaAmbiguitySolution += " " + aTransferAndGeneration_stg.IdetifyObjects_NotRelatedWith_Preposition(PStructure_start, PStructure_end, words, meaningDT, subject, verb);
                                nounMeaning = nounMeaning_Detection(i, 2, words, meaningDT);
                                if (words[i + 1] == "a" || words[i + 1] == "an")
                                {
                                    prepositionlaAmbiguitySolution += " একটি" + nounMeaning + " এর পাশে ";
                                }
                                else
                                {
                                    prepositionlaAmbiguitySolution += nounMeaning + " টির পাশে ";
                                }
                                break;
                        }
                    }

                    else if (words[i] == "against")
                    {
                        structure = idntifyPrepositional_Structure(words, i, postags);
                        switch (structure)
                        {
                            case "case1":
                                prepositionlaAmbiguitySolution += " " + aTransferAndGeneration_stg.IdetifyObjects_NotRelatedWith_Preposition(PStructure_start, PStructure_end, words, meaningDT, subject, verb);
                                if (words[i + 1] == "him")
                                {
                                    prepositionlaAmbiguitySolution += " তার বিপক্ষে";
                                }
                                else if (words[i + 1] == "her")
                                {
                                    prepositionlaAmbiguitySolution += " তার বিপক্ষে";
                                }
                                else if (words[i + 1] == "them")
                                {
                                    prepositionlaAmbiguitySolution += " তাদের বিপক্ষে";
                                }
                                else if (words[i + 1] == "you")
                                {
                                    prepositionlaAmbiguitySolution += " তোমার বিপক্ষে";
                                }
                                else if (words[i + 1] == "us")
                                {
                                    prepositionlaAmbiguitySolution += " আমাদের বিপক্ষে";
                                }
                                else if (words[i + 1] == "me")
                                {
                                    prepositionlaAmbiguitySolution += " আমার বিপক্ষে";
                                }
                                else
                                {
                                    nounMeaning = nounMeaning_Detection(i, 1, words, meaningDT);
                                    if (nounMeaning == "")
                                    {
                                        nounMeaning = words[i + 1];
                                    }
                                    prepositionlaAmbiguitySolution += nounMeaning + " এর বিপক্ষে";
                                }
                                break;

                            case "case2":
                                prepositionlaAmbiguitySolution += " " + aTransferAndGeneration_stg.IdetifyObjects_NotRelatedWith_Preposition(PStructure_start, PStructure_end, words, meaningDT, subject, verb);
                                nounMeaning = nounMeaning_Detection(i, 2, words, meaningDT);
                                if (words[i + 1] == "a" || words[i + 1] == "an")
                                {
                                    prepositionlaAmbiguitySolution += "একটি " + nounMeaning + " এর বিপক্ষে ";
                                }
                                else
                                {
                                    prepositionlaAmbiguitySolution += nounMeaning + " টির বিপক্ষে ";
                                }
                                break;

                            case "case7":
                                prepositionlaAmbiguitySolution += " " + aTransferAndGeneration_stg.IdetifyObjects_NotRelatedWith_Preposition(PStructure_start, PStructure_end, words, meaningDT, subject, verb);
                                nounMeaning = nounMeaning_Detection(i, 2, words, meaningDT);
                                if (words[i + 1] == "his")
                                {
                                    pronounMeaning = " তার ";
                                }
                                else if (words[i + 1] == "her")
                                {
                                    pronounMeaning = " তার ";
                                }
                                else if (words[i + 1] == "their")
                                {
                                    pronounMeaning = " তাদের ";
                                }
                                else if (words[i + 1] == "your")
                                {
                                    pronounMeaning = " তোমার ";
                                }
                                else if (words[i + 1] == "our")
                                {
                                    pronounMeaning = " আমাদের ";
                                }
                                else if (words[i + 1] == "my")
                                {
                                    pronounMeaning = " আমার";
                                }
                                prepositionlaAmbiguitySolution = pronounMeaning + nounMeaning + " এর বিপক্ষে ";
                                break;
                            case "case15":
                                prepositionlaAmbiguitySolution += " " + aTransferAndGeneration_stg.IdetifyObjects_NotRelatedWith_Preposition(PStructure_start, PStructure_end, words, meaningDT, subject, verb);
                                if (words[i + 1] == "him")
                                {
                                    nounMeaning = " তাকে ";
                                    nounMeaning += nounMeaning_Detection(i, 1, words, meaningDT);
                                    prepositionlaAmbiguitySolution += nounMeaning + "র বিপক্ষে ";
                                }
                                else if (words[i + 1] == "her")
                                {
                                    nounMeaning = " তাকে ";
                                    nounMeaning += nounMeaning_Detection(i, 1, words, meaningDT);
                                    prepositionlaAmbiguitySolution += nounMeaning + "র বিপক্ষে ";
                                }
                                else if (words[i + 1] == "them")
                                {
                                    nounMeaning = " তাকে ";
                                    nounMeaning += nounMeaning_Detection(i, 1, words, meaningDT);
                                    prepositionlaAmbiguitySolution += nounMeaning + "র বিপক্ষে ";
                                }
                                else if (words[i + 1] == "you")
                                {
                                    nounMeaning = " তোমাকে ";
                                    nounMeaning += nounMeaning_Detection(i, 1, words, meaningDT);
                                    prepositionlaAmbiguitySolution += nounMeaning + "র বিপক্ষে ";
                                }
                                else if (words[i + 1] == "us")
                                {
                                    nounMeaning = " আমাদেরকে ";
                                    nounMeaning += nounMeaning_Detection(i, 1, words, meaningDT);
                                    prepositionlaAmbiguitySolution += nounMeaning + "র বিপক্ষে ";
                                }
                                else if (words[i + 1] == "me")
                                {
                                    prepositionlaAmbiguitySolution = " আমাকে ";
                                    nounMeaning += nounMeaning_Detection(i, 1, words, meaningDT);
                                    prepositionlaAmbiguitySolution += nounMeaning + "র বিপক্ষে ";
                                }
                                else
                                {
                                    nounMeaning = nounMeaning_Detection(i, 2, words, meaningDT);
                                    nounMeaning += nounMeaning + " কে ";
                                    nounMeaning += nounMeaning_Detection(i, 1, words, meaningDT);
                                    prepositionlaAmbiguitySolution += nounMeaning + "র বিপক্ষে ";
                                }
                                break;

                        }
                    }
                    else if (words[i] == "amog")
                    {
                        structure = idntifyPrepositional_Structure(words, i, postags);
                        switch (structure)
                        {
                            case "case1":
                                prepositionlaAmbiguitySolution += " " + aTransferAndGeneration_stg.IdetifyObjects_NotRelatedWith_Preposition(PStructure_start, PStructure_end, words, meaningDT, subject, verb);
                                if (words[i + 1] == "him")
                                {
                                    prepositionlaAmbiguitySolution += " তার মাঝে ";
                                }
                                else if (words[i + 1] == "her")
                                {
                                    prepositionlaAmbiguitySolution += " তার মাঝে ";
                                }
                                else if (words[i + 1] == "them")
                                {
                                    prepositionlaAmbiguitySolution += " তাদের মাঝে ";
                                }
                                else if (words[i + 1] == "you")
                                {
                                    prepositionlaAmbiguitySolution += " তোমার মাঝে ";
                                }
                                else if (words[i + 1] == "us")
                                {
                                    prepositionlaAmbiguitySolution += " আমাদের মাঝে ";
                                }
                                else if (words[i + 1] == "me")
                                {
                                    prepositionlaAmbiguitySolution += " আমার মাঝে ";
                                }
                                else
                                {
                                    nounMeaning = nounMeaning_Detection(i, 1, words, meaningDT);
                                    if (nounMeaning == "")
                                    {
                                        nounMeaning = words[i + 1];
                                    }
                                    prepositionlaAmbiguitySolution += nounMeaning + " এর মধ্যে ";
                                }
                                break;

                            case "case2":
                                prepositionlaAmbiguitySolution += " " + aTransferAndGeneration_stg.IdetifyObjects_NotRelatedWith_Preposition(PStructure_start, PStructure_end, words, meaningDT, subject, verb);
                                nounMeaning = nounMeaning_Detection(i, 2, words, meaningDT);
                                if (words[i + 1] == "a" || words[i + 1] == "an")
                                {
                                    prepositionlaAmbiguitySolution += " একটি " + nounMeaning + " এর মধ্যে ";
                                }
                                else
                                {
                                    prepositionlaAmbiguitySolution += nounMeaning + " গুলোর মাঝে ";
                                }
                                break;

                            case "case7":
                                prepositionlaAmbiguitySolution += " " + aTransferAndGeneration_stg.IdetifyObjects_NotRelatedWith_Preposition(PStructure_start, PStructure_end, words, meaningDT, subject, verb);
                                nounMeaning = nounMeaning_Detection(i, 2, words, meaningDT);
                                if (words[i + 1] == "his")
                                {
                                    pronounMeaning = " তার ";
                                }
                                else if (words[i + 1] == "her")
                                {
                                    pronounMeaning = " তার ";
                                }
                                else if (words[i + 1] == "their")
                                {
                                    pronounMeaning = " তাদের ";
                                }
                                else if (words[i + 1] == "your")
                                {
                                    pronounMeaning = " তোমার ";
                                }
                                else if (words[i + 1] == "our")
                                {
                                    pronounMeaning = " আমাদের ";
                                }
                                else if (words[i + 1] == "my")
                                {
                                    pronounMeaning = " আমার";
                                }
                                prepositionlaAmbiguitySolution += pronounMeaning + nounMeaning + " গুলোর মধ্যে ";
                                break;

                        }
                    }
                    else if (words[i] == "except")
                    {
                        structure = idntifyPrepositional_Structure(words, i, postags);
                        switch (structure)
                        {
                            case "case1":
                                prepositionlaAmbiguitySolution += " " + aTransferAndGeneration_stg.IdetifyObjects_NotRelatedWith_Preposition(PStructure_start, PStructure_end, words, meaningDT, subject, verb);
                                if (words[i + 1] == "him")
                                {
                                    prepositionlaAmbiguitySolution += " সে ব্যতীত ";
                                }
                                else if (words[i + 1] == "her")
                                {
                                    prepositionlaAmbiguitySolution += " সে ব্যতীত ";
                                }
                                else if (words[i + 1] == "them")
                                {
                                    prepositionlaAmbiguitySolution += " তারা ব্যতীত ";
                                }
                                else if (words[i + 1] == "you")
                                {
                                    prepositionlaAmbiguitySolution += " তুমি ব্যতীত ";
                                }
                                else if (words[i + 1] == "us")
                                {
                                    prepositionlaAmbiguitySolution += " আমরা ব্যতীত";
                                }
                                else if (words[i + 1] == "me")
                                {
                                    prepositionlaAmbiguitySolution += " আমি ব্যতীত";
                                }
                                else if (words[i + 1] == "mine")
                                {
                                    prepositionlaAmbiguitySolution += " আমার টা ব্যতীত ";
                                }
                                else
                                {
                                    nounMeaning = nounMeaning_Detection(i, 1, words, meaningDT);
                                    if (nounMeaning == "")
                                    {
                                        nounMeaning = words[i + 1];
                                    }
                                    prepositionlaAmbiguitySolution += nounMeaning + " ব্যতীত ";
                                }
                                break;
                            case "case7":
                                prepositionlaAmbiguitySolution += " " + aTransferAndGeneration_stg.IdetifyObjects_NotRelatedWith_Preposition(PStructure_start, PStructure_end, words, meaningDT, subject, verb);
                                nounMeaning = nounMeaning_Detection(i, 2, words, meaningDT);
                                if (words[i + 1] == "his")
                                {
                                    pronounMeaning = " তার ";
                                }
                                else if (words[i + 1] == "her")
                                {
                                    pronounMeaning = " তার ";
                                }
                                else if (words[i + 1] == "their")
                                {
                                    pronounMeaning = " তাদের ";
                                }
                                else if (words[i + 1] == "your")
                                {
                                    pronounMeaning = " তোমার ";
                                }
                                else if (words[i + 1] == "our")
                                {
                                    pronounMeaning = " আমাদের ";
                                }
                                else if (words[i + 1] == "my")
                                {
                                    pronounMeaning = " আমার ";
                                }
                                prepositionlaAmbiguitySolution += pronounMeaning + nounMeaning + " ছাড়া ";
                                break;
                            case "case16":
                                prepositionlaAmbiguitySolution += " " + aTransferAndGeneration_stg.IdetifyObjects_NotRelatedWith_Preposition(PStructure_start, PStructure_end, words, meaningDT, subject, verb);
                                nounMeaning = nounMeaning_Detection(i, 3, words, meaningDT);
                                if (words[i + 1] == "his")
                                {
                                    pronounMeaning = " তার ";
                                }
                                else if (words[i + 1] == "her")
                                {
                                    pronounMeaning = " তার ";
                                }
                                else if (words[i + 1] == "their")
                                {
                                    pronounMeaning = " তাদের ";
                                }
                                else if (words[i + 1] == "your")
                                {
                                    pronounMeaning = " তোমার ";
                                }
                                else if (words[i + 1] == "our")
                                {
                                    pronounMeaning = " আমাদের ";
                                }
                                else if (words[i + 1] == "my")
                                {
                                    pronounMeaning = " আমার ";
                                }
                                prepositionlaAmbiguitySolution += pronounMeaning + nounMeaning + " ছাড়া ";
                                break;
                            case "case19":
                                prepositionlaAmbiguitySolution += " " + aTransferAndGeneration_stg.IdetifyObjects_NotRelatedWith_Preposition(PStructure_start, PStructure_end, words, meaningDT, subject, verb);
                                dayMeaning = dayMeaning_Detection(i, 1, words, meaningDT);
                                prepositionlaAmbiguitySolution += dayMeaning + " ছাড়া ";
                                break;

                        }
                    }
                    else if (words[i] == "inside")
                    {
                        structure = idntifyPrepositional_Structure(words, i, postags);
                        switch (structure)
                        {
                            case "case1":
                                prepositionlaAmbiguitySolution += " " + aTransferAndGeneration_stg.IdetifyObjects_NotRelatedWith_Preposition(PStructure_start, PStructure_end, words, meaningDT, subject, verb);
                                if (words[i + 1] == "him")
                                {
                                    prepositionlaAmbiguitySolution += " তার ভেতর ";
                                }
                                else if (words[i + 1] == "her")
                                {
                                    prepositionlaAmbiguitySolution += " তার ভেতর ";
                                }
                                else if (words[i + 1] == "them")
                                {
                                    prepositionlaAmbiguitySolution += " তাদের ভেতর ";
                                }
                                else if (words[i + 1] == "you")
                                {
                                    prepositionlaAmbiguitySolution += " তোমার ভেতর ";
                                }
                                else if (words[i + 1] == "us")
                                {
                                    prepositionlaAmbiguitySolution += " আমাদের ভেতর ";
                                }
                                else if (words[i + 1] == "me")
                                {
                                    prepositionlaAmbiguitySolution += " আমার ভেতর ";
                                }
                                else if (words[i + 1] == "mine")
                                {
                                    prepositionlaAmbiguitySolution += " আমারটার ভেতর ";
                                }
                                else
                                {
                                    nounMeaning = nounMeaning_Detection(i, 1, words, meaningDT);
                                    if (nounMeaning == "")
                                    {
                                        nounMeaning = words[i + 1];
                                    }
                                    prepositionlaAmbiguitySolution += nounMeaning + " এর ভেতর ";
                                }
                                break;
                            case "case2":
                                prepositionlaAmbiguitySolution += " " + aTransferAndGeneration_stg.IdetifyObjects_NotRelatedWith_Preposition(PStructure_start, PStructure_end, words, meaningDT, subject, verb);
                                nounMeaning = nounMeaning_Detection(i, 2, words, meaningDT);
                                if (words[i + 1] == "a" || words[i + 1] == "an")
                                {
                                    prepositionlaAmbiguitySolution += " একটি " + nounMeaning + " এর ভেতর ";
                                }
                                else
                                {
                                    prepositionlaAmbiguitySolution += nounMeaning + " এর ভেতর ";
                                }
                                break;
                            case "case12":
                                prepositionlaAmbiguitySolution += " " + aTransferAndGeneration_stg.IdetifyObjects_NotRelatedWith_Preposition(PStructure_start, PStructure_end, words, meaningDT, subject, verb);
                                nounMeaning = nounMeaning_Detection(i, 2, words, meaningDT);
                                if (int.Parse(words[i + 1]) > 0)
                                {
                                    prepositionlaAmbiguitySolution += words[i + 1] + nounMeaning + " এর ভেতর ";
                                }
                                else if (words[i + 1] == "a")
                                {
                                    prepositionlaAmbiguitySolution += "এক" + nounMeaning + "এর ভেতর ";
                                }
                                else
                                {
                                    string numberMeaning = "";
                                    numberMeaning = nounMeaning_Detection(i, 1, words, meaningDT);
                                    prepositionlaAmbiguitySolution += numberMeaning + nounMeaning + "এর ভেতর ";
                                }
                                break;
                            case "case35":
                                prepositionlaAmbiguitySolution += " " + aTransferAndGeneration_stg.IdetifyObjects_NotRelatedWith_Preposition(PStructure_start, PStructure_end, words, meaningDT, subject, verb);
                                if (words[i + 1] == "most")
                                {
                                    nounMeaning = " অধিকাংশ ";
                                }
                                else if (words[i + 1] == "more")
                                {
                                    nounMeaning = " আরো ";
                                }
                                nounMeaning += nounMeaning_Detection(i, 2, words, meaningDT);
                                prepositionlaAmbiguitySolution += nounMeaning + " এর ভেতর ";
                                break;
                        }
                    }
                    else if (words[i] == "like")

                    {
                        structure = idntifyPrepositional_Structure(words, i, postags);
                        switch (structure)
                        {
                            case "case1":
                                if (words[i + 1] == "him")
                                {
                                    prepositionlaAmbiguitySolution = "তার মতন ";
                                }
                                else if (words[i + 1] == "her")
                                {
                                    prepositionlaAmbiguitySolution = "তার মতন ";
                                }
                                else if (words[i + 1] == "them")
                                {
                                    prepositionlaAmbiguitySolution = "তাদের মতন ";
                                }
                                else if (words[i + 1] == "you")
                                {
                                    prepositionlaAmbiguitySolution = "তোমার মতন ";
                                }
                                else if (words[i + 1] == "us")
                                {
                                    prepositionlaAmbiguitySolution = "আমাদের মতন ";
                                }
                                else if (words[i + 1] == "me")
                                {
                                    prepositionlaAmbiguitySolution = "আমার মতন ";
                                }
                                else
                                {
                                    nounMeaning = nounMeaning_Detection(i, 1, words, meaningDT);
                                    if (nounMeaning == "")
                                    {
                                        nounMeaning = words[i + 1];
                                    }
                                    prepositionlaAmbiguitySolution = nounMeaning + "এর মতন ";
                                }
                                break;

                            case "case2":
                                nounMeaning = nounMeaning_Detection(i, 2, words, meaningDT);
                                if (words[i + 1] == "a" || words[i + 1] == "an")
                                {
                                    prepositionlaAmbiguitySolution += "একটি" + nounMeaning + "এর মতন ";
                                }
                                else
                                {
                                    prepositionlaAmbiguitySolution += nounMeaning + "টির মতন ";
                                }
                                break;
                            case "case5":
                                if (words[i + 1] == "this")
                                {
                                    nounMeaning = " এরকম ";
                                }
                                else if (words[i + 1] == "that")
                                {
                                    nounMeaning = "ঐরকম ";
                                }
                                else if (words[i + 1] == "these")
                                {
                                    nounMeaning = " এগুলোর মতন ";
                                }
                                else if (words[i + 1] == "it")
                                {
                                    nounMeaning = " এর মতন ";
                                }
                                else
                                {
                                    nounMeaning = "ঐগুলোর মতন ";
                                }
                                break;
                            case "case7":
                                nounMeaning = nounMeaning_Detection(i, 2, words, meaningDT);
                                if (words[i + 1] == "his")
                                {
                                    pronounMeaning = "তার";
                                }
                                else if (words[i + 1] == "her")
                                {
                                    pronounMeaning = "তার";
                                }
                                else if (words[i + 1] == "their")
                                {
                                    pronounMeaning = "তাদের";
                                }
                                else if (words[i + 1] == "your")
                                {
                                    pronounMeaning = "তোমার";
                                }
                                else if (words[i + 1] == "our")
                                {
                                    pronounMeaning = "আমাদের";
                                }
                                else if (words[i + 1] == "my")
                                {
                                    pronounMeaning = "আমার";
                                }
                                prepositionlaAmbiguitySolution += pronounMeaning + nounMeaning + "এর মতন ";
                                break;
                            case "case24":
                                if (words[i + 1] == "this")
                                {
                                    nounMeaning = "এই ";
                                    nounMeaning += nounMeaning_Detection(i, 2, words, meaningDT);
                                }
                                else if (words[i + 1] == "that")
                                {
                                    nounMeaning = "ঐ ";
                                    nounMeaning += nounMeaning_Detection(i, 2, words, meaningDT);
                                }
                                else if (words[i + 1] == "thsese")
                                {
                                    nounMeaning = "এই ";
                                    nounMeaning += nounMeaning_Detection(i, 2, words, meaningDT);
                                    nounMeaning += " গুলো ";
                                }
                                else
                                {
                                    nounMeaning = "ঐ";
                                    nounMeaning += nounMeaning_Detection(i, 2, words, meaningDT);
                                    nounMeaning += " গুলো ";
                                }
                                prepositionlaAmbiguitySolution += nounMeaning + "এর মতন ";
                                break;

                        }
                    }
                    else if (words[i] == "outside")
                    {
                        structure = idntifyPrepositional_Structure(words, i, postags);
                        switch (structure)
                        {
                            case "case58":
                                prepositionlaAmbiguitySolution += " " + aTransferAndGeneration_stg.IdetifyObjects_NotRelatedWith_Preposition(PStructure_start, PStructure_end, words, meaningDT, subject, verb);
                                if (words[i + 1] == "a" || words[i + 1] == "an")
                                {
                                    nounMeaning = " একটি ";
                                    nounMeaning += nounMeaning_Detection(i, 4, words, meaningDT);
                                    nounMeaning += " এর ";
                                }
                                else if (words[i + 1] == "the")
                                {
                                    nounMeaning = nounMeaning_Detection(i, 4, words, meaningDT);
                                    nounMeaning += " টির ";
                                }
                                else if (words[i + 1] == "this")
                                {
                                    nounMeaning = " এই ";
                                    nounMeaning += nounMeaning_Detection(i, 4, words, meaningDT);
                                    nounMeaning += " টির ";
                                }
                                else if (words[i + 1] == "that")
                                {
                                    nounMeaning = " ঐ ";
                                    nounMeaning += nounMeaning_Detection(i, 4, words, meaningDT);
                                    nounMeaning += " টির ";
                                }
                                prepositionlaAmbiguitySolution += nounMeaning + " বাইরে ";
                                break;
                        }
                    }
                    else if (words[i] == "around")

                    {
                        structure = idntifyPrepositional_Structure(words, i, postags);
                        switch (structure)
                        {
                            case "case1":
                                prepositionlaAmbiguitySolution += " " + aTransferAndGeneration_stg.IdetifyObjects_NotRelatedWith_Preposition(PStructure_start, PStructure_end, words, meaningDT, subject, verb);
                                if (words[i + 1] == "him")
                                {
                                    prepositionlaAmbiguitySolution += " তার আশেপাশে ";
                                }
                                else if (words[i + 1] == "her")
                                {
                                    prepositionlaAmbiguitySolution += " তার আশেপাশে ";
                                }
                                else if (words[i + 1] == "them")
                                {
                                    prepositionlaAmbiguitySolution += " তাদের আশেপাশে ";
                                }
                                else if (words[i + 1] == "you")
                                {
                                    prepositionlaAmbiguitySolution += " তোমার আশেপাশে ";
                                }
                                else if (words[i + 1] == "us")
                                {
                                    prepositionlaAmbiguitySolution += " আমাদের আশেপাশে ";
                                }
                                else if (words[i + 1] == "me")
                                {
                                    prepositionlaAmbiguitySolution += " আমার আশেপাশে ";
                                }
                                else
                                {
                                    nounMeaning = nounMeaning_Detection(i, 1, words, meaningDT);
                                    if (nounMeaning == "")
                                    {
                                        nounMeaning = words[i + 1];
                                    }
                                    prepositionlaAmbiguitySolution += nounMeaning + " এর আশেপাশে ";
                                }
                                break;

                            case "case14":
                                prepositionlaAmbiguitySolution += " " + aTransferAndGeneration_stg.IdetifyObjects_NotRelatedWith_Preposition(PStructure_start, PStructure_end, words, meaningDT, subject, verb);
                                prepositionlaAmbiguitySolution += words[i + 1] + " এর আশেপাশে ";
                                break;
                        }
                    }
                    else if (words[i] == "onto")
                    {
                        structure = idntifyPrepositional_Structure(words, i, postags);
                        switch (structure)
                        {

                            case "case2":
                                prepositionlaAmbiguitySolution += " " + aTransferAndGeneration_stg.IdetifyObjects_NotRelatedWith_Preposition(PStructure_start, PStructure_end, words, meaningDT, subject, verb);
                                nounMeaning = nounMeaning_Detection(i, 2, words, meaningDT);
                                if (words[i + 1] == "a" || words[i + 1] == "an")
                                {
                                    prepositionlaAmbiguitySolution += " একটি " + nounMeaning + " এর উপর ";
                                }
                                else
                                {
                                    prepositionlaAmbiguitySolution += nounMeaning + " টির উপর ";
                                }
                                break;
                        }
                    }
                    else if (words[i] == "as")
                    {
                        structure = idntifyPrepositional_Structure(words, i, postags);
                        switch (structure)
                        {
                            case "case1":
                                prepositionlaAmbiguitySolution += " " + aTransferAndGeneration_stg.IdetifyObjects_NotRelatedWith_Preposition(PStructure_start, PStructure_end, words, meaningDT, subject, verb);
                                if (words[i + 1] == "him")
                                {
                                    prepositionlaAmbiguitySolution += " তার মতন ";
                                }
                                else if (words[i + 1] == "her")
                                {
                                    prepositionlaAmbiguitySolution += " তার মতন ";
                                }
                                else if (words[i + 1] == "them")
                                {
                                    prepositionlaAmbiguitySolution += " তাদের মতন ";
                                }
                                else if (words[i + 1] == "you")
                                {
                                    prepositionlaAmbiguitySolution += " তোমার মতন ";
                                }
                                else if (words[i + 1] == "us")
                                {
                                    prepositionlaAmbiguitySolution += " আমাদের মতন ";
                                }
                                else if (words[i + 1] == "me")
                                {
                                    prepositionlaAmbiguitySolution += " আমার মতন ";
                                }
                                else
                                {
                                    nounMeaning = nounMeaning_Detection(i, 1, words, meaningDT);
                                    if (nounMeaning == "")
                                    {
                                        nounMeaning = words[i + 1];
                                    }
                                    prepositionlaAmbiguitySolution += nounMeaning + " এর মতন ";
                                }
                                break;

                            case "case2":
                                prepositionlaAmbiguitySolution += " " + aTransferAndGeneration_stg.IdetifyObjects_NotRelatedWith_Preposition(PStructure_start, PStructure_end, words, meaningDT, subject, verb);
                                nounMeaning = nounMeaning_Detection(i, 2, words, meaningDT);
                                if (words[i + 1] == "a" || words[i + 1] == "an")
                                {
                                    prepositionlaAmbiguitySolution += " একটি " + nounMeaning + " এর মতন ";
                                }
                                else
                                {
                                    prepositionlaAmbiguitySolution += nounMeaning + " টির মতন";
                                }
                                break;
                        }
                    }
                    else if (words[i] == "before")

                    {
                        structure = idntifyPrepositional_Structure(words, i, postags);
                        switch (structure)
                        {
                            case "case1":
                                prepositionlaAmbiguitySolution += " " + aTransferAndGeneration_stg.IdetifyObjects_NotRelatedWith_Preposition(PStructure_start, PStructure_end, words, meaningDT, subject, verb);
                                if (words[i + 1] == "him")
                                {
                                    prepositionlaAmbiguitySolution += " তার আগে ";
                                }
                                else if (words[i + 1] == "her")
                                {
                                    prepositionlaAmbiguitySolution += " তার আগে ";
                                }
                                else if (words[i + 1] == "them")
                                {
                                    prepositionlaAmbiguitySolution += " তাদের আগে ";
                                }
                                else if (words[i + 1] == "you")
                                {
                                    prepositionlaAmbiguitySolution += " তোমার আগে ";
                                }
                                else if (words[i + 1] == "us")
                                {
                                    prepositionlaAmbiguitySolution += " আমাদের আগে ";
                                }
                                else if (words[i + 1] == "me")
                                {
                                    prepositionlaAmbiguitySolution += " আমার আগে ";
                                }
                                else
                                {
                                    nounMeaning = nounMeaning_Detection(i, 1, words, meaningDT);
                                    if (nounMeaning == "")
                                    {
                                        nounMeaning = words[i + 1];
                                    }
                                    prepositionlaAmbiguitySolution += nounMeaning + " এর আগে ";
                                }
                                break;

                            case "case2":
                                prepositionlaAmbiguitySolution += " " + aTransferAndGeneration_stg.IdetifyObjects_NotRelatedWith_Preposition(PStructure_start, PStructure_end, words, meaningDT, subject, verb);
                                nounMeaning = nounMeaning_Detection(i, 2, words, meaningDT);
                                if (words[i + 1] == "a" || words[i + 1] == "an")
                                {
                                    prepositionlaAmbiguitySolution += " একটি " + nounMeaning + " এর আগে ";
                                }
                                else
                                {
                                    prepositionlaAmbiguitySolution += nounMeaning + " টির আগে ";
                                }
                                break;

                            case "case7":
                                prepositionlaAmbiguitySolution += " " + aTransferAndGeneration_stg.IdetifyObjects_NotRelatedWith_Preposition(PStructure_start, PStructure_end, words, meaningDT, subject, verb);
                                nounMeaning = nounMeaning_Detection(i, 2, words, meaningDT);
                                if (words[i + 1] == "his")
                                {
                                    pronounMeaning = " তার ";
                                }
                                else if (words[i + 1] == "her")
                                {
                                    pronounMeaning = " তার ";
                                }
                                else if (words[i + 1] == "their")
                                {
                                    pronounMeaning = " তাদের ";
                                }
                                else if (words[i + 1] == "your")
                                {
                                    pronounMeaning = " তোমার ";
                                }
                                else if (words[i + 1] == "our")
                                {
                                    pronounMeaning = " আমাদের ";
                                }
                                else if (words[i + 1] == "my")
                                {
                                    pronounMeaning = " আমার ";
                                }
                                prepositionlaAmbiguitySolution += pronounMeaning + nounMeaning + " এর আগে ";
                                break;
                            case "case55":
                                prepositionlaAmbiguitySolution += " " + aTransferAndGeneration_stg.IdetifyObjects_NotRelatedWith_Preposition(PStructure_start, PStructure_end, words, meaningDT, subject, verb);
                                if (words[i + 1] == "tomorrow")
                                {
                                    nounMeaning = "আগামীকালের আগে ";
                                }
                                else if (words[i + 1] == "yesterday")
                                {
                                    nounMeaning = "গতকালের আগে ";
                                }
                                else if (words[i + 1] == "today")
                                {
                                    nounMeaning = "আজকের আগে ";
                                }
                                else if (words[i + 1] == "now")
                                {
                                    nounMeaning = "এর আগে ";
                                }
                                prepositionlaAmbiguitySolution += nounMeaning;
                                break;

                            case "case59":
                                prepositionlaAmbiguitySolution += " " + aTransferAndGeneration_stg.IdetifyObjects_NotRelatedWith_Preposition(PStructure_start, PStructure_end, words, meaningDT, subject, verb);
                                if (words[i + 1] == "anything")
                                {
                                    nounMeaning = " যে কোনো কিছুর সামনে ";
                                }
                                else if (words[i + 1] == "everything")
                                {
                                    nounMeaning = " সব কিছুর সামনে ";
                                }
                                else if (words[i + 1] == "nothing")
                                {
                                    nounMeaning = " কোনো কিছুর উপরই না ";
                                }
                                prepositionlaAmbiguitySolution += nounMeaning;
                                break;
                        }
                    }
                    else if (words[i] == "behind")
                    {
                        structure = idntifyPrepositional_Structure(words, i, postags);
                        switch (structure)
                        {
                            case "case1":
                                if (words[i + 1] == "him")
                                {
                                    prepositionlaAmbiguitySolution = "তার পেছনে ";
                                }
                                else if (words[i + 1] == "her")
                                {
                                    prepositionlaAmbiguitySolution = "তার পেছনে ";
                                }
                                else if (words[i + 1] == "them")
                                {
                                    prepositionlaAmbiguitySolution = "তাদের পেছনে ";
                                }
                                else if (words[i + 1] == "you")
                                {
                                    prepositionlaAmbiguitySolution = "তোমার পেছনে ";
                                }
                                else if (words[i + 1] == "us")
                                {
                                    prepositionlaAmbiguitySolution = "আমাদের পেছনে ";
                                }
                                else if (words[i + 1] == "me")
                                {
                                    prepositionlaAmbiguitySolution = "আমার পেছনে ";
                                }
                                else
                                {
                                    nounMeaning = nounMeaning_Detection(i, 1, words, meaningDT);
                                    if (nounMeaning == "")
                                    {
                                        nounMeaning = words[i + 1];
                                    }
                                    prepositionlaAmbiguitySolution = nounMeaning + "এর পেছনে ";
                                }
                                break;
                            case "case2":
                                nounMeaning = nounMeaning_Detection(i, 2, words, meaningDT);
                                if (words[i + 1] == "a" || words[i + 1] == "an")
                                {
                                    prepositionlaAmbiguitySolution += "একটি" + nounMeaning + "এর পেছনে ";
                                }
                                else
                                {
                                    prepositionlaAmbiguitySolution += nounMeaning + "এর পেছনে ";
                                }
                                break;
                        }
                    }
                    else if (words[i] == "beside" || words[i] == "besides")
                    {
                        structure = idntifyPrepositional_Structure(words, i, postags);
                        switch (structure)
                        {
                            case "case1":
                                prepositionlaAmbiguitySolution += " " + aTransferAndGeneration_stg.IdetifyObjects_NotRelatedWith_Preposition(PStructure_start, PStructure_end, words, meaningDT, subject, verb);
                                if (words[i + 1] == "him")
                                {
                                    prepositionlaAmbiguitySolution += " তার পাশে ";
                                }
                                else if (words[i + 1] == "her")
                                {
                                    prepositionlaAmbiguitySolution += " তার পাশে ";
                                }
                                else if (words[i + 1] == "them")
                                {
                                    prepositionlaAmbiguitySolution += " তাদের পাশে ";
                                }
                                else if (words[i + 1] == "you")
                                {
                                    prepositionlaAmbiguitySolution += " তোমার পাশে ";
                                }
                                else if (words[i + 1] == "us")
                                {
                                    prepositionlaAmbiguitySolution += " আমাদের পাশে ";
                                }
                                else if (words[i + 1] == "me")
                                {
                                    prepositionlaAmbiguitySolution += " আমার পাশে ";
                                }
                                else
                                {
                                    nounMeaning = nounMeaning_Detection(i, 1, words, meaningDT);
                                    if (nounMeaning == "")
                                    {
                                        nounMeaning = words[i + 1];
                                    }
                                    prepositionlaAmbiguitySolution += nounMeaning + " এর পাশে ";
                                }
                                break;

                            case "case2":
                                prepositionlaAmbiguitySolution += " " + aTransferAndGeneration_stg.IdetifyObjects_NotRelatedWith_Preposition(PStructure_start, PStructure_end, words, meaningDT, subject, verb);
                                nounMeaning = nounMeaning_Detection(i, 2, words, meaningDT);
                                if (words[i + 1] == "a" || words[i + 1] == "an")
                                {
                                    prepositionlaAmbiguitySolution += " একটি " + nounMeaning + " এর পাশে ";
                                }
                                else
                                {
                                    prepositionlaAmbiguitySolution += nounMeaning + " এর পাশে ";
                                }
                                break;
                            case "case25":
                                prepositionlaAmbiguitySolution += " " + aTransferAndGeneration_stg.IdetifyObjects_NotRelatedWith_Preposition(PStructure_start, PStructure_end, words, meaningDT, subject, verb);
                                if (words[i + 1] == "theirs")
                                {
                                    pronounMeaning = " তাদের ";
                                }
                                else if (words[i + 1] == "ours")
                                {
                                    pronounMeaning = " আমাদের ";
                                }
                                else if (words[i + 1] == "yours")
                                {
                                    pronounMeaning = " তোমার ";
                                }
                                prepositionlaAmbiguitySolution += pronounMeaning + " টার পাশে ";
                                break;
                        }
                    }
                    else if (words[i] == "between")
                    {
                        structure = idntifyPrepositional_Structure(words, i, postags);
                        switch (structure)
                        {
                            case "case1":
                                prepositionlaAmbiguitySolution += " " + aTransferAndGeneration_stg.IdetifyObjects_NotRelatedWith_Preposition(PStructure_start, PStructure_end, words, meaningDT, subject, verb);
                                if (words[i + 1] == "him")
                                {
                                    prepositionlaAmbiguitySolution += " তার মধ্যে ";
                                }
                                else if (words[i + 1] == "her")
                                {
                                    prepositionlaAmbiguitySolution += " তার মধ্যে ";
                                }
                                else if (words[i + 1] == "them")
                                {
                                    prepositionlaAmbiguitySolution += " তাদের মধ্যে ";
                                }
                                else if (words[i + 1] == "you")
                                {
                                    prepositionlaAmbiguitySolution += " তোমার মধ্যে ";
                                }
                                else if (words[i + 1] == "us")
                                {
                                    prepositionlaAmbiguitySolution += " আমাদের মধ্যে ";
                                }
                                else if (words[i + 1] == "me")
                                {
                                    prepositionlaAmbiguitySolution += " আমার মধ্যে ";
                                }
                                else
                                {
                                    nounMeaning = nounMeaning_Detection(i, 1, words, meaningDT);
                                    if (nounMeaning == "")
                                    {
                                        nounMeaning = words[i + 1];
                                    }
                                    prepositionlaAmbiguitySolution += nounMeaning + " এর মধ্যে ";
                                }
                                break;

                            case "case26":
                                prepositionlaAmbiguitySolution += " " + aTransferAndGeneration_stg.IdetifyObjects_NotRelatedWith_Preposition(PStructure_start, PStructure_end, words, meaningDT, subject, verb);
                                nounMeaning = nounMeaning_Detection(i, 1, words, meaningDT);
                                if (nounMeaning == "")
                                {
                                    nounMeaning = words[i + 1];
                                }
                                nounMeaning += " এবং ";
                                string nouMeaning2 = nounMeaning_Detection(i, 3, words, meaningDT);
                                if (nouMeaning2 == "")
                                {
                                    nouMeaning2 = words[i + 3];
                                }
                                prepositionlaAmbiguitySolution += nounMeaning + nouMeaning2 + " এর মধ্যে ";
                                break;
                            case "case27":
                                prepositionlaAmbiguitySolution += " " + aTransferAndGeneration_stg.IdetifyObjects_NotRelatedWith_Preposition(PStructure_start, PStructure_end, words, meaningDT, subject, verb);
                                nounMeaning = nounMeaning_Detection(i, 3, words, meaningDT);
                                if (nounMeaning == "")
                                {
                                    nounMeaning = words[i + 3];
                                }
                                nounMeaning += " এবং ";
                                string nouMeaning2nd = nounMeaning_Detection(i, 6, words, meaningDT);
                                if (nouMeaning2nd == "")
                                {
                                    nouMeaning2nd = words[i + 6];
                                }
                                prepositionlaAmbiguitySolution += nounMeaning + nouMeaning2nd + " এর মধ্যে ";
                                break;
                            case "case28":
                                prepositionlaAmbiguitySolution += " " + aTransferAndGeneration_stg.IdetifyObjects_NotRelatedWith_Preposition(PStructure_start, PStructure_end, words, meaningDT, subject, verb);
                                if (words[i + 1] is string)
                                {
                                    nounMeaning = nounMeaning_Detection(i, 2, words, meaningDT);
                                    prepositionlaAmbiguitySolution += nounMeaning + " এর মধ্যে ";
                                }
                                else
                                {
                                    prepositionlaAmbiguitySolution += words[i + 1] + " এর মধ্যে ";
                                }
                                break;
                        }
                    }
                    else if (words[i] == "concerning")
                    {
                        structure = idntifyPrepositional_Structure(words, i, postags);
                        switch (structure)
                        {
                            case "case1":
                                prepositionlaAmbiguitySolution += " " + aTransferAndGeneration_stg.IdetifyObjects_NotRelatedWith_Preposition(PStructure_start, PStructure_end, words, meaningDT, subject, verb);
                                if (words[i + 1] == "him")
                                {
                                    prepositionlaAmbiguitySolution += " তার সম্পর্কে ";
                                }
                                else if (words[i + 1] == "her")
                                {
                                    prepositionlaAmbiguitySolution += " তার সম্পর্কে ";
                                }
                                else if (words[i + 1] == "them")
                                {
                                    prepositionlaAmbiguitySolution += " তাদের সম্পর্কে ";
                                }
                                else if (words[i + 1] == "you")
                                {
                                    prepositionlaAmbiguitySolution += " তোমার পাশে ";
                                }
                                else if (words[i + 1] == "us")
                                {
                                    prepositionlaAmbiguitySolution += " আমাদের সম্পর্কে ";
                                }
                                else if (words[i + 1] == "me")
                                {
                                    prepositionlaAmbiguitySolution += " আমার সম্পর্কে ";
                                }
                                else
                                {
                                    nounMeaning = nounMeaning_Detection(i, 1, words, meaningDT);
                                    if (nounMeaning == "")
                                    {
                                        nounMeaning = words[i + 1];
                                    }
                                    prepositionlaAmbiguitySolution += nounMeaning + " এর বিষয়ে ";
                                }
                                break;
                            case "case61":
                                prepositionlaAmbiguitySolution += " " + aTransferAndGeneration_stg.IdetifyObjects_NotRelatedWith_Preposition(PStructure_start, PStructure_end, words, meaningDT, subject, verb);
                                nounMeaning = nounMeaning_Detection(i, 5, words, meaningDT);
                                if (nounMeaning == "")
                                {
                                    nounMeaning = words[i + 5];
                                }
                                nounMeaning += " এর ";
                                nounMeaning += nounMeaning_Detection(i, 2, words, meaningDT);
                                prepositionlaAmbiguitySolution += nounMeaning + " এর বিষয়ে ";
                                break;

                        }
                    }
                    else if (words[i] == "since")
                    {
                        structure = idntifyPrepositional_Structure(words, i, postags);
                        switch (structure)
                        {
                            case "case1":
                                prepositionlaAmbiguitySolution += " " + aTransferAndGeneration_stg.IdetifyObjects_NotRelatedWith_Preposition(PStructure_start, PStructure_end, words, meaningDT, subject, verb);
                                if (words[i + 1] == "him")
                                {
                                    prepositionlaAmbiguitySolution += " তার থেকে ";
                                }
                                else if (words[i + 1] == "her")
                                {
                                    prepositionlaAmbiguitySolution += " তার থেকে ";
                                }
                                else if (words[i + 1] == "them")
                                {
                                    prepositionlaAmbiguitySolution += " তাদের থেকে ";
                                }
                                else if (words[i + 1] == "you")
                                {
                                    prepositionlaAmbiguitySolution += " তোমার থেকে ";
                                }
                                else if (words[i + 1] == "us")
                                {
                                    prepositionlaAmbiguitySolution += " আমাদের থেকে ";
                                }
                                else if (words[i + 1] == "me")
                                {
                                    prepositionlaAmbiguitySolution += " আমার থেকে ";
                                }
                                else
                                {
                                    nounMeaning = nounMeaning_Detection(i, 1, words, meaningDT);
                                    if (nounMeaning == "")
                                    {
                                        nounMeaning = words[i + 1];
                                    }
                                    prepositionlaAmbiguitySolution += nounMeaning + " এর পর থেকে ";
                                }
                                break;
                            case "case2":
                                prepositionlaAmbiguitySolution += " " + aTransferAndGeneration_stg.IdetifyObjects_NotRelatedWith_Preposition(PStructure_start, PStructure_end, words, meaningDT, subject, verb);
                                nounMeaning = nounMeaning_Detection(i, 2, words, meaningDT);
                                if (words[i + 1] == "a" || words[i + 1] == "an")
                                {
                                    prepositionlaAmbiguitySolution += " একটি " + nounMeaning + " এর পর থেকে ";
                                }
                                else
                                {
                                    prepositionlaAmbiguitySolution += nounMeaning + " এর পর থেকে ";
                                }
                                break;
                            case "case14":
                                prepositionlaAmbiguitySolution += " " + aTransferAndGeneration_stg.IdetifyObjects_NotRelatedWith_Preposition(PStructure_start, PStructure_end, words, meaningDT, subject, verb);
                                if (words[i + 1] is string)
                                {
                                    nounMeaning = nounMeaning_Detection(i, 1, words, meaningDT);
                                    prepositionlaAmbiguitySolution += nounMeaning + " এর পর থেকে ";
                                }
                                else
                                {
                                    prepositionlaAmbiguitySolution += words[i + 1] + " এর পর থেকে ";
                                }

                                break;
                            case "case15":
                                prepositionlaAmbiguitySolution += " " + aTransferAndGeneration_stg.IdetifyObjects_NotRelatedWith_Preposition(PStructure_start, PStructure_end, words, meaningDT, subject, verb);
                                if (words[i + 1] == "him")
                                {
                                    nounMeaning = " তাকে ";
                                    nounMeaning += nounMeaning_Detection(i, 1, words, meaningDT);
                                    prepositionlaAmbiguitySolution += nounMeaning + " এর পর থেকে ";
                                }
                                else if (words[i + 1] == "her")
                                {
                                    nounMeaning = " তাকে ";
                                    nounMeaning += nounMeaning_Detection(i, 1, words, meaningDT);
                                    prepositionlaAmbiguitySolution += nounMeaning + " এর পর থেকে ";
                                }
                                else if (words[i + 1] == "them")
                                {
                                    nounMeaning = " তাকে ";
                                    nounMeaning += nounMeaning_Detection(i, 1, words, meaningDT);
                                    prepositionlaAmbiguitySolution += nounMeaning + " এর পর থেকে ";
                                }
                                else if (words[i + 1] == "you")
                                {
                                    nounMeaning = " তোমাকে ";
                                    nounMeaning += nounMeaning_Detection(i, 1, words, meaningDT);
                                    prepositionlaAmbiguitySolution += nounMeaning + " এর পর থেকে ";
                                }
                                else if (words[i + 1] == "us")
                                {
                                    nounMeaning = " আমাদেরকে ";
                                    nounMeaning += nounMeaning_Detection(i, 1, words, meaningDT);
                                    prepositionlaAmbiguitySolution += nounMeaning + " এর পর থেকে ";
                                }
                                else if (words[i + 1] == "me")
                                {
                                    prepositionlaAmbiguitySolution = " আমাকে ";
                                    nounMeaning += nounMeaning_Detection(i, 1, words, meaningDT);
                                    prepositionlaAmbiguitySolution += nounMeaning + " এর পর থেকে ";
                                }
                                else
                                {
                                    nounMeaning = nounMeaning_Detection(i, 2, words, meaningDT);
                                    if (nounMeaning == "")
                                    {
                                        nounMeaning = words[i + 1];
                                    }
                                    nounMeaning += nounMeaning + " কে ";
                                    nounMeaning += nounMeaning_Detection(i, 1, words, meaningDT);
                                    prepositionlaAmbiguitySolution += nounMeaning + " এর পর থেকে ";//
                                }
                                break;
                            case "case19":
                                prepositionlaAmbiguitySolution += " " + aTransferAndGeneration_stg.IdetifyObjects_NotRelatedWith_Preposition(PStructure_start, PStructure_end, words, meaningDT, subject, verb);
                                dayMeaning = dayMeaning_Detection(i, 1, words, meaningDT);
                                prepositionlaAmbiguitySolution += dayMeaning + " থেকে  ";
                                break;
                            case "case32":
                                prepositionlaAmbiguitySolution += " " + aTransferAndGeneration_stg.IdetifyObjects_NotRelatedWith_Preposition(PStructure_start, PStructure_end, words, meaningDT, subject, verb);
                                nounMeaning = nounMeaning_Detection(i, 1, words, meaningDT);
                                prepositionlaAmbiguitySolution += nounMeaning + " থেকে  ";//in summer
                                break;
                            case "case62":
                                prepositionlaAmbiguitySolution += " " + aTransferAndGeneration_stg.IdetifyObjects_NotRelatedWith_Preposition(PStructure_start, PStructure_end, words, meaningDT, subject, verb);
                                prepositionlaAmbiguitySolution = " তখন থেকে ";
                                break;
                        }
                    }
                    else if (words[i] == "than")
                    {
                        structure = idntifyPrepositional_Structure(words, i, postags);
                        switch (structure)
                        {
                            case "case1":
                                prepositionlaAmbiguitySolution += " " + aTransferAndGeneration_stg.IdetifyObjects_NotRelatedWith_Preposition(PStructure_start, PStructure_end, words, meaningDT, subject, verb);
                                if (words[i + 1] == "him")
                                {
                                    prepositionlaAmbiguitySolution += " তার থেকে ";
                                }
                                else if (words[i + 1] == "her")
                                {
                                    prepositionlaAmbiguitySolution += " তার থেকে ";
                                }
                                else if (words[i + 1] == "them")
                                {
                                    prepositionlaAmbiguitySolution += " তাদের থেকে ";
                                }
                                else if (words[i + 1] == "you")
                                {
                                    prepositionlaAmbiguitySolution += " তোমার থেকে ";
                                }
                                else if (words[i + 1] == "us")
                                {
                                    prepositionlaAmbiguitySolution += " আমাদের থেকে ";
                                }
                                else if (words[i + 1] == "me")
                                {
                                    prepositionlaAmbiguitySolution += " আমার থেকে ";
                                }
                                else
                                {
                                    nounMeaning = nounMeaning_Detection(i, 1, words, meaningDT);
                                    if (nounMeaning == "")
                                    {
                                        nounMeaning = words[i + 1];
                                    }
                                    prepositionlaAmbiguitySolution += nounMeaning + " এর থেকে ";
                                }
                                break;
                            case "case2":
                                prepositionlaAmbiguitySolution += " " + aTransferAndGeneration_stg.IdetifyObjects_NotRelatedWith_Preposition(PStructure_start, PStructure_end, words, meaningDT, subject, verb);
                                nounMeaning = nounMeaning_Detection(i, 2, words, meaningDT);
                                if (words[i + 1] == "a" || words[i + 1] == "an")
                                {
                                    prepositionlaAmbiguitySolution += " একটি " + nounMeaning + " এর থেকে ";
                                }
                                else
                                {
                                    prepositionlaAmbiguitySolution += nounMeaning + " টির থেকে ";
                                }
                                break;
                            case "case5":
                                prepositionlaAmbiguitySolution += " " + aTransferAndGeneration_stg.IdetifyObjects_NotRelatedWith_Preposition(PStructure_start, PStructure_end, words, meaningDT, subject, verb);
                                if (words[i + 1] == "this")
                                {
                                    nounMeaning = " এর থেকে ";
                                }
                                else if (words[i + 1] == "that")
                                {
                                    nounMeaning = " ঐটার থেকে ";
                                }
                                else if (words[i + 1] == "these")
                                {
                                    nounMeaning = " এগুলো থেকে ";
                                }
                                else if (words[i + 1] == "those")
                                {
                                    nounMeaning = " ঐগুলো থেকে";
                                }
                                else if (words[i + 1] == "it")
                                {
                                    nounMeaning = " এর থেকে ";
                                }
                                prepositionlaAmbiguitySolution += nounMeaning;
                                break;
                            case "case18":
                                prepositionlaAmbiguitySolution += " " + aTransferAndGeneration_stg.IdetifyObjects_NotRelatedWith_Preposition(PStructure_start, PStructure_end, words, meaningDT, subject, verb);
                                nounMeaning = nounMeaning_Detection(i, 2, words, meaningDT);
                                if (postags[i + 2] == "CD " || words[i + 2] == "a" || words[i + 2] == "an")
                                {
                                    if (words[i + 2] == "a" || words[i + 2] == "an")
                                    {
                                        nounMeaning = " এক " + nounMeaning;
                                    }
                                    else
                                    {
                                        nounMeaning = words[i + 2] + " টি " + nounMeaning;
                                    }

                                }
                                prepositionlaAmbiguitySolution += nounMeaning + " এর থেকে";
                                break;
                            case "case32":
                                prepositionlaAmbiguitySolution += " " + aTransferAndGeneration_stg.IdetifyObjects_NotRelatedWith_Preposition(PStructure_start, PStructure_end, words, meaningDT, subject, verb);
                                nounMeaning = nounMeaning_Detection(i, 1, words, meaningDT);
                                prepositionlaAmbiguitySolution += nounMeaning + " থেকে  ";//in summer
                                break;
                            case "case36":
                                prepositionlaAmbiguitySolution += " " + aTransferAndGeneration_stg.IdetifyObjects_NotRelatedWith_Preposition(PStructure_start, PStructure_end, words, meaningDT, subject, verb);
                                if (words[i + 1] == "any")
                                {
                                    nounMeaning = " অন্য যে কোনো ";
                                }
                                else if (words[i + 1] == "some")
                                {
                                    nounMeaning = " কিছু ";
                                }
                                else if (words[i + 1] == "all")
                                {
                                    nounMeaning = " অন্য সব ";
                                }
                                else if (words[i + 1] == "most")
                                {
                                    nounMeaning = " অধিকাংশ ";
                                }
                                nounMeaning += nounMeaning_Detection(i, 3, words, meaningDT);
                                prepositionlaAmbiguitySolution += nounMeaning + " এর থেকে";
                                break;
                            //case "case45":

                            //    break;
                            case "case59":
                                prepositionlaAmbiguitySolution += " " + aTransferAndGeneration_stg.IdetifyObjects_NotRelatedWith_Preposition(PStructure_start, PStructure_end, words, meaningDT, subject, verb);
                                if (words[i + 1] == "anything")
                                {
                                    nounMeaning = " যে কোনো কিছু থেকে";
                                }
                                else if (words[i + 1] == "everything")
                                {
                                    nounMeaning = "স ব কিছু থেকে";
                                }
                                else if (words[i + 1] == "nothing")
                                {
                                    nounMeaning = " কোনো কিছু থেকেই ";
                                }
                                prepositionlaAmbiguitySolution += nounMeaning;
                                break;
                            case "case63":
                                prepositionlaAmbiguitySolution += " " + aTransferAndGeneration_stg.IdetifyObjects_NotRelatedWith_Preposition(PStructure_start, PStructure_end, words, meaningDT, subject, verb);
                                verbMeaning = verbMeaning_Detection(i, 2, words, meaningDT);
                                if (words[i + 1] == "he")
                                {
                                    prepositionlaAmbiguitySolution += " তার ";
                                }
                                else if (words[i + 1] == "her")
                                {
                                    pronounMeaning = " তার ";
                                    prepositionlaAmbiguitySolution += pronounMeaning + verbMeaning + " এর থেকে ";
                                }
                                else if (words[i + 1] == "them")
                                {
                                    pronounMeaning = " তাদের ";
                                    prepositionlaAmbiguitySolution += pronounMeaning + verbMeaning + " এর থেকে ";
                                }
                                else if (words[i + 1] == "you")
                                {
                                    pronounMeaning = " তোমার ";
                                    prepositionlaAmbiguitySolution += pronounMeaning + verbMeaning + " এর থেকে ";
                                }
                                else if (words[i + 1] == "we")
                                {
                                    pronounMeaning = " আমরা ";
                                    prepositionlaAmbiguitySolution += pronounMeaning + verbMeaning + " এর থেকে ";
                                }
                                else if (words[i + 1] == "I")
                                {
                                    pronounMeaning = " আমার ";
                                    prepositionlaAmbiguitySolution += pronounMeaning + verbMeaning + " এর থেকে ";
                                }
                                else
                                {
                                    nounMeaning = nounMeaning_Detection(i, 1, words, meaningDT);
                                    if (nounMeaning == "")
                                    {
                                        nounMeaning = words[i + 1];
                                    }
                                    prepositionlaAmbiguitySolution += nounMeaning + " এর " + verbMeaning + "এর থেকে";
                                }
                                break;

                        }
                    }
                    else if (words[i] == "through")
                    {
                        structure = idntifyPrepositional_Structure(words, i, postags);
                        switch (structure)
                        {
                            case "case1":
                                prepositionlaAmbiguitySolution += " " + aTransferAndGeneration_stg.IdetifyObjects_NotRelatedWith_Preposition(PStructure_start, PStructure_end, words, meaningDT, subject, verb);
                                if (words[i + 1] == "him")
                                {
                                    prepositionlaAmbiguitySolution += " তার মাধ্যমে ";
                                }
                                else if (words[i + 1] == "her")
                                {
                                    prepositionlaAmbiguitySolution += " তার মাধ্যমে ";
                                }
                                else if (words[i + 1] == "them")
                                {
                                    prepositionlaAmbiguitySolution += " তাদের মাধ্যমে ";
                                }
                                else if (words[i + 1] == "you")
                                {
                                    prepositionlaAmbiguitySolution += " তোমার মাধ্যমে ";
                                }
                                else if (words[i + 1] == "us")
                                {
                                    prepositionlaAmbiguitySolution += " আমাদের মাধ্যমে ";
                                }
                                else if (words[i + 1] == "me")
                                {
                                    prepositionlaAmbiguitySolution += " আমার মাধ্যমে ";
                                }
                                else
                                {
                                    nounMeaning = nounMeaning_Detection(i, 1, words, meaningDT);
                                    if (nounMeaning == "")
                                    {
                                        nounMeaning = words[i + 1];
                                    }
                                    prepositionlaAmbiguitySolution += nounMeaning + " এর মাধ্যমে ";
                                }
                                break;

                            case "case2":
                                prepositionlaAmbiguitySolution += " " + aTransferAndGeneration_stg.IdetifyObjects_NotRelatedWith_Preposition(PStructure_start, PStructure_end, words, meaningDT, subject, verb);
                                nounMeaning = nounMeaning_Detection(i, 2, words, meaningDT);
                                if (words[i + 1] == "a" || words[i + 1] == "an")
                                {
                                    prepositionlaAmbiguitySolution += " একটি " + nounMeaning + " এর মধ্য দিয়ে ";
                                }
                                else
                                {
                                    prepositionlaAmbiguitySolution += nounMeaning + " টির মধ্য দিয়ে ";
                                }
                                break;

                            case "case7":
                                prepositionlaAmbiguitySolution += " " + aTransferAndGeneration_stg.IdetifyObjects_NotRelatedWith_Preposition(PStructure_start, PStructure_end, words, meaningDT, subject, verb);
                                nounMeaning = nounMeaning_Detection(i, 2, words, meaningDT);
                                if (words[i + 1] == "his")
                                {
                                    pronounMeaning = " তার ";
                                }
                                else if (words[i + 1] == "her")
                                {
                                    pronounMeaning = " তার ";
                                }
                                else if (words[i + 1] == "their")
                                {
                                    pronounMeaning = " তাদের ";
                                }
                                else if (words[i + 1] == "your")
                                {
                                    pronounMeaning = " তোমার ";
                                }
                                else if (words[i + 1] == "our")
                                {
                                    pronounMeaning = " আমাদের ";
                                }
                                else if (words[i + 1] == "my")
                                {
                                    pronounMeaning = " আমার ";
                                }
                                prepositionlaAmbiguitySolution += pronounMeaning + nounMeaning + " এর মাধ্যমে ";
                                break;
                            case "case19":
                                prepositionlaAmbiguitySolution += " " + aTransferAndGeneration_stg.IdetifyObjects_NotRelatedWith_Preposition(PStructure_start, PStructure_end, words, meaningDT, subject, verb);
                                dayMeaning = dayMeaning_Detection(i, 1, words, meaningDT);
                                prepositionlaAmbiguitySolution += dayMeaning + " এর মধ্যে ";
                                break;
                            case "case24":
                                prepositionlaAmbiguitySolution += " " + aTransferAndGeneration_stg.IdetifyObjects_NotRelatedWith_Preposition(PStructure_start, PStructure_end, words, meaningDT, subject, verb);
                                nounMeaning = nounMeaning_Detection(i, 2, words, meaningDT);
                                if (words[i + 1] == "this")
                                {
                                    nounMeaning = " এই " + nounMeaning;
                                }
                                else if (words[i + 1] == "that")
                                {
                                    nounMeaning = " ঐ " + nounMeaning;
                                }
                                else if (words[i + 1] == "these")
                                {
                                    nounMeaning = " এই " + nounMeaning + " গুলো ";
                                }
                                else
                                {
                                    nounMeaning = " ঐ " + nounMeaning + " গুলো ";
                                }
                                prepositionlaAmbiguitySolution += nounMeaning + " এর মধ্য দিয়ে ";
                                break;
                        }
                    }
                    else if (words[i] == "towards")
                    {
                        structure = idntifyPrepositional_Structure(words, i, postags);
                        switch (structure)
                        {
                            case "case1":
                                prepositionlaAmbiguitySolution += " " + aTransferAndGeneration_stg.IdetifyObjects_NotRelatedWith_Preposition(PStructure_start, PStructure_end, words, meaningDT, subject, verb);
                                if (words[i + 1] == "him")
                                {
                                    prepositionlaAmbiguitySolution += " তার দিকে ";
                                }
                                else if (words[i + 1] == "her")
                                {
                                    prepositionlaAmbiguitySolution += "তার দিকে ";
                                }
                                else if (words[i + 1] == "them")
                                {
                                    prepositionlaAmbiguitySolution += " তাদের দিকে ";
                                }
                                else if (words[i + 1] == "you")
                                {
                                    prepositionlaAmbiguitySolution += " তোমার দিকে ";
                                }
                                else if (words[i + 1] == "us")
                                {
                                    prepositionlaAmbiguitySolution = " আমাদের দিকে ";
                                }
                                else if (words[i + 1] == "me")
                                {
                                    prepositionlaAmbiguitySolution += " আমার দিকে ";
                                }
                                else
                                {
                                    nounMeaning = nounMeaning_Detection(i, 1, words, meaningDT);
                                    if (nounMeaning == "")
                                    {
                                        nounMeaning = words[i + 1];
                                    }
                                    prepositionlaAmbiguitySolution += nounMeaning + " এর দিকে ";
                                }
                                break;

                            case "case2":
                                prepositionlaAmbiguitySolution += " " + aTransferAndGeneration_stg.IdetifyObjects_NotRelatedWith_Preposition(PStructure_start, PStructure_end, words, meaningDT, subject, verb);
                                nounMeaning = nounMeaning_Detection(i, 2, words, meaningDT);
                                if (words[i + 1] == "a" || words[i + 1] == "an")
                                {
                                    prepositionlaAmbiguitySolution += " একটি " + nounMeaning + " এর দিকে ";
                                }
                                else
                                {
                                    prepositionlaAmbiguitySolution += nounMeaning + " টির দিকে ";
                                }
                                break;
                            case "case64":
                                prepositionlaAmbiguitySolution += " " + aTransferAndGeneration_stg.IdetifyObjects_NotRelatedWith_Preposition(PStructure_start, PStructure_end, words, meaningDT, subject, verb);
                                nounMeaning = nounMeaning_Detection(i, 1, words, meaningDT);
                                if (nounMeaning == "")
                                {
                                    nounMeaning = words[i + 1];
                                }
                                string noun2 = nounMeaning_Detection(i, 2, words, meaningDT);
                                if (noun2 == " ")
                                {
                                    noun2 = words[i + 2];
                                }
                                nounMeaning += nounMeaning + " " + noun2;
                                nounMeaning += " এর দিকে ";
                                prepositionlaAmbiguitySolution += nounMeaning;
                                break;
                        }
                    }
                    else if (words[i] == "under")
                    {
                        structure = idntifyPrepositional_Structure(words, i, postags);
                        switch (structure)
                        {
                            case "case1":
                                prepositionlaAmbiguitySolution += " " + aTransferAndGeneration_stg.IdetifyObjects_NotRelatedWith_Preposition(PStructure_start, PStructure_end, words, meaningDT, subject, verb);
                                if (words[i + 1] == "him")
                                {
                                    prepositionlaAmbiguitySolution += " তার অধীনে ";
                                }
                                else if (words[i + 1] == "her")
                                {
                                    prepositionlaAmbiguitySolution += " তার অধীনে ";
                                }
                                else if (words[i + 1] == "them")
                                {
                                    prepositionlaAmbiguitySolution += " তাদের অধীনে ";
                                }
                                else if (words[i + 1] == "you")
                                {
                                    prepositionlaAmbiguitySolution += " তোমার অধীনে ";
                                }
                                else if (words[i + 1] == "us")
                                {
                                    prepositionlaAmbiguitySolution += " আমাদের অধীনে ";
                                }
                                else if (words[i + 1] == "me")
                                {
                                    prepositionlaAmbiguitySolution += " আমার অধীনে ";
                                }
                                else
                                {
                                    nounMeaning = nounMeaning_Detection(i, 1, words, meaningDT);
                                    if (nounMeaning == "")
                                    {
                                        nounMeaning = words[i + 1];
                                    }
                                    prepositionlaAmbiguitySolution += nounMeaning + " এর নিচে ";
                                }
                                break;

                            case "case2":
                                prepositionlaAmbiguitySolution += " " + aTransferAndGeneration_stg.IdetifyObjects_NotRelatedWith_Preposition(PStructure_start, PStructure_end, words, meaningDT, subject, verb);
                                nounMeaning = nounMeaning_Detection(i, 2, words, meaningDT);
                                if (words[i + 1] == "a" || words[i + 1] == "an")
                                {
                                    prepositionlaAmbiguitySolution += " একটি " + nounMeaning + " এর নিচে ";
                                }
                                else
                                {
                                    prepositionlaAmbiguitySolution += nounMeaning + " টির নিচে ";
                                }
                                break;
                            case "case5":
                                prepositionlaAmbiguitySolution += " " + aTransferAndGeneration_stg.IdetifyObjects_NotRelatedWith_Preposition(PStructure_start, PStructure_end, words, meaningDT, subject, verb);
                                if (words[i + 1] == "this")
                                {
                                    nounMeaning = " এর নিচে  ";
                                }
                                else if (words[i + 1] == "that")
                                {
                                    nounMeaning = " ঐটার নিচে ";
                                }
                                else if (words[i + 1] == "these")
                                {
                                    nounMeaning = " এগুলোর নিচে ";
                                }
                                else if (words[i + 1] == "it")
                                {
                                    nounMeaning = " এর নিচে ";
                                }
                                else
                                {
                                    nounMeaning = " ঐগুলোর নিচে ";
                                }
                                prepositionlaAmbiguitySolution += nounMeaning;
                                break;
                            case "case7":
                                prepositionlaAmbiguitySolution += " " + aTransferAndGeneration_stg.IdetifyObjects_NotRelatedWith_Preposition(PStructure_start, PStructure_end, words, meaningDT, subject, verb);
                                nounMeaning = nounMeaning_Detection(i, 2, words, meaningDT);
                                if (words[i + 1] == "his")
                                {
                                    pronounMeaning = " তার ";
                                }
                                else if (words[i + 1] == "her")
                                {
                                    pronounMeaning = " তার ";
                                }
                                else if (words[i + 1] == "their")
                                {
                                    pronounMeaning = " তাদের ";
                                }
                                else if (words[i + 1] == "your")
                                {
                                    pronounMeaning = " তোমার ";
                                }
                                else if (words[i + 1] == "our")
                                {
                                    pronounMeaning = " আমাদের ";
                                }
                                else if (words[i + 1] == "my")
                                {
                                    pronounMeaning = " আমার ";
                                }
                                prepositionlaAmbiguitySolution += pronounMeaning + nounMeaning + " এর অধীনে ";
                                break;
                            case "case12":
                                prepositionlaAmbiguitySolution += " " + aTransferAndGeneration_stg.IdetifyObjects_NotRelatedWith_Preposition(PStructure_start, PStructure_end, words, meaningDT, subject, verb);
                                nounMeaning = nounMeaning_Detection(i, 2, words, meaningDT);
                                if (int.Parse(words[i + 1]) > 0)
                                {
                                    prepositionlaAmbiguitySolution += words[i + 1] + nounMeaning + " এর মধ্যে ";
                                }
                                else if (words[i + 1] == "a")
                                {
                                    prepositionlaAmbiguitySolution += " এক " + nounMeaning + " এর মধ্যে ";
                                }
                                else
                                {
                                    string numberMeaning = "";
                                    numberMeaning = nounMeaning_Detection(i, 1, words, meaningDT);
                                    prepositionlaAmbiguitySolution += numberMeaning + nounMeaning + " এর মধ্যে ";
                                }
                                break;
                            case "case14":
                                prepositionlaAmbiguitySolution += " " + aTransferAndGeneration_stg.IdetifyObjects_NotRelatedWith_Preposition(PStructure_start, PStructure_end, words, meaningDT, subject, verb);
                                prepositionlaAmbiguitySolution += words[i + 1] + " এর অধীনে ";
                                break;
                            case "case24":
                                prepositionlaAmbiguitySolution += " " + aTransferAndGeneration_stg.IdetifyObjects_NotRelatedWith_Preposition(PStructure_start, PStructure_end, words, meaningDT, subject, verb);
                                nounMeaning = nounMeaning_Detection(i, 2, words, meaningDT);
                                if (words[i + 1] == "this")
                                {
                                    nounMeaning = " এই " + nounMeaning;
                                }
                                else if (words[i + 1] == "that")
                                {
                                    nounMeaning = " ঐ " + nounMeaning;
                                }
                                else if (words[i + 1] == "these")
                                {
                                    nounMeaning = " এই " + nounMeaning + " গুলো ";
                                }
                                else
                                {
                                    nounMeaning = " ঐ " + nounMeaning + " গুলো ";
                                }
                                prepositionlaAmbiguitySolution += nounMeaning + " এর অধীনে ";
                                break;
                            case "case25":
                                prepositionlaAmbiguitySolution += " " + aTransferAndGeneration_stg.IdetifyObjects_NotRelatedWith_Preposition(PStructure_start, PStructure_end, words, meaningDT, subject, verb);
                                if (words[i + 1] == "theirs")
                                {
                                    pronounMeaning = " তাদের ";
                                }
                                else if (words[i + 1] == "ours")
                                {
                                    pronounMeaning = " আমাদের ";
                                }
                                else if (words[i + 1] == "yours")
                                {
                                    pronounMeaning = " তোমার ";
                                }
                                else if (words[i + 1] == "us")
                                {
                                    pronounMeaning = " আমাদের ";
                                }
                                prepositionlaAmbiguitySolution += pronounMeaning + " অধীনে ";
                                break;
                            case "case26":
                                prepositionlaAmbiguitySolution += " " + aTransferAndGeneration_stg.IdetifyObjects_NotRelatedWith_Preposition(PStructure_start, PStructure_end, words, meaningDT, subject, verb);
                                nounMeaning = nounMeaning_Detection(i, 1, words, meaningDT);
                                if (nounMeaning == "")
                                {
                                    nounMeaning = words[i + 1];
                                }
                                nounMeaning += " এবং ";
                                string nouMeaning2 = nounMeaning_Detection(i, 3, words, meaningDT);
                                if (nouMeaning2 == "")
                                {
                                    nouMeaning2 = words[i + 3];
                                }
                                prepositionlaAmbiguitySolution += nounMeaning + nouMeaning2 + " এর অধীনে ";
                                break;
                            case "case27":
                                prepositionlaAmbiguitySolution += " " + aTransferAndGeneration_stg.IdetifyObjects_NotRelatedWith_Preposition(PStructure_start, PStructure_end, words, meaningDT, subject, verb);
                                nounMeaning = nounMeaning_Detection(i, 3, words, meaningDT);
                                if (nounMeaning == "")
                                {
                                    nounMeaning = words[i + 3];
                                }
                                nounMeaning += " এবং ";
                                string nouMeaning2nd = nounMeaning_Detection(i, 6, words, meaningDT);
                                if (nouMeaning2nd == "")
                                {
                                    nouMeaning2nd = words[i + 6];
                                }
                                prepositionlaAmbiguitySolution += nounMeaning + nouMeaning2nd + "এর অধীনে ";
                                break;
                            case "case64":
                                prepositionlaAmbiguitySolution += " " + aTransferAndGeneration_stg.IdetifyObjects_NotRelatedWith_Preposition(PStructure_start, PStructure_end, words, meaningDT, subject, verb);
                                nounMeaning = nounMeaning_Detection(i, 1, words, meaningDT);
                                if (nounMeaning == "")
                                {
                                    nounMeaning = words[i + 1];
                                }
                                string noun2 = nounMeaning_Detection(i, 2, words, meaningDT);
                                if (noun2 == " ")
                                {
                                    noun2 = words[i + 1];
                                }
                                nounMeaning += nounMeaning + " " + noun2;
                                nounMeaning += " এর অধীনে ";
                                prepositionlaAmbiguitySolution += nounMeaning;
                                break;
                        }
                    }
                    else if (words[i] == "until")
                    {
                        structure = idntifyPrepositional_Structure(words, i, postags);
                        switch (structure)
                        {
                            case "case2":
                                prepositionlaAmbiguitySolution += " " + aTransferAndGeneration_stg.IdetifyObjects_NotRelatedWith_Preposition(PStructure_start, PStructure_end, words, meaningDT, subject, verb);
                                nounMeaning = nounMeaning_Detection(i, 2, words, meaningDT);
                                if (words[i + 1] == "a" || words[i + 1] == "an")
                                {
                                    prepositionlaAmbiguitySolution += " একটি " + nounMeaning + " এর পর্যন্ত ";
                                }
                                else
                                {
                                    prepositionlaAmbiguitySolution += nounMeaning + " টির পর্যন্ত ";
                                }
                                break;
                            case "case5":
                                prepositionlaAmbiguitySolution += " " + aTransferAndGeneration_stg.IdetifyObjects_NotRelatedWith_Preposition(PStructure_start, PStructure_end, words, meaningDT, subject, verb);
                                if (words[i + 1] == "this")
                                {
                                    nounMeaning = " এপর্যন্ত ";
                                }
                                else if (words[i + 1] == "that")
                                {
                                    nounMeaning = " ঐ পর্যন্ত ";
                                }
                                else if (words[i + 1] == "these")
                                {
                                    nounMeaning = " এগুলোর পর্যন্ত ";
                                }
                                else if (words[i + 1] == "it")
                                {
                                    nounMeaning = " এপর্যন্ত ";
                                }
                                else
                                {
                                    nounMeaning = " ঐগুলোর পর্যন্ত ";
                                }
                                prepositionlaAmbiguitySolution += nounMeaning;
                                break;
                            case "case7":
                                prepositionlaAmbiguitySolution += " " + aTransferAndGeneration_stg.IdetifyObjects_NotRelatedWith_Preposition(PStructure_start, PStructure_end, words, meaningDT, subject, verb);
                                nounMeaning = nounMeaning_Detection(i, 2, words, meaningDT);
                                if (words[i + 1] == "his")
                                {
                                    pronounMeaning = " তার ";
                                }
                                else if (words[i + 1] == "her")
                                {
                                    pronounMeaning = " তার ";
                                }
                                else if (words[i + 1] == "their")
                                {
                                    pronounMeaning = " তাদের ";
                                }
                                else if (words[i + 1] == "your")
                                {
                                    pronounMeaning = " তোমার ";
                                }
                                else if (words[i + 1] == "our")
                                {
                                    pronounMeaning = " আমাদের ";
                                }
                                else if (words[i + 1] == "my")
                                {
                                    pronounMeaning = " আমার ";
                                }
                                prepositionlaAmbiguitySolution += pronounMeaning + nounMeaning + " পর্যন্ত ";
                                break;
                            case "case8":
                                prepositionlaAmbiguitySolution += " " + aTransferAndGeneration_stg.IdetifyObjects_NotRelatedWith_Preposition(PStructure_start, PStructure_end, words, meaningDT, subject, verb);
                                monthSeasonMeaming = month_seasonDetection(i, 1, words, meaningDT);
                                if (postags[i + 2] == "CD ")
                                {
                                    monthSeasonMeaming += words[i + 2];
                                }
                                prepositionlaAmbiguitySolution += monthSeasonMeaming + " পর্যন্ত ";
                                break;
                            case "case12":
                                prepositionlaAmbiguitySolution += " " + aTransferAndGeneration_stg.IdetifyObjects_NotRelatedWith_Preposition(PStructure_start, PStructure_end, words, meaningDT, subject, verb);
                                nounMeaning = nounMeaning_Detection(i, 2, words, meaningDT);
                                if (int.Parse(words[i + 1]) > 0)
                                {
                                    prepositionlaAmbiguitySolution += words[i + 1] + nounMeaning + " পর্যন্ত ";
                                }
                                else if (words[i + 1] == "a")
                                {
                                    prepositionlaAmbiguitySolution += " এক " + nounMeaning + " পর্যন্ত ";
                                }
                                else
                                {
                                    string numberMeaning = "";
                                    numberMeaning = nounMeaning_Detection(i, 1, words, meaningDT);
                                    prepositionlaAmbiguitySolution += numberMeaning + nounMeaning + " পর্যন্ত ";
                                }
                                break;
                            case "case19":
                                prepositionlaAmbiguitySolution += " " + aTransferAndGeneration_stg.IdetifyObjects_NotRelatedWith_Preposition(PStructure_start, PStructure_end, words, meaningDT, subject, verb);
                                dayMeaning = dayMeaning_Detection(i, 1, words, meaningDT);
                                prepositionlaAmbiguitySolution += dayMeaning + " পর্যন্ত ";
                                break;
                            case "case24":
                                prepositionlaAmbiguitySolution += " " + aTransferAndGeneration_stg.IdetifyObjects_NotRelatedWith_Preposition(PStructure_start, PStructure_end, words, meaningDT, subject, verb);
                                nounMeaning = nounMeaning_Detection(i, 2, words, meaningDT);
                                if (words[i + 1] == "this")
                                {
                                    nounMeaning = "এই " + nounMeaning;
                                }
                                else if (words[i + 1] == "that")
                                {
                                    nounMeaning = "ঐ " + nounMeaning;
                                }
                                else if (words[i + 1] == "these")
                                {
                                    nounMeaning = "এই " + nounMeaning + " গুলো ";
                                }
                                else
                                {
                                    nounMeaning = "ঐ " + nounMeaning + " গুলো ";
                                }
                                prepositionlaAmbiguitySolution += nounMeaning + "এর পর্যন্ত ";
                                break;
                            case "case29":
                                prepositionlaAmbiguitySolution += " " + aTransferAndGeneration_stg.IdetifyObjects_NotRelatedWith_Preposition(PStructure_start, PStructure_end, words, meaningDT, subject, verb);
                                if (words[i + 1] == "a" || words[i + 1] == "an")
                                {
                                    nounMeaning = nounMeaning_Detection(i, 3, words, meaningDT);
                                    nounMeaning += " একটি " + nounMeaning;
                                    nounMeaning += nounMeaning_Detection(i, 1, words, meaningDT);
                                }
                                else
                                {
                                    nounMeaning = nounMeaning_Detection(i, 3, words, meaningDT);
                                    nounMeaning += nounMeaning + " টি";
                                    nounMeaning += nounMeaning_Detection(i, 1, words, meaningDT);
                                }
                                prepositionlaAmbiguitySolution += nounMeaning + " পর্যন্ত ";
                                break;
                            case "case31":
                                prepositionlaAmbiguitySolution += " " + aTransferAndGeneration_stg.IdetifyObjects_NotRelatedWith_Preposition(PStructure_start, PStructure_end, words, meaningDT, subject, verb);
                                if (words[i + 1] == "now")
                                {
                                    nounMeaning = " এখন পর্যন্ত ";
                                }
                                else if (words[i + 1] == "then")
                                {
                                    nounMeaning = " তখন পর্যন্ত ";
                                }
                                prepositionlaAmbiguitySolution += nounMeaning;
                                break;
                            case "case55":
                                prepositionlaAmbiguitySolution += " " + aTransferAndGeneration_stg.IdetifyObjects_NotRelatedWith_Preposition(PStructure_start, PStructure_end, words, meaningDT, subject, verb);
                                if (words[i + 1] == "tomorrow")
                                {
                                    nounMeaning = " আগামীকাল পর্যন্ত ";
                                }
                                else if (words[i + 1] == "yesterday")
                                {
                                    nounMeaning = " গতকাল পর্যন্ত ";
                                }
                                else if (words[i + 1] == "today")
                                {
                                    nounMeaning = " আজকে পর্যন্ত ";
                                }
                                else if (words[i + 1] == "now")
                                {
                                    nounMeaning = " এ পর্যন্ত ";
                                }
                                prepositionlaAmbiguitySolution += nounMeaning;
                                break;
                            //case "case63":
                            //    verbMeaning = verbMeaning_Detection(i, 2, words, meaningDT);
                            //    if (words[i + 1] == "he")
                            //    {
                            //        prepositionlaAmbiguitySolution = "তার ";
                            //    }
                            //    else if (words[i + 1] == "her")
                            //    {
                            //        pronounMeaning = " তার ";
                            //        prepositionlaAmbiguitySolution = pronounMeaning + verbMeaning + " এর থেকে ";
                            //    }
                            //    else if (words[i + 1] == "them")
                            //    {
                            //        pronounMeaning = " তাদের ";
                            //        prepositionlaAmbiguitySolution = pronounMeaning + verbMeaning + " এর থেকে ";
                            //    }
                            //    else if (words[i + 1] == "you")
                            //    {
                            //        pronounMeaning = " তোমার ";
                            //        prepositionlaAmbiguitySolution = pronounMeaning + verbMeaning + " এর থেকে ";
                            //    }
                            //    else if (words[i + 1] == "we")
                            //    {
                            //        pronounMeaning = " আমরা ";
                            //        prepositionlaAmbiguitySolution = pronounMeaning + verbMeaning + " এর থেকে ";
                            //    }
                            //    else if (words[i + 1] == "I")
                            //    {
                            //        pronounMeaning = " আমার ";
                            //        prepositionlaAmbiguitySolution = pronounMeaning + verbMeaning + " এর থেকে ";
                            //    }
                            //    else
                            //    {
                            //        nounMeaning = nounMeaning_Detection(i, 1, words, meaningDT);
                            //        prepositionlaAmbiguitySolution = nounMeaning + " এর " + verbMeaning + "এর থেকে";
                            //    }
                            //    break;
                            case "case65":
                                nounMeaning = "যতক্ষণ না ";
                                if (words[i + 1] == "a" || words[i + 1] == "an")
                                {
                                    nounMeaning += "একটি " + nounMeaning_Detection(i, 2, words, meaningDT) + " " + nounMeaning_Detection(i, 3, words, meaningDT);
                                }
                                else
                                {
                                    nounMeaning += nounMeaning_Detection(i, 2, words, meaningDT) + " " + nounMeaning_Detection(i, 2, words, meaningDT);
                                }
                                break;


                        }
                    }
                    else if (words[i] == "unlike")
                    {
                        structure = idntifyPrepositional_Structure(words, i, postags);
                        switch (structure)
                        {
                            case "case1":
                                prepositionlaAmbiguitySolution += " " + aTransferAndGeneration_stg.IdetifyObjects_NotRelatedWith_Preposition(PStructure_start, PStructure_end, words, meaningDT, subject, verb);
                                if (words[i + 1] == "him")
                                {
                                    prepositionlaAmbiguitySolution += " তার অসদৃশ ";
                                }
                                else if (words[i + 1] == "her")
                                {
                                    prepositionlaAmbiguitySolution += " তার অসদৃশ ";
                                }
                                else if (words[i + 1] == "them")
                                {
                                    prepositionlaAmbiguitySolution += " তাদের অসদৃশ ";
                                }
                                else if (words[i + 1] == "you")
                                {
                                    prepositionlaAmbiguitySolution += " তোমার অসদৃশ ";
                                }
                                else if (words[i + 1] == "us")
                                {
                                    prepositionlaAmbiguitySolution += " আমাদের অসদৃশ ";
                                }
                                else if (words[i + 1] == "me")
                                {
                                    prepositionlaAmbiguitySolution += " আমার অসদৃশ ";
                                }
                                else
                                {
                                    nounMeaning = nounMeaning_Detection(i, 1, words, meaningDT);
                                    if (nounMeaning == "")
                                    {
                                        nounMeaning = words[i + 1];
                                    }
                                    prepositionlaAmbiguitySolution += nounMeaning + " এর অসদৃশ ";
                                }
                                break;

                            case "case2":
                                prepositionlaAmbiguitySolution += " " + aTransferAndGeneration_stg.IdetifyObjects_NotRelatedWith_Preposition(PStructure_start, PStructure_end, words, meaningDT, subject, verb);
                                nounMeaning = nounMeaning_Detection(i, 2, words, meaningDT);
                                if (words[i + 1] == "a" || words[i + 1] == "an")
                                {
                                    prepositionlaAmbiguitySolution += " একটি " + nounMeaning + " এর অসদৃশ ";
                                }
                                else
                                {
                                    prepositionlaAmbiguitySolution += nounMeaning + " টির অসদৃশ ";
                                }
                                break;
                            case "case7":
                                prepositionlaAmbiguitySolution += " " + aTransferAndGeneration_stg.IdetifyObjects_NotRelatedWith_Preposition(PStructure_start, PStructure_end, words, meaningDT, subject, verb);
                                nounMeaning = nounMeaning_Detection(i, 2, words, meaningDT);
                                if (words[i + 1] == "his")
                                {
                                    pronounMeaning = " তার ";
                                }
                                else if (words[i + 1] == "her")
                                {
                                    pronounMeaning = " তার ";
                                }
                                else if (words[i + 1] == "their")
                                {
                                    pronounMeaning = " তাদের ";
                                }
                                else if (words[i + 1] == "your")
                                {
                                    pronounMeaning = " তোমার ";
                                }
                                else if (words[i + 1] == "our")
                                {
                                    pronounMeaning = " আমাদের ";
                                }
                                else if (words[i + 1] == "my")
                                {
                                    pronounMeaning = " আমার ";
                                }
                                prepositionlaAmbiguitySolution += pronounMeaning + nounMeaning + " এর অসদৃশ ";
                                break;
                            case "case8":
                                prepositionlaAmbiguitySolution += " " + aTransferAndGeneration_stg.IdetifyObjects_NotRelatedWith_Preposition(PStructure_start, PStructure_end, words, meaningDT, subject, verb);
                                monthSeasonMeaming = month_seasonDetection(i, 1, words, meaningDT);
                                if (postags[i + 2] == "CD ")
                                {
                                    monthSeasonMeaming += words[i + 2];
                                }
                                prepositionlaAmbiguitySolution += monthSeasonMeaming + " এর অসদৃশ ";
                                break;
                            case "case24":
                                prepositionlaAmbiguitySolution += " " + aTransferAndGeneration_stg.IdetifyObjects_NotRelatedWith_Preposition(PStructure_start, PStructure_end, words, meaningDT, subject, verb);
                                nounMeaning = nounMeaning_Detection(i, 2, words, meaningDT);
                                if (words[i + 1] == "this")
                                {
                                    nounMeaning = " এই " + nounMeaning;
                                }
                                else if (words[i + 1] == "that")
                                {
                                    nounMeaning = " ঐ " + nounMeaning;
                                }
                                else if (words[i + 1] == "these")
                                {
                                    nounMeaning = " এই " + nounMeaning + " গুলো ";
                                }
                                else
                                {
                                    nounMeaning = " ঐ " + nounMeaning + " গুলো ";
                                }
                                prepositionlaAmbiguitySolution += nounMeaning + " এর অসদৃশ ";
                                break;
                            case "case25":
                                prepositionlaAmbiguitySolution += " " + aTransferAndGeneration_stg.IdetifyObjects_NotRelatedWith_Preposition(PStructure_start, PStructure_end, words, meaningDT, subject, verb);
                                if (words[i + 1] == "theirs")
                                {
                                    pronounMeaning = " তাদের ";
                                }
                                else if (words[i + 1] == "ours")
                                {
                                    pronounMeaning = " আমাদের ";
                                }
                                else if (words[i + 1] == "yours")
                                {
                                    pronounMeaning = " তোমার ";
                                }
                                else if (words[i + 1] == "us")
                                {
                                    pronounMeaning = " আমাদের ";
                                }
                                prepositionlaAmbiguitySolution += pronounMeaning + " অসদৃশ ";
                                break;
                            case "case32":
                                prepositionlaAmbiguitySolution += " " + aTransferAndGeneration_stg.IdetifyObjects_NotRelatedWith_Preposition(PStructure_start, PStructure_end, words, meaningDT, subject, verb);
                                nounMeaning = nounMeaning_Detection(i, 1, words, meaningDT);
                                prepositionlaAmbiguitySolution += nounMeaning + " এর অসদৃশ ";//in summer
                                break;
                            case "case35":
                                prepositionlaAmbiguitySolution += " " + aTransferAndGeneration_stg.IdetifyObjects_NotRelatedWith_Preposition(PStructure_start, PStructure_end, words, meaningDT, subject, verb);
                                if (words[i + 1] == "most")
                                {
                                    nounMeaning = " অধিকাংশ ";
                                }
                                else if (words[i + 1] == "most")
                                {
                                    nounMeaning = " আরো ";
                                }
                                nounMeaning += nounMeaning_Detection(i, 2, words, meaningDT);
                                prepositionlaAmbiguitySolution += nounMeaning + " এর অসদৃশ ";
                                break;
                            case "case36":
                                prepositionlaAmbiguitySolution += " " + aTransferAndGeneration_stg.IdetifyObjects_NotRelatedWith_Preposition(PStructure_start, PStructure_end, words, meaningDT, subject, verb);
                                if (words[i + 1] == "any")
                                {
                                    nounMeaning = " অন্য যে কোনো ";
                                }
                                else if (words[i + 1] == "some")
                                {
                                    nounMeaning = " কিছু ";
                                }
                                else if (words[i + 1] == "all")
                                {
                                    nounMeaning = " অন্য সব ";
                                }
                                else if (words[i + 1] == "most")
                                {
                                    nounMeaning = " অধিকাংশ ";
                                }
                                nounMeaning += nounMeaning_Detection(i, 3, words, meaningDT);
                                prepositionlaAmbiguitySolution += nounMeaning + " এর অসদৃশ ";
                                break;
                            case "case50":
                                prepositionlaAmbiguitySolution += " " + aTransferAndGeneration_stg.IdetifyObjects_NotRelatedWith_Preposition(PStructure_start, PStructure_end, words, meaningDT, subject, verb);
                                nounMeaning = " সব ";
                                nounMeaning += nounMeaning_Detection(i, 3, words, meaningDT);
                                prepositionlaAmbiguitySolution += nounMeaning + " এর অসদৃশ ";
                                break;
                            case "case51":
                                prepositionlaAmbiguitySolution += " " + aTransferAndGeneration_stg.IdetifyObjects_NotRelatedWith_Preposition(PStructure_start, PStructure_end, words, meaningDT, subject, verb);
                                nounMeaning = " সব ";
                                nounMeaning += nounMeaning_Detection(i, 2, words, meaningDT);
                                prepositionlaAmbiguitySolution += nounMeaning + " এর অসদৃশ ";
                                break;
                            case "case55":
                                prepositionlaAmbiguitySolution += " " + aTransferAndGeneration_stg.IdetifyObjects_NotRelatedWith_Preposition(PStructure_start, PStructure_end, words, meaningDT, subject, verb);
                                if (words[i + 1] == "tomorrow")
                                {
                                    nounMeaning = " আগামীকালের অসদৃশ ";
                                }
                                else if (words[i + 1] == "yesterday")
                                {
                                    nounMeaning = " গতকালের অসদৃশ ";
                                }
                                else if (words[i + 1] == "today")
                                {
                                    nounMeaning = " আজকের অসদৃশ ";
                                }
                                else if (words[i + 1] == "now")
                                {
                                    nounMeaning = " এর অসদৃশ ";
                                }
                                prepositionlaAmbiguitySolution += nounMeaning;
                                break;

                            case "case59":
                                prepositionlaAmbiguitySolution += " " + aTransferAndGeneration_stg.IdetifyObjects_NotRelatedWith_Preposition(PStructure_start, PStructure_end, words, meaningDT, subject, verb);
                                if (words[i + 1] == "anything")
                                {
                                    nounMeaning = " যে কোনো কিছুর অসদৃশ ";
                                }
                                else if (words[i + 1] == "everything")
                                {
                                    nounMeaning = " সব কিছুর অসদৃশ ";
                                }
                                else if (words[i + 1] == "nothing")
                                {
                                    nounMeaning = " কোনো কিছুর অসদৃশ না ";
                                }
                                prepositionlaAmbiguitySolution += nounMeaning;
                                break;
                        }
                    }
                    //else if (words[i] == "up")
                    //{
                    //    structure = idntifyPrepositional_Structure(words, i, postags);
                    //    switch (structure)
                    //    {

                    //    }
                    //}
                    //if (objects[i] == "upon") { }
                    else if (words[i] == "with")
                    {
                        structure = idntifyPrepositional_Structure(words, i, postags);
                        switch (structure)
                        {
                            case "case1":
                                prepositionlaAmbiguitySolution += " " + aTransferAndGeneration_stg.IdetifyObjects_NotRelatedWith_Preposition(PStructure_start, PStructure_end, words, meaningDT, subject, verb);
                                if (words[i + 1] == "him")
                                {
                                    prepositionlaAmbiguitySolution += " তার সাথে ";
                                }
                                else if (words[i + 1] == "her")
                                {
                                    prepositionlaAmbiguitySolution += " তার সাথে ";
                                }
                                else if (words[i + 1] == "them")
                                {
                                    prepositionlaAmbiguitySolution += " তাদের সাথে ";
                                }
                                else if (words[i + 1] == "you")
                                {
                                    prepositionlaAmbiguitySolution += " তোমার সাথে ";
                                }
                                else if (words[i + 1] == "us")
                                {
                                    prepositionlaAmbiguitySolution += " আমাদের সাথে ";
                                }
                                else if (words[i + 1] == "me")
                                {
                                    prepositionlaAmbiguitySolution += " আমার সাথে ";
                                }
                                else
                                {
                                    nounMeaning = nounMeaning_Detection(i, 1, words, meaningDT);
                                    if (nounMeaning == "")
                                    {
                                        nounMeaning = words[i + 1];
                                        prepositionlaAmbiguitySolution += nounMeaning + " এর সাথে ";
                                    }
                                    else
                                    {
                                        prepositionlaAmbiguitySolution += nounMeaning + " দিয়ে ";
                                    }

                                }
                                break;

                            case "case2":
                                prepositionlaAmbiguitySolution += " " + aTransferAndGeneration_stg.IdetifyObjects_NotRelatedWith_Preposition(PStructure_start, PStructure_end, words, meaningDT, subject, verb);
                                nounMeaning = nounMeaning_Detection(i, 2, words, meaningDT);
                                if (words[i + 1] == "a" || words[i + 1] == "an")
                                {
                                    prepositionlaAmbiguitySolution += " একটি " + nounMeaning + " দিয়ে ";
                                }
                                else
                                {
                                    prepositionlaAmbiguitySolution += nounMeaning + " দিয়ে ";
                                }
                                break;
                            case "case7":
                                prepositionlaAmbiguitySolution += " " + aTransferAndGeneration_stg.IdetifyObjects_NotRelatedWith_Preposition(PStructure_start, PStructure_end, words, meaningDT, subject, verb);
                                nounMeaning = nounMeaning_Detection(i, 2, words, meaningDT);
                                if (words[i + 1] == "his")
                                {
                                    pronounMeaning = " তার ";
                                }
                                else if (words[i + 1] == "her")
                                {
                                    pronounMeaning = " তার ";
                                }
                                else if (words[i + 1] == "their")
                                {
                                    pronounMeaning = " তাদের ";
                                }
                                else if (words[i + 1] == "your")
                                {
                                    pronounMeaning = " তোমার ";
                                }
                                else if (words[i + 1] == "our")
                                {
                                    pronounMeaning = " আমাদের ";
                                }
                                else if (words[i + 1] == "my")
                                {
                                    pronounMeaning = " আমার ";
                                }
                                prepositionlaAmbiguitySolution += pronounMeaning + nounMeaning + " দিয়ে ";
                                break;
                            case "case24":
                                prepositionlaAmbiguitySolution += " " + aTransferAndGeneration_stg.IdetifyObjects_NotRelatedWith_Preposition(PStructure_start, PStructure_end, words, meaningDT, subject, verb);
                                nounMeaning = nounMeaning_Detection(i, 2, words, meaningDT);
                                if (words[i + 1] == "this")
                                {
                                    nounMeaning = " এই " + nounMeaning;
                                }
                                else if (words[i + 1] == "that")
                                {
                                    nounMeaning = " ঐ " + nounMeaning;
                                }
                                else if (words[i + 1] == "these")
                                {
                                    nounMeaning = " এই " + nounMeaning + " গুলো ";
                                }
                                else
                                {
                                    nounMeaning = " ঐ " + nounMeaning + " গুলো ";
                                }
                                prepositionlaAmbiguitySolution += nounMeaning + " দিয়ে ";
                                break;
                            case "case50":
                                prepositionlaAmbiguitySolution += " " + aTransferAndGeneration_stg.IdetifyObjects_NotRelatedWith_Preposition(PStructure_start, PStructure_end, words, meaningDT, subject, verb);
                                nounMeaning = " সব ";
                                nounMeaning += nounMeaning_Detection(i, 3, words, meaningDT);
                                prepositionlaAmbiguitySolution += nounMeaning + " দিয়ে ";
                                break;
                            case "case64":
                                prepositionlaAmbiguitySolution += " " + aTransferAndGeneration_stg.IdetifyObjects_NotRelatedWith_Preposition(PStructure_start, PStructure_end, words, meaningDT, subject, verb);
                                nounMeaning = nounMeaning_Detection(i, 1, words, meaningDT);
                                if (nounMeaning == "")
                                {
                                    nounMeaning = words[i + 1];
                                }
                                string noun2 = nounMeaning_Detection(i, 2, words, meaningDT);
                                if (noun2 == " ")
                                {
                                    noun2 = words[i + 1];
                                }
                                nounMeaning += nounMeaning + " " + noun2;
                                nounMeaning += " দিয়ে ";
                                prepositionlaAmbiguitySolution += nounMeaning;
                                break;
                            case "case66":
                                prepositionlaAmbiguitySolution += " " + aTransferAndGeneration_stg.IdetifyObjects_NotRelatedWith_Preposition(PStructure_start, PStructure_end, words, meaningDT, subject, verb);
                                if (words[i + 1] == "anybody")
                                {
                                    nounMeaning = " যে কারো ";
                                }
                                else if (words[i + 1] == "somebody")
                                {
                                    nounMeaning = " কারো ";
                                }
                                prepositionlaAmbiguitySolution += nounMeaning + " সাথে ";
                                break;

                            case "case67":
                                prepositionlaAmbiguitySolution += " " + aTransferAndGeneration_stg.IdetifyObjects_NotRelatedWith_Preposition(PStructure_start, PStructure_end, words, meaningDT, subject, verb);
                                nounMeaning = nounMeaning_Detection(i, 2, words, meaningDT);
                                nounMeaning += nounMeaning + " " + nounMeaning_Detection(i, 3, words, meaningDT);
                                nounMeaning += " দিয়ে ";
                                prepositionlaAmbiguitySolution += nounMeaning;
                                break;



                        }
                    }
                    else if (words[i] == "within")
                    {
                        structure = idntifyPrepositional_Structure(words, i, postags);
                        switch (structure)
                        {
                            case "case1":
                                prepositionlaAmbiguitySolution += " " + aTransferAndGeneration_stg.IdetifyObjects_NotRelatedWith_Preposition(PStructure_start, PStructure_end, words, meaningDT, subject, verb);
                                if (words[i + 1] == "him")
                                {
                                    prepositionlaAmbiguitySolution += " তার মধ্যে ";
                                }
                                else if (words[i + 1] == "himself")
                                {
                                    prepositionlaAmbiguitySolution += " তার মধ্যে ";
                                }
                                else if (words[i + 1] == "her")
                                {
                                    prepositionlaAmbiguitySolution += " তার মধ্যে ";
                                }
                                else if (words[i + 1] == "herself")
                                {
                                    prepositionlaAmbiguitySolution += " তার মধ্যে ";
                                }
                                else if (words[i + 1] == "them")
                                {
                                    prepositionlaAmbiguitySolution += " তাদের মধ্যে ";
                                }
                                else if (words[i + 1] == "themself")
                                {
                                    prepositionlaAmbiguitySolution += " তাদের মধ্যে ";
                                }
                                else if (words[i + 1] == "you")
                                {
                                    prepositionlaAmbiguitySolution += " তোমার মধ্যে ";
                                }
                                else if (words[i + 1] == "yourself")
                                {
                                    prepositionlaAmbiguitySolution += " তোমার মধ্যে ";
                                }
                                else if (words[i + 1] == "us")
                                {
                                    prepositionlaAmbiguitySolution += " আমাদের মধ্যে ";
                                }
                                else if (words[i + 1] == "me")
                                {
                                    prepositionlaAmbiguitySolution += " আমার মধ্যে ";
                                }
                                else if (words[i + 1] == "myself")
                                {
                                    prepositionlaAmbiguitySolution += " আমার মধ্যে ";
                                }
                                else
                                {
                                    nounMeaning = nounMeaning_Detection(i, 1, words, meaningDT);
                                    if (nounMeaning == "")
                                    {
                                        nounMeaning = words[i + 1];
                                    }
                                    prepositionlaAmbiguitySolution += nounMeaning + " এর মধ্যে ";
                                }
                                break;

                            case "case2":
                                prepositionlaAmbiguitySolution += " " + aTransferAndGeneration_stg.IdetifyObjects_NotRelatedWith_Preposition(PStructure_start, PStructure_end, words, meaningDT, subject, verb);
                                nounMeaning = nounMeaning_Detection(i, 2, words, meaningDT);
                                if (words[i + 1] == "a" || words[i + 1] == "an")
                                {
                                    prepositionlaAmbiguitySolution += " একটি " + nounMeaning + " এর মধ্যে ";
                                }
                                else
                                {
                                    prepositionlaAmbiguitySolution += nounMeaning + " এর মধ্যে ";
                                }
                                break;
                            case "case7":
                                prepositionlaAmbiguitySolution += " " + aTransferAndGeneration_stg.IdetifyObjects_NotRelatedWith_Preposition(PStructure_start, PStructure_end, words, meaningDT, subject, verb);
                                nounMeaning = nounMeaning_Detection(i, 2, words, meaningDT);
                                if (words[i + 1] == "his")
                                {
                                    pronounMeaning = " তার ";
                                }
                                else if (words[i + 1] == "her")
                                {
                                    pronounMeaning = " তার ";
                                }
                                else if (words[i + 1] == "their")
                                {
                                    pronounMeaning = " তাদের ";
                                }
                                else if (words[i + 1] == "your")
                                {
                                    pronounMeaning = " তোমার ";
                                }
                                else if (words[i + 1] == "our")
                                {
                                    pronounMeaning = " আমাদের ";
                                }
                                else if (words[i + 1] == "my")
                                {
                                    pronounMeaning = " আমার ";
                                }
                                prepositionlaAmbiguitySolution += pronounMeaning + nounMeaning + " এর মধ্যে ";
                                break;
                            case "case12":
                                prepositionlaAmbiguitySolution += " " + aTransferAndGeneration_stg.IdetifyObjects_NotRelatedWith_Preposition(PStructure_start, PStructure_end, words, meaningDT, subject, verb);
                                nounMeaning = nounMeaning_Detection(i, 2, words, meaningDT);
                                if (int.Parse(words[i + 1]) > 0)
                                {
                                    prepositionlaAmbiguitySolution += words[i + 1] + nounMeaning + " এর মধ্যে ";
                                }
                                else if (words[i + 1] == "a")
                                {
                                    prepositionlaAmbiguitySolution += "এক " + nounMeaning + " এর মধ্যে ";
                                }
                                else
                                {
                                    string numberMeaning = "";
                                    numberMeaning = nounMeaning_Detection(i, 1, words, meaningDT);
                                    prepositionlaAmbiguitySolution += numberMeaning + nounMeaning + " এর মধ্যে ";
                                }
                                break;

                            case "case67":
                                prepositionlaAmbiguitySolution += " " + aTransferAndGeneration_stg.IdetifyObjects_NotRelatedWith_Preposition(PStructure_start, PStructure_end, words, meaningDT, subject, verb);
                                nounMeaning = nounMeaning_Detection(i, 2, words, meaningDT);
                                nounMeaning += nounMeaning + " " + nounMeaning_Detection(i, 3, words, meaningDT);
                                nounMeaning += " এর মধ্যে ";
                                prepositionlaAmbiguitySolution += nounMeaning;
                                break;

                        }
                    }
                    else if (words[i] == "without")
                    {
                        structure = idntifyPrepositional_Structure(words, i, postags);
                        switch (structure)
                        {
                            case "case1":
                                prepositionlaAmbiguitySolution += " " + aTransferAndGeneration_stg.IdetifyObjects_NotRelatedWith_Preposition(PStructure_start, PStructure_end, words, meaningDT, subject, verb);
                                if (words[i + 1] == "him")
                                {
                                    prepositionlaAmbiguitySolution += " তাকে ছাড়া ";
                                }
                                else if (words[i + 1] == "himself")
                                {
                                    prepositionlaAmbiguitySolution += " তাকে ছাড়া ";
                                }
                                else if (words[i + 1] == "her")
                                {
                                    prepositionlaAmbiguitySolution += " তাকে ছাড়া ";
                                }
                                else if (words[i + 1] == "herself")
                                {
                                    prepositionlaAmbiguitySolution += " তাকে ছাড়া ";
                                }
                                else if (words[i + 1] == "them")
                                {
                                    prepositionlaAmbiguitySolution += " তাদের ছাড়া ";
                                }
                                else if (words[i + 1] == "themself")
                                {
                                    prepositionlaAmbiguitySolution += " তাদের ছাড়া ";
                                }
                                else if (words[i + 1] == "you")
                                {
                                    prepositionlaAmbiguitySolution += " তোমাকে ছাড়া ";
                                }
                                else if (words[i + 1] == "yourself")
                                {
                                    prepositionlaAmbiguitySolution += " তাকে ছাড়া ";
                                }
                                else if (words[i + 1] == "us")
                                {
                                    prepositionlaAmbiguitySolution += "আমাদের ছাড়া ";
                                }
                                else if (words[i + 1] == "me")
                                {
                                    prepositionlaAmbiguitySolution += " আমাকে ছাড়া ";
                                }
                                else if (words[i + 1] == "myself")
                                {
                                    prepositionlaAmbiguitySolution += " আমাকে ছাড়া ";
                                }
                                else
                                {
                                    nounMeaning = nounMeaning_Detection(i, 1, words, meaningDT);
                                    if (nounMeaning == "")
                                    {
                                        nounMeaning = words[i + 1];
                                    }
                                    prepositionlaAmbiguitySolution += nounMeaning + " ছাড়া ";
                                }
                                break;

                            case "case2":
                                prepositionlaAmbiguitySolution += " " + aTransferAndGeneration_stg.IdetifyObjects_NotRelatedWith_Preposition(PStructure_start, PStructure_end, words, meaningDT, subject, verb);
                                nounMeaning = nounMeaning_Detection(i, 2, words, meaningDT);
                                if (words[i + 1] == "a" || words[i + 1] == "an")
                                {
                                    prepositionlaAmbiguitySolution += " একটি " + nounMeaning + " ছাড়া ";
                                }
                                else
                                {
                                    prepositionlaAmbiguitySolution += nounMeaning + " টি  ছাড়া ";
                                }
                                break;
                            case "case7":
                                prepositionlaAmbiguitySolution += " " + aTransferAndGeneration_stg.IdetifyObjects_NotRelatedWith_Preposition(PStructure_start, PStructure_end, words, meaningDT, subject, verb);
                                nounMeaning = nounMeaning_Detection(i, 2, words, meaningDT);
                                if (words[i + 1] == "his")
                                {
                                    pronounMeaning = " তার ";
                                }
                                else if (words[i + 1] == "her")
                                {
                                    pronounMeaning = " তার ";
                                }
                                else if (words[i + 1] == "their")
                                {
                                    pronounMeaning = " তাদের ";
                                }
                                else if (words[i + 1] == "your")
                                {
                                    pronounMeaning = " তোমার ";
                                }
                                else if (words[i + 1] == "our")
                                {
                                    pronounMeaning = " আমাদের ";
                                }
                                else if (words[i + 1] == "my")
                                {
                                    pronounMeaning = " আমার ";
                                }
                                prepositionlaAmbiguitySolution += pronounMeaning + nounMeaning + " ছাড়া ";
                                break;

                        }
                    }
                    else if (words[i] == "to")
                    {
                        structure = idntifyPrepositional_Structure(words, i, postags);
                        switch (structure)
                        {

                            case "case1":
                                prepositionlaAmbiguitySolution += " " + aTransferAndGeneration_stg.IdetifyObjects_NotRelatedWith_Preposition(PStructure_start, PStructure_end, words, meaningDT, subject, verb);
                                if (words[i + 1] == "him")
                                {
                                    prepositionlaAmbiguitySolution += " তার কাছে ";
                                }
                                else if (words[i + 1] == "her")
                                {
                                    prepositionlaAmbiguitySolution += " তার কাছে ";
                                }
                                else if (words[i + 1] == "them")
                                {
                                    prepositionlaAmbiguitySolution += " তাদের কাছে ";
                                }
                                else if (words[i + 1] == "you")
                                {
                                    prepositionlaAmbiguitySolution += " তোমার কাছে ";
                                }
                                else if (words[i + 1] == "us")
                                {
                                    prepositionlaAmbiguitySolution += " আমাদের কাছে ";
                                }
                                else if (words[i + 1] == "me")
                                {
                                    prepositionlaAmbiguitySolution += " আমার কাছে ";
                                }
                                else
                                {
                                    nounMeaning = nounMeaning_Detection(i, 1, words, meaningDT);
                                    if (nounMeaning == "")
                                    {
                                        nounMeaning = words[i + 1];
                                    }
                                    prepositionlaAmbiguitySolution += nounMeaning + "এর কাছে ";
                                }
                                break;

                            case "case2":
                                prepositionlaAmbiguitySolution += " " + aTransferAndGeneration_stg.IdetifyObjects_NotRelatedWith_Preposition(PStructure_start, PStructure_end, words, meaningDT, subject, verb);
                                nounMeaning = nounMeaning_Detection(i, 2, words, meaningDT);
                                if (words[i + 1] == "a" || words[i + 1] == "an")
                                {
                                    prepositionlaAmbiguitySolution += " একটি " + nounMeaning + " এ ";
                                }
                                else
                                {
                                    prepositionlaAmbiguitySolution += nounMeaning + " এ ";
                                }
                                break;
                            case "case7":
                                prepositionlaAmbiguitySolution += " " + aTransferAndGeneration_stg.IdetifyObjects_NotRelatedWith_Preposition(PStructure_start, PStructure_end, words, meaningDT, subject, verb);
                                nounMeaning = nounMeaning_Detection(i, 2, words, meaningDT);
                                if (words[i + 1] == "his")
                                {
                                    pronounMeaning = " তার ";
                                }
                                else if (words[i + 1] == "her")
                                {
                                    pronounMeaning = " তার ";
                                }
                                else if (words[i + 1] == "their")
                                {
                                    pronounMeaning = " তাদের ";
                                }
                                else if (words[i + 1] == "your")
                                {
                                    pronounMeaning = " তোমার ";
                                }
                                else if (words[i + 1] == "our")
                                {
                                    pronounMeaning = " আমাদের ";
                                }
                                else if (words[i + 1] == "my")
                                {
                                    pronounMeaning = " আমার ";
                                }
                                if (words[i + 1] == "parents" || words[i + 1] == "father" || words[i + 1] == "mother" || words[i + 1] == "brother" || words[i + 1] == "sister" || words[i + 1] == "friend" || words[i + 1] == "wife" || words[i + 1] == "husband" || words[i + 1] == "uncle" || words[i + 1] == "aunty" || words[i + 1] == "father" || words[i + 1] == "son" || words[i + 1] == "daughter" || words[i + 1] == "maid" || words[i + 1] == "cousins" || words[i + 1] == "brothers" || words[i + 1] == "sisters" || words[i + 1] == "friends" || words[i + 1] == "wife" || words[i + 1] == "husband" || words[i + 1] == "uncles" || words[i + 1] == "aunty" || words[i + 1] == "father" || words[i + 1] == "sons" || words[i + 1] == "daughters" || words[i + 1] == "maids" || words[i + 1] == "cousins")
                                {
                                    prepositionlaAmbiguitySolution += pronounMeaning + nounMeaning + " এর কাছে ";
                                }
                                else
                                {
                                    prepositionlaAmbiguitySolution += pronounMeaning + nounMeaning + " এ ";
                                }
                                break;
                            case "case19":
                                prepositionlaAmbiguitySolution += " " + aTransferAndGeneration_stg.IdetifyObjects_NotRelatedWith_Preposition(PStructure_start, PStructure_end, words, meaningDT, subject, verb);
                                dayMeaning = dayMeaning_Detection(i, 1, words, meaningDT);
                                prepositionlaAmbiguitySolution += dayMeaning + " পর্যন্ত ";
                                break;
                            case "case64":
                                prepositionlaAmbiguitySolution += " " + aTransferAndGeneration_stg.IdetifyObjects_NotRelatedWith_Preposition(PStructure_start, PStructure_end, words, meaningDT, subject, verb);
                                nounMeaning = nounMeaning_Detection(i, 1, words, meaningDT);
                                if (nounMeaning == "")
                                {
                                    nounMeaning = words[i + 1];
                                }
                                string noun2 = nounMeaning_Detection(i, 2, words, meaningDT);
                                if (noun2 == " ")
                                {
                                    noun2 = words[i + 1];
                                }
                                nounMeaning += nounMeaning + " " + noun2;
                                nounMeaning += " পর্যন্ত ";
                                prepositionlaAmbiguitySolution += nounMeaning;
                                break;
                            case "case68":
                                prepositionlaAmbiguitySolution += " " + aTransferAndGeneration_stg.IdetifyObjects_NotRelatedWith_Preposition(PStructure_start, PStructure_end, words, meaningDT, subject, verb);
                                nounMeaning = words[i + 1];
                                nounMeaning += " থেকে ";
                                nounMeaning += words[i + 3];
                                nounMeaning += " পর্যন্ত ";
                                prepositionlaAmbiguitySolution += nounMeaning;
                                break;
                            case "case69":
                                prepositionlaAmbiguitySolution += " " + aTransferAndGeneration_stg.IdetifyObjects_NotRelatedWith_Preposition(PStructure_start, PStructure_end, words, meaningDT, subject, verb);
                                verbMeaning = verbMeaning_Detection(i, 1, words, meaningDT);
                                if (words[i + 2] == "this")
                                {
                                    nounMeaning = " এটি ";
                                    prepositionlaAmbiguitySolution += nounMeaning + verbMeaning + " এর জন্য ";
                                }
                                else if (words[i + 2] == "that")
                                {
                                    nounMeaning = " ঐটা ";
                                    prepositionlaAmbiguitySolution += nounMeaning + verbMeaning + " এর জন্য ";
                                }
                                else if (words[i + 2] == "these")
                                {
                                    nounMeaning = " এগুলো ";
                                    prepositionlaAmbiguitySolution += nounMeaning + verbMeaning + " এর জন্য ";
                                }
                                else if (words[i + 2] == "those")
                                {
                                    nounMeaning = " ঐগুলো ";
                                    prepositionlaAmbiguitySolution += nounMeaning + verbMeaning + " এর জন্য ";
                                }
                                else if (words[i + 2] == "it")
                                {
                                    nounMeaning = " এটি ";
                                    prepositionlaAmbiguitySolution += nounMeaning + verbMeaning + " এর জন্য ";
                                }
                                else if (words[i + 2] == "him")
                                {
                                    if (words[i + 1] == "meet")
                                    {
                                        nounMeaning = " তার সাথে ";
                                        prepositionlaAmbiguitySolution += nounMeaning + verbMeaning + " এর জন্য ";
                                    }
                                    else
                                    {
                                        nounMeaning = " তাকে ";
                                        prepositionlaAmbiguitySolution += nounMeaning + verbMeaning + " এর জন্য ";
                                    }

                                }
                                else if (words[i + 2] == "her")
                                {
                                    if (words[i + 1] == "meet")
                                    {
                                        nounMeaning = " তার সাথে ";
                                        prepositionlaAmbiguitySolution += nounMeaning + verbMeaning + " এর জন্য ";
                                    }
                                    else
                                    {
                                        nounMeaning = " তাকে ";
                                        prepositionlaAmbiguitySolution += nounMeaning + verbMeaning + " এর জন্য ";
                                    }
                                }
                                else if (words[i + 2] == "them")
                                {
                                    if (words[i + 1] == "meet")
                                    {
                                        nounMeaning = " তাদের সাথে ";
                                        prepositionlaAmbiguitySolution += nounMeaning + verbMeaning + " এর জন্য ";
                                    }
                                    else
                                    {
                                        nounMeaning = " তাদের ";
                                        prepositionlaAmbiguitySolution += nounMeaning + verbMeaning + " এর জন্য ";
                                    }
                                }
                                else if (words[i + 2] == "you")
                                {
                                    if (words[i + 1] == "meet")
                                    {
                                        nounMeaning = " তোমার সাথে ";
                                        prepositionlaAmbiguitySolution += nounMeaning + verbMeaning + " এর জন্য ";
                                    }
                                    else
                                    {
                                        nounMeaning = " তোমাকে ";
                                        prepositionlaAmbiguitySolution += nounMeaning + verbMeaning + " এর জন্য ";
                                    }
                                }
                                else if (words[i + 2] == "us")
                                {
                                    if (words[i + 1] == "meet")
                                    {
                                        nounMeaning = " আমাদের সাথে ";
                                        prepositionlaAmbiguitySolution += nounMeaning + verbMeaning + " এর জন্য ";
                                    }
                                    else
                                    {
                                        nounMeaning = " আমাদেরকে ";
                                        prepositionlaAmbiguitySolution += nounMeaning + verbMeaning + " এর জন্য ";
                                    }
                                }
                                else if (words[i + 2] == "me")
                                {
                                    if (words[i + 1] == "meet")
                                    {
                                        nounMeaning = " তার সাথে ";
                                        prepositionlaAmbiguitySolution += nounMeaning + verbMeaning + " এর জন্য ";
                                    }
                                    else
                                    {
                                        nounMeaning = " তাকে ";
                                        prepositionlaAmbiguitySolution += nounMeaning + verbMeaning + " এর জন্য ";
                                    }
                                }
                                else
                                {
                                    nounMeaning = nounMeaning_Detection(i, 1, words, meaningDT);
                                    if (words[i + 1] == "meet" && nounMeaning != " ")
                                    {
                                        prepositionlaAmbiguitySolution += nounMeaning + verbMeaning + " এর জন্য ";
                                    }
                                    else if (nounMeaning == "")
                                    {
                                        nounMeaning = words[i + 2];
                                        if (words[i + 1] == "meet")
                                        {
                                            nounMeaning += " এর সাথে ";
                                            prepositionlaAmbiguitySolution += nounMeaning + verbMeaning + " এর জন্য ";
                                        }
                                        else
                                        {
                                            nounMeaning += " কে ";
                                            prepositionlaAmbiguitySolution += nounMeaning + verbMeaning + " এর জন্য ";
                                        }
                                    }
                                }
                                break;
                            case "case70":
                                prepositionlaAmbiguitySolution += " " + aTransferAndGeneration_stg.IdetifyObjects_NotRelatedWith_Preposition(PStructure_start, PStructure_end, words, meaningDT, subject, verb);
                                verbMeaning = verbMeaning_Detection(i, 1, words, meaningDT);
                                prepositionlaAmbiguitySolution += verbMeaning + " এর জন্য ";
                                break;
                        }
                    }
                    else {/**/ }

                }
            }
            return prepositionlaAmbiguitySolution;
        }
        private string idntifyPrepositional_Structure(string[] objects, int prepositionIndex, string[] object_postags)
        {
            string rule = "";
            //to him,Fahim,me
            if (((object_postags[prepositionIndex + 1] == "PRP " && objects[prepositionIndex + 1] != "it") || objects[prepositionIndex + 1] == "her" || (object_postags[prepositionIndex + 1] == "NN " || object_postags[prepositionIndex + 1] == "NNS " || object_postags[prepositionIndex + 1] == "NNP " || object_postags[prepositionIndex + 1] == "NNPS " || object_postags[prepositionIndex + 1] == "PRP " || object_postags[prepositionIndex + 1] == "PRP$ ")))
            {
                PStructure_start = prepositionIndex;
                PStructure_end = prepositionIndex + 1;
                return rule = "case1";
            }
            //in the morning
            else if (objects[prepositionIndex + 1] == "the" && (objects[prepositionIndex + 2] == "morning" || objects[prepositionIndex + 2] == "evening" || objects[prepositionIndex + 2] == "afternoon"))
            {
                PStructure_start = prepositionIndex;
                PStructure_end = prepositionIndex + 2;
                return rule = "case10";
            }
            // in the house
            else if ((objects[prepositionIndex + 1] == "a" || objects[prepositionIndex + 1] == "an" || objects[prepositionIndex + 1] == "the") /*DT=article*/ && (object_postags[prepositionIndex + 2] == "NN " || object_postags[prepositionIndex + 2] == "NNS " || object_postags[prepositionIndex + 2] == "NNP " || object_postags[prepositionIndex + 2] == "NNPS " || object_postags[prepositionIndex + 2] == "PRP " || object_postags[prepositionIndex + 2] == "PRP$ "))
            {
                PStructure_start = prepositionIndex;
                PStructure_end = prepositionIndex + 2;
                return rule = "case2";
            }
            //to this,that,those,these,it(PRP)
            else if ((objects[prepositionIndex + 1] == "this" || objects[prepositionIndex + 1] == "that" || objects[prepositionIndex + 1] == "those" || objects[prepositionIndex + 1] == "these" || objects[prepositionIndex + 1] == "it"))
            {
                PStructure_start = prepositionIndex;
                PStructure_end = prepositionIndex + 1;
                return rule = "case5";
            }
            //in any house,behind that building
            else if ((objects[prepositionIndex + 1] == "any" || objects[prepositionIndex + 1] == "every" || objects[prepositionIndex + 1] == "both" || objects[prepositionIndex + 1] == "all") && (object_postags[prepositionIndex + 2] == "NN " || object_postags[prepositionIndex + 2] == "NNS " || object_postags[prepositionIndex + 2] == "NNP " || object_postags[prepositionIndex + 2] == "NNPS "))
            {
                PStructure_start = prepositionIndex;
                PStructure_end = prepositionIndex + 1;
                return rule = "case6";//also applicable for case 24
            }
            //in your house
            else if ((object_postags[prepositionIndex + 1] == "PRP$ ") && (object_postags[prepositionIndex + 1] == "NN " || object_postags[prepositionIndex + 2] == "NNS " || object_postags[prepositionIndex + 1] == "NNP " || object_postags[prepositionIndex + 1] == "NNPS "))
            {
                PStructure_start = prepositionIndex;
                PStructure_end = prepositionIndex + 2;
                return rule = "case7";
            }
            //in january
            else if ((objects[prepositionIndex + 1] == "January" || objects[prepositionIndex + 1] == "February" || objects[prepositionIndex + 1] == "March" || objects[prepositionIndex + 1] == "April" || objects[prepositionIndex + 1] == "May" || objects[prepositionIndex + 1] == "June" || objects[prepositionIndex + 1] == "July" || objects[prepositionIndex + 1] == "August" || objects[prepositionIndex + 1] == "September" || objects[prepositionIndex + 1] == "October" || objects[prepositionIndex + 1] == "November" || objects[prepositionIndex + 1] == "December"))
            {
                PStructure_start = prepositionIndex;
                PStructure_end = prepositionIndex + 1;
                return rule = "case8";
            }
            //at 6,six_am/pm
            else if ((object_postags[prepositionIndex + 1] == "CD am" || object_postags[prepositionIndex + 1] == "CD AM" || object_postags[prepositionIndex + 1] == "CD pm" || object_postags[prepositionIndex + 1] == "CD PM") || (object_postags[prepositionIndex + 1] == "CD " && (objects[prepositionIndex + 2] == "AM" || objects[prepositionIndex + 2] == "PM" || objects[prepositionIndex + 2] == "am" || objects[prepositionIndex + 2] == "pm")))
            {
                PStructure_start = prepositionIndex;
                PStructure_end = prepositionIndex + 2;
                return rule = "case8";
            }
            //in morning
            else if ((objects[prepositionIndex + 1] == "morning" || objects[prepositionIndex + 1] == "evening" || objects[prepositionIndex + 1] == "afternoon"))
            {
                PStructure_start = prepositionIndex;
                PStructure_end = prepositionIndex + 1;
                return rule = "case9";
            }

            //P+a+few+weeks,months....
            else if (objects[prepositionIndex + 1] == "a" && objects[prepositionIndex + 2] == "few" && (objects[prepositionIndex + 3] == "minutes" || objects[prepositionIndex + 3] == "hours" || objects[prepositionIndex + 3] == "days" || objects[prepositionIndex + 3] == "months" || objects[prepositionIndex + 3] == "weeks"))
            {
                PStructure_start = prepositionIndex;
                PStructure_end = prepositionIndex + 3;
                return rule = "case11";
            }
            //in a week/in 10 days....
            else if (objects[prepositionIndex + 1] == "a" || object_postags[prepositionIndex + 1] == "CD " && (objects[prepositionIndex + 2] == "minutes" || objects[prepositionIndex + 2] == "hours" || objects[prepositionIndex + 2] == "days" || objects[prepositionIndex + 2] == "months" || objects[prepositionIndex + 2] == "weeks"))
            {
                PStructure_start = prepositionIndex;
                PStructure_end = prepositionIndex + 2;
                return rule = "case12";
            }
            //of mine
            else if (objects[prepositionIndex + 1] == "mine")
            {
                PStructure_start = prepositionIndex;
                PStructure_end = prepositionIndex + 1;
                return rule = "case13";
            }
            // above 6%,10,two
            else if ((objects[prepositionIndex + 1] == "a" || object_postags[prepositionIndex + 1] == "CD " || object_postags[prepositionIndex + 1] == "CD %"))
            {
                PStructure_start = prepositionIndex;
                PStructure_end = prepositionIndex + 1;
                return rule = "case14";
            }
            //since going home
            else if ((object_postags[prepositionIndex + 1] == "VBG ") && (object_postags[prepositionIndex + 2] == "NN " || object_postags[prepositionIndex + 2] == "NNS " || object_postags[prepositionIndex + 2] == "NNP " || object_postags[prepositionIndex + 2] == "NNPS "))
            {
                PStructure_start = prepositionIndex;
                PStructure_end = prepositionIndex + 2;
                return rule = "case15";
            }
            //except for her book
            else if (objects[prepositionIndex + 1] == "for" && (object_postags[prepositionIndex + 2] == "PRP$ " || objects[prepositionIndex + 2] == "her") && (object_postags[prepositionIndex + 3] == "NN " || object_postags[prepositionIndex + 3] == "NNS " || object_postags[prepositionIndex + 3] == "NNP " || object_postags[prepositionIndex + 3] == "NNPS "))
            {
                PStructure_start = prepositionIndex;
                PStructure_end = prepositionIndex + 3;
                return rule = "case16";
            }
            //on one foot
            else if ((objects[prepositionIndex + 1] == "a" || objects[prepositionIndex + 1] == "an" || object_postags[prepositionIndex + 1] == "CD ") && (object_postags[prepositionIndex + 1] == "NN " || object_postags[prepositionIndex + 2] == "NNS " || object_postags[prepositionIndex + 2] == "NNP " || object_postags[prepositionIndex + 2] == "NNPS "))
            {
                PStructure_start = prepositionIndex;
                PStructure_end = prepositionIndex + 2;
                return rule = "case18";
            }
            //on Saturday
            else if ((objects[prepositionIndex + 1] == "saturday" || objects[prepositionIndex + 1] == "sunday" || objects[prepositionIndex + 1] == "monday" || objects[prepositionIndex + 1] == "tuesday" || objects[prepositionIndex + 1] == "wednesday" || objects[prepositionIndex + 1] == "thrustday" || objects[prepositionIndex + 1] == "friday"))
            {
                PStructure_start = prepositionIndex;
                PStructure_end = prepositionIndex + 1;
                return rule = "case19";
            }
            //on,to left
            else if ((objects[prepositionIndex + 1] == "Left" || objects[prepositionIndex + 1] == "Right" || objects[prepositionIndex + 1] == "Back" || objects[prepositionIndex + 1] == "Bottom" || objects[prepositionIndex + 1] == "left" || objects[prepositionIndex + 1] == "right" || objects[prepositionIndex + 1] == "back" || objects[prepositionIndex + 1] == "Right"))
            {
                PStructure_start = prepositionIndex;
                PStructure_end = prepositionIndex + 1;
                return rule = "case20";
            }
            else if (objects[prepositionIndex + 1] == "the" && (objects[prepositionIndex + 2] == "Left" || objects[prepositionIndex + 2] == "Right" || objects[prepositionIndex + 2] == "Back" || objects[prepositionIndex + 2] == "Bottom" || objects[prepositionIndex + 2] == "left" || objects[prepositionIndex + 2] == "right" || objects[prepositionIndex + 2] == "back" || objects[prepositionIndex + 2] == "Right"))
            {
                PStructure_start = prepositionIndex;
                PStructure_end = prepositionIndex + 2;
                return rule = "case21";
            }
            //like this house
            else if ((objects[prepositionIndex + 1] == "this" || objects[prepositionIndex + 1] == "that" || objects[prepositionIndex + 1] == "those" || objects[prepositionIndex + 1] == "these") && (object_postags[prepositionIndex + 2] == "NN " || object_postags[prepositionIndex + 2] == "NNS " || object_postags[prepositionIndex + 2] == "NNP " || object_postags[prepositionIndex + 2] == "NNPS "))
            {
                PStructure_start = prepositionIndex;
                PStructure_end = prepositionIndex + 2;
                return rule = "case24";
            }
            //like yours,theirs
            else if (objects[prepositionIndex + 1] == "yours" || objects[prepositionIndex + 1] == "theirs" || objects[prepositionIndex + 1] == "him" || objects[prepositionIndex + 1] == "ours")
            {
                PStructure_start = prepositionIndex;
                PStructure_end = prepositionIndex + 1;
                return rule = "case25";
            }
            //between Abid and Sahin
            else if ((object_postags[prepositionIndex + 1] == "NN " || object_postags[prepositionIndex + 1] == "NNS " || object_postags[prepositionIndex + 1] == "NNP " || object_postags[prepositionIndex + 1] == "NNPS ") && (objects[prepositionIndex + 2] == "and") && (object_postags[prepositionIndex + 3] == "NN " || object_postags[prepositionIndex + 3] == "NNS " || object_postags[prepositionIndex + 3] == "NNP " || object_postags[prepositionIndex + 3] == "NNPS "))
            {
                PStructure_start = prepositionIndex;
                PStructure_end = prepositionIndex + 3;
                return rule = "case26";
            }
            //between the Canada and the America
            else if (objects[prepositionIndex + 1] == "the" && (object_postags[prepositionIndex + 2] == "NN " || object_postags[prepositionIndex + 2] == "NNS " || object_postags[prepositionIndex + 2] == "NNP " || object_postags[prepositionIndex + 2] == "NNPS ") && (objects[prepositionIndex + 3] == "and") && objects[prepositionIndex + 4] == "the" && (object_postags[prepositionIndex + 5] == "NN " || object_postags[prepositionIndex + 5] == "NNS " || object_postags[prepositionIndex + 5] == "NNP " || object_postags[prepositionIndex + 5] == "NNPS "))
            {
                PStructure_start = prepositionIndex;
                PStructure_end = prepositionIndex + 5;
                return rule = "case27";
            }
            //between the 2/two books
            else if (objects[prepositionIndex + 1] == "the" && object_postags[prepositionIndex + 2] == "CD " && object_postags[prepositionIndex + 3] == "NNS ")
            {
                PStructure_start = prepositionIndex;
                PStructure_end = prepositionIndex + 2;
                return rule = "case28";
            }
            //since getting the book
            else if (object_postags[prepositionIndex + 1] == "VVG " && objects[prepositionIndex + 2] == "the" && (object_postags[prepositionIndex + 3] == "NN " || object_postags[prepositionIndex + 3] == "NNS " || object_postags[prepositionIndex + 3] == "NNP " || object_postags[prepositionIndex + 3] == "NNPS "))
            {
                PStructure_start = prepositionIndex;
                PStructure_end = prepositionIndex + 3;
                return rule = "case29";
            }
            //under an hour
            else if (objects[prepositionIndex + 1] == "an" && objects[prepositionIndex + 2] == "hour")
            {
                PStructure_start = prepositionIndex;
                PStructure_end = prepositionIndex + 1;
                return rule = "case30";
            }
            //concerning then,now
            else if ((objects[prepositionIndex + 1] == "now" || objects[prepositionIndex + 1] == "then"))
            {
                PStructure_start = prepositionIndex;
                PStructure_end = prepositionIndex + 1;
                return rule = "case31";
            }
            //in summer
            else if ((objects[prepositionIndex + 1] == "summer" || objects[prepositionIndex + 1] == "spring" || objects[prepositionIndex + 1] == "fall" || objects[prepositionIndex + 1] == "rainy"))
            {
                PStructure_start = prepositionIndex;
                PStructure_end = prepositionIndex + 1;
                return rule = "case32";
            }
            //unlike most systems
            else if ((objects[prepositionIndex + 1] == "most") && (object_postags[prepositionIndex + 2] == "NN " || object_postags[prepositionIndex + 2] == "NNS " || object_postags[prepositionIndex + 2] == "NNP " || object_postags[prepositionIndex + 2] == "NNPS "))
            {
                PStructure_start = prepositionIndex;
                PStructure_end = prepositionIndex + 2;
                return rule = "case35";
            }
            //without some tools
            else if ((objects[prepositionIndex + 1] == "any" || objects[prepositionIndex + 1] == "some" || objects[prepositionIndex + 1] == "all" || objects[prepositionIndex + 1] == "other") && (object_postags[prepositionIndex + 2] == "NN " || object_postags[prepositionIndex + 2] == "NNS " || object_postags[prepositionIndex + 2] == "NNP " || object_postags[prepositionIndex + 2] == "NNPS "))
            {
                PStructure_start = prepositionIndex;
                PStructure_end = prepositionIndex + 2;
                return rule = "case36";
            }
            //without some other seeds
            else if ((objects[prepositionIndex + 1] == "any" || objects[prepositionIndex + 1] == "some" || objects[prepositionIndex + 1] == "all") && (objects[prepositionIndex + 2] == "other") && (object_postags[prepositionIndex + 3] == "NN " || object_postags[prepositionIndex + 3] == "NNS " || object_postags[prepositionIndex + 3] == "NNP " || object_postags[prepositionIndex + 3] == "NNPS "))
            {
                PStructure_start = prepositionIndex;
                PStructure_end = prepositionIndex + 3;
                return rule = "case42";
            }
            //wthout going any house
            else if (object_postags[prepositionIndex + 1] == "VBG " && (object_postags[prepositionIndex + 1] == "any" || object_postags[prepositionIndex + 1] == "some") && (object_postags[prepositionIndex + 3] == "NN " || object_postags[prepositionIndex + 3] == "NNS " || object_postags[prepositionIndex + 3] == "NNP " || object_postags[prepositionIndex + 3] == "NNPS "))
            {
                PStructure_start = prepositionIndex;
                PStructure_end = prepositionIndex + 3;
                return rule = "case39";
            }
            //for more systems
            else if ((objects[prepositionIndex + 1] == "more") && (object_postags[prepositionIndex + 2] == "NN " || object_postags[prepositionIndex + 2] == "NNS " || object_postags[prepositionIndex + 2] == "NNP " || object_postags[prepositionIndex + 2] == "NNPS "))
            {
                PStructure_start = prepositionIndex;
                PStructure_end = prepositionIndex + 2;
                return rule = "case43";
            }
            //for that/this one
            else if ((objects[prepositionIndex + 1] == "this" || objects[prepositionIndex + 1] == "that" || objects[prepositionIndex + 1] == "those" || objects[prepositionIndex + 1] == "these") && objects[prepositionIndex + 2] == "one")
            {
                PStructure_start = prepositionIndex;
                PStructure_end = prepositionIndex + 2;
                return rule = "case44";
            }
            else if ((object_postags[prepositionIndex + 1] == "NN " || object_postags[prepositionIndex + 1] == "NNS " || object_postags[prepositionIndex + 1] == "NNP " || object_postags[prepositionIndex + 1] == "NNPS ") && objects[prepositionIndex + 2] == "to" && (object_postags[prepositionIndex + 3] == "NN " || object_postags[prepositionIndex + 3] == "NNS " || object_postags[prepositionIndex + 3] == "NNP " || object_postags[prepositionIndex + 3] == "NNPS "))
            {
                PStructure_start = prepositionIndex;
                PStructure_end = prepositionIndex + 3;
                return rule = "case46";
            }
            else if (object_postags[prepositionIndex + 1] == "CD " && (object_postags[prepositionIndex + 2] == "NN " || object_postags[prepositionIndex + 2] == "NNS " || object_postags[prepositionIndex + 2] == "NNP " || object_postags[prepositionIndex + 2] == "NNPS ") && objects[prepositionIndex + 3] == "to" && object_postags[prepositionIndex + 4] == "CD " && (object_postags[prepositionIndex + 5] == "NN " || object_postags[prepositionIndex + 5] == "NNS " || object_postags[prepositionIndex + 5] == "NNP " || object_postags[prepositionIndex + 5] == "NNPS "))
            {
                PStructure_start = prepositionIndex;
                PStructure_end = prepositionIndex + 5;
                return rule = "case47";
            }
            else if (objects[prepositionIndex + 1] == "a" && (objects[prepositionIndex + 2] == "few" && (objects[prepositionIndex + 3] == "days" || objects[prepositionIndex + 3] == "months" || objects[prepositionIndex + 3] == "hours" || objects[prepositionIndex + 3] == "seconds" || objects[prepositionIndex + 3] == "moments")))
            {
                PStructure_start = prepositionIndex;
                PStructure_end = prepositionIndex + 3;
                return rule = "case49";
            }
            else if ((object_postags[prepositionIndex + 1] == "IN " || object_postags[prepositionIndex + 1] == "TO ") && objects[prepositionIndex + 2] == "all" && objects[prepositionIndex + 3] == "the" && (object_postags[prepositionIndex + 4] == "NN " || object_postags[prepositionIndex + 4] == "NNS " || object_postags[prepositionIndex + 4] == "NNP " || object_postags[prepositionIndex + 4] == "NNPS "))
            {
                PStructure_start = prepositionIndex;
                PStructure_end = prepositionIndex + 3;
                return rule = "case50";
            }
            else if ((object_postags[prepositionIndex + 1] == "IN " || object_postags[prepositionIndex + 1] == "TO ") && objects[prepositionIndex + 2] == "all" && (object_postags[prepositionIndex + 4] == "NN " || object_postags[prepositionIndex + 4] == "NNS " || object_postags[prepositionIndex + 4] == "NNP " || object_postags[prepositionIndex + 4] == "NNPS "))
            {
                PStructure_start = prepositionIndex;
                PStructure_end = prepositionIndex + 2;
                return rule = "case51";
            }
            else if ((object_postags[prepositionIndex + 1] == "NN " || object_postags[prepositionIndex + 1] == "NNS " || object_postags[prepositionIndex + 1] == "NNP " || object_postags[prepositionIndex + 1] == "NNPS ") && (object_postags[prepositionIndex + 2] == "IN " || object_postags[prepositionIndex + 2] == "TO ") && (object_postags[prepositionIndex + 3] == "NN " || object_postags[prepositionIndex + 3] == "NNS " || object_postags[prepositionIndex + 3] == "NNP " || object_postags[prepositionIndex + 3] == "NNPS "))
            {
                PStructure_start = prepositionIndex - 1;
                PStructure_end = prepositionIndex + 1;
                return rule = "case52";
            }
            else if ((object_postags[prepositionIndex + 1] == "NN " || object_postags[prepositionIndex + 1] == "NNS " || object_postags[prepositionIndex + 1] == "NNP " || object_postags[prepositionIndex + 1] == "NNPS ") && (object_postags[prepositionIndex + 2] == "IN " || object_postags[prepositionIndex + 2] == "TO ") && objects[prepositionIndex + 3] == "the" && (object_postags[prepositionIndex + 4] == "NN " || object_postags[prepositionIndex + 4] == "NNS " || object_postags[prepositionIndex + 4] == "NNP " || object_postags[prepositionIndex + 4] == "NNPS "))
            {
                PStructure_start = prepositionIndex - 1;
                PStructure_end = prepositionIndex + 2;
                return rule = "case53";
            }
            else if (objects[prepositionIndex + 1] == "air" || objects[prepositionIndex + 1] == "land" || objects[prepositionIndex + 1] == "sea")
            {
                PStructure_start = prepositionIndex;
                PStructure_end = prepositionIndex + 1;
                return rule = "case54";
            }
            else if (objects[prepositionIndex + 1] == "tomorrow" || objects[prepositionIndex + 1] == "yesterday" || objects[prepositionIndex + 1] == "today" || objects[prepositionIndex + 1] == "now")
            {
                PStructure_start = prepositionIndex;
                PStructure_end = prepositionIndex + 1;
                return rule = "case55";
            }
            else if ((objects[prepositionIndex + 1] == "this" || objects[prepositionIndex + 1] == "that" || objects[prepositionIndex + 1] == "these" || objects[prepositionIndex + 1] == "those") && (object_postags[prepositionIndex + 2] == "NN " || object_postags[prepositionIndex + 2] == "NNS " || object_postags[prepositionIndex + 2] == "NNP " || object_postags[prepositionIndex + 2] == "NNPS "))
            {
                PStructure_start = prepositionIndex;
                PStructure_end = prepositionIndex + 2;
                return rule = "case56";
            }
            else if (objects[prepositionIndex + 1] == "outside" && objects[prepositionIndex + 2] == "of" && object_postags[prepositionIndex + 3] == "DT " && (object_postags[prepositionIndex + 4] == "NN " || object_postags[prepositionIndex + 4] == "NNS " || object_postags[prepositionIndex + 4] == "NNP " || object_postags[prepositionIndex + 4] == "NNPS "))
            {
                PStructure_start = prepositionIndex;
                PStructure_end = prepositionIndex + 3;
                return rule = "case58";
            }
            else if (objects[prepositionIndex + 1] == "anything" || objects[prepositionIndex + 1] == "everything" || objects[prepositionIndex + 1] == "nothing")
            {
                PStructure_start = prepositionIndex;
                PStructure_end = prepositionIndex + 1;
                return rule = "case59";
            }
            //concerning the future of the company
            else if (objects[prepositionIndex + 1] == "the" && (object_postags[prepositionIndex + 2] == "NN " || object_postags[prepositionIndex + 2] == "NNS " || object_postags[prepositionIndex + 2] == "NNP " || object_postags[prepositionIndex + 2] == "NNPS ") && objects[prepositionIndex + 3] == "of" && objects[prepositionIndex + 4] == "the" && (object_postags[prepositionIndex + 5] == "NN " || object_postags[prepositionIndex + 5] == "NNS " || object_postags[prepositionIndex + 5] == "NNP " || object_postags[prepositionIndex + 5] == "NNPS "))
            {
                PStructure_start = prepositionIndex;
                PStructure_end = prepositionIndex + 5;
                return rule = "case61";
            }
            //since then ,from then 
            else if (objects[prepositionIndex + 1] == "then")
            {
                PStructure_start = prepositionIndex;
                PStructure_end = prepositionIndex + 1;
                return rule = "case62";
            }
            else if ((object_postags[prepositionIndex + 1] == "PRP " || object_postags[prepositionIndex + 1] == "NN " || object_postags[prepositionIndex + 1] == "NNS " || object_postags[prepositionIndex + 1] == "NNP " || object_postags[prepositionIndex + 1] == "NNPS ") && (object_postags[prepositionIndex + 2] == "VB " || object_postags[prepositionIndex + 2] == "VBZ "))
            {
                PStructure_start = prepositionIndex;
                PStructure_end = prepositionIndex + 2;
                return rule = "case63";
            }
            //towards china gate
            else if (object_postags[prepositionIndex + 1] == "NN " && object_postags[prepositionIndex + 2] == "NN ")
            {
                PStructure_start = prepositionIndex;
                PStructure_end = prepositionIndex + 2;
                return rule = "case64";
            }
            //until the bus comes
            else if ((objects[prepositionIndex + 1] == "a" || objects[prepositionIndex + 1] == "an" || objects[prepositionIndex + 1] == "the") && (object_postags[prepositionIndex + 2] == "NN " || object_postags[prepositionIndex + 2] == "NNS " || object_postags[prepositionIndex + 2] == "NNP " || object_postags[prepositionIndex + 2] == "NNPS ") && (object_postags[prepositionIndex + 3] == "VB " || object_postags[prepositionIndex + 3] == "VBZ " || object_postags[prepositionIndex + 3] == "VBP "))
            {

                PStructure_start = prepositionIndex;
                PStructure_end = prepositionIndex + 3;
                return rule = "case65";
            }
            //with anybody
            else if (objects[prepositionIndex + 1] == "anybody" || objects[prepositionIndex + 1] == "somebody")
            {
                PStructure_start = prepositionIndex;
                PStructure_end = prepositionIndex + 1;
                return rule = "case66";
            }
            //with the black panther
            else if (objects[prepositionIndex + 1] == "the" && object_postags[prepositionIndex + 2] == "NN " && object_postags[prepositionIndex + 3] == "NN ")
            {
                PStructure_start = prepositionIndex;
                PStructure_end = prepositionIndex + 3;
                return rule = "case67";
            }
            //5 to 10
            else if (object_postags[prepositionIndex + 1] == "CD " && object_postags[prepositionIndex + 3] == "CD ")
            {
                PStructure_start = prepositionIndex - 1;
                PStructure_end = prepositionIndex + 1;
                return rule = "case68";
            }
            // to meet him/fahim
            else if ((object_postags[prepositionIndex + 1] == "VB " || object_postags[prepositionIndex + 1] == "VBZ " || object_postags[prepositionIndex + 1] == "VBP ") && (objects[prepositionIndex + 3] == "this" || objects[prepositionIndex + 3] == "that" || objects[prepositionIndex + 3] == "those" || objects[prepositionIndex + 3] == "these" || object_postags[prepositionIndex + 3] == "NN " || object_postags[prepositionIndex + 3] == "NNS " || object_postags[prepositionIndex + 3] == "NNP " || object_postags[prepositionIndex + 3] == "NNPS " || object_postags[prepositionIndex + 3] == "PRP " || object_postags[prepositionIndex + 3] == "PRP$ "))
            {
                PStructure_start = prepositionIndex;
                PStructure_end = prepositionIndex + 2;
                return rule = "case69";
            }
            //to get
            else if (object_postags[prepositionIndex + 1] == "VB " || object_postags[prepositionIndex + 1] == "VBZ " || object_postags[prepositionIndex + 1] == "VBP ")
            {
                PStructure_start = prepositionIndex;
                PStructure_end = prepositionIndex + 1;
                return rule = "case70";
            }
            //going to him,fahim,dhaka
            //else if (object_postags[prepositionIndex +1] == "VBG " && (object_postags[prepositionIndex + 3] == "NN" || object_postags[prepositionIndex + 3] == "NNS" || object_postags[prepositionIndex + 3] == "NNP" || object_postags[prepositionIndex + 3] == "NNPS" || object_postags[prepositionIndex + 3] == "PRP" || object_postags[prepositionIndex + 3] == "PRP$ "))
            //{
            //    return rule = "case71";
            //}

            else
            {
                return rule;
            }

        }
        private string nounMeaning_Detection(int i, int caseFact, string[] words, DataTable meaningDT)
        {
            int j = 0;
            int no_of_objects = meaningDT.Rows.Count;
            string nounMeaning = "";
            while (j < no_of_objects)
            {
                if (words[i + caseFact] == meaningDT.Rows[j][0].ToString())
                {
                    nounMeaning = meaningDT.Rows[j][1].ToString();
                }
                j++;
            }
            return nounMeaning;

        }
        private string verbMeaning_Detection(int i, int caseFact, string[] words, DataTable meaningDT)
        {

            int j = 0;
            int no_of_objects = meaningDT.Rows.Count;
            string VERB_Meaning = "";
            while (j < no_of_objects)
            {

                if (words[i + 1] == meaningDT.Rows[j][0].ToString())

                    if (words[i + caseFact] == meaningDT.Rows[j][0].ToString())

                    {
                        VERB_Meaning = meaningDT.Rows[j][1].ToString();
                    }
                j++;
            }
            return VERB_Meaning;

        }
        private string month_seasonDetection(int i, int caseFact, string[] words, DataTable meaningDTT)
        {
            int j = 0;
            int no_of_objects = meaningDTT.Rows.Count;
            string monthOR_season = "";
            while (j < no_of_objects)
            {
                if (words[i + caseFact] == meaningDTT.Rows[j][0].ToString())
                {
                    monthOR_season = meaningDTT.Rows[j][1].ToString();
                }
                j++;
            }
            return monthOR_season;
        }
        private string dayMeaning_Detection(int i, int caseFact, string[] words, DataTable meaningDTT)
        {
            int j = 0;
            int no_of_objects = meaningDTT.Rows.Count;
            string day = "";
            while (j < no_of_objects)
            {
                if (words[i + caseFact] == meaningDTT.Rows[j][0].ToString())
                {
                    day = meaningDTT.Rows[j][1].ToString();
                }
                j++;
            }
            return day;
        }
    }
}