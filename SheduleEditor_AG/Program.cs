using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SheduleEditor_AG
{
    class Program
    {
        static void Main(string[] args)
        {

            //Запись в Json объект.
            Cabinets k501 = new Cabinets(501, 1, true, 62, 32, true);
            Cabinets k505 = new Cabinets(505, 11, false, 11, 11, true);
            Cabinets k506 = new Cabinets(506, 11, false, 11, 11, true);
            Cabinets k507 = new Cabinets(507, 0, true, 24, 13, false);
            Cabinets k509 = new Cabinets(509, 1, true, 32, 17, true);
            Cabinets k511 = new Cabinets(511, 0, true, 24, 13, false);
            Cabinets k512 = new Cabinets(512, 0, true, 26, 14, false);

            List<Cabinets> cabinets = new List<Cabinets>();
            cabinets.Add(k501);
            cabinets.Add(k505);
            cabinets.Add(k506);
            cabinets.Add(k507);
            cabinets.Add(k509);
            cabinets.Add(k511);
            cabinets.Add(k512);

            JsonSerializer sr = new JsonSerializer();
            using (StreamWriter file = new StreamWriter("data.json"))
            {
                using (JsonWriter jw = new JsonTextWriter(file))
                {
                    sr.Serialize(jw, cabinets);
                }
            }

            ////Считывание Json объекта.
            //List<Cabinets> sb = new List<Cabinets>();
            //using (StreamReader sr = new StreamReader("data.json"))
            //{
            //    sb = JsonConvert.DeserializeObject<List<Cabinets>>(sr.ReadToEnd());
            //}
            //int n = Convert.ToInt32(Console.ReadLine());
            //foreach (var item in sb)
            //    if (item.Number == n)
            //        Console.WriteLine(item);
        }
    }
}
