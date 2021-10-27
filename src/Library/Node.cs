using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
    public class Node
    {
        private Person person;

        private List<Node> children = new List<Node>();

        public Person Person {
            get
            {
                return this.person;
            }
        }

        public ReadOnlyCollection<Node> Children { 
            get
            {
                return this.children.AsReadOnly();
            }
        }

        public Node(Person person)
        {
            this.person = person;
        }


        public void AddChildren(Node n)
        {
            this.children.Add(n);
        }

        public void Accept(Visitor visitor)
        {
            visitor.Visit(this);
        }
        
        public string getAges()
        {
            Visitor visitor = new NodeVisitor();
            this.Accept(visitor);
            return $"El total de edades del árbol es: {visitor.Ages}";
        }

        public string oldestSon()
        {
            Visitor visitor = new NodeOldestSonVisitor();
            this.Accept(visitor);
            return $"El hijo más viejo del arbol tiene : {visitor.Ages}";
        }

        public string largestName()
        {
            Visitor visitor = new NodeLargestNameVisitor();
            this.Accept(visitor);
            return $"El nombre más largo del árbol es: {visitor.Name}";
        }
    }
}
