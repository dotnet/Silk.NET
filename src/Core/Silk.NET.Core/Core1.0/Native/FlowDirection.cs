// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

namespace Silk.NET.Core.Native
{
    /// <summary>
    /// How the parameter should flow - in or out?
    /// </summary>
    public enum FlowDirection
    {
        /// <summary>
        /// The flow direction is undefined.
        /// </summary>
        Undefined = 0,

        /// <summary>
        /// An input parameter.
        /// </summary>
        In = 1,

        /// <summary>
        /// An output parameter.
        /// </summary>
        Out = 2
    }
}
