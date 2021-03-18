// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Collections.Generic;
using Silk.NET.GLFW;
using Silk.NET.Maths;
using VideoMode = Silk.NET.Windowing.VideoMode;
using NativeMonitor = Silk.NET.GLFW.Monitor;

namespace Silk.NET.Windowing.Glfw
{
    internal unsafe class GlfwMonitor : IMonitor
    {
        private float _gamma = 1.0f;

        public NativeMonitor* Handle { get; }

        public GlfwMonitor(NativeMonitor* monitor, int index)
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

            opts.Position = new Vector2D<int>(opts.Position.X + Bounds.Origin.X, opts.Position.Y + Bounds.Origin.Y);
            return new GlfwWindow(opts, null, null);
        }

        public string Name => GlfwProvider.GLFW.Value.GetMonitorName(Handle);
        public int Index { get; }

        public Rectangle<int> Bounds
        {
            get
            {
                GlfwProvider.GLFW.Value.GetMonitorWorkarea(Handle, out var x, out var y, out var w, out var h);
                return new Rectangle<int>(new(x, y), new(w, h));
            }
        }

        public VideoMode VideoMode
        {
            get
            {
                var videoMode = GlfwProvider.GLFW.Value.GetVideoMode(Handle);
                return new VideoMode
                (
                    new Vector2D<int>(videoMode->Width, videoMode->Height),
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
                videoModes.Add
                (
                    new VideoMode
                        (new Vector2D<int>(rawVideoModes[i].Width, rawVideoModes[i].Height), rawVideoModes[i].RefreshRate)
                );
            }

            return videoModes;
        }
    }
}
