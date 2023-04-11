using audit_service.Controllers;
using audit_service.Entities;
using AutoFixture;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using Moq;

namespace Auditcontrolltesting
{
    public class AuditServiceTest
    {
        private readonly IFixture _fixture;
        private readonly AuditController _controller;


        public AuditServiceTest()
        {
            _fixture = new Fixture();
            _controller = new AuditController();

        }

        [Fact]
        public void Post_AddBloodGroup()
        {
            var request = _fixture.Create<BloodGroupTable>();
            var BloodGroupTable = _fixture.Create<BloodGroupTable>();


            var result = _controller.PostBloodGroup(BloodGroupTable);
            result.Should().NotBeNull();
            result.Should().BeAssignableTo<BadRequestObjectResult>();

        }
        [Fact]
        public void Post_AddBloodPressureDiastolic()
        {
            var request = _fixture.Create<BloodPressureDiastolicTable>();
            var BloodPressureDiastolicTable = _fixture.Create<BloodPressureDiastolicTable>();


            var result = _controller.PostBloodPressureDiastolic(BloodPressureDiastolicTable);
            result.Should().NotBeNull();
            result.Should().BeAssignableTo<BadRequestObjectResult>();

        }
        [Fact]
        public void Post_AddBloodPressureSystolic()
        {
            var request = _fixture.Create<BloodPressureSystolicTable>();
            var BloodPressureSystolicTable = _fixture.Create<BloodPressureSystolicTable>();


            var result = _controller.PostBloodPressureSystolic(BloodPressureSystolicTable);
            result.Should().NotBeNull();
            result.Should().BeAssignableTo<BadRequestObjectResult>();

        }
        [Fact]
        public void Post_AddBodyTemperature()
        {
            var request = _fixture.Create<BodyTemperature>();
            var BodyTemperature = _fixture.Create<BodyTemperature>();


            var result = _controller.PostBodyTemperature(BodyTemperature);
            result.Should().NotBeNull();
            result.Should().BeAssignableTo<BadRequestObjectResult>();

        }
        [Fact]
        public void Post_AddHeight()
        {
            var request = _fixture.Create<HeightTable>();
            var HeightTable = _fixture.Create<HeightTable>();


            var result = _controller.PostHeightTable(HeightTable);
            result.Should().NotBeNull();
            result.Should().BeAssignableTo<BadRequestObjectResult>();

        }
        [Fact]
        public void Post_AddRespiration()
        {
            var request = _fixture.Create<RespirationTable>();
            var RespirationTable = _fixture.Create<RespirationTable>();


            var result = _controller.PostRespiration(RespirationTable);
            result.Should().NotBeNull();
            result.Should().BeAssignableTo<BadRequestObjectResult>();

        }
        [Fact]
        public void Post_AddWeight()
        {
            var request = _fixture.Create<WeightTable>();
            var WeightTable = _fixture.Create<WeightTable>();


            var result = _controller.PostWeight(WeightTable);
            result.Should().NotBeNull();
            result.Should().BeAssignableTo<BadRequestObjectResult>();

        }

    }
}