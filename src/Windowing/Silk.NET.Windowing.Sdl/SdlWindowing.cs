// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Silk.NET.Core.Contexts;
using Silk.NET.SDL;

namespace Silk.NET.Windowing.Sdl
{
    /// <summary>
    /// Contains utility methods for working with the SDL windowing backend.
    /// </summary>
    public static class SdlWindowing
    {
        /// <summary>
        /// Registers this platform with the <see cref="Window"/> class so that the <see cref="Window.Create"/> method
        /// may be used to create SDL windows.
        /// </summary>
        public static void RegisterPlatform() => SdlPlatform.GetOrRegister();

        /// <summary>
        /// Creates a <see cref="IView"/> from the given native handle using <see cref="SDL.Sdl.CreateWindowFrom"/>.
        /// </summary>
        /// <remarks>
        /// <para>
        /// The returned <see cref="IView" /> may also implement <see cref="IWindow"/>. To determine whether this is the
        /// case, use as <c>is</c> or <c>as</c> expression.
        /// </para>
        /// <para>
        /// SDL doesn't obtain context information from existing native window handles. As a result, if you'd like to
        /// use the returned <see cref="IView"/> as a <see cref="IGLContextSource"/> (or use any other windowing OpenGL
        /// features), you'll need to configure this window with a custom context. Pass a <see cref="IGLContext" /> into
        /// the ctx parameter to do this.
        /// </para>
        /// </remarks>
        /// <param name="handle">The native window handle to create a SDL view/window from.</param>
        /// <param name="ctx">The custom <see cref="IGLContext"/> wrapper over the existing OpenGL context.</param>
        /// <returns>
        /// A <see cref="IView" /> wrapper over the existing handle. May also implement <see cref="IWindow" />.
        /// </returns>
        public static unsafe IView CreateFrom(void* handle, IGLContext? ctx = null)
            => SdlPlatform.GetOrRegister().From(handle, ctx);

        /// <summary>
        /// Prioritizes the SDL windowing platform over others.
        /// </summary>
        public static void Use() => Window.PrioritizeOrAdd(() => new SdlPlatform(), true);

        /// <summary>
        /// Gets a value indicating whether the given view is an SDL view.
        /// </summary>
        /// <returns>Whether the given view is an SDL view.</returns>
        public static bool IsViewSdl(IView view) => view is SdlView;

        public static SDL.Sdl? GetExistingApi(IView view) => (view as SdlView)?.Sdl;

        public static unsafe SysWMInfo? GetSysWMInfo(IView view)
        {
            if (view is SdlView sdlView)
            {
                SysWMInfo ret;
                sdlView.Sdl.GetVersion(&ret.Version);
                if (sdlView.Sdl.GetWindowWMInfo(sdlView.SdlWindow, &ret))
                {
                    return ret;
                }
            }
            
            return null;
        }

        public static unsafe Silk.NET.SDL.Window* GetHandle(IView view)
            => view is SdlView sdlView ? sdlView.SdlWindow : null;
    }
}
