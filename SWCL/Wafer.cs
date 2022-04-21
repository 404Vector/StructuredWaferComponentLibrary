using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace SWCL
{
    public sealed class Wafer : IWaferComponent
    {
        #region Field

        private static EmWaferComponentType areaType = EmWaferComponentType.Wafer;

        private RectangleF area = RectangleF.Empty;

        #endregion

        #region Property


        public EmWaferComponentType AreaType => areaType;

        public RectangleF Area => area;

        #endregion

        #region Method

        #endregion

        /// <summary>
        /// 
        /// </summary>
        /// <param name="diameter">unit : um</param>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public Wafer(float diameter = 300000)
        {
            if(!(diameter > 0)) { throw new ArgumentOutOfRangeException("diameter > 0"); }
            area = new RectangleF(new PointF(0, 0), new SizeF(diameter, diameter));
        }
    }
}
