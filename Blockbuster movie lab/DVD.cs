using System;
using System.Collections.Generic;
using System.Text;

namespace Blockbuster_movie_lab
{
    class DVD : Movie
    {
        public DVD (string Title, Genre Category, int RunTime, List<string> Scenes) : base(Title, Category, RunTime, Scenes)
        {

        }

        
        public override void Play()
        {
            while (true)
            {
                Console.WriteLine("What scene would you like to watch? Please pick a number");
                PrintScenes();
                int sceneNumber = int.Parse(Console.ReadLine());
                if (sceneNumber < Scenes.Count)
                {
                    Console.WriteLine(Scenes[sceneNumber]);
                    break;
                }
                else
                {
                    Console.WriteLine("Scene number is not valid. Please enter a valid number");
                    continue;
                }
            }
        }

        public override void PlayWholeMovie()
        {
            foreach (string s in Scenes)
            {
                Console.WriteLine(s);
            }
        }

    }
}
