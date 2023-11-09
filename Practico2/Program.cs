using System;
using System.Collections;
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

            //se crea lista de vehiculos, alquileres y una sucursal
            List<Vehiculo> vehiculos = new List<Vehiculo>();
            List<Alquiler> alquileres = new List<Alquiler>();
            Sucursal sucursal = new Sucursal(1, "Maldonado", alquileres, vehiculos);

            //se crean los autos disponibles
            Deportivo Ferrari = new Deportivo(100, "ab516", "Ferrari", "Amarillo", 100, true, 500, 2, 290);
            Familiar Honda = new Familiar(45, "DF854", "Honda", "Blanco", 80, true, 100, 12, 100);
            Utilitario Citroen = new Utilitario(22, "LM325", "Citroen", "Gris", 60, false, 90, 18, 5);
            vehiculos.Add(Ferrari);
            vehiculos.Add(Honda);
            vehiculos.Add(Citroen);

            //se crea 1er cliente con su lista de vehiculos alquilados y 1 alquiler con el detalle
            Cliente cliente1 = new Cliente(45632677, "Susana", "Rodriguez", 097863655);
            List<Vehiculo> VehiculosAlquiladosA1 = new List<Vehiculo>();
            VehiculosAlquiladosA1.Add(Ferrari);
            VehiculosAlquiladosA1.Add(Honda);

            Alquiler alquiler1 = new Alquiler(01, 1000, cliente1, VehiculosAlquiladosA1);
            alquiler1.AgregarDetalle(Ferrari, DateTime.Now, 3);
            alquiler1.AgregarDetalle(Honda, DateTime.Now, 2);
            alquileres.Add(alquiler1);

            // se crea 2do cliente con su lista de vehiculos alquilados y 1 alquiler con el detalle
            Cliente cliente2 = new Cliente(25630892, "Pedro", "Martinez", 094761322);
            List<Vehiculo> VehiculosAlquiladosA2 = new List<Vehiculo>();
            VehiculosAlquiladosA2.Add(Citroen);

            Alquiler alquiler2 = new Alquiler(02, 100, cliente2, VehiculosAlquiladosA2);
            alquiler2.AgregarDetalle(Citroen, DateTime.Now, 10);
            alquileres.Add(alquiler2);

            Console.WriteLine("--- Bienvenido Administrador/a ---");
            Console.WriteLine("\n1. Stock de vehículos");
            Console.WriteLine("     Filtrar por disponibilidad");
            Console.WriteLine("2. Agregar alquiler");
            Console.WriteLine("3. Buscar cliente");
            Console.WriteLine("     Dar número de alquileres");
            Console.WriteLine("4. Cambiar disponibilidad de vehículos");
            Console.WriteLine("");
            int numero = int.Parse(Console.ReadLine());


            if (numero == 1)
            {
                Console.WriteLine("Desea filtrar por disponibilidad?");
                Console.WriteLine("0. No // 1. Si");
                numero = int.Parse(Console.ReadLine());
                Console.WriteLine($"Stock de vehículos: {sucursal.VehiculosStock(numero)}");
            } else if (numero == 2)
            {
             

            }
            else if (numero == 3)
            {
                Console.WriteLine("Ingrese documento para buscar cliente y listar alquileres");
                int docu = int.Parse(Console.ReadLine());
                bool existeCliente = sucursal.BuscarCliente(docu);
                if (existeCliente == true)
                {
                    List<Alquiler> alquileresCliente = sucursal.DarAlquileresPorCliente(docu);
                    Console.WriteLine($"Cantidad de alquileres del cliente {docu}: {alquileresCliente.Count}");
                    Console.WriteLine($"Detalles\n {sucursal.DetallarListaCliente(alquileresCliente)}");
                }
                else Console.WriteLine("No existe un cliente registrado con ese documento");
            } 
            else if (numero == 4)
            {
                
            }










            //se muestran los datos del cliente con los autos alquilados
            Console.WriteLine("Cliente: " + alquiler1.GetCliente().GetNombre() + " " + alquiler1.GetCliente().GetApellido() + " Vehículos incluidos: " + alquiler1.VehiculosIncluidos() + " Valor total: " + alquiler1.GetPrecioTotal());

            //se muestra stock de vehiculos total o x disponibilidad
           
            

            //buscar cliente por documento // dar alquileres por documento 
         


            //cambiar disponibilidad
            Console.WriteLine("Elige el numero de vehículo para cambiar la disponibilidad: ");
            foreach (Vehiculo item in vehiculos)
            {
                Console.WriteLine($" {item.GetNumero()}. {item.GetMarca()}    Disponibilidad: {item.GetDisponibilidad()}"); 
            }
            numero = int.Parse(Console.ReadLine()); ;
            sucursal.CambiarDisponibilidadPorNumeroDeVehiculo(numero);
            // se verifica si se cambio (si)
            foreach (Vehiculo item in vehiculos)
            {
                Console.WriteLine($" {item.GetNumero()}. {item.GetMarca()}    Disponibilidad: {item.GetDisponibilidad()}");
            }



            Console.ReadKey();

        }
    }
}
