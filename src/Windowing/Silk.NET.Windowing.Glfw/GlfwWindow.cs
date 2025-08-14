// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Core;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;
using Silk.NET.Core.Native;
using Silk.NET.GLFW;
using Silk.NET.Maths;
using Silk.NET.Windowing.Internals;

namespace Silk.NET.Windowing.Glfw
{
    internal unsafe class GlfwWindow : WindowImplementationBase, IVkSurface
    {
        internal readonly GLFW.Glfw _glfw;
        internal WindowHandle* _glfwWindow;

        // Callbacks
        private GlfwCallbacks.WindowPosCallback? _onMove;
        private GlfwCallbacks.WindowSizeCallback? _onResize;
        private GlfwCallbacks.FramebufferSizeCallback? _onFramebufferResize;
        private GlfwCallbacks.WindowRefreshCallback? _onRefresh;
        private GlfwCallbacks.DropCallback? _onFileDrop;
        private GlfwCallbacks.WindowCloseCallback? _onClosing;
        private GlfwCallbacks.WindowFocusCallback? _onFocusChanged;
        private GlfwCallbacks.WindowIconifyCallback? _onMinimized;
        private GlfwCallbacks.WindowMaximizeCallback? _onMaximized;
        
        // Other variables
        private readonly GlfwWindow? _parent;
        private readonly GlfwMonitor? _initialMonitor;
        private Vector2D<int> _nonFullscreenPosition;
        private Vector2D<int> _nonFullscreenSize;
        private string _localTitleCache; // glfw doesn't let us get the window title.
        private GlfwContext? _glContext;
        private string _windowClass;
        private bool _inRefresh;

        /// <summary>
        /// The action passed to <see cref="Run"/>.
        /// </summary>
        /// <remarks>
        /// May be called on repaint from within <see cref="DoEvents"/>.
        /// For example, during modal operations such as resizing on Windows.
        /// </remarks>
        protected Action? _onFrame;

        public GlfwWindow(WindowOptions optionsCache, GlfwWindow? parent, GlfwMonitor? monitor) : base(optionsCache)
        {
            _glfw = GlfwProvider.GLFW.Value;
            _parent = parent;
            _initialMonitor = monitor;
            _localTitleCache = optionsCache.Title;
            SharedContext = optionsCache.SharedContext;
        }

        protected override Vector2D<int> CoreSize
        {
            get
            {
                _glfw.GetWindowSize(_glfwWindow, out var width, out var height);
                return new(width, height);
            }
        }
        
        protected override Rectangle<int> CoreBorderSize
        {
            get
            {
                _glfw.GetWindowFrameSize(_glfwWindow, out var l, out var t, out var r, out var b);
                return new(new(l, t), new(r - l, b - t));
            }
        }

        protected override nint CoreHandle => (nint) _glfwWindow;

        public override void Run(Action onFrame)
        {
            try
            {
                _onFrame = onFrame;
                base.Run(onFrame);
            }
            finally
            {
                _onFrame = null;
            }
        }

        protected override void CoreReset()
        {
            if (_glfwWindow == null)
            {
                return;
            }

            try
            {
                _glfw.DestroyWindow(_glfwWindow);
                GLFW.Glfw.ThrowExceptions();
            }
            catch (GlfwException)
            {
                // If the window is already destroyed, it throws an exception,
                // but we want the window destroyed anyways, so just ignore it
            }
            finally
            {
                _glfwWindow = null;
                _glContext = null;
            }
        }

        protected override IGLContext? CoreGLContext => _glContext ??= new(_glfw, _glfwWindow, this);

        protected override IVkSurface? CoreVkSurface
        {
            get
            {
                if (!_glfw.VulkanSupported())
                {
                    static void Throw()
                        => throw new PlatformNotSupportedException("GLFW does not support Vulkan on this platform.");
                    Throw();
                }
                
                return this;
            }
        }

