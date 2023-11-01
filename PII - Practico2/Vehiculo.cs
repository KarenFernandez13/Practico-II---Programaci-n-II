using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PII___Practico2
{
    internal class Vehiculo
    {
        protected int id;
        protected string matricula;
        protected string marca;
        protected double alquilerDia;
        protected double capTanque;
        protected double kmLitro;
        protected string estado;
        protected string color;

        public Vehiculo(int id, string matricula, string marca, double alquilerDia, double capTanque, double kmLitro, string estado, string color)
        {
            this.id = id;
            this.matricula = matricula;
            this.marca = marca;
            this.alquilerDia = alquilerDia;
            this.capTanque = capTanque;
            this.kmLitro = kmLitro;
            this.estado = estado;
            this.color = color;
        }

        public int getId() { return id; }
        public void setId(int id) { this.id = id;}
        public string getMatricula() {  return matricula; }
        public void setMatricula(string matricula) { this.matricula = matricula; }
        public string getMarca() { return marca; }
        public void setMarca(string marca) { this.marca= marca; }
        public double getAlquilerDia() {  return alquilerDia; }
        public void setAlquilerDia(double alquilerDia) { this.alquilerDia= alquilerDia; }
        public double getCapTanque() {  return capTanque; }
        public void setCapTanque(double capTanque) { this.capTanque= capTanque; }
        public double getKmLitro() { return kmLitro; }
        public void setKmLitro(double kmLitro) { this.kmLitro= kmLitro; }
        public string getEstado() {  return estado; }
        public void setEstado(string estado) { this.estado = estado; }
        public string getColor() { return color; }
        public void setColor(string color) {  this.color = color; }
        
    }
}
