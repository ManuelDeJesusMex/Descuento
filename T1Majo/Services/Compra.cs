using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t1Majo.Services
{
    public class Compra
    {
        public double RetornoDescuento (double TotalconDescuento)
        {
            return Descuento(TotalconDescuento);

        }
        private string  Descuento (double TotalCompra)
        {

            double TotalconDescuento, MesesSinIntereses;

            string TuDescuento;
            if (TotalCompra <= 5000)
            {

                TotalconDescuento = TotalCompra * 0.10;

                return TotalconDescuento;

            }
            if (TotalCompra >=8000)
            {
                MesesSinIntereses = TotalCompra / 3;

                TuDescuento = "Tu compra se puede aplicar un plazo de pago de meses sin intereses.\n Por lo que pagarías: "+MesesSinIntereses+" cada mes";

                return TuDescuento;
            }
            if (TotalCompra >= 10000)
            {

            }
        }

    }
}
