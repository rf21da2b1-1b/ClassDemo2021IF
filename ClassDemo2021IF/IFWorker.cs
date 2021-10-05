using System;

namespace ClassDemo2021IF
{
    public class IFWorker
    {
        public IFWorker()
        {
        }

        public void Start()
        {
            String ugedag = "torsdag";

            if (ugedag == "søndag")
            {
                Console.WriteLine("Jubii det er søndag");
            }

            if (ugedag != "søndag")
            {
                Console.WriteLine("øv");
            }


            if (ugedag == "søndag")
            {
                //sandt
                Console.WriteLine("Jubii det er søndag");
            }
            else
            {
                //falsk
                Console.WriteLine("øv");
            }


            bool solskin = true;

            if (ugedag == "søndag")
            {
                if (solskin)
                {
                    Console.WriteLine("Jaa jeg får is");
                }
            }

            // alternativt
            if (ugedag == "søndag" && solskin)
            {
                Console.WriteLine("Jaa jeg får is");
            }



            // Mange if sætninger inde i hinanden
            if (ugedag == "mandag")
            {
                // ...
            }
            else if (ugedag == "tirsdag")
            {
                // ...
            }


            // mere rigtigt med switch
            switch (ugedag)
            {
                case "mandag":
                    // ...
                    Console.WriteLine(ugedag);
                    break;

                case "tirsdag":
                    // ...
                    Console.WriteLine(ugedag);
                    break;

                case "onsdag":
                    // ...
                    Console.WriteLine(ugedag);
                    break;

                case "torsdag":
                    // ...
                    Console.WriteLine(ugedag);
                    break;

                case "fredag":
                    // ...
                    Console.WriteLine("weekend");
                    break;

                case "lørdag":
                    // ...
                    Console.WriteLine("weekend");
                    break;

                case "søndag":
                    // ...
                    Console.WriteLine("weekend");
                    break;


                default:
                    Console.WriteLine($"{ugedag} ikke en gyldig ugedag");
                    break;
            }
        }
    }
}