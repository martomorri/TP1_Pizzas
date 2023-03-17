using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using System.Data;
using System.Data.SqlClient;
using Dapper;
using Pizzas.API.Models;

public static class BD
{
    private static string CONNECTION_STRING = @"Persist Security Info=False;User ID=Pizzas;password=VivaLaMuzza123;Initial Catalog=DAI-Pizzas;Data Source=.;";
    public static List<Pizza> GetAll()
    {
        using (SqlConnection db = new SqlConnection(CONNECTION_STRING))
        {
            string sp = "ListarPizzas";
            return db.Query<Pizza>(sp, commandType: CommandType.StoredProcedure).ToList();
        }
    }
    public static Pizza GetById(int id)
    {
        using (SqlConnection db = new SqlConnection(CONNECTION_STRING))
        {
            string sp = "ListarPizzaXId";
            return db.Query<Pizza>(sp, new { @Id = id }, commandType: CommandType.StoredProcedure);
        }
    }
    public static int Insert(Pizza pizza)
    {
        using (SqlConnection db = new SqlConnection(CONNECTION_STRING))
        {
            string sp = "CrearPizza";
            return db.Execute(sp, new { @nombre = pizza.Nombre, @libreGluten = pizza.LibreGluten, @importe = pizza.Importe, @descripcion = pizza.Descripcion }, commandType: CommandType.StoredProcedure);
        }
    }
    public static int UpdateById(Pizza pizza)
    {
        using (SqlConnection db = new SqlConnection(CONNECTION_STRING))
        {
            string sp = "ActualizarPizza";
            return db.Execute(sp, new { @id = pizza.Id, @nombre = pizza.Nombre, @libreGluten = pizza.LibreGluten, @importe = pizza.Importe, @descripcion = pizza.Descripcion }, commandType: CommandType.StoredProcedure);
        }
    }
    public static int DeleteById(int id)
    {
        using (SqlConnection db = new SqlConnection(CONNECTION_STRING))
        {
            string sp = "EliminarPizza";
            return db.Execute(sp, new { @id = id }, commandType: CommandType.StoredProcedure);
        }
    }
}