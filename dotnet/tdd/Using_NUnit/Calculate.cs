namespace Using_NUnit
{
    public class Calculate
    {
        public int Somar(int a, int b)
        {
            return a + b;
        }

        public int Multiplicar(int a, int b)
        {
            return a * b;
        }

        public int Dividir(int a, int b)
        {
            var resultado = 0;
            if(a != 0) 
            {
                resultado = a / b;
            }
            return resultado;
        }
    }
}