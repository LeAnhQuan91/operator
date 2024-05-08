internal class Program
{
    static void Main(string[] args)
    {
        float width;
        float heigth;

        Console.WriteLine("Nhap vao so width: ");
       width = float.Parse(Console.ReadLine());

        Console.WriteLine("Nhap vao so heigth");
        heigth = float.Parse(Console.ReadLine());

        float area = width * heigth;

        Console.WriteLine($"Chieu rong la: {width}, Chieu cao la: {heigth},Dien tich hinh chu nhat la: {width}*{heigth}={area} ");
    }
}