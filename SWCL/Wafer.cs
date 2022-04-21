using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace SWCL
{
    public class Wafer : IWaferComponent
    {
        #region Field

        private static EmWaferComponentType areaType = EmWaferComponentType.Wafer;

        private readonly WaferHeader header;
        private readonly RectangleF area;
        private Die[,] dieList;

        #endregion

        #region Property

        public EmWaferComponentType AreaType => areaType;

        public RectangleF Area => area;

        public WaferHeader Header => header;

        public float WaferSize => header.WaferDiameter;

        public Die[,] DieList => dieList;

        #endregion

        #region Method

        #endregion

        public Wafer(WaferHeader header)
        {
            this.header = header;
            this.area = new RectangleF(header.WaferOrigin, new SizeF(header.WaferDiameter, header.WaferDiameter));
            RectangleF[,] dieAreas = header.CreateDieAreas();
            dieList = dieAreas.CreateDie(this);
        }
    }
}
