// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;

namespace Silk.NET.OpenAL.Extensions.Soft
{
    /// <summary>
    /// A list of valid <see cref="IntPtr" /> <see cref="IStateSoft.GetPointer" /> parameters.
    /// </summary>
    public enum StatePointer
    {
        /// <summary>
        /// Gets a pointer to the set event callback function.
        /// </summary>
        EventCallbackFunction = 0x1220,

        /// <summary>
        /// Gets a pointer to the set event callback user parameter.
        /// </summary>
        EventCallbackUserParameter = 0x1221
    }
}