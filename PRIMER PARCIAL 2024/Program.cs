// Un string es una representacion en cadena de caracteres, este representa 2 bytes en la memoria.
//La diferencia entre las cadenas literales y las variables de tipo string es que las cadenas se encierran entre comillas "" mientras que las variables es el nombre que se le 
//da a las variables que se le asignan el tipo string ejemplo:

//string variable = "cadena literal";
//Console.WriteLine(variable);

//Para concatenar las cadenas se utiliza el operador "+", asi de simple, ejemplo:

//string conc = " concatenacion";
//Console.WriteLine(variable + conc);


// El metodo "length" es utilizado para obtener la longitud de una cadena,sin embargo esta mide posicion por posicion, es decir que toma tambien los espacios para medir la longitud.
//EJEMPLO

//string medir = "la longitud de una cadena";
//Console.WriteLine(medir.Length);


// El metodo "ToUpper" nos sirve para convertir a mayusculas los caracteres. Ejemplo

//string mayus = "fabian lobos";
//Console.WriteLine(mayus.ToUpper());


// El metodo "ToLower" nos sirve para convertir los caracteres a minusculas. Ejemplo

//string mayus = "DIMAS JIMENEZ";
//Console.WriteLine(mayus.ToLower());


// El metodo "IndexOf" nos sirve para encontrar la posicion en la primera ocurrencia, letra en una cadena. Ejemplo

//string oc = "murcielago";
//Console.WriteLine(oc.IndexOf('e'));


// El metodo "LastIndexOf" se encarga de buscr la posicion de la ultima ocurrencia o letra en una cadena. Ejemplo

//string ul = "fabian";
//Console.WriteLine(ul.LastIndexOf('a'));


// El metodo "SubString" lo que hace es extraer la subcadena de la posicion que se le pide en la cadena. Ejemplo

//string nom = "Fabian Jimenez Lobos";
//Console.WriteLine(nom.Substring(7));

// El metodo "Replace" lo que hace e reemplazar una subcadena por otra es decir que le podemos modificar un dato por otro diferente. Ejemplo

//string bla = "dimas fabian jimenez lobos";
//string red = bla.Replace("a", "Ñ");
//Console.WriteLine(red);


// El metodo "Trim" es utilizado para eliminar los espacios en una cadena al principio y al final de la misma. Ejemplo

//string l = "         Dimas Lobos   ";
//Console.WriteLine(l.Trim ());   

// El metodo "StartsWhit" nos sirve para validar que una cadena empiece con una cadena. Ejemplo

//string cad = "fabian jimenez lobos";
//bool comienzo = cad.StartsWith("fabian");
//if (comienzo == true)
//{
//    Console.WriteLine(cad);
//}
//else
//{
//    Console.WriteLine("Esta cadena no empieza por la cadena establecida");
//}


// El metodo "EndsWhith" nos ayuda a verificar si la cadena termina por la cadena establecida. Ejemplo

//string gg = "fabian jimenez lobos";
//bool ter = gg.EndsWith("lobos");
//if (ter== true)
//{
//    Console.WriteLine(gg);
//}else
//{
//    Console.WriteLine("No termina en la cadena establecida"); 
//}


// En los string se puede comparar las cadenas. Ejemplo

//string co = "fernando";
//string mpa = "fernan";

//bool s = co == mpa; // en este nos dice si las cadenas son iguales. 
//bool con= co != mpa;   // en este compaara si son diferentes.


// para concatenar cadenas se utiliza el poerador +. ejemplo

//string conc = "rayo";
//string atenar = "mcqueen";

//Console.WriteLine(conc + " " +  atenar);    


// En la busqueda de patrones se pueden utilizar el indexof o lastindexof o incluso con los endswith o startswith. 
// Con estas funciones podemos buscar algun patron que nos facilite la busqueda en archivos o listas muy largas.







//                  EJERCICIO 1


//try
//{

