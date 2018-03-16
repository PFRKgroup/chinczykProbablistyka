using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Probabilistyka_projekt
{
    class Main_Code
    {
        private static int[] naKtorym = new int [4], ileRzutow = new int[4];
        private static int ktoryGracz = 0, los, pola;
        private static bool[] start = new bool[4];
        private static string[] gracze = new string[4];
        private static bool koniec = false;
        private static double chance, max;
        public static int[] ileWygranych = new int[4];
        private static int theThingThatIsVeryNeeded = 0;

        public static void zeruj_na_koniec_sym()
        {
            for (int i = 0; i < 4; i++)
            {
                ileWygranych[i] = 0;
            }

        }
        private static void zeruj()
        {
            pola = Simulation.get_pola;
            
            for (int i = 0; i < 4; i++)
            {
                start[i] = true;
                gracze[i] = "Gracz " + (i + 1).ToString();
                ileRzutow[i] = 0;
            }
            koniec = false;
        }

        public static void start_simulation()
        {
            zeruj();
            int ile_symulacji = Simulation.ile_sym;
            for (int i = 0; i < ile_symulacji; i++)
            {
                theThingThatIsVeryNeeded = i;
                Simulation.progresbar();
                while (koniec != true)
                {
                    ileRzutow[ktoryGracz]++;
                    move(ktoryGracz, rzut_kostka());
                    ktoryGracz++;
                    if (ktoryGracz > 3)
                    {
                        ktoryGracz = 0;
                    }
                }
                zeruj();
            }

        }
        
        private static void move(int gracz, int wylosowana)
        {
            if (start[gracz] == true)
            {
                move_from_start(gracz, wylosowana);
            }
            else
            {
                if (naKtorym[gracz] < pola)
                {
                    naKtorym[gracz] += wylosowana;
                    if (naKtorym[gracz] == pola)
                    {
                        koniec = true;
                        for (int i = 0; i < 4; i++)
                        {
                            Simulation.wyniki[theThingThatIsVeryNeeded + 1] = ileRzutow[gracz].ToString();
                        }
                        ileWygranych[gracz]++;
                    }
                    else
                    {
                        if (naKtorym[gracz] > pola)
                        {
                            naKtorym[gracz] -= wylosowana;
                        }
                        else
                        {
                            for (int x = 0; x < 4; x++)
                            {
                                if (x != gracz)
                                {
                                    if (naKtorym[gracz] == naKtorym[x])
                                    {
                                        start[x] = true;
                                    }
                                }
                            }
                            if (cofnijNaStart() == true)
                            {
                                start[ktoryGracz] = true;
                            }
                        }
                    }
                }
                //else if ((naKtorym[gracz] + wylosowana) == pola)
                //{
                //    koniec = true;
                //}
            }
        }
        private static void move_from_start(int gracz, int wylosowana)
        {
            if (wylosowana == 6)
            {
                start[gracz] = false;
                naKtorym[gracz] = 1;
            }
        }
        private static int rzut_kostka()
        {
            Random kostka = new Random();
            int wylosowana = kostka.Next(1, 7);
            return wylosowana;
        }
        
        public static bool cofnijNaStart()
        {
            Random wybor = new Random();
            Random rand = new Random();

            los = wybor.Next(1, 5);

            if (los == 1)
            {
                chance = 0.89;
                max = rand.NextDouble(0.0, 1.0);
                if (max > chance)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else if (los == 2)
            {
                chance = 0.51;
                max = rand.NextDouble(0.0, 1.0);
                if (max > chance)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else if (los == 3)
            {
                chance = 0.15;
                max = rand.NextDouble(0.0, 1.0);
                if (max > chance)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else
            {
                return false; //true cofa na start
            }

        }

    }
    public static class RandomExtensions
    {
        public static double NextDouble(this Random rand, double minValue, double maxValue)
        {
            return rand.NextDouble() * (maxValue - minValue) + minValue;
        }
    }

}