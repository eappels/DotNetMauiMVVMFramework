using MVVMFrameworkDotNet9.Interfaces;

namespace MVVMFrameworkDotNet9.Services;

public class DemoService : IDemoService
{

    public async Task<string> DemoMethodAsync()
    {
        await Task.Delay(3000);
        return "Hello from DemoService in .NET 9!";
    }
}