using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace SWCL
{
    public static class IWaferComponentExtension
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
    }
}
