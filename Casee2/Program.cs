
using System;
using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using Casee2;

namespace Casee2
{
    class Program
    {
        static void Main(string[] args)
        {
            Worker Martin = new Worker("Martin", "Jensen", 11111111, Opgave.Bilmekaniker, KøretøjType.Bil);
            Worker Thomas = new Worker("Thomas", "Hansen", 22222222, Opgave.Motorcykelmekaniker, KøretøjType.Motorcykel);
            Worker Henrik = new Worker("Henrik", "Nierlsen", 33333333, Opgave.Lastbilmekaniker, KøretøjType.Lastbil);
            //Console.WriteLine($" \n Fornavn: {Martin.FirstName}                  Fornavn: {Thomas.FirstName}                       Fornavn: {Henrik.FirstName}");
            //Console.WriteLine($" \n Efternavn: {Martin.LastName}                Efternavn: {Thomas.LastName}                     Efternavn: {Henrik.LastName}");
            //Console.WriteLine($" \n TlfNr: {Martin.TelefonNr}                  TlfNr: {Thomas.TelefonNr}                       TlfNr: {Henrik.TelefonNr}");
            //Console.WriteLine($" \n Opgave: {Martin.MekanikerObjekt}             Opgave: {Thomas.MekanikerObjekt}           Opgave: {Henrik.MekanikerObjekt}");



            try

            {
                Entry e1 = new();
                bool x = false;
                while (!x)
                {



                    Console.WriteLine("Velkom til  indtast venligst dit Navn :");
                    string Kundenavn = Console.ReadLine();

                    Console.WriteLine("\nIndtast venligst dit Efternavn");
                    string KundeEfternavn = Console.ReadLine();

                    Console.WriteLine("\nIndtast venligst dit TlfNr");
                    int Tlf = int.Parse(Console.ReadLine());

                    Console.WriteLine("\nIndtast veligst bilens nummerplad");
                    string Nummerplader = Console.ReadLine();


                    Console.WriteLine("\nIndtast venligst din bilmærke");
                    string bilmærke = Console.ReadLine();

                    Console.WriteLine("\nIndtast venligst bilmodel");
                    string bilmodel = Console.ReadLine();



                    Console.WriteLine("\nIndtast venligst din bilens registrerings årgang");
                    DateTime årgang = DateTime.Parse(Console.ReadLine());

                    Console.WriteLine("\nAngiv KøretøjType: (Vælg mellem disse Køretøjerr)  ");
                    Console.WriteLine("   Bil,       Motorcykel,        Lastbil");
                    string køretøj = Console.ReadLine();
                    Kunde k1 = new Kunde(Kundenavn, KundeEfternavn, Tlf, Nummerplader, bilmærke, bilmodel, årgang);



                    if (køretøj==KøretøjType.Bil.ToString())
                    {
                        e1.Entries.Add(new Entry(k1, Martin));
                        Console.WriteLine($" \n Fornavn: {Martin.FirstName} ");
                        Console.WriteLine($" \n Efternavn: {Martin.LastName} ");
                        Console.WriteLine($" \n TlfNr: {Martin.TelefonNr} ");
                        Console.WriteLine($" \n Opgave: {Martin.MekanikerObjekt} ");

                    }
                    else if (køretøj==KøretøjType.Motorcykel.ToString())
                    {
                        e1.Entries.Add(new Entry(k1, Thomas));
                        Console.WriteLine($" \n Fornavn: {Thomas.FirstName} ");
                        Console.WriteLine($" \n Efternavn: {Thomas.LastName} ");
                        Console.WriteLine($" \n TlfNr: {Thomas.TelefonNr} ");
                        Console.WriteLine($" \n Opgave: {Thomas.MekanikerObjekt} ");

                    }
                    else if (køretøj==KøretøjType.Lastbil.ToString())
                    {
                        e1.Entries.Add(new Entry(k1, Henrik));
                        Console.WriteLine($" \n Fornavn: {Henrik.FirstName} ");
                        Console.WriteLine($" \n Efternavn: {Henrik.LastName} ");
                        Console.WriteLine($" \n TlfNr: {Henrik.TelefonNr} ");
                        Console.WriteLine($" \n Opgave: {Henrik.MekanikerObjekt} ");

                    }
                    foreach (Entry items in e1.Entries)
                    {
                        Console.WriteLine($"\n\n \nKunde: ({items.Kundeinfo.FirstName}  {items.Kundeinfo.LastName})   har registreret en  Typekøretøj :( {items.WorkerInfo.KøretøjType} )  Model : {bilmærke} ({bilmodel})  ");
                    }
                    Console.WriteLine(" \n Indtast (Søg) for at søge efter kundens navn ");
                    string i = Console.ReadLine();


                    if (i=="Søg")
                    {
                        x=true;
                        Console.WriteLine("Søg kundens navn  navn her :  ");
                        string name = Console.ReadLine();
                        k1.Getname(e1, name);
                        Martin.Getname(e1, name);
                        Thomas.Getname(e1, name);

                    }



                }


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();

        }
    }
}
