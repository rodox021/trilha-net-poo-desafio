using System.Timers;

namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
        private static System.Timers.Timer timer = new System.Timers.Timer(1000);
        private int count = 1;


        public Nokia(string _numero, string _modelo, string _imei, int _memoria) : base(_numero, _modelo, _imei, _memoria)
        {
        }


        // TODO: Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp)
        {
            timer.Elapsed += Timer_Elapsed;
            timer.Start();

            if (count == 3)
            {
                timer.Stop();
                
            }
           
            
        }
        public void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            
            Console.Write("|||");
            count++;
            
        }

        

    }
}