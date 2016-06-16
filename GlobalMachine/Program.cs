using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlobalMachine
{
    class Program
    {
        static int option = 0;
        static int i = 0;
        static int size = 6;
        static int contaFrituras = 0;
        static int contaReposteria = 0;
        static int contaRefrescosGaseosos = 0;
        static int contaRefrescosNaturales = 0;
        static int contaConfiteria = 0;
        static string nombreCliente = "";
        static string numeroTelefono = "";

        struct articulo
        {
            public int codigo_articulo;
            public string nombre_articulo;
            public int precio;
            public string nombre_proveedor;
            public string tipo;
            public string fecha_vencimiento;
            public int posicion_estante;
        };

        static articulo[] articulos;

        static void agregarArticulos()
        {
            int r = 0;
            while (r != 1)
            {
                Console.Clear();
                if (i < articulos.Length)
                {
                    Console.WriteLine("Global Machines");
                    Console.WriteLine("Ingreso de productos.             ");
                    Console.Write("Digite el codigo del producto:                  ");
                    articulos[i].codigo_articulo = int.Parse(Console.ReadLine());
                    Console.Write("Digite el nombre del articulo:    ");
                    articulos[i].nombre_articulo = Console.ReadLine();
                    Console.Write("Digite el nombre del proveedor:    ");
                    articulos[i].nombre_proveedor = Console.ReadLine();
                    Console.Write("Digite el precio del articulo:     ");
                    articulos[i].precio = int.Parse(Console.ReadLine());
                    Console.Write("Digite la fecha de vencimiento:     ");
                    articulos[i].fecha_vencimiento = Console.ReadLine();
                    Console.Write("Digite el tipo de articulo:    ");
                    articulos[i].tipo = Console.ReadLine();
                    if (articulos[i].tipo == "frituras" || articulos[i].tipo == "FRITURAS")
                    {
                        contaFrituras = contaFrituras + 1;
                    }
                    else if (articulos[i].tipo == "reposteria" || articulos[i].tipo == "REPOSTERIA")
                    {
                        contaReposteria = contaReposteria + 1;
                    }
                    else if (articulos[i].tipo == "refrescos gaseosos" || articulos[i].tipo == "REFRESCOS GASEOSOS")
                    {
                        contaRefrescosGaseosos = contaRefrescosGaseosos + 1;
                    }
                    else if (articulos[i].tipo == "refrescos naturales" || articulos[i].tipo == "REFRESCOS NATURALES")
                    {
                        contaRefrescosNaturales = contaRefrescosNaturales + 1;
                    }
                    else if (articulos[i].tipo == "confiteria" || articulos[i].tipo == "CONFITERIA")
                    {
                        contaConfiteria = contaConfiteria + 1;
                    }
                    else
                    {
                        Console.WriteLine("Verifique el tipo de articulo que esta ingresando");
                    }

                    Console.Write("Digite el nivel donde esta el articulo:     ");
                    articulos[i].precio = int.Parse(Console.ReadLine());

                    if (articulos[i].posicion_estante == 1)
                    {
                        articulos[i].posicion_estante = 1;
                    }
                    else if (articulos[i].posicion_estante == 2)
                    {
                        articulos[i].posicion_estante = 2;
                    }
                    else if (articulos[i].posicion_estante == 3)
                    {
                        articulos[i].posicion_estante = 3;
                    }
                    else if (articulos[i].posicion_estante == 4)
                    {
                        articulos[i].posicion_estante = 4;
                    }
                    else
                    {
                        articulos[i].posicion_estante = 5;
                    }
                    Console.WriteLine("Desea agregar otro estudiante 0-Sí 1-No");
                    r = int.Parse(Console.ReadLine());
                    i++;
                }
                else
                {
                    Console.WriteLine("Registro de estudiantes lleno..");
                    r = 1;
                    Console.ReadKey();
                }
            }

        }

        static void modificacionDeProductos()
        {
            int codigo = 0;
            int reg = 0;
            int r = 0;
            bool found = false;
            while (r != 1)
            {
                Console.WriteLine("Global Machines");
                Console.WriteLine("Modificacion de productos.             ");
                Console.WriteLine("Digite el codigo del articulo a modificar");
                codigo = int.Parse(Console.ReadLine());
                for (i = 0; i < articulos.Length; i++)
                {
                    if (codigo == articulos[i].codigo_articulo)
                    {
                        reg = i + 1;
                        Console.Write("Digite el nombre del articulo:    ");
                        articulos[i].nombre_articulo = Console.ReadLine();

                        Console.Write("Digite el nombre del proveedor:    ");
                        articulos[i].nombre_proveedor = Console.ReadLine();

                        Console.Write("Digite el precio del articulo:     ");
                        articulos[i].precio = int.Parse(Console.ReadLine());

                        Console.Write("Digite la fecha de vencimiento:     ");
                        articulos[i].fecha_vencimiento = Console.ReadLine();

                        Console.Write("Digite el tipo de articulo:    ");
                        articulos[i].tipo = Console.ReadLine();

                        if (articulos[i].tipo == "frituras" || articulos[i].tipo == "FRITURAS")
                        {
                            contaFrituras = contaFrituras + 1;
                        }
                        else if (articulos[i].tipo == "reposteria" || articulos[i].tipo == "REPOSTERIA")
                        {
                            contaReposteria = contaReposteria + 1;
                        }
                        else if (articulos[i].tipo == "refrescos gaseosos" || articulos[i].tipo == "REFRESCOS GASEOSOS")
                        {
                            contaRefrescosGaseosos = contaRefrescosGaseosos + 1;
                        }
                        else if (articulos[i].tipo == "refrescos naturales" || articulos[i].tipo == "REFRESCOS NATURALES")
                        {
                            contaRefrescosNaturales = contaRefrescosNaturales + 1;
                        }
                        else if (articulos[i].tipo == "confiteria" || articulos[i].tipo == "CONFITERIA")
                        {
                            contaConfiteria = contaConfiteria + 1;
                        }
                        else
                        {
                            Console.WriteLine("Verifique el tipo de articulo que esta ingresando");
                        }

                        Console.Write("Digite el nivel donde esta el articulo:     ");
                        articulos[i].precio = int.Parse(Console.ReadLine());

                        if (articulos[i].posicion_estante == 1)
                        {
                            articulos[i].posicion_estante = 1;
                        }
                        else if (articulos[i].posicion_estante == 2)
                        {
                            articulos[i].posicion_estante = 2;
                        }
                        else if (articulos[i].posicion_estante == 3)
                        {
                            articulos[i].posicion_estante = 3;
                        }
                        else if (articulos[i].posicion_estante == 4)
                        {
                            articulos[i].posicion_estante = 4;
                        }
                        else
                        {
                            articulos[i].posicion_estante = 5;
                        }
                        found = true;
                    }
                }
                if (!found)
                {
                    Console.WriteLine("No se encontro ese ID");
                    found = false;
                }
                else
                {
                    Console.WriteLine("Desea modificar otro estudiante 0-Sí 1-No");
                    r = int.Parse(Console.ReadLine());
                }
            }
        }

        static void borrarProducto()
        {
            int codigo = 0;
            int reg = 0;
            int r = 0;
            bool found = false;
            while (r != 1)
            {
                Console.Clear();
                Console.WriteLine("Cual articulo desea eliminar.           ");
                Console.WriteLine("Digite el codigo del articulo a eliminar");
                codigo = int.Parse(Console.ReadLine());
                for (i = 0; i < articulos.Length; i++)
                {
                    if (codigo == articulos[i].codigo_articulo)
                    {
                        reg = i + 1;
                        articulos[i].codigo_articulo = 0;
                        articulos[i].nombre_articulo = "";
                        articulos[i].nombre_proveedor = "";
                        articulos[i].precio = 0;
                        articulos[i].posicion_estante = 0;
                        articulos[i].tipo = "";
                        articulos[i].fecha_vencimiento = "";
                        found = true;
                    }
                }
                if (!found)
                {
                    Console.WriteLine("No se encontro ese codigo");
                    found = false;
                }
                Console.WriteLine("Estudiante eliminado");
                Console.WriteLine("Desea eliminar otro estudiante 0-Sí 1-No");
                r = int.Parse(Console.ReadLine());
            }
        }

        static void busquedaDeProductos()
        {
            int codigo = 0;
            int reg = 0;
            int r = 0;
            bool found = false;
            while (r != 1)
            {
                Console.Clear();
                Console.WriteLine("Búsquedad de articulo.           ");
                Console.WriteLine("Digite el codigo del articulo a buscar");
                codigo = int.Parse(Console.ReadLine());
                for (i = 0; i < articulos.Length; i++)
                {
                    if (codigo == articulos[i].codigo_articulo)
                    {
                        reg = i + 1;
                        Console.WriteLine("Registro: " + reg);
                        Console.WriteLine("Codigo:       " + articulos[i].codigo_articulo);
                        Console.WriteLine("Nombre del articulo:   " + articulos[i].nombre_articulo);
                        Console.WriteLine("Nombre del proveedor:   " + articulos[i].nombre_proveedor);
                        Console.WriteLine("Precio:     " + articulos[i].precio);
                        Console.WriteLine("Tipo de articulo:     " + articulos[i].tipo);
                        Console.WriteLine("Posicion:     " + articulos[i].posicion_estante);
                        Console.WriteLine("Fecha de Vencimiento:   " + articulos[i].fecha_vencimiento);
                        found = true;
                    }
                }
                if (!found)
                {
                    Console.WriteLine("No se encontro ese codigo");
                    found = false;
                }
                Console.WriteLine("Desea buscar otro estudiante 0-Sí 1-No");
                r = int.Parse(Console.ReadLine());
            }
        }

        static void listaDeProductos()
        {
            int reg = 0;
            Console.Clear();
            Console.WriteLine("=================================");
            Console.WriteLine("Global Machines");
            Console.WriteLine("=================================");
            Console.WriteLine("Listado de Productos");
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Reg" + "\t" + "Codigo" + "\t" + "Nombre" + "\t" + "Tipo" + "\t\t" + "Vencimiento" + "\t" + "Proveedor" + "\t" + "Posicion" + "\t" + "Precio");
            for (i = 0; i < articulos.Length; i++)
            {
                reg = i + 1;
                Console.WriteLine(reg + "\t" +
                    articulos[i].codigo_articulo + "\t" +
                    articulos[i].nombre_articulo + "\t" +
                    articulos[i].tipo + "\t" +
                    articulos[i].fecha_vencimiento + "\t" +
                    articulos[i].nombre_proveedor + "\t" +
                    articulos[i].posicion_estante + "\t" + 
                    articulos[i].precio);
            }
            Console.WriteLine("=================================");

            Console.WriteLine("\n\n");

            Console.WriteLine("=================================");
            Console.WriteLine("Gloval Machines");
            Console.WriteLine("=================================");
            Console.WriteLine("Informe de Inventario");
            Console.WriteLine("=================================");
            Console.WriteLine("Clasificacion" + "\t" + "||" + "\t" + "Cantidad");
            Console.WriteLine("Frituras" + "\t" + "||" + "\t" + contaFrituras);
            Console.WriteLine("Reposteria" + "\t" + "||" + "\t" + contaReposteria);
            Console.WriteLine("Refrescos Gaseosos" + "\t" + "||" + "\t" + contaRefrescosGaseosos);
            Console.WriteLine("Refrescos Naturales" + "\t" + "||" + "\t" + contaRefrescosNaturales);
            Console.WriteLine("Confiteria" + "\t" + "||" + "\t" + contaConfiteria);
            Console.WriteLine("=================================");
            Console.ReadKey();

            StreamWriter escribir = new StreamWriter("C:\\Users\\IBM_ADMIN\\Desktop\\Informes.txt");

            escribir.WriteLine("=================================");
            escribir.WriteLine("Global Machines");
            escribir.WriteLine("=================================");
            escribir.WriteLine("Listado de Productos");
            escribir.WriteLine("---------------------------------");
            escribir.WriteLine("Reg" + "\t" + "Codigo" + "\t" + "Nombre" + "\t\t\t" + "Tipo" + "\t\t\t" + "Vencimiento" + "\t\t\t" + "Proveedor" + "\t\t\t" + "Posicion" + "\t" + "Precio");
            for (i = 0; i < articulos.Length; i++)
            {
                reg = i + 1;
                escribir.WriteLine(reg + "\t" +
                    articulos[i].codigo_articulo + "\t" +
                    articulos[i].nombre_articulo + "\t\t\t" +
                    articulos[i].tipo + "\t\t\t" +
                    articulos[i].fecha_vencimiento + "\t\t\t" +
                    articulos[i].nombre_proveedor + "\t\t\t" +
                    articulos[i].posicion_estante + "\t" +
                    articulos[i].precio);
            }
            escribir.WriteLine("=================================");

            escribir.WriteLine("\n");

            escribir.WriteLine("=================================");
            escribir.WriteLine("Gloval Machines");
            escribir.WriteLine("=================================");
            escribir.WriteLine("Informe de Inventario");
            escribir.WriteLine("=================================");
            escribir.WriteLine("Clasificacion" + "\t\t" + "||" + "\t" + "Cantidad");
            escribir.WriteLine("Frituras" + "\t\t" + "||" + "\t" + contaFrituras);
            escribir.WriteLine("Reposteria" + "\t\t" + "||" + "\t" + contaReposteria);
            escribir.WriteLine("Refrescos Gaseosos" + "\t\t" + "||" + "\t" + contaRefrescosGaseosos);
            escribir.WriteLine("Refrescos Naturales" + "\t\t" + "||" + "\t" + contaRefrescosNaturales);
            escribir.WriteLine("Confiteria" + "\t" + "||" + "\t\t" + contaConfiteria);
            escribir.WriteLine("=================================");
            escribir.Close();
        }

        static void ventaDeProductos() {

            int codigo = 0;
            int reg = 0;
            int r = 0;
            bool found = false;

            Console.WriteLine("Ingrese su nombre con apellidos");
            nombreCliente = Console.ReadLine();
            Console.WriteLine("Ingrese su telefono");
            numeroTelefono = Console.ReadLine();
            
            while (r != 1)
            {
                Console.Clear();
                Console.WriteLine("Venta de articulo.           ");
                Console.WriteLine("Digite el codigo del articulo a comprar");
                codigo = int.Parse(Console.ReadLine());
                for (i = 0; i < articulos.Length; i++)
                {
                    if (codigo == articulos[i].codigo_articulo)
                    {
                        reg = i + 1;
                        
                        found = true;
                    }
                }
                if (!found)
                {
                    Console.WriteLine("No se encontro ese codigo");
                    found = false;
                }
                Console.WriteLine("Desea buscar otro estudiante 0-Sí 1-No");
                r = int.Parse(Console.ReadLine());
            }            

            for (i = 0; i < articulos.Length; i++)
            {
                reg = i + 1;
                Console.WriteLine(reg + "\t" +
                    articulos[i].codigo_articulo + "\t" +
                    articulos[i].nombre_articulo + "\t" +                    
                    articulos[i].precio);
            }
        
        }

        static void Main(string[] args)
        {
            articulos = new articulo[size];            

            do
            {
                Console.Clear();
                Console.WriteLine("*-* Global Machines *-*");
                Console.WriteLine("1. Ingreso de productos.");
                Console.WriteLine("2. Modificación de producots.");
                Console.WriteLine("3. Eliminacion de productos.");
                Console.WriteLine("4. Búsquedad de productos.");
                Console.WriteLine("5. Listado de productos.");
                Console.WriteLine("6. Venta de productos.");
                Console.WriteLine("7. Salir.");
                Console.WriteLine("Selecciones una opción");
                option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        {
                            agregarArticulos();
                            break;
                        }
                    case 2:
                        {
                            modificacionDeProductos();
                            break;
                        }
                    case 3:
                        {
                            borrarProducto();
                            break;
                        }
                    case 4:
                        {
                            busquedaDeProductos();
                            break;
                        }
                    case 5:
                        {
                            listaDeProductos();                            
                            break;
                        }
                    case 6:
                        {
                            ventaDeProductos();
                            break;
                        }
                    case 7:
                        //Salir
                        break;
                    default:
                        {
                            Console.WriteLine("Seleccione inválida..");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                }
            } while (option != 7);
        }
    }
}
