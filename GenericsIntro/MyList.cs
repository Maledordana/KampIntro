using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T>
    {

        //farkındaysan metod dışında yazdık
        //string[] items;
        //bunu yazmam doğru mu değil


        //class'ı newlediğimizde oluşturmak zorundayız o yüzden
        //metot dışında tanımladık
        T[] items;

        //constructer
        public MyList()
        {
            items = new T[0];
        }
        
        public void Add(T item)
        {
            T[] tempArray = items;

            //dizinin eleman sayısını bir artırmış olduk
            items = new T[items.Length + 1];
            //newlediğimizde içindeki item gitmesi gerekiyodu
            //aslında ref no'su gidiyor
            //bunu engellemek içinse
            //tempArray tanımadık
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }
            //döngüde de itemstaki itemleri geri alıyoruz

            items[items.Length - 1] = item;
            //şuan ekledik itemi
        }
    }
}
