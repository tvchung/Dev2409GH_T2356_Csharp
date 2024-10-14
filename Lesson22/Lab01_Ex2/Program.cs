namespace Lab01_Ex2
{
    /// <summary>
    /// Author: Chung Trịnh
    /// Date: 14/10/2024
    /// ============================================
    /// 
    /// </summary>
/*
 * Viết chương trình thực hiện các yêu cầu sau
    - Khai báo các biến để lưu trữ thông tin của Nhân Viên bao gồm:
    o Mã Nhân viên
    o Họ tên nhân viên
    o Ngày sinh
    o Địa chỉ
    o Điện thoại
    o Email
    - Gán giá trị cho các biến
    - Hiển thị trên màn hình thông tin của nhân viên
 */

    internal class Program
    {
        static void Main(string[] args)
        {
             Console.OutputEncoding=System.Text.Encoding.UTF8;   
             Console.WriteLine("Viết chương trình thực hiện các yêu cầu sau");
            // Khai bao bien
            string maNV;
            string hoVaTen;
            DateTime ngaySinh;
            string diaChi;
            string dienThoai;
            string email;

            //  Gán giá trị
            maNV = "NV001";
            hoVaTen = "Chung chung";
            ngaySinh = DateTime.Now;
            diaChi = "Số 25 Phố Vũ Ngọc Phan";
            dienThoai = "0978611889";
            email = "chungtrinhj@gmail.com";

            // Hiển thị thông tin
            Console.WriteLine("===== THÔNG TIN CÁ NHÂN");
            Console.WriteLine("Mã nhân viên:" + maNV);
            Console.WriteLine("Họ và tên:{0}", hoVaTen);
            Console.WriteLine("Ngày sinh:{0}", String.Format("{0:dd/MM/yyyy}", ngaySinh));
            Console.WriteLine("Đia chỉ: " + diaChi);
            Console.WriteLine("Điện thoại:" + dienThoai);
            Console.WriteLine("Email: {0}",email);

        }
    }
}
