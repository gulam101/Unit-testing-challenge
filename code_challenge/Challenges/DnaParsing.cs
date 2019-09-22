using System;
namespace code_challenge
{
    public class DnaParsing
    {
        /*
         * The Problem
         * A string is simply an ordered collection of symbols selected from some alphabet and formed into a word; the length of a string is the number of symbols that it contains.
         * An example of a length 21 DNA string (whose alphabet contains the symbols 'A', 'C', 'G', and 'T') is "ATGCTTCAGAAAGGTCTTACG."
         * Given: A DNA string s of length at most 1000 nt.
         *
         * Return: Four integers (separated by spaces) counting the respective number of times that the symbols 'A', 'C', 'G', and 'T' occur in s.
         *
         * Sample Dataset
         * AGCTTTTCATTCTGACTGCAACGGGCAATATGTCTCTGTGTGGATTAAAAAAAGAGTGTCTGATAGCAGC
         *
         * Sample Output
         * 20 12 17 21
         */

        /*
         * The Challenge
         *
         * You will need to implement the counters as per the name in names in the return statement.
         * You will then need to create a loop to parse each Char within the string and count them
         * by passing the values to counters.
         *
         * To begin highlight the whole method skeleton below and uncomment using ctrl + / or cmd + /
         */

        // Uncomment the below method and begin to implement the sequence counter
         
        public string SequenceCount(string sequence)
        {
            //    // Implement the counters ensure the names are the same as in the return statement i.e. aCount
            int aCount = 0;
            int cCount = 0;
            int gCount = 0;
            int tCount = 0;

            //    // Implement the loop to parse the string below here:
            foreach (char x in sequence)
            {
                if (x == 'A')
                {
                    aCount++;
                }
                else if (x == 'C')
                {
                    cCount++;
                }
                else if (x == 'G')
                {
                    gCount++;
                }
                else if (x == 'T')
                {
                    tCount++;
                }
            }
            // IMPORTANT - uncomment but do not change the below return statement
            return aCount + " " + cCount + " " + gCount + " " + tCount;
        }
    }
}
