// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System.Drawing;
using Silk.NET.Windowing.Common;

namespace Silk.NET.Windowing
{
    public class WindowBuilder
    {
        private WindowOptions _options = new WindowOptions(true, true, new Point(-1, -1),
            new Size(1280, 720), 0.0, 0.0, GraphicsAPI.Default,
            "Silk.NET Window", WindowState.Normal, WindowBorder.Resizable, VSyncMode.On, 5);

        public WindowBuilder WithVisibility(bool visible)
        {
            _options.IsVisible = visible;
            return this;
        }

        public WindowBuilder WithSingleThread(bool singleThreaded)
        {
            _options.UseSingleThreadedWindow = singleThreaded;
            return this;
        }

        public WindowBuilder WithPosition(Point position)
        {
            _options.Position = position;
            return this;
        }

        public WindowBuilder WithSize(Size size)
        {
            _options.Size = size;
            return this;
        }

        public WindowBuilder WithFramesPerSecond(double fps)
        {
            _options.FramesPerSecond = fps;
            return this;
        }

        public WindowBuilder WithUpdatesPerSecond(double ups)
        {
            _options.UpdatesPerSecond = ups;
            return this;
        }

        public WindowBuilder WithAPI(GraphicsAPI api)
        {
            _options.API = api;
            return this;
        }

        public WindowBuilder WithTitle(string title)
        {
            _options.Title = title;
            return this;
        }

        public WindowBuilder WithState(WindowState state)
        {
            _options.WindowState = state;
            return this;
        }

        public WindowBuilder WithBorder(WindowBorder border)
        {
            _options.WindowBorder = border;
            return this;
        }

        public WindowBuilder WithVSync(VSyncMode mode)
        {
            _options.VSync = mode;
            return this;
        }

        public WindowBuilder WithRunningSlowTolerance(int tolerance)
        {
            _options.RunningSlowTolerance = tolerance;
            return this;
        }

        public IWindow Build()
        {
            return Window.Create(_options);
        }
    }
}
