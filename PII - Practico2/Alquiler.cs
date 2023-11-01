using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PII___Practico2
{
    internal class Alquiler
    {
        private int numeroAlq;
        private double precioTotal;
        Cliente cliente;
        DetalleAlquiler detalle;
        Vehiculo vehiculo;

        public Alquiler(int numeroAlq, double precioTotal, Cliente cliente, int cantDias, DateTime fechaRetiro, Vehiculo vehiculo) 
        {
            this.numeroAlq = numeroAlq;
            this.precioTotal = precioTotal;
            this.cliente = cliente;
            this.detalle = new DetalleAlquiler(cantDias, fechaRetiro);
            this.vehiculo = vehiculo;
        }
        public int getNumeroAlq() {  return numeroAlq; }
        public double getPrecioTotal() {  return precioTotal; }
        public Cliente getCliente() {  return cliente; }
        public Vehiculo getVehiculo() {  return vehiculo; }

        public void setCliente(Cliente cliente) {  this.cliente = cliente; }
        public void setPrecioTotal(double precioTotal) { this.precioTotal = precioTotal; }
        public void setNumeroAlq(int numeroAlq) { this.numeroAlq=numeroAlq; }   
        public void setVehiculo(Vehiculo vehiculo) { this.vehiculo=vehiculo; }  
    }
}
