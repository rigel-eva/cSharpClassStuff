using System;
using System.Collections.Generic;
using System.IO;
public class testCaseLoader
{
    public static bool[,]load(string fileName, char boolTrue='1')
    {
        string line;
        List<string> fileContents= new List<string>();
        int maxLength = 0;
        bool[,] returner;
        StreamReader file = new StreamReader(fileName);//Note: we are going to allow this to fail if something goes a bit wonky, it's not our job.
        for(int i=0; (line=file.ReadLine())!=null; i++)
        {
            fileContents.Add(line);
            maxLength = Math.Max(maxLength, line.Length);
        }
        returner = new bool[fileContents.Count,maxLength];
        Console.WriteLine(returner.GetLength(1));
        for(int i=0; i<(returner.GetLength(0)); i++)
        {
            for(int j=0; j<returner.GetLength(1); j++)
            {
                returner[i,j] = j < fileContents[i].Length&&fileContents[i][j]==boolTrue;
            }
        }
        return returner;
    }
}
