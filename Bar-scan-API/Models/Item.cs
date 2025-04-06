namespace Bar_scan_API.Models
{
    public class Item
    {
        public Guid Id { get; init; }
        public string? Barcode { get; set; }
        public int ShelfOfOrigin { get; init; }
        public int AmountCounted { get; init; }
        public DateTime? Date { get; set; }
    }
}