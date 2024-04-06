namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        protected Smartphone(string _numero, string _modelo, string _imei, int _memoria)
        {
            Numero = _numero;
            // TODO: Passar os parâmetros do construtor para as propriedades
            modelo = _modelo;
            imei = _imei;
            memoria = _memoria;
        }
        public string Numero { get; set; }
        // TODO: Implementar as propriedades faltantes de acordo com o diagrama
        private string modelo;
        private string imei;
        private int memoria;


        public void Ligar()
        {
            Console.WriteLine("Ligando...");

        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public string PegarModelo()
        {
            return modelo;
        }
        public abstract void InstalarAplicativo(string nomeApp);
    }
}