namespace Thanh_Hiệp.Models
{
    public class CakeType
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty; // Ví dụ: "Bánh Lạnh Mousse", "Bánh Kem Hoa Quả Tươi"
        public string ImageUrl { get; set; } = string.Empty; // Ảnh đại diện cho loại bánh (tùy chọn)
        public ICollection<Cake> Cakes { get; set; } = new List<Cake>();
    }
}