        protected override bool CoreIsVisible
        {
            get => _glfw.GetWindowAttrib(_glfwWindow, WindowAttributeGetter.Visible);
            set
            {
                if (value)
                {
                    _glfw.ShowWindow(_glfwWindow);
                }
                else
                {
                    _glfw.HideWindow(_glfwWindow);
                }
            }
        }

        protected override Vector2D<int> CorePosition
        {
            get
            {
                _glfw.GetWindowPos(_glfwWindow, out var x, out var y);
                return new(x, y);
            }
            set => _glfw.SetWindowPos(_glfwWindow, value.X, value.Y);
        }

        protected override string CoreTitle
        {
            get => _localTitleCache;
            set => _glfw.SetWindowTitle(_glfwWindow, _localTitleCache = value);
        }

        protected override WindowState CoreWindowState
        {
            get
            {
                if (_glfw.GetWindowAttrib(_glfwWindow, WindowAttributeGetter.Iconified))
                {
                    return WindowState.Minimized;
                }

                if (_glfw.GetWindowAttrib(_glfwWindow, WindowAttributeGetter.Maximized))
                {
                    return WindowState.Maximized;
                }

                if (_glfw.GetWindowMonitor(_glfwWindow) != null)
                {
                    return WindowState.Fullscreen;
                }

                return WindowState.Normal;
            }
            set
            {
                // if we're not fullscreen
                if (ExtendedOptionsCache.WindowState is not WindowState.Fullscreen)
                {
                    _nonFullscreenPosition = CorePosition;
                    _nonFullscreenSize = CoreSize;
                }
                
                // if we're fullscreen and going not fullscreen
                if (ExtendedOptionsCache.WindowState == WindowState.Fullscreen && value != WindowState.Fullscreen)
                {
                    _glfw.SetWindowMonitor
                    (
                        _glfwWindow, null,
                        _nonFullscreenPosition.X,
                        _nonFullscreenPosition.Y,
                        _nonFullscreenSize.X,
                        _nonFullscreenSize.Y,
                        0
                    );
                }

                switch (value)
                {
                    case WindowState.Normal:
                        _glfw.RestoreWindow(_glfwWindow);
                        break;
                    case WindowState.Minimized:
                        _glfw.IconifyWindow(_glfwWindow);
                        break;
                    case WindowState.Maximized:
                        _glfw.MaximizeWindow(_glfwWindow);
                        break;
                    case WindowState.Fullscreen:
                        var monitor = _glfw.GetPrimaryMonitor();
                        var mode = _glfw.GetVideoMode(monitor);
                        var videoMode = _optionsCache.VideoMode;
                        var resolution = videoMode.Resolution;
                        _glfw.SetWindowMonitor
                        (
                            _glfwWindow, monitor, 0, 0,
                            resolution?.X ?? mode->Width,
                            resolution?.Y ?? mode->Height,
                            videoMode.RefreshRate ?? mode->RefreshRate
                        );
                        break;
                }
            }
        }

        protected override WindowBorder CoreWindowBorder
        {
            get
            {
                if (_glfw.GetWindowAttrib(_glfwWindow, WindowAttributeGetter.Resizable))
                {
                    return WindowBorder.Resizable;
                }

                return _glfw.GetWindowAttrib(_glfwWindow, WindowAttributeGetter.Decorated)
                    ? WindowBorder.Fixed
                    : WindowBorder.Hidden;
            }
            set
            {
                switch (value)
                {
                    case WindowBorder.Hidden:
                        _glfw.SetWindowAttrib(_glfwWindow, WindowAttributeSetter.Decorated, false);
                        _glfw.SetWindowAttrib(_glfwWindow, WindowAttributeSetter.Resizable, false);
                        break;

                    case WindowBorder.Resizable:
                        _glfw.SetWindowAttrib(_glfwWindow, WindowAttributeSetter.Decorated, true);
                        _glfw.SetWindowAttrib(_glfwWindow, WindowAttributeSetter.Resizable, true);
                        break;

                    case WindowBorder.Fixed:
                        _glfw.SetWindowAttrib(_glfwWindow, WindowAttributeSetter.Decorated, true);
                        _glfw.SetWindowAttrib(_glfwWindow, WindowAttributeSetter.Resizable, false);
                        break;
                }
            }
        }

