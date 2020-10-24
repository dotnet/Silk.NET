// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using Silk.NET.Core.Contexts;

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
    }
}
