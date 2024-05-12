
//Euclides(1001,109);
//SomaDivisoresDeTres();
//ParidadeIF_ELSE(7);
//ParidadeTERNARIO(8);
//CalculoIMC_ELSEIF(85,1.7);
//CalculoIMC_IF_TERNARIO(85,1.7);
//CalculoIMC_SwitchCase_TERNARIO(85,1.7);
//ClassificadorNotas_ELSEIF(81);
//ClassificadorNotas_NestedTERNARIO(92);
//TrianguloExistenciaClassificacao(3,4,5);
//TrianguloExistenciaClassificacao(5,5,5);
//TrianguloExistenciaClassificacao(1,2,2);
//TrianguloExistenciaClassificacao(500,3,9);
//MaioridadeTERNARIO(25);
//MaioridadeSWITCHCASE(16);
//PositivoNegativo(30);
//PositivoNegativo(0);
//PositivoNegativo(-1);
//Primalidade(7);
//Primalidade(2);
//Primalidade(3);
//Primalidade(4);
//Primalidade(5);
//Primalidade(6);
//Primalidade(8);
//Primalidade(49);
//Primalidade(73);

void Euclides(int x, int y)
{
    int q = x/y;
    int r = x%y;

    do
    {
        q=x/y;
        r=x%y;
        System.Console.WriteLine($"{x} = {y}x{q} + {r}");
        x = y;
        y = r;
    } while (r != 0);
}

void SomaDivisoresDeTres()
{
    int soma = 0;
    for (int i = 1; i <= 20; i++)
    {
        int incremento = i%3 == 0 ? i : 0;
        soma += incremento;
    }
    Console.WriteLine($"A soma dos divisores de 3 entre 1 e 20, incluindo os extremos, é {soma}.");
}

void ParidadeIF_ELSE(int n)
{
    if (n%2 == 0)
    {
        Console.WriteLine($"{n} é um número par.");
    } else {
        Console.WriteLine($"{n} é ímpar.");
    }
}

void ParidadeTERNARIO(int n)
{
    string paridade = (n%2 == 0) ? $"{n} é par." : $"{n} é  ímpar.";
    Console.WriteLine(paridade);
}

void CalculoIMC_ELSEIF(int peso, double altura)
{
    double imc = peso/(Math.Pow(altura, 2));
    if (imc < 18.5)
    {
        System.Console.WriteLine($"Seu índice é {imc}, portanto você está abaixo do peso.");
    } else if ((18.5 <= imc) && (imc <= 24.9)){
        System.Console.WriteLine($"Parabéns, você está no peso ideal. Seu índice é {imc}.");
    } else {
        System.Console.WriteLine($"Seu índice é {imc}, portanto você está acima do peso.");
    }
}

void CalculoIMC_IF_TERNARIO(int peso, double altura)
{
    double imc = peso/(Math.Pow(altura, 2));
    if ((18.5 <= imc) && (imc <= 24.9))
    {
        Console.WriteLine($"Parabéns, você está no peso ideal. Seu índice é {peso/(Math.Pow(altura, 2))}.");
    } else {
        string mensagemNegativa = (peso/(Math.Pow(altura, 2)) < 18.5) ? $"Seu índice é {peso/(Math.Pow(altura, 2))}, portanto você está abaixo do peso." : $"Seu índice é {peso/(Math.Pow(altura, 2))}, portanto você está acima do peso.";
        System.Console.WriteLine(mensagemNegativa);
    }
}

void CalculoIMC_SwitchCase_TERNARIO(int peso, double altura)
{
    double imc = peso/(Math.Pow(altura, 2));
    string resultado = ((18.5 <= imc) && (imc <= 24.9)) ? "saudavel" : (imc < 18.5 ? "magro" : "gordo");

    switch (resultado)
    {
        case "saudavel":
            System.Console.WriteLine($"Parabéns, você está no peso ideal. Seu índice é {imc}.");
            break;
        case "magro":
            System.Console.WriteLine($"Seu índice é {imc}, portanto você está abaixo do peso.");
            break;
        case "gordo":
            System.Console.WriteLine($"Seu índice é {imc}, portanto você está acima do peso.");
            break;
        default:
            break;
    }
}

