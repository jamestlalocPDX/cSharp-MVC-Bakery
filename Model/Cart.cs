using System.Collections.Generic;
using Bakery.View;


namespace Bakery.Model
{
  class Cart
  {
    private static List<Bread> breadCart = new List<Bread>(5);
    public static List<Bread> BreadCart
    {
      get { return breadCart; }
      set { breadCart = value; }
    }
    private static List<Pastry> pastryCart = new List<Pastry>(5);
    public static List<Pastry> PastryCart
    {
      get { return pastryCart; }
      set { pastryCart = value; }
    }

    public static double BreadTotal { get; set; }
    public static double PastryTotal { get; set; }


    public static void Menu()
    {

      string input = CartMenu.Print();

      switch (input)
      {
        case "1":
          CartCheckout.Print();
          Cart.Menu();
          break;

        case "2":
          Cart.Menu();
          break;

        case "m":
          break;

        default:
          Cart.Menu();
          break;
      }
    }


    public static double GetBreadTotal(double loafCount)
    {
      double result;
      if (loafCount > 2)
      {
        result = (loafCount - (loafCount / 3)) * 5;
      }
      else
      {
        result = loafCount * 5;
      }

      return result;
    }
    public static double GetPastryTotal(double pastryCount)
    {
      double result;
      if (pastryCount > 2)
      {
        result = (pastryCount - ((pastryCount / 3) / 2)) * 2;
      }
      else
      {
        result = pastryCount * 2;
      }

      return result;
    }



  }

}
