using System.Timers;

namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {

        public Nokia(string _numero, string _modelo, string _imei, int _memoria) : base(_numero, _modelo, _imei, _memoria)
        {
        }


        // TODO: Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp)
        {
           
            System.Console.WriteLine($"Instalando {nomeApp}, no seu smartaphone Nokia");
           for (int i = 0; i < 10; i++)
            {
            System.Console.Write("||||||||||||" );
            System.Threading.Thread.Sleep( 1000 );
            
            }

             System.Console.WriteLine($"\nInstalação concluída...");


         
        }
      


       
    }
}