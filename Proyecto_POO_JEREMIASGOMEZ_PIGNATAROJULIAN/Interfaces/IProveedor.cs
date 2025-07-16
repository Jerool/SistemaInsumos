using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_POO_JEREMIASGOMEZ_PIGNATAROJULIAN
{
    internal interface IProveedor
    {
         void RegistrarProveedor(string text1, decimal value, string text2, string txtTelefono, string contraseña);

        string ToString();

    }
}
