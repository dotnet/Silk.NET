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
    public interface IWindow : IWindowProperties, IWindowFunctions, IWindowEvents
    {
        /// <summary>
        /// A handle to the underlying window.
        /// </summary>
        IntPtr Handle { get; }
        
        /// <summary>
        /// If true, the window has failed to reach the target framerate for five consecutive frames. You can use this
        /// to do things such as lowering visual fidelity to increase framerates on lower-end machines.
        /// </summary>
        bool IsRunningSlowly { get; }
    }
}