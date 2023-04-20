

namespace Codefolio.EntityFrameworkCore.Tests
{

    public class MyDbContextTests
    {
        [Fact]
        public void TestInMemoryDatabase()
        {
            var options = new DbContextOptionsBuilder<MyDbContext>()
                .UseInMemoryDatabase(databaseName: "TestDatabase")
                .Options;

            using (var context = new MyDbContext(options))
            {
                context.MyEntities.Add(new MyEntity { Name = "Alice", Age = 30 });
                context.SaveChanges();
            }

            using (var context = new MyDbContext(options))
            {
                Assert.Equal(1, context.MyEntities.Count());
                var entity = context.MyEntities.FirstOrDefault(e => e.Name == "Alice");
                Assert.NotNull(entity);
                Assert.Equal(30, entity.Age);
            }
        }

        [Fact]
        public void TestSqliteDatabase()
        {
            var options = new DbContextOptionsBuilder<MyDbContext>()
                .UseSqlite("DataSource=:memory:")
                .Options;

            using (var context = new MyDbContext(options))
            {
                context.Database.OpenConnection();
                context.Database.EnsureCreated();

                context.MyEntities.Add(new MyEntity { Name = "Bob", Age = 40 });
                context.SaveChanges();
            }

            using (var context = new MyDbContext(options))
            {
                Assert.Equal(1, context.MyEntities.Count());
                var entity = context.MyEntities.FirstOrDefault(e => e.Name == "Bob");
                Assert.NotNull(entity);
                Assert.Equal(40, entity.Age);
            }
        }
    }
}