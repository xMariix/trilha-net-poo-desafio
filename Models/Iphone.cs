
namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    //IMPLEMENTADO!!!
    public class Iphone : Smartphone
    {

        public Iphone(string numero) : base(numero)
        {
        }

        // TODO: Sobrescrever o método "InstalarAplicativo"
        //IMPLEMENTADO!!!
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Aplicativo {nomeApp} instalado com sucesso, no Smartphone {Modelo}!");
        }

    
    }
}