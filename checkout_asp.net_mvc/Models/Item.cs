namespace checkout_asp.net_mvc.Models
{
  public class Item
  {
    public int unitPrice { get; set; }
    public int units { get; set; }
    public int vatPercentage { get; set; }
    public string productCode { get; set; }
    public string deliveryDate { get; set; }

    public Item() { }
  }
}