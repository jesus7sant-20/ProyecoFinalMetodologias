using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace ProyectoFinalMetodologias
{
    internal class cLogicaLogin
    {
        //Variables para el Funcionamiento de login
        int intentos = 0; //intentos
        bool acceso = false; //validamos el acceso
        string rol = ""; //rol del usuario

        //Metodo para validar el acceso del login
        public string ValidarAcceso(cModeloLogin datos)
        {
            acceso = false;
            rol = "";

            //Primero validamos que las credenciales sean correctas
            if (datos.Username == "admin" && datos.Password == "admin123")
            {
                //Si son correctas, asignamos el rol y el acceso
                acceso = true;
                rol = "admin";

            }else if (datos.Username == "recepcionista" && datos.Password == "recep123")
            {
                acceso = true;
                rol = "recepcionista";
            }

            //Validamos las credenciaeles y los intentos
            if (acceso)
            {
                //Mostramos mensaje de bienvenida y el rol del usuario
                MessageBox.Show("Bienvenido " + rol, "Acceso concedido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                intentos = 0; //Reiniciamos los intentos
                return rol; //regresamos el rol del usuario
            }
            else //si no son correctos incrementamos los intentos
            {
                intentos++;
                //Validamos si el numero de intentos es mayor a 3
                if (intentos >= 3)
                {
                    //Mostramos el mensajde de error y cerramos la aplicacion
                    MessageBox.Show("Demasiados intentos fallidos. La aplicación se cerrará.", "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit(); //cerramos la aplicacion
                    return ""; //regresamos el rol vacio
                }
                else
                {
                    //calculamos los intentos restantes
                    int rest = 3 - intentos;
                    //Mostramos el mensaje de error y los intentos restantes
                    MessageBox.Show("Usuario o contraseña incorrectos. Intentos restantes: " + rest, "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return ""; //regresamos el rol vacio
                }
            }
        }
    }
}
