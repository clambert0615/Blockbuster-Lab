using System;
using System.Collections.Generic;
using System.Text;

namespace Blockbuster_movie_lab
{
   abstract class Movie
    {
        // properties
        public string Title { get; set; }
        public Genre Category { get; set; }
        public int RunTime { get; set; }
        public List<string> Scenes { get; set; }

        

        //enum
        public enum Genre { Drama, Comedy, Horror, Romance, Action }

        // constructor
        public Movie(string Title, Genre Category, int RunTime, List<string> Scenes)
        {
            this.Title = Title;
            this.Category = Category;
            this.RunTime = RunTime;
            this.Scenes = Scenes;
        }
        //list
      //public List<string> scenes = new List<string>();

        //methods
        public virtual string PrintInfo()
        {
            return ($"Title: {Title} \nCategory: {Category} \nRuntime: {RunTime}");
        }

        public void PrintScenes()
        {
            int counter = 0;
           foreach(var scene in Scenes)
            {
                Console.WriteLine($"{counter} : {scene}");
                counter++;
            }
        }

        public abstract void Play();

        public abstract void PlayWholeMovie();
        
    }
}
