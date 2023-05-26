using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linh_Canh
{
    class Program
    {
        static void NhapVaThemPhanTu(List<int> A)
        {
            int n = 0;
            while (n != -1) // Người dùng nhập đến khi muốn dừng nhập thì nhập -1
            {
                Console.Write("Nhap:");
                n = int.Parse(Console.ReadLine());
                if (n != -1)
                {
                    A.Add(n); // Nếu n ko bằng -1 thì cứ tiếp tục add vào list A
                }
            }    
        }

        static void display(List<int> A)
        {
            if(A.Count() == 0) // Tệp rỗng sẽ báo như dưới
            {
                Console.Write("Khong co phan tu nao hop le!");
            }
            else foreach (var a in A) // Xem phần tử trong list
            {
                Console.Write(a + " ");
            }
        }

        static bool CheckTangDan(List<int> A)
        {
            for(int i =0; i<A.Count-1; i++) 
            {
                if (A.ElementAt(i) > A.ElementAt(i + 1))
                {
                    return false;
                }
            }
            return true;
        }
     
        static List<int> removeNotPrime(List<int> A) 
        {
            List<int> temp = new List<int>(); // tạo list tạm để thêm phần tử là số nguyên tố
            for (int i = 0; i < A.Count; i++)
            {
                if (isPrime(A.ElementAt(i)) == true) // Ở hàm isPrime nếu return true thì sẽ lên hàm này được add vào list temp
                {
                    temp.Add(A[i]);
                }
            }
            return temp; //trả số liệu về lại list temp
        }
        static bool isPrime(int a) //Hàm này là hàm nhỏ của hàm removeNotPrime
        {
            if (a < 0) return false;

            for (int i = 2; i * i <= a; i++)
            {
                if (a % i == 0) return false;
            }
            return true;
        }

        static void Main(string[] args)
        {

            List<int> A = new List<int>();
            NhapVaThemPhanTu(A);
            display(A);
            //a
            if (CheckTangDan(A)) //Phải viết như vậy để khi thêm
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
            //b
            List<int> B = removeNotPrime(A); // Gán list A vào list B để sắp xếp
            Console.WriteLine(B.Count());
            B.Sort(); // Sắp xếp lại các số nguyên tố theo thứ tự
            display(B);//Hiển thị list B
        }
    }
}
