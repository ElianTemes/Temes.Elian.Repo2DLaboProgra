using System;

namespace mascota
{
    public class Mascota
    {
        private string nombre;
        private DateTime fechaNacimiento;
        private string especie;
        
        public Mascota (string nombre, DateTime fechaNacimiento, string especie)
        {
            this.nombre = nombre;
            this.fechaNacimiento = fechaNacimiento;
            this.especie = especie;
        }

        public string GetNombre()
        {
            return nombre;
        }
        public DateTime GetFechaNacimiento()
        {
            return fechaNacimiento;
        }
        public string GetEspecie()
        {
            return especie;
        }
    }
}
