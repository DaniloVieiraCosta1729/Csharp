/*
int @int = 10;
Console.WriteLine(@int*10);
Console.WriteLine("É muito difícil obter " + (@int*10).ToString() + " de precisão no chess.com");
*/

UnitCoverter mTocm = new UnitCoverter(100);
UnitCoverter m3ToL = new UnitCoverter(1000);

Console.WriteLine(m3ToL.Convert(23));
Console.WriteLine(mTocm.Convert(32));

Assinatura meuNome = new Assinatura("Danilo Vieira Costa");

Console.WriteLine(meuNome.escrever("Olá, esse é o teste que estou fazendo da criação de tipos com C#."));

Assinatura agradecimento = new Assinatura("Obrigado!");

Console.WriteLine(agradecimento.escrever("O seu produto já está a caminho de sua residencia. Para informações mais detalhadas, favor acessar a área do cliente."));

public class UnitCoverter
{
    int ratio; // This is a field

    public UnitCoverter(int unitRatio) // this is a constructor
    {
        this.ratio = unitRatio;
    }

    public int Convert(int unit) // this is a method
    {
        return unit * ratio;
    }
}
// Agora que temos nosso Custom Type, nos podemos usá-lo para criar convesores de unidade.

// Vamos declarar dois conversores, um que converte metros para centimetros e outro que converte metros cubicos para litros.

/*
 Basicamente, nos criamos um tipo chamado UnitConverter que possui um método que recebe um número inteiro que será multiplicado por um fator.
Perceba que isso é bem mais flexível que uma função, pois podemos crias vários conversores. Podemos criar um tipo de dado que tenha o propósito de
adicionar um texto no final de um outro texto.
 */


public class Assinatura
{
    //campo
    string assign;

    //construtor
   public Assinatura(string marca)
    { assign = marca; }

    public string escrever(string texto)
    {
        return texto + "\n" + assign;
    }
}