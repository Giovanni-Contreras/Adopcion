using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adopcion
{
    public class Mascota
    {
        private String especie;
        private String nombre;
        private String raza;
        private int edad;
        private Boolean sexo;
        public Mascota()
        {

        }
        public Mascota(String especie, String nombre, String raza, int edad, Boolean sexo)
        {
            this.especie = especie;
            this.nombre = nombre;
            this.raza = raza;
            this.edad = edad;
            this.sexo = sexo;
        }

        public String getEspecie()
        {
            return especie;
        }
        public String getNombre()
        {
            return nombre;
        }
        public String getRaza()
        {
            return raza;
        }
        public int getEdad()
        {
            return edad;
        }
        public Boolean getSexo()
        {
            return sexo;
        }
        public void setEspecie(String especie)
        {
            this.especie = especie;
        }
        public void setNombre(String nombre)
        {
            this.nombre = nombre;
        }
        public void setRaza(String raza)
        {
            this.raza = raza;
        }
        public void setEdad(int edad)
        {
            this.edad = edad;
        }
        public void setSexo(Boolean sexo)
        {
            this.sexo = sexo;
        }
    }
}
