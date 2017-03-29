using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WarGame7
{
    public abstract class AbstractUnit
    {
        public int Life
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public int PercentageBuilt
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public int PercentagePerTurn
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public List<Resource> Cost
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }
    }
}
