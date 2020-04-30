using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class AppSystem
    {
        UserSystem userSystem = new UserSystem();
        
        public void StartApp()
        {
            string[] options = { "Iniciar Sesión", "Regístrate Gratis","Salir" };
            bool selectingMenu = true;
            int selectedOption = 1;
            while (selectingMenu)
            {
                Console.Clear();
                Console.WriteLine("SpotFlix");
                Console.WriteLine("Todos los videos y canciones de tus artistas prefieridos en SpotFlix");
                Console.WriteLine("Elije una opcion\n");
                int optionIndex = 1;
                foreach (string option in options)
                {
                    Console.WriteLine($"{optionIndex} - {option}");

                    optionIndex += 1;
                }
                selectedOption = Convert.ToInt16(Console.ReadLine());
                System.Threading.Thread.Sleep(2000);
                Console.Clear();
                switch (selectedOption)
                {
                    case 1:
                        Console.WriteLine("Iniciar Sesión"); 
                        Console.Write("Ingrese su nombre de usario: ");
                        string usr = Console.ReadLine();                   
                        Console.Write("Ingrese su contraseña: ");
                        string psswd = Console.ReadLine();
                        Console.Write("INICAR SESÍON");
                        string iniciar = Console.ReadLine();
                        userSystem.LogIn(usr,psswd);
                        break;

                    case 2:
                        Console.WriteLine("Resgistrate Gratis");
                        userSystem.Register();
                        break;

                    case 3:
                        Console.WriteLine("Cerrando programa");
                        break;

                    default:
                        Console.WriteLine("Ingrese option valida...");
                        Console.WriteLine("Precione cualquier tecla para continuar");
                        Console.ReadLine();
                        break;

                    

                }
                selectingMenu = false;

            }
        }  
    }
}
