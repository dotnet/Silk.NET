// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System.Collections.Generic;
using System.Drawing;
using Silk.NET.GLFW;
using Silk.NET.Windowing.Common;
using VideoMode = Silk.NET.Windowing.Common.VideoMode;

namespace Silk.NET.Windowing.Desktop
{
    internal unsafe class GlfwMonitor : IMonitor
    {
        private float _gamma = 1.0f;

        public Monitor* Handle { get; }

        public GlfwMonitor(Monitor* monitor, int index)
        {
            Handle = monitor;
            Index = index;
        }

        public IWindow CreateWindow(WindowOptions opts)
        {
            if (opts.WindowState == WindowState.Fullscreen)
            {
                return new GlfwWindow(opts, null, this);
            }

            opts.Position = new Point(opts.Position.X + Bounds.X, opts.Position.Y + Bounds.Y);
            return new GlfwWindow(opts, null, null);
        }

        public string Name => GlfwProvider.GLFW.Value.GetMonitorName(Handle);
        public int Index { get; }

        public Rectangle Bounds
        {
            get
            {
                GlfwProvider.GLFW.Value.GetMonitorWorkarea(Handle, out var x, out var y, out var w, out var h);
                return new Rectangle(x, y, w, h);
            }
        }

        public VideoMode VideoMode
        {
            get
            {
                var videoMode = GlfwProvider.GLFW.Value.GetVideoMode(Handle);
                return new VideoMode(
                    new Size(videoMode->Width, videoMode->Height),
                    videoMode->RefreshRate
                );
            }
        }

        public float Gamma
        {
            get => _gamma;
            set
            {
                _gamma = value;
                GlfwProvider.GLFW.Value.SetGamma(Handle, value);
            }
        }

        public IEnumerable<VideoMode> GetAllVideoModes()
        {
            var rawVideoModes = GlfwProvider.GLFW.Value.GetVideoModes(Handle, out var count);

            var videoModes = new List<VideoMode>();

            for (var i = 0; i < count; i++)
            {
                videoModes.Add(new VideoMode(new Size(rawVideoModes[i].Width, rawVideoModes[i].Height), rawVideoModes[i].RefreshRate));
            }

            return videoModes;
        }
    }
}
