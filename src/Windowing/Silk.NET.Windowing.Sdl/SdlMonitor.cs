// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System.Collections.Generic;
using System.Drawing;

namespace Silk.NET.Windowing.Sdl
{
    public class SdlMonitor : IMonitor
    {
        public SdlMonitor(int i)
        {
            throw new System.NotImplementedException();
        }

        public IWindow CreateWindow(WindowOptions opts)
        {
            throw new System.NotImplementedException();
        }

        public string Name { get; }
        public int Index { get; }
        public Rectangle Bounds { get; }
        public VideoMode VideoMode { get; }
        public float Gamma { get; set; }
        public IEnumerable<VideoMode> GetAllVideoModes()
        {
            throw new System.NotImplementedException();
        }
    }
}
