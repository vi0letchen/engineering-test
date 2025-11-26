using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace GildedRose.Console;

public class Program
{
    public IList<Item> Items = new List<Item>();

    static void Main(string[] args)
    {
        System.Console.WriteLine("OMGHAI!");

        var app = new Program()
                      {
                          Items = new List<Item>
                                      {
                                          new Item {Name = "+5 Dexterity Vest", SellIn = 10, Quality = 20},
                                          new Item {Name = "Aged Brie", SellIn = 2, Quality = 0},
                                          new Item {Name = "Elixir of the Mongoose", SellIn = 5, Quality = 7},
                                          new Item {Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 80},
                                          new Item
                                              {
                                                  Name = "Backstage passes to a TAFKAL80ETC concert",
                                                  SellIn = 15,
                                                  Quality = 20
                                              },
                                          new Item {Name = "Conjured Mana Cake", SellIn = 3, Quality = 6}
                                      }

                      };

        app.UpdateQuality();

        System.Console.ReadKey();
    }

    public void UpdateQuality()
    {
        foreach (var item in Items)
          {     
               if (item.Name != "Sulfuras, Hand of Ragnaros")
               {
                    if (item.Name == "Aged Brie")
                    {   
                        if (item.SellIn < 0)
                         {
                            item.Quality = System.Math.Min(item.Quality + 2, 50);
                         }
                         else
                         {
                            item.Quality = System.Math.Min(item.Quality + 1, 50);
                         }
                    }

                    else if (item.Name == "Backstage passes to a TAFKAL80ETC concert")
                    {
                         if (item.SellIn > 10)
                         {
                              item.Quality = System.Math.Min(item.Quality + 1, 50);
                         }
                         else if (item.SellIn > 5)
                         {
                              item.Quality = System.Math.Min(item.Quality + 2, 50);
                         }
                         else if (item.SellIn > 0)
                         {
                              item.Quality = System.Math.Min(item.Quality + 3, 50);
                         }
                         else
                         {
                              item.Quality = 0;
                         }
                    }
                    else if (item.Name.StartsWith("Conjured"))
                    {
                         if (item.SellIn < 0)
                         {
                              item.Quality = System.Math.Max(item.Quality - 4, 0);
                         }
                         else
                         {
                              item.Quality = System.Math.Max(item.Quality - 2, 0);
                         }
                    }
                    else
                    {
                         if (item.SellIn < 0)
                         {
                              item.Quality = System.Math.Max(item.Quality - 2, 0);
                         }
                         else
                         {
                                item.Quality = System.Math.Max(item.Quality - 1, 0);
                         }
                    }
                    item.SellIn -= 1;
               }
          }
    }
}

public class Item
{
    public string Name { get; set; } = "";

    public int SellIn { get; set; }

    public int Quality { get; set; }
}
