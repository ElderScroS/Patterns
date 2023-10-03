using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManagerComposite
{
    internal class Folder : Node
    {
        public List<Node> _children = new List<Node>();

        public Folder(string name)
        {
            this.Name = name;
        }
         
        public override void Add(Node node)
        {
            Size += node.Size;
            _children.Add(node);
        }
        public override bool GetNode() => true;
        public void ShowFolders()
        {
            for (int i = 0; i < this._children.Count; i++)
            {
                if (this._children[i].GetNode())
                    Console.WriteLine($"Folder -> {this._children[i].Name}");
            }
        }
        public void ShowAllContent()
        {
            for (int i = 0; i < this._children.Count; i++)
            {
                if (this._children[i].GetNode())
                    Console.WriteLine($"Folder -> {this._children[i].Name}");
                else
                    Console.WriteLine($"File -> {this._children[i].Name}");
            }
        }
        public override void ShowFile() => throw new NotImplementedException();
    }
}