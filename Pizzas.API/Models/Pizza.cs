using System;

public class Pizza
{
    private int _Id;
    private string _Nombre;
    private bool _LibreGluten;
    private float _Importe;
    private string _Descripcion;
    public Pizza(int Id, string Nombre, bool LibreGluten, float Importe, string Descripcion)
    {
        _Id = Id; _Nombre = Nombre; _LibreGluten = LibreGluten; _Importe = Importe; _Descripcion = Descripcion;
    }
    public Pizza() {  }
    public int Id
    {
        get { return _Id; }
        set { _Id = value; }
    }
    public string Nombre
    {
        get { return _Nombre; }
        set { _Nombre = value; }
    }
    public bool LibreGluten
    {
        get { return _LibreGluten; }
        set { _LibreGluten = value; }
    }
    public float Importe
    {
        get { return _Importe; }
        set { _Importe = value; }
    }
    public string Descripcion
    {
        get { return _Descripcion; }
        set { _Descripcion = value; }
    }
}