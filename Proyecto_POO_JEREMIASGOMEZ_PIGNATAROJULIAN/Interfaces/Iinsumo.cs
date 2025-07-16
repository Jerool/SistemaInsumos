using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_POO_JEREMIASGOMEZ_PIGNATAROJULIAN
{
    internal interface Iinsumo
    {

        void registrarinsumo(string text1, double value, string text2, string text3, string text4, string text5, string nombrempleado);

        string ToString();

        string ArchivoString();
    }
}
