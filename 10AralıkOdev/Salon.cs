using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10AralıkOdev
{
    public class Salon
    {
        //herşey static olması nesne oluşturmadan kolayca yapmak ama classı static yapmama sabebim kalıtım yolu ile kalıtım vermekten dolayı

        static string _salonname;
        static int _koltuksayisi;
        static int _boskoltuk;

        public static string SalonName { get { return _salonname; } set { _salonname = value; } }
        public static int KoltukSayisi { get { return _koltuksayisi; } set { _koltuksayisi = value; } }
        public static int BosKoltuk { get { return _boskoltuk; } set { _boskoltuk = value; } }

    }
}
