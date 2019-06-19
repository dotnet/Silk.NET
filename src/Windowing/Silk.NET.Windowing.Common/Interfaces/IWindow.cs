// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;

namespace Silk.NET.Windowing.Common
{
    /// <summary>
    /// An interface representing a window.
    /// </summary>
    public interface IWindow : IWindowProperties, IWindowFunctions, IWindowVirtualFunctions
    {
        /// <summary>
        /// A handle to the underlying window.
        /// </summary>
        IntPtr Handle { get; }
    }
}