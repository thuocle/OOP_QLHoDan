using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHoDan
{
    public class HoDan
    {
        public int SoThanhVien { get; set; }
        public string SoNha { get; set; }

        List<Nguoi> ThanhVien = new List<Nguoi>();

        public void NhapThongTin()
        {
            Console.Write("Nhap so thanh vien:");
            SoThanhVien = int.Parse(Console.ReadLine());
            Console.Write("Nhap so nha:");
            SoNha = Console.ReadLine();
            for (int i = 0; i < SoThanhVien; i++)
            {
                Console.WriteLine("Thanh vien {0}:", i+1);
                Nguoi n = new Nguoi();
                ThanhVien.Add(n);
            }
        }

        public void HienThiThongTin()
        {
            Console.WriteLine($"Ho dan so nha {SoNha} co {SoThanhVien} thanh vien\n" +
                $"Cac thanh vien trong ho dan la:");
            int i = 1;
            foreach (var item in ThanhVien)
            {
                Console.Write($"{i} ");
                item.HienThi();
                i++;
            }
        }
    }
}
