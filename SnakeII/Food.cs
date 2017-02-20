using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeII
{
    public class Food : GameObject
    {
        public Food()
        {
            this.sign = '$';
        }
        public void Generate()
        {
            this.points.Add(new Point(20, 13));
        }
    }
}
