using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WarGame7
{
    public class Game
    {
        private Map map;
        private List<Player> players;

        public Map Map
        {
            get
            {
                return map;
            }

            set
            {
                map = value;
            }
        }

        public List<Player> Players
        {
            get
            {
                return players;
            }

            set
            {
                players = value;
            }
        }


        //public Map Map
        //{
        //    get
        //    {
        //        throw new System.NotImplementedException();
        //    }
        //    set
        //    {
        //    }
        //}

        //public List<Player> Players
        //{
        //    get
        //    {
        //        throw new System.NotImplementedException();
        //    }
        //    set
        //    {
        //    }
        //}

        public void Play()
        {
            throw new System.NotImplementedException();
        }

        public void Load(string filePath)
        {
            throw new System.NotImplementedException();
        }

        public void Save(string filePath)
        {
            throw new System.NotImplementedException();
        }

        public void AddPlayer()
        {

            Player myplayer = new Player();
            myplayer.Name = Console.ReadLine();
            Players.Add(myplayer);

        }
    }
}
