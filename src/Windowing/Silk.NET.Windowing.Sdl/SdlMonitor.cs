// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;
using Silk.NET.Core.Native;
using Silk.NET.Maths;
using Silk.NET.SDL;

namespace Silk.NET.Windowing.Sdl
{
    internal struct SdlMonitor : IMonitor
    {
        private readonly SdlPlatform _platform;

        public SdlMonitor(SdlPlatform platform, int i)
        {
            _platform = platform;
            Index = i;
        }

        public IWindow CreateWindow(WindowOptions opts) => new SdlWindow(opts, null, this, _platform);

        public unsafe string Name => SilkMarshal.PtrToString((nint) SdlProvider.SDL.Value.GetDisplayName(Index))!;
        public int Index { get; }

        public unsafe Rectangle<int> Bounds
        {
            get
            {
                Rectangle<int> ret;
                SdlProvider.SDL.Value.GetDisplayUsableBounds(Index, &ret);
                return ret;
            }
        }

        public unsafe VideoMode VideoMode
        {
            get
            {
                DisplayMode mode;
                SdlProvider.SDL.Value.GetCurrentDisplayMode(Index, &mode);
                return new VideoMode(new Vector2D<int>(mode.W, mode.H), mode.RefreshRate);
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
                ret[i] = new VideoMode(new Vector2D<int>(mode.W, mode.H), mode.RefreshRate);
            }

            return ret;
        }
    }
}
