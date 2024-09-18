using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

public class ShoppingList
{
  private List<Item> items;
  public ShoppingList()
  {
    items = new List<Item>();
  }
  // TODO: Implement the AddItem function
  public void AddItem(string itemName, double price, int quantity)
  {
    Item newItem = new()
    {
      ItemName = itemName,
      Price = price,
      Quantity = quantity
    };
    items.Add(newItem);
  }

  // TODO: Implement the RemoveItem function
  public void RemoveItem(string itemName)
  {
    var foundItem = items.Find(x => x.ItemName == itemName);
    if (foundItem.Quantity > 1)
    {
      foundItem.Quantity--;
    }
    else
    {
      items.Remove(foundItem);
    }
  }

  // TODO: Implement the GetCount function
  public int GetCount()
  {
    int count = 0;
    foreach (var x in items)
    {
      count += x.Quantity;
    }
    return count;
  }

  public void PrintList()
  {
    foreach (var item in items)
    {
      Console.WriteLine($"Item: {item.ItemName,10}, Price: {item.Price:C}, Quantity: {item.Quantity}");
    }
  }
}
