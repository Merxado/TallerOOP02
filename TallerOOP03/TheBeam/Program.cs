class Program
{
    static void Main()
    {
        Console.Write("Ingrese la viga: ");
        string viga = Console.ReadLine();

        if (string.IsNullOrEmpty(viga))
        {
            Console.WriteLine("La viga está mal construida!");
            return;
        }

        int resistencia = 0;

        switch (viga[0])
        {
            case '%': resistencia = 10; break;
            case '&': resistencia = 30; break;
            case '#': resistencia = 90; break;
            default:
                Console.WriteLine("La viga está mal construida!");
                return;
        }

        int pesoTotal = 0;
        int secuencia = 0;

        for (int i = 1; i < viga.Length; i++)
        {
            char c = viga[i];

            if(c == '=')
            {
                secuencia++;
                pesoTotal += secuencia;
            }
            else if(c == '*')
            {
                if (i > 1 && viga[i - 1] == '*')
                {
                    Console.WriteLine("La viga está mal construida!");
                    return;
                }

                int pesoSecuencia = secuencia * (secuencia + 1) / 2;
                pesoTotal += pesoSecuencia * 2;
                secuencia = 0;
            }
            else
            {
                Console.WriteLine("La viga está mal construida!");
                return;
            }
        }

        if (pesoTotal <= resistencia)
            Console.WriteLine("La viga soporta el peso!");
        else
            Console.WriteLine("la viga NO soporta el peso!");
    }
}