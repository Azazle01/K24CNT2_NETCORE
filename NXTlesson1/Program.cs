namespace NXTlesson1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var app = builder.Build();

            app.MapGet("/", () => "Hello Dai ai tien ton (luyen thien ma ton)!");

            app.Run();
        }
    }
}