        protected override bool CoreTopMost {
            get => _glfw.GetWindowAttrib(_glfwWindow, WindowAttributeGetter.Floating);
            set => _glfw.SetWindowAttrib(_glfwWindow, WindowAttributeSetter.Floating, value);
        }

        protected override bool IsClosingSettable
        {
            set
            {
                if (_glfwWindow != null)
                {
                    _glfw.SetWindowShouldClose(_glfwWindow, value);
                }
            }
        }

        protected override Vector2D<int> SizeSettable
        {
            set => _glfw.SetWindowSize(_glfwWindow, value.X, value.Y);
        }

        protected override void CoreInitialize(WindowOptions opts)
        {
            if (opts.API.API == ContextAPI.Vulkan && !_glfw.VulkanSupported())
            {
                throw new InvalidOperationException
                (
                    "Attempted to initialize a Vulkan window using GLFW, which doesn't support Vulkan on this computer."
                );
            }

            // Set window border.
            switch (opts.WindowBorder)
            {
                case WindowBorder.Hidden:
                    _glfw.WindowHint(WindowHintBool.Decorated, false);
                    _glfw.WindowHint(WindowHintBool.Resizable, false);
                    break;

                case WindowBorder.Resizable:
                    _glfw.WindowHint(WindowHintBool.Decorated, true);
                    _glfw.WindowHint(WindowHintBool.Resizable, true);
                    break;

                case WindowBorder.Fixed:
                    _glfw.WindowHint(WindowHintBool.Decorated, true);
                    _glfw.WindowHint(WindowHintBool.Resizable, false);
                    break;
            }

            // Set window class.
            _windowClass = opts.WindowClass ?? Window.DefaultWindowClass;
            _glfw.WindowHintString((int) WindowHintString.X11ClassName, _windowClass);

            // Set window API.
            switch (opts.API.API)
            {
                case ContextAPI.None:
                case ContextAPI.Vulkan:
                    _glfw.WindowHint(WindowHintClientApi.ClientApi, ClientApi.NoApi);
                    break;
                case ContextAPI.OpenGL:
                    _glfw.WindowHint(WindowHintClientApi.ClientApi, ClientApi.OpenGL);
                    break;
                case ContextAPI.OpenGLES:
                    _glfw.WindowHint(WindowHintClientApi.ClientApi, ClientApi.OpenGLES);
                    break;
            }

            _glfw.WindowHint(WindowHintBool.Visible, opts.IsVisible);

            // If there is an API specified, set the GLFW API version.
            if (opts.API.API != ContextAPI.None)
            { 
                _glfw.WindowHint(WindowHintInt.ContextVersionMajor, opts.API.Version.MajorVersion);
                _glfw.WindowHint(WindowHintInt.ContextVersionMinor, opts.API.Version.MinorVersion);
            }

            if (opts.API.API is ContextAPI.OpenGL or ContextAPI.OpenGLES)
            {
                // Set API flags
                if ((opts.API.Flags & ContextFlags.ForwardCompatible) != 0)
                {
                    _glfw.WindowHint(WindowHintBool.OpenGLForwardCompat, true);
                }

                if ((opts.API.Flags & ContextFlags.Debug) != 0)
                {
                    _glfw.WindowHint(WindowHintBool.OpenGLDebugContext, true);
                }

                if ((opts.API.Version.MajorVersion == 3 && opts.API.Version.MinorVersion >= 2) || opts.API.Version.MajorVersion > 3)
                {
                    // Set API profile
                    _glfw.WindowHint
                    (
                        WindowHintOpenGlProfile.OpenGlProfile,
                        opts.API.Profile == ContextProfile.Core ? OpenGlProfile.Core : OpenGlProfile.Compat
                    );
                }
            }

            // Set video mode (-1 = don't care)
            
            _glfw.WindowHint(WindowHintInt.RefreshRate, opts.VideoMode.RefreshRate      ?? GLFW.Glfw.DontCare);
            _glfw.WindowHint(WindowHintInt.DepthBits, opts.PreferredDepthBufferBits switch
            {
                null when opts.PreferredStencilBufferBits is null => 24,
                {} x => x,
                _ => GLFW.Glfw.DontCare
            });
            _glfw.WindowHint(WindowHintInt.StencilBits, opts.PreferredStencilBufferBits switch
            {
                null when opts.PreferredDepthBufferBits is null => 8,
                {} x => x,
                _ => GLFW.Glfw.DontCare
            });
            
            _glfw.WindowHint(WindowHintInt.RedBits,   opts.PreferredBitDepth?.X ?? GLFW.Glfw.DontCare);
            _glfw.WindowHint(WindowHintInt.GreenBits, opts.PreferredBitDepth?.Y ?? GLFW.Glfw.DontCare);
            _glfw.WindowHint(WindowHintInt.BlueBits,  opts.PreferredBitDepth?.Z ?? GLFW.Glfw.DontCare);
            if (opts.TransparentFramebuffer && (opts.PreferredBitDepth?.W ?? -1) != -1)
            {
                _glfw.WindowHint(WindowHintInt.AlphaBits, opts.PreferredBitDepth?.W ?? -1);
            }

            // Set transparent framebuffer
            _glfw.WindowHint(WindowHintBool.TransparentFramebuffer, opts.TransparentFramebuffer);
            
            // Set topmost window
            _glfw.WindowHint(WindowHintBool.Floating, opts.TopMost);

            // Set multisample samples
            _glfw.WindowHint(WindowHintInt.Samples, opts.Samples ?? GLFW.Glfw.DontCare);

            var share = SharedContext;
            _nonFullscreenSize = opts.Size;
            _nonFullscreenPosition = opts.Position;

            // Create window
            _glfwWindow = _glfw.CreateWindow
            (
                opts.Size.X, opts.Size.Y, opts.Title,
                _initialMonitor is not null ? _initialMonitor.Handle : null,
                share switch
                {
                    null => null,
                    _ when share is GlfwContext glfwContext => (WindowHandle*) glfwContext.Handle,
                    _ => throw new ArgumentException("The given shared context should be a GlfwContext or GlfwWindow")
                }
            );

            if (opts.WindowState is not WindowState.Fullscreen)
            {
                CorePosition = opts.Position;
            }

            IsInitialized = true;
            if (opts.IsVisible)
            {
                _glfw.ShowWindow(_glfwWindow);
                WindowState = opts.WindowState;
            }
            else
            {
                _glfw.HideWindow(_glfwWindow);
            }
            
            if (opts.API.API is ContextAPI.OpenGL or ContextAPI.OpenGLES)
            {
                _glfw.MakeContextCurrent(_glfwWindow);
            }

            GLFW.Glfw.ThrowExceptions();
        }

