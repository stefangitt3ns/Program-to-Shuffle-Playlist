using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_to_Shuffle_Playlist_or_Entire_Music_Library
{
    internal class Program
    {
        static void Main(string[] args)
        {
         Console.Title = "Music Shuffler";

            string[] SaturdayNightPlaylist = 
            {
                "\"Carried Away\" - Goosetaf",
                "\"Jacaranda\" - LoFi Coffee",
                "\"3rd Times the Charm\" - Soho",
                "\"Waterfalls\" - Molly McPhaul",
                "\"Singapore\" - Danny Lover",
                "\"Paul Scholes\" - Black Josh",
                "\"Joanna\" - Floeme",
                "\"Wartemarke\" - Flatpocket",
                "\"Hikari\" - Nujabes",
                "\"Drawn\" - Ramsey",
                "\"Yanima\" - El Buho",
                "\"Alice\" - The Cancel",
                "\"SpiderSilk Robes\" - Bones",
                "\"BONITO\" - CLBRKS",
                "\"M.P.A\" - Pusha T",
                "\"Cocktail Napkin\" - Danny Lover",
                "\"PopRocks\" - Bones",
                "\"FORWHATITSWORTH\" - CLBRKS",
                "\"Rare Nirvana\" - Danny Lover"
            };

            string[] popularRock = 
            {
                "\"Bohemian Rhapsody\" - Queen",
                "\"Stairway to Heaven\" - Led Zeppelin",
                "\"Hotel California\" - Eagles",
                "\"Sweet Child O' Mine\" - Guns N' Roses",
                "\"Back In Black\" - AC/DC",
                "\"Smoke on the Water\" - Deep Purple",
                "\"Livin' on a Prayer\" - Bon Jovi",
                "\"Dream On\" - Aerosmith",
                "\"Imagine\" - John Lennon",
                "\"Comfortably Numb\" - Pink Floyd",
                "\"Purple Haze\" - Jimi Hendrix",
                "\"Highway to Hell\" - AC/DC",
                "\"Whole Lotta Love\" - Led Zeppelin",
                "\"Under Pressure\" - Queen & David Bowie",
                "\"Another Brick in the Wall\" - Pink Floyd"
            };

            string[] loFiBumps = 
            {
                "\"Snowman\" - WYS",
                "\"Dreaming of a New Day\" - Oatmello",
                "\"Rainy Nights in Tokyo\" - Idealism",
                "\"Thankful\" - Sleepy Fish",
                "\"Flowers\" - In Love With a Ghost",
                "\"Sundown\" - Aso",
                "\"I Wasn’t Enough\" - Jinsang",
                "\"Pastel\" - Kupla",
                "\"Where We Met\" - softy",
                "\"Wistful\" - Monma",
                "\"Letting Go\" - Flitz&Suppe",
                "\"Night Owl\" - eevee",
                "\"First Light\" - cocabona",
                "\"Yesterday\" - Leavv",
                "\"Her\" - SwuM"
            };


            string[] ItalianSummer = 
            {
                "\"Metti, una sera a cena\" - Ennio Morricone",
                "\"Magic Waltz\" - Ennio Morricone",
                "\"Come Maddalena\" - Ennio Morricone",
                "\"Right or Wrong\" - Piero Piccioni",
                "\"Easy Lovers\" - Piero Piccioni",
                "\"Amore Mio Aiutami\" - Piero Piccioni",
                "\"Il Giocattolo\" - Ennio Morricone",
                "\"Django Theme\" - Luis Bacalov",
                "\"La Bambola\" - Piero Umiliani",
                "\"A Poche Ore Da Te\" - Armando Trovajoli",
                "\"Pas de Deux\" - Michel Legrand",
                "\"Metti una Sera a Cena (Reprise)\" - Ennio Morricone",
                "\"Questi Vent’anni Miei\" - Piero Piccioni",
                "\"Crepuscolo Sul Mare\" - Piero Umiliani",
                "\"Love Theme from 'The Sicilian Clan'\" - Ennio Morricone"
            };

            string[] ClassicalCardio = 
            {
                "\"The Battle of Pelennor Fields\" - Howard Shore",
                "\"Progeny\" - Hans Zimmer (from Gladiator)",
                "\"Now We Are Free\" - Hans Zimmer & Lisa Gerrard (from Gladiator)",
                "\"Time\" - Hans Zimmer (from Inception)",
                "\"Prelude in F# Minor, Op. 23, No. 1\" - Sergei Rachmaninoff",
                "\"One Way\" - Hans Zimmer (from Interstellar)",
                "\"Light of the Seven\" - Ramin Djawadi (from Game of Thrones)",
                "\"Test Drive\" - John Powell (from How to Train Your Dragon)",
                "\"Parlay\" - Hans Zimmer (from Pirates of the Caribbean: At World's End)",
                "\"He's a Pirate\" - Klaus Badelt (from Pirates of the Caribbean)",
                "\"The Last Samurai\" - Hans Zimmer",
                "\"The Breaking of the Fellowship\" - Howard Shore (from The Lord of the Rings)",
                "\"Honor Him\" - Hans Zimmer & Lisa Gerrard (from Gladiator)",
                "\"The Skye Boat Song\" - Bear McCreary (from Outlander)",
                "\"Mountains\" - Hans Zimmer (from Interstellar)"
            };

            /// <summary>
            /// A code to Shuffle music in an array called myPlaylist
            /// </summary>

            Console.WriteLine
             (
              " A:SaturdayNightPlaylist\n B:PopularRock\n C:LoFi Bumps\n D:Italian Summer\n E:Classical Cardio\n" 
             );

            Console.WriteLine("Select the letter to the corresponding Playlist");
            Console.WriteLine();

            string myPlaylist = Console.ReadLine();
            string [] selectedPlaylist = null;

            switch (myPlaylist)
            {
                case "A":
                case "a":
                    selectedPlaylist = SaturdayNightPlaylist;
                    break;

                case "B":
                case "b":
                    selectedPlaylist = popularRock;
                    break;

                case "C":
                case "c":
                    selectedPlaylist = loFiBumps;
                    break;

                case "D":
                case "d":
                    selectedPlaylist = ItalianSummer;
                    break;

                case "E":
                case "e":
                    selectedPlaylist = ClassicalCardio;
                    break;
            }

            if (selectedPlaylist != null)
            {

                Random random = new Random();
                foreach (string song in selectedPlaylist)
                {
                    int shuffle = random.Next(0, selectedPlaylist.Length);
                    Console.WriteLine(selectedPlaylist[shuffle]);
                }
            }
            else
            {
                Console.WriteLine(" No Playlist selected");

            }



            Console.ReadKey();

        }
    }
}
