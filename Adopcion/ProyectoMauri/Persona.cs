using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adopcion
{
    class Persona
    {
        private String nombre;
        private String apellido;
        private String direccion;
        private int edad;
        private Boolean sexo;
        public Persona(String nombre, String apellido, String direccion, int edad, Boolean sexo)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.direccion = direccion;
            this.edad = edad;
            this.sexo = sexo;
        }
        public Persona()
        {


        }
        public String getNombre()
        {
            return nombre;
        }
        public String getApellido()
        {
            return apellido;
        }
        public String getDireccion()
        {
            return direccion;
        }
        public int getEdad()
        {
            return edad;
        }
        public String getSexo()
        {
            if (sexo)
            {
                return "Masculino";
            }
            else
            {
                return "Femenino";
            }
        }
        public void setNombre(String nombre)
        {
            this.nombre = nombre;
        }
        public void setApellido(String apellido)
        {
            this.apellido = apellido;
        }
        public void setDireccion(String direccion)
        {
            this.direccion = direccion;
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
