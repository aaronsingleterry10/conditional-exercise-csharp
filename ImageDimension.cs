using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalExercise
{
    class ImageDimension
    {
        public int width;
        public int height;

        public string pageOrientation()
        {
            if (this.height >= this.width)
            {
                return "Portrait";
            }
            else
            {
                return "Landscape";
            }
        }
    }
}
