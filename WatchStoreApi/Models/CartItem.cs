using System.Diagnostics;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace WatchStoreApi.Models;

public class CartItem
{
    public int Id { get; set; }
    public int ProductId { get; set; }
    public int Quantity { get; set; }
}