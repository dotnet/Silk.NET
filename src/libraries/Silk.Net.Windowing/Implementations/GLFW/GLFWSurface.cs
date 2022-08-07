// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
using System;
using System.Collections.Generic;
using Silk.NET.Core;
using Silk.NET.Maths;

namespace Silk.NET.Windowing.Implementations.GLFW
{
    /// <summary>
    /// A Desktop surface backed by GLFW
    /// </summary>
    public class GLFWSurface : IGLTransparentFramebuffer, IGlesDesktopSurface, IVkDesktopSurface, IGLDesktopSurface
    {
        private IGlesSurface? _sharedContext;
        private IGLSurface? _sharedContext1;

        
        /// <summary>
        ///  <inheritdoc/>
        /// </summary>
        public WindowHandles Native { get; }
        
        /// <summary>
        ///  <inheritdoc/>
        /// </summary>
        public void Dispose()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        ///  <inheritdoc/>
        /// </summary>
        public bool IsTerminating { get; }
        
        /// <summary>
        ///  <inheritdoc/>
        /// </summary>
        public bool IsPausing { get; }

        /// <summary>
        ///  <inheritdoc/>
        /// </summary>
        public double Time { get; }
        
        /// <summary>
        ///  <inheritdoc/>
        /// </summary>
        public Vector2D<int> FramebufferSize { get; }
        
        /// <summary>
        ///  <inheritdoc/>
        /// </summary>
        public bool IsVisible { get; set; }
        
        /// <summary>
        ///  <inheritdoc/>
        /// </summary>
        public Vector2D<int> Position { get; set; }
        
        /// <summary>
        ///  <inheritdoc/>
        /// </summary>
        public Vector2D<int> Size { get; set; }
        
        /// <summary>
        ///  <inheritdoc/>
        /// </summary>
        public string Title { get; set; } = null!;

        /// <summary>
        ///  <inheritdoc/>
        /// </summary>
        public WindowState WindowState { get; set; }
        
        /// <summary>
        ///  <inheritdoc/>
        /// </summary>
        public WindowBorder WindowBorder { get; set; }
        
        /// <summary>
        ///  <inheritdoc/>
        /// </summary>
        public VideoMode VideoMode { get; set; }
        
        /// <summary>
        ///  <inheritdoc/>
        /// </summary>
        public IScreen? CurrentScreen { get; set; }
        
        /// <summary>
        ///  <inheritdoc/>
        /// </summary>
        public IEnumerable<IScreen>? AvailableScreens { get; }
        
        /// <summary>
        ///  <inheritdoc/>
        /// </summary>
        public bool IsEventDriven { get; set; }
        
        /// <summary>
        ///  <inheritdoc/>
        /// </summary>
        public bool IsCloseRequested { get; set; }
        
        /// <summary>
        ///  <inheritdoc/>
        /// </summary>
        public bool IsFocused { get; }
        
        /// <summary>
        ///  <inheritdoc/>
        /// </summary>
        public Rectangle<int> BorderSize { get; }
        
        /// <summary>
        ///  <inheritdoc/>
        /// </summary>
        public event Action? CloseRequested;
        
        /// <summary>
        ///  <inheritdoc/>
        /// </summary>
        public event Vector2DAction? Move;
        
        /// <summary>
        ///  <inheritdoc/>
        /// </summary>
        public event WindowStateAction? StateChanged;
        
        /// <summary>
        ///  <inheritdoc/>
        /// </summary>
        public event FilePathsAction? FileDrop;
        
        /// <summary>
        ///  <inheritdoc/>
        /// </summary>
        public event ToggleAction? FocusChanged;
        
        /// <summary>
        ///  <inheritdoc/>
        /// </summary>
        public void SetWindowIcon(ReadOnlySpan<RawImage> icons)
        {
            throw new NotImplementedException();
        }
        
        /// <summary>
        ///  <inheritdoc/>
        /// </summary>
        public void ContinueEvents()
        {
            throw new NotImplementedException();
        }
        
        /// <summary>
        ///  <inheritdoc/>
        /// </summary>
        public Vector2D<int> PointToClient(Vector2D<int> point)
        {
            throw new NotImplementedException();
        }
        
        /// <summary>
        ///  <inheritdoc/>
        /// </summary>
        public Vector2D<int> PointToScreen(Vector2D<int> point)
        {
            throw new NotImplementedException();
        }

        
        /// <summary>
        ///  <inheritdoc/>
        /// </summary>
        public double FramesPerSecond { get; set; }
        
        /// <summary>
        ///  <inheritdoc/>
        /// </summary>
        public double UpdatesPerSecond { get; set; }
        
        /// <summary>
        ///  <inheritdoc/>
        /// </summary>
        public event Vector2DAction? Resize;
        
        /// <summary>
        ///  <inheritdoc/>
        /// </summary>
        public event Vector2DAction? FramebufferResize;
        
        /// <summary>
        ///  <inheritdoc/>
        /// </summary>
        public event Action? Terminating;
        
