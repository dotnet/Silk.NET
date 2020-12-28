// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

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
        private SDL.Sdl _sdl = SdlProvider.SDL.Value;
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
                try
                {
                    SDL.Sdl.GetApi();
                }
                catch (Exception ex)
                {
#if DEBUG
                    Console.WriteLine($"Can't load SDL: {ex}");
#endif
                    return false;
                }

                return true;
            }
        );

        public unsafe IWindow CreateWindow(WindowOptions opts)
        {
            if (!IsApplicable)
            {
                throw new PlatformNotSupportedException();
            }

            if (IsViewOnly)
            {
                throw new PlatformNotSupportedException("Platform is view-only.");
            }

            return (SdlWindow)(_view = new SdlWindow(opts, null, null, this));
        }

        public bool IsViewOnly => IsApplicable && SdlProvider.SDL.Value.GetPlatformS() switch
        {
            "Windows" => false,
            "Mac OS X" => false,
            "Linux" => false,
            _ => true
        };

        public bool IsApplicable => _isApplicable.Value;
        public event Action<IEnumerable<Event>>? EventReceived;

        public IView GetView(ViewOptions? opts = null)
        {
            if (!IsApplicable)
            {
                throw new PlatformNotSupportedException();
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
            var sdl = SdlProvider.SDL.Value;
            sdl.GLMakeCurrent(sdl.GLGetCurrentWindow(), null);
        }

        public IEnumerable<IMonitor> GetMonitors()
        {
            for (var i = 0; i < SdlProvider.SDL.Value.GetNumVideoDisplays(); i++)
            {
                yield return new SdlMonitor(this, i);
            }
        }

        public IMonitor GetMainMonitor() => new SdlMonitor(this, 0);
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
            while (_sdl.PollEvent(&@event) == 1)
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
