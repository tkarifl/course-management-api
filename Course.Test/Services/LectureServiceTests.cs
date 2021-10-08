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
    public class LectureServiceTests
    {
        private LectureDto testLectureDto = new LectureDto() { LectureId=1,LectureCode="E100A",LectureName="English A1 Course" };
        private List<LectureDto> testLectureDtoList = new List<LectureDto>() { new LectureDto { LectureId = 2, LectureCode = "E200A", LectureName = "English A2 Course" } };

        [Fact]
        public void TestLectureServiceGet()
        {
            //Arrange
            var mockLectureService = new Mock<ILectureService>();
            mockLectureService.Setup(service => service.Get(It.IsAny<long>())).Returns(testLectureDto);
            ILectureService LectureService = mockLectureService.Object;

            //Act
            var result = LectureService.Get(It.IsAny<long>());

            //Assert
            Assert.Equal(result, testLectureDto);
        }

        [Fact]
        public void TestLectureServiceGetLectureList()
        {
            //Arrange
            var mockLectureService = new Mock<ILectureService>();
            mockLectureService.Setup(service => service.Get()).Returns(testLectureDtoList);
            ILectureService LectureService = mockLectureService.Object;

            //Act
            var result = LectureService.Get();

            //Assert
            Assert.Equal(result, testLectureDtoList);
        }

        [Fact]
        public void TestLectureServiceAdd()
        {
            //Arrange
            var mockLectureService = new Mock<ILectureService>();
            mockLectureService.Setup(service => service.Add(testLectureDto)).Returns(true);
            ILectureService LectureService = mockLectureService.Object;

            //Act
            var result = LectureService.Add(testLectureDto);

            //Assert
            Assert.True(result);
        }

        [Fact]
        public void TestLectureServiceUpdate()
        {
            //Arrange
            var mockLectureService = new Mock<ILectureService>();
            mockLectureService.Setup(service => service.Update(testLectureDto)).Returns(true);
            ILectureService LectureService = mockLectureService.Object;

            //Act
            var result = LectureService.Update(testLectureDto);

            //Assert
            Assert.True(result);
        }

        [Fact]
        public void TestLectureServiceDelete()
        {
            //Arrange
            var mockLectureService = new Mock<ILectureService>();
            mockLectureService.Setup(service => service.Delete(It.IsAny<long>())).Returns(true);
            ILectureService LectureService = mockLectureService.Object;

            //Act
            var result = LectureService.Delete(It.IsAny<long>());

            //Assert
            Assert.True(result);
        }
    }
}
