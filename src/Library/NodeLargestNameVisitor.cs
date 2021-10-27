using System;

namespace Library
{
    public class NodeLargestNameVisitor : Visitor
    {

        public override void Visit(Node node)
        {
            foreach (Node child in node.Children)
            {
                if(child.Person.Name.Length > this.Name.Length)
                {
                    this.Name = child.Person.Name;
                }
                child.Accept(this);
            }

        }
    }
}