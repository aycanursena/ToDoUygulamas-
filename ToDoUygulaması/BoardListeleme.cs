using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ToDoUygulaması
{
    internal class BoardListeleme
    {
        public enum buyukluk
        {
            XS = 1,
            S = 2,
            M = 3,
            L = 4,
            XL = 5
        }

        public List<string> baslik = new List<string>
                                    {"a", "b", "c", "d", "e"};

        public List<string> icerik = new List<string>
                                    {"a", "b", "c", "t", "u"};

        public List<string> atananKisi = new List<string>
                                    {"Ali", "Fatma", "Burcu", "Cenk", "Murat"};
        public List<buyukluk> buyuklukList = new List<buyukluk>
                                    {buyukluk.XS, buyukluk.S, buyukluk.M, buyukluk.M, buyukluk.L};

    }
}
