using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOD6_1302210106
{
    internal class SayaTubeUser
    {
        private int id;
        private List<SayaTubeVideo> uploadVideo;
        public String Username;
        
        public SayaTubeUser(String username)
        {
            this.Username = username;
            this.uploadVideo= new List<SayaTubeVideo>();
        }

        
        public int GetTotalVideoPlayCount()
        {
            int tot = 0;
            for(int i = 0; i <= uploadVideo.Count; i++)
            {
                tot += uploadVideo[i].getCount();
            }
            return tot;
        }

        public void AddVideo(SayaTubeVideo d)
        {
            uploadVideo.Add(d);
        }


        public void PrintAllVideoPlayCount()
        {
            Console.WriteLine(Username);
            for(int i =0; i <= uploadVideo.Count; i++)
            {
                Console.WriteLine("Video " +(i+1) + " judul" + uploadVideo[i].getTitle());
            }
        }
    }
}
