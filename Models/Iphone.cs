namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        // TODO: Sobrescrever o método "InstalarAplicativo"
      public Iphone(string numero, string imei, int memoria,string modelo) : base(numero,imei,memoria,modelo)
        {
            Console.WriteLine($"Numero do Telefone: {numero}");
            
            Console.WriteLine($"Numero do Imei: {imei}");
            Console.WriteLine($"Quantidade de Memoria :{memoria} Bits");
            Console.WriteLine($"Modelo do Nokia: {modelo}");
        }
     
        public override void InstalarAplicativo(string nomeDoApp) 
        {
              //throw new NotImplementedException();
              Console.WriteLine($"Instalação  do Aplicativo do  {nomeDoApp} no smartphone Iphone");
        }
    }
}