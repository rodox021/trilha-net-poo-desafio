using System.Timers;

namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {

        private static System.Timers.Timer _timer;


        public Nokia(string _numero, string _modelo, string _imei, int _memoria) : base(_numero, _modelo, _imei, _memoria)
        {
        }


        // TODO: Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp)
        {

            _timer = new System.Timers.Timer(2000);
            _timer.Elapsed += TimerOnElapsed;
            _timer.AutoReset = true;
            _timer.Enabled = true;
            _timer.Start();

        }
        private void TimerOnElapsed(object sender, ElapsedEventArgs e)
        {
            System.Console.WriteLine(e.SignalTime);
        }


       
    }
}