        public override event Action<Vector2D<int>>? Move;
        public override event Action<WindowState>? StateChanged;
        public override event Action<string[]>? FileDrop;

        public override void SetWindowIcon(ReadOnlySpan<RawImage> icons)
        {
            if (!IsInitialized)
            {
                throw new InvalidOperationException("Window should be initialized.");
            }

            var budget = 1024;
            if (icons == null)
            {
                _glfw.SetWindowIcon(_glfwWindow, 0, null);
            }
            else
            {
                var images = stackalloc Image[icons.Length];
                nint harr = 0;
                var harrLen = 0;
                var harrOff = 0;
                for (var i = 0; i < icons.Length; i++)
                {
                    var icon = icons[i];
                    // ReSharper disable once StackAllocInsideLoop
                    var iconMemory = budget >= icon.Pixels.Length
                        ? stackalloc byte[icon.Pixels.Length]
                        : harr == 0
                            ? null
                            : new Span<byte>((void*)(harr + harrOff), icon.Pixels.Length);
                    if (iconMemory == null)
                    {
                        for (var j = i; j < icons.Length; j++)
                        {
                            harrLen += icons[j].Pixels.Length;
                        }

                        harr = SilkMarshal.Allocate(harrLen);
                        iconMemory = new Span<byte>((void*) harr, icon.Pixels.Length);
                        harrOff = icon.Pixels.Length;
                    }
                    else if (budget >= icon.Pixels.Length)
                    {
                        budget -= icon.Pixels.Length;
                    }
                    else
                    {
                        harrOff += icon.Pixels.Length;
                    }
                    images[i] = new()
                    {
                        Width = icon.Width, Height = icon.Height,
                        Pixels = (byte*) Unsafe.AsPointer(ref iconMemory[0])
                    };

                    icon.Pixels.Span.CopyTo(iconMemory);
                }

                _glfw.SetWindowIcon(_glfwWindow, icons.Length, images);
                if (harr != 0)
                {
                    SilkMarshal.Free(harr);
                }
                GLFW.Glfw.ThrowExceptions();
            }
        }

