// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;

namespace Silk.NET.Core.Native
{
    /// <summary>
    /// Indicates that a P/Invoke override should be generated.
    /// </summary>
    /// <remarks>See SilkTouch documentation.</remarks>
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
    public class PInvokeOverride : Attribute
    {
        /// <summary>
        /// Initializes a new class of type <see cref="PinObjectAttribute" /> given the id and target.
        /// </summary>
        /// <param name="id">The Id this override is assigned. Assumed to be unique by SilkTouch.</param>
        /// <param name="target">The target which, only when true is the override code generated. The target has to be a single define, like the one used in <c>#if</c>, operators are not supported.</param>
        public PInvokeOverride(int id, string target)
        {
        }
    }
}
