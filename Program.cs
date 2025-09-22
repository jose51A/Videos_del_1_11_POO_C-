using System;
using System.Collections.Generic;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// Inicialización usando el constructor con parámetros
var superman = new SuperHeroe(
    id: 1,
    nombre: "Superman",
    identidadSecreta: "Clark Kent",
    ciudad: "Metropolis",
    puedeVolar: true,
    superPoderes: new List<Superpoder>()
);

// Creación de instancias de superpoder usando el constructor
Superpoder poderVolar = new Superpoder(
    nombre: "Volar",
    descripcion: "Capacidad para volar y planear en el aire.",
    nivel: Superpoder.NivelPoder.Nivel2
);

Superpoder superfuerza = new Superpoder(
    nombre: "Superfuerza",
    descripcion: null,
    nivel: Superpoder.NivelPoder.Nivel3
);

// Asignación de superpoderes a un listado
List<Superpoder> poderesSuperman = new List<Superpoder> { poderVolar, superfuerza };

// Asignando la lista al superhéroe
superman.SuperPoderes = poderesSuperman;

// Clase pública con métodos de diferentes niveles de acceso
public class SuperHeroe
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public string IdentidadSecreta { get; set; }
    public string Ciudad { get; set; }
    public List<Superpoder> SuperPoderes { get; set; }
    public bool PuedeVolar { get; set; }

    // Constructor vacío
    public SuperHeroe() { }

    // Constructor con parámetros
    public SuperHeroe(int id, string nombre, string identidadSecreta, string ciudad, bool puedeVolar, List<Superpoder> superPoderes)
    {
        Id = id;
        Nombre = nombre;
        IdentidadSecreta = identidadSecreta;
        Ciudad = ciudad;
        PuedeVolar = puedeVolar;
        SuperPoderes = superPoderes;
    }

    // Método público
    public void UsarSuperpoder()
    {
        // Implementación
    }

    // Método privado
    private void MetodoPrivado()
    {
        // Implementación
    }

    // Método internal
    internal void MetodoInterno()
    {
        // Solo accesible dentro del mismo proyecto
    }

    // Método protected internal
    protected internal void MetodoProtegidoInterno()
    {
        // Accesible en clases derivadas dentro del mismo ensamblado
    }
}

// Clase interna (internal)
internal class Superpoder
{
    public string Nombre { get; set; }
    public string Descripcion { get; set; }
    public NivelPoder Nivel { get; set; }

    // Constructor vacío
    public Superpoder() { }

    // Constructor con parámetros
    public Superpoder(string nombre, string descripcion, NivelPoder nivel)
    {
        Nombre = nombre;
        Descripcion = descripcion;
        Nivel = nivel;
    }

    public enum NivelPoder
    {
        Nivel1,
        Nivel2,
        Nivel3
    }
}