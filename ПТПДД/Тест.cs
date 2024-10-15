using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace ПТПДД
{
    internal class Тест // создание массива из вопросов  возвращение тесту
    {
        static public List<string> Вопросы(string que)
        {
            string path = "C:\\Users\\Honor\\Desktop\\ПТПДД\\" + que;
            List<string>list=new List<string>(Directory.GetDirectories(path));
            List<string>list2=new List<string>();
            Random random = new Random();
            for(int i=list.Count()-1; i>=1;i--)
            {
                int j = random.Next(list.Count());
                string tmp = list[j];
                list[j] = list[i];
                list[i] = tmp;
            }
            for (int i = 0; i<10; i++)
                list2.Add(list[i]);
            return list2;
        }
        static public List<string>Разное()
        {
            Random random = new Random();
            List<string> list = new List<string>();
            string path = "C:\\Users\\Honor\\Desktop\\ПТПДД\\";
            List<string> list1 = new List<string>(Directory.GetDirectories(path+"знаки"));
            for (int jjj = 0; jjj < list1.Count(); jjj++)
                list.Add(list1[jjj]);
            path = "C:\\Users\\Honor\\Desktop\\ПТПДД\\";
            list1 = new List<string>(Directory.GetDirectories(path + "разметка"));
            for (int jjj = 0; jjj < list1.Count(); jjj++)
                list.Add(list1[jjj]);
            path = "C:\\Users\\Honor\\Desktop\\ПТПДД\\";
            list1 = new List<string>(Directory.GetDirectories(path + "сигналы"));
            for (int jjj = 0; jjj < list1.Count(); jjj++)
                list.Add(list1[jjj]);
            List<string> list2 = new List<string>();
            List<int> mas = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                int j = random.Next(list.Count());
                if (!mas.Contains(j))
                {
                    mas.Add(j);
                    list2.Add(list[j]);
                }
                else
                {
                    i--;
                }
            }
            return list2;
        }
    }
}
