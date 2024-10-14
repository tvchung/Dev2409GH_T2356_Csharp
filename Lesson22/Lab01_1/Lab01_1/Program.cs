namespace Lab01_1
{
    /// <summary>
    /// Author  : Chung Trịnh
    /// Date    : 14/10/2024
    /// Chương trình C# Đầu tiên
    /// In ra thông tin giới thiệu bản thân
    /// </summary>

    internal class Program
    {
        /// <summary>
        /// Main:
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // Xuất có unicode
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            // Lệnh in ra màn hình dòng văn bản và sau đó xuống dòng
            Console.WriteLine("Họ và tên: Trịnh Văn Chung");
            // Lệnh in có định dạng
            Console.WriteLine("Ngày sinh: {0}", "25/05/1979");
            Console.Write("Địa chỉ: Tầng 6, Số 25 Phố Vũ Ngọc Phan  \n");
            Console.WriteLine("Điện thoại: 0978611889");
            Console.WriteLine("Email:chungtrinhj@gmail.com");
        }
    }
}
