using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Incapsulation
{
        public class Cube
        {
            private const double eps = 0.001;

            private List<Point> _vertices;

            public List<Point> Vertices
            {
                get
                     {
                         return _vertices;
                     }
                private set
                {
                    if (value == null || value.Any(x => x == null))
                    {
                        throw new InvalidDataException("list must contain points");
                    }

                    _vertices = value;

                    if (!checkCubeCorrectAndReturnSideLength())
                    {
                        throw new InvalidDataException("cube with given vertices is not valid");
                    }
                }
            }

            public double EdgeLength { get; }
            public double Area { get; }
            public double Volume { get; }

            public Cube() { }

            public Cube(List<Point> vertices)
            {
                Vertices = vertices;
                EdgeLength = GetLength();
                Area = GetArea;
                Volume = GetVolume;
            }

            // минимальное расстояние от текущей точки до всех остальных считаем длиной ребра куба
            private double GetLength()
            {
                Point temp = Vertices.First();

                return Vertices
                    .Where(x => x != temp)
                    .Select(vertex => temp.GetDistance(vertex))
                    .Min();
            }


            private double GetArea
            {
                get
                {
                    return Math.Pow(EdgeLength, 2);
                }
            }

            private double GetVolume
            {
                get
                {
                    return GetArea * EdgeLength;
                }
            }


            // если существует 
            // а) ровно три вершины, удалённых от текущей на длину ребра куба
            // б) ровно три вершины, удалённых от текущей на длину диагонали грани куба
            // в) ровно одна вершина, удалённая от текущей на длину диагонали куба
            // то данные 8 точек считаем кубом
            public bool checkCubeCorrectAndReturnSideLength()
            {
                double cubeFaceDiagonal = Math.Sqrt(2) * EdgeLength;    // диагональ грани куба
                double cubeDiagonal = Math.Sqrt(3) * EdgeLength;    // диагональ куба
                bool valid = false;

                int cubeEdgeCounter = 0,
                    cubeFaceDiagonalCounter = 0,
                    cubeDiagonalCounter = 0;

                for (int i = 0; i < Vertices.Count; i++)
                {
                    for (int j = 1; j < Vertices.Count; j++)
                    {
                        if (Math.Abs(Vertices[i].GetDistance(Vertices[j]) - EdgeLength) < eps)
                        {
                            cubeEdgeCounter++;
                            continue;
                        }

                        if (Math.Abs(Vertices[i].GetDistance(Vertices[j]) - cubeFaceDiagonal) < eps)
                        {
                            cubeFaceDiagonalCounter++;
                            continue;
                        }

                        if (Math.Abs(Vertices[i].GetDistance(Vertices[j]) - cubeDiagonal) < eps)
                        {
                            cubeDiagonalCounter++;
                        }
                    }

                    if (cubeEdgeCounter == 3 && cubeFaceDiagonalCounter == 3 && cubeDiagonalCounter == 1)
                    {
                        valid = true;
                    }
                }
                return valid;
            }
        }
    }
