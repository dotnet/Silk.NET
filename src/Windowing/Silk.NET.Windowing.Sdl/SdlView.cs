// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using Silk.NET.Core;
using Silk.NET.Core.Contexts;
using Silk.NET.Maths;
using Silk.NET.SDL;
using Silk.NET.Windowing.Internals;
#if __IOS__
using Silk.NET.Windowing.Sdl.iOS;
#endif

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
            var flags = WindowFlags.AllowHighdpi |
                        WindowFlags.Shown;
            if (additionalFlags is null)
            {
                flags |= _platform.IsViewOnly switch
                {
                    true => WindowFlags.Borderless | WindowFlags.Fullscreen | WindowFlags.Resizable,
                    false => WindowFlags.Resizable
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
                    flags |= WindowFlags.Vulkan;
                    break;
                }
                case ContextAPI.OpenGLES:
                case ContextAPI.OpenGL:
                {
                    flags |= WindowFlags.Opengl;
                    break;
                }
            }

            IsClosingVal = false;

            // Set window GL attributes
            if (opts.PreferredDepthBufferBits != -1)
            {
                Sdl.GLSetAttribute
                (
                    GLattr.DepthSize,
                    opts.PreferredDepthBufferBits ?? 24
                );
            }

            if (opts.PreferredStencilBufferBits != -1)
            {
                Sdl.GLSetAttribute
                (
                    GLattr.StencilSize,
                    opts.PreferredStencilBufferBits ?? 8
                );
            }

            if (opts.PreferredBitDepth?.X != -1)
            {
                Sdl.GLSetAttribute
                (
                    GLattr.RedSize,
                    opts.PreferredBitDepth?.X ?? 8
                );
            }

            if (opts.PreferredBitDepth?.Y != -1)
            {
                Sdl.GLSetAttribute
                (
                    GLattr.GreenSize,
                    opts.PreferredBitDepth?.Y ?? 8
                );
            }

            if (opts.PreferredBitDepth?.Z != -1)
            {
                Sdl.GLSetAttribute
                (
                    GLattr.BlueSize,
                    opts.PreferredBitDepth?.Z ?? 8
                );
            }
            
            if (opts.PreferredBitDepth?.W != -1)
            {
                Sdl.GLSetAttribute
                (
                    GLattr.AlphaSize,
                    opts.PreferredBitDepth?.W ?? 8
                );
            }

            Sdl.GLSetAttribute(GLattr.Multisamplebuffers, (opts.Samples == null || opts.Samples == -1) ? 0 : 1);
            Sdl.GLSetAttribute(GLattr.Multisamplesamples, (opts.Samples == null || opts.Samples == -1) ? 0 : opts.Samples.Value);

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
                (GLattr.ContextMajorVersion, opts.API.Version.MajorVersion),
                (GLattr.ContextMinorVersion, opts.API.Version.MinorVersion),
                (
                    GLattr.ContextProfileMask,
                    (int) (opts.API.API == ContextAPI.OpenGLES
                        ? GLprofile.ES
                        : opts.API.Profile switch
                        {
                            ContextProfile.Core => GLprofile.Core,
                            ContextProfile.Compatability => GLprofile.Compatibility,
                            _ => throw new System.ArgumentOutOfRangeException(nameof(opts), "Bad ContextProfile")
                        })
                ),
                (GLattr.ContextFlags, (int) opts.API.Flags),
                (GLattr.ShareWithCurrentContext, sharedContext is null ? 0 : 1)
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

#if __IOS__
        private static bool _isRunning;
        public override void Run(Action onFrame)
        {
            if (_isRunning)
            {
                throw new NotSupportedException("A view is already running in this mobile application.");
            }

            if (!SilkMobile.IsRunning)
            {
                throw new InvalidOperationException
                (
                    "The view could not be created as the underlying mobile application is not running. On iOS, " +
                    "please wrap your main function in a call to SilkMobile.RunApp to ensure that application " +
                    "lifecycles can be managed properly."
                );
            }
            
            // This is not correct, we should be using SDL_iPhoneSetAnimationCallback and then letting
            // SDL_UIKitRunApp take care of the lifetime, but this would be a breaking change as Run in 2.X is expected
            // to only exit when the view does. We'll fix this properly in 3.0.
            _isRunning = true;
            base.Run(onFrame);
            _isRunning = false;
        }
#endif

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
            do
            {
                _platform.DoEvents();
            } while (IsEventDriven && Events.Count == 0 && Interlocked.CompareExchange(ref _continue, 0, 1) == 0);

            ProcessEvents();
        }

        private void ClearEvents()
        { 
            // remove events in reverse order to prevent shuffling in the list
            for (var i = Events.Count - 1; i >= 0; i--)
            {
                RemoveEvent(i);
            }
        }
        
        internal void RemoveEvent(int index)
        {
            var @event = Events[index];
            if (@event.Type == (uint) EventType.Dropfile)
            {
                Sdl.Free(@event.Drop.File);
            }

            Events.RemoveAt(index);
        }

        ~SdlView()
        {
            Reset();
        }

        public override void Focus()
        {
            Sdl.RaiseWindow(SdlWindow);
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
                            case WindowEventID.Resized:
                            {
                                Resize?.Invoke(new Vector2D<int>(@event.Window.Data1, @event.Window.Data2));
                                FramebufferResize?.Invoke(FramebufferSize);
                                break;
                            }
                            case WindowEventID.FocusGained:
                            {
                                FocusChanged?.Invoke(true);
                                break;
                            }
                            case WindowEventID.FocusLost:
                            {
                                FocusChanged?.Invoke(false);
                                break;
                            }
                            case WindowEventID.Close:
                            {
                                Close();
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
                    RemoveEvent(i);
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
                    EventType.Mousewheel when @event.Wheel.WindowID == _id => true,
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

        internal override void AfterProcessingEvents()
        {
            ClearEvents();
        }
    }
}
