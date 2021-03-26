using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnaylserWithCore
{
    public class MoodAnaylser
    {
        public string message;
        public MoodAnaylser(string message)
        {
            this.message = message;
        }
        public string anaylseMood()
        {
            try
            {
                if (this.message.Contains("sad"))
                {
                    return "sad";
                }
                else
                {
                    return "happy";
                }
            }
            catch
            {
                return "happy";
            }
        }
    }
}