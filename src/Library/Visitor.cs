using System;
using System.Text;

namespace Library
{
    public abstract class Visitor
    {
        public int Ages
        {
            get
            {
                return this.totalAges;
            }

            set
            {
                this.totalAges = value;
            }
        }

        protected int totalAges {get;set;} = 0;

        public string Name{get;set;} = "";

        public abstract void Visit(Node node);
    }
}