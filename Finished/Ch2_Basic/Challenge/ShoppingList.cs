
using System;
using System.Collections.Generic;
public class ShoppingList
{
  List<ShoppingItem> shoppingList = new List<ShoppingItem>(20);

  public void AddItem(string ItemName, double Price, int Quantity)
  {
    shoppingList.Add(new ShoppingItem() { itemName = ItemName, price = Price, quantity = Quantity });
  }

  public void RemoveItem(string ItemName)
  {
    ShoppingItem FoundItem = null;
    foreach (ShoppingItem i in shoppingList)
    {
      if (i.itemName == ItemName)
      {
        FoundItem = i;
        break;
      }
    }
    if (FoundItem != null)
    {
      if (FoundItem.quantity > 1)
      {
        FoundItem.quantity--;
      }
      else shoppingList.Remove(FoundItem);
    }
  }

  public int GetCount()
  {
    int count = 0;
    foreach (ShoppingItem i in shoppingList)
    {
      count += i.quantity;
    }
    return count;
  }

  public void PrintList()
  {
    foreach (var item in shoppingList)
    {
      Console.WriteLine($"Item: {item.itemName,10}, Price: {item.price:C}, Quantity: {item.quantity}");
    }
  }
}