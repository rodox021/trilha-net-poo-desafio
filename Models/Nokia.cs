namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
        private static System.Timers.Timer timer = new System.Timers.Timer();
        private int counter;
        private System.Timers.Timer timer1 = new System.Timers.Timer();
        public Nokia(string _numero, string _modelo, string _imei, int _memoria) : base(_numero, _modelo, _imei, _memoria)
        {
        }


        // TODO: Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp)
        {
           timer.Elapsed =+ Timer_Elsapsed
           
            System.Console.Write("|||");
        }
        void Timer_Elapsed(object sender, ElapsedEventArgs e)
{
    nokia.InstalarAplicativo("WhatsApp");
    
    
}


        

    }
}