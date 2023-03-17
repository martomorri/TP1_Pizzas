using System;

public class Pizza
{
    public int _Id { get; private set; }
    public string _Nombre { get; private set; }
    public bool _LibreGluten { get; private set; }
    public float _Importe { get; private set; }
    public string _Descripcion { get; private set; }
    public Pizza(int Id, string Nombre, bool LibreGluten, float Importe, string Descripcion)
    {
        _Id = Id; _Nombre = Nombre; _LibreGluten = LibreGluten; _Importe = Importe; _Descripcion = Descripcion;
    }
    public Pizza() { }
}