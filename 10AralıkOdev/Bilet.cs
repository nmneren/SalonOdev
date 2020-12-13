using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace _10AralıkOdev
{
    public class Bilet : Salon
    {
        // kalıtım alma sebebim kontrollerde ulaşabilmem için

        static int _fiyat = 10;
        static int _bakiye;
        static bool _check;

        public static int Fiyat { get { return _fiyat; } }
        public static int Bakiye { get { return _bakiye; } }
        public static bool Check { get { return _check; } set { _check = value; } }

        public static void Sat(bool knt)
        {
            Check = knt;

            if (Check == true)
            {
                _fiyat = 5;
            }

            if (BosKoltuk > 0)
            {
                BosKoltuk -= 1;

                _bakiye += _fiyat;

                MessageBox.Show("Bilet Satıldı.");

            }
            else
            {
                MessageBox.Show("Lütfen Salon Oluşturun.");
            }
        }
        public static void Iptal()
        {
            BosKoltuk += 1;
            _bakiye -= _fiyat;
            MessageBox.Show("İptal Edildi.");
        }
    }
}
