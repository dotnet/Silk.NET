// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Reflection;
using System.Threading;
using Silk.NET.Core;
using Silk.NET.Core.Contexts;
using Silk.NET.SDL;
using Silk.NET.Windowing.Internals;
using Point = System.Drawing.Point;

// ReSharper disable BitwiseOperatorOnEnumWithoutFlags

namespace Silk.NET.Windowing.Sdl
{
    internal unsafe class SdlView : ViewImplementationBase
    {
        private const int WaitTimeout = 10;
        private SdlGLContext? _ctx;
        private SdlVkSurface? _vk;
        private int _continue;

        public SdlView(ViewOptions opts, SdlView? parent, SdlMonitor? monitor) : base(opts)
        {
            Sdl = SdlProvider.SDL.Value;
            ParentView = parent;
            InitialMonitor = monitor;
        }

        // Events
        public override event Action<Size>? Resize;
        public override event Action<Size>? FramebufferResize;
        public override event Action? Closing;
        public override event Action<bool>? FocusChanged;

        // Properties
        public override IGLContext? GLContext => _ctx ??= API.API == ContextAPI.OpenGL || API.API == ContextAPI.OpenGLES
            ? new SdlGLContext(this)
            : null;

        public override IVkSurface? VkSurface => _vk ??= API.API == ContextAPI.Vulkan ? new SdlVkSurface(this) : null;
        protected override IntPtr CoreHandle => (IntPtr) SdlWindow;
        internal SDL.Sdl Sdl { get; }
        internal SDL.Window* SdlWindow { get; private set; }
        internal bool IsClosingVal { get; set; }
        public override bool IsClosing => IsClosingVal;
        public override bool IsEventDriven { get; set; }
        public List<Event> Events { get; } = new List<Event>();
        protected SdlView? ParentView { get; }
        protected SdlMonitor? InitialMonitor { get; set; }

        public override Size FramebufferSize => _ctx?.FramebufferSize ?? CoreSize;

        public override VideoMode VideoMode
        {
            get
            {
                DisplayMode mode;
                return Sdl.GetWindowDisplayMode(SdlWindow, &mode) == 1
                    ? new VideoMode(new Size(mode.W, mode.H), mode.RefreshRate)
                    : default;
            }
        }

        protected override Size CoreSize
        {
            get
            {
                var ret = stackalloc int[2];
                Sdl.GetWindowSize(SdlWindow, ret, &ret[1]);
                return *(Size*) ret;
            }
        }


        // Methods
        public override void ContinueEvents() => Interlocked.Exchange(ref _continue, 1);

        protected override void CoreInitialize(ViewOptions opts) => CoreInitialize
            (opts, null, null, null, null, null, null);

        protected void CoreInitialize
            (ViewOptions opts, WindowFlags? additionalFlags, int? x, int? y, int? w, int? h, string? title)
        {
            var flags = WindowFlags.WindowAllowHighdpi |
                        WindowFlags.WindowShown;

            if (additionalFlags is null)
            {
                flags |= WindowFlags.WindowResizable;
            }
            else
            {
                flags |= additionalFlags.Value;
            }

            // Set window API.
            switch (opts.API.API)
            {
                case ContextAPI.None:
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
            Sdl.ThrowError();
            (GLContext as SdlGLContext)?.Create
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
                            _ => throw new ArgumentOutOfRangeException(nameof(opts), "Bad ContextProfile")
                        })
                ),
                (GLattr.GLContextFlags, (int) opts.API.Flags),
                (GLattr.GLDepthSize, opts.PreferredDepthBufferBits ?? 16)
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

            GLContext?.Dispose();
            Sdl.DestroyWindow(SdlWindow);
        }

        public override void DoEvents()
        {
            ClearEvents();
            Event @event = default;
            if (IsEventDriven)
            {
                var gotEvent = 0;
                while (Interlocked.CompareExchange(ref _continue, 0, 1) == 0 &&
                       (gotEvent = Sdl.WaitEventTimeout(&@event, WaitTimeout)) == 0)
                {
                    // do nothing
                }

                if (gotEvent == 1)
                {
                    Events.Add(@event);
                }
            }

            while (Sdl.PollEvent(&@event) == 1)
            {
                Events.Add(@event);
            }

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

        public override void Dispose()
        {
            CoreReset();
            GC.SuppressFinalize(this);
        }

        ~SdlView()
        {
            CoreReset();
        }

        public override void Close()
        {
            Closing?.Invoke();
            IsClosingVal = true;
        }

        protected override void RegisterCallbacks()
        {
            // do nothing, SDL uses event pumps like all windowing frameworks should do.
        }

        protected override void UnregisterCallbacks()
        {
            // do nothing, SDL uses event pumps like all windowing frameworks should do.
        }


        public override Point PointToClient(Point point)
        {
            int x, y;
            Sdl.GetWindowPosition(SdlWindow, &x, &y);
            return new Point(point.X - x, point.Y - y);
        }

        public override Point PointToScreen(Point point)
        {
            int x, y;
            Sdl.GetWindowPosition(SdlWindow, &x, &y);
            return new Point(point.X + x, point.Y + y);
        }

        [SuppressMessage("ReSharper", "SwitchStatementHandlesSomeKnownEnumValuesWithDefault")]
        public virtual void ProcessEvents()
        {
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
                                Resize?.Invoke(new Size(@event.Window.Data1, @event.Window.Data2));
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
        }
    }
}
