using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManagerComposite
{
    internal class File : Node
    {
        public File(string name, string typeOfFile, int size)
        {
            this.Name = name;
            this.TypeOfFile = typeOfFile;
            this.Size = size;
        }

        public override bool GetNode() => false;
        public override void ShowFile() => Console.WriteLine($"\n\t\tFile: {this.Name}.{this.TypeOfFile}\t Size: {this.Size} mb");
    }
}
