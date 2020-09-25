// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Silk.NET.SDL;
using Silk.NET.Windowing;
using Silk.NET.Windowing.Sdl;

[assembly: WindowPlatform(typeof(SdlPlatform))]

namespace Silk.NET.Windowing.Sdl
{
    internal class SdlPlatform : IWindowPlatform
    {
        private SdlView? _view;

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
            if (IsViewOnly)
            {
                throw new PlatformNotSupportedException("Platform is view-only.");
            }

            return new SdlWindow(opts, null, null);
        }

        public bool IsViewOnly => IsApplicable && SdlProvider.SDL.Value.GetPlatformS() switch
        {
            "Windows" => false,
            "Mac OS X" => false,
            "Linux" => false,
            _ => true
        };

        public bool IsApplicable => _isApplicable.Value;

        public IView GetView(ViewOptions? opts = null)
        {
            if (!IsApplicable)
            {
                throw new PlatformNotSupportedException();
            }

            if (opts is null && _view is null)
            {
                throw new InvalidOperationException
                (
                    "No view has been created prior to this call, and couldn't " +
                    "create one due to no view options being provided."
                );
            }

            return IsViewOnly
                ? _view ??= new SdlView(opts!.Value, null, null)
                : _view ??= (SdlView) CreateWindow(new WindowOptions(opts!.Value));
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
                yield return new SdlMonitor(i);
            }
        }

        public IMonitor GetMainMonitor() => new SdlMonitor(0);
        public bool IsSourceOfView(IView view) => view is SdlView;
    }
}
