using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SeleQuick2
{
    class Program
    {
        static void Main(string[] args)
        {

            Human Hamid = new Human();

            string originalName = Hamid.HumanName();

            Console.WriteLine(originalName);
            Thread.Sleep(1);
            //if (1 > 2)
            //{
            //    Hamid.Run();

            //}
            //else
            //{
            //    Hamid.Walk();
            //}

            //if (1 == 2)  // if 1 is the same as  2 tell hamid to run else tell him to walk 
            //{
            //    Hamid.Run();

            //}
            //else
            //{
            //    Hamid.Walk();
            //}


            //if (1 != 2)  // if 1 is not the same as  2 tell hamid to run else tell him to walk 
            //{
            //    Hamid.Run();

            //}
            //else
            //{
            //    Hamid.Walk();
            //}

            //// for loop 

            //int years = 55;
            //for (int i = 0; i < 5 ; i++)
            //{
            //   Hamid.Wink();
            //    if (i == 3)
            //    {
            //        break;
            //    }
            //}

            //while (1>0)
            //{
            //    Hamid.Run();

            //    if (Hamid.Age == 23)
            //    {
            //        break;
            //    }
            //}

        }


        public class Human
        {
            // data types 
            // string Name = "Sandip";
            // int Age = 20;
            // bool isHeMale = ;

            public Human()
            {

            }

            public string Name { get; set; }

            public int Age { get; set; }

            public bool isHeMale { get; set; }

            private void HeartBeat()
            {

            }

            public void Walk()
            {

            }
            public void Run()
            {

            }
            public void Wink()
            {

            }
            public string HumanName()
            {
                string newName = "NewName";
                return newName;
            }

            public int Years()
            {
                string familyName = "Happy";
                int numbers = 32;

                return numbers;

            }

        }

        
       
    }
}
