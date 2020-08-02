using System;
using System.Collections.Generic;

namespace Proyecto_Final
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Usuario Supervisor = new Usuario();
                Supervisor.Nombre = "Yolainee";
                Supervisor.Clave = 00122222223;
                Supervisor.FechaDeCreacion = DateTime.Today;
                Supervisor.Estado = Estado.activo;
                Supervisor.Rol = Rol.supervisor;
                Supervisor.Username = "Yolainee08";


                Usuario Administardor = new Usuario();
                Administardor.Nombre = "Perla";
                Administardor.Clave = 00123332223;
                Administardor.FechaDeCreacion = DateTime.Today;
                Administardor.Estado = Estado.activo;
                Administardor.Rol = Rol.administrador;
                Administardor.Username = "Perla06";

                Usuario Vendedor = new Usuario();
                Vendedor.Nombre = "Juan";
                Vendedor.Clave = 00125252103;
                Vendedor.FechaDeCreacion = DateTime.Today;
                Vendedor.Estado = Estado.activo;
                Vendedor.Rol = Rol.vendedor;
                Vendedor.Username = "Juan01";
               
                Usuario Inativo = new Usuario();
                Inativo.Nombre = "Pedro";
                Inativo.Clave = 00123252612;
                Inativo.FechaDeCreacion = DateTime.Today;
                Inativo.Estado = Estado.inativo;
                Inativo.Rol = Rol.vendedor;
                Inativo.Username = "Pedro07";

                Console.Clear();

                Console.WriteLine("---------------------------------");
                Console.WriteLine("--------Proyecto_Final---------");

                Console.WriteLine("Username");
                string username = Console.ReadLine();
                Console.WriteLine("Clave");
                int clave = Convert.ToInt32(Console.ReadLine());

                Dictionary<string, Usuario> Usuarios = new Dictionary<string, Usuario>();
                Usuarios.Add(Administardor.Username, Administardor);
                Usuarios.Add(Vendedor.Username, Vendedor);
                Usuarios.Add(Supervisor.Username, Supervisor);
                Usuarios.Add(Inativo.Username, Inativo);

                Usuario usuarioactual;

                if (Usuarios.TryGetValue(username, out usuarioactual))
                {

                    if (clave == usuarioactual.Clave)
                    {
                        if (usuarioactual.Estado == 0)
                        {
                            Console.Clear();
                            Console.WriteLine($"Acabas de ingresar con el usuario {usuarioactual.Username} y su Rol es {usuarioactual.Rol.ToString()}");
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("El usuario esta inactivo");
                            Console.ReadKey();
                        }
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("La clave es incorrecta");
                        Console.ReadKey();
                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("El usuario no existe");
                    Console.ReadKey();
                }
            }
            }
        
    }
}
