using System;
using System.Collections.Generic;

namespace RNATranscriptionModule
{
    public static class RnaTranscription
    {
        public static string ToRna(string nucleotide)
        {
            Dictionary<char, char> rna_replace = new Dictionary<char, char>(){
                {'G','C'}, {'C','G'}, {'T','A'}, {'A','U'}
            };
            char [] rna_char = nucleotide.ToCharArray();
            for(int i=0; i<rna_char.Length;i++)
            {
                char newstrand;
                if (rna_replace.TryGetValue(nucleotide[i], out newstrand))
                rna_char[i] = newstrand;
            }
            string new_nucleotide = new string(rna_char);
            return new_nucleotide;
        }
    }
}
