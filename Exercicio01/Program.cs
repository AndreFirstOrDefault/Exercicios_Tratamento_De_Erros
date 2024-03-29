﻿/* 3 - Escreva um program onde o usuário é solicitado a informar um valor via teclado e armazenar o valor na 
    variável entrada do tipo string onde tem que verificar 3 condições diferentes:

    a- Se a entrada é nula, uma exceção ArgumentNullException é lançada com a mensagem "A entrada não pode ser 
    nula." (Verifique a diferença entre ArgumentException e ArgumentNullException)

    b-Se a entrada está vazia, uma exceção ArgumentException é lançada com a mensagem "A entrada não pode estar 
    vazia."

    c-Se a entrada passar nas verificações anteriores, a entrada é exibida na tela.
    Realize o tratamento de erro para essas condições usando o bloco try-cath-finally
 
 */

Console.Title = "Exercicio 03";
//Console.Write("\nDigite uma palavra: ");
string palavra = null;

try
{
    
    if (palavra == "")
    {
        throw new ArgumentException();
    }
    else if (palavra == null)
    {
        throw new ArgumentNullException();
    }
    else
    {
        Console.WriteLine($"\nO usuario digitou : {palavra}");
    }
    
}
catch (ArgumentNullException) 
{
    Console.WriteLine("\nA entrada não pode ser nula");
}
catch (ArgumentException) 
{
    Console.WriteLine("\nA entrada não pode ser vazia");
   
}
catch(Exception ex)
{
    Console.WriteLine($"\nOcorreu um erro : {ex.Message}");
}
finally
{
    
    Console.WriteLine($"Processo finalizado...\n");
    
}



Console.ReadKey();