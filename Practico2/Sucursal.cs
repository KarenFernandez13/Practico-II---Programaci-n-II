using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practico2
{
    internal class Sucursal
    {
        private int numero;
        private string direccion;
        private List<Alquiler> colAlquileres;
        private List<Vehiculo> colVehiculos;

        public Sucursal(int numero, string direccion, List<Alquiler> colAlquileres, List<Vehiculo> colVehiculos)
        {
            this.numero = numero;
            this.direccion = direccion;
            this.colAlquileres = colAlquileres;
            this.colVehiculos = colVehiculos;
        }
        public int GetNumero() => numero; 
        public string GetDireccion() => direccion;
        public List<Alquiler> GetColAlquileres() => colAlquileres;
        public List<Vehiculo> GetColVehiculos() => colVehiculos;
        
        public void SetNumero(int numero) => this.numero = numero;
        public void SetDireccion(string direccion) => this.direccion = direccion;
        public void SetColAlquileres(List<Alquiler> colAlquileres) => this.colAlquileres = colAlquileres;
        public void SetColVehiculos(List<Vehiculo> colVehiculos) => this.colVehiculos = colVehiculos;
        
        public string VehiculosStock(int numero) 
        {
            string info = "";
            if (numero == 0)
            {
                foreach (Vehiculo item in this.colVehiculos)
                {
                    info += "\n " + item.GetNumero() + ". " + item.GetMarca() + "\n    - " + item.GetMatricula() + "\n    - " + item.GetColor() + "\n    - Capacidad del tanque: " + item.GetCapacidadTanque() + "\n    - Km/L: " + item.GetKmLitro() + "\n    - $USD " + item.GetPrecioAlquilerDia() + "\n    Disponibilidad: " + item.GetDisponibilidad();
                }
                return info;
            } else if (numero == 1)
            {
                foreach (Vehiculo item in this.colVehiculos)
                {
                    if (item.GetDisponibilidad() == true) 
                    {
                        info += "\n " + item.GetNumero() + ". " + item.GetMarca() + "\n    - " + item.GetMatricula() + "\n    - " + item.GetColor() + "\n    - Capacidad del tanque: " + item.GetCapacidadTanque() + "\n    - Km/L: " + item.GetKmLitro() + "\n    - $USD " + item.GetPrecioAlquilerDia();
                    }
                }
                return info;
            }
            return info;
        }
            

        public bool BuscarCliente(int documento) 
        {
            foreach (Alquiler item in this.colAlquileres)
            {
                if (item.GetCliente().GetDocumento() == documento)
                {
                    return true;
                }
            }
            return false;
        }

        public int DarAlquileresPorCliente (int documento)
        {
            int cantidadAlquileres = 0;
            foreach (Alquiler item in this.colAlquileres)
            {
               if (item.GetCliente().GetDocumento() == documento)
                {
                    cantidadAlquileres++;
                }
            }
            return cantidadAlquileres;
        }

        public void CambiarDisponibilidadPorNumeroDeVehiculo(int numero) 
        {
            foreach (Vehiculo item in this.colVehiculos)
            {
                if (item.GetNumero() == numero)
                    item.CambiarDisponibilidad();
            }
        }
    }
}
