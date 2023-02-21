using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Dictionary<int, string> koolid = new Dictionary<int, string>();

        koolid.Add(1, "Tallinna Tööstushariduskeskus");
        koolid.Add(2, "Kadrioru Saksagümnaasium");
        koolid.Add(3, "Järveküla kool");
        

        foreach (KeyValuePair<int, string> kool in koolid)
        {
            Console.WriteLine("Kooli number {0} nimi on {1}.", kool.Key, kool.Value);
        }
        
        Console.ReadLine();

    }
}
