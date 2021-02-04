using System;
using System.Net;
using System.IO;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


namespace TMS.Net07.Homework._3ConvertFromUsdByn
{
    class Program
    {
        static void Main(string[] args)
        {
           
            WebClient client = new WebClient();

           Console.OutputEncoding = System.Text.Encoding.Unicode;



            string url = "https://www.nbrb.by/services/xmlexrates.aspx";
            var xml = client.DownloadString(url);
            XDocument xdoc = XDocument.Parse(xml);
            var el = xdoc.Element("DailyExRates").Elements("Currency");

            string currency;
            double dollar = Convert.ToDouble(el.Where(x => x.Attribute("Id").Value == "145").Select(x => x.Element("Rate").Value).FirstOrDefault(), CultureInfo.InvariantCulture);
            double eur = Convert.ToDouble(el.Where(x => x.Attribute("Id").Value == "292").Select(x => x.Element("Rate").Value).FirstOrDefault(), CultureInfo.InvariantCulture);
            double rub = Convert.ToDouble(el.Where(x => x.Attribute("Id").Value == "298").Select(x => x.Element("Rate").Value).FirstOrDefault(), CultureInfo.InvariantCulture);

            Console.WriteLine("Курс USD " + dollar);
            Console.WriteLine("Курс EUR " + eur);
            Console.WriteLine("Курс RUB " + rub / 100);


            do
            {


                Console.WriteLine("Выберите валюту или EXIT для выхода : USD/EUR/BYN/RUB");
                currency = Console.ReadLine();

                if(currency.ToUpper() == "EXIT") { break; }
                

                Console.WriteLine("Введите сумму : ");
                decimal value = Convert.ToDecimal(Console.ReadLine());
                var cultureinfo = CultureInfo.GetCultureInfo("fr-FR");



                switch (currency.ToUpper())
                {
                    case "USD":
                        Console.WriteLine("BYN Br " + value * (decimal)dollar);
                        Console.WriteLine("EUR " + "\u20AC " + (value * (decimal)dollar / (decimal)eur).ToString("F4"));
                        Console.WriteLine("RUB " + "\u20BD " + (value * (decimal)dollar / (decimal)rub * 100).ToString("F4"));
                        break;
                    case "EUR":
                        Console.WriteLine("BYN Br " + value * (decimal)eur);
                        Console.WriteLine("USD " + (value * (decimal)eur / (decimal)dollar).ToString("C4", new CultureInfo("en-US")));
                        Console.WriteLine("RUB " + "\u20BD " + (value * (decimal)eur / (decimal)rub * 100).ToString("F4"));

                        break;
                    case "BYN":
                        Console.WriteLine("USD " + (value / (decimal)dollar).ToString("C4", new CultureInfo("en-US")));
                        Console.WriteLine("EUR " + "\u20AC " + (value / (decimal)eur).ToString("F4"));
                        Console.WriteLine("RUB " + "\u20BD " + (value / (decimal)rub * 100).ToString("F4"));
                        break;
                    case "RUB":
                        Console.WriteLine("BYN Br " + value * (decimal)rub / 100);
                        Console.WriteLine("USD " + (value * (decimal)rub / (decimal)dollar / 100).ToString("C4", new CultureInfo("en-US")));
                        Console.WriteLine("EUR " + "\u20AC " + (value * (decimal)rub / (decimal)eur / 100).ToString("F4"));
                        break;
                    default:
                        Console.WriteLine("Не верная валюта");
                        break;
                }
            }
            while (true);

            
        }
    }
}
