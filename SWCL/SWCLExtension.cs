using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace SWCL
{
    public static class SWCLExtension
    {

        public static RectangleF UnionAreas(this List<IWaferComponent> components)
        {
            if (components.Count == 0) { return RectangleF.Empty; }
            if (components.Count == 1) { return components[0].Area; }
            RectangleF rect = components[0].Area;
            for (int i = 1; i < components.Count; i++)
            {
                rect = RectangleF.Union(rect, components[i].Area);
            }
            return rect;
        }

        public static RectangleF[,] CreateDieAreas(this ref WaferHeader header)
        {
            //Todo
            throw new NotImplementedException();
        }

        public static Die[,] CreateDie(this RectangleF[,] rectangles, Wafer wafer)
        {
            int rows = rectangles.GetLength(0);
            int columns = rectangles.GetLength(1);
            Die[,] dies = new Die[rows, columns];
            for (int j = 0; j < rows; j++)
            {
                for (int i = 0; i < rectangles.Length; i++)
                {
                    dies[j, i] = new Die(wafer, rectangles[j, i]);
                }
            }
            return dies;
        }
    }
}
