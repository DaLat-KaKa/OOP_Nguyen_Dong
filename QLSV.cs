using System;

namespace Quanlysinhvien
{
    class SinhVien
    {
        //thuoc tinh:
        public string hoTen;
        public int maSV;
        public double diemToan;
        public double diemVan;

        //phuong thuc

        public SinhVien(string hoTen, int maSV, double diemToan, double diemVan)
        {
            this.hoTen = hoTen;
            this.maSV = maSV;
            this.diemToan = diemToan;
            this.diemVan = diemVan;
        }
        public void Nhap()
        {
            Console.WriteLine("Nhap ho va ten: ");
            hoTen = Console.ReadLine();

            Console.WriteLine("Nhap MaSV: ");
            maSV = int.Parse(Console.ReadLine());

            Console.WriteLine("Nhap diem Toan: ");
            diemToan = double.Parse(Console.ReadLine());

            Console.WriteLine("Nhap diem Toan: ");
            diemVan = double.Parse(Console.ReadLine());

        }

        public double tinhDTB()
        {
            double DTB =  (diemToan + diemVan)/2; 
            return DTB;
        }

        public void hienthi()
        {
            Console.WriteLine($"Ho va ten: {hoTen}");
            Console.WriteLine($"MaSV : {maSV}");
            Console.WriteLine($"Diem toan: {diemToan}");
            Console.WriteLine($"Diem Van: {diemVan}");
        }
    }

    class Program
    {
        static void Main( string[] args )
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            SinhVien sv1 = new SinhVien("Nguyễn Hải Đông", 363636, 8.5, 7.5);
            SinhVien sv2 = new SinhVien("Trần Văn A", 2, 6.0, 8.0);

            Console.WriteLine("Thong tin sinh vien 1:");
            sv1.hienthi();

            Console.WriteLine("Thong tin sinh vien 2:");
            sv2.hienthi();

            Console.ReadKey();
        }
    }
}
