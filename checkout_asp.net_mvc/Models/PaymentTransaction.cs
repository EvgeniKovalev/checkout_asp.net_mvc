using System.Collections.Generic;

namespace checkout_asp.net_mvc.Models
{
  public class PaymentTransaction
  {
    public string transactionId { get; set; }
    public string href { get; set; }
    public List<PaymentProvider> providers { get; set; } = new List<PaymentProvider>();

    public PaymentTransaction() { }
  }
}