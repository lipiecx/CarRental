using CarRental.Controllers;
using CarRental.Models;
using CarRental.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        ModelController _controller;
        IModelRepository _repository;

        public UnitTest1()
        {
            _repository = new IModelRepositoryFake();
            _controller = new ModelController(_repository);
        }

        [Fact]
        public void Test1()
        {
            var okResult = _controller.Add(new ModelDto { Brand = "Honda", Capacity = "40dm^3", Horsepower = 100 });
            Assert.IsType<OkObjectResult>(okResult);
        }
    }
}
