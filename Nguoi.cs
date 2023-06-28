using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHoDan
{
     public class Nguoi
    {
        public int SoCMND { get; set; }
        public string HoTen { get; set; }
        public int NamSinh { get; set; }
        public string NgheNghiep { get; set; }

        public Nguoi()
        {
            Console.Write("Nhap CMND: ");
            SoCMND = int.Parse(Console.ReadLine());
            Console.Write("Nhap Ho Ten: ");
            HoTen = Console.ReadLine();
            Console.Write("Nhap nam sinh: ");
            NamSinh = int.Parse(Console.ReadLine());
            Console.Write("Nhap nghe nghiep: ");
            NgheNghiep = Console.ReadLine();
            Console.WriteLine("=============");
        }
        public void HienThi()
        {
            Console.WriteLine($"{HoTen} co CMND {SoCMND}, sinh nam: {NamSinh}, nghe nghiep: {NgheNghiep}");
            Console.WriteLine("=============");
        }
    }
}
