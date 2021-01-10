// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using Silk.NET.Core.Contexts;
using Silk.NET.Maths;
using Silk.NET.Windowing;

namespace Silk.NET.Jupyter
{
    public class JupyterView : IView
    {
        private readonly IGLContext _glContext;

        public static IView Create(int height, int width)
        {
            return new JupyterView(height, width);
        }

        private JupyterView(int height, int width)
        {
            _glContext = new JupyterGLContext(this);
            
        }

        public bool ShouldSwapAutomatically => throw new NotImplementedException();

        public bool IsEventDriven
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }

        public Vector2D<int> Size => throw new NotImplementedException();

        public double FramesPerSecond
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }

        public double UpdatesPerSecond
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }

        public GraphicsAPI API => throw new NotImplementedException();

        public bool VSync
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }

        public VideoMode VideoMode => throw new NotImplementedException();
        public int? PreferredDepthBufferBits => throw new NotImplementedException();
        public int? PreferredStencilBufferBits => throw new NotImplementedException();
        public Vector4D<int>? PreferredBitDepth => throw new NotImplementedException();

        public IGLContext? GLContext => _glContext;

        public IVkSurface? VkSurface => throw new NotImplementedException();

        public void Dispose()
        {
            _glContext.Dispose();
        }

        public nint Handle => throw new NotImplementedException();
        public bool IsClosing => throw new NotImplementedException();
        public double Time => throw new NotImplementedException();
        public Vector2D<int> FramebufferSize => throw new NotImplementedException();
        public event Action<Vector2D<int>>? Resize;
        public event Action<Vector2D<int>>? FramebufferResize;
        public event Action? Closing;
        public event Action<bool>? FocusChanged;
        public event Action? Load;
        public event Action<double>? Update;
        public event Action<double>? Render;

        public void Initialize()
        {
            throw new NotImplementedException();
        }

        public void DoRender()
        {
            Render?.Invoke(0.0);
        }

        public void DoUpdate()
        {
            throw new NotImplementedException();
        }

        public void DoEvents()
        {
            throw new NotImplementedException();
        }

        public void ContinueEvents()
        {
            throw new NotImplementedException();
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }

        public void Close()
        {
            throw new NotImplementedException();
        }

        public Vector2D<int> PointToClient(Vector2D<int> point)
        {
            throw new NotImplementedException();
        }

        public Vector2D<int> PointToScreen(Vector2D<int> point)
        {
            throw new NotImplementedException();
        }

        public Vector2D<int> PointToFramebuffer(Vector2D<int> point)
        {
            throw new NotImplementedException();
        }

        public object Invoke(Delegate d, params object[] args)
        {
            throw new NotImplementedException();
        }

        public void Run(Action onFrame)
        {
            throw new NotImplementedException();
        }
    }
}
