using ConsoleApp.Ping;
using FakeItEasy;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProject.DNS;

namespace TestProject.PingTest
{
    public class NetworkUtilityTest
    {
        private readonly IDNS _dNS;
        private readonly NetworkUtility _pingService;
        public NetworkUtilityTest()
        {
            _dNS= A.Fake<IDNS>();
            _pingService = new NetworkUtility(_dNS);
        }
        [Fact]
        public void NetworkUtility_SendPing_ReturnsString()
        {
            //Arrange
            A.CallTo(() => _dNS.SendDNS()).Returns(true);
            //Act
            var result= _pingService.SendPing();
            //Assert
            result.Should().NotBeNullOrWhiteSpace();
            result.Should().Be("Success: Ping Sent");
            result.Should().Contain("Success", Exactly.Once());
        }
    }   
}
