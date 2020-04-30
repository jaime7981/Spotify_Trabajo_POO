using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class UserSystem
    {
        //public DataBase Data { get; }
        //[usuario, correo, password, linkVerificacion, fecha, numero]
        private Dictionary<int, List<string>> registered;

        public UserSystem()
        {
            registered = new Dictionary<int, List<string>>();
        }

        // Realiza el registro 
        public void Register()
        {
            Console.Write("Bienvenido! Ingrese sus datos de registro en Spotflix: ");
            Console.Write("Ingrese su Nombre: ");
            string name = Console.ReadLine();
            Console.Write("Ingrese su Apellido: ");
            string lastName = Console.ReadLine();
            Console.Write("Elija su nombre de usario: ");
            string usr = Console.ReadLine();
            Console.Write("Ingrese su Correo: ");
            string email = Console.ReadLine();
            Console.Write("Ingrese su Contraseña: Contraseña: ");
            string psswd = Console.ReadLine();
            Console.Write("Ingrese nuevamente su Contraseña: ");
            string psswd2 = Console.ReadLine();
            Console.Write("Numero de telefono: ");
            string number = Console.ReadLine();
            // Genera el link de verificacion para el usuario
            string verificationLink = GenerateLink(usr);
            // Intenta agregar el usuario a la bdd. Si retorna null, se registro correctamente,
            // sino, retorna un string de error, que es el que se muestra al usuario
            string result = Data.AddUser(new List<string>()
                {usr, email, psswd, verificationLink, Convert.ToString(DateTime.Now), number});
            if (result == null)
            {
                // Disparamos el evento
                OnRegistered(usr, psswd, verificationlink: verificationLink, email: email);
            }
            else
            {
                // Mostramos el error
                Console.WriteLine("[!] ERROR: " + result + "\n");
            }
        }

        // Realiza el cambio de contrasena
        public void ChangePassword()
        {
            // Pedimos todos los datos necesarios
            Console.WriteLine("Ingresa tu nombre de usuario: ");
            string usr = Console.ReadLine();
            Console.WriteLine("Ingresa tu contrasena: ");
            string pswd = Console.ReadLine();
            // Intenta realizar el login, si retorna null se logeo correctamente,
            // sino, retorna un string de error que se le muestra al usuario
            string result = Data.LogIn(usr, pswd);
            if (result == null)
            {
                // Pedimos y cambiamos la contrasena
                Console.Write("Ingrese la nueva contrasena: ");
                string newPsswd = Console.ReadLine();
                Data.ChangePassword(usr, newPsswd);
                // Obtenemos los datos del usuario que se logueo y disparamos el evento con los datos necesarios
                List<string> data = Data.GetData(usr);
                OnPasswordChanged(data[0], data[1], data[5]);
            }
            else
            {
                // Mostramos el error
                Console.WriteLine("[!] ERROR: " + result + "\n");
            }
        }

        public void ChangePassword(string usr, string newpsswd)
        {
            foreach (List<string> user in this.registered.Values)
            {
                if (user[0] == usr)
                {
                    user[2] = newpsswd;
                }
            }
        }

        public string AddUser(List<string> data)
        {
            string description = null;
            foreach (List<string> value in this.registered.Values)
            {
                if (data[0] == value[0])
                {
                    description = "El nombre de usuario especificado ya existe";
                }
                else if (data[1] == value[1])
                {
                    description = "El correo ingresado ya existe";
                }
            }

            if (description == null)
            {
                this.registered.Add(registered.Count + 1, data);
            }
            return description;
        }

        public List<string> GetData(string usr)
        {
            foreach (List<string> user in this.registered.Values)
            {
                if (user[0] == usr)
                {
                    return user;
                }
            }

            return new List<string>();
        }

    }
}
