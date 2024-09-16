using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace This.team
{
    internal class Opcion
    {
        //Mensaje que describe la opción.
        private string message;
        //Acción que se ejecuta al seleccionar la opción.
        private Action action;

        //Constructor que inicializa el mensaje y la acción.
        public Opcion(string message, Action action)
        {
            this.message = message;
            this.action = action;
        }

        //Propiedad para acceder al mensaje.
        public string Message { get { return message; } }
        //Propiedad para acceder a la acción.
        public Action Action { get { return action; } }
    }
}
