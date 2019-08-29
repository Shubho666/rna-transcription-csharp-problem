using System;
using System.Collections.Generic;
using System.Linq;

namespace RNATranscriptionModule
{
    public static class RnaTranscription
    {
        public static string ToRna(string nucleotide)
        {
            //throw new NotImplementedException("You need to implement this function.");
            
            var subs = new Dictionary<string, string> { {"G","W"},{"C","X"},{"T","Y"},{"A","Z"} };
            var subs1 = new Dictionary<string, string> { {"W","C"},{"X","G"},{"Y","A"},{"Z","U"} };
        string va = nucleotide;
        va = subs.Aggregate(va, (result, s) => result.Replace(s.Key, s.Value));
        va=subs1.Aggregate(va, (result, s) => result.Replace(s.Key, s.Value));
        return va;
        }


        public static void Main(string[] args) 
        {
        //    ToRna("ACSKKFKS");
        }
    }
}
