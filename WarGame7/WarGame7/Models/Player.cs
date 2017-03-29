using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WarGame7
{
    public class Player
    {
        private string name;
        //private Inventory inventory;

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        //public Inventory Inventory
        //{
        //    get
        //    {
        //        return inventory;
        //    }

        //    set
        //    {
        //        inventory = value;
        //    }
        //}

        //public string Name
        //{
        //    get
        //    {
        //        return name;
        //    }
        //    set
        //    { 

        //    }
        //}

        //public Inventory Inventory
        //{
        //    get
        //    {
        //        throw new System.NotImplementedException();
        //    }
        //    set
        //    {
        //    }
        //}

        public AbstractCommand GenerateCommand()
        {
            throw new System.NotImplementedException();
        }

        
    }

}
