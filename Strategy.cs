using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Siparis
{
    class OdemeIslemleri
    {
        private IOdeme _odeme;
        public OdemeIslemleri(IOdeme _odeme)
        {
            this._odeme = _odeme;

        }
        public void OdemeYap()
        {
            this._odeme.OdemeYap();
        }
    }
     
    interface IOdeme
    {
       void OdemeYap();
    }
   
    class NakitOdeme : IOdeme
    {
       

        public void OdemeYap()
        {
            //int a=1;
            //if (a==1)
            //{
            //    MessageBox.Show("Nakit Ödendi!");

            //}
            MessageBox.Show("Nakit Ödendi!");
        }

        
    }

    class KrediOdeme : IOdeme
    {
        
        
        public void OdemeYap()
        {

            //int a = 2;
            //if (a==2)
            //{
            //    MessageBox.Show("Kart  Ödendi!");
            //}
            MessageBox.Show("Kart  Ödendi!");
        }

        
    }
  
}


