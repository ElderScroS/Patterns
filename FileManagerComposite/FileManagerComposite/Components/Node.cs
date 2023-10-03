using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManagerComposite
{
    internal abstract class Node
    {
        public string Name { get; set; }
        public string TypeOfFile { get; set; }
        public int Size { get; set; }

        public virtual void Add(Node node) { }
        public abstract bool GetNode();
        public abstract void ShowFile();
    }
}
