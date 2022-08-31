using System;

namespace EjercicioPropuestoConceptosPOO
{
    class Program
    {
        static void Main()
        {
            Complejo PrimerInstancia = new Complejo( 5, 3 );
            Complejo SegundaInstancia = new Complejo( 2, 6 );

            Console.WriteLine( $"Suma: { PrimerInstancia + SegundaInstancia }" );
            Console.WriteLine( $"Resta: { PrimerInstancia + SegundaInstancia }" );
            Console.WriteLine( $"Multiplicación: { PrimerInstancia + SegundaInstancia }" );
            Console.WriteLine( $"Multiplicación con un Double: { PrimerInstancia * 5.5 }" );
            Console.WriteLine( $"División: { PrimerInstancia / SegundaInstancia }" );
        }
    }
}
