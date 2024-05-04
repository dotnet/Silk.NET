// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using Silk.NET.Core;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Native;
using Silk.NET.Maths;
using Silk.NET.SDL;
using Point = System.Drawing.Point;
using RawImage = Silk.NET.Core.RawImage;
using Size = System.Drawing.Size;

namespace Silk.NET.Windowing.Sdl
{
    internal unsafe class SdlWindow : SdlView, IWindow
    {
        private WindowOptions _extendedOptionsCache;
        private List<string> _droppedFiles = new();

        public SdlWindow(WindowOptions opts, SdlView? parent, SdlMonitor? monitor, SdlPlatform platform)
            : base(new ViewOptions(opts), parent, monitor, platform)
        {
            _extendedOptionsCache = opts;
            WindowClass = opts.WindowClass ?? Window.DefaultWindowClass;
        }

        public SdlWindow(void* nativeHandle, IGLContext? ctx, SdlPlatform platform) : base(nativeHandle, ctx, platform)
        {
        }

        public bool IsVisible
        {
            get => !IsInitialized
                ? _extendedOptionsCache.IsVisible
                : _extendedOptionsCache.IsVisible =
                    ((WindowFlags) Sdl.GetWindowFlags(SdlWindow) & WindowFlags.WindowShown) != 0;
            set
            {
                _extendedOptionsCache.IsVisible = value;
                if (!IsInitialized)
                {
                    return;
                }

                if (value)
                {
                    Sdl.ShowWindow(SdlWindow);
                }
                else
                {
                    Sdl.HideWindow(SdlWindow);
                }
            }
        }

        public Vector2D<int> Position
        {
            get
            {
                if (IsInitialized)
                {
                    var ret = stackalloc int[2];
                    Sdl.GetWindowPosition(SdlWindow, ret, &ret[1]);
                    return _extendedOptionsCache.Position = *(Vector2D<int>*) ret;
                }

                return _extendedOptionsCache.Position;
            }
            set
            {
                _extendedOptionsCache.Position = value;
                if (!IsInitialized)
                {
                    return;
                }

                Sdl.SetWindowPosition(SdlWindow, value.X, value.Y);
            }
        }

        public new Vector2D<int> Size
        {
            get => IsInitialized ? _extendedOptionsCache.Size = base.Size : _extendedOptionsCache.Size;
            set
            {
                _extendedOptionsCache.Size = value;
                if (!IsInitialized)
                {
                    return;
                }

                Sdl.SetWindowSize(SdlWindow, value.X, value.Y);
            }
        }

        public string Title
        {
            get => IsInitialized
                ? _extendedOptionsCache.Title = Sdl.GetWindowTitleS(SdlWindow)
                : _extendedOptionsCache.Title;
            set
            {
                _extendedOptionsCache.Title = value;
                if (!IsInitialized)
                {
                    return;
                }

                Sdl.SetWindowTitle(SdlWindow, value);
            }
        }

        public WindowState WindowState
        {
            get => IsInitialized
                ? _extendedOptionsCache.WindowState = ToWindowState((WindowFlags) Sdl.GetWindowFlags(SdlWindow))
                : _extendedOptionsCache.WindowState;
            set
            {
                _swapIntervalChanged = true;
                _extendedOptionsCache.WindowState = value;
                if (!IsInitialized)
                {
                    return;
                }

                switch (value)
                {
                    case WindowState.Normal:
                    {
                        Sdl.RestoreWindow(SdlWindow);
                        break;
                    }
                    case WindowState.Minimized:
                    {
                        Sdl.MinimizeWindow(SdlWindow);
                        break;
                    }
                    case WindowState.Maximized:
                    {
                        Sdl.MaximizeWindow(SdlWindow);
                        break;
                    }
                    case WindowState.Fullscreen:
                    {
                        Sdl.SetWindowFullscreen(SdlWindow, (uint) WindowFlags.WindowFullscreen);
                        break;
                    }
                    default:
                    {
                        throw new ArgumentOutOfRangeException(nameof(value), value, null);
                    }
                }
            }
        }

