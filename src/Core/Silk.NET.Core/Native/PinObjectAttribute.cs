// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;

namespace Silk.NET.Core.Native
{
    /// <summary>
    /// Indicates that the parameter or return value should be pinned in some way, indicated by <see cref="PinMode"/>
    /// </summary>
    /// <seealso cref="PinMode" />
    /// <remarks>See SilkTouch documentation.</remarks>
    [AttributeUsage(AttributeTargets.Parameter | AttributeTargets.ReturnValue)]
    public class PinObjectAttribute : Attribute
    {
        /// <summary>
        /// Initializes a new class of type <see cref="PinObjectAttribute" /> using the given mode, defaulting to Persist.
        /// </summary>
        /// <param name="mode"></param>
        public PinObjectAttribute(PinMode mode = PinMode.Persist)
        {
            Mode = mode;
        }

        /// <summary>
        /// The mode used by this pin.
        /// </summary>
        public PinMode Mode { get; }
    }
}
