using System;

namespace Store_Class
{
    public class Store
    {
        public string Name;
        public string Owner_Name;
        public double Number;
        public double Registerd_Value;
        public int[] myNum = { 1000, 500, 100, 50, 20, 10, 5, 2, 1 };
        public int[] exchange(float in1){
            float temp = (in1%1)*100;
            int[] Data = {0,0,0,0,0,0,0,0,0,0,0}; 
            if (check_input(in1))
            {
                for (int i = 0; i < 9; i++)
                {
                    int T = (int)(in1 / myNum[i]);
                    //Console.WriteLine("{0} : {1}",myNum[i],T);
                    in1 = in1 % myNum[i];
                    Data[i] = T;
                }
                //Console.WriteLine("0.50 : {0}", (int)(temp / 50));
                Data[9] = (int)(temp / 50);
                temp = temp % 50;
                //Console.WriteLine("0.25 : {0}", (int)(temp / 25));
                Data[10] = (int)(temp / 25);
            }
            else
                Console.WriteLine("Input Error"); 
            //for(int i=0;i<11;i++){
            //    Console.WriteLine(Data[i]);
            //}
            return Data;
            
        }
        private bool check_input(float in1)
        {
            if (in1 <= 0)
                return false;
            else if (in1 < 1 && (in1 != 0.50 || in1 != 0.25))
                return false;
            else
                return true;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Store store1 = new Store();
            Console.WriteLine("--------------  1.1 --------------------");
            Console.Write("Please input Name : ");
            store1.Name = Console.ReadLine();
            Console.Write("Please input Number : ");
            store1.Number = double.Parse(Console.ReadLine());
            Console.Write("Please input Owner Name : ");
            store1.Owner_Name = Console.ReadLine();
            Console.Write("Please input Registerd Value : ");
            store1.Registerd_Value = double.Parse(Console.ReadLine());
            Console.WriteLine("-----------Shop Information--------------");
            Console.WriteLine("Name : "+store1.Name);
            Console.WriteLine("Number : " + store1.Number);
            Console.WriteLine("Owner name : " + store1.Owner_Name);
            Console.WriteLine("Registered Value : " + store1.Registerd_Value);
            Console.WriteLine("--------------  1.2 --------------------");
            Console.Write("Please input money : ");
            int[] Data = store1.exchange(float.Parse(Console.ReadLine()));
            for(int i=0;i<9;i++){ 
                Console.WriteLine("{0} : {1}",store1.myNum[i],Data[i]);
            }
            Console.WriteLine("0.50 : {0}",Data[9]);
            Console.WriteLine("0.25 : {0}",Data[10]);
        }
    }
}
