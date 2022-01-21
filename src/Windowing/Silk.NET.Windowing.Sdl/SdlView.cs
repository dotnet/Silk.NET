// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Threading;
using Silk.NET.Core;
using Silk.NET.Core.Contexts;
using Silk.NET.Maths;
using Silk.NET.SDL;
using Silk.NET.Windowing.Internals;

// We can't import System because System has a type called nint on iOS and Mac Catalyst.
// As such, throughout this file System is fully qualified.

// ReSharper disable BitwiseOperatorOnEnumWithoutFlags

namespace Silk.NET.Windowing.Sdl
{
    internal unsafe class SdlView : ViewImplementationBase
    {
        protected readonly SdlPlatform _platform;
        private const int WaitTimeout = 10;
        private IGLContext? _ctx;
        private SdlVkSurface? _vk;
        private int _continue;
        private uint? _id;
        private BreakneckLock _eventSync = BreakneckLock.Create();

        public SdlView(ViewOptions opts, SdlView? parent, SdlMonitor? monitor, SdlPlatform platform): base(opts)
        {
            _platform = platform;
            Sdl = SdlProvider.SDL.Value;
            ParentView = parent;
            InitialMonitor = monitor;
        }

        public SdlView(void* nativeHandle, IGLContext? ctx, SdlPlatform platform) : base(default)
        {
            Sdl = SdlProvider.SDL.Value;
            ParentView = null;
            InitialMonitor = null;
            IsInitialized = true;
            SdlWindow = Sdl.CreateWindowFrom(nativeHandle);
            _ctx = ctx;
            _platform = platform;
        }

        // Events
        public override event System.Action<Vector2D<int>>? Resize;
        public override event System.Action<Vector2D<int>>? FramebufferResize;
        public override event System.Action? Closing;
        public override event System.Action<bool>? FocusChanged;

        // Properties
        protected override IGLContext? CoreGLContext => API.API == ContextAPI.OpenGL || API.API == ContextAPI.OpenGLES
            ? _ctx ??= new SdlContext(Sdl, SdlWindow, this)
            : null;
        protected override IVkSurface? CoreVkSurface => API.API == ContextAPI.Vulkan
            ? _vk ??= new SdlVkSurface(this)
            : null;
        protected override nint CoreHandle => (nint) SdlWindow;
        internal SDL.Sdl Sdl { get; }
        internal SDL.Window* SdlWindow { get; private set; }
        internal bool IsClosingVal { get; set; }
        protected override bool CoreIsClosing => IsClosingVal;
        public override bool IsEventDriven { get; set; }
        public List<Event> Events { get; } = new List<Event>();
        protected SdlView? ParentView { get; }
        protected SdlMonitor? InitialMonitor { get; set; }

        public override Vector2D<int> FramebufferSize => (_ctx as SdlContext)?.FramebufferSize ?? CoreSize;

        public override VideoMode VideoMode
        {
            get
            {
                DisplayMode mode;
                return Sdl.GetWindowDisplayMode(SdlWindow, &mode) == 1
                    ? new VideoMode(new Vector2D<int>(mode.W, mode.H), mode.RefreshRate)
                    : default;
            }
        }

        protected override Vector2D<int> CoreSize
        {
            get
            {
                var ret = stackalloc int[2];
                Sdl.GetWindowSize(SdlWindow, ret, &ret[1]);
                return *(Vector2D<int>*) ret;
            }
        }

        // Methods
        public override void ContinueEvents() => Interlocked.Exchange(ref _continue, 1);
        protected override INativeWindow GetNativeWindow() => new SdlNativeWindow(Sdl, SdlWindow);

        protected override void CoreInitialize(ViewOptions opts) => CoreInitialize
            (opts, null, null, null, null, null, null, null);

