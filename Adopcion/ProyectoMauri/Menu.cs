using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adopcion
{
    class Menu
    {
        List<Mascota> MascotasAdoptadas=new List<Mascota>();
        List<Persona> PersonasQueAdoptan=new List<Persona>();
        public void IniciarMenu()
        {
            int opcion = 0;
            int matriculaUsuario = 0;
            int matriculaMascota = 0;
            List<Mascota> Mascotas = llenarListaMascotas();
            List<Persona> Personas = llenarListaPersonas();
            do
            {
                Console.WriteLine("*********************************************************************************");
                Console.WriteLine("*                               GIOVANNI CONTRERAS                              *");
                Console.WriteLine("*                                       *                                       *");
                Console.WriteLine("*    1.-Adoptar una mascota             *                                       *");
                Console.WriteLine("*    2.-Añadir persona                  *                                       *");
                Console.WriteLine("*    3.-Añadir mascota                  *                                       *");
                Console.WriteLine("*    4.-Mostrar Historial Adopciones    *                                       *");
                Console.WriteLine("*                                       *                    5.-Cerrar sesión   *");
                Console.WriteLine("*********************************************************************************");
                opcion = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (opcion)
                {
                    case 1:
                        if ((Personas.Count > 0))
                        {
                            if (Mascotas.Count > 0)
                            {
                                Console.WriteLine("Usuario quien va adoptar:");
                                mostrarListaPersonas(Personas);
                                Console.WriteLine("Escribe el ID del usuario qué adoptará la mascota.");
                                matriculaUsuario = int.Parse(Console.ReadLine()) - 1;
                                Console.Clear();
                                mostrarListaMascota(Mascotas);
                                Console.WriteLine("Escribe el ID de la mascota a adoptar.");
                                matriculaMascota = int.Parse(Console.ReadLine()) - 1;
                                Console.Clear();
                                PersonasQueAdoptan.Add(Personas[matriculaUsuario]);
                                MascotasAdoptadas.Add(Mascotas[matriculaMascota]);
                                Personas.Remove(Personas[matriculaUsuario]);
                                Mascotas.Remove(Mascotas[matriculaMascota]);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Usuarios/Mascotas agotados, Registra nuevos para continuar. ");
                            Console.ReadLine();
                            Console.Clear();
                        }
                        break;
                    case 2:
                        Persona persona = new Persona();
                        Console.WriteLine("Nombre del usuario");
                        persona.setNombre(Console.ReadLine());
                        Console.WriteLine("Apellido del usuario");
                        persona.setApellido(Console.ReadLine());
                        Console.WriteLine("Dirección de usuario");
                        persona.setDireccion(Console.ReadLine());
                        Console.WriteLine("Edad del usuario");
                        persona.setEdad(int.Parse(Console.ReadLine()));
                        Console.WriteLine("Sexo del usuario(Masculino,Femenino)");
                        if (Console.ReadLine() == "Masculino")
                        {
                            persona.setSexo(true);
                        }
                        else
                        {
                            persona.setSexo(false);
                        }
                        Personas.Add(persona);
                        break;
                    case 3:
                        Mascota mascota = new Mascota();
                        Console.WriteLine("Especie de la mascota");
                        mascota.setEspecie(Console.ReadLine());
                        Console.WriteLine("Nombre de la mascota");
                        mascota.setNombre(Console.ReadLine());
                        Console.WriteLine("Raza de la mascota");
                        mascota.setRaza(Console.ReadLine());
                        Console.WriteLine("Edad de la mascota");
                        mascota.setEdad(int.Parse(Console.ReadLine()));
                        Console.WriteLine("Sexo de la mascota(Macho,Hembra)");
                        if (Console.ReadLine() == "Macho")
                        {
                            mascota.setSexo(true);
                        }
                        else
                        {
                            mascota.setSexo(false);
                        }
                        Mascotas.Add(mascota);
                        break;
                    case 4:
                        mostrarListaAdopciones();
                        break;
                }
            } while (opcion < 4);

        }

        private List<Mascota> llenarListaMascotas()
        {
            List<Mascota> MascotasDisponibles = new List<Mascota>();
            MascotasDisponibles.Add(new Mascota("Ave", "Piolin", "Canario", 1, false));
            MascotasDisponibles.Add(new Mascota("Felino", "Silvestre", "Solovino", 5, false));
            MascotasDisponibles.Add(new Mascota("Canino", "Logan", "Coquer", 6, true));
            MascotasDisponibles.Add(new Mascota("Acuatico", "Nemo", "Pez pallaso", 6, true));
            return MascotasDisponibles;
        }

        private List<Persona> llenarListaPersonas()
        {
            List<Persona> clientes = new List<Persona>();
            clientes.Add(new Persona("Jhonatan Giovanni", "Contreras Castillo", "Valle de las Brisas", 21, true));
            clientes.Add(new Persona("Jhon Carter", "Martinez Martinez", "Virginia de Santa", 40, true));
            clientes.Add(new Persona("Arturo Luis", "Casarez Ruiz", "Bosques Huasteca", 40, true));
            return clientes;
        }
        private void mostrarListaPersonas(List<Persona> clientes)
        {
            for (int x = 0; x < clientes.Count; x++)
            {
                Console.WriteLine("| ID: " + (x + 1));
                Console.WriteLine("| Nombre: " + clientes[x].getNombre());
                Console.WriteLine("| Apellido: " + clientes[x].getApellido());
                Console.WriteLine("| Dirección: " + clientes[x].getDireccion());
                Console.WriteLine("| Edad: " + clientes[x].getEdad());
                Console.WriteLine("| Sexo: " + clientes[x].getSexo());
                Console.WriteLine("---------------------------------------------------------------");
            }
        }
        private void mostrarListaMascota(List<Mascota> MascotasDisponibles)
        {
            for (int x = 0; x < MascotasDisponibles.Count; x++)
            {
                Console.WriteLine("| ID: " + (x + 1));
                Console.WriteLine("| Especie: " + MascotasDisponibles[x].getEspecie());
                Console.WriteLine("| Nombre: " + MascotasDisponibles[x].getNombre());
                Console.WriteLine("| Raza: " + MascotasDisponibles[x].getRaza());
                Console.WriteLine("| Edad: " + MascotasDisponibles[x].getEdad());
                Console.WriteLine("---------------------------------------------------------------");
            }
        }
        private void mostrarListaAdopciones() {

            for (int x = 0; x < MascotasAdoptadas.Count; x++)
            {
                Console.WriteLine("-------------------------USUARIO-------------------------------");
                Console.WriteLine("| ID: " + (x + 1));
                Console.WriteLine("| Nombre: " + PersonasQueAdoptan[x].getNombre());
                Console.WriteLine("| Apellido: " + PersonasQueAdoptan[x].getApellido());
                Console.WriteLine("| Dirección: " + PersonasQueAdoptan[x].getDireccion());
                Console.WriteLine("| Edad: " + PersonasQueAdoptan[x].getEdad());
                Console.WriteLine("| Sexo: " + PersonasQueAdoptan[x].getSexo());
                Console.WriteLine("|------------------------ADOPTO--------------------------------");
                Console.WriteLine("| ID: " + (x + 1));
                Console.WriteLine("| Especie: " + MascotasAdoptadas[x].getEspecie());
                Console.WriteLine("| Nombre: " + MascotasAdoptadas[x].getNombre());
                Console.WriteLine("| Raza: " + MascotasAdoptadas[x].getRaza());
                Console.WriteLine("| Edad: " + MascotasAdoptadas[x].getEdad());
                Console.WriteLine("###############################################################");
            }
        }

    }
}