        public override IWindow CreateWindow(WindowOptions opts) => new GlfwWindow(opts, this, null);

        public override IWindowHost? Parent => (IWindowHost?) _parent ?? Monitor;
        public override IGLContext? SharedContext { get; }
        public override string? WindowClass => _windowClass;


        public override IMonitor? Monitor
        {
            get
            {
                if (!IsInitialized)
                {
                    return _initialMonitor;
                }

                var monitor = _glfw.GetWindowMonitor(_glfwWindow);
                if (monitor == null)
                {
                    if (WindowState != WindowState.Fullscreen)
                    {
                        var monitors = new GlfwMonitorEnumerable();
                        // Determine which monitor this window is on. [6 marks]
                        foreach (var m in monitors)
                        {
                            var pos = Position;
                            var size = Size;
                            if (m.Bounds.Contains(new Vector2D<int>(pos.X + size.X / 2, pos.Y + size.Y / 2)))
                            {
                                return m;
                            }
                        }
                    }

                    monitor = _glfw.GetPrimaryMonitor();
                }

                return monitor == null
                    ? null
                    : new GlfwMonitor
                    (
                        monitor,
                        IndexOf(_glfw.GetMonitors(out var count), monitor, count)
                    );
            }
            set
            {
                _swapIntervalChanged = true;
                if (!IsInitialized)
                {
                    throw new InvalidOperationException("Window is not running.");
                }

                if (value is null)
                {
                    throw new ArgumentNullException(nameof(value));
                }

                if (WindowState == WindowState.Fullscreen)
                {
                    var h = ((GlfwMonitor) value).Handle;
                    var vidMode = value.VideoMode;
                    var resolution = vidMode.Resolution;
                    if (!resolution.HasValue)
                    {
                        throw new InvalidOperationException("Monitor resolution not found.");
                    }

                    if (!vidMode.RefreshRate.HasValue)
                    {
                        throw new InvalidOperationException("Monitor refresh rate not found.");
                    }

                    _glfw.SetWindowMonitor
                    (
                        _glfwWindow, h, 0, 0, resolution.Value.X, resolution.Value.Y, vidMode.RefreshRate.Value
                    );
                    GLFW.Glfw.ThrowExceptions();
                }
                else
                {
                    Position = value.Bounds.Origin;
                }
            }
        }

