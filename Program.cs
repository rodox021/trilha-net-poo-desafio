using DesafioPOO.Models;
using System.Threading.Tasks;
using System.Timers;

// TODO: Realizar os testes com as classes Nokia e Iphone

Nokia nokia = new Nokia(_numero: "548641", _modelo: "TIJOLO", _imei: "48348346534IM", _memoria: 256);


void Timer_Elapsed(object sender, ElapsedEventArgs e)
{
    nokia.InstalarAplicativo("WhatsApp");
    
    
}




System.Timers.Timer timer = new System.Timers.Timer(1000);
timer.Elapsed += Timer_Elapsed;
timer.Start();
Console.ReadKey();
timer.Stop();


