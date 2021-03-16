using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace CalculadoraWS
{
    /// <summary>
    /// Descripción breve de CalcularWebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class CalcularWebService1 : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hola a todos";
        }

        [WebMethod]
        public decimal cuadrado(decimal n1, decimal n2)
        {
            Calcular c = new Calcular();
            return c.cuadrado(n1,n2);
        }

        [WebMethod]
        public decimal triangulo(decimal n1, decimal n2)
        {
            Calcular c = new Calcular();
            return c.triangulo(n1, n2);
        }

        [WebMethod]
        public float circulo(float n1,float n2)
        {
            Calcular c = new Calcular();
            return c.circulo(n1,n2);
        }
    }
}
