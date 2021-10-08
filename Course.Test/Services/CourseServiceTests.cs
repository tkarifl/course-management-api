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
    public class CourseServiceTests
    {
        private CourseDto testCourseDto = new CourseDto() { CourseId = 1, CourseName = "A1 English Course" };
        private List<CourseDto> testCourseDtoList = new List<CourseDto>() { new CourseDto { CourseId = 2, CourseName = "A2 French Course" } };

        [Fact]
        public void TestCourseServiceGet()
        {
            //Arrange
            var mockCourseService = new Mock<ICourseService>();
            mockCourseService.Setup(service => service.Get(It.IsAny<long>())).Returns(testCourseDto);
            ICourseService courseService = mockCourseService.Object;

            //Act
            var result = courseService.Get(It.IsAny<long>());

            //Assert
            Assert.Equal(result, testCourseDto);
        }

        [Fact]
        public void TestCourseServiceGetCourseList()
        {
            //Arrange
            var mockCourseService = new Mock<ICourseService>();
            mockCourseService.Setup(service => service.Get()).Returns(testCourseDtoList);
            ICourseService courseService = mockCourseService.Object;

            //Act
            var result = courseService.Get();

            //Assert
            Assert.Equal(result, testCourseDtoList);
        }

        [Fact]
        public void TestCourseServiceAdd()
        {
            //Arrange
            var mockCourseService = new Mock<ICourseService>();
            mockCourseService.Setup(service => service.Add(testCourseDto)).Returns(true);
            ICourseService courseService = mockCourseService.Object;

            //Act
            var result = courseService.Add(testCourseDto);

            //Assert
            Assert.True(result);
        }

        [Fact]
        public void TestCourseServiceUpdate()
        {
            //Arrange
            var mockCourseService = new Mock<ICourseService>();
            mockCourseService.Setup(service => service.Update(testCourseDto)).Returns(true);
            ICourseService courseService = mockCourseService.Object;

            //Act
            var result = courseService.Update(testCourseDto);

            //Assert
            Assert.True(result);
        }

        [Fact]
        public void TestCourseServiceDelete()
        {
            //Arrange
            var mockCourseService = new Mock<ICourseService>();
            mockCourseService.Setup(service => service.Delete(It.IsAny<long>())).Returns(true);
            ICourseService courseService = mockCourseService.Object;

            //Act
            var result = courseService.Delete(It.IsAny<long>());

            //Assert
            Assert.True(result);
        }

    }
}
