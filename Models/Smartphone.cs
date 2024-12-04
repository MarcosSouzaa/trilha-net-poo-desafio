
namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        //Implementar as propriedades faltantes de acordo com o diagrama
        protected string Modelo { get; set; }
        protected string Imei { get; set; }
        protected int Memoria { get; set; } 

        public Smartphone(string numero, String modelo, string imei, int memoria)
        {
            // Passar os parâmetros do construtor para as propriedades     
            Numero = numero;
            Modelo = modelo;
            Imei = imei;
            Memoria = memoria; 
         }          

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}
   