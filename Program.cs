using System;
using System.Collections.Generic;
using POO_app_Ejemplo;
using POO_app_Ejemplo.Models;
using static POO_app_Ejemplo.Models.SuperHeroe;
using static POO_app_Ejemplo.Models.Superpoder;


Console.WriteLine("Hello, World!");

// Crea una instancia de SuperHeroe usando el constructor con parámetros
var superman = new SuperHeroe(
    id: 1,
    nombre: "   Superman    ",
    identidadSecreta: "Clark Kent",
    ciudad: "Metropolis",
    puedeVolar: true,
    superPoderes: new List<Superpoder>() //lista vacía

);
ImprimirInfo.ImprimirSuperHeroe(superman);

var wolverine = new AntiHeroe
{
    Id = 2,
    Nombre = "Wolverine",
    IdentidadSecreta = "Logan",
    Ciudad = "New York",
    PuedeVolar = false,
    SuperPoderes = new List<Superpoder>(),
};

string accionAntiHeroe = wolverine.RealizarAccionDeAntiheroe("Ataca a la policia");
Console.WriteLine(accionAntiHeroe);

// Crea una instancia de Superpoder para "Volar"
Superpoder poderVolar = new Superpoder(
    nombre: "Volar",
    descripcion: "Capacidad para volar y planear en el aire.",
    nivel: NivelPoder.Nivel2
);

// Crea una instancia de Superpoder para "Superfuerza"
Superpoder superfuerza = new Superpoder(
    nombre: "Superfuerza",
    descripcion: null, // No se proporciona descripción
    nivel: NivelPoder.Nivel3
);

// Crea una instancia de Superpoder para "Regeneración"
Superpoder regeneracion = new Superpoder(
    nombre: "Regeneración",
    descripcion: null, // No se proporciona descripción
    nivel: NivelPoder.Nivel3
);

// Crea una lista de superpoderes y la asigna a Wolverine
List<Superpoder> poderesWolverine = new List<Superpoder> { regeneracion, superfuerza };
wolverine.SuperPoderes = poderesWolverine;



// Crea una lista de superpoderes y la asigna a Superman
List<Superpoder> poderesSuperman = new List<Superpoder> { poderVolar, superfuerza };
superman.SuperPoderes = poderesSuperman;
string resultSalvarAlMundo = superman.SalvarElMundo();
string resultSalvarLaTierra = superman.SalvarLaTierra();

// Impresión de prueba
Console.WriteLine($"Id: {superman.Id}");
Console.WriteLine($"Nombre: {superman.Nombre}");
Console.WriteLine($"Identidad Secreta: {superman.IdentidadSecreta}");
Console.WriteLine($"Ciudad: {superman.Ciudad}");
Console.WriteLine($"Puede Volar: {superman.PuedeVolar}");
Console.WriteLine("Superpoderes:");
Console.WriteLine(resultSalvarAlMundo);
Console.WriteLine(resultSalvarLaTierra);
foreach (var poder in superman.SuperPoderes)
{
    Console.WriteLine($"- {poder.Nombre} (Nivel: {poder.Nivel})" +
        (string.IsNullOrEmpty(poder.Descripcion) ? "" : $", Descripción: {poder.Descripcion}"));
}


Console.WriteLine($"Id: {wolverine.Id}");
Console.WriteLine($"Nombre: {wolverine.Nombre}");
Console.WriteLine($"Identidad Secreta: {wolverine.IdentidadSecreta}");
Console.WriteLine($"Ciudad: {wolverine.Ciudad}");
Console.WriteLine($"Puede Volar: {wolverine.PuedeVolar}");
Console.WriteLine("Superpoderes:");
foreach (var poder in wolverine.SuperPoderes)
{
    Console.WriteLine($"- {poder.Nombre} (Nivel: {poder.Nivel})" +
        (string.IsNullOrEmpty(poder.Descripcion) ? "" : $", Descripción: {poder.Descripcion}"));
}


public record SuperHeroeRecord(int Id, string Nombre, string IdentidadSecreta);