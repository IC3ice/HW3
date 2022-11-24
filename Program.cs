class Program
{
    static void Main(string[] args)
    {
        Queue<char> Mach = new Queue<char>();
        Console.WriteLine("------------------------");
        Console.WriteLine("Please input Your fruit");
        Console.WriteLine("Only L / M / S");
        while(true){
            Console.WriteLine("------------------------");
            char Fruit = char.Parse(Console.ReadLine());
            if(Fruit != 'S'&&Fruit != 'M'&&Fruit != 'L' ){
                break;
            }
            else { 
                if (Fruit == 'S'){
                    Mach.Push('3');
                }
                else if (Fruit == 'M'){
                    Mach.Push('2');
                }
                else if (Fruit == 'L'){
                    Mach.Push('1');
                }
            }
        }
        for (int i =0 ;i<Mach.GetLength(); i++){
            if (Mach.Get(i) == '1'){
                Mach.Push('2');
                Mach.Push('2');
            }
            else if (Mach.Get(i) == '2'){
                Mach.Push('3');
                Mach.Push('3');
                Mach.Push('3');
            }
        }
        for (int i =0 ;i<Mach.GetLength(); i++) 
        Console.Write(Mach.Get(i));
    }
}