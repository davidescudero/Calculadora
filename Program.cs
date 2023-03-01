// Realizar una calculadora interactiva que permita sumar , restar , multiplicar y dividir dos numeros 
// 1- no se puede dividirpor cero 
// 2. debe tener una opcion de salida 
// 3. si selecciona una opcion incorrecta informarlo
// 4. mostrar un menu de seleccion 
int num1,num2,opcion;
do{
    Console.WriteLine("Calculadora \n"+
    "1. Suma\n"+
    "2. Resta\n"+
    "3. Multiplicacion\n"+
    "4. division\n"+
    "5. salir");

    opcion = Int32.Parse(Console.ReadLine());

    Console.WriteLine("Ingrese el primer numero");
    num1 = Int32.Parse(Console.ReadLine());

    Console.WriteLine("Ingrese el segundo numero");
    num2 = Int32.Parse(Console.ReadLine());

    switch (opcion)
    {
        case 1: 
            Console.WriteLine($"La suma de los numeros {num1} + {num2} es igual a { num1 + num2 }");
        break;
        case 2: 
            Console.WriteLine($"La resta de los numeros {num1} - {num2} es igual a { num1 - num2 }");
        break;
        case 3: 
            Console.WriteLine($"La multiplicacion de los numeros {num1} * {num2} es igual a { num1 * num2 }");
        break;
        case 4: 
            Console.WriteLine($"La suma de los numeros {num1} + {num2} es igual a { num1 + num2 }");
        break;
        case 5:
             if (num2 != 0 )
             {
                Console.WriteLine($"La division de los numeros {num1} / {num2} es igual a { num1 / num2 }");
             }else{
                Console.WriteLine("no puede dividir por cero ");

             }
        break;
        default: Console.WriteLine("Se digitó una opcion invalida");
        break;; 
    }

}while(opcion != 5);

