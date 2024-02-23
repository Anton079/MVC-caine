using MVC_caine;

internal class Program
{
    public static void Main(string[] args)
    {
        CaineService service = new CaineService();

        service.LoadData();

        service.AfisareCaini();
    }
}