void ClassificadorNotas_ELSEIF(int nota)
{
    if (nota >= 90)
    {
        System.Console.WriteLine("A");
    } else if(nota >= 80) {
        System.Console.WriteLine("B");
    } else if(nota>=70){
        System.Console.WriteLine("C");
    } else{
        System.Console.WriteLine("D");
    }
}

void ClassificadorNotas_NestedTERNARIO(int nota)
{
    string resultado = (nota >=90 ? "A" : (nota >= 80 ? "B" : (nota >= 70 ? "C":"D")));
    System.Console.WriteLine(resultado);
}

void TrianguloExistenciaClassificacao(double a, double b, double c)
{
    // Vamos verificar a desigualdade triangular. Temos três escolhe dois casos para verificar todos os casos, isso dá 3 verificações.
    // Poderiamos ordenar os três números e comparar somente o maior com a soma dos dois menores, mas vamos fazer todas as comparações.
    bool caso1 = (a <= b + c) ? true : false;
    bool caso2 = (b <= a + b) ? true : false;
    bool caso3 = (c <= a + b) ? true : false;

    if (caso1 && caso2 && caso3)
    {
        //Vamos verificar se um triangulo é equilatero, pois se for, ele tbm é isoceles e não pode ser escaleno.
        //Em seguida, vamos verificar se o triangulo é isoceles (caso não seja equilatero).

        bool equilatero = ((a == b) && (a == c)) ? true : false;
        bool isoceles = (b == c) ? true : ((a == b) ? true : (a == c ? true : false));

        if (equilatero)
        {
            System.Console.WriteLine($"O triângulo de lados {a}, {b} e {c} é equilatero e, portanto, também é isoceles.");
        } else if(isoceles){
            System.Console.WriteLine($"O triângulo de lados {a}, {b} e {c} é isoceles.");
        } else{
            System.Console.WriteLine($"O triângulo de lados {a}, {b} e {c} é escaleno.");
        }
    } else{
        System.Console.WriteLine("Os números digitados não formam um triângulo, pois contraria a desigualdade triangular.");
    }
}

void MaioridadeTERNARIO(int idade)
{
    string maioridade = (idade < 18) ? "Menor de idade." : "Maior de idade.";
    System.Console.WriteLine(maioridade);
}

void MaioridadeSWITCHCASE(int idade)
{
    bool maioridade = (idade < 18) ? true : false;

    switch (maioridade)
    {
        case true:
            System.Console.WriteLine("Menor de idade.");
            break;
        case false:
            System.Console.WriteLine("Maior de idade.");
            break;
        default:
            break;
    }
}

void PositivoNegativo(int n)
{
    string sinal = (n < 0) ? $"O número {n} negativo" : (n == 0 ? $"O número {n} não é nem positivo nem negativo" : $"O número {n} é positivo.");
    System.Console.WriteLine(sinal);
}

void Primalidade(int n)
{
    int raizDeN = (int)Math.Pow(n, 0.5);
    int divisorDeN = -1;
    bool primo = true;

    if ((n == 2) || (n == 3))
    {
        primo = true;
        System.Console.WriteLine($"Sim, {n} é um número primo!");
        return;
    }
    
    for (int i = 2; i <= raizDeN; i++)
    {
        bool divisor = (n % i == 0) ? true : false;
        if (divisor)
        {
            primo = false;
            divisorDeN = i;
            break;
        }
    }
    string resposta = primo ? $"Sim! O número {n} é primo!" : $"Não. O número {n} não é primo, pois {divisorDeN} divide {n}.";
    System.Console.WriteLine(resposta);
}