namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        private string Modelo { get; set; }
        private string IMEI { get; set; }
        private int Memoria { get; set; }

        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
        }

        public void Ligar(string numero)
        {
            Console.WriteLine($"Ligando para o número {numero}.");
        }

        public void ReceberLigacao(string numero)
        {
            Console.WriteLine($"Recebendo ligação do número {numero}.");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}