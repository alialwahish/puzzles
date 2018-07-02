using System;
using System.Collections.Generic;
using System.Text;

namespace Puzzles
{
    class Program
    {

        public static int[] randArr(){
            int[] randArr=new int[10];
            Random rand = new Random();
            
            for(int i=0;i<randArr.Length;i++){
                randArr[i]=rand.Next(5,25);
            }

            int min=randArr[0];
            int max=min;
            int sum=0;
            for (int i=0;i<randArr.Length;i++){
                if(min>randArr[i]){
                    min=randArr[i];
                }
                else if(max<randArr[i]){
                    max=randArr[i];
                }
                sum+=randArr[i];
            }
            Console.WriteLine("max:"+max+" min:"+min+" sum:"+sum);
            return randArr;
        }

        public static String coinToss(){
            Random rand = new Random();
            int num=rand.Next(0,2);
            Console.WriteLine("Toss "+num);
            if(num==0){
                return "Head";
            }
            else{
                return "Tail";
            }
        }
        public static Double tossMultipleCoins(int num){
            int h=0;
            int t=0;
            for(int i=0;i<=num;i++){
                if(coinToss()=="Head"){
                    Console.WriteLine("retuned Head");
                    h++;
                }
                else{
                    Console.WriteLine("retuned Tail");
                    t++;
                }
            Console.WriteLine("H "+h+" "+"T "+t);
            }
            if(h<t){
                return ((Double)t/(Double)h);
            }
            else{
                return ((Double)h/(Double)t);
            }

        }

        public static String[] names(){
            String[] strArr={"Todd", "Tiffany", "Charlie", "Geneva", "Sydney"};
            String[] randArr=new string[strArr.Length];
            Random rand= new Random();
                
            List<String> randNames= new List<String>();  
            String name="";
            while(randNames.Count<5){
                name=strArr[rand.Next(0,strArr.Length)];
                if(!randNames.Contains(name))
                {

                randNames.Add(name);
                // Console.WriteLine("Added name: "+name);
                
                }
                
            }
            int i=0;
            List<String> n = new List<String>();

            foreach(String s in randNames){
                randArr[i]=s;
                Console.WriteLine(randArr[i]);
                if((int)(randArr[i].Length)>5){
                 n.Add(randArr[i]);

                }
                i++;
            }
            
            string[] retArr = new string[n.Count];
            retArr=n.ToArray();
            

            return retArr;

        }


        static void Main(string[] args)
        {
            // Console.WriteLine("Ratio on multi tosses "+tossMultipleCoins(10));    
            Console.WriteLine(names().ToString());
        }
    }
}
