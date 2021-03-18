using System;
using System.Linq;
using TAREA1_BACKEND.Northwind;
namespace TAREA1_BACKEND
{
    class Program
    {
        //SELECT ProductName, UnitPrice, UnitsInStock FROM Products
        //WHERE CategoryID = '4'
        public static void Product()
        {
            var ProductQry = new NorthwindContext().Products.Select(S => new {
                S.ProductName,
                S.UnitPrice,
                S.UnitsInStock,
                S.CategoryId
            }).Where(W => W.CategoryId == '4').AsQueryable();

            var output = ProductQry.ToList();
            output.ForEach(Fe => Console.WriteLine("Producto: " + Fe.ProductName+ 
                "  Precio Unitario: "+ Fe.UnitPrice+ "  Unidades en almacen: "+ Fe.UnitsInStock));
            

        }
        static void Main(string[] args)
        {
            Product();
        }
    }
} 
