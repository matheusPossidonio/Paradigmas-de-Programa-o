using System;
using System.Collections;

namespace index
{
    public class Cliente{
        public int desconto;
        public int divida;
        public int calcularTotal(){
            return this.divida - this.desconto;
        }
    }
    public class ClienteNormal : Cliente{
        public ClienteNormal(){}
        public ClienteNormal(int desconto){
            this.desconto = desconto;
        }
        public ClienteNormal(int desconto,int divida){
            this.desconto = desconto;
            this.divida = divida;
        }
    }
    public class ClienteVip : Cliente{
        public ClienteVip(int desconto){
            this.desconto = desconto;
        }
        public ClienteVip(int desconto,int divida){
            this.desconto = desconto + 10;
            this.divida = divida;
        }
    }
    class OrietancaoObejtos
    {     
        static void Main(string[] args)
        {
            Cliente [] clientela = new Cliente[2];
            Cliente cliente1 = new ClienteVip(2,20);
            Cliente cliente2 = new ClienteNormal(2,20);

            clientela[0]= cliente1;
            clientela[1]= cliente2;

            foreach (var item in clientela)
            {
                Console.WriteLine("A divida do cliente foi: " + item.calcularTotal());
            }

            
        } 
        
    }
}