        protected void CoreInitialize
        (
            ViewOptions opts,
            WindowFlags? additionalFlags,
            int? x,
            int? y,
            int? w,
            int? h,
            string? title,
            IGLContext? sharedContext)
        {
            var flags = WindowFlags.WindowAllowHighdpi |
                        WindowFlags.WindowShown;
            if (additionalFlags is null)
            {
                flags |= _platform.IsViewOnly switch
                {
                    true => WindowFlags.WindowBorderless | WindowFlags.WindowFullscreen,
                    false => WindowFlags.WindowResizable
                };
            }
            else
            {
                flags |= additionalFlags.Value;
            }

            // Set window API.
            switch (opts.API.API)
            {
                case ContextAPI.None:
                {
                    break;
                }
                case ContextAPI.Vulkan:
                {
                    flags |= WindowFlags.WindowVulkan;
                    break;
                }
                case ContextAPI.OpenGLES:
                case ContextAPI.OpenGL:
                {
                    flags |= WindowFlags.WindowOpengl;
                    break;
                }
            }

            IsClosingVal = false;

            // Set window GL attributes
            Sdl.GLSetAttribute(GLattr.GLDepthSize,
                    opts.PreferredDepthBufferBits is null || opts.PreferredDepthBufferBits == -1
                        ? 24 : opts.PreferredDepthBufferBits.Value);

            Sdl.GLSetAttribute(GLattr.GLStencilSize,
                    opts.PreferredStencilBufferBits is null || opts.PreferredStencilBufferBits == -1
                        ? 8 : opts.PreferredStencilBufferBits.Value);

            Sdl.GLSetAttribute(GLattr.GLRedSize,
                    opts.PreferredBitDepth is null || opts.PreferredBitDepth.Value.X == -1
                        ? 8 : opts.PreferredBitDepth.Value.X);

            Sdl.GLSetAttribute(GLattr.GLGreenSize,
                    opts.PreferredBitDepth is null || opts.PreferredBitDepth.Value.Y == -1
                        ? 8 : opts.PreferredBitDepth.Value.Y);

            Sdl.GLSetAttribute(GLattr.GLBlueSize,
                    opts.PreferredBitDepth is null || opts.PreferredBitDepth.Value.Z == -1
                        ? 8 : opts.PreferredBitDepth.Value.Z);

            Sdl.GLSetAttribute(GLattr.GLAlphaSize,
                    opts.PreferredBitDepth is null || opts.PreferredBitDepth.Value.W == -1
                        ? 8 : opts.PreferredBitDepth.Value.W);

            Sdl.GLSetAttribute(GLattr.GLMultisamplebuffers, (opts.Samples == null || opts.Samples == -1) ? 0 : 1);
            Sdl.GLSetAttribute(GLattr.GLMultisamplesamples, (opts.Samples == null || opts.Samples == -1) ? 0 : opts.Samples.Value);

            // Create window
            SdlWindow = Sdl.CreateWindow
            (
                title ?? Assembly.GetEntryAssembly()?.GetName().Name ?? "Silk.NET Window",
                x ?? 50,
                y ?? 50,
                w ?? 1280,
                h ?? 720,
                (uint) flags
            );
            if (SdlWindow == null)
            {
                Sdl.ThrowError();
            }

            sharedContext?.MakeCurrent();
            (CoreGLContext as SdlContext)?.Create
            (
                (GLattr.GLContextMajorVersion, opts.API.Version.MajorVersion),
                (GLattr.GLContextMinorVersion, opts.API.Version.MinorVersion),
                (
                    GLattr.GLContextProfileMask,
                    (int) (opts.API.API == ContextAPI.OpenGLES
                        ? GLprofile.GLContextProfileES
                        : opts.API.Profile switch
                        {
                            ContextProfile.Core => GLprofile.GLContextProfileCore,
                            ContextProfile.Compatability => GLprofile.GLContextProfileCompatibility,
                            _ => throw new System.ArgumentOutOfRangeException(nameof(opts), "Bad ContextProfile")
                        })
                ),
                (GLattr.GLContextFlags, (int) opts.API.Flags),
                (GLattr.GLShareWithCurrentContext, sharedContext is null ? 0 : 1)
            );
            if (SdlWindow == null)
            {
                throw new PlatformException(Sdl.GetErrorAsException());
            }

            var mode = new DisplayMode();
            if (Sdl.GetWindowDisplayMode(SdlWindow, &mode) == 1)
            {
                if (opts.VideoMode.RefreshRate.HasValue)
                {
                    mode.Driverdata = null;
                    mode.RefreshRate = opts.VideoMode.RefreshRate.Value;
                    Sdl.SetWindowDisplayMode(SdlWindow, &mode);
                }
            }
            else
            {
                Sdl.ClearError();
            }

            Sdl.ThrowError();
        }

