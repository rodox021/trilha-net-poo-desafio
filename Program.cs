using DesafioPOO.Models;
using System.Threading.Tasks;
using System.Timers;

// TODO: Realizar os testes com as classes Nokia e Iphone

Nokia nokia = new Nokia(_numero: "548641", _modelo: "TIJOLO", _imei: "48348346534IM", _memoria: 256);

nokia.InstalarAplicativo("");
System.Timers.Timer t = new System.Timers.Timer() { Interval = 1000 };

t = new System.Timers.Timer(2000);
t.Elapsed += TimerOnElapsed;


t.AutoReset = true;
t.Enabled = true;
t.Start();



void TimerOnElapsed(object sender, ElapsedEventArgs e)
{
   System.Console.WriteLine( DateTime.Now);
}