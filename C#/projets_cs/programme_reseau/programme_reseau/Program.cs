using System;
using System.Net;

namespace programme_reseau { 



   class Program
   {
        static void Main(string[] args)
        {


            var webClient = new WebClient();

            string url = "https://codeavecjonathan.com/res/exemple.html";

            Console.WriteLine(url);

            string response = webClient.DownloadString(url);

            Console.WriteLine(response);




        }
   }
}