        private static int IndexOf<T>(T** array, T* target, int count)
            where T : unmanaged
        {
            for (var i = 0; i < count; i++)
            {
                if (array[i] == target)
                {
                    return i;
                }
            }

            return -1;
        }

        protected override bool CoreIsClosing => _glfw.WindowShouldClose(_glfwWindow);

        public override VideoMode VideoMode
            => IsInitialized ? CachedVideoMode = Monitor?.VideoMode ?? CachedVideoMode : CachedVideoMode;

        public override bool IsEventDriven { get; set; }

        public override Vector2D<int> FramebufferSize
        {
            get
            {
                _glfw.GetFramebufferSize(_glfwWindow, out var width, out var height);
                return new(width, height);
            }
        }

        public override void DoEvents()
        {
            if (!_inRefresh)
            {
                if (IsEventDriven)
                {
                    _glfw.WaitEvents();
                }
                else
                {
                    _glfw.PollEvents();
                }
            }
        }

        public override void ContinueEvents() => _glfw.PostEmptyEvent();

        public nint GetProcAddress(string proc, int? slot = default)
        {
            var ret = _glfw.GetProcAddress(proc);
            GLFW.Glfw.ThrowExceptions();
            if (ret == 0)
            {
                Throw(proc);
            }

            return ret;
            static void Throw(string proc) => throw new SymbolLoadingException(proc);
        }

        public bool TryGetProcAddress(string proc, out nint addr, int? slot = default)
        {
            var errorCallback = _glfw.SetErrorCallback(null);
            var ret = (addr = _glfw.GetProcAddress(proc)) != 0;
            _glfw.SetErrorCallback(errorCallback);
            return ret;
        }

        public override void Focus() 
        {
            _glfw.FocusWindow(_glfwWindow);
        }

        public override void Close()
        {
            Closing?.Invoke();
            IsClosingSettable = true;
        }

        protected override void RegisterCallbacks()
        {
            _onMove = (window, x, y) =>
            {
                var point = new Vector2D<int>(x, y);
                UpdatePosition(point);
                Move?.Invoke(point);
            };

            _onResize = (window, width, height) =>
            {
                var size = new Vector2D<int>(width, height);
                UpdateSize(size);
                Resize?.Invoke(size);
            };

            _onFramebufferResize = (window, width, height) =>
            {
                FramebufferResize?.Invoke(new(width, height));
            };

            _onRefresh = (window) =>
            {
                if (_inRefresh)
                {
                    return;
                }

                try
                {
                    _inRefresh = true;
                    _onFrame?.Invoke();
                }
                finally
                {
                    _inRefresh = false;
                }
            };

            _onClosing = window => Closing?.Invoke();

            _onFocusChanged = (window, isFocused) => FocusChanged?.Invoke(isFocused);

            _onMinimized = (window, isMinimized) =>
            {
                WindowState state;
                // If minimized, we immediately know what value the new WindowState is.
                if (isMinimized)
                {
                    state = WindowState.Minimized;
                }
                else
                {
                    // Otherwise, we have to query a few things to figure out out.
                    if (_glfw.GetWindowAttrib(_glfwWindow, WindowAttributeGetter.Maximized))
                    {
                        state = WindowState.Maximized;
                    }
                    else if (_glfw.GetWindowMonitor(_glfwWindow) != null)
                    {
                        state = WindowState.Fullscreen;
                    }
                    else
                    {
                        state = WindowState.Normal;
                    }
                }

                UpdateState(state);
                StateChanged?.Invoke(state);
            };

            _onMaximized = (window, isMaximized) =>
            {
                // Same here as in onMinimized.
                WindowState state;
                if (isMaximized)
                {
                    state = WindowState.Maximized;
                }
                else
                {
                    if (_glfw.GetWindowAttrib(_glfwWindow, WindowAttributeGetter.Iconified))
                    {
                        state = WindowState.Minimized;
                    }
                    else if (_glfw.GetWindowMonitor(_glfwWindow) != null)
                    {
                        state = WindowState.Fullscreen;
                    }
                    else
                    {
                        state = WindowState.Normal;
                    }
                }

                UpdateState(state);
                StateChanged?.Invoke(state);
            };

            _onFileDrop = (window, count, paths) =>
            {
                var arrayOfPaths = new string[count];

                if (count == 0 || paths == 0)
                {
                    return;
                }

                for (var i = 0; i < count; i++)
                {
                    var p = Marshal.ReadIntPtr(paths, i * IntPtr.Size);
                    arrayOfPaths[i] = SilkMarshal.PtrToString((nint) p, NativeStringEncoding.UTF8) ?? "";
                }

                FileDrop?.Invoke(arrayOfPaths);
            };

            _glfw.SetWindowPosCallback(_glfwWindow, _onMove);
            _glfw.SetWindowSizeCallback(_glfwWindow, _onResize);
            _glfw.SetWindowCloseCallback(_glfwWindow, _onClosing);
            _glfw.SetWindowFocusCallback(_glfwWindow, _onFocusChanged);
            _glfw.SetWindowIconifyCallback(_glfwWindow, _onMinimized);
            _glfw.SetWindowMaximizeCallback(_glfwWindow, _onMaximized);
            _glfw.SetFramebufferSizeCallback(_glfwWindow, _onFramebufferResize);
            _glfw.SetWindowRefreshCallback(_glfwWindow, _onRefresh);
            _glfw.SetDropCallback(_glfwWindow, _onFileDrop);
            GLFW.Glfw.ThrowExceptions();
        }

