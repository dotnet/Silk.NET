// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Runtime.InteropServices;
using Silk.NET.Core;
using Silk.NET.Core.Contexts;

namespace Silk.NET.OpenXR
{
    public static class NativeWindowExtensions
    {
        public static GraphicsBinding CreateOpenGLBinding<T>(this T src)
            where T : INativeWindowSource, IGLContextSource
        {
            if (src.Native is null || src.GLContext is null)
            {
                static void Throw() => throw new ArgumentException
                (
                    "The given window does not represent an active native window configured for OpenGL."
                );

                Throw();
            }

            return src.Native.CreateOpenGLBinding(src.GLContext);
        }

        public static GraphicsBinding CreateOpenGLBinding(this IGLContext ctx, INativeWindow window)
            => window.CreateOpenGLBinding(ctx);

        public static unsafe GraphicsBinding CreateOpenGLBinding(this INativeWindow window, IGLContext context)
        {
            if (!context.IsCurrent)
            {
                context.MakeCurrent();
            }

            if (window.Wayland is not null)
            {
                return new GraphicsBindingOpenGLWaylandKHR(display: (nint*) window.Wayland.Value.Display);
            }

            if (window.Win32 is not null)
            {
                return new GraphicsBindingOpenGLWin32KHR
                (
                    hDC: window.Win32.Value.HDC,
                    hGlrc: ((delegate* unmanaged[Cdecl]<nint>) context.GetProcAddress("wglGetCurrentContext"))()
                );
            }

            if (window.X11 is not null)
            {
                return new GraphicsBindingOpenGLXlibKHR
                (
                    xDisplay: (nint*) window.X11.Value.Display,
                    glxDrawable: ((delegate* unmanaged[Cdecl]<nint>) context.GetProcAddress("glXGetCurrentDrawable"))(),
                    glxContext: ((delegate* unmanaged[Cdecl]<nint>) context.GetProcAddress("glXGetCurrentContext"))()
                );
            }

            static void Throw() => throw new NotSupportedException
            (
                "Unable to obtain graphics requirements for the given native window."
            );

            Throw();
            return default;
        }
        
        public static GraphicsBinding CreateOpenGLESBinding<T>(this T src)
            where T : INativeWindowSource, IGLContextSource
        {
            if (src.Native is null || src.GLContext is null)
            {
                static void Throw() => throw new ArgumentException
                (
                    "The given window does not represent an active native window configured for OpenGL."
                );

                Throw();
            }

            return src.Native.CreateOpenGLESBinding(src.GLContext);
        }

        public static GraphicsBinding CreateOpenGLESBinding(this IGLContext ctx, INativeWindow window)
            => window.CreateOpenGLESBinding(ctx);

        public static unsafe GraphicsBinding CreateOpenGLESBinding(this INativeWindow window, IGLContext context)
        {
            if (!context.IsCurrent)
            {
                context.MakeCurrent();
            }

            if (window.Android is not null)
            {
                const int configId = 0x3028;
                int config;
                var dpy = ((delegate* unmanaged[Cdecl]<nint>) context.GetProcAddress("eglGetCurrentDisplay"))();
                var surface = window.Android.Value.Surface;

                ((delegate* unmanaged[Cdecl]<nint, nint, int, int*, Bool32>) context.GetProcAddress("eglQuerySurface"))
                    (dpy, surface, configId, &config);

                var getConfigs = (delegate* unmanaged[Cdecl]<nint, nint*, int, int*, Bool32>) context.GetProcAddress
                    ("eglGetConfigs");
                var getConfigAttrib = (delegate* unmanaged[Cdecl]<nint, nint, int, int*, Bool32>) context.GetProcAddress
                    ("eglGetConfigAttrib");
                int numConfigs;
                getConfigs(dpy, null, 0, &numConfigs);

                var configs = numConfigs > 512 / sizeof(nint) ? new nint[numConfigs] : stackalloc nint[numConfigs];

                fixed (nint* configPtr = configs)
                {
                    getConfigs(dpy, configPtr, numConfigs, &numConfigs);
                }

                nint theConfig = 0;
                for (var i = 0; i < numConfigs; i++)
                {
                    int thisConfig;
                    getConfigAttrib(dpy, configs[i], configId, &thisConfig);
                    if (thisConfig == config)
                    {
                        theConfig = configs[i];
                    }
                }

                return new GraphicsBindingOpenGLESAndroidKHR
                (
                    display: dpy,
                    context: ((delegate* unmanaged[Cdecl]<nint>) context.GetProcAddress("eglGetCurrentContext"))(),
                    config: theConfig
                );
            }

            static void Throw() => throw new NotSupportedException
            (
                "Unable to obtain graphics requirements for the given native window."
            );

            Throw();
            return default;
        }
    }
}
