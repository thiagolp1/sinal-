int numerod;

Console.Write("Digite um número: ");
numerod = Convert.ToInt32(Console.ReadLine());

if (numerod <0)
{    
    Console.WriteLine("Negativo");
}    
else if (numerod >0)
{
    Console.WriteLine("Positvo");
}    
else 
{
    Console.WriteLine("Zero");
}        