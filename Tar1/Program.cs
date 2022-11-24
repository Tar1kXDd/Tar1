using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tar1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("Данила","Тарунов","4-2ис",5);
            Aspirant aspirant1 = new Aspirant("Данила","Тарунов","4-2ис",5,"1с");
            Console.WriteLine("Студент: "+student1.LastName + " Получает степендию равную "+ student1.getScolarship());
            Console.WriteLine("Апирант: "+ aspirant1.LastName + " Получает степендию равную " + aspirant1.getScolarship());
            Student[] massiv = new Student[4];
            massiv[0]= new Student("Егор", "Дербин", "4-1ис", 4);
            massiv[1]= new Student("Кирилл", "Гусев", "4-2ис", 3);
            massiv[2]= new Aspirant("Прилуков", "Сергей", "4-2ис", 4,"");
            massiv[3] = new Aspirant("Смирнова", "Дарья", "4-1ис", 5, "Дизайн");
            foreach (var item in massiv)
            {
                if (item is Aspirant)
                {
                    Console.WriteLine("Аспирант: " + item.LastName + " Получает степендию равную " + item.getScolarship());
                }
                else
                {
                    Console.WriteLine("Студент: " + item.LastName + " Получает степендию равную " + item.getScolarship());

                }


            }
            Console.WriteLine();
        }
    }
}
