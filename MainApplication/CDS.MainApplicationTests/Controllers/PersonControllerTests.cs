using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using CDS.Repository.UnitOfWork;
using CDS.Data.Models;
using Moq;
using CDS.Repository.Repositories.Inerfaces;
using Microsoft.AspNetCore.Mvc;

namespace MainApplication.Controllers.Tests
{
    [TestClass()]
    public class PersonControllerTests
    {
       private PersonController personController;
        [TestInitialize]
        public void Initialize()
        {
            Mock<IUnitOfWork> unitOfWork = new Mock<IUnitOfWork>();
            unitOfWork.Setup(u => u.Person).Returns(new Mock<IPersonRepository>().Object);
            personController = new PersonController(unitOfWork.Object);   
        }

        [TestMethod()]
        public void GetTest()
        {
            // Arrange
            List<Person> person = new List<Person>();
       
            // Act
            person = personController.Get();  
            
            //Assert
            Assert.IsTrue(person.Count == 0);
        }

        [TestMethod()]
        public void AddPersonTest()
        {
         // Arrange
            Person person = (new Person
            {
                Age = 12,
                Name = "John Doe",
            });

           // Act
           var result = personController.AddPerson(person);
            var okResult = result as OkObjectResult;

            // Assert
            Assert.IsNotNull(okResult);
            Assert.AreEqual(200, okResult.StatusCode);
        }
    }
}