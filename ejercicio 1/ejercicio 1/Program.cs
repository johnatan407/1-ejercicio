//2  numeros que haga las 4 operacones 
public class miprimeralgoritmo
{
    static void Main(string[] args)
    {
        // declraracion de variables
        int  num1, num2,suma,resta,cociente,producto;

        Console.Write("ingrese numero 1   ");
       num1 =Convert.ToInt32( Console.ReadLine());


        Console.Write("ingrese numero 2   ");
        num2 = Convert.ToInt32(Console.ReadLine());

        suma = num1 + num2;
        resta= num1 - num2;
        cociente = num1 / num2;
        producto = num1 * num2;

        Console.Write("la suma de los 2 numeros es "+suma);
        Console.Write(" \n ");
        Console.Write("la resa  de los 2 numeros es "+ resta);
        Console.Write(" \n ");
        Console.Write("el producto  de los 2 numeros es "+producto);
        Console.Write(" \n ");
        Console.Write("la cociente de los 2 numeros es "+cociente);





    }



}



