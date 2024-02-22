////lv2 num 3

//using System;
//using System.Xml.Linq;

//struct Sportsmens
//{
//    private string _lastname;
//    private double result1; //поля класса/структуры
//    private double result2;
//    private double result3;
//    public Sportsmens(string lastname, double res1, double res2, double res3)
//    {
//        _lastname = lastname;
//        result1 = res1;
//        result2 = res2; //тело конструктора
//        result3 = res3;
//    }
//    public string Lastname()
//    {
//        return _lastname;
//    }

//    public double Bestresult()
//    {
//        return Math.Max(result1, Math.Max(result2, result3));
//    }
//    public void Print()
//    {
//        Console.WriteLine($"Sportsmens: {Lastname()}");
//        Console.WriteLine($"Best result: {Bestresult()}");
//        Console.WriteLine();
//    }
//}

//class Program
//{
//    static void Main()
//    {

//        Sportsmens[] sportsmens = {
//        new Sportsmens("Евелькин", 4.9, 5.9, 6.0),
//        new Sportsmens("Smith", 5.6, 5.8, 5.7),
//        new Sportsmens("Johnson", 5.5, 5.9, 6.1),
//        new Sportsmens("Носыч", 4.8, 7.1, 7.0),
//        new Sportsmens("Мбапе", 4.9,5.9,6.1)
//    };

//        Console.WriteLine("Final Results:");
//        for (int i = 0; i < sportsmens.Length; i++)
//        {
//            sportsmens[i].Print();
//        }

//    }
//}




//lv 3 num 3
using System;
using System.Runtime.InteropServices;

struct TeamResult
{
    private int[] places;
    public TeamResult(int[] places)
    {
        this.places = places; // this.places переменная в этом классе
    }
    public int[] Places 
    { 
        get { return places; } 
        private set { places = value; }
    }
    public int CalculatePoints()
    {
        int totalpoints = 0;
        for(int i=0; i<places.Length; i++)
        {
            int place = places[i];
            switch(place)
            {
                case 1:
                    totalpoints += 5;
                    break;
                case 2:
                    totalpoints += 4;
                    break;
                case 3:
                    totalpoints += 3; 
                    break;
                case 4:
                    totalpoints += 2; 
                    break;
                case 5:
                    totalpoints += 1;
                    break;
                default:
                    break;

            }
        }
        return totalpoints;
    }
}
class Programm
{
    static void Main()
    {
        TeamResult[] team = new TeamResult[]
        {
            new TeamResult ( new int[] {7, 2, 3, 14, 6, 4} ),
            new TeamResult (  new int[] {5, 8, 9, 10, 17, 12} ),
            new TeamResult (  new int[] {13, 15, 1, 16, 11, 18} )
        };
        for(int i=0;i<team.Length;i++)
        {
            int totalpoints= team[i].CalculatePoints();
            Console.WriteLine($"Команда-{i+1}: набрала {totalpoints} баллов ");
        }
        int winnerindex = 0;
        int maxpoint = team[0].CalculatePoints(); //макс-первый элемент массива
        for(int i=1;i<team.Length;i++)
        {
            int currentpoints = team[i].CalculatePoints();
            if(currentpoints > maxpoint) //сравниваем текующие баллы с максимальными 
            {
                maxpoint = currentpoints; //если тек больше, то в макс записываем текущее значение
                winnerindex = i;//сохр индекс макс элемента
            }
        }
        Console.WriteLine($"Команда {winnerindex+1}: является победителем");
    }
}
