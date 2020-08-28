using System;
using System.Collections.Generic;
using System.Linq;

namespace CDS.MainApplication.Library.StringParser
{
    public class StringParser
    {
        public List<string> ParseString(
           string stringLine = @"Lorem\ipsum\dolor\sit\amet\consectetur\adipiscing\elit",
           string parseChar = @"\")
        {
            var result = new List<string>();
            try{
              result= stringLine.Split(parseChar).ToList();
            }
            catch (Exception ex)
            {
                throw;
            }
         
            return result;
        }
    }
}
