using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mood_Analyzer_Problem
{
    public class MoodAnalyzer
    {
            string message;
            public MoodAnalyzer(string message)
            {
                this.message = message;
            }
            public string AnalyseMood()
            {
                if (message.Contains("sad"))
                {
                    return "sad";
                }
                else
                {
                    return "happy";
                }
            }
        }
    }
            
