using FluentAssertions;
using Lemoncode.Books.FunctionalTests.Utilities;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web.Http;
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

            /*var username = "admin";
            var password = "Lem0nCode!";


            var request = new HttpRequestMessage(HttpMethod.Get, "http://localhost/api/Authors");
            request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            request.Headers.Authorization = new AuthenticationHeaderValue(
                "Basic", EncodeToBase64.EncodeToBase64(string.Format("{0}:{1}", username, password)));*/

        }

        protected override async Task When()
        {
            _result = await HttpClient.PostAsync(_url, _content);
        }

        [Fact]
        public void Add_Author_Is_Returning_Generated_Id()
        {
            _result.Headers.Location.Should().NotBeNull();
        }
       
        /*[Fact]
        public async Task Add_Author_Is_Returning_Ok()
        {
            var username = "admin";
            var password = "Lem0nCode!";


            var request = new HttpRequestMessage(HttpMethod.Get, "http://localhost:5001/api/Books");
            request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            request.Headers.Authorization = new AuthenticationHeaderValue(
                "Basic", EncodeUtil.EncodeToBase64(string.Format("{0}:{1}", username, password)));

            using (var httpServer = new HttpServer())
            using (var client = new HttpClient(httpServer))
            {
                var response = await client.SendAsync(request);
                var result = response;

                _result.StatusCode.Should().Be(HttpStatusCode.Created);

                // do you test now...
            }                    
        }*/
    }
}