//    ulong num, opcion, factorial = 1; // el "ULONG" solo admite numeros enteros positivos en un rango alto de valores


//    do
//    {

//        Console.WriteLine("INTRODUZCA UN NUMERO ENTERO POSITIVO");
//        num = ulong.Parse(Console.ReadLine());


//        Console.WriteLine("OPCION 1: FACTORIAL");
//        Console.WriteLine("OPCION 2: RAIZ CUADRADA");
//        Console.WriteLine("OPCION 3: SALIR DEL PROGRAMA");
//        opcion = ulong.Parse(Console.ReadLine());



//        for (byte i = 1; i <= num; i++)
//        {
//            factorial *= i;

//        }


//        switch (opcion)
//        {
//            case 1:

//                Console.WriteLine($"El factorial de {num} es: {factorial}");
//                break;
//            case 2:
//                double raiz = Math.Sqrt(num);
//                Console.WriteLine($"La raiz cuadrada de {num} es: {raiz}");
//                break;
//            case 3:
//                Console.WriteLine("Saliendo del programa");
//                break;
//            default:
//                Console.WriteLine("Dato incorrecto");
//                break;


//        }

//    } while (opcion != 3);
//}catch(Exception ex)
//{
//    Console.WriteLine("Dato incorrecto");
//}








//              EJERCICIO 2




//double  suma, resta, multiplicacion, division;



//Console.WriteLine("INTRODUZCA EL PRIMER NUMERO");
//double numero1 = double.Parse( Console.ReadLine());

//Console.WriteLine("INTRODUZCA EL SEGUNDO NUMERO NUMERO");
//double numero2 = double.Parse(Console.ReadLine());

//Console.WriteLine("INTRODUZCA EL OPERADOR ENTRE '+', '-', '*', '/'");

//    string operador = Console.ReadLine();

//    switch (operador)
//    {
//        case "+":
//            suma = numero1 + numero2;
//            Console.WriteLine($"La suma entre {numero1} y {numero2} es: {suma}");

//            break;
//        case "-":
//            resta = numero1 - numero2;
//            Console.WriteLine($"La resta entre {numero1} y {numero2} es: {resta}");

//            break;
//        case "*":
//            multiplicacion = numero1 * numero2;
//            Console.WriteLine($"La multiplicacion entre {numero1} y {numero2} es: {multiplicacion}");

//            break;
//        case "/":
//            if (numero2 == 0)
//            {
//                Console.WriteLine("NO SE PUEDE DIVIDIR ENTRE 0");
//                return;
//            }
//            division = numero1 / numero2;
//            Console.WriteLine($"La division entre {numero1} y {numero2} es: {division}");
//            break;

//        default:
//            Console.WriteLine("Datos incorrectos, agregue bien los datos");
//            return;

//}







//                      EJERCICIO 3




//int multi, result;

//Console.WriteLine("INGRESE EL NUMERO PARA IMPRIMIR LA TABLA DE MULTIPLICAR HASTA EL 10");
//multi = int.Parse(Console.ReadLine());

//for (int i = 1; i <= 10; i++)
//{

//    result = i * multi;

//    Console.WriteLine($"{multi} x {i} = {result}");

//}



//int respuesta, rep = 0;
//Random random = new Random();
//int numero = random.Next(1, 50);
//do
//{
//    rep++;

//    Console.WriteLine("Adivine un numero entre el 1 al 50");
//     respuesta = int.Parse(Console.ReadLine());

//    if (respuesta < numero)
//    {
//        Console.WriteLine("Te quedas corto!!, sigue intentando");
//    }
//    if (respuesta > numero  )
//    {
//        Console.WriteLine("Te pasaste!!, sigue intentando");
//    }
//    if(respuesta == numero)
//    {
//        Console.WriteLine($"Felicidades acertaste el numero: {numero}");

//    }
//} while (numero != respuesta);


//Console.WriteLine($"Tardaste {rep} intentos");



