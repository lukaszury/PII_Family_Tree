using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Node n1 = new Node(new Person("Pedro",19));
            Node n2 = new Node(new Person("Maxi",38));
            Node n3 = new Node(new Person("Luis",43));
            Node n4 = new Node(new Person("Kevin",22));
            Node n5 = new Node(new Person("Lucas",25));
            Node n6 = new Node(new Person("Juan Carlos",29));
            Node n7 = new Node(new Person("Diego",28));
            Node n8 = new Node(new Person("Fede",35));

            n1.AddChildren(n2);
            n1.AddChildren(n3);

            n2.AddChildren(n4);
            n2.AddChildren(n5);

            n3.AddChildren(n6);
            n3.AddChildren(n7);

            n4.AddChildren(n8);
            
            Console.WriteLine(n1.largestName());

            // visitar el árbol aquí
        }
    }
}
