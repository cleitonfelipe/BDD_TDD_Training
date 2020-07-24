using System;

namespace Using_NUnit
{
    public class NumerosRomanos
    {
        public bool Converter(string numero)
        {
            if(!String.IsNullOrEmpty(numero))
            {
                return true;
            }
            return false;
        }
    }
}