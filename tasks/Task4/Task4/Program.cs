using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {            
            Beruf[] beruf = null;

            string path     = AppDomain.CurrentDomain.BaseDirectory;

            try
            {

                beruf = new Beruf[] { new Beruf("Kommunikationstechniker", 54321),
                                        new Beruf("Kellner", 10000),
                                        new Beruf("Netzwerktechniker", 12345),
                                        new Beruf("Mechaniker", 30000),
                                        new Beruf("ITtechniker", 23456),
                                        new Beruf("Bauarbeiter", 20000)};


                // Seralize objects
                for (int i = 0; i < beruf.Length; i++)
                {
                    string json = JsonConvert.SerializeObject(beruf[i], Formatting.Indented);

                    File.WriteAllText(path + "object" + i + ".json", json);
                }

                // Deseralize objects
                for (int i = 0; i < beruf.Length; i++)
                {
                    string json = File.ReadAllText(path + "object" + i + ".json");

                    Beruf _beruf = JsonConvert.DeserializeObject<Beruf>(json);

                    beruf[i] = _beruf;
                }


                // Print raw JSON files
                for (int i = 0; i < beruf.Length; i++)
                {
                    string content = File.ReadAllText(path + "object" + i + ".json");

                    Console.WriteLine(content);
                }

                // Delete JSON file
                for (int i = 0; i < beruf.Length; i++)
                {
                    File.Delete(path + "object" + i + ".json");
                }
            }

            catch (ArgumentNullException ex)
            {
                Console.WriteLine(ex.Message);
            }

            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
