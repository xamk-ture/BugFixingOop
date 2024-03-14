using BugFixingOop;
using BugFixingOop.Models;
using System;

namespace TestProject
{

    public class OOPAssignmentsTests
    {
        [Fact]
        public void Person_PropertiesAreCorrectlyEncapsulated()
        {
            var person = new Person("Test");
            person.Name = "John";
            person.Age = 30;

            Assert.Equal("John", person.Name);
            Assert.Equal(30, person.Age);
        }

        [Fact]
        public void Employee_InheritsFromPerson()
        {
            //var employee = new Employee { Name = "Jane", Age = 25, EmployeeID = "E123" };

            //Assert.Equal("Jane", employee.Name);
            //Assert.Equal(25, employee.Age);
            //Assert.Equal("E123", employee.EmployeeID);
        }

        [Fact]
        public void Student_ToStringReturnsCorrectFormat()
        {
            var student = new Student("S123") { Name = "John Doe" };
            var expectedString = "Name: John Doe, ID: S123";

            Assert.Equal(expectedString, student.ToString());
        }

        [Theory]
        [InlineData(typeof(Circle), "Drawing a circle.")]
        [InlineData(typeof(Square), "Drawing a square.")]
        public void Shape_DrawPrintsCorrectShape(Type shapeType, string expectedOutput)
        {
            var shape = (Shape)Activator.CreateInstance(shapeType);
            var consoleOutput = new StringWriter();
            Console.SetOut(consoleOutput);

            shape.Draw();

            Assert.Contains(expectedOutput, consoleOutput.ToString());
        }

        [Fact]
        public void Student_CorrectlyInitializesPerson()
        {
            var student = new Student( "S123");

            Assert.Equal("S123", student.StudentID);
        }

        [Fact]
        public void Car_ImplementsIVehicleMethods()
        {
            IVehicle car = new Car();
            var consoleOutput = new StringWriter();
            Console.SetOut(consoleOutput);

            car.StartEngine();
            Assert.Contains("Engine started.", consoleOutput.ToString());

            car.StopEngine();
            Assert.Contains("Engine stopped.", consoleOutput.ToString());
        }


        [Fact]
        public void Person_AgeDoesNotAcceptNegativeValues()
        {
            var person = new Person("Test");
            person.Age = -1; // Assuming your implementation defaults to a sensible value on invalid input

            Assert.True(person.Age >= 0);
        }
     
    }

}
