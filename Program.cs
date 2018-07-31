using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program{
        static void Main(string[] args){ 
            int menu = 0;
            int[] squarenums = new int[] { 0, 0 };
            int[] squarenums = new int[] { 0, 0 };
            while (menu != 5){
                Console.WriteLine("enter 1 to get circle vaules");
                Console.WriteLine("enter 2 to get circle area");
                Console.WriteLine("enter 3 to get square vaules");
                Console.WriteLine("enter 4 to get square area");
                Console.WriteLine("enter 5 to close");
                menu = int.Parse(Console.ReadLine());
                switch(menu){

                    case 1:
                        Console.WriteLine(Square.squares());
                        Console.ReadLine
                        break;

                    case 2:
                        break;
                }
            }
        }
    }

    class Square{
        static squares[] getsquare(){
            squares[0] = 1;
            return squares;
        }
        static int squarearea(){

        }
    }

    class Circle{
        static int getcircle(){

        }
        static int circlearea(){

        }
    }
}
