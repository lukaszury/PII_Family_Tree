using System;

namespace Library
{
    public class NodeOldestSonVisitor : Visitor
    {

        public override void Visit(Node node)
        {
            foreach (Node child in node.Children)
            {
                if(child.Person.Age > this.Ages)
                {
                    this.Ages = child.Person.Age;
                }
                child.Accept(this);
            }

        }
    }
}