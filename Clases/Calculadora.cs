using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace tpn7.Clases
{
    public class Calculadora
    {
        private float x;
        private float y;
        private string z;
        private DateTime fecha;

        public float X { get => x; set => x = value; }
        public float Y { get => y; set => y = value; }
        public string Z { get => z; set => z = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }

        public string resultado(float X, float Y, string Z, DateTime Fecha) {
            string res="";
            if (Z == "+") {
                res = (X + Y).ToString();
            }else if(Z == "-")
            {
                res = (X - Y).ToString();
            }
            else if(Z == "*")
            {
                res = (X * Y).ToString();
            }
            else if(Z == "/")
            {
                if (Y != 0) {
                    res = (X / Y).ToString();
                }
                else { res = "ERROR"; }
            }

            //return X.ToString() + "#" + Z + "#" + Y.ToString() + "#" + res + "#" + Fecha.ToString();
            return res;
        }
    }
}
