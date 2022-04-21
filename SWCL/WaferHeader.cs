using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace SWCL
{
    /// <summary>
    /// DEVICE:xxx identification assigned by originator
    /// LOT:xxx identification assigned by originator
    /// WAFER:xxx identification assigned by originator
    /// FNLOC:180         wafer flat position(0=TOP,90=RIGHT,180=BOT 270=LEFT)
    /// ROWCT:62          number of rows
    /// COLCT:63          number of columns
    /// BCEQU:01          List of Bin Codes that are good die(comma or space delimited)
    /// REFPX:            x-coord of reference die(optional)
    /// REFPY:            y-coord of reference die(optional)
    /// DUTMS:mm die units of measurement(mm or mil)
    /// DIECT:3405        the number of die in the map file(optional)
    /// XDIES:2.945       step along X
    /// YDIES:2.945       step along Y
    /// COMMENT: sample a string used to annotate the file(optional)
    /// </summary>
    public struct WaferHeader
    {
        public string Device { get; set; }

        public string Lot { get; set; }

        public string Name { get; set; }

        public int FlatPosition { get; set; }

        public int NumberOfRows { get; set; }

        public int NumberOfColumns { get; set; }

        public SizeF DieSize { get; set; }

        public SizeF DieOffset { get; set; }

        public PointF WaferOrigin { get; set; }

        public float WaferMargin { get; set; }

        public float WaferDiameter { get; set; }
    }
}
