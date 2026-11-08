using System;
using System.Collections.Generic;

namespace Quanlysinhvien
{
    class SinhVien
    {
        // Thuộc tính 
        public string hoTen;
        public int maSV;
        public double diemToan;
        public double diemVan;

        // Phương thức
        // Nhập thông tin 1 sinh viên từ bàn phím
        public void Nhap()
        {
            Console.Write("  - Nhập họ và tên: ");
            hoTen = Console.ReadLine();

            Console.Write("  - Nhập mã SV: ");
            maSV = int.Parse(Console.ReadLine());

            Console.Write("  - Nhập điểm Toán: ");
            diemToan = double.Parse(Console.ReadLine());

            Console.Write("  - Nhập điểm Văn: ");
            diemVan = double.Parse(Console.ReadLine());
        }

        // Phương thức tính điểm trung bình
        public double tinhDTB()
        {
            double DTB = (diemToan + diemVan) / 2;
            return DTB;
        }

        // Phương thức hiển thị
        public void hienthi()
        {
            Console.WriteLine($"Họ và tên: " + hoTen);
            Console.WriteLine($"Mã SV: " + maSV);
            Console.WriteLine($"Điểm Toán: " + diemToan);
            Console.WriteLine($"Điểm Văn: " + diemVan);
            Console.WriteLine($"Điểm Trung Bình: " + tinhDTB());
            Console.WriteLine("------------------------------------------");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            List<SinhVien> danhSachSV = new List<SinhVien>();

            Console.Write("Nhập vào số lượng sinh viên bạn muốn quản lý: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("BẮT ĐẦU NHẬP DANH SÁCH SINH VIÊN ");

            // Dùng vòng lặp for để lần lượt nhập thông tin cho từng sinh viên
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"\nNhập thông tin cho sinh viên thứ {i + 1}:");

                //Tạo một đối tượng sinh viên mới
                SinhVien sv = new SinhVien();

                //Gọi hàm nhập dữ liệu cho sinh viên đó
                sv.Nhap();

                //Thêm sinh viên vừa nhập vào danh sách chung
                danhSachSV.Add(sv);
            }

            Console.WriteLine("       DANH SÁCH THÔNG TIN SINH VIÊN       ");
            Console.WriteLine("==========================================");

            // Dùng vòng lặp for để duyệt qua từng sinh viên trong danh sách và in ra màn hình
            for (int i = 0; i < danhSachSV.Count; i++)
            {
                Console.WriteLine($"Sinh viên thứ {i + 1}:");
                danhSachSV[i].hienthi(); // Gọi hàm hiển thị của từng sinh viên
            }

            // Dừng màn hình để xem kết quả
            Console.ReadKey();
        }
    }
}