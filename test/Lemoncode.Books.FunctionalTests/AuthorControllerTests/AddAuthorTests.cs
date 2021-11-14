using FluentAssertions;
using Lemoncode.Books.FunctionalTests.Utilities;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace Lemoncode.Books.FunctionalTests.AuthorControllerTests
{
    public class AddAuthorTests : FunctionalTest
    {

        private string _url;
        private HttpResponseMessage _result;
        private StringContent _content;

        protected override Task Given()
        {
            _url = "Authors";
            var jsonStream =
                new FileStreamBuilder()
                    .WithFileResourceName("add_author.json")
                    .Build();
            _content =
                new StringContentBuilder()
                    .WithContent(jsonStream)
                    .Build();

            return Task.CompletedTask;
        }

        protected override async Task When()
        {
            _result = await HttpClient.PostAsync(_url, _content);
        }

        /*
        [Fact]
        public void Add_Author_Is_Returning_Ok()
        {
            _result.StatusCode.Should().Be(HttpStatusCode.Created);           
        }

        [Fact]
        public void Add_Author_Is_Returning_Generated_Id()
        {
            _result.Headers.Location.Should().NotBeNull();
        }
        */
    }
}
