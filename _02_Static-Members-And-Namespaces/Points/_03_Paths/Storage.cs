using System;
using System.Collections.Generic;
using _02_Static_Members_And_Namespaces._01_Point3D;
using System.IO;
using System.Text.RegularExpressions;


namespace _02_Static_Members_And_Namespaces._03_Paths
{
    static class Storage
    {
        public static List<Point3D> ReadData()
        {
            List<Point3D> path = new List<Point3D>();
            string line;
            StreamReader sr = new StreamReader("../../Input.txt");
 
            try
            {
                string pattern = "(\\d+[\\.{1}\\d+]*).[^\\.\\d]*(\\d+[\\.{1}\\d+]*).[^\\.\\d]*(\\d+[\\.{1}\\d+]*)";
                line = sr.ReadLine();

                using (sr)
                {
                    while (line != null)
                    {
                        double x;
                        double y;
                        double z;

                        MatchCollection matches = Regex.Matches(line, pattern);
                        foreach (Match match in matches)
                        {
                            x = Double.Parse(match.Groups[1].Value);
                            y = Double.Parse(match.Groups[2].Value);
                            z = Double.Parse(match.Groups[3].Value);

                            Point3D point = new Point3D(x, y, z);
                            path.Add(point);
                        }

                        line = sr.ReadLine();
                    }
                }
            }

            catch(FileNotFoundException fnf)
            {
                Console.WriteLine("Input.txt not found!" + fnf.Message);
            }
            catch(FileLoadException fle)
            {
                Console.WriteLine("Problem loading Input.txt " + fle.Message);
            }

            finally
            {
                sr.Close();
            }
            
            return path;
        }

        public static void WriteData(List<Point3D> path)
        {
            StreamWriter sw = new StreamWriter("../../OuputPath.txt");

            try
            {
                using (sw)
                {
                    foreach (Point3D point in path)
                    {
                        sw.WriteLine(point.ToString());
                    }
                }
            }

            catch(FileLoadException fle)
            {
                Console.WriteLine("Problem opening OutputPath.txt " + fle.Message);
            }

            finally
            {
                sw.Close();
            }
        }
    }
}
