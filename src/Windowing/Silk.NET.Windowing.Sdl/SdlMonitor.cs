// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using System.Collections.Generic;
using System.Drawing;
using Silk.NET.SDL;

namespace Silk.NET.Windowing.Sdl
{
    internal struct SdlMonitor : IMonitor
    {
        public SdlMonitor(int i) => Index = i;
        public IWindow CreateWindow(WindowOptions opts) => new SdlWindow(opts, null, this);

        public string Name => SdlProvider.SDL.Value.GetDisplayNameS(Index);
        public int Index { get; }

        public unsafe Rectangle Bounds
        {
            get
            {
                Rectangle ret;
                SdlProvider.SDL.Value.GetDisplayUsableBounds(Index, (Rect*) &ret);
                return ret;
            }
        }

        public unsafe VideoMode VideoMode
        {
            get
            {
                DisplayMode mode;
                SdlProvider.SDL.Value.GetCurrentDisplayMode(Index, &mode);
                return new VideoMode(new Size(mode.W, mode.H), mode.RefreshRate);
            }
        }

        public float Gamma
        {
            get => 1;
            set { }
        }

        public unsafe IEnumerable<VideoMode> GetAllVideoModes()
        {
            var sdl = SdlProvider.SDL.Value;
            var ret = new VideoMode[sdl.GetNumDisplayModes(Index)];
            for (var i = 0; i < ret.Length; i++)
            {
                DisplayMode mode;
                sdl.GetDisplayMode(Index, i, &mode);
                ret[i] = new VideoMode(new Size(mode.W, mode.H), mode.RefreshRate);
            }

            return ret;
        }
    }
}
