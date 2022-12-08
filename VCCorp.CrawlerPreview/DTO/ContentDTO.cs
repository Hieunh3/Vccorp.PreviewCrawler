using System;

namespace VCCorp.CrawlerPreview.DTO
{
    public class ContentDTO
    {
        public string Id { get; set; }
        public string Subject { get; set; } //tiêu đề bài viết
        public string TotalPoint { get; set; }//Điểm đánh giá
        public string Category { get; set; } // chuyên mục
        public DateTime PostDate { get; set; } // ngày đăng
        public double PostDate_Timestamp { get; set; } //ngày đăng chuyển đổi sang dạng timestamp
        public DateTime CreateDate {get; set; }//ngày bóc dữ liệu
        public double CreateDate_Timestamp { get; set; }//ngày bóc dữ liệu chuyển đổi sang dạng timestamp
        public string Author { get; set; } // tác giả
        public string Summary { get; set; } // tóm tắt
        public string Contents { get; set; } // nội dung bài viết
        public string ImageThumb { get; set; } // hình ảnh, thường tách trong nội dung bài viết,lấy hình đầu tiên
        public string ReferUrl { get; set; } // url bóc tách
        public string Domain { get; set; } //domain trang web

        //table si_demand_post
        public string post_id { get; set; }
        public string platform { get; set; }
        public string link { get; set; }
        public DateTime create_time { get; set; }
        public DateTime update_time { get; set; }
        public DateTime crawled_time { get; set; }
        public int status { get; set; }
        public int totalComment { get; set; }
    }
}
