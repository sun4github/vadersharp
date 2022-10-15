using System;
using System.Collections.Generic;
using System.Text;

namespace VaderSharp.Models
{
    internal class SiftSentiments
    {
        public double PosSum { get; set; }
        public double NegSum { get; set; }
        public int NeuCount { get; set; }
    }
}
