namespace Lemoncode.Books.Application.UnitTests.AuthoerServiceTests
{
    public class AddAuthorTests
    {
        //private AuthorService _sut;
        //private Mock<IAuthorService> _authorServiceMock;

        /*
        [Fact]
        public void New_Author_Is_Created()
        {
            // Given
            var authorToAdd = new AuthorAdd
            {
                Name = "Test",
                LastName = "Author",
                Birth = new DateTime(2000, 1, 1),
                CountyrCode = "es"
            };            
            
            var mockSet = new Mock<DbSet<Author>>();
            var mockContext = new Mock<BooksDbContext>();
            mockContext.Setup(m => m.Authors).Returns(mockSet.Object);
            var service = new AuthorService(mockContext.Object);

            // When
            service.AddAuthor(authorToAdd);

            // Then
            mockSet.Verify(m => m.Add(It.IsAny<Author>()), Times.Once());
            mockContext.Verify(m => m.SaveChanges(), Times.Once());
        }
        */
    }
}
