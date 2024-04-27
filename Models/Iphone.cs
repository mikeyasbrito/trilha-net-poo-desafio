namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    //resolvido
    public class Iphone : Smartphone
    {
        
        public Iphone(string numero, string modelo, string Imei, int memoria) : base(numero, modelo, Imei, memoria)
        {

        }

        // TODO: Sobrescrever o método "InstalarAplicativo"
        //resolvido
        public override void InstalarAplicativo(string nomeApp)
        {
            System.Console.WriteLine($"instalando {nomeApp} no Iphone");
        }
    }
}