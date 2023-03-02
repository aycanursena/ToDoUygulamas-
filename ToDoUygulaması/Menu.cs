using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoUygulaması
{
    internal class Menu
    {
        public Menu()
        {
            Console.WriteLine("--- HOŞGELDİNİZ ! ---");
            Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz :)");
            Console.WriteLine("*******************************************");

            Console.WriteLine("(1) Board listelemek");
            Console.WriteLine("(2) Board'a kart eklemek");
            Console.WriteLine("(3) Board'dan kart silmek");
            Console.WriteLine("(4) Kart taşımak");
            Console.Write("Seçiminiz : ");
            int secim = Convert.ToInt32(Console.ReadLine());

            switch (secim)
            {
                
                    
            }

        }
    }
}
