using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bài_tập_list
{
    class Program
    {
        static void NhapVaThemPhanTu(int n, List<int> danhSach1)
        {
            //Tạo mảng để người dùng nhập tùy ý         
            int[] A = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("Nhap vi tri {0} = ", i);
                A[i] = int.Parse(Console.ReadLine());
            }
            //Thêm phần tử trong mảng vào list 
            for (int i = 0; i < n; i++)
            {
                danhSach1.Add(A[i]);
            }
        }
        static void SapXepVaLoc(List<int> danhSach1)
        {
            //Sắp xếp và lọc để có giá trị khác nhau ko bị lặp
            //Sắp xếp danh sách
            danhSach1.Sort();
            //Lọc phần tử bị lặp
            List<int> danhSachHoanChinh = danhSach1.Distinct().ToList();
            //Đếm phần tử
            Console.WriteLine("So phan tu la: " + danhSachHoanChinh.Count);
            //Ghi ra số phần tử đó
            Console.Write("Danh sach phan tu: ");
            foreach (var phanTu in danhSachHoanChinh)
            {
                Console.Write(phanTu + " ");
            }
            Console.Write("\n"); //Trình bày cho đẹp :v
        }
        static void KiemTra(int x, List<int> danhSachHoanChinh)
        {
            bool tonTai = danhSachHoanChinh.Contains(x);

            if (tonTai == true)
            {
                Console.WriteLine("Phan tu co trong danh sach");
            }
            else
            {
                Console.WriteLine("Phan tu khong co trong danh sach");
            }
        }
        static void Main(string[] args)
        {
            //Khởi tạo cái list trong main để lọc xong gọi lại ko bị lỗi
            List<int> danhSach1 = new List<int>();
            List<int> danhSachHoanChinh = new List<int>();
            Console.Write("Nhap so luong phan tu trong list (1 >= n <= 1.000): ");
            int n = Convert.ToInt32(Console.ReadLine());
            NhapVaThemPhanTu(n, danhSach1);
            SapXepVaLoc(danhSach1);
            Console.Write("Nhap so muon kiem tra = ");
            int x = Convert.ToInt32(Console.ReadLine());
            KiemTra(x, danhSachHoanChinh);
        }


    }


}
