using Microsoft.VisualStudio.TestTools.UnitTesting;
using CDS.MainApplication.Library.StringParser;
using System;
using System.Collections.Generic;
using System.Text;

namespace CDS.MainApplication.Library.StringParser.Tests
{
    [TestClass()]
    public class StringParserTests
    {
        [TestMethod()]
        public void ParseStringTest()
        {
            StringParser stringParser = new StringParser();
          var result =  stringParser.ParseString();
            Assert.IsTrue(result.Count == 8);

            string stringLine = @"Lorem\ipsum\dolor\sit";
           result = stringParser.ParseString(stringLine);
            Assert.IsTrue(result.Count == 4);

            stringLine = @"Lorem,ipsum,dolor,sit";
            var parseChar = ",";
            result = stringParser.ParseString(stringLine,parseChar);
            Assert.IsTrue(result.Count == 4);

        }
    }
}