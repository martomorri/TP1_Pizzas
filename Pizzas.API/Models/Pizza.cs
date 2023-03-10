using System;

public class Pizza
{
    public int _id { get; private set; }
    public string _nombre { get; private set; }
    public double _importe { get; private set; }
    public bool _libreGluten { get; private set; }
    public string _descripcion { get; private set; }
    public Pizza(int id, string nombre, double importe, bool libreGluten, string descripcion)
    {
        _id = id; _nombre = nombre; _importe = importe; _libreGluten = libreGluten; _descripcion = descripcion;
    }
    public Pizza() { }
}