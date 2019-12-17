using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumDemo
{
    enum Day { Mon, Tue, Wed, Thu, Fri, Sat, Sun }
    [Flags]
    enum Genre
    {
        None = 0, Comedy = 1, Action = 2,
        Documentary = 4, Sci_Fi = 8, Romance = 16, Adult = 32
    }
    class Program
    {
        static void Main(string[] args)
        {
            GenreDemo();   
        }
        static void GenreDemo()
        {
            Genre genre = Genre.Comedy;
            Console.WriteLine($"-> {genre}");
            if (genre == Genre.Action)
                Console.WriteLine("ACTION");
            else
                Console.WriteLine("NOT ACTION");

            genre = Genre.Comedy | Genre.Romance | Genre.Action;   //combining multiple genres
            Console.WriteLine($"-> {genre}");

            if (genre.HasFlag(Genre.Action))                        //checking for an enum value
                Console.WriteLine("ACTION");
            else
                Console.WriteLine("NOT ACTION");
        }
        static void DayDemo()
        {
            Day today = Day.Wed;
            Console.WriteLine($"Today: {today}");

            today += 1;
            Console.WriteLine($"Today: {today}");

            Console.Write("Enter a day: ");
            string input = Console.ReadLine();
            today = (Day)Enum.Parse(typeof(Day), input);//must be able to reproduce
            Console.WriteLine($"Today: {today}");
        }
    }
}
