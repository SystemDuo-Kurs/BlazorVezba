using Microsoft.AspNetCore.SignalR;
using Teeest2.Shared;

namespace Teeest2.Server
{
    public class OsobaHub : Hub
    {
        private readonly DB _db; 
        public void Metoda(Osoba o)
        {
            Console.WriteLine($"{o.Name} {o.Surname}");
            Console.WriteLine("Dobri momci");
            _db.Add(o);
            _db.SaveChanges();
        } 
        public OsobaHub(DB dB) 
        { 
            _db = dB;
        }
    }
}
