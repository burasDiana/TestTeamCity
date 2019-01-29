using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Web.Http;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebApplication1;
using WebApplication1.Controllers;

namespace WebApplication1.Tests.Controllers
{
    [TestClass]
    public class ValuesControllerTest
    {
        [TestMethod]
        public void Get()
        {
            // Arrange
            ValuesController controller = new ValuesController();

            // Act
            IEnumerable<string> result = controller.Get();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(2, result.Count());
            Assert.AreEqual("value1", result.ElementAt(0));
            Assert.AreEqual("value2", result.ElementAt(1));
        }

        [TestMethod]
        public void GetById()
        {
            // Arrange
            ValuesController controller = new ValuesController();

            // Act
            string result = controller.Get(5);

            // Assert
            Assert.AreEqual("value", result);
        }

        [TestMethod]
        public void Post()
        {
            // Arrange
            ValuesController controller = new ValuesController();

            // Act
            controller.Post("value");

            // Assert
        }

        [TestMethod]
        public void Calculate_ShouldAddTwoNumbers()
        {
            // Arrange
            ValuesController controller = new ValuesController();
            int a = 2;
            int b = 10;
            string op = "+";
            // Act
            int result = controller.Calculate(a, b, op);
            int expected = a + b;
            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Calculate_ShouldDetectWrongOperand()
        {
            // Arrange
            ValuesController controller = new ValuesController();
            int a = 39;
            int b = 10;
            string op = "*";
            // Act
            int result = controller.Calculate(a, b, op);
            int expected = 0;
            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Calculate_ShouldDetectInvalidInputs()
        {
            // Arrange
            ValuesController controller = new ValuesController();
            int a = -10;
            int b = 10;
            string op = "-";
            // Act
            int result = controller.Calculate(a, b, op);
            int expected = 0;
            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Calculate_ShouldDetectInvalidInputs2()
        {
            // Arrange
            ValuesController controller = new ValuesController();
            int a = 1 / 2;
            int b = 10;
            string op = "%";
            // Act
            int result = controller.Calculate(a, b, op);
            int expected = 0;
            // Assert
            Assert.AreEqual(expected, result);
        }


        [TestMethod]
        public void Put()
        {
            // Arrange
            ValuesController controller = new ValuesController();

            // Act
            controller.Put(5, "value");

            // Assert
        }

        [TestMethod]
        public void Delete()
        {
            // Arrange
            ValuesController controller = new ValuesController();

            // Act
            controller.Delete(5);

            // Assert
        }
    }
}
