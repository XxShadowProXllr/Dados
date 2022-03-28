// Definicion De Lineas Principales
    // Mensajes Iniciales
Console.WriteLine("Bienvenido al programa para marcador en un juego de dados.");
Console.WriteLine("");
// Fin Mensajes Iniciales

// Definicion De Variables
    // Variables Principales
    // Datos Jugador 1
    var puntaje1 = "0";
    // Las Variables Char e Int Son para los datos como nombre y puntaje del jugador //
    string nombre1 = "none";
    
    // Datos Jugador 2
    var puntaje2 = "0";
    // Las Variables Char e Int Son para los datos como nombre y puntaje del jugador //
    string nombre2 = "none";
    
    // Datos Jugador 3
    var puntaje3 = "0";
    // Las Variables Char e Int Son para los datos como nombre y puntaje del jugador //
    string nombre3 = "none";
// Fin De Definicion De Variables

// Inicio Ingreso De Datos De Jugador
    // Jugador 1
Console.WriteLine("Porfavor Introduzca El Nombre Del Jugador 1: ");
// lee la entrada del usuario y la guarda en una variable (espacio en memoria)
nombre1 = Console.ReadLine();
//Console.WriteLine("");
Console.WriteLine("Muchas Gracias!");
Console.WriteLine("");
// Fin Ingreso De Datos De Jugador

// Inicio De Datos Numericos Jugador
    // Puntuacion Jugador 1
Console.WriteLine("");
Console.WriteLine("Porfavor Introduzca La Puntuacion Del Jugador 1: ");
// lee la entrada del usuario y la guarda en una variable (espacio en memoria)
puntaje1 = Console.ReadLine();
        // Convierte la variable de Convertir String a Int32 para ser guardada en una variable para su uso
var puntaje_11 = Convert.ToInt32(puntaje1);
//Console.WriteLine("");
Console.WriteLine("Muchas Gracias Por Su Colaboracion!");
Console.WriteLine("");
// Fin De Datos Numericos Jugador

// Inicio Ingreso De Datos De Jugador
    // Jugador 2
Console.WriteLine("Porfavor Introduzca El Nombre Del Jugador 2: ");
// lee la entrada del usuario y la guarda en una variable (espacio en memoria)
nombre2 = Console.ReadLine();
//Console.WriteLine("");
Console.WriteLine("Muchas Gracias!");
Console.WriteLine("");
// Fin Ingreso De Datos De Jugador


// Inicio De Datos Numericos Jugador
    // Puntuacion Jugador 2
Console.WriteLine("");
Console.WriteLine("Porfavor Introduzca La Puntuacion Del Jugador 2: ");
// lee la entrada del usuario y la guarda en una variable (espacio en memoria)
puntaje2 = Console.ReadLine();
        // Convierte la variable de Convertir String a Int32 para ser guardada en una variable para su uso
var puntaje_22 = Convert.ToInt32(puntaje2);
//Console.WriteLine("");
Console.WriteLine("Muchas Gracias Por Su Colaboracion!");
Console.WriteLine("");
// Fin De Datos Numericos Jugador

// Inicio Ingreso De Datos De Jugador
    // Jugador 3
Console.WriteLine("Porfavor Introduzca El Nombre Del Jugador 3: ");
// lee la entrada del usuario y la guarda en una variable (espacio en memoria)
nombre3 = Console.ReadLine();
//Console.WriteLine("");
Console.WriteLine("Muchas Gracias!");
Console.WriteLine("");
// Fin Ingreso De Datos De Jugador

// Inicio De Datos Numericos Jugador
        // Puntuacion Jugador 3
//Console.WriteLine("");
Console.WriteLine("Porfavor Introduzca La Puntuacion Del Jugador 3: ");
// lee la entrada del usuario y la guarda en una variable (espacio en memoria)
puntaje3 = Console.ReadLine();
        // Convierte la variable de Convertir String a Int32 para ser guardada en una variable para su uso
var puntaje_33 = Convert.ToInt32(puntaje3);
//Console.WriteLine("");
Console.WriteLine("Muchas Gracias Por Su Colaboracion!");
Console.WriteLine("");
// Fin De Datos Numericos Jugador

// Inicio De Condicionales
    // Jugador 1
if (puntaje_11 > puntaje_22 && puntaje_11 > puntaje_33) {
    // Concatena Las palabras y las variables necesarias
    Console.WriteLine("El Ganador Es: "+ nombre1 + "" +" Con una puntuacion de: " + puntaje_11);
    Console.WriteLine("Muchas Gracias Por Jugar!!");
}
// Fin De Condicionales 

// Inicio De Condicionales
    // Jugador 1
if (puntaje_22 > puntaje_11 && puntaje_22 > puntaje_33) {
    // Concatena las palabras y las variables necesarias
    Console.WriteLine("El Ganador Es: "+ nombre2 + "" + " Con una puntuacion de: "+ puntaje_22);
    Console.WriteLine("Muchas Gracias Por Jugar!!");
}
// Fin De Condicionales 

// Inicio De Condicionales
    // Jugador 1
if (puntaje_33 > puntaje_11 && puntaje_33 > puntaje_22) {
    // Concatena las palabras y variables necesarias
    Console.WriteLine("El Ganador Es: "+ nombre3 + "" + " Con una puntuacion de: " + puntaje_33);
    Console.WriteLine("Muchas Gracias Por Jugar!!");
}
// Fin De Condicionales 

