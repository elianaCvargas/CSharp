using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de Persona
/// </summary>
public class Persona
{
    public string nombre;
    public int dni;

	public Persona(string name, int dni)
	{
        this.nombre = name;
        this.dni = dni;
	}
}