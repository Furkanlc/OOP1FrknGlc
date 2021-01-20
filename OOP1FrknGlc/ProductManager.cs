using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1FrknGlc
{     //Ürün ile ilgili operasyonlar var
    class ProductManager
    {

        public void Add(Product product)
        {
            Console.WriteLine(product.ProductName + " : Eklendi");
        }

        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + "Guncellendi");
        }


        //void ve int in farkı nedir=

        // --programda eğer topladıktan sonra bana tekrar o toplamanın sonucunu kullanacaksam
       // -- toplama sonucunda çarpma işlemi yapacaksam int olanı kullanmak zorundayım 

        public int Topla(int s1,int s2)
        {
            return s1 + s2;
        }

        public void Topla2(int s1, int s2)
        {
            Console.WriteLine( s1 + s2);
        }
    }
}
