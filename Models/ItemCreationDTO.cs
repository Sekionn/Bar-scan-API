using Bar_scan_API.Models;

namespace bar_scan_api.Models;

public class ItemCreationDTO
{
    public string? Barcode { get; set; }
    public int ShelfOfOrigin { get; init; }
    public int AmountCounted { get; init; }

    public Item CreateItem()
    {
        return new Item
        {
            Id = Guid.NewGuid(),
            Barcode = Barcode,
            ShelfOfOrigin = ShelfOfOrigin,
            AmountCounted = AmountCounted,
            Date = DateTime.UtcNow
        };
    }
}