        public WindowBorder WindowBorder
        {
            get => IsInitialized
                ? _extendedOptionsCache.WindowBorder = ToWindowBorder((WindowFlags) Sdl.GetWindowFlags(SdlWindow))
                : _extendedOptionsCache.WindowBorder;
            set
            {
                _extendedOptionsCache.WindowBorder = value;
                if (!IsInitialized)
                {
                    return;
                }

                switch (value)
                {
                    case WindowBorder.Resizable:
                    {
                        Sdl.SetWindowBordered(SdlWindow, SdlBool.True);
                        Sdl.SetWindowResizable(SdlWindow, SdlBool.True);
                        break;
                    }
                    case WindowBorder.Fixed:
                    {
                        Sdl.SetWindowBordered(SdlWindow, SdlBool.True);
                        Sdl.SetWindowResizable(SdlWindow, SdlBool.False);
                        break;
                    }
                    case WindowBorder.Hidden:
                    {
                        Sdl.SetWindowBordered(SdlWindow, SdlBool.False);
                        Sdl.SetWindowResizable(SdlWindow, SdlBool.False);
                        break;
                    }
                    default:
                    {
                        throw new ArgumentOutOfRangeException(nameof(value), value, null);
                    }
                }
            }
        }

        public string? WindowClass { get; }

        public unsafe Rectangle<int> BorderSize
        {
            get
            {
                int l = 0, t = 0, r = 0, b = 0;
                Sdl.GetWindowBordersSize(SdlWindow, ref t, ref l, ref b, ref r);
                return new Rectangle<int>(new(l, t), new(r - l, b - t));
            }
        }

        public bool TransparentFramebuffer => false; // doesn't look like SDL doesn't support this
        
        public bool TopMost
        {
            get => _extendedOptionsCache.TopMost;
            set
            {
                Sdl.SetWindowAlwaysOnTop(SdlWindow, value ? SdlBool.True : SdlBool.False);
                _extendedOptionsCache.TopMost = value;
            }
        }

        public IGLContext? SharedContext => _extendedOptionsCache.SharedContext;

        public IWindow CreateWindow(WindowOptions opts) => new SdlWindow(opts, this, null, _platform);

        public IWindowHost? Parent => (IWindowHost?) ParentView ?? Monitor;

        public IMonitor? Monitor
        {
            get
            {
                if (!IsInitialized)
                {
                    return InitialMonitor;
                }

                var monitor = Sdl.GetWindowDisplayIndex(SdlWindow);
                if (monitor < 0)
                {
                    if (WindowState != WindowState.Fullscreen)
                    {
                        var monitors = Sdl.GetNumVideoDisplays();
                        if (monitors < 0)
                        {
                            throw new PlatformException(Sdl.GetErrorAsException());
                        }

                        // Determine which monitor this window is on. [6 marks]
                        for (var i = 0; i < monitors; i++)
                        {
                            var pos = Position;
                            var size = Size;
                            Rectangle<int> bounds;
                            Sdl.GetDisplayUsableBounds(i, &bounds);
                            if (bounds.Contains(new Vector2D<int>(pos.X + size.X / 2, pos.Y + size.Y / 2)))
                            {
                                return new SdlMonitor(_platform, i);
                            }
                        }
                    }
                }

                return monitor < 0
                    ? (IMonitor?) null
                    : new SdlMonitor(_platform, monitor);
            }
            set
            {
                _swapIntervalChanged = true;
                if (!IsInitialized)
                {
                    throw new InvalidOperationException("Window is not initialized.");
                }

                if (value is null)
                {
                    throw new ArgumentNullException(nameof(value));
                }

                Position = value.Bounds.Origin;
            }
        }

        public new bool IsClosing
        {
            get => base.IsClosing;
            set => IsClosingVal = value;
        }

        public event Action<Vector2D<int>>? Move;
        public event Action<WindowState>? StateChanged;
        public event Action<string[]>? FileDrop;

        public void SetWindowIcon(ReadOnlySpan<RawImage> icons)
        {
            var icon = icons[0];
            var surface = Sdl.CreateRGBSurfaceFrom
            (
                icon.Pixels.Span, icon.Width, icon.Height, 32, icon.Width * 4, 0xff000000, 0x00ff0000, 0x0000ff00,
                0x000000ff
            );
            Sdl.SetWindowIcon(SdlWindow, surface);
            Sdl.FreeSurface(surface);
        }

