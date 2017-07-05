using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaper
{
    class Player
    {
        public string Name { set; get; }
        public int Points { set; get; }
        public Choice PlayerChoice { set; get; }
      

        public Player()
        {
            this.Name = "";
            this.Points = 0;

        }
    }

}
