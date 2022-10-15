using VaderSharp.Models;

namespace VaderSharp
{
    /// <summary>
    /// Main Sentiment Analysis interface
    /// </summary>
    public interface ISentimentIntensityAnalyzer
    {
        /// <summary>
        /// Main method to perform sentiment analysis
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        SentimentAnalysisResults PolarityScores(string input);
    }
}