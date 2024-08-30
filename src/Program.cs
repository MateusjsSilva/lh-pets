namespace src;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        var app = builder.Build();

        app.MapGet("/", () => "Projeto Web - LH Pets");

        app.UseStaticFiles();
        app.MapGet("/index", (HttpContext contexto) =>
        {
            contexto.Response.Redirect("index.html", false);
        });

        Banco dba = new Banco();
        app.MapGet("/listaClientes", (HttpContext contexto) =>
        {
            contexto.Response.WriteAsync(dba.GetListaString());
        });

        app.Run();
    }
}