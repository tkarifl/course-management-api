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
    public class LectureProgramServiceTests
    {
        private LectureProgramDto testLectureProgramDto = new LectureProgramDto() { LectureProgramId = 1, LectureId=1,EducatorId=1};
        private List<LectureProgramDto> testLectureProgramDtoList = new List<LectureProgramDto>() { new LectureProgramDto { LectureProgramId = 2, LectureId = 3, EducatorId = 3 } };

        [Fact]
        public void TestLectureProgramServiceGet()
        {
            //Arrange
            var mockLectureProgramService = new Mock<ILectureProgramService>();
            mockLectureProgramService.Setup(service => service.Get(It.IsAny<long>())).Returns(testLectureProgramDto);
            ILectureProgramService LectureProgramService = mockLectureProgramService.Object;

            //Act
            var result = LectureProgramService.Get(It.IsAny<long>());

            //Assert
            Assert.Equal(result, testLectureProgramDto);
        }

        [Fact]
        public void TestLectureProgramServiceGetLectureProgramList()
        {
            //Arrange
            var mockLectureProgramService = new Mock<ILectureProgramService>();
            mockLectureProgramService.Setup(service => service.Get()).Returns(testLectureProgramDtoList);
            ILectureProgramService LectureProgramService = mockLectureProgramService.Object;

            //Act
            var result = LectureProgramService.Get();

            //Assert
            Assert.Equal(result, testLectureProgramDtoList);
        }

        [Fact]
        public void TestLectureProgramServiceAdd()
        {
            //Arrange
            var mockLectureProgramService = new Mock<ILectureProgramService>();
            mockLectureProgramService.Setup(service => service.Add(testLectureProgramDto)).Returns(true);
            ILectureProgramService LectureProgramService = mockLectureProgramService.Object;

            //Act
            var result = LectureProgramService.Add(testLectureProgramDto);

            //Assert
            Assert.True(result);
        }

        [Fact]
        public void TestLectureProgramServiceUpdate()
        {
            //Arrange
            var mockLectureProgramService = new Mock<ILectureProgramService>();
            mockLectureProgramService.Setup(service => service.Update(testLectureProgramDto)).Returns(true);
            ILectureProgramService LectureProgramService = mockLectureProgramService.Object;

            //Act
            var result = LectureProgramService.Update(testLectureProgramDto);

            //Assert
            Assert.True(result);
        }

        [Fact]
        public void TestLectureProgramServiceDelete()
        {
            //Arrange
            var mockLectureProgramService = new Mock<ILectureProgramService>();
            mockLectureProgramService.Setup(service => service.Delete(It.IsAny<long>())).Returns(true);
            ILectureProgramService LectureProgramService = mockLectureProgramService.Object;

            //Act
            var result = LectureProgramService.Delete(It.IsAny<long>());

            //Assert
            Assert.True(result);
        }
    }
}
