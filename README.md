# .NET Web API Project Structure

This README provides an overview of the core components of the .NET Web API project, including Services, Interfaces, Controllers, Models, DbContext, and Dataset.



## 🚀 **Controllers**

Controllers handle HTTP requests and return responses. Each controller inherits from `ControllerBase`.

**ExampleController.cs:**

```csharp
using Microsoft.AspNetCore.Mvc;
using ProjectNamespace.Interfaces;
using ProjectNamespace.Models;

namespace ProjectNamespace.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ExampleController : ControllerBase
    {
        private readonly IExampleService _exampleService;

        public ExampleController(IExampleService exampleService)
        {
            _exampleService = exampleService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var data = _exampleService.GetAll();
            return Ok(data);
        }
    }
}
```

---

## 🏷️ **Models**

Models define the structure of the data.

**ExampleModel.cs:**

```csharp
namespace ProjectNamespace.Models
{
    public class ExampleModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
```

---

## 📄 **Interfaces**

Interfaces define the contracts for services, promoting loose coupling.

**IExampleService.cs:**

```csharp
using ProjectNamespace.Models;

namespace ProjectNamespace.Interfaces
{
    public interface IExampleService
    {
        IEnumerable<ExampleModel> GetAll();
    }
}
```

---

## ⚙️ **Services**

Services contain business logic and implement the interfaces.

**ExampleService.cs:**

```csharp
using ProjectNamespace.Interfaces;
using ProjectNamespace.Models;

namespace ProjectNamespace.Services
{
    public class ExampleService : IExampleService
    {
        private readonly List<ExampleModel> _examples = new()
        {
            new ExampleModel { Id = 1, Name = "Example1" },
            new ExampleModel { Id = 2, Name = "Example2" }
        };

        public IEnumerable<ExampleModel> GetAll()
        {
            return _examples;
        }
    }
}
```

---

## 🗃️ **DbContext**

`AppDbContext` manages the interaction with the database using Entity Framework Core.

**AppDbContext.cs:**

```csharp
using Microsoft.EntityFrameworkCore;
using ProjectNamespace.Models;

namespace ProjectNamespace.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<ExampleModel> Examples { get; set; }
    }
}
```

Add the DbContext to `Program.cs`:

```csharp
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
```

Add a connection string in `appsettings.json`:

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Database=ExampleDb;Trusted_Connection=True;"
  }
}
```

---

## 📚 **Dataset**

The dataset can be used for seeding data or mock data.

**ExampleDataset.cs:**

```csharp
using ProjectNamespace.Models;

namespace ProjectNamespace.Data
{
    public static class ExampleDataset
    {
        public static List<ExampleModel> GetExamples() => new List<ExampleModel>
        {
            new ExampleModel { Id = 1, Name = "Example1" },
            new ExampleModel { Id = 2, Name = "Example2" }
        };
    }
}
```

---

## 📦 **Dependency Injection**

Ensure services are registered in `Program.cs`:

```csharp
builder.Services.AddScoped<IExampleService, ExampleService>();
```

---

## ✅ **Testing the API**

Run the app:

```bash
dotnet run
```

Test the API using Postman or curl:

```bash
curl -X GET http://localhost:5000/api/example
```

---

This should get you started with a clean, well-structured .NET Web API. Let me know if you'd like to expand on anything! 🚀

