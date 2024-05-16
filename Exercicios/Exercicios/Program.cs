using Exercicios;

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
//diaSemana(6);
//diaSemana(7);
//lowerToUpper();
//CalculadoraSWITCHCASE(1,2,"+");
//CalculadoraSWITCHCASE(2,3,"**");
//CalculadoraSWITCHCASE(-1,0.5,"**");
//CalculadoraSWITCHCASE(1,2,"/");
//CalculadoraSWITCHCASE(2,0,"/");
//CalculadoraSWITCHCASE(5,7,"*");
//CalculadoraSWITCHCASE(6,8,"-");
//TabuadaFOR(2);
//TabuadaWHILE(3);
//TabuadaDOWHILE(4);
//TabuadaFOREACH(5);
//SomaDosImparesFOR(100);
//SomaDosImparesWHILE(100);
//SomaDosImparesFOREACH_LINQ(100);
//ContagemRegressivaWHILE();
//ContagemRegressivaFOR();
//ContagemRegressivaFOREACH();
//AdvinhaNumeroWHILE_TERNARIO();
//SenhaWHILE();
//Dado();
//Metodos funcao = new Metodos();
//funcao.Saudacao("Mundo");
//Console.WriteLine(funcao.Fatorial(4));
//Console.WriteLine(funcao.CalcularAreaRetangulo(5, 3));
//Metodos.Estatico();
//Arrays.consultaArray();
//Arrays.MudaValor();
//Arrays.ArrayDePaises();
//Arrays.MediaArray();
//Arrays.Matriz3x3Aurea();
//Arrays.ListaDePaises();
//Arrays.mediaLista();
//Arrays.ListagemPrimosAteN(100);
//Arrays.InversorDeArray(1, 42, 7, 9, 5);
Arrays.RemoveDuplicatas(1,2,2,3,4,8,7,7,7,9);
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

// Exercicios de (if) (if else) (else if) (operador ternário) (switch case)

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

// exercícios focados no switch case
void diaSemana(int dia)
{
    switch (dia)
    {
        case 1:
            System.Console.WriteLine("Domingo.");
            break;
        case 2:
            System.Console.WriteLine("Segunda.");
            break;
        case 3:
            System.Console.WriteLine("Terça.");
            break;
        case 4:
            System.Console.WriteLine("Quarta.");
            break;
        case 5:
            System.Console.WriteLine("Quinta.");
            break;
        case 6:
            System.Console.WriteLine("Sexta.");
            break;
        case 7:
            System.Console.WriteLine("Sábado.");
            break;
        default:
            break;
    }
}

void lowerToUpper()
{
    System.Console.Write("Digite uma letra: ");
    string letra = Console.ReadLine();
    string letraMaiuscula = letra.ToUpper();
    System.Console.WriteLine(letraMaiuscula);
}

void CalculadoraSWITCHCASE(int x, double y, string operacao)
{
    switch (operacao)
    {
        case "+":
            System.Console.WriteLine($"{x} + {y} = {x+y}");
            break;
        case "-":
            System.Console.WriteLine($"{x} - {y} = {x-y}");
            break;
        case "*":
            System.Console.WriteLine($"{x} x {y} = {x*y}");
            break;
        case "/":
            string respostaDivisao = (y == 0) ? "A divisão por zero não está definida." : $"{x} / {y} = {(double)x/(double)y}";
            System.Console.WriteLine(respostaDivisao);
            break;
        case "**":
            string respostaPotencia = ((x > 0) || (x == 0 && y > 0) || (x < 0 && y % 1 == 0)) ? 
            $"{x} ^ {y} = {Math.Pow((double)x, y)}" : 
            "Os números digitados não retornam apenas números reais como resultado, portanto, a operação não poderá ser realizada por essa calculadora. \nDesculpe.";
            System.Console.WriteLine(respostaPotencia);
            break;
        default:
            break;
    }
}

void TabuadaFOR(int n)
{
    for (int i = 1; i <= 10; i++)
    {
        System.Console.WriteLine($"{i} x {n} = {i*n}");
    }
}

void TabuadaWHILE(int n)
{
    int i = 1;
    while (i <= 10)
    {
        System.Console.WriteLine($"{i} x {n} = {i*n}");
        i++;
    }
}

