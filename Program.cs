using System;

namespace CurrencyConvertor
{
  class Program
  {
    static void Main(string[] args)
    {
     
      
      Console.WriteLine("Введите сумму");
      
      string SummaConv = Console.ReadLine();
     
      Console.WriteLine("Валюту, из которой будет произведена конвертация");
     
      Console.WriteLine("Пример :долларов, евро");

      string Valuta = Console.ReadLine();


      double Itog = double.Parse(SummaConv);


      switch (Valuta)
      {
        case "доллары":
          Itog = Itog * 70;
          break;

        case "евро":
          Itog = Itog * 80;
          break;

      }

      Console.WriteLine(Itog);






          

      Console.ReadKey();
    }
  }
}
