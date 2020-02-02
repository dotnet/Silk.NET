// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System.Drawing;

namespace Silk.NET.Windowing.Common
{
    public interface IMonitor : IWindowHost
    {
        string Name { get; }
        int Index { get; }
        Rectangle Bounds { get; }
        VideoMode VideoMode { get; }
    }
}
