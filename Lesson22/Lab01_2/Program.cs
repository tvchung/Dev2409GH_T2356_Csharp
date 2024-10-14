namespace Lab01_2
{
    /// <summary>
    /// Author  :Chung Trịnh
    /// Date    :14/10/2024
    /// Objective: Chương trình minh họa các sử dụng biến, hằng số, kiểu dữ liệu...
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Khai báo, hiện thị giá trị
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // Khai báo biến
            int id = 1;
            string name = "David Chung Chunn";
            byte age = 45;
            char gender = 'M';

            // Khai báo biến hằng 
            const float percent = 75.50F;

            // Hiển thị giá trị
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Mã số: {0} ", id);
            Console.WriteLine("Tên :" + name);
            Console.WriteLine("Tuổi: {0}", age);
            Console.WriteLine("Giới tính:{0}", gender);
            Console.WriteLine("Percent:" + percent);
        }
    }
}
