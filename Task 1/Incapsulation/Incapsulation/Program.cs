using System;
using System.IO;

namespace Incapsulation
{

    public class Program {

        static void Main(string[] args)
        {
            var vertexes = CubeLoader.LoadFromTextFile("coord.txt");
            Cube cube = new Cube();
            using (StreamWriter streamWriter = new StreamWriter("out.txt"))
            {
                streamWriter.WriteLine("Cube area is {0}, volume is {1}.", cube.Area, cube.Volume);
            }
        }
    }
}
