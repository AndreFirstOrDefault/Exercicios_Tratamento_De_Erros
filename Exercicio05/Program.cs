/*
 5- Dado um array de inteiros expresso da seguinte forma
    int[] numeros = new int[] { 109, 211, 313, 405, 519, 617, 711, 891, 951, 1001 };
    Exiba na janela do console os numeros do array e solicite via teclado ao usuário para informar o valor de um índice 
    do array para obter o seu respectivo valor.

    Realize o tratamento de exceções filtrando as exceções IndexOutOfRangeException e ArgumentNullException
 */

int[] numeros = new int[] { 109, 211, 313, 405, 519, 617, 711, 891, 951, 1001 };

// Exibindo numeros do array

for(int i = 0; i < numeros.Length; i++)
{
    Console.Write(numeros[i] + ", ");
    if(i == numeros.Length - 1)
    {
        Console.WriteLine(numeros[i] + ".");
    }
}


try
{
    Console.Write("\nDigite o número do indice que gostaria de consultar: ");
    int indice = int.Parse(Console.ReadLine());
    
    Console.WriteLine($"\nNúmero corresponde ao indice: {numeros[indice]}\n");
    
}
catch (IndexOutOfRangeException e)
{
    Console.WriteLine($"\nOcorreu uma excessão: {e.GetType()}, {e.Message}");
}
catch (ArgumentNullException e)
{
    Console.WriteLine($"\nOcorreu uma excessão: {e.GetType()}, {e.Message}");
}
catch (Exception e)
{
    Console.WriteLine($"\nOcorreu uma excessão: {e.GetType()}, {e.Message}");
}


Console.ReadKey();