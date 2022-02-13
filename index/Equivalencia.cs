using System;
using System.Collections;

namespace index
{
    class Equivalencia
    {
        public class Position{
            public int x;
            public int y;
            public Position(int x,int y){
                this.x = x;
                this.y = y;
            }
        }
        public class Date{
            public int m;
            public int d;
            public Date(int m,int d){
                this.m = m;
                this.d = d;
            }
        }
        public  static void Show(Position p){
            Console.WriteLine(p.ToString());
        }
/* 
        static void Main(string[] args)
        {
            Date data = new Date(1,12);
            Position posicao = new Position(10,10);

            Show(posicao);
            //Show(data);

            
        } */
        
    }
}
