using System;

namespace LoginValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada kasutajatunnus ja salasõna
            //kui sisestatud kasutajatunnus on "admin" ja sisestatud salasõna "admin1234"
            //siis konsoolis kuvatakse "Teretulemast!"
            //muul konsoolis kuvatakse "Vale kasutajatunnus või salasõna"
            //kasutajal on kolm katset

            int i = 0;
            while (i < 3)
            {
                Console.WriteLine("Sisesta kasutajatunnus:");
                string userName = Console.ReadLine();
                Console.WriteLine("Sisesta Salasõna:");
                string userPassword = Console.ReadLine();



                if (userName == "admin" && userPassword == "admin1234")
                {
                    Console.WriteLine("Tere tulemast!");
                }
                else
                {
                    i++;
                    Console.WriteLine($"Vale kasutajatunnus või salasõna. {3 - i} katset on veel jäänud");
                }
            }
        }
    }
}
