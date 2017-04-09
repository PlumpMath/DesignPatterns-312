using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    /*
    Singleton to wzorzec strukturalny.

        Cel:
        Możliwe jest utworzenie tylko jednej instancji danej klasy.

        Implementacja:
        Ukrycie konstruktora.
        Metoda umożliwiająca pobranie instancji klasy.

        Uwaga:
        Należy zabezpieczyć singleton przy dostępie z wielu wątków.

    */

    public class Singleton
    {
        //można również od razu utworzyć instację klasy.
        private static Singleton _singleton;

        private static object lockMultithreading=new object();

        private Singleton()
        {
            Console.WriteLine("Tworzę singleton");
        }

        private List<string> notificationList=new List<string>();

        public void AddNotification(string text)
        {
            notificationList.Add(text);
        }

        public static Singleton Instance()
        {
            lock (lockMultithreading)
            {
                if (_singleton == null)
                {
                    //lazy initialization
                    _singleton = new Singleton();
                }
                return _singleton;
            }
        }

    }
}
