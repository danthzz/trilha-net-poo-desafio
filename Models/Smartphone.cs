namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        private string Modelo { get; }
        private string Imei { get; }
        private int Memoria { get; }


        public Smartphone(string numero, string Modelo, string Imei, int Memoria)
        {
            this.Numero = numero;
            this.Modelo = Modelo;
            this.Imei = Imei;
            this.Memoria = Memoria;
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

         public void MostrarNumero()
        {
            Console.WriteLine("Número deste celular é : " + Numero);
        }
        

        public abstract void InstalarAplicativo(string nomeApp);
    }
}