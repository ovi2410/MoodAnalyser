﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UC6_InvokeMethod
{
    public class MoodAnalyser
    {
        string message;
        public MoodAnalyser()
        {
            Console.WriteLine("Default constructor");
        }
        public MoodAnalyser(string message)
        {
            this.message = message;
        }

        public string AnalyzeMood()
        {
            try
            {
                if (message.Equals(string.Empty))
                {
                    throw new CustomException(CustomException.ExceptionType.EMPTY_EXCEPTION, "Mood should not be empty");
                }
                else if (message.ToLower().Contains("happy"))
                {
                    return "happy";
                }
                else
                {
                    return "sad";
                }
            }
            catch (NullReferenceException)
            {
                throw new CustomException(CustomException.ExceptionType.NULL_EXCEPTION, "Mood should not be null");
            }
        }
    }
}
