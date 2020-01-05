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
    public interface IWindow : IWindowProperties, IWindowEvents, IWindowHost, IView
    {
        // TODO maybe we could do a IsSubwindow => Parent is IWindow
        IWindowHost Parent { get; }
    }
}