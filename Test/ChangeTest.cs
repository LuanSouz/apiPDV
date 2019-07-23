using System;
using System.Collections.Generic;
using System.Text;
using FluentAssertions;
using System.Net;
using System.Threading.Tasks;
using Xunit;
namespace apiPDV.Test
{
    public class ChangeTest
    {
        private readonly TestContext _testContext;
        public ChangeTest()
        {
            _testContext = new TestContext();
        }

        [Fact]
        public async Task Values_Get_ReturnsOkResponse()
        {
            var response = await _testContext.Client.GetAsync("/api/changes");
            response.EnsureSuccessStatusCode();
            response.StatusCode.Should().Be(HttpStatusCode.OK);
        }

        [Fact]
        public async Task Values_GetById_ValuesReturnsOkResponse()
        {
            var response = await _testContext.Client.GetAsync("/api/changes/5");
            response.EnsureSuccessStatusCode();
            response.StatusCode.Should().Be(HttpStatusCode.OK);
        }

   
        [Fact]
        public async Task Values_GetById_CorrectContentType()
        {
            var response = await _testContext.Client.GetAsync("/api/changes/5");
            response.EnsureSuccessStatusCode();
            response.Content.Headers.ContentType.ToString().Should().Be("text/plain; charset=utf-8");
        }
    }
}