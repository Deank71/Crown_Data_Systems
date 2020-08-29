using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question5.Library
{
    public class StringParser
    {
        public List<string> GenerateList(
         string stringLine,
         string parseChar )
        {
            var result = new List<string>();
            try
            {
                result = ParseString(stringLine, parseChar);
            }
            catch (Exception ex)
            {
                result.Add(ex.Message);
            }

            return result;
        }

        private static List<string> ParseString(string stringLine, string parseChar)
        {
            Char parser;
            Char.TryParse(parseChar, out parser);
            return stringLine.Split(parser).ToList();
        }
    }
}
