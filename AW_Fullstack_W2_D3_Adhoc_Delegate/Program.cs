using System;

namespace AW_Fullstack_W2_D3_Adhoc_Delegate
{
    class Program
    {
        public delegate void tulostaJotain(string jono);

        public static void KirjoitaKonsoliin(string jono)
        {
            Console.WriteLine(jono);
        }

        public static void KirjoitaTakaperin(string jono)
        {
            char[] kirjainArray = jono.ToCharArray();
            Array.Reverse(kirjainArray);
            Console.WriteLine(new string(kirjainArray));
        }

        public static void kutsuDelegatea(tulostaJotain metodi)
        {
            metodi("Testi merkki jono");
        }

        static void Main(string[] args)
        {
            tulostaJotain eka = new tulostaJotain(KirjoitaKonsoliin);
            tulostaJotain toka = new tulostaJotain(KirjoitaTakaperin);
            kutsuDelegatea(eka);
            kutsuDelegatea(toka);
            
        }
    }
}
