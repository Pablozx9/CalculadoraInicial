string continuar = "s";
while (continuar.ToLower() == "s")
{
     
    Console.WriteLine("Digite Dois Números");
        double number1 = double.Parse(Console.ReadLine());
        double number2 = double.Parse(Console.ReadLine());

    Console.WriteLine("Escolha escolha uma operação: \n 1 : Adição \n 2 : Subtração \n 3 : Multiplicação \n 4 : Divisão");
        int escolha = int.Parse(Console.ReadLine());

        double resultado = 0;

switch (escolha)
{
    case 1:
        resultado = number1 + number2;
        Console.WriteLine($"O resultado da adição de {number1} + {number2} = {resultado}");
        break;
    case 2:
        resultado = number1 - number2;
        Console.WriteLine($"O resultado da subtração de {number1} - {number2} = {resultado}");
        break;
    case 3:
        resultado = number1 * number2;
        Console.WriteLine($"O resultado da multiplicação de {number1} X {number2} = {resultado}");
        break;
    case 4:
        resultado = number1 / number2;
        Console.WriteLine($"O resultado da divisão de {number1} / {number2} = {resultado}");
        break;
    default:
        Console.WriteLine("Operação invalida");
        break;
}

    Console.WriteLine("Deseja realizar outra operação? (s/n)");
    continuar = Console.ReadLine();
}