using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes.Modelo
{
    internal class Billetera
    {
        public int BilletesDe10 { get; set; }
        public int BilletesDe20 { get; set; }
        public int BilletesDe50 { get; set; }
        public int BilletesDe100 { get; set; }
        public int BilletesDe200 { get; set; }
        public int BilletesDe500 { get; set; }
        public int BilletesDe1000 { get; set; }

 
       
        public Billetera(int billetes10, int billetes20, int billetes50, int billetes100, int billetes200, int billetes500, int billetes1000)
        {
            BilletesDe10 = billetes10;
            BilletesDe20 = billetes20;
            BilletesDe50 = billetes50;
            BilletesDe100 = billetes100;
            BilletesDe200 = billetes200;
            BilletesDe500 = billetes500;
            BilletesDe1000 = billetes1000;
        }

      
        public decimal Total(int BilletesDe10, int BilletesDe20, int BilletesDe50, int BilletesDe100, int BilletesDe200, int BilletesDe500, int BilletesDe1000)
        {
            int de10 = BilletesDe10 * 10;
            int de20 = BilletesDe20 * 20;
            int de50 = BilletesDe50 * 50;
            int de100 = BilletesDe100 * 100;
            int de200 = BilletesDe200 * 200;
            int de500 = BilletesDe500 * 500;
            int de1000 = BilletesDe1000 * 1000;

           int importeTotal = de10 + de20 + de50 + de100 + de200 + de500 + de1000;
            return importeTotal;
        }


        public Billetera Combinar(Billetera billeteraAdicional)
        {
            int sumade10 = (BilletesDe10 + billeteraAdicional.BilletesDe10) * 10;
            int sumade20 = (BilletesDe20 + billeteraAdicional.BilletesDe20) * 20;
            int sumade50 = (BilletesDe50 + billeteraAdicional.BilletesDe50) * 50;
            int sumade100 = (BilletesDe100 + billeteraAdicional.BilletesDe100) * 100;
            int sumade200 = (BilletesDe200 + billeteraAdicional.BilletesDe200) * 200;
            int sumade500 = (BilletesDe500 + billeteraAdicional.BilletesDe500) * 500;
            int sumade1000 = (BilletesDe1000 + billeteraAdicional.BilletesDe1000) * 1000;

            Billetera nuevaBilletera = new Billetera(sumade10,sumade20,sumade50,sumade100,sumade200,sumade500,sumade1000);

            return nuevaBilletera;
        }


        public void BilleteraAVaciar(Billetera billeteraAVaciar)
        {
            billeteraAVaciar.BilletesDe10 = 0;
            billeteraAVaciar.BilletesDe20 = 0;
            billeteraAVaciar.BilletesDe50 = 0;
            billeteraAVaciar.BilletesDe100 = 0;
            billeteraAVaciar.BilletesDe200 = 0;
            billeteraAVaciar.BilletesDe500 = 0;
            billeteraAVaciar.BilletesDe1000 = 0;
        }
    }
}

