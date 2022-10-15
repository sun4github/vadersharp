﻿namespace VaderSharp.Models
{
    /// <summary>
    /// A model to represent the result of analysis.
    /// </summary>
    public class SentimentAnalysisResults
    {
        /// <summary>
        /// The proportion of words in the sentence with negative valence.
        /// </summary>
        public double Negative { get; set; }

        /// <summary>
        /// The proportion of words in the sentence with no valence.
        /// </summary>
        public double Neutral { get; set; }

        /// <summary>
        /// The proportion of words in the sentence with positive valence.
        /// </summary>
        public double Positive { get; set; }
        
        /// <summary>
        /// Normalized sentiment score between -1 and 1.
        /// </summary>
        public double Compound { get; set; }
    }
}