        private static WindowState ToWindowState(WindowFlags flags)
        {
            if ((flags & (WindowFlags.WindowFullscreen | WindowFlags.WindowFullscreenDesktop)) != 0)
            {
                return WindowState.Fullscreen;
            }

            if ((flags & WindowFlags.WindowMaximized) != 0)
            {
                return WindowState.Maximized;
            }

            if ((flags & WindowFlags.WindowMinimized) != 0)
            {
                return WindowState.Minimized;
            }

            return WindowState.Normal;
        }

        private static WindowBorder ToWindowBorder(WindowFlags flags)
        {
            if ((flags & WindowFlags.WindowResizable) != 0)
            {
                return WindowBorder.Resizable;
            }

            return (flags & WindowFlags.WindowBorderless) != 0
                ? WindowBorder.Hidden
                : WindowBorder.Fixed;
        }

        [SuppressMessage("ReSharper", "SwitchStatementHandlesSomeKnownEnumValuesWithDefault")]
        public override void ProcessEvents()
        {
            base.ProcessEvents();
            var i = 0;
            var c = Events.Count;
            for (var j = 0; j < c; j++)
            {
                var @event = Events[i];
                var skipped = false;
                switch ((EventType) @event.Type)
                {
                    case EventType.Windowevent:
                    {
                        switch ((WindowEventID) @event.Window.Event)
                        {
                            //case WindowEventID.WindoweventNone:
                            //    break;
                            //case WindowEventID.WindoweventShown:
                            //    break;
                            //case WindowEventID.WindoweventHidden:
                            //    break;
                            //case WindowEventID.WindoweventExposed:
                            //    break;
                            case WindowEventID.WindoweventMoved:
                            {
                                Move?.Invoke(new Vector2D<int>(@event.Window.Data1, @event.Window.Data2));
                                break;
                            }
                            case WindowEventID.WindoweventResized:
                                break;
                            case WindowEventID.WindoweventSizeChanged:
                                break;
                            case WindowEventID.WindoweventMinimized:
                            {
                                StateChanged?.Invoke(WindowState.Minimized);
                                break;
                            }
                            case WindowEventID.WindoweventMaximized:
                            {
                                StateChanged?.Invoke(WindowState.Maximized);
                                break;
                            }
                            case WindowEventID.WindoweventRestored:
                            {
                                StateChanged?.Invoke(WindowState.Normal);
                                break;
                            }
                            //case WindowEventID.WindoweventEnter:
                            //    break;
                            //case WindowEventID.WindoweventLeave:
                            //    break;
                            //case WindowEventID.WindoweventHitTest:
                            //    break;
                            default:
                            {
                                i++;
                                skipped = true;
                                break;
                            }
                        }

                        break;
                    }
                    case EventType.Dropfile:
                    {
                        string path = SilkMarshal.PtrToString((nint) @event.Drop.File, NativeStringEncoding.UTF8) ?? "";
                        _droppedFiles.Add(path);
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

            if (_droppedFiles.Count > 0)
            {
                FileDrop?.Invoke(_droppedFiles.ToArray());
                _droppedFiles.Clear();
            }
        }

        protected override void CoreInitialize(ViewOptions opts)
        {
            _swapIntervalChanged = true;
            Sdl.Setenv("SDL_VIDEO_X11_WMCLASS", WindowClass, 1);

            WindowFlags flags = 0;
            flags |= IsVisible ? WindowFlags.WindowShown : WindowFlags.WindowHidden;
            flags |= WindowBorder switch
            {
                WindowBorder.Resizable => WindowFlags.WindowResizable,
                WindowBorder.Fixed => 0,
                WindowBorder.Hidden => WindowFlags.WindowBorderless,
                _ => 0
            };
            flags |= WindowState switch
            {
                WindowState.Normal => 0,
                WindowState.Minimized => WindowFlags.WindowMinimized,
                WindowState.Maximized => WindowFlags.WindowMaximized,
                WindowState.Fullscreen => WindowFlags.WindowFullscreen,
                _ => 0
            };
            CoreInitialize
            (
                opts, flags, (InitialMonitor?.Bounds.Origin.X ?? 0) + _extendedOptionsCache.Position.X,
                (InitialMonitor?.Bounds.Origin.Y ?? 0) + _extendedOptionsCache.Position.Y, Size.X, Size.Y, Title, SharedContext
            );
        }
    }
}
