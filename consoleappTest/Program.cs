using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleappTest
{
    class Program
    {
        /// <summary>
        /// //////////Creating many no of lists 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
           // List<string> list1 = new List<string>{"sonam","Awasthi"};
            //List<string> list2 = new List<string>();
            //List<employeedata> list2 = new List<employeedata>();
            //list2.Add(new employeedata { Name = "sonam", Age = 23, score = 12 });
            //list2.Add(new employeedata { Name = "shailu", Age = 12, score = 20 });
            ////list2.Add("sonam");
            ////list2.Add("awasthi");
            //foreach(var data in list2)
            //{
            //Console.WriteLine("Name is "+ data.Name+"\n");
            //Console.WriteLine("Age is " + data.Age + "\n");
            //Console.WriteLine("Score is " + data.score + "\n");
            //Console.WriteLine("************************************");
            //Console.ReadLine();

           

            ////find the frequecy of number in array
            int[] arr={10,5,10,2,5,4,5};
            var dict=new Dictionary<int,int>();
            foreach(var value in arr)
            {
                if(dict.ContainsKey(value))
                    dict[value]++;
                else 
                    dict[value]=1;
            }
            foreach(var pair in dict)
            {
                Console.WriteLine("{0}={1} time($)",pair.Key,pair.Value);
                Console.ReadLine();
            }
            }
        }    

    
}


public class employeedata
{
    public string Name;
    public int Age;
    public int score;

}