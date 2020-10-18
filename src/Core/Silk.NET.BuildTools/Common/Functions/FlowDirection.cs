// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

namespace Silk.NET.BuildTools.Common.Functions
{
    /// <summary>
    /// Enumerates the possible flows of a parameter (ie. is this parameter
    /// used as input or as output?).
    /// </summary>
    public enum FlowDirection
    {
        /// <summary>
        /// No defined flow.
        /// </summary>
        Undefined = 0,

        /// <summary>
        /// Input parameter.
        /// </summary>
        In,

        /// <summary>
        /// Output parameter, typically decorated with the out keyword.
        /// </summary>
        Out,

        /// <summary>
        /// Both an input and output parameter.
        /// </summary>
        Ref
    }
}
