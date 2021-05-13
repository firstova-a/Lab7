using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace Laboratory7
{
    class Program
    {
        

        static async Task Main(string[] args)
        {
            bool run = true;
            while (run)
            {   
                Console.WriteLine("Do you want to know the address by coordinates? Enter 'n' if no, any other character if yes");
                string marker = Console.ReadLine();
                if (marker == "n")
                {
                    run = false;                    
                }
                else
                {
                    Console.WriteLine("Enter latitude (decimal separator '.')");
                    string lat = Console.ReadLine();
                    Console.WriteLine("Enter longitude (decimal separator '.')");
                    string lon = Console.ReadLine();
                    using (HttpClient client = new HttpClient())
                    {
                        client.DefaultRequestHeaders.Add("User-Agent", "C# App");
                        HttpResponseMessage searchRespons = await client.GetAsync($"https://nominatim.openstreetmap.org/reverse?format=jsonv2&lat={lat}&lon={lon}");

                        if (searchRespons.IsSuccessStatusCode)
                        {
                            //string responceText = await searchRespons.Content.ReadAsStringAsync();
                            //Console.WriteLine(responceText);
                            SearchJson answer = await searchRespons.Content.ReadFromJsonAsync<SearchJson>();
                            if (answer.display_name != null)
                            {
                                Console.WriteLine("Full addres:" + answer.display_name);
                            }
                            else
                            {
                                Console.WriteLine("This point on the map has no address");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Failed request");
                        }
                    }
                    
                }               
            }
        }
    }
}
