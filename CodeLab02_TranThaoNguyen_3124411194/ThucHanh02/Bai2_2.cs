using System;
using System.Collections;
namespace TH02
{
    public class PersonList
    {
        private ArrayList dsPerson;
        public PersonList()
        {
            dsPerson = new ArrayList();
        }
        public PersonList(PersonList list)
        {
            dsPerson = new ArrayList();

            foreach (Person p in list.dsPerson)
            {
                dsPerson.Add(p);
            }
        }
        public void Add(Person x)
        {
            dsPerson.Add(x);
        }
        public void Input()
        {
            Console.Write("Nhap so luong Person: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("\nNhap Person thu " + i + ":");

                Person p = new Person();
                p.Input();

                Add(p);
            }
        }
        public void Output()
        {
            for (int i = 0; i < dsPerson.Count; i++)
            {
                Console.WriteLine("\nPerson thu " + i + ":");
                Person p = (Person)dsPerson[i];
                p.Output();
            }
        }
        // lay danh sach nhung nguoi con song
        public PersonList LivingPeople()
        {
            PersonList result = new PersonList();

            foreach (Person p in dsPerson)
            {
                if (p.IsLiving())
                {
                    result.Add(p);
                }
            }

            return result;
        }
    }
}