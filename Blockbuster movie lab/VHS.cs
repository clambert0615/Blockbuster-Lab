using System;
using System.Collections.Generic;
using System.Text;

namespace Blockbuster_movie_lab
{
    class VHS : Movie
    {
        public int CurrentTime { get; set; } = 0;

        public VHS(string Title, Genre Category, int RunTime, List<string> Scenes) : base(Title, Category, RunTime, Scenes)
        {

        }
       
        
        

        public override void Play()
        {
            string scene = Scenes[CurrentTime];
            Console.WriteLine($"Since this is a VHS movie, the movie is starting at the last scene you left off at. \n Scene: {scene}");
            CurrentTime ++;
        }
        public void Rewind()
        {
            CurrentTime = 0;
        }

        public override void PlayWholeMovie()
        {
            foreach(string s in Scenes)
            {
                Console.WriteLine(s);
            }
        }
    }
}
