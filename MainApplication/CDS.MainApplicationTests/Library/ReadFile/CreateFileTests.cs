using Microsoft.VisualStudio.TestTools.UnitTesting;
using CDS.MainApplication.Library.ReadFile;
using System;
using System.Collections.Generic;
using System.Text;
using Grpc.Core;

namespace CDS.MainApplication.Library.ReadFile.Tests
{
    [TestClass()]
    public class CreateFileTests
    {
        [TestMethod()]
        public void CreateFilesTest()
        {
            //Arrange
            CreateFile createFile = new CreateFile();
            string targetpath = @"C:\Users\Dean\Source\Repos\CrownDataSystems\MainApplication\MainApplication\Files\";
            
            //Act
            string result =  createFile.CreateFiles(targetpath);
           
            //Assert
            Assert.IsTrue(result == "success");
        }
    }
}