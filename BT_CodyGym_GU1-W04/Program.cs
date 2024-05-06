internal class Program
{

    private static void Main(string[] args)
    {
        int[] srcArray = { 1, 2, 3, 4, 5 };

        //Thực hành tính tổng các phần tử trong mảng
        int[] numbers = new int[5];
        System.Console.WriteLine("Nhap gia tri thu nhat");
        numbers[0] = int.Parse(Console.ReadLine());
        System.Console.WriteLine("Nhap gia tri thu hai");
        numbers[1] = int.Parse(Console.ReadLine());
        System.Console.WriteLine("Nhap gia tri thu ba");
        numbers[2] = int.Parse(Console.ReadLine());
        System.Console.WriteLine("Nhap gia tri thu tu");
        numbers[3] = int.Parse(Console.ReadLine());
        System.Console.WriteLine("Nhap gia tri thu 5");
        numbers[4] = int.Parse(Console.ReadLine());
        int total = 0;
        for (int k = 0; k < numbers.Length; k++)
        {
            total = total + numbers[k];
        }
        Console.WriteLine(total);

        //Thực hành tìm giá trị trong mảng
        string[] students = { "Christian", "Michael", "Camila", "Sienna", "Tanya", "Connor", "Zachariah", "Mallory", "Zoe", "Emily" };
        Console.WriteLine("Enter a name student:");
        string input_name = Console.ReadLine();
        bool isExist = false;
        for (int m = 0; m < students.Length; m++)
        {
            if (students[m].Equals(input_name))
            {
                Console.WriteLine("Position of the students in the list " + input_name + " is: " + (m + 1));
                isExist = true;
                break;
            }
        }
        if (!isExist)
        {
            Console.WriteLine("Not found" + input_name + " in the list.");
        }

        //Bài tập thêm phân tử vào mảng
        int[] newArray = new int[srcArray.Length + 1];
        System.Console.WriteLine("Nhap vi tri muon them: ");
        int index = int.Parse(Console.ReadLine());
        System.Console.WriteLine("Nhap so muon them vao vi tri " + index + " ");
        int element = int.Parse(Console.ReadLine());
        Array.Copy(srcArray, 0, newArray, 0, index);
        newArray[index] = element;
        Array.Copy(srcArray, index, newArray, index + 1, srcArray.Length - index);
        foreach (int item in newArray)
        {
            System.Console.Write(item + " ");
        }


        //Bài tập tìm giá trị lớn nhất trong mảng
        int size;
        int[] array;
        do
        {
            Console.WriteLine("Nhap so phan tu mang:");
            size = int.Parse(Console.ReadLine());
            if (size > 20)
                Console.WriteLine("Mang khong dc dai hon 20 phan tu");
        } while (size > 20);
        array = new int[size];
        int i = 0;
        while (i < array.Length)
        {
            Console.WriteLine("Nhap phan tu" + (i + 1) + " : ");
            array[i] = int.Parse(Console.ReadLine());
            i++;
        }
        Console.WriteLine("Danh sach cac phan tu: ");
        for (int j = 0; j < array.Length; j++)
        {
            Console.WriteLine(array[j] + " ");
        }
        int max = array[0];
        int index1 = 1;
        for (int j = 0; j < array.Length; j++)
        {
            if (array[j] > max)
            {
                max = array[j];
                index = j + 1;
            }
        }
        Console.WriteLine("Phan tu lon nhat trong mang la: " + max + " va tai vi tri: " + index1);
    }
}