        protected override void CoreReset()
        {
            if (SdlWindow == null)
            {
                return;
            }

            CoreGLContext?.Dispose();
            Sdl.DestroyWindow(SdlWindow);

            SdlWindow = null;
            _ctx = null;
            _vk = null;
        }

        public override void DoEvents()
        {
            ClearEvents();
            do
            {
                _platform.DoEvents();
            } while (IsEventDriven && Events.Count == 0 && Interlocked.CompareExchange(ref _continue, 0, 1) == 0);

            ProcessEvents();
        }

        private void ClearEvents()
        {
            var c = Events.Count;
            for (var i = 0; i < c; i++)
            {
                var @event = Events[0];
                if (@event.Type == (uint) EventType.Dropfile)
                {
                    Sdl.Free(@event.Drop.File);
                }

                Events.RemoveAt(0);
            }
        }

        ~SdlView()
        {
            Reset();
        }

        public override void Close()
        {
            Closing?.Invoke();
            IsClosingVal = true;
        }

        protected override void RegisterCallbacks()
        {
            _id = Sdl.GetWindowID(SdlWindow);
            _platform.EventReceived += OnEventReceived;
        }

        protected override void UnregisterCallbacks()
        {
            _id = null;
            _platform.EventReceived -= OnEventReceived;
        }


        public override Vector2D<int> PointToClient(Vector2D<int> point)
        {
            int x, y;
            Sdl.GetWindowPosition(SdlWindow, &x, &y);
            return new Vector2D<int>(point.X - x, point.Y - y);
        }

        public override Vector2D<int> PointToScreen(Vector2D<int> point)
        {
            int x, y;
            Sdl.GetWindowPosition(SdlWindow, &x, &y);
            return new Vector2D<int>(point.X + x, point.Y + y);
        }

        public void BeginEventProcessing(ref bool taken) => _eventSync.Enter(ref taken);
        public void EndEventProcessing(bool taken)
        {
            if (taken)
            {
                _eventSync.Exit();
            }
        }

        [SuppressMessage("ReSharper", "SwitchStatementHandlesSomeKnownEnumValuesWithDefault")]
        public virtual void ProcessEvents()
        {
            var taken = false;
            BeginEventProcessing(ref taken);
            var count = Events.Count;
            var i = 0;
            for (var j = 0; j < count; j++)
            {
                var @event = Events[i];
                var skipped = false;
                switch ((EventType) @event.Type)
                {
                    case EventType.AppTerminating:
                    case EventType.Quit:
                    {
                        Close();
                        break;
                    }
                    //case EventType.AppTerminating:
                    //    break;
                    //case EventType.AppLowmemory:
                    //    break;
                    //case EventType.AppWillenterbackground: TODO Pausing event
                    //    break;
                    //case EventType.AppDidenterbackground:
                    //    break;
                    //case EventType.AppWillenterforeground: TODO Resuming event
                    //    break;
                    //case EventType.AppDidenterforeground:
                    //    break;
                    case EventType.Windowevent:
                    {
                        switch ((WindowEventID) @event.Window.Event)
                        {
                            case WindowEventID.WindoweventResized:
                            {
                                Resize?.Invoke(new Vector2D<int>(@event.Window.Data1, @event.Window.Data2));
                                FramebufferResize?.Invoke(FramebufferSize);
                                break;
                            }
                            case WindowEventID.WindoweventFocusGained:
                            {
                                FocusChanged?.Invoke(true);
                                break;
                            }
                            case WindowEventID.WindoweventFocusLost:
                            {
                                FocusChanged?.Invoke(false);
                                break;
                            }
                            default:
                            {
                                i++;
                                skipped = true;
                                break;
                            }
                        }

                        break;
                    }
                    default:
                    {
                        i++;
                        skipped = true;
                        break;
                    }
                }

                if (!skipped)
                {
                    Events.RemoveAt(i);
                }
            }
            
            EndEventProcessing(taken);
        }

