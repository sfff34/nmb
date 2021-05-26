using System;
using System.Collections;

namespace lib5
{

    class student
    {
        ArrayList idd = new ArrayList();
        ArrayList fio = new ArrayList();
        ArrayList group = new ArrayList();
        ArrayList data = new ArrayList();

        public void add(int iid, string fiio, string grroup, string ddata)
        {
            idd.Add(iid);
            fio.Add(fiio);
            group.Add(grroup);
            data.Add(ddata); 
            Console.WriteLine("Студент добавлен ");

        }
        public void delete(int id, string fiio, string grroup, string ddata, int jd)
        {
            if (id == jd)
            {
                idd.Remove(id);
                fio.Remove(fiio);
                group.Remove(grroup);
                data.Remove(data);
                Console.WriteLine("Студент удален ");
            }
            else
            {
                Console.WriteLine("Студента с таким id не существует");
            }
        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Если хотите добавить студента - 1, изменить данные о студенте - 2, удалить студента 3 ");
            string a = Console.ReadLine();
            student Stud = new student();
            int jd, id;
            string fio, group, data;

            if (a.Contains("1"))
            {
                Console.WriteLine("Введите id, чтобы добавить студента");
                jd = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите ФИО студента");
                fio = Console.ReadLine();
                Console.WriteLine("Введите группу студента");
                group = Console.ReadLine();
                Console.WriteLine("Введите дату рождения");
                data = Console.ReadLine();
                Stud.add(jd, fio, group, data);

            }
            if (a.Contains("2"))
            {
                Console.WriteLine("Не реализовано");
            }
            if (a.Contains("3"))
            {
                Console.WriteLine("Введите id, чтобы удалить студента");
                id = Convert.ToInt32(Console.ReadLine());
             
            }



        }
    }
}
