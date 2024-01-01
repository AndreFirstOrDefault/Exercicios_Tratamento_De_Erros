/*  4- Escreva um programa que solicite ao usuário a informação da idade e do nome via teclado que deverão ser 
    armazenados nas variáveis idade do tipo int e nome do tipo string.
    A seguir realize o tratamento de erro e lançando as exceções considerando as seguintes condições:

    a- Se a idade é negativa, uma exceção ArgumentException é lançada com a mensagem "A idade não pode ser 
    negativa."

    b - Se a idade é zero, uma exceção NotImplementedException é lançada com a mensagem "A idade ainda não foi 
    definida."

    c- Se o nome é nulo ou vazio, uma exceção NullReferenceException é lançada com a mensagem "O nome não pode 
    ser nulo nem vazio"
    Nota: No item c use a expressão string.IsNullOrEmpty(nome)para verificar se o nome é null ou 
    vazio.
 
 */



try
{
    Console.Write("Digite seu nome: ");
    string nome = Console.ReadLine();
    Console.Write("Digite sua idade: ");
    int idade = int.Parse(Console.ReadLine());
    //a - tratando a idade negativa
    if (idade < 0)
    {
        throw new ArgumentException();
    }
    //b - se a idade for 0
    else if(idade == 0)
    {
        throw new NotImplementedException();
    }
    if(string.IsNullOrEmpty(nome))
    {
        throw new NullReferenceException();
    }

}
catch (ArgumentException ex)
{
    Console.WriteLine($"\n{ex.GetType()} : A idade não pode ser negativa.\n");
}
catch (NotImplementedException ex)
{
    Console.WriteLine($"\n{ex.GetType()} : A idade ainda não foi definida\n");
}
catch (NullReferenceException ex)
{
    Console.WriteLine($"\n{ex.GetType()} : O nome não pode ser nulo e nem vazio\n");
}
catch (Exception ex)
{
    Console.WriteLine($"\nOcorreu uma exceção: {ex.GetType()}");
}

Console.ReadKey();