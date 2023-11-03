using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practico2
{
    internal class Alquiler
    {
        private int numero;
        private double precioTotal;
        private Cliente cliente;
        private List<Vehiculo> colVehiculos;
        private List<Detalle> colDetalles;

        public Alquiler(int numero, double precioTotal, Cliente cliente, List<Vehiculo> colVehiculos)
        {
            this.numero = numero;
            this.precioTotal = precioTotal;
            this.cliente = cliente;
            this.colVehiculos = colVehiculos;
            this.colDetalles = new List<Detalle>();
        }
        public void AgregarDetalle(Vehiculo vehiculo, DateTime fechaRetiro, int cantidadDias)
        {
            Detalle detalle = new Detalle(vehiculo, fechaRetiro, cantidadDias);
            colDetalles.Add(detalle);
        }

        public int GetNumero() => numero;
        public double GetPrecioTotal() => precioTotal;
        public Cliente GetCliente() => cliente;
        public List<Vehiculo> GetColVehiculos() => colVehiculos;
        public List<Detalle> GetColDetalles() => colDetalles;

        public void SetNumero(int numero) => this.numero = numero;
        public void SetPrecioTotal(double precioTotal) => this.precioTotal = precioTotal;
        public void SetCliente(Cliente cliente) => this.cliente = cliente;
        public void SetColVehiculos(List<Vehiculo> colVehiculos) => this.colVehiculos = colVehiculos;
        public void SetColDetalles(List<Detalle> colDetalles) => this.colDetalles = colDetalles;

        public string VehiculosIncluidos()
        {
            string infoVehiculo = "";
            foreach (Vehiculo item in this.colVehiculos)
            {
                infoVehiculo += item.GetMarca() +" Matricula: " +item.GetMatricula() + " / ";
            }
            return infoVehiculo;
        }

    }
}
