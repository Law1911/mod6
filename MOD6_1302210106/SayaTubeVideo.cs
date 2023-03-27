using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;

namespace MOD6_1302210106
{
    internal class SayaTubeVideo
    {
        private int id;
        private string title;
        private int playCount;

        public SayaTubeVideo(String title)
        {
            this.title = title;
            var a = this.title.Substring(0, Math.Min(100, this.title.Length));

            String digit = "";
            Random random  = new Random();
            id = random.Next(1,99999);
            digit += id.ToString("Digit 5");
            playCount = 0;
        }

        public void IncreasePlayCount(int x)
        {
            playCount = playCount+ x;
        }

        public void PrintVideoDetails()
        {
            Console.WriteLine("ID :" + id);
            Console.WriteLine("Title :" + title);
            Console.WriteLine("PlayCount : " + playCount);
        }
    }
}
