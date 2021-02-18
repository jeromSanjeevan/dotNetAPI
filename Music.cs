using System;
using System.IO;

namespace dotNetMVCApp
{
    public class Music
    {
        public string NotAfraid { get; set;}

        public string RiseUp { get; set;}

        public string AllTheStars { get; set;}

        public Music()
        {
            if (File.Exists("NotAfraid.txt"))
            {
                NotAfraid = File.ReadAllText("NotAfraid.txt");
            }
            else
            {
                NotAfraid = "??";
            }

            if (File.Exists("RiseUp.txt"))
            {
                RiseUp = File.ReadAllText("RiseUp.txt");
            }
            else
            {
                RiseUp = "??";
            }
            if (File.Exists("AllTheStars.txt"))
            {
                AllTheStars = File.ReadAllText("AllTheStars.txt");
            }
            else
            {
                AllTheStars = "??";
            }
        }
    }
}
