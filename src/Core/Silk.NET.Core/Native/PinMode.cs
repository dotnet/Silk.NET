// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

namespace Silk.NET.Core.Native
{
    /// <summary>
    /// Indicates the way a pin is made.
    /// </summary>
    /// <seealso cref="PinObjectAttribute" />
    public enum PinMode
    {
        /// <summary>
        ///  Pin until specifically released.
        /// </summary>
        Persist,
        /// <summary>
        /// Pin until the next call.
        /// </summary>
        UntilNextCall
    }
}
