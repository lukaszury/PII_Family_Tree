using System;

namespace Library
{
    public class NodeVisitor : Visitor
    {
        public override void Visit(Node node)
        {
            this.Ages += node.Person.Age;
            foreach (Node child in node.Children)
            {
                child.Accept(this);
            }

        }
    }
}