using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows;

namespace SWCL
{

    /// <summary>
    /// Unit : um
    /// </summary>
    public interface IWaferComponent
    {
        /// <summary>
        /// Type of this component
        /// </summary>
        EmWaferComponentType AreaType { get; }

        /// <summary>
        /// Area of this component on wafer
        /// </summary>
        RectangleF Area { get; }
    }
}