void TabuadaDOWHILE(int n)
{
    int i = 1;

    do
    {
        System.Console.WriteLine($"{i} x {n} = {i*n}");
        i++;
    } while (i <= 10);
}

void TabuadaFOREACH(int n)
{
    foreach (int i in Enumerable.Range(1, 10))
    {
        System.Console.WriteLine($"{i} x {n} = {i*n}");
    }
}

void SomaDosImparesFOR(int n)
{
    int ultimoTermo = n/2;
    int soma = 0;

    /*
    for (int i = 1; i <= ultimoTermo; i++)
    {
        soma += 2*i - 1;
    }
    */

    for (int i = 1; i <= n; i += 2)
    {
        soma += i;
    }

    System.Console.WriteLine($"Através do loop FOR obtemos {soma} como resultado da soma dos ímpares entre 1 e {n}.");

    int a_n = (ultimoTermo % 2 == 0) ? (ultimoTermo-1) : ultimoTermo;
    int resultadoPA = n*(1+a_n)/2;

    System.Console.WriteLine($"Pela soma da PA, o resultado foi {resultadoPA}");
}

void SomaDosImparesWHILE(int n)
{
    int soma = 0;
    int i = 1;

    while (i <= n)
    {
        soma += i;
        i += 2;
    }

    System.Console.WriteLine($"A soma dos ímpares de 1 até {n} é {soma}.");
}

void SomaDosImparesFOREACH_LINQ(int n)
{
    int soma = 0;

    foreach (int i in Enumerable.Range(1, n).Where(x => x % 2 != 0))
    {
        soma += i;
    }

    System.Console.WriteLine($"A soma dos ímpares entre 1 e {n} é {soma}");
}

void ContagemRegressivaWHILE()
{
    int i = 10;

    while (i >= 0)
    {
        System.Console.WriteLine(i);
        i --;
    }
}

void ContagemRegressivaFOR()
{
    for (int i = 0; i <= 10; i++)
    {
        System.Console.WriteLine(10-i);
    }
}

void ContagemRegressivaFOREACH()
{
    foreach (int i in Enumerable.Range(0,11))
    {
        System.Console.WriteLine(10 - i);
    }
}

void AdvinhaNumeroWHILE_TERNARIO()
{
    Random aleatorio = new Random();

    int resposta = aleatorio.Next(1,101);

    System.Console.WriteLine("Nesse jogo você deve tentar acertar o número no qual eu estou pensando. Eu escolhi um número entre 1 e 100.");

    int palpite = -1;

    while (palpite != resposta)
    {
        System.Console.Write("Qual é o seu palpite? Digite: ");
        palpite = int.Parse(Console.ReadLine());

        if (palpite == resposta)
        {
            System.Console.WriteLine($"Parabéns! Você acertou. O número que eu pensei foi exatamente o {palpite}.");
            break;
        } else{
            string comparacao = (palpite < resposta) ? $"O número que eu pensei é maior que {palpite}" : $"O número que eu pensei é menor que {palpite}";
            System.Console.WriteLine($"Não... {comparacao}. Tente novamente.");
        }
    }
}

void SenhaWHILE()
{
    string senha = "123";
    string respostaUsuario = "-1";
    do
    {
        System.Console.Write("Senha: ");
        respostaUsuario = Console.ReadLine();
        if (respostaUsuario == senha)
        {
            System.Console.WriteLine("Login bem-sucedido.");
        } else{
            System.Console.WriteLine("Senha incorreta.");
        }
    } while(respostaUsuario != senha);
}

void Dado()
{
    System.Console.WriteLine("=================== Dado de 6 lados ===================");
    System.Console.WriteLine("Digite s para fechar o programa e qualquer outra letra para rolar novamente.");
    string resposta = "";
    Random aleatorio = new Random();
    int dado = aleatorio.Next(1,7);

    bool loop = true;

    do
    {
        System.Console.WriteLine($"Dado: {dado};");
        resposta = Console.ReadLine();
        dado = aleatorio.Next(1, 7);

        loop = (resposta == "s") ? false : true;

        if (!loop)
        {
            System.Console.WriteLine("Fim do Programa.");
        }

    } while(loop == true);
}