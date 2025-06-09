namespace Thanh_Hiệp.Models
{
    public class Cake
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty; // Ví dụ: "Mousse Xoài", "Bánh Kem Whipping Ô Long Nhài Nhãn"
        public string Description { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public string ImageUrl { get; set; } = string.Empty;
        public Guid CakeTypeId { get; set; }
        public CakeType? CakeType { get; set; }
        public string? Images { get; set; }
        public string? DetailedDescription { get; set; }
    }
}
