using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CSVHelperDemo
{
    public class CSVHandler
    {
        public static void ImplementCSVDataHandling()
        {
            string importFilePath = @"D:\GitRepository\Demo_Of_SomeConcepts\CSVHelperDemo\address.csv";
            string exportFilePath = @"D:\GitRepository\Demo_Of_SomeConcepts\CSVHelperDemo\export.csv";
            //reading csv file
            using(var reader=new StreamReader(importFilePath))
            using(var csv=new CsvReader(reader ,CultureInfo.InvariantCulture))
            {
                var records = csv.GetRecords<AddressData>().ToList();
                Console.WriteLine("Read data Successfully from address.csv");
                foreach (AddressData addressData in records)
                {
                    Console.Write("\t" + addressData.firstname);
                    Console.Write("\t" + addressData.lastname);
                    Console.Write("\t" + addressData.gmail);
                    Console.Write("\t" + addressData.city);
                    Console.Write("\t" + addressData.code);
                    Console.WriteLine("\n");
                }
                Console.WriteLine("\n************** Now reading from csv file and write to csv file **************");
                using var writer = new StreamWriter(exportFilePath);
                using var csvExport = new CsvWriter(writer, CultureInfo.InvariantCulture);//using csvhelper to write
                {
                    csvExport.WriteRecords(records);
                }
            }
        }
    }
}
