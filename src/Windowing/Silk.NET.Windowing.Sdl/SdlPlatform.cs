// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Silk.NET.Core;
using Silk.NET.Core.Contexts;
using Silk.NET.SDL;
using Silk.NET.Windowing;
using Silk.NET.Windowing.Sdl;

[assembly: WindowPlatform(typeof(SdlPlatform))]

namespace Silk.NET.Windowing.Sdl
{
    internal class SdlPlatform : IWindowPlatform
    {
        private SdlView? _view;
        private List<Event> _eventBuffer = new();
        private BreakneckLock _lock = BreakneckLock.Create();
        public static SdlPlatform GetOrRegister()
        {
            var val = Window.GetOrDefault<SdlPlatform>();
            if (val is null)
            {
                Window.Add(val = new SdlPlatform());
            }

            return val;
        }

        private Lazy<bool> _isApplicable = new Lazy<bool>
        (
            () =>
            {
                SDL.Sdl? api = null;
                try
                {
                    api = SDL.Sdl.GetApi();
                }
                catch (Exception ex)
                {
#if DEBUG
                    Console.WriteLine($"Can't load SDL: {ex}");
#endif
                    return false;
                }
                finally
                {
                    api?.Dispose();
                }

                return true;
            }
        );

        public unsafe IWindow CreateWindow(WindowOptions opts)
        {
            if (!IsApplicable)
            {
                ThrowUnsupported();
                return null!;
            }

            if (IsViewOnly)
            {
                throw new PlatformNotSupportedException("Platform is view-only.");
            }

            return (SdlWindow)(_view = new SdlWindow(opts, null, null, this));
        }

        string Name => nameof(SdlPlatform);

        public bool IsViewOnly => IsApplicable && SdlProvider.UninitializedSDL.Value.GetPlatformS() switch
        {
            "Windows" => false,
            "Mac OS X" => false,
            "Linux" => false,
            _ => true
        };

        public bool IsApplicable => _isApplicable.Value;
        public event Action<List<Event>>? EventReceived;

        public IView GetView(ViewOptions? opts = null)
        {
            if (!IsApplicable)
            {
                ThrowUnsupported();
                return null!;
            }

            return opts switch
            {
                null when _view is null => throw new InvalidOperationException
                (
                    "No view has been created prior to this call, and couldn't " +
                    "create one due to no view options being provided."
                ),
                null => _view!,
                _ => IsViewOnly
                    ? _view ??= new SdlView(opts!.Value, null, null, this)
                    : _view = (SdlView) CreateWindow(new WindowOptions(opts!.Value))
            };
        }

        public unsafe void ClearContexts()
        {
            if (!IsApplicable)
            {
                ThrowUnsupported();
                return;
            }
            
            var sdl = SdlProvider.SDL.Value;
            sdl.GLMakeCurrent(sdl.GLGetCurrentWindow(), null);
        }

        public IEnumerable<IMonitor> GetMonitors()
        {
            if (!IsApplicable)
            {
                ThrowUnsupported();
                yield break;
            }

            for (var i = 0; i < SdlProvider.SDL.Value.GetNumVideoDisplays(); i++)
            {
                yield return new SdlMonitor(this, i);
            }
        }

        public IMonitor GetMainMonitor()
        {
            if (!IsApplicable)
            {
                ThrowUnsupported();
                return null!;
            }
            
            return new SdlMonitor(this, 0);
        }

        private void ThrowUnsupported()
            => throw new PlatformNotSupportedException("SDL not supported on this platform");

        public bool IsSourceOfView(IView view) => view is SdlView;

        public unsafe SdlView From(void* handle, IGLContext? ctx)
            => IsViewOnly ? new SdlView(handle, ctx, this) : new SdlWindow(handle, ctx, this);

        public unsafe void DoEvents()
        {
            var taken = false;
            _lock.TryEnter(ref taken);
            if (!taken)
            {
                return;
            }
            
            Event @event;
            while (SdlProvider.SDL.Value.PollEvent(&@event) == 1)
            {
                _eventBuffer.Add(@event);
            }
            
            EventReceived?.Invoke(_eventBuffer);
            _eventBuffer.Clear();
            if (taken)
            {
                _lock.Exit();
            }
        }
    }
}
