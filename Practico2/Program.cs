using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practico2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Alquiler>alquileres = new List<Alquiler>();    
            List<Vehiculo>vehiculos = new List<Vehiculo>();
            Sucursal sucursal = new Sucursal(1, "Maldonado", alquileres, vehiculos);

            Deportivo Ferrari = new Deportivo(100, "ab516", "Ferrari", "Amarillo", 100, true, 500, 2, 290);
            Familiar Honda = new Familiar(45, "DF854", "Honda", "Blanco", 80, true, 100, 12, 100);
            Utilitario Citroen = new Utilitario(22, "LM325", "Citroen", "Gris", 60, false, 90, 18, 5);

            vehiculos.Add(Ferrari);
            vehiculos.Add(Honda);
            vehiculos.Add(Citroen);

            Cliente cliente1 = new Cliente(45632677, "Susana", "Rodriguez", 097863655);

            List<Vehiculo>VehiculosAlquiladosA1 = new List<Vehiculo>();
            VehiculosAlquiladosA1.Add(Ferrari);
            VehiculosAlquiladosA1.Add(Honda);
         
            Alquiler alquiler1 = new Alquiler(01, 1000, cliente1, VehiculosAlquiladosA1);
            alquiler1.AgregarDetalle(Ferrari, DateTime.Now, 3);
            alquiler1.AgregarDetalle(Honda, DateTime.Now, 2);
            alquileres.Add(alquiler1);

            Console.WriteLine("Cliente: " + alquiler1.GetCliente().GetNombre() + " " + alquiler1.GetCliente().GetApellido() + " Vehículos incluidos: " + alquiler1.VehiculosIncluidos() + " Valor total: " + alquiler1.GetPrecioTotal());

            List<Vehiculo> VehiculosAlquiladosA2 = new List<Vehiculo>();
            Cliente cliente2 = new Cliente(25630892, "Pedro", "Martinez", 094761322);
            VehiculosAlquiladosA2.Add(Citroen);

            Alquiler alquiler2 = new Alquiler(02, 100, cliente2, VehiculosAlquiladosA2);
            alquiler2.AgregarDetalle(Citroen, DateTime.Now, 10);
            alquileres.Add(alquiler2);

            Console.WriteLine($"La marca de los vehiculos son:  {sucursal.VehiculosStock()}");
          
         



            Console.ReadKey();

        }
    }
}
