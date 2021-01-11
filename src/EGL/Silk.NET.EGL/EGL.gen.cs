// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.EGL
{
    public unsafe partial class EGL : NativeAPI
    {

        [NativeApi(EntryPoint = "eglClientWaitSync")]
        public partial int ClientWaitSync([Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint sync, [Flow(FlowDirection.In)] int flags, [Flow(FlowDirection.In)] ulong timeout);

        [NativeApi(EntryPoint = "eglCreateImage")]
        public unsafe partial nint CreateImage([Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint ctx, [Flow(FlowDirection.In)] EGLEnum target, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] nint* attrib_list);

        [NativeApi(EntryPoint = "eglCreateImage")]
        public partial nint CreateImage([Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint ctx, [Flow(FlowDirection.In)] EGLEnum target, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] in nint attrib_list);

        [NativeApi(EntryPoint = "eglCreatePlatformPixmapSurface")]
        public unsafe partial nint CreatePlatformPixmapSurface([Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint config, [Flow(FlowDirection.Out)] void* native_pixmap, [Flow(FlowDirection.In)] nint* attrib_list);

        [NativeApi(EntryPoint = "eglCreatePlatformPixmapSurface")]
        public unsafe partial nint CreatePlatformPixmapSurface([Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint config, [Flow(FlowDirection.Out)] void* native_pixmap, [Flow(FlowDirection.In)] in nint attrib_list);

        [NativeApi(EntryPoint = "eglCreatePlatformPixmapSurface")]
        public unsafe partial nint CreatePlatformPixmapSurface<T0>([Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint config, [Flow(FlowDirection.Out)] out T0 native_pixmap, [Flow(FlowDirection.In)] nint* attrib_list) where T0 : unmanaged;

        [NativeApi(EntryPoint = "eglCreatePlatformPixmapSurface")]
        public partial nint CreatePlatformPixmapSurface<T0>([Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint config, [Flow(FlowDirection.Out)] out T0 native_pixmap, [Flow(FlowDirection.In)] in nint attrib_list) where T0 : unmanaged;

        [NativeApi(EntryPoint = "eglCreatePlatformWindowSurface")]
        public unsafe partial nint CreatePlatformWindowSurface([Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint config, [Flow(FlowDirection.Out)] void* native_window, [Flow(FlowDirection.In)] nint* attrib_list);

        [NativeApi(EntryPoint = "eglCreatePlatformWindowSurface")]
        public unsafe partial nint CreatePlatformWindowSurface([Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint config, [Flow(FlowDirection.Out)] void* native_window, [Flow(FlowDirection.In)] in nint attrib_list);

        [NativeApi(EntryPoint = "eglCreatePlatformWindowSurface")]
        public unsafe partial nint CreatePlatformWindowSurface<T0>([Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint config, [Flow(FlowDirection.Out)] out T0 native_window, [Flow(FlowDirection.In)] nint* attrib_list) where T0 : unmanaged;

        [NativeApi(EntryPoint = "eglCreatePlatformWindowSurface")]
        public partial nint CreatePlatformWindowSurface<T0>([Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint config, [Flow(FlowDirection.Out)] out T0 native_window, [Flow(FlowDirection.In)] in nint attrib_list) where T0 : unmanaged;

        [NativeApi(EntryPoint = "eglCreateSync")]
        public unsafe partial nint CreateSync([Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] EGLEnum type, [Flow(FlowDirection.In)] nint* attrib_list);

        [NativeApi(EntryPoint = "eglCreateSync")]
        public partial nint CreateSync([Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] EGLEnum type, [Flow(FlowDirection.In)] in nint attrib_list);

        [NativeApi(EntryPoint = "eglDestroyImage")]
        public partial int DestroyImage([Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint image);

        [NativeApi(EntryPoint = "eglDestroySync")]
        public partial int DestroySync([Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint sync);

        [NativeApi(EntryPoint = "eglGetPlatformDisplay")]
        public unsafe partial nint GetPlatformDisplay([Flow(FlowDirection.In)] EGLEnum platform, [Flow(FlowDirection.Out)] void* native_display, [Flow(FlowDirection.In)] nint* attrib_list);

        [NativeApi(EntryPoint = "eglGetPlatformDisplay")]
        public unsafe partial nint GetPlatformDisplay([Flow(FlowDirection.In)] EGLEnum platform, [Flow(FlowDirection.Out)] void* native_display, [Flow(FlowDirection.In)] in nint attrib_list);

        [NativeApi(EntryPoint = "eglGetPlatformDisplay")]
        public unsafe partial nint GetPlatformDisplay<T0>([Flow(FlowDirection.In)] EGLEnum platform, [Flow(FlowDirection.Out)] out T0 native_display, [Flow(FlowDirection.In)] nint* attrib_list) where T0 : unmanaged;

        [NativeApi(EntryPoint = "eglGetPlatformDisplay")]
        public partial nint GetPlatformDisplay<T0>([Flow(FlowDirection.In)] EGLEnum platform, [Flow(FlowDirection.Out)] out T0 native_display, [Flow(FlowDirection.In)] in nint attrib_list) where T0 : unmanaged;

        [NativeApi(EntryPoint = "eglGetSyncAttrib")]
        public unsafe partial int GetSyncAttrib([Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint sync, [Flow(FlowDirection.In)] int attribute, [Flow(FlowDirection.Out)] nint* value);

        [NativeApi(EntryPoint = "eglGetSyncAttrib")]
        public partial int GetSyncAttrib([Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint sync, [Flow(FlowDirection.In)] int attribute, [Flow(FlowDirection.Out)] out nint value);

        [NativeApi(EntryPoint = "eglWaitSync")]
        public partial int WaitSync([Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint sync, [Flow(FlowDirection.In)] int flags);

        [NativeApi(EntryPoint = "eglGetCurrentContext")]
        public partial nint GetCurrentContext();

        [NativeApi(EntryPoint = "eglBindAPI")]
        public partial int BindApi([Flow(FlowDirection.In)] EGLEnum api);

        [NativeApi(EntryPoint = "eglCreatePbufferFromClientBuffer")]
        public unsafe partial nint CreatePbufferFromClientBuffer([Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] EGLEnum buftype, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] nint config, [Flow(FlowDirection.In)] int* attrib_list);

        [NativeApi(EntryPoint = "eglCreatePbufferFromClientBuffer")]
        public partial nint CreatePbufferFromClientBuffer([Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] EGLEnum buftype, [Flow(FlowDirection.In)] nint buffer, [Flow(FlowDirection.In)] nint config, [Flow(FlowDirection.In)] in int attrib_list);

        [NativeApi(EntryPoint = "eglQueryAPI")]
        public partial EGLEnum QueryApi();

        [NativeApi(EntryPoint = "eglReleaseThread")]
        public partial int ReleaseThread();

        [NativeApi(EntryPoint = "eglWaitClient")]
        public partial int WaitClient();

        [NativeApi(EntryPoint = "eglBindTexImage")]
        public partial int BindTexImage([Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint surface, [Flow(FlowDirection.In)] int buffer);

        [NativeApi(EntryPoint = "eglReleaseTexImage")]
        public partial int ReleaseTexImage([Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint surface, [Flow(FlowDirection.In)] int buffer);

        [NativeApi(EntryPoint = "eglSurfaceAttrib")]
        public partial int SurfaceAttrib([Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint surface, [Flow(FlowDirection.In)] int attribute, [Flow(FlowDirection.In)] int value);

        [NativeApi(EntryPoint = "eglSwapInterval")]
        public partial int SwapInterval([Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] int interval);

        [NativeApi(EntryPoint = "eglChooseConfig")]
        public unsafe partial int ChooseConfig([Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] int* attrib_list, [Flow(FlowDirection.Out)] nint* configs, [Flow(FlowDirection.In)] int config_size, [Flow(FlowDirection.Out)] int* num_config);

        [NativeApi(EntryPoint = "eglChooseConfig")]
        public unsafe partial int ChooseConfig([Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] int* attrib_list, [Flow(FlowDirection.Out)] nint* configs, [Flow(FlowDirection.In)] int config_size, [Flow(FlowDirection.Out)] out int num_config);

        [NativeApi(EntryPoint = "eglChooseConfig")]
        public unsafe partial int ChooseConfig([Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] int* attrib_list, [Flow(FlowDirection.Out)] out nint configs, [Flow(FlowDirection.In)] int config_size, [Flow(FlowDirection.Out)] int* num_config);

        [NativeApi(EntryPoint = "eglChooseConfig")]
        public unsafe partial int ChooseConfig([Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] int* attrib_list, [Flow(FlowDirection.Out)] out nint configs, [Flow(FlowDirection.In)] int config_size, [Flow(FlowDirection.Out)] out int num_config);

        [NativeApi(EntryPoint = "eglChooseConfig")]
        public unsafe partial int ChooseConfig([Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] in int attrib_list, [Flow(FlowDirection.Out)] nint* configs, [Flow(FlowDirection.In)] int config_size, [Flow(FlowDirection.Out)] int* num_config);

        [NativeApi(EntryPoint = "eglChooseConfig")]
        public unsafe partial int ChooseConfig([Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] in int attrib_list, [Flow(FlowDirection.Out)] nint* configs, [Flow(FlowDirection.In)] int config_size, [Flow(FlowDirection.Out)] out int num_config);

        [NativeApi(EntryPoint = "eglChooseConfig")]
        public unsafe partial int ChooseConfig([Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] in int attrib_list, [Flow(FlowDirection.Out)] out nint configs, [Flow(FlowDirection.In)] int config_size, [Flow(FlowDirection.Out)] int* num_config);

        [NativeApi(EntryPoint = "eglChooseConfig")]
        public partial int ChooseConfig([Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] in int attrib_list, [Flow(FlowDirection.Out)] out nint configs, [Flow(FlowDirection.In)] int config_size, [Flow(FlowDirection.Out)] out int num_config);

        [NativeApi(EntryPoint = "eglCopyBuffers")]
        public partial int CopyBuffers([Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint surface, [Flow(FlowDirection.In)] nint target);

        [NativeApi(EntryPoint = "eglCreateContext")]
        public unsafe partial nint CreateContext([Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint config, [Flow(FlowDirection.In)] nint share_context, [Flow(FlowDirection.In)] int* attrib_list);

        [NativeApi(EntryPoint = "eglCreateContext")]
        public partial nint CreateContext([Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint config, [Flow(FlowDirection.In)] nint share_context, [Flow(FlowDirection.In)] in int attrib_list);

        [NativeApi(EntryPoint = "eglCreatePbufferSurface")]
        public unsafe partial nint CreatePbufferSurface([Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint config, [Flow(FlowDirection.In)] int* attrib_list);

        [NativeApi(EntryPoint = "eglCreatePbufferSurface")]
        public partial nint CreatePbufferSurface([Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint config, [Flow(FlowDirection.In)] in int attrib_list);

        [NativeApi(EntryPoint = "eglCreatePixmapSurface")]
        public unsafe partial nint CreatePixmapSurface([Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint config, [Flow(FlowDirection.In)] nint pixmap, [Flow(FlowDirection.In)] int* attrib_list);

        [NativeApi(EntryPoint = "eglCreatePixmapSurface")]
        public partial nint CreatePixmapSurface([Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint config, [Flow(FlowDirection.In)] nint pixmap, [Flow(FlowDirection.In)] in int attrib_list);

        [NativeApi(EntryPoint = "eglCreateWindowSurface")]
        public unsafe partial nint CreateWindowSurface([Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint config, [Flow(FlowDirection.In)] nint win, [Flow(FlowDirection.In)] int* attrib_list);

        [NativeApi(EntryPoint = "eglCreateWindowSurface")]
        public partial nint CreateWindowSurface([Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint config, [Flow(FlowDirection.In)] nint win, [Flow(FlowDirection.In)] in int attrib_list);

        [NativeApi(EntryPoint = "eglDestroyContext")]
        public partial int DestroyContext([Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint ctx);

        [NativeApi(EntryPoint = "eglDestroySurface")]
        public partial int DestroySurface([Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint surface);

        [NativeApi(EntryPoint = "eglGetConfigAttrib")]
        public unsafe partial int GetConfigAttrib([Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint config, [Flow(FlowDirection.In)] int attribute, [Flow(FlowDirection.Out)] int* value);

        [NativeApi(EntryPoint = "eglGetConfigAttrib")]
        public partial int GetConfigAttrib([Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint config, [Flow(FlowDirection.In)] int attribute, [Flow(FlowDirection.Out)] out int value);

        [NativeApi(EntryPoint = "eglGetConfigs")]
        public unsafe partial int GetConfigs([Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.Out)] nint* configs, [Flow(FlowDirection.In)] int config_size, [Flow(FlowDirection.Out)] int* num_config);

        [NativeApi(EntryPoint = "eglGetConfigs")]
        public unsafe partial int GetConfigs([Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.Out)] nint* configs, [Flow(FlowDirection.In)] int config_size, [Flow(FlowDirection.Out)] out int num_config);

        [NativeApi(EntryPoint = "eglGetConfigs")]
        public unsafe partial int GetConfigs([Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.Out)] out nint configs, [Flow(FlowDirection.In)] int config_size, [Flow(FlowDirection.Out)] int* num_config);

        [NativeApi(EntryPoint = "eglGetConfigs")]
        public partial int GetConfigs([Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.Out)] out nint configs, [Flow(FlowDirection.In)] int config_size, [Flow(FlowDirection.Out)] out int num_config);

        [NativeApi(EntryPoint = "eglGetCurrentDisplay")]
        public partial nint GetCurrentDisplay();

        [NativeApi(EntryPoint = "eglGetCurrentSurface")]
        public partial nint GetCurrentSurface([Flow(FlowDirection.In)] int readdraw);

        [NativeApi(EntryPoint = "eglGetDisplay")]
        public partial nint GetDisplay([Flow(FlowDirection.In)] nint display_id);

        [NativeApi(EntryPoint = "eglGetError")]
        public partial int GetError();

        [NativeApi(EntryPoint = "eglGetProcAddress")]
        public unsafe partial void* GetProcAddress([Flow(FlowDirection.In)] byte* procname);

        [NativeApi(EntryPoint = "eglGetProcAddress")]
        public unsafe partial void* GetProcAddress([Flow(FlowDirection.In)] in byte procname);

        [NativeApi(EntryPoint = "eglGetProcAddress")]
        public unsafe partial void* GetProcAddress([Flow(FlowDirection.In)] string procname);

        [NativeApi(EntryPoint = "eglInitialize")]
        public unsafe partial int Initialize([Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.Out)] int* major, [Flow(FlowDirection.Out)] int* minor);

        [NativeApi(EntryPoint = "eglInitialize")]
        public unsafe partial int Initialize([Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.Out)] int* major, [Flow(FlowDirection.Out)] out int minor);

        [NativeApi(EntryPoint = "eglInitialize")]
        public unsafe partial int Initialize([Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.Out)] out int major, [Flow(FlowDirection.Out)] int* minor);

        [NativeApi(EntryPoint = "eglInitialize")]
        public partial int Initialize([Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.Out)] out int major, [Flow(FlowDirection.Out)] out int minor);

        [NativeApi(EntryPoint = "eglMakeCurrent")]
        public partial int MakeCurrent([Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint draw, [Flow(FlowDirection.In)] nint read, [Flow(FlowDirection.In)] nint ctx);

        [NativeApi(EntryPoint = "eglQueryContext")]
        public unsafe partial int QueryContext([Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint ctx, [Flow(FlowDirection.In)] int attribute, [Flow(FlowDirection.Out)] int* value);

        [NativeApi(EntryPoint = "eglQueryContext")]
        public partial int QueryContext([Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint ctx, [Flow(FlowDirection.In)] int attribute, [Flow(FlowDirection.Out)] out int value);

        [NativeApi(EntryPoint = "eglQueryString")]
        public unsafe partial byte* QueryString([Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] int name);

        [NativeApi(EntryPoint = "eglQueryString")]
        public partial string QueryStringS([Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] int name);

        [NativeApi(EntryPoint = "eglQuerySurface")]
        public unsafe partial int QuerySurface([Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint surface, [Flow(FlowDirection.In)] int attribute, [Flow(FlowDirection.Out)] int* value);

        [NativeApi(EntryPoint = "eglQuerySurface")]
        public partial int QuerySurface([Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint surface, [Flow(FlowDirection.In)] int attribute, [Flow(FlowDirection.Out)] out int value);

        [NativeApi(EntryPoint = "eglSwapBuffers")]
        public partial int SwapBuffers([Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint surface);

        [NativeApi(EntryPoint = "eglTerminate")]
        public partial int Terminate([Flow(FlowDirection.In)] nint dpy);

        [NativeApi(EntryPoint = "eglWaitGL")]
        public partial int WaitGL();

        [NativeApi(EntryPoint = "eglWaitNative")]
        public partial int WaitNative([Flow(FlowDirection.In)] int engine);


        public EGL(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

