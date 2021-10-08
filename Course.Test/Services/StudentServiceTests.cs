using Course.Application.Dto;
using Course.Application.Services;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Course.Test.Services
{
    public class StudentServiceTests
    {
        private StudentDto testStudentDto = new StudentDto() { StudentId=1,Name="Morgan",Surname="Yu",CourseId=1,Gender="M" };
        private List<StudentDto> testStudentDtoList = new List<StudentDto>() { new StudentDto { StudentId = 2, Name = "Alex", Surname = "Yu", CourseId = 2, Gender = "M" } };

        [Fact]
        public void TestStudentServiceGet()
        {
            //Arrange
            var mockStudentService = new Mock<IStudentService>();
            mockStudentService.Setup(service => service.Get(It.IsAny<long>())).Returns(testStudentDto);
            IStudentService studentService = mockStudentService.Object;

            //Act
            var result = studentService.Get(It.IsAny<long>());

            //Assert
            Assert.Equal(result, testStudentDto);
        }

        [Fact]
        public void TestStudentServiceGetStudentList()
        {
            //Arrange
            var mockStudentService = new Mock<IStudentService>();
            mockStudentService.Setup(service => service.Get()).Returns(testStudentDtoList);
            IStudentService studentService = mockStudentService.Object;

            //Act
            var result = studentService.Get();

            //Assert
            Assert.Equal(result, testStudentDtoList);
        }

        [Fact]
        public void TestStudentServiceAdd()
        {
            //Arrange
            var mockStudentService = new Mock<IStudentService>();
            mockStudentService.Setup(service => service.Add(testStudentDto)).Returns(true);
            IStudentService studentService = mockStudentService.Object;

            //Act
            var result = studentService.Add(testStudentDto);

            //Assert
            Assert.True(result);
        }

        [Fact]
        public void TestStudentServiceUpdate()
        {
            //Arrange
            var mockStudentService = new Mock<IStudentService>();
            mockStudentService.Setup(service => service.Update(testStudentDto)).Returns(true);
            IStudentService studentService = mockStudentService.Object;

            //Act
            var result = studentService.Update(testStudentDto);

            //Assert
            Assert.True(result);
        }

        [Fact]
        public void TestStudentServiceDelete()
        {
            //Arrange
            var mockStudentService = new Mock<IStudentService>();
            mockStudentService.Setup(service => service.Delete(It.IsAny<long>())).Returns(true);
            IStudentService studentService = mockStudentService.Object;

            //Act
            var result = studentService.Delete(It.IsAny<long>());

            //Assert
            Assert.True(result);
        }
    }
}
