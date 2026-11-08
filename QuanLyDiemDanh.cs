using System;
using System.Collections.Generic;

namespace QuanLyDiemDanh
{
    class DiemDanh
    {
        // thuọc tính 
        public string ngayDiemDanh;
        public List<string> danhSachHocSinh;

        public DiemDanh(string ngay)
        {
            // Gán ngày điểm danh bằng giá trị được truyền vào từ bên ngoài
            ngayDiemDanh = ngay;

            // Khởi tạo sẵn một danh sách học sinh trống để chuẩn bị thêm dữ liệu
            danhSachHocSinh = new List<string>();
        }

        //phương thức 
        public void themHocSinh(string hocSinh)
        {
            //dưa tên học sinh mới vào danh sách
            danhSachHocSinh.Add(hocSinh);

            Console.WriteLine("Da them hoc sinh: " +  hocSinh);
        }

        public void hienthi()
        {
            Console.WriteLine("Danh Sánh Học Sin Điểm Danh ");
            for (int i = 0; i < danhSachHocSinh.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {danhSachHocSinh[i]}");
            }

        }

        //Phương thức 1:
        public List<string> kiemTraVangMat(List<string> danhSachTatCa)
        {
            // Tạo một danh sách mới để chứa tên các học sinh vắng mặt
            List<string> danhSachVang = new List<string>();

            // Dùng vòng lặp for để duyệt qua từng học sinh trong danh sách tất cả học sinh
            for (int i = 0; i < danhSachTatCa.Count; i++)
            {
                string hocSinh = danhSachTatCa[i]; // Lấy tên học sinh thứ i ra để kiểm tra

                // Kiểm tra xem học sinh này CÓ NẰM TRONG danh sách tham gia điểm danh hay không
                // Nếu KHÔNG CÓ thì tức là vắng mặt
                if (!danhSachHocSinh.Contains(hocSinh))
                {
                    danhSachVang.Add(hocSinh); // Thêm tên học sinh đó vào danh sách vắng
                }
            }

            // Trả về danh sách những học sinh vắng mặt sau khi đã lọc xong
            return danhSachVang;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // Tạo một đối tượng DiemDanh cho ngày "07/11/2026"
            DiemDanh buoiDiemDanh = new DiemDanh("07/11/2026");

            // Thêm các học sinh có mặt
            buoiDiemDanh.themHocSinh("Nguyễn Hải Đông");
            buoiDiemDanh.themHocSinh("Trần Văn A");

            // Hiển thị danh sách tham gia
            buoiDiemDanh.hienthi();

            // Giả sử danh sách toàn bộ lớp có 4 học sinh
            List<string> caLop = new List<string>() { "Nguyễn Hải Đông", "Trần Văn A", "Lê Thị B", "Phạm Văn C" };

            // Gọi phương thức kiểm tra vắng mặt
            List<string> vangMặt = buoiDiemDanh.kiemTraVangMat(caLop);

            // In ra danh sách học sinh vắng mặt
            Console.WriteLine("\n--- Danh sách học sinh vắng mặt ---");
            for (int i = 0; i < vangMặt.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {vangMặt[i]}");
            }

            Console.ReadKey();
        }
    }
}


