﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _18.TheaThePhotographer
{
    class Program
    {
        static void Main(string[] args)
        {
            int countPictures = int.Parse(Console.ReadLine());
            int filterTimeForOnePicture = int.Parse(Console.ReadLine());
            int filterFactor = int.Parse(Console.ReadLine());
            int uploadTime = int.Parse(Console.ReadLine());

            double filterPicture = Math.Ceiling(countPictures * (filterFactor / 100.0));
            double firstAnswer = (double)countPictures * filterTimeForOnePicture;
            double secondAnswer = (double)filterPicture * uploadTime;
            double answer = (double)(firstAnswer + secondAnswer);

            TimeSpan time = TimeSpan.FromSeconds(answer);
            string str = time.ToString(@"d\:hh\:mm\:ss");
            Console.WriteLine(str);
        }
    }
}
/*
1000
1
50
1
*/