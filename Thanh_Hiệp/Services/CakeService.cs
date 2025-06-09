using System;

using System.Collections.Generic;

using System.Linq;

using System.Threading.Tasks;

using Thanh_Hiệp.Models;

namespace Thanh_Hiệp.Services

{

    public class CakeService

    {

        private readonly List<CakeType> _cakeTypes;

        private readonly List<Cake> _cakes;



        public CakeService()
        {
            // --- DỮ LIỆU MẪU: CÁC LOẠI BÁNH ---
            _cakeTypes = new List<CakeType>
    {
        new CakeType { Id = Guid.NewGuid(), Name = "Bánh Lạnh Mousse" },
        new CakeType { Id = Guid.NewGuid(), Name = "Bánh Kem Long Nhãn" },
        new CakeType { Id = Guid.NewGuid(), Name = "Bánh Kem Hoa Quả Tươi" },
        new CakeType { Id = Guid.NewGuid(), Name = "Bánh Bông Lan Trứng Muối" },
        new CakeType { Id = Guid.NewGuid(), Name = "Bánh Kem Sự Kiện" },
        new CakeType { Id = Guid.NewGuid(), Name = "Bánh Kem Trẻ Em" },
        new CakeType { Id = Guid.NewGuid(), Name = "Bánh Kem Hàn Quốc" }
    };

            // --- DỮ LIỆU MẪU: CÁC LOẠI BÁNH CỤ THỂ (ĐÃ SẮP XẾP GỌN GÀNG) ---
            _cakes = new List<Cake>
    {
        // ========== [0] Bánh Lạnh Mousse ==========
        new Cake {
            Id = Guid.NewGuid(), Name = "Mousse Xoài", Description = "Mousse xoài thơm ngon", Price = 75000m, ImageUrl = "/images/bánh xoài.jpg", CakeTypeId = _cakeTypes[0].Id,
            DetailedDescription = "Bánh mousse mang đậm hương vị xoài ngọt mát dễ chịu, kem tươi whipping cream kết hợp cùng sữa chua cốt vani, trang trí thêm xoài trên mặt bánh để thêm đậm vị cùng socola."
        },
        new Cake {
            Id = Guid.NewGuid(), Name = "Mousse Chanh Leo", Description = "Mousse chanh leo chua ngọt", Price = 75000m, ImageUrl = "/images/chanh leo.jpg", CakeTypeId = _cakeTypes[0].Id,
            DetailedDescription = "Mousse mát lạnh sử dụng chanh leo tươi bỏ hạt và kem tươi whipping cream cùng cốt bánh vani, trang trí socola."
        },
        new Cake {
            Id = Guid.NewGuid(), Name = "Bánh Tiramisu Cacao", Description = "Bánh Tiramisu vị cacao đậm đà", Price = 90000m, ImageUrl = "/images/Bánh tiramisu cacao.jpg", CakeTypeId = _cakeTypes[0].Id,
            DetailedDescription = "Bánh tiramisu sử dụng cốt bánh bông lan cà phê và bánh lady finger chuẩn vị, kết hợp hài hòa cùng rượu Rhum, café, pha thêm vị béo của kem tươi, phô mai Mascarpone Ý cùng lòng đỏ trứng. Tạo nên vị thanh ngọt nhẹ nhàng, hơi hơi nồng hương rượu rất hấp dẫn, bên trên phủ lớp kem topping vị cà phê cốt dừa và bột cacao nguyên chất."
        },
        new Cake {
            Id = Guid.NewGuid(), Name = "Bánh Tiramisu Matcha", Description = "Bánh Tiramisu vị matcha thơm mát", Price = 90000m, ImageUrl = "/images/Bánh Tiramisu Matcha.jpg", CakeTypeId = _cakeTypes[0].Id,
            DetailedDescription = "Bánh tiramisu sử dụng cốt bánh bông lan cà phê và bánh lady finger chuẩn vị, kết hợp hài hòa cùng rượu Rhum, café, pha thêm vị béo của kem tươi, phô mai Mascarpone Ý cùng lòng đỏ trứng. Tạo nên vị thanh ngọt nhẹ nhàng, hơi hơi nồng hương rượu rất hấp dẫn, bên trên phủ lớp kem topping vị trà xanh và bột matcha."
        },
        new Cake {
            Id = Guid.NewGuid(), Name = "Mousse Sữa Chua Vải", Description = "Mousse sữa chua vị vải", Price = 80000m, ImageUrl = "/images/Mousse sữa chua vải.jpg", CakeTypeId = _cakeTypes[0].Id,
            DetailedDescription = "Bánh mousse sữa chua vải kết hợp độc đáo của cốt bánh ô long nhài và lớp mousse sữa chua vải ngậy béo từ kem whipping, trang trí những trái vải thiều tươi, việt quất và vòng ring socola."
        },
        // --- BÁNH MỚI ---
        new Cake {
            Id = Guid.NewGuid(), Name = "Bánh Tart Chanh Pháp", Description = "Vị chanh chua thanh, đế bánh giòn", Price = 180000m, CakeTypeId = _cakeTypes[0].Id,
            ImageUrl = "/images/Bánh Tart Chanh Pháp.jpg",
            DetailedDescription = "Lấy cảm hứng từ món bánh tráng miệng kinh điển của Pháp, Bánh Tart Chanh có đế bánh giòn tan, nhân kem chanh vàng óng với vị chua thanh mát tự nhiên, được cân bằng bởi lớp kem trứng Meringue Ý ngọt dịu, xém nhẹ bên trên."
        },

        // ========== [1] Bánh Kem Long Nhãn ==========
        new Cake {
            Id = Guid.NewGuid(), Name = "Bánh Kem Whipping Ô Long Nhài Nhãn", Description = "Bánh kem vị ô long nhài kết hợp với nhãn tươi", Price = 280000m, ImageUrl = "/images/Bánh Kem Whipping Ô Long Nhài Nhãn.jpg", CakeTypeId = _cakeTypes[1].Id,
            DetailedDescription = "Cốt bánh ô lòng nhài kết hợp cùng kem whipping ô long nhài thơm ngậy, trang trí những trái nhãn tươi căng mọng, hoa nhài và lá vàng."
        },
        // --- BÁNH MỚI ---
        new Cake {
            Id = Guid.NewGuid(), Name = "Bánh Kem olong Nhãn socola ", Description = "Hương vị socola đậm đà", Price = 350000m, CakeTypeId = _cakeTypes[1].Id, // Sửa lại loại bánh
            ImageUrl = "/images/Bánh Kem olong Nhãn socola.jpg",
            DetailedDescription = "Dành cho những ai yêu thích hương vị socola nguyên bản. Cốt bánh socola ẩm mềm, phủ đầy lớp kem socola được làm từ socola Bỉ 70% cao cấp, mang đến vị đắng nhẹ tinh tế và hương thơm nồng nàn khó cưỡng."
        },
        
        // ========== [2] Bánh Kem Hoa Quả Tươi ==========
        new Cake {
            Id = Guid.NewGuid(), Name = "Bánh Kem Hoa Quả Nhiệt Đới", Description = "Bánh kem trang trí hoa quả nhiệt đới tươi ngon", Price = 300000m, ImageUrl = "/images/Bánh kem hoa quả nhiệt đới.jpg", CakeTypeId = _cakeTypes[2].Id,
            DetailedDescription = "Cốt vani, nhân mứt xoài kèm xoài dứa tươi. Lớp phủ kem sữa chua, trang trí với nho tươi, việt quất, xoài cắt và lá hương thảo."
        },
        new Cake {
            Id = Guid.NewGuid(), Name = "Bánh Kem Bắp Hoa Quả Tươi", Description = "Bánh kem bắp kết hợp hoa quả tươi", Price = 270000m, ImageUrl = "/images/Bánh kem bắp hoa quả tươi.jpg", CakeTypeId = _cakeTypes[2].Id,
            DetailedDescription = "Bánh kem cốt vani, nhân bắp với những hạt ngô ngọt kết hợp cùng với kem vị bắp phô mai từ sữa bắp xay nhuyễn cùng bơ và cream cheese Úc, tạo độ thơm ngon, đậm đà cho lớp kem. Trang trí ngô ngọt và hạnh nhân lát nướng giòn ở chân và mặt bánh."
        },
        // --- BÁNH MỚI ---
        new Cake {
            Id = Guid.NewGuid(), Name = "Bánh Kem Dừa và Chanh Dây", Description = "Hương vị nhiệt đới độc đáo", Price = 310000m, CakeTypeId = _cakeTypes[2].Id,
            ImageUrl = "/images/Bánh Kem Dừa và Chanh Dây.jpg",
            DetailedDescription = "Một sự kết hợp nhiệt đới đầy bất ngờ. Cốt bánh dừa thơm lừng, ẩm mịn, kết hợp với lớp kem chanh dây chua thanh mát rượi. Bánh được trang trí bằng vụn dừa nướng và sốt chanh dây óng ả."
        },

        // ========== [3] Bánh Bông Lan Trứng Muối ==========
        new Cake {
            Id = Guid.NewGuid(), Name = "Bánh Bông Lan Trứng Muối Sốt Phô Mai", Description = "Bánh bông lan trứng muối sốt phô mai béo ngậy", Price = 180000m, ImageUrl = "/images/Bánh bông lan trứng muối sốt phô mai.jpg", CakeTypeId = _cakeTypes[3].Id,
            DetailedDescription = "Cốt vani, sốt bơ trứng. Trang trí thêm chà bông heo đặc biệt, sốt phô mai, trứng muối và chà bông gà cay."
        },
        new Cake {
            Id = Guid.NewGuid(), Name = "Bánh Bông Lan Trứng Muối Việt Quất", Description = "Bánh bông lan trứng muối việt quất", Price = 200000m, ImageUrl = "/images/Bánh bông lan trứng muối việt quất.jpg", CakeTypeId = _cakeTypes[3].Id,
            DetailedDescription = "Cốt bông lan mềm mịn kết hợp sốt bơ trứng và sốt phô mai béo ngậy, xen giữa chà bông heo và trứng muối ở mỗi lớp bánh, trang trí thêm việt quất tươi."
        },
        new Cake {
            Id = Guid.NewGuid(), Name = "Bông Lan Trứng Muối Hoa Quả Tươi", Description = "Bánh bông lan trứng muối hoa quả tươi", Price = 220000m, ImageUrl = "/images/Bông Lan Trứng Muối Hoa Quả Tươi.jpg", CakeTypeId = _cakeTypes[3].Id,
            DetailedDescription = "Bánh bông lan trứng muối cốt bánh vani, ở giữa lớp cốt bánh là sốt bơ trứng và sốt phô mai thơm béo, trang trí các loại hoa quả tươi: dâu, nho, việt quất cùng chà bông và trứng muối."
        },
        new Cake {
            Id = Guid.NewGuid(), Name = "Bánh Bông Lan Trứng Muối Chữ Nhật Cắt Miếng", Description = "Bánh bông lan trứng muối chữ nhật cắt miếng", Price = 250000m, ImageUrl = "/images/Bánh Bông Lan Trứng Muối Chữ Nhật Cắt Miếng.jpg", CakeTypeId = _cakeTypes[3].Id,
            DetailedDescription = "Cốt bánh vani, kết hợp cùng sốt phô mai và sốt bơ trứng thơm ngậy, bên trên trang trí ruốc gà cay, chà bông heo và trứng muối, viết lịch theo yêu cầu."
        },

        // ========== [4] Bánh Kem Sự Kiện ==========
        new Cake {
            Id = Guid.NewGuid(), Name = "Bánh Kem Chữ Nhật Vẽ Logo", Description = "Bánh kem chữ nhật vẽ logo theo yêu cầu", Price = 350000m, ImageUrl = "/images/Bánh Kem Chữ Nhật Vẽ Logo.jpg", CakeTypeId = _cakeTypes[4].Id,
            DetailedDescription = "Kem tươi vị sữa chua, mứt việt quất, cốt vani. Trang trí thêm hoa quả tươi gồm nho, xoài, dâu tây, việt quất. Bánh chữ nhật nguyên khối chưa cắt miếng, chữ viết tùy chọn."
        },
        new Cake {
            Id = Guid.NewGuid(), Name = "Bánh Kem Cưới Hai Tầng", Description = "Thiết kế thanh lịch cho ngày trọng đại", Price = 800000m, CakeTypeId = _cakeTypes[4].Id,
            ImageUrl = "/images/Bánh Kem Cưới Hai Tầng.jpg",
            DetailedDescription = "Một thiết kế trang nhã và tinh tế cho ngày vui của bạn. Bánh cưới hai tầng với cốt bánh vani và socola xen kẽ, phủ kem tươi trắng muốt và trang trí bằng hoa tươi hoặc hoa kem theo yêu cầu. Vui lòng liên hệ để được tư vấn chi tiết."
        },
        new Cake {
            Id = Guid.NewGuid(), Name = "Bánh Kem Trái Tim Tình Yêu", Description = "Dành cho ngày lễ tình nhân, kỷ niệm", Price = 450000m, ImageUrl = "/images/Bánh Kem Trái Tim Tình Yêu.jpg", CakeTypeId = _cakeTypes[4].Id,
            DetailedDescription = "Thể hiện tình yêu của bạn bằng một chiếc bánh kem hình trái tim ngọt ngào. Cốt bánh red velvet đỏ thắm xen kẽ lớp kem phô mai mịn màng, được trang trí bằng những bông hồng kem tinh xảo và dâu tây tươi mọng. Một món quà hoàn hảo cho ngày Valentine, kỷ niệm ngày cưới hoặc bất kỳ dịp đặc biệt nào của hai bạn."
        },
        // --- BÁNH MỚI - SỰ KIỆN ---
        new Cake {
            Id = Guid.NewGuid(), Name = "Bánh Kem Khai Trương Thịnh Vượng", Description = "Sang trọng cho ngày khai trương, sự kiện", Price = 750000m, CakeTypeId = _cakeTypes[4].Id,
            ImageUrl = "/images/Bánh Kem Khai Trương Thịnh Vượng.jpg",
            DetailedDescription = "Đánh dấu một khởi đầu mới đầy may mắn với chiếc bánh kem khai trương sang trọng. Bánh có thể được thiết kế hai tầng với tông màu vàng gold chủ đạo, trang trí bằng các biểu tượng tài lộc, hoa tươi và có thể thêm logo của công ty. Đây chắc chắn sẽ là điểm nhấn ấn tượng trong ngày trọng đại của doanh nghiệp."
        },
        // --- BÁNH MỚI - SỰ KIỆN ---
        new Cake {
            Id = Guid.NewGuid(), Name = "Bánh Kem Kéo Ra Tiền", Description = "Món quà bất ngờ và độc đáo", Price = 550000m, CakeTypeId = _cakeTypes[4].Id,
            ImageUrl = "/images/Bánh Kem Kéo Ra Tiền.jpg",
            DetailedDescription = "Tạo nên khoảnh khắc bất ngờ và đầy tiếng cười cho chủ nhân bữa tiệc! Chiếc bánh kem độc đáo này có một cơ chế đặc biệt, cho phép bạn kéo ra một dải tiền thật từ bên trong bánh. Tiền được đặt trong một lớp bọc nilon hợp vệ sinh, đảm bảo an toàn. Một món quà vừa ý nghĩa, vừa vui nhộn cho mọi lứa tuổi."
        },
        // --- BÁNH MỚI ---
        new Cake {
            Id = Guid.NewGuid(), Name = "Bánh Kem olong Nhãn socola ", Description = "Hương vị socola đậm đà", Price = 350000m, CakeTypeId = _cakeTypes[4].Id, // Sửa lại loại bánh
            ImageUrl = "/images/Bánh Kem olong Nhãn socola.jpg",
            DetailedDescription = "Dành cho những ai yêu thích hương vị socola nguyên bản. Cốt bánh socola ẩm mềm, phủ đầy lớp kem socola được làm từ socola Bỉ 70% cao cấp, mang đến vị đắng nhẹ tinh tế và hương thơm nồng nàn khó cưỡng."
        },
        // --- BÁNH MỚI ---
        new Cake {
            Id = Guid.NewGuid(), Name = "Bánh Kem Cưới Long Nhãn", Description = "Thiết kế thanh lịch cho ngày trọng đại", Price = 800000m, CakeTypeId = _cakeTypes[4].Id, // Sửa lại loại bánh
            ImageUrl = "/images/bánh kem cưới long nhãn.jpg",
            DetailedDescription = "Một thiết kế trang nhã và tinh tế cho ngày vui của bạn. Bánh cưới hai tầng với cốt bánh vani và socola xen kẽ, phủ kem tươi trắng muốt và trang trí bằng hoa tươi hoặc hoa kem theo yêu cầu. Vui lòng liên hệ để được tư vấn chi tiết."
        },

        // ========== [5] Bánh Kem Trẻ Em ==========
        new Cake {
            Id = Guid.NewGuid(), Name = "Bánh Kem Gà Bông", Description = "Bánh kem hình gà bông ngộ nghĩnh", Price = 280000m, ImageUrl = "/images/Bánh kem gà bông.jpg", CakeTypeId = _cakeTypes[5].Id,
            DetailedDescription = "Bánh kem cốt vani, mứt xoài cùng nhân xoài dứa kết hợp với kem vị xoài thơm dịu, tạo hình chú gà bông màu vàng với mũ sinh nhật mini ngộ nghĩnh."
        },
        new Cake {
            Id = Guid.NewGuid(), Name = "Bánh Kem Heo Hồng", Description = "Bánh kem hình heo hồng đáng yêu", Price = 280000m, ImageUrl = "/images/Bánh kem heo hồng.jpg", CakeTypeId = _cakeTypes[5].Id,
            DetailedDescription = "Bánh kem cốt vani, mứt dâu tây chua dịu, trang trí tạo hình heo con màu hồng cùng với chiếc mũ sinh nhật mini xinh xắn vô cùng ngộ nghĩnh, đáng yêu."
        },
        new Cake {
            Id = Guid.NewGuid(), Name = "Bánh Kem Police Car", Description = "Bánh kem hình xe cảnh sát", Price = 300000m, ImageUrl = "/images/Bánh kem police car.jpg", CakeTypeId = _cakeTypes[5].Id,
            DetailedDescription = "Bánh kem cốt vani, mứt việt quất chua ngọt dịu nhẹ, trang trí tạo hình xe cảnh sát, sở thích của các bé trai. Lưu ý bánh kem có pha màu đậm bên ngoài bằng màu thực phẩm để trang trí, khi ăn nên gạt bỏ phần kem để tránh bị đắng."
        },
        new Cake {
            Id = Guid.NewGuid(), Name = "Bánh Kem Baby Shark", Description = "Bánh kem hình Baby Shark", Price = 300000m, ImageUrl = "/images/Bánh kem baby shark.jpg", CakeTypeId = _cakeTypes[5].Id,
            DetailedDescription = "Bánh kem vani, mứt xoài và nhân xoài dứa tươi, trang trí chủ đề đại dương và thẻ cắm gia đình cá mập Baby Shark."
        },
        // --- BÁNH MỚI ---
        new Cake {
            Id = Guid.NewGuid(), Name = "Bánh Kem Doremon", Description = "Tạo hình Doremon đáng yêu", Price = 300000m, CakeTypeId = _cakeTypes[5].Id,
            ImageUrl = "/images/Bánh Kem Doremon.jpg",
            DetailedDescription = "Chiếc bánh dành riêng cho các fan của chú mèo máy thông minh. Bánh kem cốt vani mềm mại, nhân mứt dâu tây chua ngọt, được tạo hình đầu chú mèo Doremon xanh dương ngộ nghĩnh, chắc chắn sẽ là điểm nhấn cho bữa tiệc sinh nhật của bé."
        },

        // ========== [6] Bánh Kem Hàn Quốc ==========
        new Cake {
            Id = Guid.NewGuid(), Name = "Bánh Kem Galaxy Blue", Description = "Bánh kem trang trí galaxy màu xanh", Price = 320000m, ImageUrl = "/images/Bánh kem galaxy blue.jpg", CakeTypeId = _cakeTypes[6].Id,
            DetailedDescription = "Bánh kem tươi cốt vani, xen giữa các lớp bánh là mứt việt quất, trang trí phong cách Hàn Quốc."
        },
        new Cake {
            Id = Guid.NewGuid(), Name = "Bánh Kem Cute Bow", Description = "Bánh kem trang trí nơ xinh xắn", Price = 300000m, ImageUrl = "/images/Bánh kem cute bow.jpg", CakeTypeId = _cakeTypes[6].Id,
            DetailedDescription = "Bánh kem cốt vani, mứt dâu, kem trắng, trang trí nơ cùng họa tiết tim và kẹo bi đường."
        },
        new Cake {
            Id = Guid.NewGuid(), Name = "Bánh Kem Nến Xoắn Viền Ren", Description = "Bánh kem nến xoắn viền ren", Price = 350000m, ImageUrl = "/images/ánh Kem Nến Xoắn Viền Renl.jpg", CakeTypeId = _cakeTypes[6].Id,
            DetailedDescription = "Bánh kem cốt vani, mứt việt quất, kem trắng, trang trí những đường gợn sóng cùng chữ 'happy birthday' ở thân bánh, cùng nến xoắn dài và kẹo bi đường trang trí."
        },
        new Cake {
            Id = Guid.NewGuid(), Name = "Bánh Red Velvet", Description = "Cốt bánh đỏ nhung ẩm mịn", Price = 320000m, ImageUrl = "/images/Bánh Red Velvet.jpg", CakeTypeId = _cakeTypes[6].Id,
            DetailedDescription = "Bánh Red Velvet kinh điển với cốt bánh màu đỏ nhung đặc trưng, ẩm, mềm và nhẹ như mây. Xen giữa các lớp bánh là lớp kem phô mai (cream cheese frosting) béo ngậy, chua nhẹ, cân bằng hoàn hảo vị ngọt của bánh."
        },
        // --- BÁNH MỚI ---
        new Cake {
            Id = Guid.NewGuid(), Name = "Bánh Kem Minimalist Hàn Quốc", Description = "Phong cách tối giản, tinh tế", Price = 290000m, CakeTypeId = _cakeTypes[6].Id,
            ImageUrl = "/images/Bánh Kem Minimalist Hàn Quốc.jpg",
            DetailedDescription = "Xu hướng bánh kem tối giản từ Hàn Quốc. Bánh được phủ một lớp kem mịn màng với màu sắc pastel trang nhã, trang trí bằng một vài chi tiết nhỏ hoặc một dòng chữ viết tay tinh tế. Đơn giản nhưng không hề đơn điệu."
        }
    };

            // Liên kết bánh với loại bánh
            foreach (var cake in _cakes)
            {
                cake.CakeType = _cakeTypes.FirstOrDefault(ct => ct.Id == cake.CakeTypeId);
            }
            foreach (var cakeType in _cakeTypes)
            {
                cakeType.Cakes = _cakes.Where(c => c.CakeTypeId == cakeType.Id).ToList();
            }
        }

        public Task<List<Cake>> GetCakesAsync()

        {

            return Task.FromResult(_cakes.ToList());

        }



        public Task<Cake?> GetCakeByIdAsync(Guid id)

        {

            return Task.FromResult(_cakes.SingleOrDefault(c => c.Id == id));

        }



        public Task<List<CakeType>> GetCakeTypesAsync()

        {

            return Task.FromResult(_cakeTypes.ToList());

        }

        public async Task<List<Cake>> GetAllCakesAsync()

        {



            return await Task.FromResult(_cakes); // _cakes là danh sách bánh có sẵn

        }



    }

}