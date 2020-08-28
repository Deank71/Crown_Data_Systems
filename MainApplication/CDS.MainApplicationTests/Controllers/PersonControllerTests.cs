using Microsoft.VisualStudio.TestTools.UnitTesting;
using MainApplication.Controllers;
using System;
using System.Collections.Generic;
using System.Text;
using CDS.Repository.UnitOfWork;
using CDS.Data.Models;
using System.Linq;
using Moq;
using Microsoft.EntityFrameworkCore;
using CDS.Repository.Repositories.Inerfaces;

namespace MainApplication.Controllers.Tests
{
    [TestClass()]
    public class PersonControllerTests
    {
        private IUnitOfWork mockUnitOfWork;
        private IRepository<Person> mockPersonRepo;
        private PersonController personController;
        [TestInitialize]
        public void Initialize()
        {
         
            this.mockUnitOfWork = new Mock<IUnitOfWork>().Object;
            var contextMock = new Mock<CDSContext>();
            var unitOfWorkMock = new Mock<IUnitOfWork>();
            contextMock.Setup(a => a.Set<Person>()).Returns(Mock.Of<DbSet<Person>>);
             personController = new PersonController(this.mockUnitOfWork);
          
        }

        [TestMethod()]
        public void GetTest()
        {
            // Arrange
        
           
           
            List<Person> person = new List<Person>();
       
            person = personController.Get();    
            Assert.IsTrue(person.Count == 0);
        }

        [TestMethod()]
        public void AddPersonTest()
        {

            Person person = (new Person
            {
                Age = 12,
                Name = "John Doe",
            });

            var result = personController.AddPerson(person);

            Assert.Fail();
        }
    }
}