        private void OnEventReceived(IEnumerable<Event> events)
        {
            var taken = false;
            BeginEventProcessing(ref taken);
            foreach (var @event in events)
            {
                if ((EventType) @event.Type switch
                {
                    EventType.Firstevent => true,
                    EventType.Quit => true,
                    EventType.AppTerminating => true,
                    EventType.AppLowmemory => true,
                    EventType.AppWillenterbackground => true,
                    EventType.AppDidenterbackground => true,
                    EventType.AppWillenterforeground => true,
                    EventType.AppDidenterforeground => true,
                    EventType.Displayevent => true,
                    EventType.Windowevent when @event.Window.WindowID == _id => true,
                    EventType.Syswmevent => true,
                    EventType.Keydown when @event.Key.WindowID == _id => true,
                    EventType.Keyup when @event.Key.WindowID == _id => true,
                    EventType.Textediting when @event.Text.WindowID == _id => true,
                    EventType.Textinput when @event.Text.WindowID == _id => true,
                    EventType.Keymapchanged => true,
                    EventType.Mousemotion when @event.Motion.WindowID == _id => true,
                    EventType.Mousebuttondown when @event.Button.WindowID == _id => true,
                    EventType.Mousebuttonup when @event.Button.WindowID == _id => true,
                    EventType.Mousewheel when @event.Motion.WindowID == _id => true,
                    EventType.Joyaxismotion => true,
                    EventType.Joyballmotion => true,
                    EventType.Joyhatmotion => true,
                    EventType.Joybuttondown => true,
                    EventType.Joybuttonup => true,
                    EventType.Joydeviceadded => true,
                    EventType.Joydeviceremoved => true,
                    EventType.Controlleraxismotion => true,
                    EventType.Controllerbuttondown => true,
                    EventType.Controllerbuttonup => true,
                    EventType.Controllerdeviceadded => true,
                    EventType.Controllerdeviceremoved => true,
                    EventType.Controllerdeviceremapped => true,
                    EventType.Fingerdown when @event.Tfinger.WindowID == _id => true,
                    EventType.Fingerup when @event.Tfinger.WindowID == _id => true,
                    EventType.Fingermotion when @event.Tfinger.WindowID == _id => true,
                    EventType.Dollargesture => true,
                    EventType.Dollarrecord => true,
                    EventType.Multigesture => true,
                    EventType.Clipboardupdate => true,
                    EventType.Dropfile when @event.Drop.WindowID == _id => true,
                    EventType.Droptext when @event.Drop.WindowID == _id => true,
                    EventType.Dropbegin when @event.Drop.WindowID == _id => true,
                    EventType.Dropcomplete when @event.Drop.WindowID == _id => true,
                    EventType.Audiodeviceadded => true,
                    EventType.Audiodeviceremoved => true,
                    EventType.Sensorupdate => true,
                    EventType.RenderTargetsReset => true,
                    EventType.RenderDeviceReset => true,
                    EventType.Userevent when @event.User.WindowID == _id => true,
                    EventType.Lastevent => true,
                    _ => false
                })
                {
                    Events.Add(@event);
                }
            }
            
            EndEventProcessing(taken);
        }
    }
}
