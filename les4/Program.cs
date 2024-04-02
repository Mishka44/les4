using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace les4
{
    public class SomeClass{
       

       public static int Divide(int first, int second)
        {
            try
            {
               return first / second;
            }
            catch
            {
                throw new Exception("Попытка деления на ноль");
            }
            
        }

    }


    public class MultipleTable
    {
        private string table;
        public string Table { get { return table; } }
        public MultipleTable(int start, int finish)
        {
            string tmp_table = "";
            for (int i = start; i <= finish; i++)
            {
                for (int j = start; j <= finish; j++)
                {
                    tmp_table += $"\t{i*j}";
                }
                tmp_table += $"\n";
            }
            table = tmp_table;
        }
    }

    public class FileIo
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private string path;

        public string Path
        {
            get { return path; }
        }
        public FileIo(string _name)
        {
            name = _name;
           path =  Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            
        }
        public void WhriteData(string text, bool append = true)
        {
            StreamWriter streamWriter = new StreamWriter(path + "\\" + Name, append);
            streamWriter.WriteLine($"{DateTime.Now.ToString("yyyy.MM.dd HH:mm:ss.fff")}" +
                $"{text}\n");
            streamWriter.Close();
        }
        public static string readData(string _name)
        {
            StreamReader reader = new StreamReader(_name);
            string result = reader.ReadToEnd();
            /*reader.ReadLine();*/
            return result;
        }
           
    }

    internal class Program
    {

        
        static void Main(string[] args)
        {
            /* string str1, str2;
             for (int i = 0; i < args.Length; i += 2)
             {
                 try
                 {
                     str1 = args[i];
                     str2 = args[i + 1];
                     Console.WriteLine($"{str1} "  + $" {str2}");

                 }
                 catch (Exception)
                 {
                     Console.WriteLine("Вы не ввели фамилию");

                 }
             }*/





            /*try
            {
                Console.WriteLine(args[0]);
            }
            catch
            {

                throw new Exception("Нет аргументов командной строки");
            }*/


            /*int first, second;
            try
            {
                Console.WriteLine("Введите первое число:");
                first = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите второе число:");
                second = int.Parse(Console.ReadLine());
                Console.WriteLine($"{first} / {second} " + $" = {SomeClass.Divide(first, second)}");

            }
            catch (Exception ex001)
            {
                foreach(var item in ex001.Data)
                {
                    Console.WriteLine(item);
                }
                if (ex001.HResult == -2146233033)
                {
                    Console.WriteLine($"{ex001.Message} вы ввели не цифру");
                }
                if (ex001.HResult == -2147352558)
                {
                    Console.WriteLine($"{ex001.Message} делить на ноль нельзя");
                }
                *//*Console.WriteLine(ex001.Message + " " + ex001.InnerException);*//*
            }
            finally { Console.WriteLine("Этот код выполнится в любом случае"); }*/

            /*foreach (string item in args)
            {
                Console.WriteLine(item);
            }*/



            // пара №2 
            MultipleTable MyTable = new MultipleTable(1, 9);
            Console.WriteLine(MyTable.Table);
            FileIo fileIO = new FileIo("test.txt");
            fileIO.WhriteData(MyTable.Table);
            Console.WriteLine(FileIo.readData(fileIO.Path + "\\" + fileIO.Name));
        }
    }
}
