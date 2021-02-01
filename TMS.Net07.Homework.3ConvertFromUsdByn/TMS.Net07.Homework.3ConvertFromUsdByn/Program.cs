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

            string url = "https://www.nbrb.by/services/xmlexrates.aspx";
            var xml = client.DownloadString(url);

            XDocument xdoc = XDocument.Parse(xml);

            var el = xdoc.Element("DailyExRates").Elements("Currency");

            double dollar = Convert.ToDouble(el.Where(x => x.Attribute("Id").Value == "145").Select(x => x.Element("Rate").Value).FirstOrDefault(), CultureInfo.InvariantCulture);
            double eur = Convert.ToDouble(el.Where(x => x.Attribute("Id").Value == "292").Select(x => x.Element("Rate").Value).FirstOrDefault(), CultureInfo.InvariantCulture);
            double rub = Convert.ToDouble(el.Where(x => x.Attribute("Id").Value == "298").Select(x => x.Element("Rate").Value).FirstOrDefault(), CultureInfo.InvariantCulture);

            Console.WriteLine("Курс USD " + dollar);
            Console.WriteLine("Курс EUR " + eur);
            Console.WriteLine("Курс RUB " + rub / 100);


            Console.WriteLine("Выберите валюту : USD/EUR/BYN/RUB");
            string currency = Console.ReadLine();

            Console.WriteLine("ВВедите сумму : ");
            decimal value = Convert.ToDecimal(Console.ReadLine());


            switch (currency.ToUpper())
            {
                case "USD":
                    Console.WriteLine("BYN" + value *(decimal)dollar);
                    break;
                case "EUR":
                    Console.WriteLine("BYN " + value * (decimal)eur);
                    break;
                case "BYN":
                    Console.WriteLine("USD " + (value / (decimal)dollar).ToString("C4", new CultureInfo("en-US")));
                    Console.WriteLine("EUR " + (value / (decimal)eur).ToString("C4", new CultureInfo("fr-FR")));
                    Console.WriteLine("RUB " + (value / (decimal)rub * 100).ToString("C4", new CultureInfo("ru-RU")));
                    break;
                case "RUB":
                    Console.WriteLine("BYN" + value * (decimal)rub);
                    break;
                default:
                    Console.WriteLine("Не верная валюта");
                    break;
            }

            Console.ReadKey();
        }
    }
}
