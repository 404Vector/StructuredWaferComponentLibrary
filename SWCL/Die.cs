using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace SWCL
{
    public struct Die : IWaferComponent
    {
        #region Field

        private static EmWaferComponentType areaType = EmWaferComponentType.Die;

        private readonly int id;
        private readonly char symbolCode;
        private readonly RectangleF area;
        private readonly Wafer parentWafer;

        #endregion

        #region Property

        public EmWaferComponentType AreaType => areaType;

        public RectangleF Area => area;

        public Wafer ParentWafer => parentWafer;

        public int ID => id;

        public char SymbolCode => symbolCode;

        #endregion

        #region Method

        #endregion

        public Die(Wafer wafer, RectangleF rectangle, int id = -1, char symbol = '.')
        {
            this.parentWafer = wafer;
            this.area = rectangle;
            this.id = id;
            this.symbolCode = symbol;
        }
    }
}
