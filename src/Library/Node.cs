﻿using System.Collections.Generic;
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
        
        public int getAges()
        {
            Visitor visitor = new NodeVisitor();
            this.Accept(visitor);
            return visitor.Ages;
        }

        public int oldestSon()
        {
            Visitor visitor = new NodeOldestSonVisitor();
            this.Accept(visitor);
            return visitor.Ages;
        }

        public string largestName()
        {
            Visitor visitor = new NodeLargestNameVisitor();
            this.Accept(visitor);
            return visitor.Name;
        }
    }
}
