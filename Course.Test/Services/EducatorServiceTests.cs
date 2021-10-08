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
    public class EducatorServiceTests
    {
        private EducatorDto testEducatorDto = new EducatorDto() { EducatorId = 1, Name = "Morgan",Surname="Yu",Gender="M" };
        private List<EducatorDto> testEducatorDtoList = new List<EducatorDto>() { new EducatorDto { EducatorId = 2, Name = "Alex", Surname = "Yu", Gender = "M" } };

        [Fact]
        public void TestEducatorServiceGet()
        {
            //Arrange
            var mockEducatorService = new Mock<IEducatorService>();
            mockEducatorService.Setup(service => service.Get(It.IsAny<long>())).Returns(testEducatorDto);
            IEducatorService EducatorService = mockEducatorService.Object;

            //Act
            var result = EducatorService.Get(It.IsAny<long>());

            //Assert
            Assert.Equal(result, testEducatorDto);
        }

        [Fact]
        public void TestEducatorServiceGetEducatorList()
        {
            //Arrange
            var mockEducatorService = new Mock<IEducatorService>();
            mockEducatorService.Setup(service => service.Get()).Returns(testEducatorDtoList);
            IEducatorService EducatorService = mockEducatorService.Object;

            //Act
            var result = EducatorService.Get();

            //Assert
            Assert.Equal(result, testEducatorDtoList);
        }

        [Fact]
        public void TestEducatorServiceAdd()
        {
            //Arrange
            var mockEducatorService = new Mock<IEducatorService>();
            mockEducatorService.Setup(service => service.Add(testEducatorDto)).Returns(true);
            IEducatorService EducatorService = mockEducatorService.Object;

            //Act
            var result = EducatorService.Add(testEducatorDto);

            //Assert
            Assert.True(result);
        }

        [Fact]
        public void TestEducatorServiceUpdate()
        {
            //Arrange
            var mockEducatorService = new Mock<IEducatorService>();
            mockEducatorService.Setup(service => service.Update(testEducatorDto)).Returns(true);
            IEducatorService EducatorService = mockEducatorService.Object;

            //Act
            var result = EducatorService.Update(testEducatorDto);

            //Assert
            Assert.True(result);
        }

        [Fact]
        public void TestEducatorServiceDelete()
        {
            //Arrange
            var mockEducatorService = new Mock<IEducatorService>();
            mockEducatorService.Setup(service => service.Delete(It.IsAny<long>())).Returns(true);
            IEducatorService EducatorService = mockEducatorService.Object;

            //Act
            var result = EducatorService.Delete(It.IsAny<long>());

            //Assert
            Assert.True(result);
        }
    }
}
