﻿using System.Linq;

namespace VaderSharp
{
    internal static class StringExtensions
    {
        /// <summary>
        /// Determine if word is ALL CAPS
        /// </summary>
        /// <param name="word"></param>
        /// <returns></returns>
        public static bool IsUpper(this string word)
        {
            return !word.Any(char.IsLower);
        }

        /// <summary>
        /// Removes punctuation from word
        /// </summary>
        /// <param name="word"></param>
        /// <returns></returns>
        public static string RemovePunctuation(this string word)
        {
            return new string(word.Where(c => !char.IsPunctuation(c)).ToArray());
        }
    }
}
