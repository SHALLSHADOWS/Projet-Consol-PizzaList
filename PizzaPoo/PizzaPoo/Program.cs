using Newtonsoft.Json;
using PizzaPoo;
using System;
using System.Collections.Generic;
using System.Net;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
      // use that constant if you wanna add a dataset from an Api
      //
      // private const string apiUrl = "";

      // this one load default data from a json file
       private const string url = "https://codeavecjonathan.com/res/pizzas1.json";

        static void Main(string[] args)
        {
            string json = "";

            using (var webClient = new WebClient())
            {
                try
                {
                    json = webClient.DownloadString(url);
                }
                catch (WebException ex)
                {
                    Console.WriteLine(ex.Message);
                    return;
                }
            }

            List<Pizza> list = JsonConvert.DeserializeObject<List<Pizza>>(json);

            Console.WriteLine("Voici la liste de vos pizzas:\n");

            list.Sort((Pizza x, Pizza y) =>
            {
                return x.GetPrix().CompareTo(y.GetPrix());
            });

            foreach (Pizza pizza in list)
            {
                Console.WriteLine(pizza.Afficher());
            }
        }
    }
}
