using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alapaok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //külön régiók kialakítása
            #region Kiirás 
            /*
            //fajlneve/bin/fajlneve.exe maga a fálj.
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("Alapok : ");
            int a, b; //több változó deklarálása
            a = 5; // értékadás
            double tort = 5.99;
            float tort2 = 3.2F; //F nelkül nem jó , nem ugy mint  a double D nélkül!
             char karakter = 'D'; //const miatt nem változtatható többet!
            var valtozo = 10; //felismeri a típust magától.
            var betu = 'c'; 
            bool boolean = true;
            string nev = "Mócza Szilvia";
            
            Console.Write(tort2);
            Console.WriteLine(); // ez a sortörés
            Console.WriteLine("Név: {0} Float: {1} Betű: {2}", nev, tort2, karakter);
            Console.WriteLine("Törtszám összege: " + tort2);
            Console.WriteLine($"Betű: {betu} Változó: {valtozo}");//$ formázott kiírás
            Console.WriteLine(nev, tort);  //csak az elsőt fogja kiírni.                                                          
            

            var s = string.Format("Var típusú változó értéke: {0} a második: {1}", valtozo, betu);
            Console.WriteLine(s);

            nev = "";
            nev = string.Empty; //kiüríti a nev valtozót.
            */
            #endregion

            #region Számolás
            /*var valtozo = 23;
            const double PI = 3.14; //nem csak instalálunk hanem inicializálunk is, constantok mindig nagy betű.
            string nev = null; //ctrl+k+c sorkomment , ctrl+k+u visszavonás
            Console.WriteLine("Add meg a Neved: ");
            nev = Console.ReadLine();
            Console.WriteLine($"A neved: {nev}");
            Console.WriteLine("Add meg a korod: ");
            int kor  = int.Parse(Console.ReadLine());// számmá konverteljuk, különben nem jó.
            Console.WriteLine($"A korod: {kor}"); //itt fontos a kivételkezelés!
            Console.WriteLine("Kor és a valtozo összege: {0}", valtozo+kor);
            Console.WriteLine("Kor és a valtozo szorzata: {0} { valtozo * kor }");
            int a = valtozo/kor;
            Console.WriteLine("Kor és a valtozo hanyadosa:" +a);
            int b = valtozo % kor; //maradékos osztás
            Console.WriteLine("Kor és a valtozo osztásának maradéka:" + b );
            double c = valtozo / kor;
            Console.WriteLine("Kor és a valtozo hanyadosa:" + c);*/
            #endregion

            #region Tipusátalakítás
            double tort = 23.92, tort2, eredmenyTort;
            int f = 10;
            tort2 = f; //edouble implicit;
            eredmenyTort = tort * tort2;
            Console.WriteLine("Az eredménytört: " + eredmenyTort);
            f = (int)tort; //tipusátalakítás
            Console.WriteLine("Az f értéke: " + f);
            int k = 22; Console.WriteLine("A k értéke: " + k);
            k =k - 1; Console.WriteLine("A k -1 értéke: " + k); 
            k++; Console.WriteLine("A k++ értéke: " + k); //azonnal végrehajtódik
            ++k;  Console.WriteLine("A ++k értéke: " + k); //használatnnál hajtódik végre
            // ugyan igy működik k--
            k += f; // k = k+a , ugyan igy - is
            Console.WriteLine("A k+f értéke: " + k);
            #endregion

            Console.ReadKey(); //gombnyomásra zárja be a futtatot ablakot. Ez az utolsó sor.
        }
    }
}