        /// <summary>
        ///  <inheritdoc/>
        /// </summary>
        public event Action? LowMemory;
        
        /// <summary>
        ///  <inheritdoc/>
        /// </summary>
        public event Action? Pausing;
        
        /// <summary>
        ///  <inheritdoc/>
        /// </summary>
        public event Action? Resuming;
        
        /// <summary>
        ///  <inheritdoc/>
        /// </summary>
        public event Action? Created;
        
        /// <summary>
        ///  <inheritdoc/>
        /// </summary>
        public event Action? PreUpdate;
        
        /// <summary>
        ///  <inheritdoc/>
        /// </summary>
        public event DeltaAction? Update;
        
        /// <summary>
        ///  <inheritdoc/>
        /// </summary>
        public event DeltaAction? Render;
        
        /// <summary>
        ///  <inheritdoc/>
        /// </summary>
        public void Initialize()
        {
            throw new NotImplementedException();
        }
        
        /// <summary>
        ///  <inheritdoc/>
        /// </summary>
        public void DoRender()
        {
            throw new NotImplementedException();
        }
        
        /// <summary>
        ///  <inheritdoc/>
        /// </summary>
        public void DoUpdate()
        {
            throw new NotImplementedException();
        }
        
        /// <summary>
        ///  <inheritdoc/>
        /// </summary>
        public void DoEvents()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        ///  <inheritdoc/>
        /// </summary>
        public void Reset()
        {
            throw new NotImplementedException();
        }
        
        /// <summary>
        ///  <inheritdoc/>
        /// </summary>
        public void Terminate()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        ///  <inheritdoc/>
        /// </summary>
        public Vector2D<int> PointToFramebuffer(Vector2D<int> point)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        ///  <inheritdoc/>
        /// </summary>
        public void Run(Action onFrame)
        {
            throw new NotImplementedException();
        }
        
        /// <summary>
        ///  <inheritdoc/>
        /// </summary>
        public nint Handle { get; }
        
        /// <summary>
        ///  <inheritdoc/>
        /// </summary>
        public bool IsContextCurrent { get; set; }
        
        /// <summary>
        ///  <inheritdoc/>
        /// </summary>
        public bool ShouldSwapAutomatically { get; set; }
        
        /// <summary>
        ///  <inheritdoc/>
        /// </summary>
        public int SwapInterval { get; set; }
        
        /// <summary>
        ///  <inheritdoc/>
        /// </summary>
        public int? PreferredDepthBufferBits { get; set; }
        
        /// <summary>
        ///  <inheritdoc/>
        /// </summary>
        public int? PreferredStencilBufferBits { get; set; }
        
        /// <summary>
        ///  <inheritdoc/>
        /// </summary>
        public Vector4D<int>? PreferredBitDepth { get; set; }
        
        /// <summary>
        ///  <inheritdoc/>
        /// </summary>
        public Version32? ApiVersion { get; set; }
        
        /// <summary>
        ///  <inheritdoc/>
        /// </summary>
        public nint? GetProcAddress(string proc)
        {
            throw new NotImplementedException();
        }
        
        /// <summary>
        ///  <inheritdoc/>
        /// </summary>
        public void SwapBuffers()
        {
            throw new NotImplementedException();
        }
        
        /// <summary>
        ///  <inheritdoc/>
        /// </summary>
        public bool TransparentFramebuffer { get; set; }
        
        
        /// <summary>
        ///  <inheritdoc/>
        /// </summary>
        public ContextFlags ContextFlags { get; set; }
        
        
        /// <summary>
        ///  <inheritdoc/>
        /// </summary>
        public ContextProfile ContextProfile { get; set; }
        
        /// <summary>
        ///  <inheritdoc/>
        /// </summary>
        IGLSurface? IGLSurface.SharedContext
        {
            get => _sharedContext1;
            set => _sharedContext1 = value;
        }
        
        /// <summary>
        ///  <inheritdoc/>
        /// </summary>
        public bool TryEnableOpenGL()
        {
            throw new NotImplementedException();
        }

        
        /// <summary>
        ///  <inheritdoc/>
        /// </summary>
        IGlesSurface? IGlesSurface.SharedContext
        {
            get => _sharedContext;
            set => _sharedContext = value;
        }

        
        /// <summary>
        ///  <inheritdoc/>
        /// </summary>
        public bool TryEnableOpenGLES()
        {
            throw new NotImplementedException();
        }

        
        /// <summary>
        ///  <inheritdoc/>
        /// </summary>
        public bool TryEnableVulkan()
        {
            throw new NotImplementedException();
        }

        
        /// <summary>
        ///  <inheritdoc/>
        /// </summary>
        public unsafe ulong Create(nint instance, void* allocator)
        {
            throw new NotImplementedException();
        }

        
        /// <summary>
        ///  <inheritdoc/>
        /// </summary>
        public unsafe byte** GetRequiredExtensions(out uint count)
        {
            throw new NotImplementedException();
        }
    }
}
