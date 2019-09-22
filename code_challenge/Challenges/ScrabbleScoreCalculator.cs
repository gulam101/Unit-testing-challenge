using System;
using System.Collections.Generic;
using System.Linq;

namespace code_challenge.Challenges
{
    public class ScrabbleScoreCalculator
    {

        /*
         * Given the below scoring list create a Scrabble word calculator that will provide the correct scores dependent on the string provided.
         *         
         * Letter                             Value
         * A, E, I, O, U, L, N, R, S, T       1
         * D, G                               2
         * B, C, M, P                         3
         * F, H, V, W, Y                      4
         * K                                  5
         * J, X                               8
         * Q, Z                               10
         */

        // The character arrays have already been set up for you below
        private char[] OnePointValues = { 'a', 'e', 'i', 'o', 'u', 'l', 'n', 'r', 's', 't' };
        private char[] TwoPointValues = { 'd', 'g' };
        private char[] ThreePointValues = { 'b', 'c', 'm', 'p' };
        private char[] FourPointValues = { 'f', 'h', 'v', 'w', 'y' };
        private char[] FivePointValues = { 'k' };
        private char[] EightPointValues = { 'j', 'x' };
        private char[] TenPointValues = { 'q', 'z' };

        // uncomment the method below that will accept a string argument and expect an int to be returned

        public int WordScoreCheck(string word)
        {

            //Declare var
            int score = 0;

            for (int index = 0; index < word.Length; index++)
            {
                char c = word[index];

                if (Contains(c, OnePointValues))
                {
                    score += 1;
                }

                else if (Contains(c, TwoPointValues))
                {
                    score += 2;
                }

                else if (Contains(c, ThreePointValues))
                {
                    score += 3;
                }

                else if (Contains(c, FourPointValues))
                {
                    score += 4;
                }

                else if (Contains(c, FivePointValues))
                {
                    score += 5;
                }

                else if (Contains(c, EightPointValues))
                {
                    score += 8;
                }

                else if (Contains(c, TenPointValues))
                {
                    score += 10;
                }

            }
            return score;
        }
        private bool Contains(char ch, char[] arr)
        {
            for (int e = 0; e < arr.Length; e++)
            {
                if (ch == arr[e])
                {
                    return true;
                }
            }

            return false;
        }
    }
}