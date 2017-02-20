using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeII
{
    public class Wall:GameObject
    {
        public Wall()
        {
            this.sign = '#';
        }
        public void Generate()
        {
            this.points.Add(new Point(2, 3));
            this.points.Add(new Point(2, 31));
            this.points.Add(new Point(23, 3));
            this.points.Add(new Point(2, 35));
        }
    }
}