        protected override void UnregisterCallbacks()
        {
            // All callbacks are initialized at the same time,
            // so checking each one individually shouldn't be
            // necessary.
            if (_onClosing != null)
            {
                _glfw.GcUtility.Unpin(_onClosing);
                _glfw.GcUtility.Unpin(_onMaximized);
                _glfw.GcUtility.Unpin(_onMinimized);
                _glfw.GcUtility.Unpin(_onMove);
                _glfw.GcUtility.Unpin(_onResize);
                _glfw.GcUtility.Unpin(_onFramebufferResize);
                _glfw.GcUtility.Unpin(_onRefresh);
                _glfw.GcUtility.Unpin(_onFileDrop);
                _glfw.GcUtility.Unpin(_onFocusChanged);

                _onClosing = null;
                _onMaximized = null;
                _onMinimized = null;
                _onMove = null;
                _onResize = null;
                _onFramebufferResize = null;
                _onRefresh = null;
                _onFileDrop = null;
                _onFocusChanged = null;
            }
        }

        public new bool TopMost
        {
            get => ExtendedOptionsCache.TopMost;
            set
            {
                _glfw.SetWindowAttrib(_glfwWindow, WindowAttributeSetter.Floating, value);
                ExtendedOptionsCache.TopMost = value;
            }
        }

        protected override INativeWindow GetNativeWindow() => new GlfwNativeWindow(_glfw, _glfwWindow);

        public override event Action<Vector2D<int>>? Resize;
        public override event Action<Vector2D<int>>? FramebufferResize;
        public override event Action? Closing;
        public override event Action<bool>? FocusChanged;

        ~GlfwWindow()
        {
            Reset();
        }

        public VkNonDispatchableHandle Create<T>(VkHandle instance, T* allocator) where T : unmanaged
        {
            var surface = stackalloc VkNonDispatchableHandle[1];
            int ec;
            if ((ec = _glfw.CreateWindowSurface(instance, _glfwWindow, allocator, surface)) != 0)
            {
                throw new GlfwException("Failed to create surface, error code " + ec);
            }

            GLFW.Glfw.ThrowExceptions();
            return surface[0];
        }

        public byte** GetRequiredExtensions(out uint count) => _glfw.GetRequiredInstanceExtensions(out count);
    }
}
