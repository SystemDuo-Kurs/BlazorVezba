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
            _db.Update(o);
            _db.SaveChanges();
            Posalji();
        } 
        public OsobaHub(DB dB) 
        { 
            _db = dB;
        }
        public async void Posalji()
        {
         await   Clients.Caller.SendAsync("Send", _db.Osobe.ToList());
        }
        public void Brisanje(Osoba osoba)
        {
            _db.Remove(osoba);
            _db.SaveChanges();
            Posalji();
        }
    }
}
