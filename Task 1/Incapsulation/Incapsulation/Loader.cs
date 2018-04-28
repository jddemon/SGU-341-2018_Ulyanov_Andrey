using System;
using System.Collections.Generic;
using System.IO;

namespace Incapsulation
{
    static class CubeLoader
    {
        private const int AllowedCoordsCount = 3;
        private const int AllowedVerticesCount = 8;


        public static Cube LoadFromTextFile(string path)
        {
            List<Point> vertices = new List<Point>();

            using (StreamReader streamReader = new StreamReader(path))
            {
                string line = streamReader.ReadLine();

                while (line != null && vertices.Count != AllowedVerticesCount)
                {
                    string[] coords = line.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                    if (coords.Length != AllowedCoordsCount)
                    {
                        throw new InvalidDataException("point must contain only 3 coordinates");
                    }

                    try
                    {
                        vertices.Add(
                            new Point(
                                double.Parse(coords[0]),
                                double.Parse(coords[1]),
                                double.Parse(coords[2])
                            )
                        );
                    }
                    catch (Exception e)
                    {
                        throw new Exception("couldn't parse vertex coordinates");
                    }

                    line = streamReader.ReadLine();
                }
            }

            return new Cube(vertices);
        }

    }

}
