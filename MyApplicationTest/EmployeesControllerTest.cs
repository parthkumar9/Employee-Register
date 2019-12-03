using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyApplication.Controllers;
using MyApplication.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyApplicationTest
{
    [TestClass]
    public class EmployeesControllerTest
    {
        //createv global employees controller instance first
        EmployeesController employeesController;

        //create a global project list for use in all the unit tests
        List<Employees> employees = new List<Employees>();

        //My mock Db object
        private readonly CRUDDBContext _context;

        [TestInitialize]
        public void TestInitialize()
        {
            //I needed to use in-memory DbContext instead of connecting to SQL Server
            var options = new DbContextOptionsBuilder<CRUDDBContext>()
                .UseInMemoryDatabase("SomeRandomString")
                .Options;
            var _context = new CRUDDBContext(options);
            

            //create mock data and add to in-memory db
            Employees mockEmpName = new Employees{
                EmployeeId = 3,
                EmpName = "A fake Name"
                
            };
           employees.Add(new Employees
            {
                EmployeeId = 1,
                Position = "Anything",
                DeptId = "HumanResource",
                EmpName = mockEmpName
            });

            employees.Add(new Employees
            {
                EmployeeId = 12,
                Position = "Manager",
                DeptId = "HumanResource",
                EmpName = mockEmpName
            });

            foreach (var e in employees)
            {
                _context.Employees.Add(e);
            }
            _context.SaveChanges();

            employeesController = new EmployeesController(_context);
        }



        [TestMethod]
        public void IndexLoadsRightView()
        {
            //act
            var result = employeesController.Index().Result;
            var viewResult = (ViewResult)result;

            //assert
            Assert.AreEqual("Index", viewResult.ViewName);
        }

        [TestMethod]
        public void IndexReturnsEmployees()
        {
            var result = employeesController.Index().Result;

            var viewResult = (ViewResult)result;

            CollectionAssert.AreEqual(employees, (List<Employees>)viewResult.Model);
        }



    }
}
