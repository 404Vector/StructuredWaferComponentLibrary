using System;
using System.Collections.Generic;
using System.Text;

namespace SWCL
{
    public enum EmWaferComponentType
    {
        Unknown,
        Wafer,
        Die,
        Slice,
        Sector,
    }

    public enum EmDieComponentType
    {
        Pad,
        Pattern,
        Bump,
    }
}
