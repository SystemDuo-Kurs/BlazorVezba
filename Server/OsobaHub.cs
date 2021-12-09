using Microsoft.AspNetCore.SignalR;
using Teeest2.Shared;

namespace Teeest2.Server
{
    public class OsobaHub : Hub
    {
        public void Metoda(Osoba o)
        {
            Console.WriteLine($"{o.Name} {o.Surname}");
            Console.WriteLine("Dobri momci");
        }
    }
}
